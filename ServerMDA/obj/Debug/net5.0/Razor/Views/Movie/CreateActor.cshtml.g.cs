#pragma checksum "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Movie\CreateActor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5a8c00ad754325bf5514af3c2017f3e3fd400df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_CreateActor), @"mvc.1.0.view", @"/Views/Movie/CreateActor.cshtml")]
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
#line 1 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Movie\CreateActor.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Movie\CreateActor.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Movie\CreateActor.cshtml"
using ServerMDA.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5a8c00ad754325bf5514af3c2017f3e3fd400df", @"/Views/Movie/CreateActor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f44792abd596afd1ba2515f7ae3cd7cc9ca71375", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_CreateActor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CMovieOneWayViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Movie\CreateActor.cshtml"
  
    ViewData["Title"] = "CreateActor";
    //Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Modal -->\r\n");
#nullable restore
#line 15 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Movie\CreateActor.cshtml"
 using (Html.BeginForm("WatchListCreate", "Member"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""modal-content"">
        <div class=""modal-header"">
            <h5 class=""modal-title"" id=""exampleModalLongTitle"" style=""color:black"">我的所有片單</h5>
            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                <span aria-hidden=""true"">&times;</span>
            </button>
        </div>
        <div class=""modal-body"">
            <!--modal content start-->

            <table id=""WatchList"" class=""table table-bordered"">
                <thead>
                    <tr>
                        <th>片單</th>
                        <th>移除</th>
                    </tr>
                </thead>
                <tbody id=""tableLists"">
                </tbody>
            </table>


            <button type=""button"" id=""btnAddList"" class=""site-btn btn-sm mt-3"">
                <i class=""fa fa-plus"">新增</i>
            </button>
            <input type=""text"" list=""typelist"" class=""form-control inputMovie"" id=""inputMovie"" name=""movieName""");
            WriteLiteral(@" placeholder=""演員名稱"">
            <datalist id=""typelist"" class=""typelist""></datalist>

            <small id=""duplicate"" style=""color:darkgray""></small>

            <!--modal content end-->
        </div>
        <div class=""modal-footer"">
            <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">取消</button>
            <button type=""button"" class=""btn btn-primary"" id=""submitAddList"">確定</button>
        </div>
    </div>
");
#nullable restore
#line 54 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Movie\CreateActor.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!--modal end-->
<script>
    const inputName = document.querySelector(""#inputMovie"")
    const inputMovie = document.querySelectorAll("".inputMovie"")
    const listData = document.querySelectorAll("".typelist"")
    const btnAddList = document.querySelector(""#btnAddList"")

");
            WriteLiteral("    btnAddList.addEventListener(\"click\", async () => {\r\n            const url = \"");
#nullable restore
#line 66 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Movie\CreateActor.cshtml"
                    Write(Url.Content("~/Movie/checkWatchList"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""
            const params = `?name=${inputName.value}`
            let response = await fetch(url + params)  //resolve->response, reject
            let data = await response.text()
            if (inputName.value == """") {
                duplicate.textContent = ""不可空白""
            }
            else if (data == 'True') {
                duplicate.textContent = ""演員名稱重複""
            }
            else {
                duplicate.textContent = """"

                var tr = document.createElement('tr');
                tr.innerHTML =
                            `
                        <td>
                        <input type=""hidden"" class=""id"" name=""listId"" value="""" />
                        <input type=""text"" class=""form-control name"" name=""listName"" value=""${inputName.value}""/>
                        </td>
                        <td><button type=""button"" onclick=""deleteRow(event)"" class=""btn btn-danger btn-sm delList""><i class=""fas fa-trash-alt""></i></button></td>
                    ");
            WriteLiteral("        `\r\n                tableLists.appendChild(tr);\r\n\r\n            }\r\n        })\r\n\r\n");
            WriteLiteral(@"        listData.forEach(item => {
            item.style.display=""none""
        })

        inputMovie.forEach(item => {

            item.addEventListener(""input"", async () => {
                let keyword = item.value
                let results = await fetch(""");
#nullable restore
#line 102 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\Movie\CreateActor.cshtml"
                                      Write(Url.Content("~/Movie/autoCmpMovie"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" + `?keyword=${keyword}`)
                let datas = await results.json()
                //console.log(datas)
                let htmlDatas = datas.map(data => {
                    return (
                        `
                <option onclick=""read(event)"">${data}</option>
                `)
                })
                listData.forEach(item => { item.innerHTML = htmlDatas.join("""") })
            })
        })
</script>

");
            WriteLiteral("<script>\r\n    function deleteRow(event) {\r\n        event.target.closest(\'tr\').remove();\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CMovieOneWayViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
