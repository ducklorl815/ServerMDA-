#pragma checksum "C:\MDA143後\ServerMDA\Views\Member\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff4d91345c28d68dd0e6b1f70ca8fed565f2d41d"
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
#line 1 "C:\MDA143後\ServerMDA\Views\_ViewImports.cshtml"
using ServerMDA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MDA143後\ServerMDA\Views\_ViewImports.cshtml"
using ServerMDA.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\MDA143後\ServerMDA\Views\Member\List.cshtml"
using ServerMDA.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff4d91345c28d68dd0e6b1f70ca8fed565f2d41d", @"/Views/Member/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f44792abd596afd1ba2515f7ae3cd7cc9ca71375", @"/Views/_ViewImports.cshtml")]
    public class Views_Member_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CMemberViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bootstrap-5.2.2/YukabtnEdit.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("space"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/vendor/jquery/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/vendor/datatables/Datatable_transCht.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/vendor/datatables/jquery.dataTables.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\MDA143後\ServerMDA\Views\Member\List.cshtml"
  
    ViewData["Title"] = "會員清單";

#line default
#line hidden
#nullable disable
            DefineSection("styles", async() => {
                WriteLiteral(@"
    <style>
        .w3-check {
            transform: scale(2);
        }

        #con {
            display: flex;
            flex-direction: row;
            justify-content: space-between;
            align-items: center
        }

        #quickchange {
            display: flex;
        }
    </style>
");
            }
            );
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ff4d91345c28d68dd0e6b1f70ca8fed565f2d41d7315", async() => {
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
            WriteLiteral("\r\n\r\n\r\n<div id=\"con\">\r\n    <div id=\"a\">\r\n        <h3 class=\"MovieList\">\r\n            會員清單\r\n            <a class=\"btn btn-success mb-1\"");
            BeginWriteAttribute("onclick", " onclick=\"", 652, "\"", 735, 3);
            WriteAttributeValue("", 662, "showmodal(\'", 662, 11, true);
#nullable restore
#line 32 "C:\MDA143後\ServerMDA\Views\Member\List.cshtml"
WriteAttributeValue("", 673, Url.Action("Create", "Member", Context.Request.Scheme), 673, 55, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 728, "\',null)", 728, 7, true);
            EndWriteAttribute();
            WriteLiteral(">新增</a>\r\n        </h3>\r\n    </div>\r\n    <div id=\"quickchange\">\r\n        <h3 class=\"chagetitle\" style=\"width: 250px; vertical-align:middle; \">快速修改</h3>\r\n        <select id=\"selector\" class=\"form-select\" name=\"selector\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff4d91345c28d68dd0e6b1f70ca8fed565f2d41d9353", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <optgroup label=\"優惠券\" id=\"coupon\">\r\n");
#nullable restore
#line 40 "C:\MDA143後\ServerMDA\Views\Member\List.cshtml"
                 foreach (var t in Model.First().優惠總表coupon)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff4d91345c28d68dd0e6b1f70ca8fed565f2d41d10867", async() => {
#nullable restore
#line 42 "C:\MDA143後\ServerMDA\Views\Member\List.cshtml"
                                                Write(t.優惠名稱couponName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
            WriteLiteral(" ");
#nullable restore
#line 42 "C:\MDA143後\ServerMDA\Views\Member\List.cshtml"
                        WriteLiteral(t.優惠編號couponId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 43 "C:\MDA143後\ServerMDA\Views\Member\List.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </optgroup>\r\n            <optgroup label=\"會員權限\" id=\"permite\">\r\n");
#nullable restore
#line 46 "C:\MDA143後\ServerMDA\Views\Member\List.cshtml"
                 foreach (var p in Model.First().會員權限PermissionS)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff4d91345c28d68dd0e6b1f70ca8fed565f2d41d13166", async() => {
#nullable restore
#line 48 "C:\MDA143後\ServerMDA\Views\Member\List.cshtml"
                                                  Write(p.權限名稱permissionName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "C:\MDA143後\ServerMDA\Views\Member\List.cshtml"
                       WriteLiteral(p.會員權限permission1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 49 "C:\MDA143後\ServerMDA\Views\Member\List.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </optgroup>\r\n            <optgroup label=\"會員資格\" id=\"Formal\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff4d91345c28d68dd0e6b1f70ca8fed565f2d41d15228", async() => {
                WriteLiteral("正式會員 ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff4d91345c28d68dd0e6b1f70ca8fed565f2d41d16403", async() => {
                WriteLiteral("非正式會員 ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

            </optgroup>
        </select>
        <button class=""btn btn-success mb-1"" style=""width:100px;"" id=""execution"">執行</button>
    </div>
</div>

<div>
    <table id=""myTable"" class=""table tables display compact hover col-12"">
        <thead>
            <tr style=""white-space:nowrap"">
                <th style=""width:60px"">
                    全選 &nbsp;
                    <input class=""w3-check"" type=""checkbox"" id=""checkAll"" />
                </th>
                <th style=""width:5px"">
                    ID
                </th>
                <th class=""col-1"">
                    姓名
                </th>
                <th class=""col-1"">
                    ");
#nullable restore
#line 76 "C:\MDA143後\ServerMDA\Views\Member\List.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().會員電話cellphone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th class=\"col-2\">\r\n                    ");
#nullable restore
#line 79 "C:\MDA143後\ServerMDA\Views\Member\List.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().電子信箱email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n\r\n                <th class=\"col-1\">\r\n                    ");
#nullable restore
#line 83 "C:\MDA143後\ServerMDA\Views\Member\List.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().會員照片image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th class=\"col-1\">\r\n                    ");
#nullable restore
#line 86 "C:\MDA143後\ServerMDA\Views\Member\List.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().性別名稱genderName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th class=\"col-1\">\r\n                    ");
#nullable restore
#line 89 "C:\MDA143後\ServerMDA\Views\Member\List.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().權限名稱permissionName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th class=\"col-1\">\r\n                    ");
#nullable restore
#line 92 "C:\MDA143後\ServerMDA\Views\Member\List.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().正式會員formal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th style=\"width:10px\">\r\n                    指令\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 100 "C:\MDA143後\ServerMDA\Views\Member\List.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <tr style=""white-space:nowrap"">
                    <td id=""ccontainer"">
                        <input class=""w3-check"" type=""checkbox"" id=""select"" name=""checkbox"" />
                        <input type=""hidden"" id=""memberId"" />
                    </td>
                    <td id=""會員編號memberId"">
                        ");
#nullable restore
#line 108 "C:\MDA143後\ServerMDA\Views\Member\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.會員編號memberId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 111 "C:\MDA143後\ServerMDA\Views\Member\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.姓氏lName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 111 "C:\MDA143後\ServerMDA\Views\Member\List.cshtml"
                                                              Write(Html.DisplayFor(modelItem => item.名字fName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 114 "C:\MDA143後\ServerMDA\Views\Member\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.會員電話cellphone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"tables_hidtext\">\r\n                        ");
#nullable restore
#line 117 "C:\MDA143後\ServerMDA\Views\Member\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.電子信箱email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <div>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ff4d91345c28d68dd0e6b1f70ca8fed565f2d41d22574", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4370, "~/images/Member/", 4370, 16, true);
#nullable restore
#line 121 "C:\MDA143後\ServerMDA\Views\Member\List.cshtml"
AddHtmlAttributeValue("", 4386, item.會員照片image, 4386, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 125 "C:\MDA143後\ServerMDA\Views\Member\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.性別名稱genderName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 128 "C:\MDA143後\ServerMDA\Views\Member\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.權限名稱permissionName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 131 "C:\MDA143後\ServerMDA\Views\Member\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.正式會員formal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <a class=\"btn btn-yuka \" id=\"btn\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4948, "\"", 5055, 3);
            WriteAttributeValue("", 4958, "showmodal(\'", 4958, 11, true);
#nullable restore
#line 134 "C:\MDA143後\ServerMDA\Views\Member\List.cshtml"
WriteAttributeValue("", 4969, Url.Action("Edit","Member",new {id=@item.會員編號memberId},Context.Request.Scheme), 4969, 79, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5048, "\',null)", 5048, 7, true);
            EndWriteAttribute();
            WriteLiteral(">修改</a>\r\n");
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 138 "C:\MDA143後\ServerMDA\Views\Member\List.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff4d91345c28d68dd0e6b1f70ca8fed565f2d41d26848", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff4d91345c28d68dd0e6b1f70ca8fed565f2d41d27888", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
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
    const checkbox = document.querySelectorAll('#select')
    const member = document.querySelectorAll('#會員編號memberId')
    const memberID = document.querySelectorAll('#memberId')
    const selector = document.querySelector('#document.querySelector')


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


    //全選
    let arrId = new Array();
    $(""#checkAll"").click(function () {
        $('input:checkbox').not(this).prop('checked', this.checked);
        for (let i = 0; i < checkbox.length; i++) {
            if (this.checked) {
                memberID[");
            WriteLiteral(@"i].value = member[i].innerText;
                arrId.push(memberID[i].value)
            } else {
                let ok = arrId.indexOf((memberID[i].value))
                arrId.splice(ok, 1)
                memberID[i].value = 0;
            }
        };
    });

    //多選
    for (let i = 0; i < checkbox.length; i++) {
        checkbox[i].addEventListener('click', function () {
            if (this.checked) {
                memberID[i].value = member[i].innerText;
                arrId.push(memberID[i].value)

            }
            else {
                let ok = arrId.indexOf((memberID[i].value))
                arrId.splice(ok, 1)
                memberID[i].value = 0;

            }
        });
    }

    //combobox
    let arrToDo = """"
    let label =
    $('#selector').on('change', function () {       
            this.value == """"
            arrToDo = this.value;
            console.log(arrToDo)
            label = $(this.options[this.selectedIndex]).closest('o");
            WriteLiteral(@"ptgroup').prop('label');
            console.log(label)
       
    })


    $('#execution').click(async function () {
        
       
        //增加優惠券
        if (label == ""優惠券"") {
        $.ajax({
            type: ""POST"",
            url: ""/ApiHome/addCoupon"",
            data: { arrId: arrId, arrToDo: arrToDo },
            success: function () {
                alert('success');
                $(""input:checked"").prop(""checked"", false)               
            },
            dataType: 'json',
        });
        }
        //增加會員權限
        else if (label == ""會員權限"") {
            $.ajax({
                type: ""POST"",
                url: ""/ApiHome/addPermission"",
                data: { arrId: arrId, arrToDo: arrToDo },
                success: function () {
                    alert('success');
                    $(""input:checked"").prop(""checked"", false)
                },
                dataType: 'json',
            });            
        }
        //會員資格
       ");
            WriteLiteral(@" else if (label == ""會員資格"") {
            $.ajax({
                type: ""POST"",
                url: ""/ApiHome/addFormal"",
                data: { arrId: arrId, arrToDo: arrToDo },
                success: function () {
                    alert('success');
                    $(""input:checked"").prop(""checked"", false)
                },
                dataType: 'json',
            });
        }
        else
            alert(""請選擇執行項目"")
        
    })
    
</script>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff4d91345c28d68dd0e6b1f70ca8fed565f2d41d32637", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CMemberViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
