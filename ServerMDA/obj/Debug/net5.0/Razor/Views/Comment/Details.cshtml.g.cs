#pragma checksum "C:\Users\jo3wait\Documents\ServerMDA-\ServerMDA\Views\Comment\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a03a82a0c13746dcef913c3ca42ca73b74bc6495"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comment_Details), @"mvc.1.0.view", @"/Views/Comment/Details.cshtml")]
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
#line 1 "C:\Users\jo3wait\Documents\ServerMDA-\ServerMDA\Views\_ViewImports.cshtml"
using ServerMDA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jo3wait\Documents\ServerMDA-\ServerMDA\Views\_ViewImports.cshtml"
using ServerMDA.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\jo3wait\Documents\ServerMDA-\ServerMDA\Views\Comment\Details.cshtml"
using ServerMDA.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a03a82a0c13746dcef913c3ca42ca73b74bc6495", @"/Views/Comment/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f44792abd596afd1ba2515f7ae3cd7cc9ca71375", @"/Views/_ViewImports.cshtml")]
    public class Views_Comment_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CCommentViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bootstrap-5.2.2/YukabtnEdit.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\jo3wait\Documents\ServerMDA-\ServerMDA\Views\Comment\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a03a82a0c13746dcef913c3ca42ca73b74bc64954263", async() => {
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
            WriteLiteral("\r\n\r\n<div>\r\n    <h5>會員(");
#nullable restore
#line 12 "C:\Users\jo3wait\Documents\ServerMDA-\ServerMDA\Views\Comment\Details.cshtml"
      Write(Model.會員編號memberId);

#line default
#line hidden
#nullable disable
            WriteLiteral("):  ");
#nullable restore
#line 12 "C:\Users\jo3wait\Documents\ServerMDA-\ServerMDA\Views\Comment\Details.cshtml"
                             Write(Model.姓氏lName);

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\jo3wait\Documents\ServerMDA-\ServerMDA\Views\Comment\Details.cshtml"
                                           Write(Model.名字fName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" 對 <");
#nullable restore
#line 12 "C:\Users\jo3wait\Documents\ServerMDA-\ServerMDA\Views\Comment\Details.cshtml"
                                                             Write(Model.中文標題titleCht);

#line default
#line hidden
#nullable disable
            WriteLiteral("> 的電影評論</h5>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 15 "C:\Users\jo3wait\Documents\ServerMDA-\ServerMDA\Views\Comment\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.中文標題titleCht));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 18 "C:\Users\jo3wait\Documents\ServerMDA-\ServerMDA\Views\Comment\Details.cshtml"
       Write(Html.DisplayFor(model => model.中文標題titleCht));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 21 "C:\Users\jo3wait\Documents\ServerMDA-\ServerMDA\Views\Comment\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.評論標題commentTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 24 "C:\Users\jo3wait\Documents\ServerMDA-\ServerMDA\Views\Comment\Details.cshtml"
       Write(Html.DisplayFor(model => model.評論標題commentTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 27 "C:\Users\jo3wait\Documents\ServerMDA-\ServerMDA\Views\Comment\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.評論內容comments));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 30 "C:\Users\jo3wait\Documents\ServerMDA-\ServerMDA\Views\Comment\Details.cshtml"
       Write(Html.DisplayFor(model => model.評論內容comments));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 33 "C:\Users\jo3wait\Documents\ServerMDA-\ServerMDA\Views\Comment\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.評分rate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 36 "C:\Users\jo3wait\Documents\ServerMDA-\ServerMDA\Views\Comment\Details.cshtml"
       Write(Html.DisplayFor(model => model.評分rate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 39 "C:\Users\jo3wait\Documents\ServerMDA-\ServerMDA\Views\Comment\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.期待度anticipation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 42 "C:\Users\jo3wait\Documents\ServerMDA-\ServerMDA\Views\Comment\Details.cshtml"
       Write(Html.DisplayFor(model => model.期待度anticipation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 45 "C:\Users\jo3wait\Documents\ServerMDA-\ServerMDA\Views\Comment\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.發佈時間commentTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 48 "C:\Users\jo3wait\Documents\ServerMDA-\ServerMDA\Views\Comment\Details.cshtml"
       Write(Html.DisplayFor(model => model.發佈時間commentTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 51 "C:\Users\jo3wait\Documents\ServerMDA-\ServerMDA\Views\Comment\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.觀影日期viewingTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 54 "C:\Users\jo3wait\Documents\ServerMDA-\ServerMDA\Views\Comment\Details.cshtml"
       Write(Html.DisplayFor(model => model.觀影日期viewingTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 57 "C:\Users\jo3wait\Documents\ServerMDA-\ServerMDA\Views\Comment\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.觀影方式source));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 60 "C:\Users\jo3wait\Documents\ServerMDA-\ServerMDA\Views\Comment\Details.cshtml"
       Write(Html.DisplayFor(model => model.觀影方式source));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 63 "C:\Users\jo3wait\Documents\ServerMDA-\ServerMDA\Views\Comment\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.是否開放討論串oxFloor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 66 "C:\Users\jo3wait\Documents\ServerMDA-\ServerMDA\Views\Comment\Details.cshtml"
       Write(Html.DisplayFor(model => model.是否開放討論串oxFloor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 69 "C:\Users\jo3wait\Documents\ServerMDA-\ServerMDA\Views\Comment\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.屏蔽invisible));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 72 "C:\Users\jo3wait\Documents\ServerMDA-\ServerMDA\Views\Comment\Details.cshtml"
       Write(Html.DisplayFor(model => model.屏蔽invisible));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 75 "C:\Users\jo3wait\Documents\ServerMDA-\ServerMDA\Views\Comment\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.公開等級public));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 78 "C:\Users\jo3wait\Documents\ServerMDA-\ServerMDA\Views\Comment\Details.cshtml"
       Write(Html.DisplayFor(model => model.公開等級public));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n");
            WriteLiteral("    </dl>\r\n</div>\r\n<div style=\"float:right\">\r\n    <a class=\"btn btn-yuka mb-1\" input=\"color\" id=\"btn\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3005, "\"", 3112, 3);
            WriteAttributeValue("", 3015, "showmodal(\'", 3015, 11, true);
#nullable restore
#line 89 "C:\Users\jo3wait\Documents\ServerMDA-\ServerMDA\Views\Comment\Details.cshtml"
WriteAttributeValue("", 3026, Url.Action("Edit","Comment",new {id=Model.電影編號movieId},Context.Request.Scheme), 3026, 79, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3105, "\',null)", 3105, 7, true);
            EndWriteAttribute();
            WriteLiteral(">修改評論內容</a>\r\n    <button type=\"button\" class=\"btn btn-secondary mb-1\" data-bs-dismiss=\"modal\" aria-label=\"Close\">回到清單</button>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CCommentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
