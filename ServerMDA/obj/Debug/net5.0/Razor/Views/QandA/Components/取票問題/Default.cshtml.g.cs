#pragma checksum "C:\MDA後台\ServerMDA\Views\QandA\Components\取票問題\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "edc065bee01d7ee0b0216c5bb2196359571ec331"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QandA_Components_取票問題_Default), @"mvc.1.0.view", @"/Views/QandA/Components/取票問題/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edc065bee01d7ee0b0216c5bb2196359571ec331", @"/Views/QandA/Components/取票問題/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f44792abd596afd1ba2515f7ae3cd7cc9ca71375", @"/Views/_ViewImports.cshtml")]
    public class Views_QandA_Components_取票問題_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ServerMDA.ViewModel.CQandAViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\MDA後台\ServerMDA\Views\QandA\Components\取票問題\Default.cshtml"
  
    ViewData["Title"] = "Default"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div>
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
#line 26 "C:\MDA後台\ServerMDA\Views\QandA\Components\取票問題\Default.cshtml"
              int count = 0;
                foreach (var item in Model)
                {
                    count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td id=\"編號\" style=\"vertical-align: central; align-content:center\">\r\n                            ");
#nullable restore
#line 32 "C:\MDA後台\ServerMDA\Views\QandA\Components\取票問題\Default.cshtml"
                       Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 963, "\"", 1025, 1);
#nullable restore
#line 33 "C:\MDA後台\ServerMDA\Views\QandA\Components\取票問題\Default.cshtml"
WriteAttributeValue("", 971, Html.DisplayFor(modelItem => item.取票問題taketicketQaId), 971, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        </td>\r\n                        <td id=\"QQQ\">\r\n                            <div class=\"col-10 offset-1\">\r\n                                ");
#nullable restore
#line 37 "C:\MDA後台\ServerMDA\Views\QandA\Components\取票問題\Default.cshtml"
                           Write(Html.DisplayFor(modelItem => item.取票問題Question));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </td>\r\n                        <td id=\"AAA\">\r\n                            <div class=\"col-10 offset-1\">\r\n                                ");
#nullable restore
#line 42 "C:\MDA後台\ServerMDA\Views\QandA\Components\取票問題\Default.cshtml"
                           Write(Html.DisplayFor(modelItem => item.取票問題Answer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </td>\r\n                        <td>\r\n\r\n                            <a class=\"btn btn-yuka \" id=\"btn\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1647, "\"", 1767, 3);
            WriteAttributeValue("", 1657, "showmodal(\'", 1657, 11, true);
#nullable restore
#line 47 "C:\MDA後台\ServerMDA\Views\QandA\Components\取票問題\Default.cshtml"
WriteAttributeValue("", 1668, Url.Action("Edit7", "QandA", new { id = @item.取票問題taketicketQaId }, Context.Request.Scheme), 1668, 92, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1760, "\',null)", 1760, 7, true);
            EndWriteAttribute();
            WriteLiteral(">修改</a>\r\n");
            WriteLiteral("                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 51 "C:\MDA後台\ServerMDA\Views\QandA\Components\取票問題\Default.cshtml"
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
