#pragma checksum "C:\MDA後台\ServerMDA\Views\Coupon\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ef8bd6897b89ef76765a8342fa56026e1813ac1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Coupon_List), @"mvc.1.0.view", @"/Views/Coupon/List.cshtml")]
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
#line 1 "C:\MDA後台\ServerMDA\Views\Coupon\List.cshtml"
using ServerMDA.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ef8bd6897b89ef76765a8342fa56026e1813ac1", @"/Views/Coupon/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f44792abd596afd1ba2515f7ae3cd7cc9ca71375", @"/Views/_ViewImports.cshtml")]
    public class Views_Coupon_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CCouponViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bootstrap-5.2.2/YukabtnEdit.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/vendor/jquery/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/vendor/datatables/Datatable_transCht.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/vendor/datatables/jquery.dataTables.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\MDA後台\ServerMDA\Views\Coupon\List.cshtml"
  
    ViewData["Title"] = "優惠明細";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8ef8bd6897b89ef76765a8342fa56026e1813ac15209", async() => {
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
            WriteLiteral("\r\n\r\n<h3 class=\"MovieList\">\r\n    優惠明細\r\n    <a class=\"btn btn-success mb-1\"");
            BeginWriteAttribute("onclick", " onclick=\"", 248, "\"", 331, 3);
            WriteAttributeValue("", 258, "showmodal(\'", 258, 11, true);
#nullable restore
#line 13 "C:\MDA後台\ServerMDA\Views\Coupon\List.cshtml"
WriteAttributeValue("", 269, Url.Action("Create", "Coupon", Context.Request.Scheme), 269, 55, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 324, "\',null)", 324, 7, true);
            EndWriteAttribute();
            WriteLiteral(">新增優惠券</a>\r\n</h3>\r\n<table id=\"myTable\" class=\"table tables display compact hover col-12\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ID\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\MDA後台\ServerMDA\Views\Coupon\List.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstOrDefault().優惠編號couponId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\MDA後台\ServerMDA\Views\Coupon\List.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstOrDefault().優惠截止日期couponDueDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                使用於訂單\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\MDA後台\ServerMDA\Views\Coupon\List.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstOrDefault().會員編號memberId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                姓名\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\MDA後台\ServerMDA\Views\Coupon\List.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstOrDefault().會員電話cellphone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 41 "C:\MDA後台\ServerMDA\Views\Coupon\List.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstOrDefault().是否使用優惠oxCouponUsing));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                指令\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 49 "C:\MDA後台\ServerMDA\Views\Coupon\List.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "C:\MDA後台\ServerMDA\Views\Coupon\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.優惠明細編號couponListId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 56 "C:\MDA後台\ServerMDA\Views\Coupon\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.優惠代碼couponCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 59 "C:\MDA後台\ServerMDA\Views\Coupon\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.優惠截止日期couponDueDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 62 "C:\MDA後台\ServerMDA\Views\Coupon\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.訂單編號orderId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 65 "C:\MDA後台\ServerMDA\Views\Coupon\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.會員編號memberId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 68 "C:\MDA後台\ServerMDA\Views\Coupon\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.姓氏lName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\MDA後台\ServerMDA\Views\Coupon\List.cshtml"
                                                      Write(Html.DisplayFor(modelItem => item.名字fName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 71 "C:\MDA後台\ServerMDA\Views\Coupon\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.會員電話cellphone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 74 "C:\MDA後台\ServerMDA\Views\Coupon\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.是否使用優惠oxCouponUsing));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a class=\"btn btn-yuka\" id=\"btn\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2358, "\"", 2465, 3);
            WriteAttributeValue("", 2368, "showmodal(\'", 2368, 11, true);
#nullable restore
#line 77 "C:\MDA後台\ServerMDA\Views\Coupon\List.cshtml"
WriteAttributeValue("", 2379, Url.Action("Edit","Coupon",new {id=@item.會員編號memberId},Context.Request.Scheme), 2379, 79, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2458, "\',null)", 2458, 7, true);
            EndWriteAttribute();
            WriteLiteral(">修改</a>\r\n                <a class=\"btn btn-details \" id=\"btn\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2527, "\"", 2637, 3);
            WriteAttributeValue("", 2537, "showmodal(\'", 2537, 11, true);
#nullable restore
#line 78 "C:\MDA後台\ServerMDA\Views\Coupon\List.cshtml"
WriteAttributeValue("", 2548, Url.Action("Details","Coupon",new {id=@item.會員編號memberId},Context.Request.Scheme), 2548, 82, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2630, "\',null)", 2630, 7, true);
            EndWriteAttribute();
            WriteLiteral(">細節</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 81 "C:\MDA後台\ServerMDA\Views\Coupon\List.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<div class=""modal fade"" id=""newstaticBackdrop"" data-bs-backdrop=""static"" data-bs-keyboard=""false"" tabindex=""-1"" aria-labelledby=""staticBackdropLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-body col-12 "">
            </div>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""sortstaticBackdrop"" data-bs-backdrop=""static"" data-bs-keyboard=""false"" tabindex=""-1"" aria-labelledby=""staticBackdropLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-body col-12 "">


            </div>
        </div>
    </div>
</div>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ef8bd6897b89ef76765a8342fa56026e1813ac113875", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ef8bd6897b89ef76765a8342fa56026e1813ac114915", async() => {
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
</script>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ef8bd6897b89ef76765a8342fa56026e1813ac116481", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CCouponViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
