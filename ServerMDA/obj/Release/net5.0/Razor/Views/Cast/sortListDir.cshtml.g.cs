#pragma checksum "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Cast\sortListDir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "040f87464f92ec7811786e387415c61f5a88dc78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cast_sortListDir), @"mvc.1.0.view", @"/Views/Cast/sortListDir.cshtml")]
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
#line 1 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Cast\sortListDir.cshtml"
using ServerMDA.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"040f87464f92ec7811786e387415c61f5a88dc78", @"/Views/Cast/sortListDir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f44792abd596afd1ba2515f7ae3cd7cc9ca71375", @"/Views/_ViewImports.cshtml")]
    public class Views_Cast_sortListDir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CMovieDirectorViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bootstrap-5.2.2/YukabtnEdit.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/vendor/jquery/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Cast\sortListDir.cshtml"
  
    ViewData["Title"] = "sortListDir";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    tr {\r\n        vertical-align: middle !important;\r\n        align-content: center !important;\r\n    }\r\n</style>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "040f87464f92ec7811786e387415c61f5a88dc785146", async() => {
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
            WriteLiteral("\r\n\r\n\r\n<h5 class=\"MovieList\" style=\"float:left\">\r\n    ");
#nullable restore
#line 20 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Cast\sortListDir.cshtml"
Write(Html.DisplayFor(modelItem => Model[0].中文標題titleCht));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</h5>\r\n\r\n<div style=\"float:right; margin-bottom:5px\">\r\n    <a class=\"btn btn-success mb-1\" id=\"btn\"");
            BeginWriteAttribute("onclick", " onclick=\"", 538, "\"", 650, 3);
            WriteAttributeValue("", 548, "showmodal(\'", 548, 11, true);
#nullable restore
#line 24 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Cast\sortListDir.cshtml"
WriteAttributeValue("", 559, Url.Action("CreateDir","Cast",new {id=Model[0].電影編號movieId},Context.Request.Scheme), 559, 84, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 643, "\',null)", 643, 7, true);
            EndWriteAttribute();
            WriteLiteral(@">新增導演</a>
    <button type=""button"" class=""btn btn-secondary mb-1"" data-bs-dismiss=""modal"" aria-label=""Close"">回到清單</button>
</div>

<div>
    <table id=""myTable"" class=""table table-striped table-hover tables col-12"">
        <thead>
            <tr>
                <th class=""col-1"">
                    ID
                </th>
                <th style=""width:120px"">
                    ");
#nullable restore
#line 36 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Cast\sortListDir.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().導演照片image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th class=\"col-2\">\r\n                    ");
#nullable restore
#line 39 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Cast\sortListDir.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().導演中文名字nameCht));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th class=\"col-3\">\r\n                    ");
#nullable restore
#line 42 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Cast\sortListDir.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().導演英文名字nameEng));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th class=\"col-3\">\r\n                    指令\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 50 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Cast\sortListDir.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th>\r\n                        ");
#nullable restore
#line 54 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Cast\sortListDir.cshtml"
                   Write(Html.DisplayFor(modelItem => item.導演編號directorId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <td>\r\n                        <div>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "040f87464f92ec7811786e387415c61f5a88dc789595", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1878, "~/images/Director/", 1878, 18, true);
#nullable restore
#line 58 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Cast\sortListDir.cshtml"
AddHtmlAttributeValue("", 1896, item.導演照片image, 1896, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 62 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Cast\sortListDir.cshtml"
                   Write(Html.DisplayFor(modelItem => item.導演中文名字nameCht));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 65 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Cast\sortListDir.cshtml"
                   Write(Html.DisplayFor(modelItem => item.導演英文名字nameEng));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <a class=\"btn btn-yuka mb-1\" id=\"btn\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2339, "\"", 2450, 3);
            WriteAttributeValue("", 2349, "showmodal(\'", 2349, 11, true);
#nullable restore
#line 68 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Cast\sortListDir.cshtml"
WriteAttributeValue("", 2360, Url.Action("Edit","Director",new {id=@item.導演編號directorId},Context.Request.Scheme), 2360, 83, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2443, "\',null)", 2443, 7, true);
            EndWriteAttribute();
            WriteLiteral(">修改</a>\r\n");
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 72 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Cast\sortListDir.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "040f87464f92ec7811786e387415c61f5a88dc7812961", async() => {
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
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CMovieDirectorViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591