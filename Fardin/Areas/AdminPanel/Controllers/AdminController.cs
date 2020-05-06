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
        public IActionResult Post(int SectionId, string PostText, IFormFile PostImg)
        {
            bool isSuccess = _postService.addPost( User.Identity.Name,SectionId, PostText, PostImg);
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

    }
}