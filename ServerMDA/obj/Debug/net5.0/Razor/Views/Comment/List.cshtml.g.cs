#pragma checksum "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Comment\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e58370e6ff49b17b4edf615ae3a3ab0ee7f2af05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comment_List), @"mvc.1.0.view", @"/Views/Comment/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e58370e6ff49b17b4edf615ae3a3ab0ee7f2af05", @"/Views/Comment/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f44792abd596afd1ba2515f7ae3cd7cc9ca71375", @"/Views/_ViewImports.cshtml")]
    public class Views_Comment_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ServerMDA.Models.電影評論movieComment>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning mb-1  ml-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info mb-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("white-space:nowrap"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Comment\List.cshtml"
  
    ViewData["Title"] = "電影評論";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e58370e6ff49b17b4edf615ae3a3ab0ee7f2af055969", async() => {
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
            WriteLiteral("\r\n\r\n<h2>電影評論");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e58370e6ff49b17b4edf615ae3a3ab0ee7f2af057095", async() => {
                WriteLiteral("新增");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h2>\r\n<table class=\"table table-striped table-hover tables\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Comment\List.cshtml"
           Write(Html.DisplayNameFor(model => model.會員編號memberId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Comment\List.cshtml"
           Write(Html.DisplayNameFor(model => model.評分rate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Comment\List.cshtml"
           Write(Html.DisplayNameFor(model => model.期待度anticipation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Comment\List.cshtml"
           Write(Html.DisplayNameFor(model => model.評論標題commentTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Comment\List.cshtml"
           Write(Html.DisplayNameFor(model => model.評論內容comments));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Comment\List.cshtml"
           Write(Html.DisplayNameFor(model => model.發佈時間commentTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Comment\List.cshtml"
           Write(Html.DisplayNameFor(model => model.觀影日期viewingTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Comment\List.cshtml"
           Write(Html.DisplayNameFor(model => model.觀影方式source));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Comment\List.cshtml"
           Write(Html.DisplayNameFor(model => model.是否開放討論串oxFloor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Comment\List.cshtml"
           Write(Html.DisplayNameFor(model => model.屏蔽invisible));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Comment\List.cshtml"
           Write(Html.DisplayNameFor(model => model.公開等級編號public));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 46 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Comment\List.cshtml"
           Write(Html.DisplayNameFor(model => model.電影編號movie));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 52 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Comment\List.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr style=\"white-space:nowrap\">\r\n            <td>\r\n                ");
#nullable restore
#line 56 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Comment\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.會員編號memberId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 59 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Comment\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.評分rate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 62 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Comment\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.期待度anticipation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td class=\"tables_hidtext\">\r\n                ");
#nullable restore
#line 65 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Comment\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.評論標題commentTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td class=\"tables_hidtext\">\r\n                ");
#nullable restore
#line 68 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Comment\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.評論內容comments));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td class=\"tables_hidtext\">\r\n                ");
#nullable restore
#line 71 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Comment\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.發佈時間commentTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td class=\"tables_hidtext\">\r\n                ");
#nullable restore
#line 74 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Comment\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.觀影日期viewingTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 77 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Comment\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.觀影方式source));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 80 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Comment\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.是否開放討論串oxFloor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 83 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Comment\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.屏蔽invisible));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 86 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Comment\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.公開等級編號public.公開等級public));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 89 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Comment\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.電影編號movie.英文標題titleEng));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e58370e6ff49b17b4edf615ae3a3ab0ee7f2af0517441", async() => {
                WriteLiteral("修改");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 92 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Comment\List.cshtml"
                                       WriteLiteral(item.電影編號movieId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 95 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ServerMDA\ServerMDA\Views\Comment\List.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ServerMDA.Models.電影評論movieComment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
