<<<<<<< HEAD
#pragma checksum "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\product\ProductSearchKeyword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48dc20e458c262ba854718ad01052109bea4436e"
=======
#pragma checksum "C:\MDA143後\ServerMDA\Views\product\ProductSearchKeyword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48dc20e458c262ba854718ad01052109bea4436e"
>>>>>>> 187505558a020f182b185c827468fca8ce7582d3
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_product_ProductSearchKeyword), @"mvc.1.0.view", @"/Views/product/ProductSearchKeyword.cshtml")]
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
#line 1 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\_ViewImports.cshtml"
=======
#line 1 "C:\MDA143後\ServerMDA\Views\_ViewImports.cshtml"
>>>>>>> 187505558a020f182b185c827468fca8ce7582d3
using ServerMDA;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\_ViewImports.cshtml"
=======
#line 2 "C:\MDA143後\ServerMDA\Views\_ViewImports.cshtml"
>>>>>>> 187505558a020f182b185c827468fca8ce7582d3
using ServerMDA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48dc20e458c262ba854718ad01052109bea4436e", @"/Views/product/ProductSearchKeyword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f44792abd596afd1ba2515f7ae3cd7cc9ca71375", @"/Views/_ViewImports.cshtml")]
    public class Views_product_ProductSearchKeyword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
<<<<<<< HEAD
#line 2 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\product\ProductSearchKeyword.cshtml"
=======
#line 2 "C:\MDA143後\ServerMDA\Views\product\ProductSearchKeyword.cshtml"
>>>>>>> 187505558a020f182b185c827468fca8ce7582d3
  
    ViewData["Title"] = "ProductSearchKeyword";
    Layout = "~/Views/Shared/_ChartLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div style=\"display:block;height:20px;\"></div>\r\n<h1>產品查詢</h1>\r\n<div class=\"row\">\r\n    <div class=\"col-2\">\r\n\r\n    </div>\r\n    <div class=\"col-8\">\r\n\r\n");
            WriteLiteral(@"        <button type=""button"" id=""mysearch"" class=""btn-primary""><i class=""fa-solid fa-magnifying-glass""></i>搜尋關鍵字</button>
        <input type=""text"" class=""form-control"" id=""mykeyword"">
        <div class=""list-group mt-3"">
            <button type=""button"" class=""list-group-item list-group-item-action"" aria-current=""true"">
                The current button
            </button>
            <button type=""button"" class=""list-group-item list-group-item-action"">A second item</button>
");
            WriteLiteral("        </div>\r\n\r\n    </div>\r\n    <div class=\"col-2\"></div>\r\n</div>\r\n<br />\r\n<br />\r\n");
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"card-columns\">\r\n\r\n    </div>\r\n</div>\r\n\r\n<div style=\"display:block;height:40px;\"></div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
     const inputText = document.querySelector(""#mykeyword"")
     const Mysearch = document.querySelector(""#mysearch"")
     const Mydiv1 = document.querySelector(""#mydiv"")
     const MylistData = document.querySelector("".container"")
     const listData = document.querySelector("".list-group"")
        listData.style.display = ""none""

        inputText.addEventListener(""input"", async () => {
         //console.log(inputText.value)
            const keyword = inputText.value
            listData.style.display = ""block""
         //console.log(keyword)
         //找到字就回傳字的索引值，找不到就回傳-1
         //let results = DATAS.filter(data => data.Name.indexOf(keyword) !== -1)

        //let htmlDatas = results.map(data => {
        //    return (
        //        `<button type=""button"" onclick=""read(event)"" class=""list-group-item list-group-item-action"">${data.Name}</button>`
        //        )
        //})
         let response = await fetch(""");
#nullable restore
<<<<<<< HEAD
#line 63 "C:\Users\Student\Documents\ServerMDA-\ServerMDA\Views\product\ProductSearchKeyword.cshtml"
=======
#line 63 "C:\MDA143後\ServerMDA\Views\product\ProductSearchKeyword.cshtml"
>>>>>>> 187505558a020f182b185c827468fca8ce7582d3
                                Write(Url.Content("~/product/PrdSearch"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""" + `?keyword=${keyword}`)
             //console.log(response)

         let result = await response.json() //[""Chai"",""Chang"",""Chartreuse verte""]
        // console.log(result.length)
            console.log(result)
            let mykey = result.filter(k => k.電影院名稱theaterName.indexOf(keyword) !== -1)
            let htmlDatas = mykey.map(myk => {

                return (
                    `<button type=""button"" onclick=""read(event)"" class=""list-group-item list-group-item-action"">${myk.電影院名稱theaterName}</button>`
                )
            })
            listData.innerHTML = htmlDatas.join("""")

            result.forEach(item => {
            //    let mykey = await response.filter(data => data.item.商品名稱productName.indexOf(keyword) !== -1)
            //      let htmlDatas = mykey.map(data => {
            //return (
            //    `<button type=""button"" onclick=""read(event)"" class=""list-group-item list-group-item-action"">${data.item.商品名稱productName}</button>`
            //    )");
                WriteLiteral(@"
            //      })
            //    listData.innerHTML = htmlDatas.join("""")
             //console.log(item.商品名稱productName)
             //console.log(item.商品價格productPrice)
             //console.log(item.商品介紹introduce)
             //console.log(item.商品圖片路徑imagePath)
             //console.log(item.電影院名稱theaterName)

         })
         let b = result.map(item => {

             return (
                 `<div class=""container"">
<div class=""card bg-white text-dark"" style=""width: 20rem; height:33rem;"" >
                 <img class=""card-img-top img-thumbnail p-4"" src=""/images/WenProduct/${item.商品圖片路徑imagePath}"" />
                 <div class=""card-body"">
                 <h5 class=""card-title"">品名: ${item.商品名稱productName}<br/><small>[${item.電影院名稱theaterName}]<small></h5>
                 <p class=""card-text"">類別: ${item.類別category}</br>價格: ${item.商品價格productPrice}</br>描述: ${item.商品介紹introduce}</p>
                </div>
                </div>
</div>`
                 )
         }");
                WriteLiteral(")\r\n         document.querySelector(\".card-columns\").innerHTML = b.join(\"\")\r\n\r\n        })\r\n\r\n        function read(evt) {\r\n            inputText.value = evt.target.textContent\r\n            listData.style.display = \"none\"\r\n        }\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n\r\n");
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
