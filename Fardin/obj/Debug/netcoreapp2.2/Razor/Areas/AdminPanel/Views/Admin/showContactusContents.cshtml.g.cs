#pragma checksum "D:\Project\Fardin\Project Core\Fardin\Fardin\Areas\AdminPanel\Views\Admin\showContactusContents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbd211f044319e913e8094f88cf345a3534d7aad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminPanel_Views_Admin_showContactusContents), @"mvc.1.0.view", @"/Areas/AdminPanel/Views/Admin/showContactusContents.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/AdminPanel/Views/Admin/showContactusContents.cshtml", typeof(AspNetCore.Areas_AdminPanel_Views_Admin_showContactusContents))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbd211f044319e913e8094f88cf345a3534d7aad", @"/Areas/AdminPanel/Views/Admin/showContactusContents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a878d11321884554a680f6fd1a2305422ce2ed5", @"/Areas/AdminPanel/Views/_ViewImports.cshtml")]
    public class Areas_AdminPanel_Views_Admin_showContactusContents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Fardin.DataLayer.Entites.ContactUs>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "AdminPanel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-white p-2 mb-2 "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditPosts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-white p-2 mb-2 sidebar-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeletePost", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ManageComments", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-white p-2 mb-2 sidebar-link "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "showContactusContents", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-white p-2 mb-2 sidebar-link current"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SocialNetwork", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "StaticInformations", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "About", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangePassword", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Project\Fardin\Project Core\Fardin\Fardin\Areas\AdminPanel\Views\Admin\showContactusContents.cshtml"
  
    Layout = "~/Views/Shared/_adminPanelLayout.cshtml";

#line default
#line hidden
            BeginContext(115, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("sidebar", async() => {
                BeginContext(134, 445, true);
                WriteLiteral(@"
    <div class=""col-xl-2 col-lg-3 col-md-4 sidebar fixed-top"">
        <a href=""#"" class=""navbar-brand text-white d-block mx-auto text-center py-3 mb-4 bottom-border"">
            سایت پزشکی
        </a>
        <div class=""d-flex justify-content-center align-self-center bottom-border pb-2"">
            <img src=""img/3.jpg"" alt="""" width=""40px"" height=""30px"" class=""rounded-circle ml-2"">
            <a href=""#"" class=""text-white"">سلام ");
                EndContext();
                BeginContext(580, 18, false);
#line 14 "D:\Project\Fardin\Project Core\Fardin\Fardin\Areas\AdminPanel\Views\Admin\showContactusContents.cshtml"
                                           Write(User.Identity.Name);

#line default
#line hidden
                EndContext();
                BeginContext(598, 139, true);
                WriteLiteral("</a>\r\n        </div>\r\n        <ul class=\"navbar-nav flex-column text-right mt-2\">\r\n            <li class=\"nav-item pl-3\">\r\n                ");
                EndContext();
                BeginContext(737, 212, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbd211f044319e913e8094f88cf345a3534d7aad9880", async() => {
                    BeginContext(842, 103, true);
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
                BeginContext(949, 79, true);
                WriteLiteral("\r\n            </li>\r\n\r\n            <li class=\"nav-item pl-3\">\r\n                ");
                EndContext();
                BeginContext(1028, 235, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbd211f044319e913e8094f88cf345a3534d7aad12039", async() => {
                    BeginContext(1149, 110, true);
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
                BeginContext(1263, 79, true);
                WriteLiteral("\r\n            </li>\r\n\r\n            <li class=\"nav-item pl-3\">\r\n                ");
                EndContext();
                BeginContext(1342, 231, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbd211f044319e913e8094f88cf345a3534d7aad14208", async() => {
                    BeginContext(1464, 105, true);
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
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1573, 77, true);
                WriteLiteral("\r\n            </li>\r\n            <li class=\"nav-item pl-3\">\r\n                ");
                EndContext();
                BeginContext(1650, 215, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbd211f044319e913e8094f88cf345a3534d7aad16368", async() => {
                    BeginContext(1755, 106, true);
                    WriteLiteral("\r\n                    <i class=\"fas fa-wrench text-light fa-lg ml-3\"></i>مدیریت کامنت ها\r\n                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1865, 77, true);
                WriteLiteral("\r\n            </li>\r\n            <li class=\"nav-item pl-3\">\r\n                ");
                EndContext();
                BeginContext(1942, 233, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbd211f044319e913e8094f88cf345a3534d7aad18321", async() => {
                    BeginContext(2061, 110, true);
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
                BeginContext(2175, 77, true);
                WriteLiteral("\r\n            </li>\r\n            <li class=\"nav-item pl-3\">\r\n                ");
                EndContext();
                BeginContext(2252, 221, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbd211f044319e913e8094f88cf345a3534d7aad20279", async() => {
                    BeginContext(2355, 114, true);
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
                BeginContext(2473, 77, true);
                WriteLiteral("\r\n            </li>\r\n            <li class=\"nav-item pl-3\">\r\n                ");
                EndContext();
                BeginContext(2550, 220, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbd211f044319e913e8094f88cf345a3534d7aad22242", async() => {
                    BeginContext(2658, 108, true);
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
                BeginContext(2770, 77, true);
                WriteLiteral("\r\n            </li>\r\n            <li class=\"nav-item pl-3\">\r\n                ");
                EndContext();
                BeginContext(2847, 203, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbd211f044319e913e8094f88cf345a3534d7aad24199", async() => {
                    BeginContext(2942, 104, true);
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
                BeginContext(3050, 77, true);
                WriteLiteral("\r\n            </li>\r\n            <li class=\"nav-item pl-3\">\r\n                ");
                EndContext();
                BeginContext(3127, 213, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbd211f044319e913e8094f88cf345a3534d7aad26152", async() => {
                    BeginContext(3231, 105, true);
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
                BeginContext(3340, 48, true);
                WriteLiteral("\r\n            </li>\r\n        </ul>\r\n    </div>\r\n");
                EndContext();
            }
            );
            BeginContext(3391, 156, true);
            WriteLiteral("\r\n<div class=\"container\" style=\"margin-top: 50px\">\r\n    <div class=\"row mx-0 mb-5 postSection\">\r\n        <div class=\"col-xl-10 col-lg-9 col-md-8 mr-auto\">\r\n");
            EndContext();
#line 71 "D:\Project\Fardin\Project Core\Fardin\Fardin\Areas\AdminPanel\Views\Admin\showContactusContents.cshtml"
             if (ViewBag.isSuccess != null)
            {

#line default
#line hidden
            BeginContext(3607, 78, true);
            WriteLiteral("                <p class=\"alert alert-success\">عملیات با موفقیت انجام شد</p>\r\n");
            EndContext();
#line 74 "D:\Project\Fardin\Project Core\Fardin\Fardin\Areas\AdminPanel\Views\Admin\showContactusContents.cshtml"
            }

#line default
#line hidden
            BeginContext(3700, 177, true);
            WriteLiteral("            <table class=\"table table-bordered\">\r\n                <tr>\r\n                    <th>متن کامنت</th>\r\n                    <th>حذف کامنت</th>\r\n                </tr>\r\n\r\n");
            EndContext();
#line 81 "D:\Project\Fardin\Project Core\Fardin\Fardin\Areas\AdminPanel\Views\Admin\showContactusContents.cshtml"
                 foreach (var contact in Model)
                {

#line default
#line hidden
            BeginContext(3945, 176, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            <small class=\"font-italic font-weight-lighter\">\r\n                                نام کاربر: ");
            EndContext();
            BeginContext(4122, 16, false);
#line 86 "D:\Project\Fardin\Project Core\Fardin\Fardin\Areas\AdminPanel\Views\Admin\showContactusContents.cshtml"
                                      Write(contact.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(4138, 86, true);
            WriteLiteral("\r\n                                <br />\r\n                                تاریخ دقیق: ");
            EndContext();
            BeginContext(4225, 12, false);
#line 88 "D:\Project\Fardin\Project Core\Fardin\Fardin\Areas\AdminPanel\Views\Admin\showContactusContents.cshtml"
                                       Write(contact.Date);

#line default
#line hidden
            EndContext();
            BeginContext(4237, 81, true);
            WriteLiteral("\r\n                                <br />\r\n                                ایمیل: ");
            EndContext();
            BeginContext(4319, 13, false);
#line 90 "D:\Project\Fardin\Project Core\Fardin\Fardin\Areas\AdminPanel\Views\Admin\showContactusContents.cshtml"
                                  Write(contact.Email);

#line default
#line hidden
            EndContext();
            BeginContext(4332, 87, true);
            WriteLiteral("\r\n                                <br />\r\n                                شماره تلفن : ");
            EndContext();
            BeginContext(4421, 70, false);
#line 92 "D:\Project\Fardin\Project Core\Fardin\Fardin\Areas\AdminPanel\Views\Admin\showContactusContents.cshtml"
                                         Write(contact.PhoneNumber != null? contact.PhoneNumber : "شماره ای ثبت نشده");

#line default
#line hidden
            EndContext();
            BeginContext(4492, 108, true);
            WriteLiteral("\r\n                            </small>\r\n                            <br />\r\n                            <p> ");
            EndContext();
            BeginContext(4601, 12, false);
#line 95 "D:\Project\Fardin\Project Core\Fardin\Fardin\Areas\AdminPanel\Views\Admin\showContactusContents.cshtml"
                           Write(contact.Text);

#line default
#line hidden
            EndContext();
            BeginContext(4613, 126, true);
            WriteLiteral("</p>\r\n                           \r\n                        </td>\r\n                        <td>\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4739, "\"", 4798, 2);
            WriteAttributeValue("", 4746, "/AdminPanel/Admin/DeleteContact/", 4746, 32, true);
#line 99 "D:\Project\Fardin\Project Core\Fardin\Fardin\Areas\AdminPanel\Views\Admin\showContactusContents.cshtml"
WriteAttributeValue("", 4778, contact.ContactUsId, 4778, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4799, 97, true);
            WriteLiteral(" class=\"btn btn-danger\">حذف کامنت</a>\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 102 "D:\Project\Fardin\Project Core\Fardin\Fardin\Areas\AdminPanel\Views\Admin\showContactusContents.cshtml"
                }

#line default
#line hidden
            BeginContext(4915, 60, true);
            WriteLiteral("\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Fardin.DataLayer.Entites.ContactUs>> Html { get; private set; }
    }
}
#pragma warning restore 1591