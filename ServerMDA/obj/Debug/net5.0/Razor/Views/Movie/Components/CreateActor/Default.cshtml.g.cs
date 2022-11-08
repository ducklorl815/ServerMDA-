#pragma checksum "C:\MDA後台\ServerMDA\Views\Movie\Components\CreateActor\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7775727a53717f618441d1472815cdc21a4e758e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Components_CreateActor_Default), @"mvc.1.0.view", @"/Views/Movie/Components/CreateActor/Default.cshtml")]
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
#line 4 "C:\MDA後台\ServerMDA\Views\Movie\Components\CreateActor\Default.cshtml"
using ServerMDA.ViewComponents;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7775727a53717f618441d1472815cdc21a4e758e", @"/Views/Movie/Components/CreateActor/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f44792abd596afd1ba2515f7ae3cd7cc9ca71375", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Components_CreateActor_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<演員總表actor>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("draggable", new global::Microsoft.AspNetCore.Html.HtmlString("false"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<div class=""container m-3 pt-2 pb-2"">
    <div class=""row"">
        <div class=""col-1""></div>
        <div class=""col-5"">
            <div class=""d-block"">
                <div class=""card"" style=""width: 18rem; overflow: hidden!important"" id=""actordropzone"">
                    <div class=""card-body"" style=""overflow:hidden"">
                        <h5 class=""card-title"">加入演員</h5>
                        <p class=""card-text"">拖入已加入演員</p>
                    </div>
                </div>
            </div>
            <div class=""d-block"">
                <div class=""card"" style=""width: 95%;"">
                    <ul class=""list-group list-group-flush"" id=""actorlist"">
                    </ul>
                </div>
            </div>
");
            WriteLiteral(@"            <div class=""d-block"">
                <button class=""btn btn-primary"" id=""closeandsave"">儲存</button>
                <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"" aria-label=""Close"">回到清單</button>
            </div>
        </div>
        <div class=""col-6"">
            <div class=""card"" style=""width: 90%;height:60vh;"">
                <input type=""text"" />
                <ul class=""list-group list-group-flush"">
");
#nullable restore
#line 43 "C:\MDA後台\ServerMDA\Views\Movie\Components\CreateActor\Default.cshtml"
                      
                        foreach (var item in Model)
                        {
                            string idstr = $"actor{item.演員編號actorsId}";

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li");
            BeginWriteAttribute("id", " id=", 1731, "", 1741, 1);
#nullable restore
#line 47 "C:\MDA後台\ServerMDA\Views\Movie\Components\CreateActor\Default.cshtml"
WriteAttributeValue("", 1735, idstr, 1735, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"actor\" class=\"list-group-item\"");
            BeginWriteAttribute("value", " value=\"", 1778, "\"", 1804, 1);
#nullable restore
#line 47 "C:\MDA後台\ServerMDA\Views\Movie\Components\CreateActor\Default.cshtml"
WriteAttributeValue("", 1786, item.演員編號actorsId, 1786, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" draggable=\"true\">");
#nullable restore
#line 47 "C:\MDA後台\ServerMDA\Views\Movie\Components\CreateActor\Default.cshtml"
                                                                                                                      Write(item.演員中文名字nameCht);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7775727a53717f618441d1472815cdc21a4e758e6404", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1870, "~/images/Actor/", 1870, 15, true);
#nullable restore
#line 47 "C:\MDA後台\ServerMDA\Views\Movie\Components\CreateActor\Default.cshtml"
AddHtmlAttributeValue("", 1885, item.演員照片image, 1885, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 48 "C:\MDA後台\ServerMDA\Views\Movie\Components\CreateActor\Default.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<演員總表actor>> Html { get; private set; }
    }
}
#pragma warning restore 1591
