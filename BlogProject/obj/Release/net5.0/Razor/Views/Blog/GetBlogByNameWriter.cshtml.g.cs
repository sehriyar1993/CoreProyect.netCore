#pragma checksum "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Blog\GetBlogByNameWriter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "495c848fd87298a56b0c0aa1a60bb5a25332893d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_GetBlogByNameWriter), @"mvc.1.0.view", @"/Views/Blog/GetBlogByNameWriter.cshtml")]
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
#line 1 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\_ViewImports.cshtml"
using BlogProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\_ViewImports.cshtml"
using BlogProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Blog\GetBlogByNameWriter.cshtml"
using EntitylayerCore.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"495c848fd87298a56b0c0aa1a60bb5a25332893d", @"/Views/Blog/GetBlogByNameWriter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f611d8a26e9ddd131eab235047e43c94299cee7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_GetBlogByNameWriter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Blog\GetBlogByNameWriter.cshtml"
  
    ViewData["Title"] = "GetBlogByNameWriter";
    Layout = "~/Views/Shared/_MemberLayout.cshtml";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table Basic form elements"">
    <tr>
        <th>#</th>
        <th>Şəkil</th>
        <th>Başlıq</th>
        <th>Hazırlanma Vaxdı</th>
        <th>Kateqoriyası</th>
        <th>Saytda Bax</th>
        <th>Sil</th>
        <th>Yenilə</th>
    </tr>
");
#nullable restore
#line 20 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Blog\GetBlogByNameWriter.cshtml"
     foreach (var item in Model)
    {
        count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Blog\GetBlogByNameWriter.cshtml"
           Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><img");
            BeginWriteAttribute("src", " src=\"", 579, "\"", 600, 1);
#nullable restore
#line 25 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Blog\GetBlogByNameWriter.cshtml"
WriteAttributeValue("", 585, item.BlogImage, 585, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"50\" width=\"50\" /></td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Blog\GetBlogByNameWriter.cshtml"
           Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Blog\GetBlogByNameWriter.cshtml"
            Write(((DateTime)item.BlogDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Blog\GetBlogByNameWriter.cshtml"
           Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 815, "\"", 852, 2);
            WriteAttributeValue("", 822, "/Blog/BlogReadAll/", 822, 18, true);
#nullable restore
#line 29 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Blog\GetBlogByNameWriter.cshtml"
WriteAttributeValue("", 840, item.BlogId, 840, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">Saytda Gör</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 922, "\"", 955, 3);
            WriteAttributeValue("", 929, "/Blog/Delete/", 929, 13, true);
#nullable restore
#line 30 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Blog\GetBlogByNameWriter.cshtml"
WriteAttributeValue("", 942, item.BlogId, 942, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 954, "/", 954, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1020, "\"", 1053, 3);
            WriteAttributeValue("", 1027, "/Blog/Update/", 1027, 13, true);
#nullable restore
#line 31 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Blog\GetBlogByNameWriter.cshtml"
WriteAttributeValue("", 1040, item.BlogId, 1040, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1052, "/", 1052, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Yenilə</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 33 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Blog\GetBlogByNameWriter.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
