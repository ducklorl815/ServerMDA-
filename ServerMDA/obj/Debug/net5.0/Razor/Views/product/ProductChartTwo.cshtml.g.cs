#pragma checksum "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\product\ProductChartTwo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1810301b2a6f3e7014ede466e4856fa8e1fc2bee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_product_ProductChartTwo), @"mvc.1.0.view", @"/Views/product/ProductChartTwo.cshtml")]
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
#line 1 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\_ViewImports.cshtml"
using ServerMDA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\_ViewImports.cshtml"
using ServerMDA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1810301b2a6f3e7014ede466e4856fa8e1fc2bee", @"/Views/product/ProductChartTwo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f44792abd596afd1ba2515f7ae3cd7cc9ca71375", @"/Views/_ViewImports.cshtml")]
    public class Views_product_ProductChartTwo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ServerMDA.Models.電影院theater>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("myclass"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("runat", new global::Microsoft.AspNetCore.Html.HtmlString("server"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\product\ProductChartTwo.cshtml"
  
    ViewData["Title"] = "ProductChartTwo";
    Layout = "~/Views/Shared/_ChartLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div style=""display:block;height:20px;""></div>
<h4>電影院商品銷售數量統計表</h4>

<div class=""container"">
    <div class=""row"">
        <div class=""col-12"">
            <div class=""input-group mb-3"">
                <span class=""input-group-text"" id=""inputGroup-sizing-default"">電影院名稱:</span>
                <input type=""text"" id=""theatername"" name=""theatername"" class=""form-control"" aria-label=""Sizing example input"" aria-describedby=""inputGroup-sizing-default"">
            </div>
            <div style=""display:block;height:20px;""></div>
            <div>
                <select id=""select1"" class=""form-select"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1810301b2a6f3e7014ede466e4856fa8e1fc2bee5420", async() => {
                WriteLiteral("請選擇您要查詢的電影院");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 23 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\product\ProductChartTwo.cshtml"
                      
                        for (var item = 0; item < Model.Count(); item++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1810301b2a6f3e7014ede466e4856fa8e1fc2bee6731", async() => {
#nullable restore
#line 26 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\product\ProductChartTwo.cshtml"
                                                             Write(Model.ToList()[item].電影院名稱theaterName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1027, "op+", 1027, 3, true);
#nullable restore
#line 26 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\product\ProductChartTwo.cshtml"
AddHtmlAttributeValue("", 1030, item, 1030, 5, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 27 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\product\ProductChartTwo.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </select>
            </div>
        </div>
    </div>
</div>
<div style=""display:block;height:40px;""></div>
<div  class=""container"">
    <div class=""card bg-white text-dark"" style=""width:40rem;"">
        <div class=""card-body"">
            <h4 class=""card-title"">電影院商品銷售數量統計表</h4>
            <p class=""card-text"">x:商品名稱，y:數量</p>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1810301b2a6f3e7014ede466e4856fa8e1fc2bee9153", async() => {
                WriteLiteral("\r\n                <div style=\"width: 100%;\">\r\n                    <canvas id=\"myChart\"></canvas>\r\n                </div>\r\n                <div id=\"myToolTip\" style=\"position:absolute\">\r\n                    <p></p>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n<div style=\"display:block;height:40px;\"></div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        var ctx = document.getElementById('myChart')       
        const selects = document.querySelectorAll("".myclass"")
        const theatername = document.getElementById(""theatername"")
        const S = document.getElementById(""select1"")       
       
        S.addEventListener(""change"", async () => {
            //console.log(S.options[S.selectedIndex].value)
            let intheater = S.options[S.selectedIndex].value
            theatername.value = intheater

            let mytheater = S.options[S.selectedIndex].value
            console.log(mytheater)
            let response = await fetch(""");
#nullable restore
#line 66 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\product\ProductChartTwo.cshtml"
                                   Write(Url.Content("~/product/saleChart"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""" + `?theatername=${mytheater}`)
            let datas = await response.json()
            //console.log(response)
            console.log(datas)
            //0:{ 電影院: { … }, 商品名稱: 'Pizza', 數量: 2 }
            let arrT = new Array()
            let arrC = new Array()
            for (let i = 0, max = datas.length; i < max; i++) {
                let mydata = datas[i].商品名稱
                console.log(datas[i].商品名稱)
                let mycount = datas[i].數量               
                arrT.push(mydata)
                arrC.push(mycount)
            }
            var myChart = new Chart(ctx, {
                type: 'bar',
                data: {
                    labels: arrT,
                    //labels: [datas[0]['商品名稱'], datas[1]['商品名稱'],datas[2]['商品名稱']],                    
                    //document.getElementById(""theaterName"").value.split("",""),
                    //labels: theaterName.value.splite("",""),
                    datasets: [{
                        backgroundC");
                WriteLiteral(@"olor: [
                            'rgba(255, 99, 132, 0.2)',
                            'rgba(54, 162, 235, 0.2)',
                            'rgba(255, 206, 86, 0.2)'
                        ],
                        borderColor: [
                            'rgba(255,99,132,1)',
                            'rgba(54, 162, 235, 1)',
                            'rgba(255, 206, 86, 1)',
                            'rgba(75, 192, 192, 1)'
                        ],
                        borderWidth: 1,
                        label: '數量',
                        data: arrC
                        //data: [datas[0]['數量'],datas[1]['數量'],datas[2]['數量']]
                        //label: myqty
                    }]
                },
                options: {
                    scales: {
                        yAxes: [{
                            ticks: {
                                beginAtZero: true,
                                responsive: true //符合響應式
                   ");
                WriteLiteral(@"         }
                        }]
                    }
                }
            });

        })
        


        //const form = document.querySelector(""body"")
        //console.log(document.getElementById(`op+${S.selectedIndex}`))
        //console.log(selects.options[index].value)
        //form.addEventListener(""load"", () => {
          
        //})

        // const xhr = new XMLHttpRequest()
        //console.log(selects.options[index].value)
        //function myScript()
        //{
        //    console.log(document.getElementById(`op+${S.selectedIndex}`))
        //    theatername.value = document.getElementById(`op+${S.selectedIndex}`).textContent;
        //    let mytheater = theatername.value
        //    console.log(mytheater)
        //}
        //for (let c of selects) {
        //    c.addEventListener(""click"", function (event) {

        //        let TheaterName = this.value;
        //        selected.textContent = TheaterName;
        //    })
 ");
                WriteLiteral(@"       //}
        //xhr.addEventListener(""load"", () => {
        //    const data = JSON.parse(xhr.responseText)
        //    console.log(data)
            //console.log(data[0]['商品名稱'])

            //var myChart = new Chart(ctx, {
            //    type: 'bar',
            //    data: {
            //        labels: [data[0]['商品名稱'], data[1]['商品名稱'], data[2]['商品名稱']],
            //        //document.getElementById(""theaterName"").value.split("",""),
            //        //labels: theaterName.value.splite("",""),
            //        datasets: [{
            //            backgroundColor: [
            //                'rgba(255, 99, 132, 0.2)',
            //                'rgba(54, 162, 235, 0.2)',
            //                'rgba(255, 206, 86, 0.2)'
            //            ],
            //            borderColor: [
            //                'rgba(255,99,132,1)',
            //                'rgba(54, 162, 235, 1)',
            //                'rgba(255, 206, 86, 1)',
 ");
                WriteLiteral(@"           //                'rgba(75, 192, 192, 1)'
            //            ],
            //            borderWidth: 1,
            //            label: '數量',
            //            data: [data[0]['數量'], data[1]['數量'], data[2]['數量']]
            //        }]
            //    },
            //    options: {
            //        scales: {
            //            yAxes: [{
            //                ticks: {
            //                    beginAtZero: true,
            //                    responsive: true //符合響應式
            //                }
            //            }]
            //        }
            //    }
            //});

        //})

       // xhr.open(""GET"", `saleChart?theatername=${theatername}`)
       //xhr.send()

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ServerMDA.Models.電影院theater>> Html { get; private set; }
    }
}
#pragma warning restore 1591
