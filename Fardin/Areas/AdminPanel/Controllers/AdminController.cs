using System.Collections.Generic;
using Fardin.Core.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Fardin.DataLayer.Entites;
using Fardin.Core.Services.IServices;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Fardin.Areas.AdminPanel
{
    [Authorize]
    [Area("AdminPanel")]
    public class AdminController : Controller
    {
        #region Constructor and inject services
        private IAdminService _adminService;
        private IPostService _postService;
        private ICommentService _commentService;
        public AdminController(IAdminService adminService, IPostService postService, ICommentService commentService)
        {
            _adminService = adminService;
            _postService = postService;
            _commentService = commentService;
        }
        #endregion

        public IActionResult Index()
        {
            return View();
        }

        #region Login
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Login(bool? hasError)
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index");
            }
            if (hasError == true)
            {
                ViewBag.loginError = "your information was'nt valid";
            }
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public IActionResult Login(LoginViewModel login)
        {
            if (!ModelState.IsValid)
            {
                return View(login);
            }

            Fardin.DataLayer.Entites.AdminPanel admin = _adminService.returnAdmin(login.Username, login.Password);

            if (admin != null)
            {
                var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.NameIdentifier, admin.AdminPanelId.ToString()),
                    new Claim(ClaimTypes.Name, admin.Username)
                };
                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);
                HttpContext.SignInAsync(principal);
                return RedirectToAction("Index");
            }
            return Redirect("/AdminPanel/Admin/Login?hasError=true");
        }
        #endregion

        #region Logout
        [Route("Logout")]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("login");
        }

        #endregion

        #region Posting Section (Edit SubPost)
        public IActionResult Post(Post post,string lang, IFormFile PostImg)
        {
            bool isSuccess = _postService.addPost(post.Title, User.Identity.Name, post.SectionId, post.PostText,lang, PostImg);
            if (isSuccess)
            {
                return RedirectToAction("Index");
            }
            return View();
        }


        public IActionResult SubPosts(int PostId, string lang, SubPostEditViewModel SubPost, List<IFormFile> imageGallery)
        {
            bool isExist = _postService.isAnySubPost(SubPost.SubPostId);
            if (isExist)
            {
                _postService.updateSubPost(SubPost,lang);
                return RedirectToAction("EditPosts");
            }
            else
            {
                _postService.AddSubPost(PostId,lang, SubPost,imageGallery);
                return RedirectToAction("Index");
            }

        }
        public IActionResult detailOfPost(int SelectedDescriptionId, int SubPostId,string lang, string descriptionText, IFormFile image, List<IFormFile> imageGallery)
        {
            if (SelectedDescriptionId != 0)
            {
                _postService.updateSubPostDescription(SelectedDescriptionId, descriptionText,lang, image);
                return RedirectToAction("EditPosts");
            }
            else
            {
                _postService.addDescriptionOfSubPost(SubPostId, descriptionText,lang, image, imageGallery);
                return RedirectToAction("Index");
            }



        }
        #endregion

        #region Edit Post Section
        [HttpGet]
        public IActionResult EditPosts()
        {
            return View();
        }
        [HttpPost]
        public IActionResult EditPosts(int postId, int newSectionId, string Title, string PostText,string lang, IFormFile PostImg)
        {
            bool isSuccess = _postService.updatePost(postId, Title, User.Identity.Name, newSectionId, lang, PostText, PostImg);
            return View();
        }

        #endregion

        #region Delete posts
        [HttpGet]
        public IActionResult DeletePost()
        {
            return View(_postService.getDeletePostViewModels());
        }
        public IActionResult DeleteOnePost(int postId)
        {
            _postService.deletePost(postId);
            return RedirectToAction("DeletePost");
        }
        public IActionResult deleteSubPost(int id)
        {
            _postService.deleteSubPostById(id);
            return RedirectToAction("DeletePost");
        }
        public IActionResult deleteDescriptonOfDetail(int id)
        {
            _postService.deleteSubPostDescriptionById(id);
            return RedirectToAction("DeletePost");
        }
        #endregion

        #region Get Data With Ajax : JSON Result

    
        public IActionResult getPostsWithSectionId(int id)
        {
            return Json(new SelectList(_postService.GetPostsWithSectionIdForManageView(id), "Value", "Text"));
        }
        public IActionResult getSubPostWithSectionId(int id)
        {
            return Json(_postService.getSubPostsByPostId(id));
        }

        public IActionResult getPostWithPostId(int id)
        {
            Post post = _postService.getPostWithId(id);
            return Json(post);
        }
        public IActionResult getSubPost(int id)
        {
            return Json(_postService.getSubPostById(id));
        }
        public IActionResult getSubPostDescription(int id)
        {
            return Json(_postService.getSubPostDescriptionById(id));
        }
        public IActionResult getSubPostDescriptionBySubPostId(int id)
        {
            return Json(_postService.getSubPostDescriptionBySubPostId(id));
        }




        #endregion

        #region Comments and Contact Us Section
        [HttpGet]
        public IActionResult ManageComments()
        {
            return View(_commentService.getCommentsForManage());
        }
        public IActionResult DeleteComment(int id)
        {
            _commentService.deleteComment(id);
            return RedirectToAction("ManageComments");
        }
        public IActionResult ConfirmComment(int id,string lang)
        {
            _commentService.confirmComment(id,lang);
            return RedirectToAction("ManageComments");
        }
        public IActionResult CancelConfirm(int id)
        {
            _commentService.cancelConfirm(id);
            return RedirectToAction("ManageComments");
        }
        public IActionResult showContactusContents(bool isSuccess = false)
        {
            if (isSuccess)
                ViewBag.isSuccess = true;
            return View(_commentService.contacts());
        }
        public IActionResult DeleteContact(int id)
        {
            _commentService.DeleteContentUsMessage(id);
            return Redirect("/AdminPanel/Admin/showContactusContents?isSuccess=true");
        }



        #endregion

        #region Social Networks

        [HttpGet]
        public IActionResult SocialNetwork()
        {
            return View(_adminService.getSocialNetworks());
        }
        [HttpPost]
        public IActionResult SocialNetwork(SocialNetwork social)
        {
            _adminService.addSocialNetworks(social);
            return RedirectToAction("SocialNetwork");
        }
        #endregion

        #region Cover and Footer
        [HttpGet]
        public IActionResult StaticInformations()
        {
            return View(_postService.getSiteStaticInformation());
        }

        [HttpPost]
        public IActionResult StaticInformations(SiteStatic siteStatic, IFormFile footerpic, IFormFile coverpic,string lang)
        {
            if (siteStatic.SiteStaticId == 0)
                _postService.saveSiteStatic(siteStatic, coverpic, footerpic,lang);
            else
                _postService.updateSiteStatic(siteStatic, coverpic, footerpic,lang);

            return View(_postService.getSiteStaticInformation());
        }
        #endregion

        #region About
        [Route("About")]
        public IActionResult About()
        {
            return View(_adminService.getAbout());
        }
        [HttpPost]
        public IActionResult About(string aboutText)
        {
            _adminService.addAbout(aboutText);
            return View();
        }
        #endregion

        #region Change Password
        public IActionResult ChangePassword(bool? isSuccess)
        {
            ViewBag.isSuccess = isSuccess;
            return View();
        }
        [HttpPost]
        public IActionResult ChangePassword(ChangePasswordViewModel changePass)
        {
            try
            {
                _adminService.ChangePassword(changePass);
                return Redirect("/AdminPanel/Admin/ChangePassword?isSuccess=true");
            }
            catch (System.Exception)
            {
                return Redirect("/AdminPanel/Admin/ChangePassword?isSuccess=false");
            }
           
            
        }
        #endregion
    }
}