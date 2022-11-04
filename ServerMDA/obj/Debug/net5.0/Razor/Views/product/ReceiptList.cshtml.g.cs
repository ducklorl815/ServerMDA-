#pragma checksum "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\product\ReceiptList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41ab149c85bf88746db06f26e736b39bbe7c1d5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_product_ReceiptList), @"mvc.1.0.view", @"/Views/product/ReceiptList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41ab149c85bf88746db06f26e736b39bbe7c1d5e", @"/Views/product/ReceiptList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f44792abd596afd1ba2515f7ae3cd7cc9ca71375", @"/Views/_ViewImports.cshtml")]
    public class Views_product_ReceiptList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ServerMDA.ViewModel.WenViewModel.CRList>
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
#line 4 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\product\ReceiptList.cshtml"
  
    ViewData["Title"] = "ReceiptList";

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n   /* .Deletebtn {\r\n    }*/\r\n</style>\r\n<link rel=\"stylesheet\" type=\"text/css\" href=\"https://cdn.datatables.net/1.12.1/css/jquery.dataTables.min.css\">\r\n\r\n<h1>購買商品明細</h1>\r\n\r\n<div style=\"display:block;height:40px;\"></div>\r\n\r\n<div class=\"row\">\r\n");
            WriteLiteral(@"    <div class=""col-12"">
        <table class=""table table-hover"" id=""myTable"">
            <thead>
                <tr>
                    <th class=""ml-2"">
                        序號
                    </th>
                    <th class=""ml-2"">
                        購買商品明細
                    </th>
                    <th class=""ml-2"">
                        訂單編號
                    </th>
                    <th class=""ml-2"">
                        商品名稱
                    </th>
                    <th class=""ml-2"">
                        商品價格
                    </th>
                    <th class=""ml-2"">
                        數量
                    </th>
                    <th class=""ml-2"">
                        類別
                    </th>
                    <th class=""ml-2"">
                        電影院名稱
                    </th>
");
            WriteLiteral("                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 54 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\product\ReceiptList.cshtml"
                   int count = 0;

                    foreach (var item in Model.購買的明細表)
                    {
                        count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr");
            BeginWriteAttribute("data", " data=\"", 1695, "\"", 1721, 1);
#nullable restore
#line 59 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\product\ReceiptList.cshtml"
WriteAttributeValue("", 1702, item.商品編號productId, 1702, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <td>\r\n                                ");
#nullable restore
#line 61 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\product\ReceiptList.cshtml"
                           Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 64 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\product\ReceiptList.cshtml"
                           Write(Html.DisplayFor(modelItem => item.購買商品明細編號receiptId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 67 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\product\ReceiptList.cshtml"
                           Write(Html.DisplayFor(modelItem => item.訂單編號orderId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 70 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\product\ReceiptList.cshtml"
                           Write(Html.DisplayFor(modelItem => item.商品名稱productName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 73 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\product\ReceiptList.cshtml"
                           Write(item.商品價格productPrice.ToString("0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 76 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\product\ReceiptList.cshtml"
                           Write(Html.DisplayFor(modelItem => item.商品數量qty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n\r\n                            <td>\r\n                                ");
#nullable restore
#line 80 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\product\ReceiptList.cshtml"
                           Write(Html.DisplayFor(modelItem => item.類別category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 83 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\product\ReceiptList.cshtml"
                           Write(Html.DisplayFor(modelItem => item.電影院名稱theaterName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("                        </tr>\r\n");
#nullable restore
#line 96 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\product\ReceiptList.cshtml"

                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>

        <!--<div class=""modal fade text-dark"" id=""myModel"" data-backdrop=""static"">
            <div class=""modal-dialog"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h4>您好，要移除商品嗎?</h4>
                        <button class=""close"" data-dismiss=""modal"">&times;</button>
                    </div>
                    <div id=""div1"" class=""modal-body"">
                        <p>親愛的顧客您好，確定要移除，此商品嗎?</p>
                    </div>
                    <div class=""modal-footer"">
                        <button class=""btn btn-default"" data-dismiss=""modal"">關閉</button>-->
");
            WriteLiteral("        <!--<button id=\"D\" type=\"submit\" class=\"btn btn-warning\" data-dismiss=\"modal\">移除</button>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>-->\r\n\r\n    </div>\r\n</div>\r\n\r\n");
            WriteLiteral("<div style=\"display:block;height:40px;\"></div>\r\n\r\n");
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 133 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\product\ReceiptList.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral("    <script src=\"https://cdn.datatables.net/1.12.1/js/jquery.dataTables.min.js\"></script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41ab149c85bf88746db06f26e736b39bbe7c1d5e10809", async() => {
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
            $('#myTable').DataTable({
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
                            ""週一"",
           ");
                WriteLiteral(@"                 ""週二"",
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
                        }");
                WriteLiteral(@",
                        ""clearAll"": ""清空"",
                        ""conditions"": {
                            ""array"": {
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
         ");
                WriteLiteral(@"                       ""empty"": ""為空"",
                                ""equals"": ""等於"",
                                ""gt"": ""大於"",
                                ""gte"": ""大於等於"",
                                ""lt"": ""小於"",
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
      ");
                WriteLiteral(@"                      }
                        },
                        ""data"": ""欄位"",
                        ""leftTitle"": ""群組條件"",
                        ""logicAnd"": ""且"",
                        ""logicOr"": ""或"",
                        ""rightTitle"": ""取消群組"",
                        ""title"": {
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
                                ""_"": ""您確定要刪除您所選取的");
                WriteLiteral(@" %d 筆資料嗎？"",
                                ""1"": ""您確定要刪除您所選取的 1 筆資料嗎？""
                            }
                        },
                        ""error"": {
                            ""system"": ""系統發生錯誤(更多資訊)""
                        },
                        ""edit"": {
                            ""button"": ""修改"",
                            ""title"": ""修改資料"",
                            ""submit"": ""送出修改""
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
         ");
                WriteLiteral(@"                   ""1"": ""複製了 1 筆資料""
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
                            ""_"": ""顯示 %d 筆""
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
                  ");
                WriteLiteral(@"          ""_"": ""搜尋面版 (%d)"",
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
                        ""emptyError"": ""名稱不能空白。"",
                        ""creationModal"": {
                            ""button"": ""建立"",
                            ""columns"": {
                                ""search"": ""欄位搜尋"",
                                ""visible"": ""欄位顯示""
                            },
                            ""name"": ""名稱："",
                            ""order"": ""排序"",
                            ""paging"": ""分頁"",
            ");
                WriteLiteral(@"                ""scroller"": ""卷軸位置"",
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
                        ""renameButton"": ""重新命名"",
                        ""renameLabel"": ""%s 的新名稱："",
                        ""renameTitle"": ""重新命名狀態""
                    },
                    ""select"": {
                        ""columns"": {
                            ""_"": ""選擇了 %d 欄資料"",
                            ""1"": ""選擇了 1 欄資料""
                      ");
                WriteLiteral(@"  },
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
                    ""lengthMenu"": ""顯示 _MENU_ 筆結果"",
                    ""search"": ""搜尋："",
                    ""searchPlaceholder"": ""請輸入關鍵字"",
                    ""thousands"": "",""
                }

            });
        });
        //let delete");
                WriteLiteral(@"btns = document.getElementsByClassName('Deletebtn')//自動長出的刪除鍵
        //let deleteID = document.querySelector('#inputdelete')//隱藏欄位，放要刪除的產品id號碼
        //let D = document.querySelector('#D')//出現要刪除的方塊，「移除」的按鈕
        //let inputdelete = document.querySelector('#inputdelete')//隱藏欄位，放要刪除的產品id號碼,設定value

        //let pre = document.getElementById(""pre"")
        //let next = document.getElementById(""next"")
        //let tx = document.getElementById(""tx"")
        //let mytx = document.getElementById(""mytx"")
        //let ttable = $(""#ttable"");

        //next.addEventListener(""click"", evt => {
            //evt.preventDefault()
           // console.log('click')
          //  mytx.value = tx.value
            //mytx.setAttribute('value', mytx);
          //  console.log(mytx)
         //   $('#pagInfo').submit();

");
                WriteLiteral(@"       // })

        //delete-----------------------
       // for (let item of deletebtns) {
        //    item.addEventListener('click', evt => {
          //      evt.preventDefault();

               // deleteID = $(event.currentTarget).parents('tr')[0].getAttribute('data');
                //inputdelete.setAttribute('value', deleteID);
                //D.addEventListener('click', evt => {
                   // $('#Deleteform').submit();//form 的id

                //})


            //})

       // }

    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServerMDA.ViewModel.WenViewModel.CRList> Html { get; private set; }
    }
}
#pragma warning restore 1591