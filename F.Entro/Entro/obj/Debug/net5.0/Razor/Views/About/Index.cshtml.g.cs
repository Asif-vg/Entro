#pragma checksum "C:\Users\CASPER\Desktop\Entro\Entro\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "358547f1dc14e2819f6368fac89cb32e39dd62f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
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
#line 1 "C:\Users\CASPER\Desktop\Entro\Entro\Views\_ViewImports.cshtml"
using Entro;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\CASPER\Desktop\Entro\Entro\Views\_ViewImports.cshtml"
using Entro.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\CASPER\Desktop\Entro\Entro\Views\_ViewImports.cshtml"
using Entro.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"358547f1dc14e2819f6368fac89cb32e39dd62f6", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4c90eb97dfe15ed572c16523fe4b53c48b1ad9e", @"/Views/_ViewImports.cshtml")]
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<About>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\CASPER\Desktop\Entro\Entro\Views\About\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""backgro_mh"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""heding"">
                    <h2>About</h2>
                </div>
            </div>
        </div>
    </div>
</div>

<!-- about  -->
<div id=""about"" class=""about"">
    <div class=""container"">
        <div class=""row display_boxflex"">
            <div class=""col-xl-6 col-lg-6 col-md-6 col-sm-12"">
                <div class=""about-box"">
                    <h2>");
#nullable restore
#line 24 "C:\Users\CASPER\Desktop\Entro\Entro\Views\About\Index.cshtml"
                   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <p>");
#nullable restore
#line 25 "C:\Users\CASPER\Desktop\Entro\Entro\Views\About\Index.cshtml"
                  Write(Model.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <a href=\"Javascript:void(0)\">Read More</a>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-xl-6 col-lg-6 col-md-6 col-sm-12\">\r\n                <div class=\"about-box\">\r\n                    <figure><img");
            BeginWriteAttribute("src", " src=\"", 889, "\"", 919, 2);
            WriteAttributeValue("", 895, "images/", 895, 7, true);
#nullable restore
#line 31 "C:\Users\CASPER\Desktop\Entro\Entro\Views\About\Index.cshtml"
WriteAttributeValue("", 902, Model.AboutImage, 902, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"#\" /></figure>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n<!-- end abouts -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<About> Html { get; private set; }
    }
}
#pragma warning restore 1591
