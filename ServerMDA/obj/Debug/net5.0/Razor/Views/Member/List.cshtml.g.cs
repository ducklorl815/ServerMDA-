#pragma checksum "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Member\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a50d81b2819c77dd441dc276cf47a510050681d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Member_List), @"mvc.1.0.view", @"/Views/Member/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a50d81b2819c77dd441dc276cf47a510050681d6", @"/Views/Member/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f44792abd596afd1ba2515f7ae3cd7cc9ca71375", @"/Views/_ViewImports.cshtml")]
    public class Views_Member_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ServerMDA.Models.會員member>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning mb-1  ml-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("120"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info mb-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("white-space:nowrap"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Member\List.cshtml"
  
    ViewData["Title"] = "會員清單";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a50d81b2819c77dd441dc276cf47a510050681d66185", async() => {
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
            WriteLiteral("\r\n\r\n<h2>會員清單");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a50d81b2819c77dd441dc276cf47a510050681d67311", async() => {
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
            WriteLiteral("</h2>\r\n\r\n<table class=\"table table-striped table-hover tables\">\r\n    <thead>\r\n        <tr style=\"white-space:nowrap\">\r\n            <th class=\"col-2\">\r\n                ");
#nullable restore
#line 15 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Member\List.cshtml"
           Write(Html.DisplayNameFor(model => model.會員電話cellphone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n");
            WriteLiteral("            <th class=\"col-1\">\r\n                ");
#nullable restore
#line 21 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Member\List.cshtml"
           Write(Html.DisplayNameFor(model => model.姓氏lName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th class=\"col-1\">\r\n                ");
#nullable restore
#line 24 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Member\List.cshtml"
           Write(Html.DisplayNameFor(model => model.名字fName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n");
            WriteLiteral("            <th class=\"col-3\">\r\n                ");
#nullable restore
#line 33 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Member\List.cshtml"
           Write(Html.DisplayNameFor(model => model.電子信箱email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n");
            WriteLiteral("            <th>\r\n                ");
#nullable restore
#line 39 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Member\List.cshtml"
           Write(Html.DisplayNameFor(model => model.紅利點數bonus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 42 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Member\List.cshtml"
           Write(Html.DisplayNameFor(model => model.正式會員formal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th class=\"col-1\">\r\n                ");
#nullable restore
#line 45 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Member\List.cshtml"
           Write(Html.DisplayNameFor(model => model.會員照片image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th class=\"col-1\">\r\n                ");
#nullable restore
#line 48 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Member\List.cshtml"
           Write(Html.DisplayNameFor(model => model.建立時間createdTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n");
            WriteLiteral("            <th class=\"col-1\">\r\n                ");
#nullable restore
#line 54 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Member\List.cshtml"
           Write(Html.DisplayNameFor(model => model.會員權限permissionNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 60 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Member\List.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr style=\"white-space:nowrap\">\r\n            <td>\r\n                ");
#nullable restore
#line 64 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Member\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.會員電話cellphone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
            WriteLiteral("            <td>\r\n                ");
#nullable restore
#line 70 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Member\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.姓氏lName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 73 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Member\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.名字fName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
            WriteLiteral("            <td class=\"tables_hidtext\">\r\n                ");
#nullable restore
#line 82 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Member\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.電子信箱email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
            WriteLiteral("            <td>\r\n                ");
#nullable restore
#line 88 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Member\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.紅利點數bonus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 91 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Member\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.正式會員formal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <div>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a50d81b2819c77dd441dc276cf47a510050681d614142", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3118, "~/images/Member/", 3118, 16, true);
#nullable restore
#line 95 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Member\List.cshtml"
AddHtmlAttributeValue("", 3134, item.會員照片image, 3134, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </td>\r\n            <td class=\"tables_hidtext\">\r\n                ");
#nullable restore
#line 99 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Member\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.建立時間createdTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
            WriteLiteral("            <td>\r\n                ");
#nullable restore
#line 105 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Member\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.會員權限permissionNavigation.權限名稱permissionName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a50d81b2819c77dd441dc276cf47a510050681d616512", async() => {
                WriteLiteral("修改");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 108 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Member\List.cshtml"
                                       WriteLiteral(item.會員編號memberId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 111 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\Member\List.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ServerMDA.Models.會員member>> Html { get; private set; }
    }
}
#pragma warning restore 1591
