#pragma checksum "E:\ATSOLUTION\Atsolution\Atsolution\Views\Shared\_MenuPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35f281fb0f7c13e07f88b37d3fe578adebfac391"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__MenuPartial), @"mvc.1.0.view", @"/Views/Shared/_MenuPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_MenuPartial.cshtml", typeof(AspNetCore.Views_Shared__MenuPartial))]
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
#line 1 "E:\ATSOLUTION\Atsolution\Atsolution\Views\_ViewImports.cshtml"
using Atsolution;

#line default
#line hidden
#line 2 "E:\ATSOLUTION\Atsolution\Atsolution\Views\_ViewImports.cshtml"
using Atsolution.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35f281fb0f7c13e07f88b37d3fe578adebfac391", @"/Views/Shared/_MenuPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f7b0b641a04a5de84ddaaf1bf61e2959eb1b7af", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__MenuPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Atsolution.Efs.Entities.Menu>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\ATSOLUTION\Atsolution\Atsolution\Views\Shared\_MenuPartial.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(78, 18, true);
            WriteLiteral("    <li>\r\n        ");
            EndContext();
            BeginContext(96, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35f281fb0f7c13e07f88b37d3fe578adebfac3913491", async() => {
                BeginContext(126, 2, true);
                WriteLiteral("<i");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 128, "\"", 150, 1);
#line 6 "E:\ATSOLUTION\Atsolution\Atsolution\Views\Shared\_MenuPartial.cshtml"
WriteAttributeValue("", 136, item.IconSlug, 136, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(151, 11, true);
                WriteLiteral("></i><span>");
                EndContext();
                BeginContext(163, 9, false);
#line 6 "E:\ATSOLUTION\Atsolution\Atsolution\Views\Shared\_MenuPartial.cshtml"
                                                                     Write(item.Name);

#line default
#line hidden
                EndContext();
                BeginContext(172, 7, true);
                WriteLiteral("</span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 105, "~/", 105, 2, true);
#line 6 "E:\ATSOLUTION\Atsolution\Atsolution\Views\Shared\_MenuPartial.cshtml"
AddHtmlAttributeValue("", 107, item.AnotherLink, 107, 17, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(183, 764, true);
            WriteLiteral(@"
        <ul>
            <li>
                <a href=""#"">Shop Products listing</a>
                <ul>
                    <li><a href=""#"">Right Side Bar</a></li>
                    <li><a href=""#"">Left Side Bar</a></li>
                    <li><a href=""#"">No side bar</a></li>
                </ul>
            </li>
            <li>
                <a href=""#"">Product Page</a>
                <ul>
                    <li><a href=""#"">Right Side Bar</a></li>
                    <li><a href=""#"">Left Side Bar</a></li>
                    <li><a href=""#"">No side bar</a></li>
                </ul>
            </li>
            <li><a href=""#"">Shoping cart</a></li>
            <li><a href=""#"">Check out</a></li>
        </ul>
    </li>
");
            EndContext();
#line 28 "E:\ATSOLUTION\Atsolution\Atsolution\Views\Shared\_MenuPartial.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Atsolution.Efs.Entities.Menu>> Html { get; private set; }
    }
}
#pragma warning restore 1591