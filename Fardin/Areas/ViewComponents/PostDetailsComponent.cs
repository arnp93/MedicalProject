using Fardin.Core.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fardin.ViewComponents
{
    public class PostDetailsComponent:ViewComponent
    {
        private IPostService _postService;
        public PostDetailsComponent(IPostService postService)
        {
            _postService = postService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult((IViewComponentResult)View("PostDetails", _postService.GetPosts()));
        }
    }
}
