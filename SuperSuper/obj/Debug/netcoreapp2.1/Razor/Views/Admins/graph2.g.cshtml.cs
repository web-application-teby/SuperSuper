#pragma checksum "C:\Users\Yarden\Documents\GitHub\SuperSuper\SuperSuper\Views\Admins\graph2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b262ec84039ae841f20f15bb71cb68e7203c5da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admins_graph2), @"mvc.1.0.view", @"/Views/Admins/graph2.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admins/graph2.cshtml", typeof(AspNetCore.Views_Admins_graph2))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b262ec84039ae841f20f15bb71cb68e7203c5da", @"/Views/Admins/graph2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d88aa9b1628d321d7b2b7335381f9c1eb20b1569", @"/Views/_ViewImports.cshtml")]
    public class Views_Admins_graph2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SuperSuper.Models.Admin>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Yarden\Documents\GitHub\SuperSuper\SuperSuper\Views\Admins\graph2.cshtml"
  
    ViewData["Title"] = "Update Products";

#line default
#line hidden
            BeginContext(98, 915, true);
            WriteLiteral(@"


<h1>Statistics</h1>


<div>
    <script>
    window.onload = function() {

                var chart = new CanvasJS.Chart(""chartContainer"", {
                    animationEnabled: true,
                    theme: ""dark2"", // ""light1"", ""light2"", ""dark1"", ""dark2""
                    title: {
                        text: ""The Best Supplier ""
                    },

                    axisY: {
                        title: ""Amount of products"",
                        //logarithmic: true
                    },
                    data: [{
                        type: ""column"",
                        indexLabelFontColor: ""white"",
                        indexLabel: ""{y}"",
                        indexLabelFontSize: 16,
                        yValueFormatString: ""#,##0.#"",
                        toolTipContent: ""<b>{label}: {y}</b>"",
                        dataPoints:  ");
            EndContext();
            BeginContext(1014, 28, false);
#line 34 "C:\Users\Yarden\Documents\GitHub\SuperSuper\SuperSuper\Views\Admins\graph2.cshtml"
                                Write(Html.Raw(ViewBag.DataPoints));

#line default
#line hidden
            EndContext();
            BeginContext(1042, 271, true);
            WriteLiteral(@"
        }]
                });
                chart.render();

            }


    </script>


    <div id=""chartContainer"" style=""height: 350px; width: 100%;""></div>
    <script src=""https://canvasjs.com/assets/script/canvasjs.min.js""></script>
</div>

");
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
