#pragma checksum "D:\Project\Fardin\Project Core\Fardin\Fardin\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6f97d4f0c798ea089fdc5ef24c537b4fa0ab9f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6f97d4f0c798ea089fdc5ef24c537b4fa0ab9f0", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Fardin.DataLayer.Entites.About>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Project\Fardin\Project Core\Fardin\Fardin\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About";
    Layout = "~/Views/Shared/_mainLayout.cshtml";

#line default
#line hidden
            BeginContext(131, 205, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n\r\n    <div class=\"col-12\" id=\"about\" style=\"text-align:justify;margin-top: 200px;margin-left: 30px;margin-right:30px;padding: 50px;text-justify: inter-word;background-color: white \">\r\n");
            EndContext();
#line 10 "D:\Project\Fardin\Project Core\Fardin\Fardin\Views\Home\About.cshtml"
         if (Model.Text == null)
        {

#line default
#line hidden
            BeginContext(381, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(395, 23, true);
            WriteLiteral(" There is no Contents\r\n");
            EndContext();
#line 13 "D:\Project\Fardin\Project Core\Fardin\Fardin\Views\Home\About.cshtml"
        }
        else
        {
            

#line default
#line hidden
            BeginContext(467, 10, false);
#line 16 "D:\Project\Fardin\Project Core\Fardin\Fardin\Views\Home\About.cshtml"
       Write(Model.Text);

#line default
#line hidden
            EndContext();
#line 16 "D:\Project\Fardin\Project Core\Fardin\Fardin\Views\Home\About.cshtml"
                       
        }

#line default
#line hidden
            BeginContext(490, 725, true);
            WriteLiteral(@"    </div>

</div>
<div class=""copyrights"" style=""bottom: 0;position: absolute"">
    <div class=""container-fluid"">
        <div class=""footer-distributed"">
            <div class=""footer-left"">
                <p class=""footer-links"">
                    <a href=""#"">Home</a>
                    <a href=""#"">Blog</a>
                    <a href=""#"">Pricing</a>
                    <a href=""#"">About</a>
                    <a href=""#"">Faq</a>
                    <a href=""#"">Contact</a>
                </p>
                <p class=""footer-company-name"">All Rights Reserved. &copy; 2020 | Design By : <a href=""#"">ARASH NP</a></p>
            </div>

            <div class=""footer-right"">
                ");
            EndContext();
            BeginContext(1215, 193, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6f97d4f0c798ea089fdc5ef24c537b4fa0ab9f05870", async() => {
                BeginContext(1245, 156, true);
                WriteLiteral("\r\n                    <input placeholder=\"Subscribe our newsletter..\" name=\"search\">\r\n                    <i class=\"fa fa-envelope-o\"></i>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1408, 101, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div><!-- end container -->\r\n</div><!-- end copyrights -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Fardin.DataLayer.Entites.About> Html { get; private set; }
    }
}
#pragma warning restore 1591
