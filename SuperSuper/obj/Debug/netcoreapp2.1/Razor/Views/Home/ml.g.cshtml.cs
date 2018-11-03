#pragma checksum "C:\Users\tmazor\source\repos\SuperSuper\SuperSuper\Views\Home\ml.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2268c77691e1fe2f9271399c1f43021daf6de93d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ml), @"mvc.1.0.view", @"/Views/Home/ml.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ml.cshtml", typeof(AspNetCore.Views_Home_ml))]
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
#line 1 "C:\Users\tmazor\source\repos\SuperSuper\SuperSuper\Views\_ViewImports.cshtml"
using SuperSuper;

#line default
#line hidden
#line 2 "C:\Users\tmazor\source\repos\SuperSuper\SuperSuper\Views\_ViewImports.cshtml"
using SuperSuper.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2268c77691e1fe2f9271399c1f43021daf6de93d", @"/Views/Home/ml.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d88aa9b1628d321d7b2b7335381f9c1eb20b1569", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ml : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(0, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(25, 136, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd51841785b3474c907191224df8a80d", async() => {
                BeginContext(31, 123, true);
                WriteLiteral("\r\n    <title>Getting Started with ml5.js</title>\r\n    <script src=\"https://unpkg.com/ml5@0.1.1/dist/ml5.min.js\"></script>\r\n");
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
            BeginContext(161, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(163, 690, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3d00b2b6835404eb0edc61692fe6b6a", async() => {
                BeginContext(169, 677, true);
                WriteLiteral(@"
    <h1>Take a snapshot of the current video stream</h1>
    Click on the Start WebCam button.
    <p>
        <button onclick=""startWebcam();"">Start WebCam</button>
        <button onclick=""snapshot();"">want to buy this</button>
    </p>
    <video onclick=""snapshot(this);"" width=400 height=400 id=""video"" controls autoplay></video>
    <p>

        Screenshots :
    <p>
        <canvas id=""myCanvas"" width=""400"" height=""400""></canvas>

        <h1>Image classification using MobileNet</h1>
<p>
        The MobileNet model labeled this as
        <span id=""result"">...</span> with a confidence of
        <span id=""probability"">...</span>
    </p>
   
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
            BeginContext(853, 2981, true);
            WriteLiteral(@"

<script>

    var image = new Image();

    function startml(img) {
        // The image we want to classify
        const image = img;
        // The result tag in the HTML
        const result = document.getElementById('result');
        // The probability tag in the HTML
        const probability = document.getElementById('probability');

        // Initialize the Image Classifier method with MobileNet
        const classifier = ml5.imageClassifier('MobileNet', function () {
            console.log('Model Loaded!');
        });

        // Make a prediction with the selected image
        // This will return an array with a default of 10 options with their probabilities
        classifier.predict(image, function (err, results) {
            result.innerText = results[0].className;
            probability.innerText = results[0].probability.toFixed(4);
        });
    }

    //--------------------
    // GET USER MEDIA CODE
    //--------------------
    navigator.getUserMedia");
            WriteLiteral(@" = (navigator.getUserMedia ||
        navigator.webkitGetUserMedia ||
        navigator.mozGetUserMedia ||
        navigator.msGetUserMedia);

    var video;
    var webcamStream;

    function startWebcam() {
        if (navigator.getUserMedia) {
            navigator.getUserMedia(

                // constraints
                {
                    video: true,
                    audio: false
                },

                // successCallback
                function (localMediaStream) {
                    video = document.querySelector('video');
                    video.src = window.URL.createObjectURL(localMediaStream);
                    webcamStream = localMediaStream;
                },

                // errorCallback
                function (err) {
                    console.log(""The following error occured: "" + err);
                }
            );
        } else {
            console.log(""getUserMedia not supported"");
        }
    }

    //----------");
            WriteLiteral(@"-----------
    // TAKE A SNAPSHOT CODE
    //---------------------
    var canvas, ctx;

    //function init() {
    //    // Get the canvas and obtain a context for
    //    // drawing in it
    //    canvas = document.getElementById(""myCanvas"");
    //    ctx = canvas.getContext('2d');
    //}

    //function snapshot() {
    //    // Draws current image from the video element into the canvas
    //    ctx.drawImage(video, 0, 0, canvas.width, canvas.height);
    //    image.id = ""pic""
    //    image.src = ctx.toDataURL();
    //    //image.src = document.getElementById(""video"");
    //    startml(image)

    function snapshot() {
        canvas = document.getElementById(""myCanvas"");
        canvas.getContext('2d').drawImage(video, 0, 0, canvas.width, canvas.height);
        image.id = ""pic""
        image.src = canvas.toDataURL();
        startml(image);
    }
   
    
</script>
</html>");
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
