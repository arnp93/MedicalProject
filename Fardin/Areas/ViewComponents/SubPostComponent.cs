using Fardin.Core.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fardin.ViewComponents
{
    public class SubPostComponent:ViewComponent
    {
        private IPostService _postService;
        public SubPostComponent(IPostService postService)
        {
            _postService = postService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.Model = _postService.getSubPostsWithData();
            return await Task.FromResult((IViewComponentResult)View("SubPost"));
        }
    }
}
