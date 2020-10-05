using System;
using Fardin.Core.DTO;
using Fardin.Core.Services.IServices;
using Fardin.DataLayer.Entites;
using Fardin.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace Fardin.Controllers
{
    public class HomeController : Controller
    {
        private IPostService _postService;
        private ICommentService _commentService;
        private IAdminService _adminService;

        public HomeController(IPostService postService, ICommentService commentService, IAdminService adminService)
        {
            _postService = postService;
            _commentService = commentService;
            _adminService = adminService;
        }
        [Route("/")]
        public IActionResult Index()
        {
            ViewBag.siteStatic = _postService.getSiteStaticInformation();
            var test = PasswordHelper.EncodePasswordMd5("123");
            return View(_postService.GetPosts());
        }
        [Route("aboutus")]
        public IActionResult About()
        {
            return View(_adminService.getAbout());
        }
        [Route("view/{id}")]
        public ActionResult ShowSubPost(int id)
        {
            return View(_postService.getSubPostsListByPostId(id));
        }
        [Route("detailDescription/{id}")]
        public IActionResult detailDescription(int id)
        {
            var description = _postService.getSubPostDescriptionById(id);
            return View(description);
        }
        [Route("Comments/{currentPage:int?}/{Success:bool?}")]
        [HttpGet]
        public IActionResult Comments(bool? Success,int currentPage)
        {
            if (Success == true)
                ViewBag.IsSuccess = Success;

            ViewBag.CommentListModel = _commentService.commentsPaging(currentPage);

            return View();
        }
        [HttpPost]
        [Route("Comments")]
        public IActionResult Comments(SubmitCommentViewModel comment)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.CommentListModel = _commentService.GetComments();
                return View(comment);
            }
           bool isSuccess = _commentService.AddComment(comment);
            if (isSuccess)
            {
                return Redirect("/Comments?Success=true");
            }
            else
            {
                return View(comment);
            }

        }

        public IActionResult ChangeLanguage(string culture)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions() { Expires = DateTimeOffset.UtcNow.AddYears(1) });

            return Redirect(Request.Headers["Referer"].ToString());
        }
        [HttpGet("contact-us")]
        public IActionResult ContactUs(bool isSuccess)
        {
            if (isSuccess)
                ViewBag.isSuccess = true;
            return View();
        }

        [HttpPost("contact-us")]
        public IActionResult ContactUs(ContactUs contact)
        {
            if (ModelState.IsValid)
            {
                _commentService.addContactUsContent(contact);
                return Redirect("/contact-us?isSuccess=true");
            }
            return View(contact);
        }

    }
}