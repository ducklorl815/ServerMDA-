#pragma checksum "C:\MDA後台\ServerMDA\Views\Cast\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0c690ce6adc6c6c1711f6a1d0ec0da62544ab76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cast_List), @"mvc.1.0.view", @"/Views/Cast/List.cshtml")]
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
#line 1 "C:\MDA後台\ServerMDA\Views\Cast\List.cshtml"
using ServerMDA.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0c690ce6adc6c6c1711f6a1d0ec0da62544ab76", @"/Views/Cast/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f44792abd596afd1ba2515f7ae3cd7cc9ca71375", @"/Views/_ViewImports.cshtml")]
    public class Views_Cast_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CCastViewModel>>
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
#line 4 "C:\MDA後台\ServerMDA\Views\Cast\List.cshtml"
  
    ViewData["Title"] = "主演清單";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3 class=\"MovieList\">\r\n    電影圖片清單\r\n");
            WriteLiteral("\r\n    <a class=\"btn btn-success mb-1\"");
            BeginWriteAttribute("onclick", " onclick=\"", 310, "\"", 391, 3);
            WriteAttributeValue("", 320, "showmodal(\'", 320, 11, true);
#nullable restore
#line 12 "C:\MDA後台\ServerMDA\Views\Cast\List.cshtml"
WriteAttributeValue("", 331, Url.Action("Create", "Cast", Context.Request.Scheme), 331, 53, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 384, "\',null)", 384, 7, true);
            EndWriteAttribute();
            WriteLiteral(">新增</a>\r\n</h3>\r\n<table id=\"myTable\" class=\"table table-striped tables table-hover \">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\MDA後台\ServerMDA\Views\Cast\List.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstOrDefault().角色名字characterName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\MDA後台\ServerMDA\Views\Cast\List.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstOrDefault().角色說明characterIllustrate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\MDA後台\ServerMDA\Views\Cast\List.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstOrDefault().演員中文名字nameCht));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\MDA後台\ServerMDA\Views\Cast\List.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstOrDefault().中文標題titleCht));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th class=\"col-1\">\r\n                指令\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 35 "C:\MDA後台\ServerMDA\Views\Cast\List.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr style=\"white-space:nowrap\">\r\n                <td>\r\n                    ");
#nullable restore
#line 39 "C:\MDA後台\ServerMDA\Views\Cast\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.角色名字characterName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"tables_hidtext\">\r\n                    ");
#nullable restore
#line 42 "C:\MDA後台\ServerMDA\Views\Cast\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.角色說明characterIllustrate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 45 "C:\MDA後台\ServerMDA\Views\Cast\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.演員中文名字nameCht));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 48 "C:\MDA後台\ServerMDA\Views\Cast\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.中文標題titleCht));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a class=\"btn btn btn-yuka mb-1\" id=\"btn\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1796, "\"", 1900, 3);
            WriteAttributeValue("", 1806, "showmodal(\'", 1806, 11, true);
#nullable restore
#line 51 "C:\MDA後台\ServerMDA\Views\Cast\List.cshtml"
WriteAttributeValue("", 1817, Url.Action("Edit","Cast",new {id=@item.電影編號movieId},Context.Request.Scheme), 1817, 76, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1893, "\',null)", 1893, 7, true);
            EndWriteAttribute();
            WriteLiteral(">修改</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 54 "C:\MDA後台\ServerMDA\Views\Cast\List.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<div class=""modal fade"" id=""newstaticBackdrop"" data-bs-backdrop=""static"" data-bs-keyboard=""false"" tabindex=""-1"" aria-labelledby=""staticBackdropLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-xl"">
        <div class=""modal-content"">
            <div class=""modal-body col-12 "">
            </div>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""sortstaticBackdrop"" data-bs-backdrop=""static"" data-bs-keyboard=""false"" tabindex=""-1"" aria-labelledby=""staticBackdropLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-xl"">
        <div class=""modal-content"">
            <div class=""modal-body col-12 "">


            </div>
        </div>
    </div>
</div>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0c690ce6adc6c6c1711f6a1d0ec0da62544ab769687", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0c690ce6adc6c6c1711f6a1d0ec0da62544ab7610726", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0c690ce6adc6c6c1711f6a1d0ec0da62544ab7611766", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CCastViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
