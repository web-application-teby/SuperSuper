#pragma checksum "C:\Users\bmanor\Desktop\Bar\CS\פיתוח אפליקציות אינטרנטיות\SuperSuper\SuperSuper\Views\Purcheses\PurchesesView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bb9e042d19b079fcd34d250f89394e893d57aec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Purcheses_PurchesesView), @"mvc.1.0.view", @"/Views/Purcheses/PurchesesView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Purcheses/PurchesesView.cshtml", typeof(AspNetCore.Views_Purcheses_PurchesesView))]
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
#line 1 "C:\Users\bmanor\Desktop\Bar\CS\פיתוח אפליקציות אינטרנטיות\SuperSuper\SuperSuper\Views\_ViewImports.cshtml"
using SuperSuper;

#line default
#line hidden
#line 2 "C:\Users\bmanor\Desktop\Bar\CS\פיתוח אפליקציות אינטרנטיות\SuperSuper\SuperSuper\Views\_ViewImports.cshtml"
using SuperSuper.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bb9e042d19b079fcd34d250f89394e893d57aec", @"/Views/Purcheses/PurchesesView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d88aa9b1628d321d7b2b7335381f9c1eb20b1569", @"/Views/_ViewImports.cshtml")]
    public class Views_Purcheses_PurchesesView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SuperSuper.Models.PurchesesView>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\bmanor\Desktop\Bar\CS\פיתוח אפליקציות אינטרנטיות\SuperSuper\SuperSuper\Views\Purcheses\PurchesesView.cshtml"
  
    ViewData["Title"] = "My Basket";

#line default
#line hidden
            BeginContext(100, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(107, 17, false);
#line 7 "C:\Users\bmanor\Desktop\Bar\CS\פיתוח אפליקציות אינטרנטיות\SuperSuper\SuperSuper\Views\Purcheses\PurchesesView.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(124, 9, true);
            WriteLiteral("</h1>\r\n\r\n");
            EndContext();
            BeginContext(199, 38, true);
            WriteLiteral("\r\n<p>\r\n    \r\n    <button type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 237, "\"", 362, 12);
            WriteAttributeValue("", 247, "alert(\'Thank", 247, 12, true);
            WriteAttributeValue(" ", 259, "you", 260, 4, true);
            WriteAttributeValue(" ", 263, "for", 264, 4, true);
            WriteAttributeValue(" ", 267, "your", 268, 5, true);
            WriteAttributeValue(" ", 272, "purchase.", 273, 10, true);
            WriteAttributeValue(" ", 282, "Payment", 283, 8, true);
            WriteAttributeValue(" ", 290, "in", 291, 3, true);
            WriteAttributeValue(" ", 293, "cash", 294, 5, true);
            WriteAttributeValue(" ", 298, "upon", 299, 5, true);
            WriteAttributeValue(" ", 303, "delivery\');location.href=\'", 304, 27, true);
#line 15 "C:\Users\bmanor\Desktop\Bar\CS\פיתוח אפליקציות אינטרנטיות\SuperSuper\SuperSuper\Views\Purcheses\PurchesesView.cshtml"
WriteAttributeValue("", 330, Url.Action("Buy", "Purcheses"), 330, 31, false);

#line default
#line hidden
            WriteAttributeValue("", 361, "\'", 361, 1, true);
            EndWriteAttribute();
            BeginContext(363, 18, true);
            WriteLiteral("> buy</button>\r\n\r\n");
            EndContext();
            BeginContext(527, 269, true);
            WriteLiteral(@"

    <br>

</p>

<table class=""table"">
    <thead>
        <tr>
            <th>
                Product Name
            </th>
            <th>
                Date
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>


");
            EndContext();
#line 39 "C:\Users\bmanor\Desktop\Bar\CS\פיתוח אפליקציות אינטרנטיות\SuperSuper\SuperSuper\Views\Purcheses\PurchesesView.cshtml"
         foreach (SuperSuper.Models.PurchesesView item in Model)
        {

#line default
#line hidden
            BeginContext(873, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(934, 46, false);
#line 43 "C:\Users\bmanor\Desktop\Bar\CS\פיתוח אפליקציות אינטרנטיות\SuperSuper\SuperSuper\Views\Purcheses\PurchesesView.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(980, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1048, 46, false);
#line 46 "C:\Users\bmanor\Desktop\Bar\CS\פיתוח אפליקציות אינטרנטיות\SuperSuper\SuperSuper\Views\Purcheses\PurchesesView.cshtml"
               Write(Html.DisplayFor(modelItem => item.PurchesDate));

#line default
#line hidden
            EndContext();
            BeginContext(1094, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1161, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e15fd4cf0ef4cf0a23995599e737343", async() => {
                BeginContext(1223, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 49 "C:\Users\bmanor\Desktop\Bar\CS\פיתוח אפליקציות אינטרנטיות\SuperSuper\SuperSuper\Views\Purcheses\PurchesesView.cshtml"
                                             WriteLiteral(item.OriginalPurchesID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1233, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 52 "C:\Users\bmanor\Desktop\Bar\CS\פיתוח אפליקציות אינטרנטיות\SuperSuper\SuperSuper\Views\Purcheses\PurchesesView.cshtml"
        }

#line default
#line hidden
            BeginContext(1288, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SuperSuper.Models.PurchesesView>> Html { get; private set; }
    }
}
#pragma warning restore 1591
