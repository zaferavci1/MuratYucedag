#pragma checksum "C:\Users\ZAFER\OneDrive\Masaüstü\DERSLER\Murat Yücedağ\MuratYucedag\Demo_project\Demo_project\Views\Job\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51836e153ec2c19172b97e54ec96e16933af3f95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Job_Index), @"mvc.1.0.view", @"/Views/Job/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\ZAFER\OneDrive\Masaüstü\DERSLER\Murat Yücedağ\MuratYucedag\Demo_project\Demo_project\Views\Job\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51836e153ec2c19172b97e54ec96e16933af3f95", @"/Views/Job/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"518799706d97eacd973a6c7e6e1086e4cffac8eb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Job_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Job>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ZAFER\OneDrive\Masaüstü\DERSLER\Murat Yücedağ\MuratYucedag\Demo_project\Demo_project\Views\Job\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UILayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Meslek Adı</th>\r\n        <th>Sil</th>\r\n        <th>Güncelle</th>\r\n        <th>Detaylar</th>\r\n    </tr>\r\n");
#nullable restore
#line 16 "C:\Users\ZAFER\OneDrive\Masaüstü\DERSLER\Murat Yücedağ\MuratYucedag\Demo_project\Demo_project\Views\Job\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 19 "C:\Users\ZAFER\OneDrive\Masaüstü\DERSLER\Murat Yücedağ\MuratYucedag\Demo_project\Demo_project\Views\Job\Index.cshtml"
   Write(item.JobID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 20 "C:\Users\ZAFER\OneDrive\Masaüstü\DERSLER\Murat Yücedağ\MuratYucedag\Demo_project\Demo_project\Views\Job\Index.cshtml"
   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 431, "\"", 464, 2);
            WriteAttributeValue("", 438, "/Job/DeleteJob/", 438, 15, true);
#nullable restore
#line 21 "C:\Users\ZAFER\OneDrive\Masaüstü\DERSLER\Murat Yücedağ\MuratYucedag\Demo_project\Demo_project\Views\Job\Index.cshtml"
WriteAttributeValue("", 453, item.JobID, 453, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 521, "\"", 554, 2);
            WriteAttributeValue("", 528, "/Job/UpdateJOb/", 528, 15, true);
#nullable restore
#line 22 "C:\Users\ZAFER\OneDrive\Masaüstü\DERSLER\Murat Yücedağ\MuratYucedag\Demo_project\Demo_project\Views\Job\Index.cshtml"
WriteAttributeValue("", 543, item.JobID, 543, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Güncelle</a></td>\r\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 617, "\"", 651, 2);
            WriteAttributeValue("", 624, "/Job/DetailsJOb/", 624, 16, true);
#nullable restore
#line 23 "C:\Users\ZAFER\OneDrive\Masaüstü\DERSLER\Murat Yücedağ\MuratYucedag\Demo_project\Demo_project\Views\Job\Index.cshtml"
WriteAttributeValue("", 640, item.JobID, 640, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary\">Detaylar</a></td>\r\n</tr>\r\n");
#nullable restore
#line 25 "C:\Users\ZAFER\OneDrive\Masaüstü\DERSLER\Murat Yücedağ\MuratYucedag\Demo_project\Demo_project\Views\Job\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Job>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
