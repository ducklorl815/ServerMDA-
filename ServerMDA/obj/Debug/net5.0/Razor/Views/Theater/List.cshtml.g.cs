#pragma checksum "C:\Users\Student\Documents\備份\ServerMDA\Views\Theater\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61ff0194b1dde93d13f3b8b808ff953a4b3a40df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Theater_List), @"mvc.1.0.view", @"/Views/Theater/List.cshtml")]
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
#line 1 "C:\Users\Student\Documents\備份\ServerMDA\Views\_ViewImports.cshtml"
using ServerMDA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Student\Documents\備份\ServerMDA\Views\_ViewImports.cshtml"
using ServerMDA.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Student\Documents\備份\ServerMDA\Views\Theater\List.cshtml"
using ServerMDA.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61ff0194b1dde93d13f3b8b808ff953a4b3a40df", @"/Views/Theater/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f44792abd596afd1ba2515f7ae3cd7cc9ca71375", @"/Views/_ViewImports.cshtml")]
    public class Views_Theater_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CTheaterViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bootstrap-5.2.2/YukabtnEdit.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("120"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/bootstrap-5.2.2/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/vendor/jquery/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/vendor/datatables/jquery.dataTables.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\Student\Documents\備份\ServerMDA\Views\Theater\List.cshtml"
  
    ViewData["Title"] = "電影院清單";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "61ff0194b1dde93d13f3b8b808ff953a4b3a40df6023", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "61ff0194b1dde93d13f3b8b808ff953a4b3a40df7137", async() => {
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
            WriteLiteral(@"
<link rel=""stylesheet"" href=""https://www.w3schools.com/w3css/4/w3.css"">

<style>
    .row {
        text-align: center;
    }


    .seatrow .dot {
        display: inline-block;
        width: 13px;
        height: 13px;
        border-radius: 50%;
        margin: 0.2vw;
        cursor: pointer;
        background-color: black;
    }

    .seatrow div {
        display: block;
    }

    .seatrow .selected {
        background-color: deeppink;
    }

    .seatrow .none {
        background-color: transparent;
    }
</style>

<h3 class=""MovieList"">
    電影院清單
    <a class=""btn btn-success mb-1""");
            BeginWriteAttribute("onclick", " onclick=\"", 863, "\"", 947, 3);
            WriteAttributeValue("", 873, "showmodal(\'", 873, 11, true);
#nullable restore
#line 45 "C:\Users\Student\Documents\備份\ServerMDA\Views\Theater\List.cshtml"
WriteAttributeValue("", 884, Url.Action("Create", "Theater", Context.Request.Scheme), 884, 56, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 940, "\',null)", 940, 7, true);
            EndWriteAttribute();
            WriteLiteral(@">新增電影院</a>
</h3>
<div>
    <table id=""myTable"" class=""table tables display compact hover col-12"">
        <thead>
            <tr>
                <th style=""width:25px"">
                    ID
                </th>
                <th class=""col-1"">
                    電影院名稱
                </th>
                <th class=""col-1"">
                    營業時間
                </th>
                <th>
                    電話
                </th>
                <th class=""col-2"">
                    地址
                </th>
                <th>
                    官方網站
                </th>
                <th class=""col-1"">
                    電影院照片
                </th>
                <th>
                    ");
#nullable restore
#line 73 "C:\Users\Student\Documents\備份\ServerMDA\Views\Theater\List.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().影城名稱mainTheaterName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    指令\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 81 "C:\Users\Student\Documents\備份\ServerMDA\Views\Theater\List.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 85 "C:\Users\Student\Documents\備份\ServerMDA\Views\Theater\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.電影院編號theaterId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 88 "C:\Users\Student\Documents\備份\ServerMDA\Views\Theater\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.電影院名稱theaterName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 91 "C:\Users\Student\Documents\備份\ServerMDA\Views\Theater\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.營業時間businessHours));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 94 "C:\Users\Student\Documents\備份\ServerMDA\Views\Theater\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.電話phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"tables_hidtext\">\r\n                        ");
#nullable restore
#line 97 "C:\Users\Student\Documents\備份\ServerMDA\Views\Theater\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.地址address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"tables_hidtext\">\r\n                        ");
#nullable restore
#line 100 "C:\Users\Student\Documents\備份\ServerMDA\Views\Theater\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.官方網站url));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <div>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "61ff0194b1dde93d13f3b8b808ff953a4b3a40df13061", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2896, "~/images/Theater/", 2896, 17, true);
#nullable restore
#line 104 "C:\Users\Student\Documents\備份\ServerMDA\Views\Theater\List.cshtml"
AddHtmlAttributeValue("", 2913, item.電影院照片image, 2913, 16, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue(" ", 2929, "", 2930, 1, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 108 "C:\Users\Student\Documents\備份\ServerMDA\Views\Theater\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.影城名稱mainTheaterName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <a class=\"btn btn-yuka\" id=\"btn\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3223, "\"", 3333, 3);
            WriteAttributeValue("", 3233, "showmodal(\'", 3233, 11, true);
#nullable restore
#line 111 "C:\Users\Student\Documents\備份\ServerMDA\Views\Theater\List.cshtml"
WriteAttributeValue("", 3244, Url.Action("Edit","Theater",new {id=@item.電影院編號theaterId},Context.Request.Scheme), 3244, 82, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3326, "\',null)", 3326, 7, true);
            EndWriteAttribute();
            WriteLiteral(">修改</a>\r\n                        <button class=\"btn btn-details \" name=\"Cinemabtn\"");
            BeginWriteAttribute("value", " value=\"", 3416, "\"", 3445, 2);
#nullable restore
#line 112 "C:\Users\Student\Documents\備份\ServerMDA\Views\Theater\List.cshtml"
WriteAttributeValue("", 3424, item.電影院編號theaterId, 3424, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 3444, "", 3445, 1, true);
            EndWriteAttribute();
            WriteLiteral(">細節</button>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 115 "C:\Users\Student\Documents\備份\ServerMDA\Views\Theater\List.cshtml"
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


<div class=""w3-container"">
    <div class=""w3-modal"" id=""theaterModal"">
        <div class=""w3-modal-content w3-card-4 w3-animate-zoom"" style=""width:75vw;"">
            <div id=""id01"">

            </div>
        </div>
    </div>
</div>




");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61ff0194b1dde93d13f3b8b808ff953a4b3a40df17601", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61ff0194b1dde93d13f3b8b808ff953a4b3a40df18641", async() => {
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
            WriteLiteral(@"



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

    $('button[name=Cinemabtn]').click(function () {
        let value = this.getAttribute('value');
        console.log(value);
        document.getElementById('theaterModal').style.display = 'block';
        CallAjax(value);
    })

       async function CallAjax(theaterID) {
        $(""#id01"").empty();
           let _url = await '");
#nullable restore
#line 182 "C:\Users\Student\Documents\備份\ServerMDA\Views\Theater\List.cshtml"
                        Write(Url.Action("TheaterInfo", "Theater"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + `?theaterId=${theaterID}`;
                $.ajax({
                    type: ""GET"",
                    url: _url,
                    success: function (result) {
                        $('#id01').html(result);
                        showbox();
                    }
                });
    }

    function showbox() {
        $('.accordion-button').click(function () {
            let id = `collapse${this.getAttribute('data')}`;
            let flag = this.getAttribute('data-flag');
            if (flag == 0) {
                $(`#${id}`).addClass('show');
                this.setAttribute('data-flag', 1)
            } else {
                $(`#${id}`).removeClass('show');
                this.setAttribute('data-flag', 0)
            }

        })
    }
</script>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61ff0194b1dde93d13f3b8b808ff953a4b3a40df21478", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CTheaterViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
