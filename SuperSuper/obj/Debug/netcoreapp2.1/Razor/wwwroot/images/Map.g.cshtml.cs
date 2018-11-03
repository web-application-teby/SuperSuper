#pragma checksum "C:\Users\tmazor\source\repos\SuperSuper\SuperSuper\wwwroot\images\Map.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "331dc0b0506c9df2178a990545cc4fafa92394c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.wwwroot_images_Map), @"mvc.1.0.view", @"/wwwroot/images/Map.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/wwwroot/images/Map.cshtml", typeof(AspNetCore.wwwroot_images_Map))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"331dc0b0506c9df2178a990545cc4fafa92394c9", @"/wwwroot/images/Map.cshtml")]
    public class wwwroot_images_Map : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(45, 99, true);
            WriteLiteral("\r\n<h1>Our stores</h1>\r\n\r\n<h1 style=\"color:white;\"> Our stores</h1>\r\n\r\n\r\n\r\n<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(144, 270, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1e5db5c66664b82adea8f687441b43f", async() => {
                BeginContext(150, 257, true);
                WriteLiteral(@"

    <style>
        /* Set the size of the div element that contains the map */
        #map {
            height: 400px; /* The height is 400 pixels */
            width: 100%; /* The width is the width of the web page */
        }
    </style>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(414, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(416, 2330, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b35cc453f1ed4c549a820e8bd5f88230", async() => {
                BeginContext(422, 2317, true);
                WriteLiteral(@"

    <!--The div element for the map -->
    <div id=""map""></div>
    <script>
        // Initialize and add the map
        function initMap() {
            // The location of Uluru
            //var uluru = {lat: -25.344, lng: 131.036};
            var uluru1 = { lat: 32.087074, lng: 34.770491 };
            var uluru2 = { lat: 32.0300614, lng: 34.8002 };
            var uluru3 = { lat: 32.1670727, lng: 34.7973614 };
            var uluru4 = { lat: 31.969738, lng: 34.77278720000004 };
            var uluru5 = { lat: 32.030339, lng: 34.88709849999998 };
            var uluru6 = { lat: 32.321458, lng: 34.853196000000025 };
            var uluru7 = { lat: 31.817429, lng: 35.109406000000035 };
            var uluru8 = { lat: 31.890267, lng: 35.01039700000001 };
            var uluru9 = { lat: 31.877958, lng: 34.739449000000036 };


            // The map, centered at Uluru
            var map = new google.maps.Map(
                document.getElementById('map'), { zoom: 9, center: uluru1 ");
                WriteLiteral(@"});



            // The marker, positioned at Uluru
            var marker1 = new google.maps.Marker({ position: uluru1, map: map });
            var marker2 = new google.maps.Marker({ position: uluru2, map: map });
            var marker3 = new google.maps.Marker({ position: uluru3, map: map });
            var marker4 = new google.maps.Marker({ position: uluru4, map: map });
            var marker5 = new google.maps.Marker({ position: uluru5, map: map });
            var marker6 = new google.maps.Marker({ position: uluru6, map: map });
            var marker7 = new google.maps.Marker({ position: uluru7, map: map });
            var marker8 = new google.maps.Marker({ position: uluru8, map: map });
            var marker9 = new google.maps.Marker({ position: uluru9, map: map });

        }
    </script>
    <!--Load the API from the specified URL
    * The async attribute allows the browser to render the page while the API loads
    * The key parameter will contain your own API key (which");
                WriteLiteral(@" is not needed for this tutorial)
    * The callback parameter executes the initMap() function
    -->
    <script async defer
            src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyAZn87I_EZmCJYBEDPwHTMwnBRrH2WH1Fo
&callback=initMap"">
    </script>
");
                EndContext();
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
            EndContext();
            BeginContext(2746, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
