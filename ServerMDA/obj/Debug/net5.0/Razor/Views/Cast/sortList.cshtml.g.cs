#pragma checksum "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Cast\sortList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e1c417690d53858cfe9c26c71cc10fffaa2c5a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cast_sortList), @"mvc.1.0.view", @"/Views/Cast/sortList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e1c417690d53858cfe9c26c71cc10fffaa2c5a5", @"/Views/Cast/sortList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f44792abd596afd1ba2515f7ae3cd7cc9ca71375", @"/Views/_ViewImports.cshtml")]
    public class Views_Cast_sortList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ServerMDA.Models.電影主演cast>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bootstrap-5.2.2/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/bootstrap-5.2.2/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/vendor/jquery/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Cast\sortList.cshtml"
  
    ViewData["Title"] = "sortList";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7e1c417690d53858cfe9c26c71cc10fffaa2c5a55215", async() => {
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
            WriteLiteral("\r\n\r\n");
            WriteLiteral("<h3 class=\"MovieList\">主演清單 <a class=\"btn btn-info mb-1\" id=\"btn\"");
            BeginWriteAttribute("onclick", " onclick=\"", 408, "\"", 494, 3);
            WriteAttributeValue("", 418, "showmodal(\'", 418, 11, true);
#nullable restore
#line 11 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Cast\sortList.cshtml"
WriteAttributeValue("", 429, Url.Action("Create","Cast",Context.Request.Scheme), 429, 51, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 480, "\',null)\',null)", 480, 14, true);
            EndWriteAttribute();
            WriteLiteral(@">新增</a></h3>

<div>
    <table id=""sortTable"" class=""table tables display compact hover col-12"">
        <thead>
            <tr>
                <th style=""width:25px"">
                    ID
                </th>
                <th>
                    ");
#nullable restore
#line 21 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Cast\sortList.cshtml"
               Write(Html.DisplayNameFor(model => model.角色名字characterName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 24 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Cast\sortList.cshtml"
               Write(Html.DisplayNameFor(model => model.角色說明characterIllustrate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 27 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Cast\sortList.cshtml"
               Write(Html.DisplayNameFor(model => model.演員編號actor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 30 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Cast\sortList.cshtml"
               Write(Html.DisplayNameFor(model => model.電影編號movie));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 36 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Cast\sortList.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th class=\"col-1\">\r\n                    ");
#nullable restore
#line 40 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Cast\sortList.cshtml"
               Write(Html.DisplayFor(modelItem => item.演員編號actorId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <td>\r\n                    ");
#nullable restore
#line 43 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Cast\sortList.cshtml"
               Write(Html.DisplayFor(modelItem => item.角色名字characterName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td style=\"white-space:nowrap\">\r\n                    <textarea rows=\"1\" class=\"tables_hidtext\">\r\n                    ");
#nullable restore
#line 47 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Cast\sortList.cshtml"
               Write(Html.DisplayFor(modelItem => item.角色說明characterIllustrate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </textarea>\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 51 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Cast\sortList.cshtml"
               Write(Html.DisplayFor(modelItem => item.演員編號actor.英文名字nameEng));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 54 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Cast\sortList.cshtml"
               Write(Html.DisplayFor(modelItem => item.電影編號movie.英文標題titleEng));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a class=\"btn btn-info mb-1\" id=\"btn\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2171, "\"", 2273, 3);
            WriteAttributeValue("", 2181, "showmodal(\'", 2181, 11, true);
#nullable restore
#line 57 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Cast\sortList.cshtml"
WriteAttributeValue("", 2192, Url.Action("Edit","Actor",new {id=@item.主演編號maId},Context.Request.Scheme), 2192, 74, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2266, "\',null)", 2266, 7, true);
            EndWriteAttribute();
            WriteLiteral(">修改</a>\r\n                    <a class=\"btn btn-info mb-1\" id=\"btn\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2340, "\"", 2445, 3);
            WriteAttributeValue("", 2350, "showmodal(\'", 2350, 11, true);
#nullable restore
#line 58 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Cast\sortList.cshtml"
WriteAttributeValue("", 2361, Url.Action("Details","Actor",new {id=@item.主演編號maId},Context.Request.Scheme), 2361, 77, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2438, "\',null)", 2438, 7, true);
            EndWriteAttribute();
            WriteLiteral(">細節</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 61 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Cast\sortList.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e1c417690d53858cfe9c26c71cc10fffaa2c5a512336", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e1c417690d53858cfe9c26c71cc10fffaa2c5a513376", async() => {
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
        $('#sortTable').DataTable({
            //中文化
            ""language"": {
                ""processing"": ""處理中..."",
                ""loadingRecords"": ""載入中..."",
                ""paginate"": {
                    ""first"": ""第一頁"",
                    ""previous"": ""上一頁"",
                    ""next"": ""下一頁"",
                    ""last"": ""最後一頁""
                },
                ""emptyTable"": ""目前沒有資料"",
                ""datetime"": {
                    ""previous"": ""上一頁"",
                    ""next"": ""下一頁"",
                    ""hours"": ""時"",
                    ""minutes"": ""分"",
                    ""seconds"": ""秒"",
                    ""amPm"": [
                        ""上午"",
                        ""下午""
                    ],
                    ""unknown"": ""未知"",
                    ""weekdays"": [
                        ""週日"",
      ");
            WriteLiteral(@"                  ""週一"",
                        ""週二"",
                        ""週三"",
                        ""週四"",
                        ""週五"",
                        ""週六""
                    ],
                    ""months"": [
                        ""一月"",
                        ""二月"",
                        ""三月"",
                        ""四月"",
                        ""五月"",
                        ""六月"",
                        ""七月"",
                        ""八月"",
                        ""九月"",
                        ""十月"",
                        ""十一月"",
                        ""十二月""
                    ]
                },
                ""searchBuilder"": {
                    ""add"": ""新增條件"",
                    ""condition"": ""條件"",
                    ""deleteTitle"": ""刪除過濾條件"",
                    ""button"": {
                        ""_"": ""複合查詢 (%d)"",
                        ""0"": ""複合查詢""
                    },
                    ""clearAll"": ""清空"",
                    ""conditions"": {
 ");
            WriteLiteral(@"                       ""array"": {
                            ""contains"": ""含有"",
                            ""equals"": ""等於"",
                            ""empty"": ""空值"",
                            ""not"": ""不等於"",
                            ""notEmpty"": ""非空值"",
                            ""without"": ""不含""
                        },
                        ""date"": {
                            ""after"": ""大於"",
                            ""before"": ""小於"",
                            ""between"": ""在其中"",
                            ""empty"": ""為空"",
                            ""equals"": ""等於"",
                            ""not"": ""不為"",
                            ""notBetween"": ""不在其中"",
                            ""notEmpty"": ""不為空""
                        },
                        ""number"": {
                            ""between"": ""在其中"",
                            ""empty"": ""為空"",
                            ""equals"": ""等於"",
                            ""gt"": ""大於"",
                            ""gte"": ""大於等於"",
   ");
            WriteLiteral(@"                         ""lt"": ""小於"",
                            ""lte"": ""小於等於"",
                            ""not"": ""不為"",
                            ""notBetween"": ""不在其中"",
                            ""notEmpty"": ""不為空""
                        },
                        ""string"": {
                            ""contains"": ""含有"",
                            ""empty"": ""為空"",
                            ""endsWith"": ""字尾為"",
                            ""equals"": ""等於"",
                            ""not"": ""不為"",
                            ""notEmpty"": ""不為空"",
                            ""startsWith"": ""字首為"",
                            ""notContains"": ""不含"",
                            ""notStartsWith"": ""開頭不是"",
                            ""notEndsWith"": ""結尾不是""
                        }
                    },
                    ""data"": ""欄位"",
                    ""leftTitle"": ""群組條件"",
                    ""logicAnd"": ""且"",
                    ""logicOr"": ""或"",
                    ""rightTitle"": ""取消群組"",
            ");
            WriteLiteral(@"        ""title"": {
                        ""_"": ""複合查詢 (%d)"",
                        ""0"": ""複合查詢""
                    },
                    ""value"": ""內容""
                },
                ""editor"": {
                    ""close"": ""關閉"",
                    ""create"": {
                        ""button"": ""新增"",
                        ""title"": ""新增資料"",
                        ""submit"": ""送出新增""
                    },
                    ""remove"": {
                        ""button"": ""刪除"",
                        ""title"": ""刪除資料"",
                        ""submit"": ""送出刪除"",
                        ""confirm"": {
                            ""_"": ""您確定要刪除您所選取的 %d 筆資料嗎？"",
                            ""1"": ""您確定要刪除您所選取的 1 筆資料嗎？""
                        }
                    },
                    ""error"": {
                        ""system"": ""系統發生錯誤(更多資訊)""
                    },
                    ""edit"": {
                        ""button"": ""修改"",
                        ""title"": ""修改資料"",
                ");
            WriteLiteral(@"        ""submit"": ""送出修改""
                    },
                    ""multi"": {
                        ""title"": ""多重值"",
                        ""info"": ""您所選擇的多筆資料中，此欄位包含了不同的值。若您想要將它們都改為同一個值，可以在此輸入，要不然它們會保留各自原本的值。"",
                        ""restore"": ""復原"",
                        ""noMulti"": ""此輸入欄需單獨輸入，不容許多筆資料一起修改""
                    }
                },
                ""autoFill"": {
                    ""cancel"": ""取消""
                },
                ""buttons"": {
                    ""copySuccess"": {
                        ""_"": ""複製了 %d 筆資料"",
                        ""1"": ""複製了 1 筆資料""
                    },
                    ""copyTitle"": ""已經複製到剪貼簿"",
                    ""excel"": ""Excel"",
                    ""pdf"": ""PDF"",
                    ""print"": ""列印"",
                    ""copy"": ""複製"",
                    ""colvis"": ""欄位顯示"",
                    ""colvisRestore"": ""重置欄位顯示"",
                    ""csv"": ""CSV"",
                    ""pageLength"": {
                        ""-1"": ""顯示全部"",
      ");
            WriteLiteral(@"                  ""_"": ""顯示 %d 筆""
                    },
                    ""createState"": ""建立狀態"",
                    ""removeAllStates"": ""移除所有狀態"",
                    ""removeState"": ""移除"",
                    ""renameState"": ""重新命名"",
                    ""savedStates"": ""儲存狀態"",
                    ""stateRestore"": ""狀態 %d"",
                    ""updateState"": ""更新""
                },
                ""searchPanes"": {
                    ""collapse"": {
                        ""_"": ""搜尋面版 (%d)"",
                        ""0"": ""搜尋面版""
                    },
                    ""emptyPanes"": ""沒搜尋面版"",
                    ""loadMessage"": ""載入搜尋面版中..."",
                    ""clearMessage"": ""清空"",
                    ""count"": ""{total}"",
                    ""countFiltered"": ""{shown} ({total})"",
                    ""title"": ""過濾條件 - %d"",
                    ""showMessage"": ""顯示全部"",
                    ""collapseMessage"": ""摺疊全部""
                },
                ""stateRestore"": {
                    ""emptyError"": ""名");
            WriteLiteral(@"稱不能空白。"",
                    ""creationModal"": {
                        ""button"": ""建立"",
                        ""columns"": {
                            ""search"": ""欄位搜尋"",
                            ""visible"": ""欄位顯示""
                        },
                        ""name"": ""名稱："",
                        ""order"": ""排序"",
                        ""paging"": ""分頁"",
                        ""scroller"": ""卷軸位置"",
                        ""search"": ""搜尋"",
                        ""searchBuilder"": ""複合查詢"",
                        ""select"": ""選擇"",
                        ""title"": ""建立新狀態"",
                        ""toggleLabel"": ""包含：""
                    },
                    ""duplicateError"": ""此狀態名稱已經存在。"",
                    ""emptyStates"": ""名稱不可空白。"",
                    ""removeConfirm"": ""確定要移除 %s 嗎？"",
                    ""removeError"": ""移除狀態失敗。"",
                    ""removeJoiner"": ""和"",
                    ""removeSubmit"": ""移除"",
                    ""removeTitle"": ""移除狀態"",
                    ""renameButton");
            WriteLiteral(@""": ""重新命名"",
                    ""renameLabel"": ""%s 的新名稱："",
                    ""renameTitle"": ""重新命名狀態""
                },
                ""select"": {
                    ""columns"": {
                        ""_"": ""選擇了 %d 欄資料"",
                        ""1"": ""選擇了 1 欄資料""
                    },
                    ""rows"": {
                        ""1"": ""選擇了 1 筆資料"",
                        ""_"": ""選擇了 %d 筆資料""
                    },
                    ""cells"": {
                        ""1"": ""選擇了 1 格資料"",
                        ""_"": ""選擇了 %d 格資料""
                    }
                },
                ""zeroRecords"": ""沒有符合的資料"",
                ""aria"": {
                    ""sortAscending"": ""：升冪排列"",
                    ""sortDescending"": ""：降冪排列""
                },
                ""info"": ""顯示第 _START_ 至 _END_ 筆結果，共 _TOTAL_ 筆"",
                ""infoEmpty"": ""顯示第 0 至 0 筆結果，共 0 筆"",
                ""infoFiltered"": ""(從 _MAX_ 筆結果中過濾)"",
                ""infoThousands"": "","",
                ""lengthMenu"": """);
            WriteLiteral("顯示 _MENU_ 筆結果\",\r\n                \"search\": \"搜尋：\",\r\n                \"searchPlaceholder\": \"請輸入關鍵字\",\r\n                \"thousands\": \",\"\r\n            }\r\n        });\r\n    });\r\n</script>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e1c417690d53858cfe9c26c71cc10fffaa2c5a524827", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ServerMDA.Models.電影主演cast>> Html { get; private set; }
    }
}
#pragma warning restore 1591
