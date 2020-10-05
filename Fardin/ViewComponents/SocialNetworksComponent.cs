using Fardin.Core.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fardin.ViewComponents
{
    public class SocialNetworksComponent : ViewComponent
    {
        private IAdminService adminService;
        public SocialNetworksComponent(IAdminService adminService)
        {
            this.adminService = adminService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult((IViewComponentResult)View("SocialNetworks",adminService.returnSocialNetwork()));
        }
    }
}
