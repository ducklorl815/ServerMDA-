#pragma checksum "C:\Users\duckl\Documents\ServerMDA- - 複製\ServerMDA\Views\Movie\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7c143258a70b40d1aae6557d30b3c4fb1d48e20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_List), @"mvc.1.0.view", @"/Views/Movie/List.cshtml")]
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
#line 1 "C:\Users\duckl\Documents\ServerMDA- - 複製\ServerMDA\Views\_ViewImports.cshtml"
using ServerMDA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\duckl\Documents\ServerMDA- - 複製\ServerMDA\Views\_ViewImports.cshtml"
using ServerMDA.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\duckl\Documents\ServerMDA- - 複製\ServerMDA\Views\Movie\List.cshtml"
using ServerMDA.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7c143258a70b40d1aae6557d30b3c4fb1d48e20", @"/Views/Movie/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f44792abd596afd1ba2515f7ae3cd7cc9ca71375", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CMovieViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/datatables/jquery.dataTables.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/sb-admin-2.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/vendor/jquery/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/vendor/datatables/jquery.dataTables.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\duckl\Documents\ServerMDA- - 複製\ServerMDA\Views\Movie\List.cshtml"
  
    ViewData["Title"] = "電影清單";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e7c143258a70b40d1aae6557d30b3c4fb1d48e206052", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e7c143258a70b40d1aae6557d30b3c4fb1d48e207166", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e7c143258a70b40d1aae6557d30b3c4fb1d48e208280", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e7c143258a70b40d1aae6557d30b3c4fb1d48e209395", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<h2>電影清單</h2> <a class=\"btn btn-info mb-1\"");
            BeginWriteAttribute("onclick", " onclick=\"", 381, "\"", 461, 3);
            WriteAttributeValue("", 391, "showmodal(\'", 391, 11, true);
#nullable restore
#line 14 "C:\Users\duckl\Documents\ServerMDA- - 複製\ServerMDA\Views\Movie\List.cshtml"
WriteAttributeValue("", 402, Url.Action("Create","Movie",Context.Request.Scheme), 402, 52, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 454, "\',null)", 454, 7, true);
            EndWriteAttribute();
            WriteLiteral(">新增</a>\r\n<div>\r\n    <table id=\"table_id\" class=\"table table-striped table-hover tables col-12\">\r\n        <thead>\r\n            <tr style=\"white-space:nowrap\">\r\n                <th class=\"col-2\">\r\n                    ");
#nullable restore
#line 20 "C:\Users\duckl\Documents\ServerMDA- - 複製\ServerMDA\Views\Movie\List.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().中文標題titleCht));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th class=\"col-2\">\r\n                    ");
#nullable restore
#line 23 "C:\Users\duckl\Documents\ServerMDA- - 複製\ServerMDA\Views\Movie\List.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().英文標題titleEng));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th class=\"col-1\">\r\n                    ");
#nullable restore
#line 26 "C:\Users\duckl\Documents\ServerMDA- - 複製\ServerMDA\Views\Movie\List.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().上映年份releaseYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th class=\"col-1\">\r\n                    ");
#nullable restore
#line 29 "C:\Users\duckl\Documents\ServerMDA- - 複製\ServerMDA\Views\Movie\List.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().上映日期releaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th class=\"col-1\">\r\n                    ");
#nullable restore
#line 32 "C:\Users\duckl\Documents\ServerMDA- - 複製\ServerMDA\Views\Movie\List.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().片長runtime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th class=\"col-1\">\r\n                    ");
#nullable restore
#line 35 "C:\Users\duckl\Documents\ServerMDA- - 複製\ServerMDA\Views\Movie\List.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().評分rate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th class=\"col-1\">\r\n                    ");
#nullable restore
#line 38 "C:\Users\duckl\Documents\ServerMDA- - 複製\ServerMDA\Views\Movie\List.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().期待度anticipation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th class=\"col-1\">\r\n                    ");
#nullable restore
#line 41 "C:\Users\duckl\Documents\ServerMDA- - 複製\ServerMDA\Views\Movie\List.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().票房boxOffice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th class=\"col-1\">\r\n                    ");
#nullable restore
#line 44 "C:\Users\duckl\Documents\ServerMDA- - 複製\ServerMDA\Views\Movie\List.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().劇情大綱plot));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th class=\"col-1\">\r\n                    ");
#nullable restore
#line 47 "C:\Users\duckl\Documents\ServerMDA- - 複製\ServerMDA\Views\Movie\List.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().系列名稱seriesName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th class=\"col-1\">\r\n                    ");
#nullable restore
#line 50 "C:\Users\duckl\Documents\ServerMDA- - 複製\ServerMDA\Views\Movie\List.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().分級圖片ratingImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th class=\"col-1\">\r\n                    指令\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 58 "C:\Users\duckl\Documents\ServerMDA- - 複製\ServerMDA\Views\Movie\List.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr style=\"white-space:nowrap\">\r\n                <td class=\"tables_hidtext\">\r\n                    ");
#nullable restore
#line 62 "C:\Users\duckl\Documents\ServerMDA- - 複製\ServerMDA\Views\Movie\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.中文標題titleCht));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"tables_hidtext\">\r\n                    ");
#nullable restore
#line 65 "C:\Users\duckl\Documents\ServerMDA- - 複製\ServerMDA\Views\Movie\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.英文標題titleEng));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"tables_hidtext\">\r\n                    ");
#nullable restore
#line 68 "C:\Users\duckl\Documents\ServerMDA- - 複製\ServerMDA\Views\Movie\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.上映年份releaseYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"tables_hidtext\">\r\n                    ");
#nullable restore
#line 71 "C:\Users\duckl\Documents\ServerMDA- - 複製\ServerMDA\Views\Movie\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.上映日期releaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 74 "C:\Users\duckl\Documents\ServerMDA- - 複製\ServerMDA\Views\Movie\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.片長runtime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 77 "C:\Users\duckl\Documents\ServerMDA- - 複製\ServerMDA\Views\Movie\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.評分rate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 80 "C:\Users\duckl\Documents\ServerMDA- - 複製\ServerMDA\Views\Movie\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.期待度anticipation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"tables_hidtext\">\r\n                    ");
#nullable restore
#line 83 "C:\Users\duckl\Documents\ServerMDA- - 複製\ServerMDA\Views\Movie\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.票房boxOffice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"tables_hidtext\">\r\n                    ");
#nullable restore
#line 86 "C:\Users\duckl\Documents\ServerMDA- - 複製\ServerMDA\Views\Movie\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.劇情大綱plot));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"tables_hidtext\">\r\n                    ");
#nullable restore
#line 89 "C:\Users\duckl\Documents\ServerMDA- - 複製\ServerMDA\Views\Movie\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.系列名稱seriesName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("src", " src=\"", 3829, "\"", 3893, 1);
#nullable restore
#line 92 "C:\Users\duckl\Documents\ServerMDA- - 複製\ServerMDA\Views\Movie\List.cshtml"
WriteAttributeValue("", 3835, Url.Action("Edit","Cast", new {id= item.電影分級編號ratingId }), 3835, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 3925, "\"", 3995, 1);
#nullable restore
#line 93 "C:\Users\duckl\Documents\ServerMDA- - 複製\ServerMDA\Views\Movie\List.cshtml"
WriteAttributeValue("", 3931, Url.Action("ShowPhoto","Movie", new {id= item.電影分級編號ratingId }), 3931, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-thumbnail w-50\" />\r\n                </td>\r\n                <td>\r\n                    <a class=\"btn btn-info mb-1\" id=\"btn\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4130, "\"", 4235, 3);
            WriteAttributeValue("", 4140, "showmodal(\'", 4140, 11, true);
#nullable restore
#line 96 "C:\Users\duckl\Documents\ServerMDA- - 複製\ServerMDA\Views\Movie\List.cshtml"
WriteAttributeValue("", 4151, Url.Action("Edit","Movie",new {id=@item.電影編號movieId},Context.Request.Scheme), 4151, 77, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4228, "\',null)", 4228, 7, true);
            EndWriteAttribute();
            WriteLiteral(">修改</a>\r\n");
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 100 "C:\Users\duckl\Documents\ServerMDA- - 複製\ServerMDA\Views\Movie\List.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>
</div>

<div class=""modal fade"" id=""newstaticBackdrop"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-xl"">
        <div class=""modal-content"">
            <div class=""modal-title"">


            </div>
            <div class=""modal-body"">


            </div>
        </div>
    </div>
</div>


");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7c143258a70b40d1aae6557d30b3c4fb1d48e2021561", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

    <script>
        $(document).ready(function () {
            $('#table_id').DataTable();
        });
    </script>

    <script type=""text/javascript"" charset=""utf8"" src=""https://cdn.datatables.net/1.12.1/js/jquery.dataTables.js""></script>


<script>
    showmodal = (url, title) => {
        $.ajax({
            type: ""GET"",
            url: url,
            success: function (res) {
                $(""#newstaticBackdrop .modal-body"").html(res);
                $(""#newstaticBackdrop .modal-title"").html(title);
                $(""#newstaticBackdrop"").modal('show');
            }
        })
    }
</script>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7c143258a70b40d1aae6557d30b3c4fb1d48e2023254", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script>\r\n    //$.on(\'hidden.bs.modal\', function () {\r\n    //    alert(\'The modal is completely hidden now!\');\r\n    //});\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CMovieViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
