#pragma checksum "C:\Users\Yarden\Documents\GitHub\SuperSuper\SuperSuper\Views\Admins\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e784985f382e0010be44668a87bcca99a34cd3c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admins_Index), @"mvc.1.0.view", @"/Views/Admins/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admins/Index.cshtml", typeof(AspNetCore.Views_Admins_Index))]
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
#line 1 "C:\Users\Yarden\Documents\GitHub\SuperSuper\SuperSuper\Views\_ViewImports.cshtml"
using SuperSuper;

#line default
#line hidden
#line 2 "C:\Users\Yarden\Documents\GitHub\SuperSuper\SuperSuper\Views\_ViewImports.cshtml"
using SuperSuper.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e784985f382e0010be44668a87bcca99a34cd3c3", @"/Views/Admins/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d88aa9b1628d321d7b2b7335381f9c1eb20b1569", @"/Views/_ViewImports.cshtml")]
    public class Views_Admins_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SuperSuper.Models.Admin>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Yarden\Documents\GitHub\SuperSuper\SuperSuper\Views\Admins\Index.cshtml"
  
    ViewData["Title"] = "Update Products";

#line default
#line hidden
            BeginContext(98, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(105, 17, false);
#line 7 "C:\Users\Yarden\Documents\GitHub\SuperSuper\SuperSuper\Views\Admins\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(122, 57, true);
            WriteLiteral("</h1>\r\n\r\n<p>\r\n    <br /><br />\r\n    <button type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 179, "\"", 243, 3);
            WriteAttributeValue("", 189, "location.href=\'", 189, 15, true);
#line 11 "C:\Users\Yarden\Documents\GitHub\SuperSuper\SuperSuper\Views\Admins\Index.cshtml"
WriteAttributeValue("", 204, Url.Action("CreateProduct", "Admins"), 204, 38, false);

#line default
#line hidden
            WriteAttributeValue("", 242, "\'", 242, 1, true);
            EndWriteAttribute();
            BeginContext(244, 78, true);
            WriteLiteral(" class=\"btn btn-default\"> Create product</button>\r\n\r\n    <button type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 322, "\"", 384, 3);
            WriteAttributeValue("", 332, "location.href=\'", 332, 15, true);
#line 13 "C:\Users\Yarden\Documents\GitHub\SuperSuper\SuperSuper\Views\Admins\Index.cshtml"
WriteAttributeValue("", 347, Url.Action("EditProduct", "Admins"), 347, 36, false);

#line default
#line hidden
            WriteAttributeValue("", 383, "\'", 383, 1, true);
            EndWriteAttribute();
            BeginContext(385, 91, true);
            WriteLiteral(" class=\"btn btn-default\"> Edit product</button>\r\n\r\n</p>\r\n\r\n\r\n<h1>Statistics</h1>\r\n\r\n<button");
            EndContext();
            BeginWriteAttribute("onclick", " onclick= \"", 476, "\"", 535, 4);
            WriteAttributeValue("", 487, "location.href=\'", 487, 15, true);
#line 20 "C:\Users\Yarden\Documents\GitHub\SuperSuper\SuperSuper\Views\Admins\Index.cshtml"
WriteAttributeValue("", 502, Url.Action("graph1", "Admins"), 502, 31, false);

#line default
#line hidden
            WriteAttributeValue("", 533, "\'", 533, 1, true);
            WriteAttributeValue(" ", 534, "", 535, 1, true);
            EndWriteAttribute();
            BeginContext(536, 37, true);
            WriteLiteral(">Products consuming</button>\r\n<button");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 573, "\"", 631, 4);
            WriteAttributeValue("", 583, "location.href=\'", 583, 15, true);
#line 21 "C:\Users\Yarden\Documents\GitHub\SuperSuper\SuperSuper\Views\Admins\Index.cshtml"
WriteAttributeValue("", 598, Url.Action("graph2", "Admins"), 598, 31, false);

#line default
#line hidden
            WriteAttributeValue("", 629, "\'", 629, 1, true);
            WriteAttributeValue(" ", 630, "", 631, 1, true);
            EndWriteAttribute();
            BeginContext(632, 43, true);
            WriteLiteral(">The Best Supplier</button>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SuperSuper.Models.Admin>> Html { get; private set; }
    }
}
#pragma warning restore 1591
