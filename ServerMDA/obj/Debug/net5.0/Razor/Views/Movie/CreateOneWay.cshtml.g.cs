#pragma checksum "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Movie\CreateOneWay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "239e6c4b19075710c5f59b566a1646bae988c00f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_CreateOneWay), @"mvc.1.0.view", @"/Views/Movie/CreateOneWay.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"239e6c4b19075710c5f59b566a1646bae988c00f", @"/Views/Movie/CreateOneWay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f44792abd596afd1ba2515f7ae3cd7cc9ca71375", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_CreateOneWay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bootstrap-5.2.2/YukabtnEdit.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Movie/CreateOneDragon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/vendor/jquery/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Movie\CreateOneWay.cshtml"
  
    ViewData["Title"] = "新增";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "239e6c4b19075710c5f59b566a1646bae988c00f6035", async() => {
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
            WriteLiteral(@"
<style>
    .card {
        overflow: scroll;
    }

    .list-group-item {
    }

        .list-group-item img {
            position: relative;
            max-height: 75px;
            padding-left: 5%;
            float: right;
        }

    .dataimg {
        position: relative;
        height: 277px;
        max-width: 200px;
        padding-left: 2%;
        padding-bottom: 3%;
    }
</style>

<h4>新增電影</h4>

<div class=""row"">
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "239e6c4b19075710c5f59b566a1646bae988c00f7619", async() => {
                WriteLiteral(@"
        <div class=""col-12"">
            <div class=""d-flex flex-row"">
                <div class=""col-2"">
                    <div class=""form-group"">
                        <label for=""Series_ID"" class=""control-label"">系列名稱</label>
                        <button type=""button"" class=""d-inline btn btn-yuka ml-3"" id=""NewSeries"">新增系列</button>
                        ");
#nullable restore
#line 41 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Movie\CreateOneWay.cshtml"
                   Write(await Component.InvokeAsync("Series"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>
                    <div class=""form-group"">
                        <label for=""Title_Chi"" class=""control-label"">電影中文名</label>
                        <input class=""form-control"" id=""Title_Chi"" name=""Title_Chi"" />
                        <span class=""text-danger""></span>
                    </div>
                    <div class=""form-group"">
                        <label for=""Title_Eng"" class=""control-label"">電影英文名</label>
                        <input class=""form-control"" id=""Title_Eng"" name=""Title_Eng"" />
                        <span class=""text-danger""></span>
                    </div>
                    <div class=""form-group"">
                        <label for=""Release_Date"" class=""control-label"">上映日期</label>
                        <input type=""date"" class=""form-control"" id=""Release_Date"" name=""Release_Date"" />
                        <span class=""text-danger""></span>
                    </div>
                    <div class=""form-group"">
             ");
                WriteLiteral(@"           <label for=""runtime"" class=""control-label"">片長</label>
                        <input class=""form-control"" id=""runtime"" name=""runtime"" />
                        <span class=""text-danger""></span>
                    </div>

                </div>
                <div class=""col-4"">
                    <div class=""form-group"">
                        <label for=""Rate_ID"" class=""control-label"">電影分級</label>
                        ");
#nullable restore
#line 68 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Movie\CreateOneWay.cshtml"
                   Write(await Component.InvokeAsync("Rate"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>
                    <div class=""form-group"">
                        <label for=""Box"" class=""control-label"">票房</label>
                        <input class=""form-control"" id=""Box"" name=""Box"" />
                        <span class=""text-danger""></span>
                    </div>
                    <div class=""form-group"">
                        <label for=""TrailerUrl"" class=""control-label"">預告片(網址)</label>
                        <input class=""form-control"" id=""TrailerUrl"" name=""TrailerUrl"" />
                        <span class=""text-danger""></span>
                    </div>
                    <div class=""form-group"">
                        <label for=""Plot"" class=""control-label"">電影介紹</label>
                        <textarea rows=""5"" class=""form-control"" id=""Plot"" name=""Plot""></textarea>
                        <span class=""text-danger""></span>
                    </div>
                    <div class=""form-group"" style=""float:right"">
                        ");
                WriteLiteral("<button type=\"button\" class=\"btn btn-success\" id=\"sumbit\">上傳新資料</button>\r\n                        <button type=\"button\" class=\"btn btn-dark\" aria-label=\"Close\" id=\"demoDragon\">Demo</button>\r\n");
                WriteLiteral("                    </div>\r\n                </div>\r\n                <div class=\"col-6 ml-4\">\r\n");
                WriteLiteral("                    <div class=\" pt-1 \">\r\n                        <label class=\"btn-gary\">導演清單</label>\r\n                        <a class=\"btn btn-details mb-1\" id=\"btn\"");
                BeginWriteAttribute("onclick", " onclick=\"", 4618, "\"", 4710, 3);
                WriteAttributeValue("", 4628, "showmodalD(\'", 4628, 12, true);
#nullable restore
#line 99 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Movie\CreateOneWay.cshtml"
WriteAttributeValue("", 4640, Url.Action("CreateDirector","Movie", Context.Request.Scheme), 4640, 61, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4701, "\',\'加入導演\')", 4701, 9, true);
                EndWriteAttribute();
                WriteLiteral(@">新增導演</a>
                        <ul class=""list-group"" id=""DlistInfo"">
                        </ul>
                    </div>
                    <div class="" pt-4"">
                        <label class=""btn-gary"">演員清單</label>
                        <a class=""btn btn-details mb-1"" id=""btn""");
                BeginWriteAttribute("onclick", " onclick=\"", 5012, "\"", 5101, 3);
                WriteAttributeValue("", 5022, "showmodalA(\'", 5022, 12, true);
#nullable restore
#line 105 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Movie\CreateOneWay.cshtml"
WriteAttributeValue("", 5034, Url.Action("CreateActor","Movie", Context.Request.Scheme), 5034, 58, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 5092, "\',\'加入演員\')", 5092, 9, true);
                EndWriteAttribute();
                WriteLiteral(@">新增演員</a>
                        <ul class=""list-group"" id=""AlistInfo"">
                        </ul>
                    </div>
                    <div class="" pt-4"">
                        <label class=""btn-gary"">圖片清單</label>
                        <div class=""d-block"" id=""picBox"">
                        </div>
                        <input type=""file"" id=""btnP"" value=""上傳照片"" name=""photos"" multiple>
                    </div>
                </div>
            </div>
        </div>
        <div id=""Ddata""></div>
        <div id=""Adata""></div>
        <div id=""Pdata""></div>
        <input type=""hidden"" name=""Series_ID"" id=""Sid""/>
        <input type=""hidden"" name=""Rate_ID"" id=""Rid""/>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "239e6c4b19075710c5f59b566a1646bae988c00f16376", async() => {
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
            WriteLiteral(@"
<script src=""//cdn.jsdelivr.net/npm/sweetalert2@11""></script>
<script type=""text/javascript"" charset=""utf8"" src=""https://cdn.datatables.net/1.12.1/js/jquery.dataTables.js""></script>

<script>

    demoDragon.addEventListener(""click"", () => {
        console.log(15);
        const demoDragon = document.querySelector(""#demoDragon"");
        const titleCh = document.querySelector(""#Title_Chi"");
        const titleEn = document.querySelector(""#Title_Eng"");

        const date = document.querySelector(""#Release_Date"");
        const runtime = document.querySelector(""#runtime"");
        const box = document.querySelector(""#Box"");
        const plot = document.querySelector(""#Plot"");
        const trailerUrl = document.querySelector(""#TrailerUrl"");


        titleCh.value = ""M.D.A一條龍設計製作Demo"";
        titleEn.value = ""Movie, Drama, Anime Using MovieDemo"";
        trailerUrl.value =""https://www.youtube.com/MDA/DragonBall7z""
        date.value = ""2022-11-16"";
        runtime.value = 113;
     ");
            WriteLiteral(@"   box.value = 1.007;
        plot.value = ""M.D.A一條龍由李沛軒設計製作，希望藉由這個整合平台，讓最完整的電影、電視劇及動畫相關資訊都能快速方便的被使用者查找、觀賞及討論。藉由多媒體媒介（如電影預告片、快速訂票系統、評論交流區）提高用戶的使用體驗。提供使用者一個方便查看電影資訊、快速訂票、發表並交流電影評論的管道。"";
    })

</script>






<script>

    showmodalD = (url, title) => {
        $.ajax({
            type: ""GET"",
            url: url,
            success: function (res) {
                $(""#newstaticBackdrop .modal-body"").empty();
                $(""#newstaticBackdrop .modal-title"").empty();
                $(""#newstaticBackdrop .modal-body"").html(res);
                $(""#newstaticBackdrop .modal-title"").html(title);
                $(""#newstaticBackdrop"").modal('show');
                AddDropEvent('director', 'directordropzone', 'directorlist');
                CloseAndSaveEvent('DlistInfo', 'Ddata','directors');
            },
        })
    }
    showmodalA = (url, title) => {
        $.ajax({
            type: ""GET"",
            url: url,
            success: function (res) {
            ");
            WriteLiteral(@"    $(""#newstaticBackdrop .modal-body"").empty();
                $(""#newstaticBackdrop .modal-title"").empty();
                $(""#newstaticBackdrop .modal-body"").html(res);
                $(""#newstaticBackdrop .modal-title"").html(title);
                $(""#newstaticBackdrop"").modal('show');
                AddDropEvent('actor', 'actordropzone', 'actorlist');
                CloseAndSaveEvent('AlistInfo', 'Adata', 'actors');
            },
        })
    }

    let items;
    let zone;
    let list;

    let ActorsArr = new Array(); //放演員陣列
    let Dirctor = new Array(); //放導演陣列

    function dragStartHandler(e) {
        let id = this.getAttribute('id');
        e.dataTransfer.setData(""text/plain"", id);
    }//儲存要拖放的資
    function dragoverHandler(e) {
        e.preventDefault();
    }//取消預設動作
    function dropHandler(e) {
        e.preventDefault();
        let ID = e.dataTransfer.getData(""text/plain"");
        let element = document.getElementById(`${ID}`);
        let eleli =");
            WriteLiteral(@" document.createElement('li');
        eleli.innerHTML = element.textContent;
        list.appendChild(eleli)
        eleli.setAttribute(""class"", ""list-group-item"");
        eleli.setAttribute(""name"", ""additem"");
        eleli.setAttribute(""data"", `${element.getAttribute('value')}`);
        element.setAttribute('draggable', 'false');


    }
    function AddDropEvent(itemname,zonename,listname) {
        items = document.getElementsByName(itemname)
        zone = document.getElementById(zonename);
        list = document.getElementById(listname);
        for (let item of items) {
            item.addEventListener(""dragstart"", dragStartHandler);
        }
        zone.addEventListener('drop', dropHandler)
        zone.addEventListener('dragover', dragoverHandler)
    }
    function CloseAndSaveEvent(ulid,divid,name) {
        $('#closeandsave').click(() => {
            let data = document.getElementsByName('additem');
            $(`#${ulid}`).empty();
            for (let item of dat");
            WriteLiteral(@"a) {
                let eleli = document.createElement('li');
                let eleinput = document.createElement('input')
                eleli.setAttribute('value', `${item.getAttribute('data')}`);
                eleli.textContent = item.textContent;
                eleinput.setAttribute('value', `${item.getAttribute('data')}`);
                eleinput.setAttribute('name', name)
                eleinput.setAttribute('type', 'hidden');
                document.getElementById(ulid).appendChild(eleli);
                document.getElementById(divid).appendChild(eleinput);

            }
            $(""#newstaticBackdrop"").modal('hide');
        })
    }

    $('#NewSeries').click(() => {
        Swal.fire({
            title: '新的系列',
            input: 'text',
            inputLabel: '輸入新系列名稱',
            inputPlaceholder: '系列名稱'
        })


        $('.swal2-confirm').click(() => {
            let name = $('#swal2-input').val()
            console.log('click')
            con");
            WriteLiteral("sole.log(name);\r\n            let _url = \'");
#nullable restore
#line 279 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Movie\CreateOneWay.cshtml"
                   Write(Url.Action("CreateNewSerial", "Movie"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + `?name=${name}`;
            $.ajax({
                type:""GET"",
                url: _url,
                success: function (result) {
                    if (result == 'T') {
                        Swal.fire({
                            icon: 'success',
                            title: '成功',
                            text: '新系列已新增，請重新整理!',
                        })
                    }
                    else {
                        Swal.fire({
                            icon: 'error',
                            title: '失敗',
                            text: '新增失敗，請重新執行!',
                        })
                    }

                }
            });
        })
    })

    let imageBuffer;

    $('#btnP').on(""change"", function () {
        console.log('change')
        $.each(this.files, function (index, file) {
            console.log(file);
            let image = document.createElement('img');
            let src = URL.createObjectURL(file);
      ");
            WriteLiteral(@"      image.setAttribute('src', src);
            image.setAttribute('class', 'dataimg');
            $('#picBox').append(image);

        })
    })

    $('#sumbit').click(function () {
        console.log($('#Rate_ID  option:selected').val())
        console.log($('#Series_ID option:selected').val())
        document.getElementById('Rid').setAttribute('value', $('#Rate_ID  option:selected').val())
        document.getElementById('Sid').setAttribute('value', $('#Series_ID  option:selected').val())

        $('#form').submit();
    })

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
