using Fardin.Core.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fardin.Areas.ViewComponents
{
    public class SubPostDescriptionComponent : ViewComponent
    {
        private IPostService _postService;
        public SubPostDescriptionComponent(IPostService postService)
        {
            _postService = postService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {            
            return await Task.FromResult((IViewComponentResult)View("SubPostDescription", _postService.getSubPostsWithDescription()));
        }
    }
}
