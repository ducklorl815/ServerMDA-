<<<<<<< HEAD
#pragma checksum "C:\Users\jo3wait\Documents\ServerMDA-\ServerMDA\Views\product\ProductChartSample.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0235b7db7ca525f413eefcfa0c8baffff90788e3"
=======
#pragma checksum "C:\MDA143後\ServerMDA\Views\product\ProductChartSample.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0235b7db7ca525f413eefcfa0c8baffff90788e3"
>>>>>>> feature/#orli
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_product_ProductChartSample), @"mvc.1.0.view", @"/Views/product/ProductChartSample.cshtml")]
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
<<<<<<< HEAD
#line 1 "C:\Users\jo3wait\Documents\ServerMDA-\ServerMDA\Views\_ViewImports.cshtml"
=======
#line 1 "C:\MDA143後\ServerMDA\Views\_ViewImports.cshtml"
>>>>>>> feature/#orli
using ServerMDA;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "C:\Users\jo3wait\Documents\ServerMDA-\ServerMDA\Views\_ViewImports.cshtml"
=======
#line 2 "C:\MDA143後\ServerMDA\Views\_ViewImports.cshtml"
>>>>>>> feature/#orli
using ServerMDA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0235b7db7ca525f413eefcfa0c8baffff90788e3", @"/Views/product/ProductChartSample.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f44792abd596afd1ba2515f7ae3cd7cc9ca71375", @"/Views/_ViewImports.cshtml")]
    public class Views_product_ProductChartSample : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("runat", new global::Microsoft.AspNetCore.Html.HtmlString("server"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
<<<<<<< HEAD
#line 2 "C:\Users\jo3wait\Documents\ServerMDA-\ServerMDA\Views\product\ProductChartSample.cshtml"
=======
#line 2 "C:\MDA143後\ServerMDA\Views\product\ProductChartSample.cshtml"
>>>>>>> feature/#orli
  
    ViewData["Title"] = "ProductChartSample";
    //Layout = "~/Views/Shared/_ChartLayout.cshtml";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div style=""display:block;height:20px;""></div>
<h4>電影院商品上架統計圖表</h4>

<div style=""display:block;height:40px;""></div>
<input id=""T"" type=""hidden"" />
<input id=""COUNT"" type=""hidden"" />
<div class=""container"">
    <div class=""card bg-white text-dark"" style=""width:40rem;"">
        <div class=""card-body"">
            <h4 class=""card-title"">電影院商品上架統計</h4>
            <p class=""card-text"">x:電影院名稱，y:統計商品數量</p>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0235b7db7ca525f413eefcfa0c8baffff90788e34657", async() => {
                WriteLiteral(@"
                <div style=""width: 100%;"">
                    <canvas id=""myChart""></canvas>
                </div>
                <div id=""myToolTip"" style=""position:absolute"">
                    <p></p>
                    
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div style=\"display:block;height:40px;\"></div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        var ctx = document.getElementById('myChart');
        var T = document.getElementById('T');
        var COUNT = document.getElementById('COUNT')
        const xhr = new XMLHttpRequest()       
        xhr.addEventListener(""load"", () => {
            /*const data = xhr.responseText*/
            const data = JSON.parse(xhr.responseText)
            console.log(data)
            //console.log(data[0]['theaterName'])
            //mymessage.textContent = data           
            let arrT = new Array()
            let arrC = new Array()
            for (let i = 0, max = data.length; i < max; i++) {
                let mydata = data[i].theaterName
                let mycount = data[i].productCount
                console.log(data[i]['theaterName']);
                arrT.push(mydata)             
                arrC.push(mycount)
             
            }

            console.log(arrT);
            console.log(arrC);

            //T = S,
            //    C = ");
                WriteLiteral(@"COUNT,
            //console.log(S)
            //console.log(C)
            var myChart = new Chart(ctx, {
               
                type: 'line',
                data: {
                    labels: arrT,
                    //labels: [data[0]['theaterName'], data[1]['theaterName'], data[2]['theaterName']],
                    //document.getElementById(""theaterName"").value.split("",""),
                    //labels: theaterName.value.splite("",""),
                    datasets: [{
                        backgroundColor: [
                            'rgba(255, 99, 132, 0.2)',
                            'rgba(54, 162, 235, 0.2)',
                            'rgba(255, 206, 86, 0.2)'
                        ],
                        borderColor: [
                            'rgba(255,99,132,1)',
                            'rgba(54, 162, 235, 1)',                            
                            'rgba(75, 192, 192, 1)'
                        ],
                        border");
                WriteLiteral(@"Width: 1,
                        label: '電影院名稱',
                        //data: [ArrC.value.splite("","")]
                        data: arrC
                    }]
                },
                options: {
                    scales: {
                        yAxes: [{
                            ticks: {
                                beginAtZero: true,
                                responsive: true //符合響應式
                            }
                        }]
                    }
                }
            });

        })
        xhr.open(""GET"", ""testItem"")
        xhr.send()


        //var myChart = new Chart(ctx, {
        //    type: 'bar',
        //    data: {
        //        labels: ['一月', '二月', '三月'],
        //        //document.getElementById(""theaterName"").value.split("",""),
        //        //labels: theaterName.value.splite("",""),
        //        datasets: [{
        //            backgroundColor: [
        //                'rgba(255, 99, 132, 0");
                WriteLiteral(@".2)',
        //                'rgba(54, 162, 235, 0.2)',
        //                'rgba(255, 206, 86, 0.2)'
        //            ],
        //            borderColor: [
        //                'rgba(255,99,132,1)',
        //                'rgba(54, 162, 235, 1)',
        //                'rgba(255, 206, 86, 1)',
        //                'rgba(75, 192, 192, 1)'
        //            ],
        //            borderWidth: 1,
        //            label: '銷售業績(百萬)',
        //            data: [60, 49, 72]
        //        }]
        //    }
        //});
    </script>
");
            }
            );
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
