#pragma checksum "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Blog\GetBlogByName.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c248c268f4c596c7002e2bf6cb9d786dd76dcd0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_GetBlogByName), @"mvc.1.0.view", @"/Views/Blog/GetBlogByName.cshtml")]
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
#line 1 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Blog\GetBlogByName.cshtml"
using EntitylayerCore.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c248c268f4c596c7002e2bf6cb9d786dd76dcd0e", @"/Views/Blog/GetBlogByName.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f611d8a26e9ddd131eab235047e43c94299cee7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_GetBlogByName : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Blog\GetBlogByName.cshtml"
  
    ViewData["Title"] = "GetBlogByName";
    Layout = "~/Views/Shared/_BlogLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"main-content-w3layouts-agileits\">\r\n\t<div class=\"container\">\r\n\t\t<h3 class=\"tittle\">BlogLar</h3>\r\n\t\t<div class=\"inner-sec\">\r\n\t\t\t<!--left-->\r\n\t\t\t<div class=\"left-blog-info-w3layouts-agileits text-left\">\r\n\t\t\t\t<div class=\"row\">\r\n");
#nullable restore
#line 15 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Blog\GetBlogByName.cshtml"
                     foreach (var item in Model)
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<div class=\"col-lg-4 card\">\r\n\r\n\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 484, "\"", 521, 2);
            WriteAttributeValue("", 491, "/Blog/BlogReadAll/", 491, 18, true);
#nullable restore
#line 19 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Blog\GetBlogByName.cshtml"
WriteAttributeValue("", 509, item.BlogId, 509, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 537, "\"", 558, 1);
#nullable restore
#line 20 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Blog\GetBlogByName.cshtml"
WriteAttributeValue("", 543, item.BlogImage, 543, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 590, "\"", 596, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"width:300px; height:220px;\">\r\n\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t<div class=\"card-body\">\r\n\t\t\t\t\t\t\t\t<ul class=\"blog-icons my-4\">\r\n\t\t\t\t\t\t\t\t\t<li>\r\n\t\t\t\t\t\t\t\t\t\t<a href=\"#\">\r\n\t\t\t\t\t\t\t\t\t\t\t<i class=\"far fa-calendar-alt\"></i> ");
#nullable restore
#line 26 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Blog\GetBlogByName.cshtml"
                                                                            Write(((DateTime)item.BlogDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t\t\t</li>\r\n");
            WriteLiteral("\t\t\t\t\t\t\t\t\t<li class=\"mx-2\">\r\n\t\t\t\t\t\t\t\t\t\t<a href=\"#\">\r\n\t\t\t\t\t\t\t\t\t\t\t<i class=\"fas fa-eye\"></i> ");
#nullable restore
#line 36 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Blog\GetBlogByName.cshtml"
                                                                  Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t\t\t\t<li>\r\n\t\t\t\t\t\t\t\t\t\t<a href=\"#\">\r\n\t\t\t\t\t\t\t\t\t\t\t<i class=\"fas fa-comment\"></i> 2000\r\n\t\t\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t\t\t</li>\r\n\r\n\t\t\t\t\t\t\t\t</ul>\r\n\t\t\t\t\t\t\t\t<h5 class=\"card-title\">\r\n\t\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 1360, "\"", 1397, 2);
            WriteAttributeValue("", 1367, "/Blog/BlogReadAll/", 1367, 18, true);
#nullable restore
#line 47 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Blog\GetBlogByName.cshtml"
WriteAttributeValue("", 1385, item.BlogId, 1385, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 47 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Blog\GetBlogByName.cshtml"
                                                                        Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\t\t\t\t\t\t\t\t</h5>\r\n");
#nullable restore
#line 49 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Blog\GetBlogByName.cshtml"
                                 if (item.BlogContent != null)
								{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t<p class=\"card-text mb-3\">");
#nullable restore
#line 51 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Blog\GetBlogByName.cshtml"
                                                         Write(item.BlogContent.Substring(0,item.BlogContent.Substring(0,100).LastIndexOf(" ")));

#line default
#line hidden
#nullable disable
            WriteLiteral("... </p>\r\n");
#nullable restore
#line 52 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Blog\GetBlogByName.cshtml"

								}
								else
								{

								}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 1673, "\"", 1710, 2);
            WriteAttributeValue("", 1680, "/Blog/BlogReadAll/", 1680, 18, true);
#nullable restore
#line 58 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Blog\GetBlogByName.cshtml"
WriteAttributeValue("", 1698, item.BlogId, 1698, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary read-m\">Davamını Oxu</a>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 61 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Blog\GetBlogByName.cshtml"
					}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\t\t\t\t</div>\r\n\t\t\t\t<!--//left-->\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</section>\r\n\r\n\r\n");
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
