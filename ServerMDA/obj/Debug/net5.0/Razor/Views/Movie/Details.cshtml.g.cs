#pragma checksum "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Movie\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4cd31f4c12c5d1a60ea5009aa9c988b4dfacd63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Details), @"mvc.1.0.view", @"/Views/Movie/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4cd31f4c12c5d1a60ea5009aa9c988b4dfacd63", @"/Views/Movie/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f44792abd596afd1ba2515f7ae3cd7cc9ca71375", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ServerMDA.ViewModel.CMovieViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bootstrap-5.2.2/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bootstrap-5.2.2/YukabtnEdit.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/bootstrap-5.2.2/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Movie\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d4cd31f4c12c5d1a60ea5009aa9c988b4dfacd635189", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d4cd31f4c12c5d1a60ea5009aa9c988b4dfacd636303", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d4cd31f4c12c5d1a60ea5009aa9c988b4dfacd637417", async() => {
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
            WriteLiteral("\r\n\r\n<div>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-3\">\r\n            ");
#nullable restore
#line 15 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Movie\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.電影編號movieId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-9\">\r\n            ");
#nullable restore
#line 18 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Movie\Details.cshtml"
       Write(Html.DisplayFor(model => model.電影編號movieId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-3\">\r\n            ");
#nullable restore
#line 21 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Movie\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.中文標題titleCht));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-9\">\r\n            ");
#nullable restore
#line 24 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Movie\Details.cshtml"
       Write(Html.DisplayFor(model => model.中文標題titleCht));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-3\">\r\n            ");
#nullable restore
#line 27 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Movie\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.英文標題titleEng));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-9\">\r\n            ");
#nullable restore
#line 30 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Movie\Details.cshtml"
       Write(Html.DisplayFor(model => model.英文標題titleEng));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-3\">\r\n            ");
#nullable restore
#line 33 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Movie\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.上映年份releaseYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-9\">\r\n            ");
#nullable restore
#line 36 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Movie\Details.cshtml"
       Write(Html.DisplayFor(model => model.上映年份releaseYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-3\">\r\n            ");
#nullable restore
#line 39 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Movie\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.上映日期releaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-9\">\r\n            ");
#nullable restore
#line 42 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Movie\Details.cshtml"
       Write(Html.DisplayFor(model => model.上映日期releaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-3\">\r\n            ");
#nullable restore
#line 45 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Movie\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.片長runtime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-9\">\r\n            ");
#nullable restore
#line 48 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Movie\Details.cshtml"
       Write(Html.DisplayFor(model => model.片長runtime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-3\">\r\n            演出名單\r\n        </dt>\r\n        <dd class=\"col-sm-9\">\r\n            <input type=\"hidden\" id=\"ratingId\"");
            BeginWriteAttribute("value", " value=\"", 1766, "\"", 1792, 1);
#nullable restore
#line 54 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Movie\Details.cshtml"
WriteAttributeValue("", 1774, Model.電影編號movieId, 1774, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <a class=\"btn btn-details mb-1\" id=\"btn\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1850, "\"", 1961, 3);
            WriteAttributeValue("", 1860, "showmodal(\'", 1860, 11, true);
#nullable restore
#line 55 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Movie\Details.cshtml"
WriteAttributeValue("", 1871, Url.Action("sortListDir","Cast",new {id=Model.電影編號movieId},Context.Request.Scheme), 1871, 83, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1954, "\',null)", 1954, 7, true);
            EndWriteAttribute();
            WriteLiteral(">導演</a>\r\n            <a class=\"btn btn-details mb-1\" id=\"btn\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2023, "\"", 2131, 3);
            WriteAttributeValue("", 2033, "showmodal(\'", 2033, 11, true);
#nullable restore
#line 56 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Movie\Details.cshtml"
WriteAttributeValue("", 2044, Url.Action("sortList","Cast",new {id=Model.電影編號movieId},Context.Request.Scheme), 2044, 80, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2124, "\',null)", 2124, 7, true);
            EndWriteAttribute();
            WriteLiteral(">演員</a>\r\n        </dd>\r\n        <dt class=\"col-sm-3\">\r\n            ");
#nullable restore
#line 59 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Movie\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.評分rate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-9\">\r\n            ");
#nullable restore
#line 62 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Movie\Details.cshtml"
       Write(Html.DisplayFor(model => model.評分rate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-3\">\r\n            ");
#nullable restore
#line 65 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Movie\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.期待度anticipation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-9\">\r\n            ");
#nullable restore
#line 68 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Movie\Details.cshtml"
       Write(Html.DisplayFor(model => model.期待度anticipation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-3\">\r\n            ");
#nullable restore
#line 71 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Movie\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.票房boxOffice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-9\">\r\n            ");
#nullable restore
#line 74 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Movie\Details.cshtml"
       Write(Html.DisplayFor(model => model.票房boxOffice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 77 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Movie\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.劇情大綱plot));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-9 offset-1\">\r\n            <textarea class=\"col-11 form-control\" rows=\"8\">");
#nullable restore
#line 80 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Movie\Details.cshtml"
                                                      Write(Html.DisplayFor(model => model.劇情大綱plot));

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n\r\n        </dd>\r\n        <dt class=\"col-sm-3\">\r\n            ");
#nullable restore
#line 84 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Movie\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.預告片trailer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-9\">\r\n            ");
#nullable restore
#line 87 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Movie\Details.cshtml"
       Write(Html.DisplayFor(model => model.預告片trailer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-3\">\r\n            ");
#nullable restore
#line 90 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Movie\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.系列編號seriesId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-9\">\r\n            ");
#nullable restore
#line 93 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Movie\Details.cshtml"
       Write(Html.DisplayFor(model => model.系列名稱seriesName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-3\">\r\n            ");
#nullable restore
#line 96 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Movie\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.分級級數ratingLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-9\">\r\n            ");
#nullable restore
#line 99 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Movie\Details.cshtml"
       Write(Html.DisplayFor(model => model.分級級數ratingLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div style=\"float:right\">\r\n    <a class=\"btn btn-yuka mb-1\" input=\"color\" id=\"btn\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3812, "\"", 3917, 3);
            WriteAttributeValue("", 3822, "showmodal(\'", 3822, 11, true);
#nullable restore
#line 104 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Movie\Details.cshtml"
WriteAttributeValue("", 3833, Url.Action("Edit","Movie",new {id=Model.電影編號movieId},Context.Request.Scheme), 3833, 77, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3910, "\',null)", 3910, 7, true);
            EndWriteAttribute();
            WriteLiteral(">修改電影內容</a>\r\n    <button type=\"button\" class=\"btn btn-secondary mb-1\" data-bs-dismiss=\"modal\" aria-label=\"Close\">回到清單</button>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4cd31f4c12c5d1a60ea5009aa9c988b4dfacd6319580", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServerMDA.ViewModel.CMovieViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
