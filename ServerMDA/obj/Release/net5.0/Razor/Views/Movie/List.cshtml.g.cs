#pragma checksum "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Movie\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6bb0fa75c4652ac02dca1192aac0a213f7e8861"
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
#line 1 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\_ViewImports.cshtml"
using ServerMDA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\_ViewImports.cshtml"
using ServerMDA.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Movie\List.cshtml"
using ServerMDA.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6bb0fa75c4652ac02dca1192aac0a213f7e8861", @"/Views/Movie/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f44792abd596afd1ba2515f7ae3cd7cc9ca71375", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CMovieViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bootstrap-5.2.2/YukabtnEdit.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-duck"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Movie", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateOneWay", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/vendor/jquery/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/vendor/datatables/Datatable_transCht.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Movie\List.cshtml"
  
    ViewData["Title"] = "????????????";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    <style>\r\n    </style>\r\n");
            }
            );
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e6bb0fa75c4652ac02dca1192aac0a213f7e88616535", async() => {
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
            WriteLiteral("\r\n\r\n<h3 class=\"MovieList\">\r\n    ????????????\r\n    <a class=\"btn btn-success\"");
            BeginWriteAttribute("onclick", " onclick=\"", 290, "\"", 372, 3);
            WriteAttributeValue("", 300, "showmodal(\'", 300, 11, true);
#nullable restore
#line 17 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Movie\List.cshtml"
WriteAttributeValue("", 311, Url.Action("Create", "Movie", Context.Request.Scheme), 311, 54, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 365, "\',null)", 365, 7, true);
            EndWriteAttribute();
            WriteLiteral(">??????</a>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6bb0fa75c4652ac02dca1192aac0a213f7e88618282", async() => {
                WriteLiteral("???????????????");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
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
#line 29 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Movie\List.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().????????????titleCht));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th class=\"col-2\">\r\n                    ");
#nullable restore
#line 32 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Movie\List.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().????????????titleEng));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n");
            WriteLiteral("                <th class=\"col-2\">\r\n                    ");
#nullable restore
#line 38 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Movie\List.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().????????????releaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th class=\"col-1\">\r\n                    ");
#nullable restore
#line 41 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Movie\List.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().??????runtime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th class=\"col-1\">\r\n                    ");
#nullable restore
#line 44 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Movie\List.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().??????rate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th class=\"col-1\">\r\n                    ");
#nullable restore
#line 47 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Movie\List.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().?????????anticipation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th class=\"col-2\">\r\n                    ");
#nullable restore
#line 50 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Movie\List.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().??????boxOffice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n");
            WriteLiteral("                <th class=\"col-1\">\r\n                    ");
#nullable restore
#line 56 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Movie\List.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().????????????seriesName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th class=\"col-1\">\r\n                    ");
#nullable restore
#line 59 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Movie\List.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().????????????ratingImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th style=\"width:100px\">\r\n                    ??????\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 67 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Movie\List.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr style=\"white-space:nowrap\">\r\n                <th class=\"col-1\">\r\n                    ");
#nullable restore
#line 71 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Movie\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.????????????movieId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <td class=\"tables_hidtext\">\r\n                    <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 2823, "\"", 2848, 1);
#nullable restore
#line 74 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Movie\List.cshtml"
WriteAttributeValue("", 2831, item.????????????movieId, 2831, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    ");
#nullable restore
#line 75 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Movie\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.????????????titleCht));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"tables_hidtext\">\r\n                    ");
#nullable restore
#line 78 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Movie\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.????????????titleEng));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
            WriteLiteral("                <td class=\"tables_hidtext\">\r\n                    ");
#nullable restore
#line 84 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Movie\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.????????????releaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 87 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Movie\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.??????runtime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 90 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Movie\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.??????rate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 93 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Movie\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.?????????anticipation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td style=\"white-space:pre-wrap pre-line pre\">\r\n                    ");
#nullable restore
#line 96 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Movie\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.??????boxOffice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
            WriteLiteral("                <td class=\"tables_hidtext\">\r\n                    ");
#nullable restore
#line 102 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Movie\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.????????????seriesName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("src", " src=\"", 4156, "\"", 4220, 1);
#nullable restore
#line 105 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Movie\List.cshtml"
WriteAttributeValue("", 4162, Url.Action("Edit","Cast", new {id= item.??????????????????ratingId }), 4162, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 4252, "\"", 4322, 1);
#nullable restore
#line 106 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Movie\List.cshtml"
WriteAttributeValue("", 4258, Url.Action("ShowPhoto","Movie", new {id= item.??????????????????ratingId }), 4258, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid w-50\" />\r\n                </td>\r\n                <td>\r\n                    <a class=\"btn btn-yuka \" id=\"btn\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4449, "\"", 4554, 3);
            WriteAttributeValue("", 4459, "showmodal(\'", 4459, 11, true);
#nullable restore
#line 109 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Movie\List.cshtml"
WriteAttributeValue("", 4470, Url.Action("Edit","Movie",new {id=@item.????????????movieId},Context.Request.Scheme), 4470, 77, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4547, "\',null)", 4547, 7, true);
            EndWriteAttribute();
            WriteLiteral(">??????</a>\r\n                    <a class=\"btn btn-details \" id=\"btn\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4620, "\"", 4728, 3);
            WriteAttributeValue("", 4630, "showmodal(\'", 4630, 11, true);
#nullable restore
#line 110 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Movie\List.cshtml"
WriteAttributeValue("", 4641, Url.Action("Details","Movie",new {id=@item.????????????movieId},Context.Request.Scheme), 4641, 80, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4721, "\',null)", 4721, 7, true);
            EndWriteAttribute();
            WriteLiteral(">??????</a>\r\n");
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 114 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Movie\List.cshtml"
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
    <div class=""modal-dialog modal-xl"">
        <div class=""modal-content"">
");
            WriteLiteral("            <div class=\"modal-body\">\r\n\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n                       \r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6bb0fa75c4652ac02dca1192aac0a213f7e886120962", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6bb0fa75c4652ac02dca1192aac0a213f7e886122002", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
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
    $(document).ready(function () {
        $('#myTable').DataTable();
    });
</script>

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
    showmodaloneway = (url, title) => {
        $.ajax({
            type: ""GET"",
            url: url,
            success: function (res) {
                $(""#sortstaticBackdrop .modal-body"").html(res);
                $(""#sortstaticBackdrop .modal-title"").html(title);
                $(""#sortstaticBackdrop"").modal('show');
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
