#pragma checksum "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Cast\sortListDir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32a5dbb8ecebbc48e272a1c7967f81747ae90c91"
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
#nullable restore
#line 1 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Cast\sortListDir.cshtml"
using ServerMDA.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32a5dbb8ecebbc48e272a1c7967f81747ae90c91", @"/Views/Cast/sortListDir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f44792abd596afd1ba2515f7ae3cd7cc9ca71375", @"/Views/_ViewImports.cshtml")]
    public class Views_Cast_sortListDir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CMovieDirectorViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bootstrap-5.2.2/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bootstrap-5.2.2/YukabtnEdit.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/bootstrap-5.2.2/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/vendor/jquery/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Cast\sortListDir.cshtml"
  
    ViewData["Title"] = "sortListDir";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    tr {\r\n        vertical-align: middle !important;\r\n        align-content: center !important;\r\n    }\r\n</style>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "32a5dbb8ecebbc48e272a1c7967f81747ae90c915894", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "32a5dbb8ecebbc48e272a1c7967f81747ae90c917008", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "32a5dbb8ecebbc48e272a1c7967f81747ae90c918122", async() => {
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
            WriteLiteral("\r\n\r\n<h5 class=\"MovieList\">\r\n    ");
#nullable restore
#line 20 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Cast\sortListDir.cshtml"
Write(Html.DisplayFor(modelItem => Model[1].中文標題titleCht));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <a class=\"btn btn-success mb-1\" id=\"btn\"");
            BeginWriteAttribute("onclick", " onclick=\"", 583, "\"", 692, 3);
            WriteAttributeValue("", 593, "showmodal(\'", 593, 11, true);
#nullable restore
#line 21 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Cast\sortListDir.cshtml"
WriteAttributeValue("", 604, Url.Action("Create","Cast",new {id=Model[1].電影編號movieId},Context.Request.Scheme), 604, 81, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 685, "\',null)", 685, 7, true);
            EndWriteAttribute();
            WriteLiteral(@">新增</a>
    <button type=""button"" class=""btn btn-secondary mb-1"" data-bs-dismiss=""modal"" aria-label=""Close"">回到清單</button>
</h5>

<div>
    <table id=""myTableSort"" class=""table table-striped table-hover tables col-12"">
        <thead>
            <tr>
                <th class=""col-1"">
                    ID
                </th>
                <th>
                    ");
#nullable restore
#line 33 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Cast\sortListDir.cshtml"
               Write(Html.DisplayFor(model => model.FirstOrDefault().電影編號movieId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 36 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Cast\sortListDir.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().中文名字nameCht));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 39 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Cast\sortListDir.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().英文名字nameEng));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    指令\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 47 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Cast\sortListDir.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 51 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Cast\sortListDir.cshtml"
               Write(Html.DisplayFor(modelItem => item.導演編號directorId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 54 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Cast\sortListDir.cshtml"
               Write(Html.DisplayFor(modelItem => item.中文標題titleCht));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <td>\r\n                    ");
#nullable restore
#line 57 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Cast\sortListDir.cshtml"
               Write(Html.DisplayFor(modelItem => item.中文名字nameCht));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 60 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Cast\sortListDir.cshtml"
               Write(Html.DisplayFor(modelItem => item.英文名字nameEng));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a class=\"btn btn-yuka mb-1\" id=\"btn\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2164, "\"", 2266, 3);
            WriteAttributeValue("", 2174, "showmodal(\'", 2174, 11, true);
#nullable restore
#line 63 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Cast\sortListDir.cshtml"
WriteAttributeValue("", 2185, Url.Action("Edit","Actor",new {id=@item.主演編號maId},Context.Request.Scheme), 2185, 74, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2259, "\',null)", 2259, 7, true);
            EndWriteAttribute();
            WriteLiteral(">修改</a>\r\n                    <a class=\"btn btn-info mb-1\" id=\"btn\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2333, "\"", 2438, 3);
            WriteAttributeValue("", 2343, "showmodal(\'", 2343, 11, true);
#nullable restore
#line 64 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Cast\sortListDir.cshtml"
WriteAttributeValue("", 2354, Url.Action("Details","Actor",new {id=@item.主演編號maId},Context.Request.Scheme), 2354, 77, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2431, "\',null)", 2431, 7, true);
            EndWriteAttribute();
            WriteLiteral(">細節</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 67 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Cast\sortListDir.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32a5dbb8ecebbc48e272a1c7967f81747ae90c9114897", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32a5dbb8ecebbc48e272a1c7967f81747ae90c9115941", async() => {
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
