#pragma checksum "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\product\copySearchKeyword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0db69826ab31dc7e82c03161258d4976399d48ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_product_copySearchKeyword), @"mvc.1.0.view", @"/Views/product/copySearchKeyword.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0db69826ab31dc7e82c03161258d4976399d48ac", @"/Views/product/copySearchKeyword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f44792abd596afd1ba2515f7ae3cd7cc9ca71375", @"/Views/_ViewImports.cshtml")]
    public class Views_product_copySearchKeyword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\product\copySearchKeyword.cshtml"
  
    ViewData["Title"] = "SearchKeyword";
    Layout = "~/Views/Shared/_WenLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-2\">\r\n\r\n    </div>\r\n    <div class=\"col-8\">\r\n\r\n");
            WriteLiteral("        <button type=\"button\" id=\"mysearch\" class=\"btn-primary\"><i class=\"fa-solid fa-magnifying-glass\"></i>搜尋關鍵字</button>\r\n        <input type=\"text\" class=\"form-control\" id=\"mykeyword\">\r\n\r\n    </div>\r\n    <div class=\"col-2\"></div>\r\n</div>\r\n\r\n<br />\r\n");
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"card-columns\">\r\n\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
     const inputText = document.querySelector(""#mykeyword"")
     const Mysearch = document.querySelector(""#mysearch"")
     const Mydiv1 = document.querySelector(""#mydiv"")
     const MylistData = document.querySelector("".container"")

     inputText.addEventListener(""input"", async () => {
         const keyword = inputText.value
         //console.log(keyword)
         let response = await fetch(""");
#nullable restore
#line 39 "C:\Users\duckl\Documents\ServerMDA-\ServerMDA\Views\product\copySearchKeyword.cshtml"
                                Write(Url.Content("~/WenShoppingCart/TestSearchKeyword"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""" + `?keyword=${keyword}`)
         // console.log(response)
         let result = await response.json() //[""Chai"",""Chang"",""Chartreuse verte""]
         console.log(result.length)
         console.log(result)

         result.forEach(item => {
             console.log(item.商品名稱productName)
             console.log(item.商品價格productPrice)
             console.log(item.商品介紹introduce)
             console.log(item.商品圖片路徑imagePath)
             console.log(item.電影院名稱theaterName)

         })
         let b = result.map(item => {

             return (
                 `<div class=""container"">
<div class=""card bg-white text-dark"" style=""width: 20rem; height:33rem;"" >
                 <img class=""card-img-top img-thumbnail p-4"" src=""/images/${item.商品圖片路徑imagePath}"" />
                 <div class=""card-body"">
                 <h5 class=""card-title"">品名: ${item.商品名稱productName}<br/><small>[${item.電影院名稱theaterName}]<small></h5>
                 <p class=""card-text"">類別: ${item.類別category}</br>價格: ${i");
                WriteLiteral(@"tem.商品價格productPrice}</br>描述: ${item.商品介紹introduce}</p>
                 <a href=""#"" class=""btn btn-outline-success"">加入購物車</a>
                </div>
                </div>
</div>`
                 )
         })
         document.querySelector("".card-columns"").innerHTML = b.join("""")

         })

    </script>
");
            }
            );
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
