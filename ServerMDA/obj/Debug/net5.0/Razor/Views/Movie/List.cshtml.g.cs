#pragma checksum "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Movie\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a742e29837447e96e3e5dd13ddc6327920a9c7b"
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
#line 1 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\_ViewImports.cshtml"
using ServerMDA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\_ViewImports.cshtml"
using ServerMDA.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Movie\List.cshtml"
using ServerMDA.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a742e29837447e96e3e5dd13ddc6327920a9c7b", @"/Views/Movie/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f44792abd596afd1ba2515f7ae3cd7cc9ca71375", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CMovieViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/bootstrap-5.2.2/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/vendor/jquery/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/vendor/datatables/Datatable_transCht.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Movie\List.cshtml"
  
    ViewData["Title"] = "電影清單";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    <style>\r\n    </style>\r\n");
            }
            );
            WriteLiteral("\r\n\r\n<h3 class=\"MovieList\">電影清單 \r\n    <a class=\"btn btn-success mb-1\"");
            BeginWriteAttribute("onclick", " onclick=\"", 218, "\"", 300, 3);
            WriteAttributeValue("", 228, "showmodal(\'", 228, 11, true);
#nullable restore
#line 15 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Movie\List.cshtml"
WriteAttributeValue("", 239, Url.Action("Create", "Movie", Context.Request.Scheme), 239, 54, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 293, "\',null)", 293, 7, true);
            EndWriteAttribute();
            WriteLiteral(@">新增</a>
    </h3>

<div>
    <table id=""myTable"" class=""table tables display compact hover col-12"">
        <thead>
            <tr style=""white-space:nowrap"">
                <th style=""width:25px"">
                    ID
                </th>
                <th class=""col-3"">
                    ");
#nullable restore
#line 26 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Movie\List.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().中文標題titleCht));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th class=\"col-2\">\r\n                    ");
#nullable restore
#line 29 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Movie\List.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().英文標題titleEng));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n");
            WriteLiteral("                <th class=\"col-2\">\r\n                    ");
#nullable restore
#line 35 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Movie\List.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().上映日期releaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th class=\"col-1\">\r\n                    ");
#nullable restore
#line 38 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Movie\List.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().片長runtime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th class=\"col-1\">\r\n                    ");
#nullable restore
#line 41 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Movie\List.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().評分rate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th class=\"col-1\">\r\n                    ");
#nullable restore
#line 44 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Movie\List.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().期待度anticipation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th style=\"width:75px\">\r\n                    ");
#nullable restore
#line 47 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Movie\List.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().票房boxOffice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n");
            WriteLiteral("                <th class=\"col-1\">\r\n                    ");
#nullable restore
#line 53 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Movie\List.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().系列名稱seriesName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th class=\"col-1\">\r\n                    ");
#nullable restore
#line 56 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Movie\List.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().分級圖片ratingImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th style=\"width:100px\">\r\n                    指令\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 64 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Movie\List.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr style=\"white-space:nowrap\">\r\n                    <th class=\"col-1\">\r\n                        ");
#nullable restore
#line 68 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Movie\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.電影編號movieId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <td>\r\n                        <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 2661, "\"", 2686, 1);
#nullable restore
#line 71 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Movie\List.cshtml"
WriteAttributeValue("", 2669, item.電影編號movieId, 2669, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        ");
#nullable restore
#line 72 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Movie\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.中文標題titleCht));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"tables_hidtext\">\r\n                        ");
#nullable restore
#line 75 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Movie\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.英文標題titleEng));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
            WriteLiteral("                    <td class=\"tables_hidtext\">\r\n                        ");
#nullable restore
#line 81 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Movie\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.上映日期releaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 84 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Movie\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.片長runtime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 87 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Movie\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.評分rate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 90 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Movie\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.期待度anticipation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"tables_hidtext\">\r\n                        ");
#nullable restore
#line 93 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Movie\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.票房boxOffice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
            WriteLiteral("                    <td class=\"tables_hidtext\">\r\n                        ");
#nullable restore
#line 99 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Movie\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.系列名稱seriesName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("src", " src=\"", 4147, "\"", 4211, 1);
#nullable restore
#line 102 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Movie\List.cshtml"
WriteAttributeValue("", 4153, Url.Action("Edit","Cast", new {id= item.電影分級編號ratingId }), 4153, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 4247, "\"", 4317, 1);
#nullable restore
#line 103 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Movie\List.cshtml"
WriteAttributeValue("", 4253, Url.Action("ShowPhoto","Movie", new {id= item.電影分級編號ratingId }), 4253, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid w-50\" />\r\n                    </td>\r\n                    <td>\r\n                        <a class=\"btn btn-yuka \" id=\"btn\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4456, "\"", 4561, 3);
            WriteAttributeValue("", 4466, "showmodal(\'", 4466, 11, true);
#nullable restore
#line 106 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Movie\List.cshtml"
WriteAttributeValue("", 4477, Url.Action("Edit","Movie",new {id=@item.電影編號movieId},Context.Request.Scheme), 4477, 77, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4554, "\',null)", 4554, 7, true);
            EndWriteAttribute();
            WriteLiteral(">修改</a>\r\n                        <a class=\"btn btn-details \" id=\"btn\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4631, "\"", 4739, 3);
            WriteAttributeValue("", 4641, "showmodal(\'", 4641, 11, true);
#nullable restore
#line 107 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Movie\List.cshtml"
WriteAttributeValue("", 4652, Url.Action("Details","Movie",new {id=@item.電影編號movieId},Context.Request.Scheme), 4652, 80, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4732, "\',null)", 4732, 7, true);
            EndWriteAttribute();
            WriteLiteral(">細節</a>\r\n");
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 111 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Movie\List.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>
</div>

<div class=""modal fade"" id=""newstaticBackdrop"" data-bs-backdrop=""static"" data-bs-keyboard=""false"" tabindex=""-1"" aria-labelledby=""staticBackdropLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">
");
            WriteLiteral(@"            <div class=""modal-body"">


            </div>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""sortstaticBackdrop"" data-bs-backdrop=""static"" data-bs-keyboard=""false"" tabindex=""-1"" aria-labelledby=""staticBackdropLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">
");
            WriteLiteral(@"            <div class=""modal-body"">


            </div>
        </div>
    </div>
</div>

<!-- Modal -->
<!--<div class=""modal fade"" id=""newstaticBackdrop"" data-bs-backdrop=""static"" data-bs-keyboard=""false"" tabindex=""-1"" aria-labelledby=""staticBackdropLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h1 class=""modal-title fs-5"" id=""newstaticBackdrop"">Modal title</h1>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
                ...
            </div>
        </div>
    </div>
</div>-->


");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a742e29837447e96e3e5dd13ddc6327920a9c7b18398", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a742e29837447e96e3e5dd13ddc6327920a9c7b19438", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a742e29837447e96e3e5dd13ddc6327920a9c7b20478", async() => {
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
            },
        })
    }
</script>");
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
