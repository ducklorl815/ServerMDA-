#pragma checksum "C:\MDA後\ServerMDA\Views\QandA\Components\一般資訊\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6af1f36ad196f2946543c3adad574d42ae64510c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QandA_Components_一般資訊_Default), @"mvc.1.0.view", @"/Views/QandA/Components/一般資訊/Default.cshtml")]
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
#line 1 "C:\MDA後\ServerMDA\Views\_ViewImports.cshtml"
using ServerMDA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MDA後\ServerMDA\Views\_ViewImports.cshtml"
using ServerMDA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6af1f36ad196f2946543c3adad574d42ae64510c", @"/Views/QandA/Components/一般資訊/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f44792abd596afd1ba2515f7ae3cd7cc9ca71375", @"/Views/_ViewImports.cshtml")]
    public class Views_QandA_Components_一般資訊_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ServerMDA.ViewModel.CQandAViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\MDA後\ServerMDA\Views\QandA\Components\一般資訊\Default.cshtml"
  
    ViewData["Title"] = "Default"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <a class=\"btn btn-yuka \" id=\"btn\"");
            BeginWriteAttribute("onclick", " onclick=\"", 150, "\"", 282, 3);
            WriteAttributeValue("", 160, "showmodal(\'", 160, 11, true);
#nullable restore
#line 8 "C:\MDA後\ServerMDA\Views\QandA\Components\一般資訊\Default.cshtml"
WriteAttributeValue("", 171, Url.Action("Edit", "QandA", new { id = Model.First().一般資訊GeneraInformationID }, Context.Request.Scheme), 171, 104, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 275, "\',null)", 275, 7, true);
            EndWriteAttribute();
            WriteLiteral(@">修改</a>
    <table id=""myTable"" class=""table tables display compact hover col-12"">
        <thead>
            <tr style=""white-space:nowrap"">
                <th class=""col-1"">
                    序號
                </th>
                <th class=""col-2"">
                    問題
                </th>
                <th class=""col-8"">
                    回答
                </th>
                <th class=""col-1"">
                    指令
                </th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 27 "C:\MDA後\ServerMDA\Views\QandA\Components\一般資訊\Default.cshtml"
              int count = 0;
                foreach (var item in Model)
                {
                    count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td id=\"編號\" style=\"vertical-align: central; align-content:center\">\r\n                            ");
#nullable restore
#line 33 "C:\MDA後\ServerMDA\Views\QandA\Components\一般資訊\Default.cshtml"
                       Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 1142, "\"", 1209, 1);
#nullable restore
#line 34 "C:\MDA後\ServerMDA\Views\QandA\Components\一般資訊\Default.cshtml"
WriteAttributeValue("", 1150, Html.DisplayFor(modelItem => item.一般資訊GeneraInformationID), 1150, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        </td>\r\n                        <td id=\"QQQ\">\r\n                            <div class=\"col-10 offset-1\">\r\n                                ");
#nullable restore
#line 38 "C:\MDA後\ServerMDA\Views\QandA\Components\一般資訊\Default.cshtml"
                           Write(Html.DisplayFor(modelItem => item.問題Question));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </td>\r\n                        <td id=\"AAA\">\r\n                            <div class=\"col-10 offset-1\">\r\n                                ");
#nullable restore
#line 43 "C:\MDA後\ServerMDA\Views\QandA\Components\一般資訊\Default.cshtml"
                           Write(Html.DisplayFor(modelItem => item.答案Answer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </td>\r\n                        <td>\r\n                            \r\n\r\n");
            WriteLiteral("                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 52 "C:\MDA後\ServerMDA\Views\QandA\Components\一般資訊\Default.cshtml"
                } 

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ServerMDA.ViewModel.CQandAViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
