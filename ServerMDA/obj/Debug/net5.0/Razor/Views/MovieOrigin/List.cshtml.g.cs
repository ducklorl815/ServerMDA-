#pragma checksum "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\MovieOrigin\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd4495c6fa6760eccf5c9c42d6803ced0f5ff826"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MovieOrigin_List), @"mvc.1.0.view", @"/Views/MovieOrigin/List.cshtml")]
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
#line 1 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\MovieOrigin\List.cshtml"
using ServerMDA.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd4495c6fa6760eccf5c9c42d6803ced0f5ff826", @"/Views/MovieOrigin/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f44792abd596afd1ba2515f7ae3cd7cc9ca71375", @"/Views/_ViewImports.cshtml")]
    public class Views_MovieOrigin_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CMovieOriginViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/vendor/jquery/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\MovieOrigin\List.cshtml"
  
    ViewData["Title"] = "國家產地清單";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>國家產地清單 <a class=\"btn btn-success mb-1\"");
            BeginWriteAttribute("onclick", " onclick=\"", 152, "\"", 238, 3);
            WriteAttributeValue("", 162, "showmodal(\'", 162, 11, true);
#nullable restore
#line 8 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\MovieOrigin\List.cshtml"
WriteAttributeValue("", 173, Url.Action("Create","MovieOrigin",Context.Request.Scheme), 173, 58, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 231, "\',null)", 231, 7, true);
            EndWriteAttribute();
            WriteLiteral(">新增</a></h3>\r\n\r\n<div>\r\n    <table id=\"myTable\" class=\"table table-striped table-hover tables col-12\">\r\n        <thead>\r\n            <tr style=\"white-space:nowrap\">\r\n                <th class=\"col-1\">\r\n                    ");
#nullable restore
#line 15 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\MovieOrigin\List.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().國旗countryImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 18 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\MovieOrigin\List.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().國家編號countryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 21 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\MovieOrigin\List.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().國家名稱countryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n\r\n                <th>\r\n                    ");
#nullable restore
#line 25 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\MovieOrigin\List.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().電影編號movieId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th class=\"col-4\">\r\n                    ");
#nullable restore
#line 28 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\MovieOrigin\List.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().中文標題titleCht));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 34 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\MovieOrigin\List.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        <div>\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 1353, "\"", 1428, 1);
#nullable restore
#line 39 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\MovieOrigin\List.cshtml"
WriteAttributeValue("", 1359, Url.Action("ShowPhoto","MovieOrigin", new {id= item.國家編號countryId }), 1359, 69, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid w-25\" />\r\n                        </div>\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 43 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\MovieOrigin\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.國家編號countryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 46 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\MovieOrigin\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.國家名稱countryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 50 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\MovieOrigin\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.電影編號movieId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 53 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\MovieOrigin\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.中文標題titleCht));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <a class=\"btn btn-yuka mb-1\" id=\"btn\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2116, "\"", 2226, 3);
            WriteAttributeValue("", 2126, "showmodal(\'", 2126, 11, true);
#nullable restore
#line 56 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\MovieOrigin\List.cshtml"
WriteAttributeValue("", 2137, Url.Action("Edit","MovieOrigin",new {id=@item.電影產地編號mcId},Context.Request.Scheme), 2137, 82, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2219, "\',null)", 2219, 7, true);
            EndWriteAttribute();
            WriteLiteral(">修改</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 59 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\MovieOrigin\List.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>
</div>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd4495c6fa6760eccf5c9c42d6803ced0f5ff82610191", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

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
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CMovieOriginViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
