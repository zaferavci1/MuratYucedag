#pragma checksum "C:\Users\ZAFER\OneDrive\Masaüstü\DERSLER\Murat Yücedağ\MuratYucedag\Demo_project\Demo_project\Views\Shared\_UILayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76acb0a1ffa2b7d4f672339837017de7a0439735"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__UILayout), @"mvc.1.0.view", @"/Views/Shared/_UILayout.cshtml")]
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
#nullable restore
#line 1 "C:\Users\ZAFER\OneDrive\Masaüstü\DERSLER\Murat Yücedağ\MuratYucedag\Demo_project\Demo_project\Views\_ViewImports.cshtml"
using Demo_project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ZAFER\OneDrive\Masaüstü\DERSLER\Murat Yücedağ\MuratYucedag\Demo_project\Demo_project\Views\_ViewImports.cshtml"
using Demo_project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76acb0a1ffa2b7d4f672339837017de7a0439735", @"/Views/Shared/_UILayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"518799706d97eacd973a6c7e6e1086e4cffac8eb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__UILayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/startbootstrap-sb-admin-gh-pages/js/scripts.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ZAFER\OneDrive\Masaüstü\DERSLER\Murat Yücedağ\MuratYucedag\Demo_project\Demo_project\Views\Shared\_UILayout.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
#nullable restore
#line 9 "C:\Users\ZAFER\OneDrive\Masaüstü\DERSLER\Murat Yücedağ\MuratYucedag\Demo_project\Demo_project\Views\Shared\_UILayout.cshtml"
Write(Html.Partial("/Views/Partials/Partial_Header.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76acb0a1ffa2b7d4f672339837017de7a04397354423", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 11 "C:\Users\ZAFER\OneDrive\Masaüstü\DERSLER\Murat Yücedağ\MuratYucedag\Demo_project\Demo_project\Views\Shared\_UILayout.cshtml"
Write(Html.Partial("/Views/Partials/Partial_Navbar.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <div id=\"layoutSidenav\">\r\n        ");
#nullable restore
#line 13 "C:\Users\ZAFER\OneDrive\Masaüstü\DERSLER\Murat Yücedağ\MuratYucedag\Demo_project\Demo_project\Views\Shared\_UILayout.cshtml"
   Write(Html.Partial("/Views/Partials/Partial_SideNavbar.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <div id=\"layoutSidenav_content\">\r\n\r\n            <main>\r\n                <div class=\"container-fluid px-4\">\r\n                    <h1 class=\"mt-4\">merhabalar &#x1F61C</h1>\r\n\r\n                    ");
#nullable restore
#line 20 "C:\Users\ZAFER\OneDrive\Masaüstü\DERSLER\Murat Yücedağ\MuratYucedag\Demo_project\Demo_project\Views\Shared\_UILayout.cshtml"
               Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </main>\r\n            ");
#nullable restore
#line 23 "C:\Users\ZAFER\OneDrive\Masaüstü\DERSLER\Murat Yücedağ\MuratYucedag\Demo_project\Demo_project\Views\Shared\_UILayout.cshtml"
       Write(Html.Partial("/Views/Partials/Partial_Footer.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <script src=\"https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js\" crossorigin=\"anonymous\"></script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76acb0a1ffa2b7d4f672339837017de7a04397356395", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
