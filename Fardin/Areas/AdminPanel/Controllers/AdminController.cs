using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fardin.Core.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Fardin.DataLayer.Entites;
using Fardin.Core.Services.IServices;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Fardin.Security;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Fardin.Areas.AdminPanel
{
    [Area("AdminPanel")]
    public class AdminController : Controller
    {
        private IAdminService _adminService;
        private IPostService _postService;
        public AdminController(IAdminService adminService, IPostService postService)
        {
            _adminService = adminService;
            _postService = postService;
        }
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

        #region Login
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
        [Authorize]
        [Route("Logout")]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("login");
        }

        #endregion

        #region Post Section
        [Authorize]
        public IActionResult Post(Post post, IFormFile PostImg)
        {
            bool isSuccess = _postService.addPost(post.Title, User.Identity.Name,post.SectionId, post.PostText, PostImg);
            if (isSuccess)
            {
                return RedirectToAction("Index");
            }
            return View();
        }


        [Authorize]
        public IActionResult PostDetails(int PostId, string postDetailsText, IFormFile image)
        {
            _postService.AddPostDetails(PostId, postDetailsText, image);
            return RedirectToAction("Index");
        }

        public IActionResult detailOfPost(int postDetailId, string DetailText, IFormFile image)
        {
            _postService.addDescriptionOfPostDetail(postDetailId, DetailText, image);
            return RedirectToAction("Index");
        }
        #endregion

        #region Edit Post Section
        [Authorize]
        [HttpGet]
        public IActionResult EditPosts()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        public IActionResult EditPosts(int postId,int newSectionId, string Title, string PostText, IFormFile PostImg)
        {
            bool isSuccess = _postService.updatePost(postId,Title, User.Identity.Name, newSectionId, PostText, PostImg);
            return View();
        }
        [Authorize]
        public IActionResult getPostsWithSectionId(int id)
        {
            List<SelectListItem> listItems = new List<SelectListItem>()
            {
                new SelectListItem()
                {
                    Text = "انتخاب کنید....",
                    Value = "0"
                }
            };
            listItems.AddRange(_postService.GetPostsWithSectionIdForManageView(id));
            return Json(new SelectList(listItems,"Value","Text"));       
        }
        [Authorize]

        public IActionResult getPostWithPostId(int id)
        {
            Post post = _postService.getPostWithId(id);
            return Json(post);
        }
        #endregion

    }
}