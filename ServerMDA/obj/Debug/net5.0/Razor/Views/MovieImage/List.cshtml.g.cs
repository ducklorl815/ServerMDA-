<<<<<<< HEAD
#pragma checksum "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\MovieImage\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d27d1f0ef88cc819bc42e2015175760ed186a45"
=======
#pragma checksum "C:\MDA143後\ServerMDA\Views\MovieImage\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d27d1f0ef88cc819bc42e2015175760ed186a45"
>>>>>>> 187505558a020f182b185c827468fca8ce7582d3
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MovieImage_List), @"mvc.1.0.view", @"/Views/MovieImage/List.cshtml")]
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
#line 1 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\_ViewImports.cshtml"
=======
#line 1 "C:\MDA143後\ServerMDA\Views\_ViewImports.cshtml"
>>>>>>> 187505558a020f182b185c827468fca8ce7582d3
using ServerMDA;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\_ViewImports.cshtml"
=======
#line 2 "C:\MDA143後\ServerMDA\Views\_ViewImports.cshtml"
>>>>>>> 187505558a020f182b185c827468fca8ce7582d3
using ServerMDA.Models;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\MovieImage\List.cshtml"
=======
#line 2 "C:\MDA143後\ServerMDA\Views\MovieImage\List.cshtml"
>>>>>>> 187505558a020f182b185c827468fca8ce7582d3
using ServerMDA.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d27d1f0ef88cc819bc42e2015175760ed186a45", @"/Views/MovieImage/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f44792abd596afd1ba2515f7ae3cd7cc9ca71375", @"/Views/_ViewImports.cshtml")]
    public class Views_MovieImage_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CMovieImageViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("75"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/bootstrap-5.2.2/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/vendor/jquery/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/vendor/datatables/Datatable_transCht.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
<<<<<<< HEAD
#line 5 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\MovieImage\List.cshtml"
=======
#line 5 "C:\MDA143後\ServerMDA\Views\MovieImage\List.cshtml"
>>>>>>> 187505558a020f182b185c827468fca8ce7582d3
  
    ViewData["Title"] = "電影圖片清單";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n\r\n");
            }
            );
            WriteLiteral("\r\n<h3 class=\"MovieList\">\r\n    電影圖片清單\r\n    <a class=\"btn btn-success mb-1\"");
            BeginWriteAttribute("onclick", " onclick=\"", 264, "\"", 351, 3);
            WriteAttributeValue("", 274, "showmodal(\'", 274, 11, true);
#nullable restore
<<<<<<< HEAD
#line 15 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\MovieImage\List.cshtml"
=======
#line 15 "C:\MDA143後\ServerMDA\Views\MovieImage\List.cshtml"
>>>>>>> 187505558a020f182b185c827468fca8ce7582d3
WriteAttributeValue("", 285, Url.Action("Create", "MovieImage", Context.Request.Scheme), 285, 59, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 344, "\',null)", 344, 7, true);
            EndWriteAttribute();
            WriteLiteral(">新增</a>\r\n</h3>\r\n<div>\r\n    <table id=\"myTable\" class=\"table table-striped tables table-hover \">\r\n        <thead>\r\n            <tr style=\"white-space:nowrap\">\r\n                <th class=\"col-1\">\r\n                    ");
#nullable restore
<<<<<<< HEAD
#line 22 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\MovieImage\List.cshtml"
=======
#line 22 "C:\MDA143後\ServerMDA\Views\MovieImage\List.cshtml"
>>>>>>> 187505558a020f182b185c827468fca8ce7582d3
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().圖片image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
<<<<<<< HEAD
#line 25 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\MovieImage\List.cshtml"
=======
#line 25 "C:\MDA143後\ServerMDA\Views\MovieImage\List.cshtml"
>>>>>>> 187505558a020f182b185c827468fca8ce7582d3
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().電影名稱movieName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th class=\"col-1\">\r\n                    ");
#nullable restore
<<<<<<< HEAD
#line 28 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\MovieImage\List.cshtml"
=======
#line 28 "C:\MDA143後\ServerMDA\Views\MovieImage\List.cshtml"
>>>>>>> 187505558a020f182b185c827468fca8ce7582d3
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().圖片類型imageType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
<<<<<<< HEAD
#line 31 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\MovieImage\List.cshtml"
=======
#line 31 "C:\MDA143後\ServerMDA\Views\MovieImage\List.cshtml"
>>>>>>> 187505558a020f182b185c827468fca8ce7582d3
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().圖片雲端imageImdb));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th class=\"col-1\">\r\n                    ");
#nullable restore
<<<<<<< HEAD
#line 34 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\MovieImage\List.cshtml"
=======
#line 34 "C:\MDA143後\ServerMDA\Views\MovieImage\List.cshtml"
>>>>>>> 187505558a020f182b185c827468fca8ce7582d3
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().屏蔽invisible));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th class=\"col-1\">\r\n                    指令\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
<<<<<<< HEAD
#line 42 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\MovieImage\List.cshtml"
=======
#line 42 "C:\MDA143後\ServerMDA\Views\MovieImage\List.cshtml"
>>>>>>> 187505558a020f182b185c827468fca8ce7582d3
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr style=\"white-space:nowrap\">\r\n                    <td>\r\n                        <div>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4d27d1f0ef88cc819bc42e2015175760ed186a458314", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1553, "~/images/MovieImage/", 1553, 20, true);
#nullable restore
<<<<<<< HEAD
#line 47 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\MovieImage\List.cshtml"
=======
#line 47 "C:\MDA143後\ServerMDA\Views\MovieImage\List.cshtml"
>>>>>>> 187505558a020f182b185c827468fca8ce7582d3
AddHtmlAttributeValue("", 1573, item.圖片image, 1573, 13, false);

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
            WriteLiteral("\r\n                        </div>\r\n                    </td>\r\n                    <td class=\"tables_hidtext\">\r\n                        ");
#nullable restore
<<<<<<< HEAD
#line 51 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\MovieImage\List.cshtml"
=======
#line 51 "C:\MDA143後\ServerMDA\Views\MovieImage\List.cshtml"
>>>>>>> 187505558a020f182b185c827468fca8ce7582d3
                   Write(Html.DisplayFor(modelItem => item.電影名稱movieName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
<<<<<<< HEAD
#line 54 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\MovieImage\List.cshtml"
=======
#line 54 "C:\MDA143後\ServerMDA\Views\MovieImage\List.cshtml"
>>>>>>> 187505558a020f182b185c827468fca8ce7582d3
                   Write(Html.DisplayFor(modelItem => item.圖片類型imageType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"tables_hidtext\">\r\n                        ");
#nullable restore
<<<<<<< HEAD
#line 57 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\MovieImage\List.cshtml"
=======
#line 57 "C:\MDA143後\ServerMDA\Views\MovieImage\List.cshtml"
>>>>>>> 187505558a020f182b185c827468fca8ce7582d3
                   Write(Html.DisplayFor(modelItem => item.圖片雲端imageImdb));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
<<<<<<< HEAD
#line 60 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\MovieImage\List.cshtml"
=======
#line 60 "C:\MDA143後\ServerMDA\Views\MovieImage\List.cshtml"
>>>>>>> 187505558a020f182b185c827468fca8ce7582d3
                   Write(Html.DisplayFor(modelItem => item.屏蔽invisible));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <a class=\"btn btn btn-yuka mb-1\" id=\"btn\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2309, "\"", 2419, 3);
            WriteAttributeValue("", 2319, "showmodal(\'", 2319, 11, true);
#nullable restore
<<<<<<< HEAD
#line 63 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\MovieImage\List.cshtml"
=======
#line 63 "C:\MDA143後\ServerMDA\Views\MovieImage\List.cshtml"
>>>>>>> 187505558a020f182b185c827468fca8ce7582d3
WriteAttributeValue("", 2330, Url.Action("Edit","MovieImage",new {id=@item.圖片編號imageId},Context.Request.Scheme), 2330, 82, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2412, "\',null)", 2412, 7, true);
            EndWriteAttribute();
            WriteLiteral(">修改</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
<<<<<<< HEAD
#line 66 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\MovieImage\List.cshtml"
=======
#line 66 "C:\MDA143後\ServerMDA\Views\MovieImage\List.cshtml"
>>>>>>> 187505558a020f182b185c827468fca8ce7582d3
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
            <div class=""modal-body col-12 "">
            </div>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""sortstaticBackdrop"" data-bs-backdrop=""static"" data-bs-keyboard=""false"" tabindex=""-1"" aria-labelledby=""staticBackdropLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">
            <div class=""modal-body col-12 "">


            </div>
        </div>
    </div>
</div>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d27d1f0ef88cc819bc42e2015175760ed186a4513143", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d27d1f0ef88cc819bc42e2015175760ed186a4514183", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d27d1f0ef88cc819bc42e2015175760ed186a4515223", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CMovieImageViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
