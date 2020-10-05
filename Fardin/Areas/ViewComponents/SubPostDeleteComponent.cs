using Fardin.Core.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fardin.Areas.ViewComponents
{
    public class SubPostDeleteComponent : ViewComponent
    {
        private IPostService _postService;
        public SubPostDeleteComponent(IPostService postService)
        {
            _postService = postService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult((IViewComponentResult)View("SubPostDelete", _postService.getDeleteSubPosts()));
        }
    }
}
