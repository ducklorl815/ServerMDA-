#pragma checksum "C:\MDA後台\ServerMDA\Views\HomePage\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c599bf240894fd25e3a37e7e53d51905bd0b6034"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HomePage_List), @"mvc.1.0.view", @"/Views/HomePage/List.cshtml")]
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
#line 1 "C:\MDA後台\ServerMDA\Views\_ViewImports.cshtml"
using ServerMDA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MDA後台\ServerMDA\Views\_ViewImports.cshtml"
using ServerMDA.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\MDA後台\ServerMDA\Views\HomePage\List.cshtml"
using ServerMDA.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c599bf240894fd25e3a37e7e53d51905bd0b6034", @"/Views/HomePage/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f44792abd596afd1ba2515f7ae3cd7cc9ca71375", @"/Views/_ViewImports.cshtml")]
    public class Views_HomePage_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CTheaterViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("myclass"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/wencssjs/chart.js/Chart.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/wencssjs/chart.js/utils.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\MDA後台\ServerMDA\Views\HomePage\List.cshtml"
  
    ViewData["Title"] = "ProductChartTwo";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Content Wrapper -->

<iframe title=""後台HomePage - 收入"" width=""1570"" height=""1000"" src=""https://app.powerbi.com/view?r=eyJrIjoiNzkyNTY0NWUtZjBlMC00MWI2LTk5MGUtMGNiMmFjNDk4ZmY4IiwidCI6ImE0M2Y2Y2QzLTU0MTItNGIxZi1hMTM0LTJjMjc3MzY0Y2FmNiIsImMiOjEwfQ%3D%3D"" frameborder=""0"" allowFullScreen=""true""></iframe>

");
            WriteLiteral(@"  <!--<div id=""content"">


        <!-- Begin Page Content -->
    <!--<div class=""container-fluid"">
        <div class=""row"">-->
    <!-- Area Chart -->
    <!--<div class=""col-8"">
        <div class=""card shadow mb-4"">-->
    <!-- Card Header - Dropdown -->
    <!--<div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between"">
        <div class=""d-flex flex-row"">
            <div class=""mt-2 mr-2"">
                <h6 class=""m-0 font-weight-bold fs-3 text-primary"">收益 曲線圖</h6>
            </div>
            <div>
                <select id=""select1"" name=""電影院名稱theaterName"" class=""form-select fs-5"">
                    <option>請選擇您要查詢的電影院</option>
");
#nullable restore
#line 31 "C:\MDA後台\ServerMDA\Views\HomePage\List.cshtml"
                      
                        //foreach (var item in Model.titleTheater)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c599bf240894fd25e3a37e7e53d51905bd0b60345962", async() => {
                WriteLiteral("  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
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
#line 35 "C:\MDA後台\ServerMDA\Views\HomePage\List.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </select>
            </div>
        </div>
        <div class=""dropdown no-arrow"">
            <a class=""dropdown-toggle"" href=""#"" role=""button"" id=""dropdownMenuLink""
               data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                <i class=""fas fa-ellipsis-v fa-sm fa-fw text-gray-400""></i>
            </a>
            <div class=""dropdown-menu dropdown-menu-right shadow animated--fade-in""
                 aria-labelledby=""dropdownMenuLink"">
                <div class=""dropdown-header"">收入來源:</div>
                <a class=""dropdown-item"" href=""#"">Action</a>
                <a class=""dropdown-item"" href=""#"">Another action</a>
                <div class=""dropdown-divider""></div>
                <a class=""dropdown-item"" href=""#"">Something else here</a>
            </div>
        </div>
    </div>-->
    <!-- Card Body -->
    <!--<div class=""card-body"">
                <div class=""chart-area"" style=""height:400px"">
                    <canvas ");
            WriteLiteral(@"class=""h-100"" id=""myChart""></canvas>
                </div>
            </div>
        </div>
    </div>-->
    <!-- Pie Chart -->
    <!--<div class=""col-xl-4 col-lg-5"">
        <div class=""card shadow mb-4"">-->
    <!-- Card Header - Dropdown -->
    <!--<div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between"">
        <h6 class=""m-0 font-weight-bold text-primary"">收入來源</h6>
        <div class=""dropdown no-arrow"">
            <a class=""dropdown-toggle"" href=""#"" role=""button"" id=""dropdownMenuLink""
               data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                <i class=""fas fa-ellipsis-v fa-sm fa-fw text-gray-400""></i>
            </a>
            <div class=""dropdown-menu dropdown-menu-right shadow animated--fade-in""
                 aria-labelledby=""dropdownMenuLink"">
                <div class=""dropdown-header"">Dropdown Header:</div>
                <a class=""dropdown-item"" href=""#"">Action</a>
                <a class=""dr");
            WriteLiteral("opdown-item\" href=\"#\">Another action</a>\r\n                <div class=\"dropdown-divider\"></div>\r\n                <a class=\"dropdown-item\" href=\"#\">Something else here</a>\r\n            </div>\r\n        </div>\r\n    </div>-->\r\n    <!-- Card Body 收益圖 -->");
            WriteLiteral("\r\n    <!--");
            WriteLiteral("\r\n            <!--</div>\r\n        </div>\r\n    </div>-->\r\n    <!-- #region 備註 -->\r\n    <!-- Content Row -->\r\n    <!--</div>-->\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("    <!--End of Main Content-->\r\n\r\n\r\n\r\n<!-- End of Content Wrapper -->\r\n<!-- End of Page Wrapper -->\r\n<!-- Scroll to Top Button-->\r\n<!-- #endregion 備註 -->\r\n");
            WriteLiteral("\r\n<!-- Logout Modal-->\r\n");
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c599bf240894fd25e3a37e7e53d51905bd0b603410332", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c599bf240894fd25e3a37e7e53d51905bd0b603411432", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"


    <script>
    var ctx = document.getElementById('myChart')
    const selects = document.querySelectorAll("".myclass"")
    const theatername = document.getElementById(""theatername"")
    const S = document.getElementById(""select1"")



    S.addEventListener(""change"", async () => {

    let mytheater = S.options[S.selectedIndex].value
        console.log(mytheater)
    let response = await fetch(""");
#nullable restore
#line 163 "C:\MDA後台\ServerMDA\Views\HomePage\List.cshtml"
                           Write(Url.Content("~/List/HomePage"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""" + `?theatername=${mytheater}`)
    let datas = await response.json()

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
            datasets: [{

                    borderColor: window.chartColors.red,
                    backgroundColor: window.chartColors.red,
                    borderWidth: 1,
                    label: '數量',
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
    ");
                WriteLiteral("})\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CTheaterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
