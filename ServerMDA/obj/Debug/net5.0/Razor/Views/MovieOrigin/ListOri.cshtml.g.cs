<<<<<<< HEAD
#pragma checksum "C:\Users\jo3wait\Documents\ServerMDA-\ServerMDA\Views\MovieOrigin\ListOri.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed124ad69375eee20375e5aedfe35292fdda27f7"
=======
#pragma checksum "C:\MDA143後\ServerMDA\Views\MovieOrigin\ListOri.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed124ad69375eee20375e5aedfe35292fdda27f7"
>>>>>>> feature/#orli
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MovieOrigin_ListOri), @"mvc.1.0.view", @"/Views/MovieOrigin/ListOri.cshtml")]
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
<<<<<<< HEAD
#line 1 "C:\Users\jo3wait\Documents\ServerMDA-\ServerMDA\Views\_ViewImports.cshtml"
=======
#line 1 "C:\MDA143後\ServerMDA\Views\_ViewImports.cshtml"
>>>>>>> feature/#orli
using ServerMDA;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "C:\Users\jo3wait\Documents\ServerMDA-\ServerMDA\Views\_ViewImports.cshtml"
=======
#line 2 "C:\MDA143後\ServerMDA\Views\_ViewImports.cshtml"
>>>>>>> feature/#orli
using ServerMDA.Models;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 1 "C:\Users\jo3wait\Documents\ServerMDA-\ServerMDA\Views\MovieOrigin\ListOri.cshtml"
=======
#line 1 "C:\MDA143後\ServerMDA\Views\MovieOrigin\ListOri.cshtml"
>>>>>>> feature/#orli
using ServerMDA.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed124ad69375eee20375e5aedfe35292fdda27f7", @"/Views/MovieOrigin/ListOri.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f44792abd596afd1ba2515f7ae3cd7cc9ca71375", @"/Views/_ViewImports.cshtml")]
    public class Views_MovieOrigin_ListOri : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CCountrysViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("p-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:150px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/vendor/jquery/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/vendor/datatables/Datatable_transCht.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
<<<<<<< HEAD
#line 4 "C:\Users\jo3wait\Documents\ServerMDA-\ServerMDA\Views\MovieOrigin\ListOri.cshtml"
=======
#line 4 "C:\MDA143後\ServerMDA\Views\MovieOrigin\ListOri.cshtml"
>>>>>>> feature/#orli
  
    ViewData["Title"] = "國家清單";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<h3>國家清單 <a class=\"btn btn-success mb-1\"");
            BeginWriteAttribute("onclick", " onclick=\"", 149, "\"", 235, 3);
            WriteAttributeValue("", 159, "showmodal(\'", 159, 11, true);
#nullable restore
<<<<<<< HEAD
#line 10 "C:\Users\jo3wait\Documents\ServerMDA-\ServerMDA\Views\MovieOrigin\ListOri.cshtml"
=======
#line 10 "C:\MDA143後\ServerMDA\Views\MovieOrigin\ListOri.cshtml"
>>>>>>> feature/#orli
WriteAttributeValue("", 170, Url.Action("Create","MovieOrigin",Context.Request.Scheme), 170, 58, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 228, "\',null)", 228, 7, true);
            EndWriteAttribute();
            WriteLiteral(">新增</a></h3>\r\n<table id=\"myTable\" class=\"table table-striped table-hover tables col-12\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
<<<<<<< HEAD
#line 15 "C:\Users\jo3wait\Documents\ServerMDA-\ServerMDA\Views\MovieOrigin\ListOri.cshtml"
=======
#line 15 "C:\MDA143後\ServerMDA\Views\MovieOrigin\ListOri.cshtml"
>>>>>>> feature/#orli
           Write(Html.DisplayNameFor(model => model.FirstOrDefault().國家名稱countryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
<<<<<<< HEAD
#line 18 "C:\Users\jo3wait\Documents\ServerMDA-\ServerMDA\Views\MovieOrigin\ListOri.cshtml"
=======
#line 18 "C:\MDA143後\ServerMDA\Views\MovieOrigin\ListOri.cshtml"
>>>>>>> feature/#orli
           Write(Html.DisplayNameFor(model => model.FirstOrDefault().國旗countryImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
<<<<<<< HEAD
#line 24 "C:\Users\jo3wait\Documents\ServerMDA-\ServerMDA\Views\MovieOrigin\ListOri.cshtml"
=======
#line 24 "C:\MDA143後\ServerMDA\Views\MovieOrigin\ListOri.cshtml"
>>>>>>> feature/#orli
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
<<<<<<< HEAD
#line 28 "C:\Users\jo3wait\Documents\ServerMDA-\ServerMDA\Views\MovieOrigin\ListOri.cshtml"
=======
#line 28 "C:\MDA143後\ServerMDA\Views\MovieOrigin\ListOri.cshtml"
>>>>>>> feature/#orli
           Write(Html.DisplayFor(modelItem => item.國家名稱countryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ed124ad69375eee20375e5aedfe35292fdda27f76839", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 878, "~/images/Country/", 878, 17, true);
#nullable restore
<<<<<<< HEAD
#line 31 "C:\Users\jo3wait\Documents\ServerMDA-\ServerMDA\Views\MovieOrigin\ListOri.cshtml"
=======
#line 31 "C:\MDA143後\ServerMDA\Views\MovieOrigin\ListOri.cshtml"
>>>>>>> feature/#orli
AddHtmlAttributeValue("", 895, item.國旗countryImage, 895, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a class=\"btn btn-yuka mb-1\" id=\"btn\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1044, "\"", 1160, 3);
            WriteAttributeValue("", 1054, "showmodal(\'", 1054, 11, true);
#nullable restore
<<<<<<< HEAD
#line 34 "C:\Users\jo3wait\Documents\ServerMDA-\ServerMDA\Views\MovieOrigin\ListOri.cshtml"
=======
#line 34 "C:\MDA143後\ServerMDA\Views\MovieOrigin\ListOri.cshtml"
>>>>>>> feature/#orli
WriteAttributeValue("", 1065, Url.Action("EditOri","MovieOrigin",new {id=@item.國家編號countryId},Context.Request.Scheme), 1065, 88, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1153, "\',null)", 1153, 7, true);
            EndWriteAttribute();
            WriteLiteral(">修改</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
<<<<<<< HEAD
#line 37 "C:\Users\jo3wait\Documents\ServerMDA-\ServerMDA\Views\MovieOrigin\ListOri.cshtml"
=======
#line 37 "C:\MDA143後\ServerMDA\Views\MovieOrigin\ListOri.cshtml"
>>>>>>> feature/#orli
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<div class=""modal fade"" id=""newstaticBackdrop"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">
            <div class=""modal-title"">


            </div>
            <div class=""modal-body"">


            </div>
        </div>
    </div>
</div>


");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed124ad69375eee20375e5aedfe35292fdda27f79768", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed124ad69375eee20375e5aedfe35292fdda27f710807", async() => {
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
    $(document).ready(function () {
        $('#myTable').DataTable();
    });
</script>
<script>
    showmodal = (url, title) => {
        $.ajax({
            type: ""GET"",
            url: url,
            success: function (res) {
                $(""#newstaticBackdrop .modal-body"").html(res);
                $(""#newstaticBackdrop .modal-title"").html(title);
                $(""#newstaticBackdrop"").modal('show');
            }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CCountrysViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
