#pragma checksum "D:\Project\Fardin\Project Core\Fardin\Fardin\Areas\AdminPanel\Views\Admin\DeletePost.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa8d84dbc81f29a70806b59f0967c57fdd34d07c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminPanel_Views_Admin_DeletePost), @"mvc.1.0.view", @"/Areas/AdminPanel/Views/Admin/DeletePost.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/AdminPanel/Views/Admin/DeletePost.cshtml", typeof(AspNetCore.Areas_AdminPanel_Views_Admin_DeletePost))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 2 "D:\Project\Fardin\Project Core\Fardin\Fardin\Areas\AdminPanel\Views\_ViewImports.cshtml"
using Fardin.Core.DTO;

#line default
#line hidden
#line 3 "D:\Project\Fardin\Project Core\Fardin\Fardin\Areas\AdminPanel\Views\_ViewImports.cshtml"
using Fardin.DataLayer.Entites;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa8d84dbc81f29a70806b59f0967c57fdd34d07c", @"/Areas/AdminPanel/Views/Admin/DeletePost.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a878d11321884554a680f6fd1a2305422ce2ed5", @"/Areas/AdminPanel/Views/_ViewImports.cshtml")]
    public class Areas_AdminPanel_Views_Admin_DeletePost : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DeletePostPageViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "AdminPanel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-white p-2 mb-2 "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditPosts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-white p-2 mb-2 sidebar-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeletePost", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-white p-2 mb-2 sidebar-link current"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ManageComments", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "showContactusContents", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-white p-2 mb-2 sidebar-link "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SocialNetwork", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "StaticInformations", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "About", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangePassword", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("120"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_16 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_17 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/no.image.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Project\Fardin\Project Core\Fardin\Fardin\Areas\AdminPanel\Views\Admin\DeletePost.cshtml"
  
    ViewData["Title"] = "DeletePost";
    Layout = "~/Views/Shared/_adminPanelLayout.cshtml";

#line default
#line hidden
            BeginContext(148, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("sidebar", async() => {
                BeginContext(167, 445, true);
                WriteLiteral(@"
    <div class=""col-xl-2 col-lg-3 col-md-4 sidebar fixed-top"">
        <a href=""#"" class=""navbar-brand text-white d-block mx-auto text-center py-3 mb-4 bottom-border"">
            سایت پزشکی
        </a>
        <div class=""d-flex justify-content-center align-self-center bottom-border pb-2"">
            <img src=""img/3.jpg"" alt="""" width=""40px"" height=""30px"" class=""rounded-circle ml-2"">
            <a href=""#"" class=""text-white"">سلام ");
                EndContext();
                BeginContext(613, 18, false);
#line 14 "D:\Project\Fardin\Project Core\Fardin\Fardin\Areas\AdminPanel\Views\Admin\DeletePost.cshtml"
                                           Write(User.Identity.Name);

#line default
#line hidden
                EndContext();
                BeginContext(631, 139, true);
                WriteLiteral("</a>\r\n        </div>\r\n        <ul class=\"navbar-nav flex-column text-right mt-2\">\r\n            <li class=\"nav-item pl-3\">\r\n                ");
                EndContext();
                BeginContext(770, 212, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa8d84dbc81f29a70806b59f0967c57fdd34d07c10920", async() => {
                    BeginContext(875, 103, true);
                    WriteLiteral("\r\n                    <i class=\"fas fa-home text-light fa-lg ml-3\"></i>اضافه کردن پست\r\n                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(982, 79, true);
                WriteLiteral("\r\n            </li>\r\n\r\n            <li class=\"nav-item pl-3\">\r\n                ");
                EndContext();
                BeginContext(1061, 235, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa8d84dbc81f29a70806b59f0967c57fdd34d07c13080", async() => {
                    BeginContext(1182, 110, true);
                    WriteLiteral("\r\n                    <i class=\"fas fa-file-alt text-light fa-lg ml-3\"></i>تغییر دادن پست ها\r\n                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1296, 79, true);
                WriteLiteral("\r\n            </li>\r\n\r\n            <li class=\"nav-item pl-3\">\r\n                ");
                EndContext();
                BeginContext(1375, 239, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa8d84dbc81f29a70806b59f0967c57fdd34d07c15249", async() => {
                    BeginContext(1505, 105, true);
                    WriteLiteral("\r\n                    <i class=\"fas fa-table text-light fa-lg ml-3\"></i>حذف کردن پست ها\r\n                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1614, 77, true);
                WriteLiteral("\r\n            </li>\r\n            <li class=\"nav-item pl-3\">\r\n                ");
                EndContext();
                BeginContext(1691, 214, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa8d84dbc81f29a70806b59f0967c57fdd34d07c17409", async() => {
                    BeginContext(1795, 106, true);
                    WriteLiteral("\r\n                    <i class=\"fas fa-wrench text-light fa-lg ml-3\"></i>مدیریت کامنت ها\r\n                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1905, 77, true);
                WriteLiteral("\r\n            </li>\r\n            <li class=\"nav-item pl-3\">\r\n                ");
                EndContext();
                BeginContext(1982, 226, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa8d84dbc81f29a70806b59f0967c57fdd34d07c19362", async() => {
                    BeginContext(2094, 110, true);
                    WriteLiteral("\r\n                    <i class=\"fas fa-wrench text-light fa-lg ml-3\"></i>پیام های تماس با ما\r\n                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2208, 77, true);
                WriteLiteral("\r\n            </li>\r\n            <li class=\"nav-item pl-3\">\r\n                ");
                EndContext();
                BeginContext(2285, 221, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa8d84dbc81f29a70806b59f0967c57fdd34d07c21320", async() => {
                    BeginContext(2388, 114, true);
                    WriteLiteral("\r\n                    <i class=\"fas fa-wrench text-light fa-lg ml-3\"></i>مدیریت شبکه های اجتماعی\r\n                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_11.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2506, 77, true);
                WriteLiteral("\r\n            </li>\r\n            <li class=\"nav-item pl-3\">\r\n                ");
                EndContext();
                BeginContext(2583, 220, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa8d84dbc81f29a70806b59f0967c57fdd34d07c23283", async() => {
                    BeginContext(2691, 108, true);
                    WriteLiteral("\r\n                    <i class=\"fas fa-wrench text-light fa-lg ml-3\"></i>مدیریت هدر و فوتر\r\n                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_12.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2803, 77, true);
                WriteLiteral("\r\n            </li>\r\n            <li class=\"nav-item pl-3\">\r\n                ");
                EndContext();
                BeginContext(2880, 203, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa8d84dbc81f29a70806b59f0967c57fdd34d07c25240", async() => {
                    BeginContext(2975, 104, true);
                    WriteLiteral("\r\n                    <i class=\"fas fa-wrench text-light fa-lg ml-3\"></i>متن درباره ما\r\n                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_13.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3083, 77, true);
                WriteLiteral("\r\n            </li>\r\n            <li class=\"nav-item pl-3\">\r\n                ");
                EndContext();
                BeginContext(3160, 213, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa8d84dbc81f29a70806b59f0967c57fdd34d07c27193", async() => {
                    BeginContext(3264, 105, true);
                    WriteLiteral("\r\n                    <i class=\"fas fa-wrench text-light fa-lg ml-3\"></i>تغییر رمز عبور\r\n                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_14.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_14);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3373, 48, true);
                WriteLiteral("\r\n            </li>\r\n        </ul>\r\n    </div>\r\n");
                EndContext();
            }
            );
            BeginContext(3424, 635, true);
            WriteLiteral(@"<div class=""row mx-0 mb-5"" style=""margin-top: 50px"">
    <div class=""col-xl-10 col-lg-9 col-md-8 mr-auto table-responsive"">

        <p class=""alert alert-danger"">در صورت حذف پست، تمام پست های زیرمجموعه نیز حذف خواهند شد!</p>
        <table class=""table table-bordered"">
            <thead>
                <tr>
                    <th class=""d-md-table-cell"">پست ها</th>
                    <th class=""d-md-table-cell"">زیر پست ها</th>
                    <th class=""d-md-table-cell"">عکس پست</th>
                    <th class=""d-md-table-cell"">دستور</th>
                </tr>
            </thead>
            <tbody>

");
            EndContext();
#line 82 "D:\Project\Fardin\Project Core\Fardin\Fardin\Areas\AdminPanel\Views\Admin\DeletePost.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(4124, 78, true);
            WriteLiteral("                    <tr>\r\n                        <td class=\"d-md-table-cell\">");
            EndContext();
            BeginContext(4203, 14, false);
#line 85 "D:\Project\Fardin\Project Core\Fardin\Fardin\Areas\AdminPanel\Views\Admin\DeletePost.cshtml"
                                               Write(item.postTitle);

#line default
#line hidden
            EndContext();
            BeginContext(4217, 119, true);
            WriteLiteral("</td>\r\n                        <td class=\"d-md-table-cell\">\r\n                            <ul style=\"list-style:none\">\r\n");
            EndContext();
#line 88 "D:\Project\Fardin\Project Core\Fardin\Fardin\Areas\AdminPanel\Views\Admin\DeletePost.cshtml"
                                 foreach (var detail in item.SubPostTitles)
                                {

#line default
#line hidden
            BeginContext(4448, 82, true);
            WriteLiteral("                                    <li>\r\n                                        ");
            EndContext();
            BeginContext(4531, 6, false);
#line 91 "D:\Project\Fardin\Project Core\Fardin\Fardin\Areas\AdminPanel\Views\Admin\DeletePost.cshtml"
                                   Write(detail);

#line default
#line hidden
            EndContext();
            BeginContext(4537, 93, true);
            WriteLiteral("\r\n                                        <hr />\r\n                                    </li>\r\n");
            EndContext();
#line 94 "D:\Project\Fardin\Project Core\Fardin\Fardin\Areas\AdminPanel\Views\Admin\DeletePost.cshtml"

                                }

#line default
#line hidden
            BeginContext(4667, 148, true);
            WriteLiteral("                            </ul>\r\n\r\n                        </td>\r\n                        <td class=\"d-md-table-cell\" style=\"text-align:center\">\r\n");
            EndContext();
#line 100 "D:\Project\Fardin\Project Core\Fardin\Fardin\Areas\AdminPanel\Views\Admin\DeletePost.cshtml"
                             if (item.postImage != null)
                            {

#line default
#line hidden
            BeginContext(4904, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(4936, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "aa8d84dbc81f29a70806b59f0967c57fdd34d07c32467", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4946, "~/posts/image/", 4946, 14, true);
#line 102 "D:\Project\Fardin\Project Core\Fardin\Fardin\Areas\AdminPanel\Views\Admin\DeletePost.cshtml"
AddHtmlAttributeValue("", 4960, item.postImage, 4960, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_15);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_16);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5003, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 103 "D:\Project\Fardin\Project Core\Fardin\Fardin\Areas\AdminPanel\Views\Admin\DeletePost.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(5101, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(5133, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "aa8d84dbc81f29a70806b59f0967c57fdd34d07c34605", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_17);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_15);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_16);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5192, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 107 "D:\Project\Fardin\Project Core\Fardin\Fardin\Areas\AdminPanel\Views\Admin\DeletePost.cshtml"
                            }

#line default
#line hidden
            BeginContext(5225, 119, true);
            WriteLiteral("\r\n                        </td>\r\n\r\n                        <td class=\"d-md-table-cell\">\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5344, "\"", 5402, 2);
            WriteAttributeValue("", 5351, "/AdminPanel/Admin/DeleteOnePost?postId=", 5351, 39, true);
#line 112 "D:\Project\Fardin\Project Core\Fardin\Fardin\Areas\AdminPanel\Views\Admin\DeletePost.cshtml"
WriteAttributeValue("", 5390, item.PostId, 5390, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5403, 91, true);
            WriteLiteral(" class=\"btn btn-danger\">حذف</a>\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 115 "D:\Project\Fardin\Project Core\Fardin\Fardin\Areas\AdminPanel\Views\Admin\DeletePost.cshtml"

                }

#line default
#line hidden
            BeginContext(5515, 70, true);
            WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n<hr />\r\n");
            EndContext();
            BeginContext(5586, 53, false);
#line 123 "D:\Project\Fardin\Project Core\Fardin\Fardin\Areas\AdminPanel\Views\Admin\DeletePost.cshtml"
Write(await Component.InvokeAsync("SubPostDeleteComponent"));

#line default
#line hidden
            EndContext();
            BeginContext(5639, 18, true);
            WriteLiteral("\r\n<br />\r\n<hr />\r\n");
            EndContext();
            BeginContext(5658, 64, false);
#line 126 "D:\Project\Fardin\Project Core\Fardin\Fardin\Areas\AdminPanel\Views\Admin\DeletePost.cshtml"
Write(await Component.InvokeAsync("SubPostDescriptionDeleteComponent"));

#line default
#line hidden
            EndContext();
            BeginContext(5722, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DeletePostPageViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591