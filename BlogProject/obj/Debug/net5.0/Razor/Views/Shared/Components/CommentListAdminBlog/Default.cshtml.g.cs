#pragma checksum "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Shared\Components\CommentListAdminBlog\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a5583ef60f29379c021aba9f7130ba44be6ce9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CommentListAdminBlog_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CommentListAdminBlog/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a5583ef60f29379c021aba9f7130ba44be6ce9d", @"/Views/Shared/Components/CommentListAdminBlog/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f611d8a26e9ddd131eab235047e43c94299cee7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_CommentListAdminBlog_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntitylayerCore.Concrete.Comment>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Shared\Components\CommentListAdminBlog\Default.cshtml"
    foreach (var x in Model)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"feed-element\">\r\n                <a href=\"#\" class=\"float-left\">\r\n                    <img alt=\"image\" class=\"rounded-circle\"");
            BeginWriteAttribute("src", " src=\"", 239, "\"", 267, 1);
#nullable restore
#line 7 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Shared\Components\CommentListAdminBlog\Default.cshtml"
WriteAttributeValue("", 245, ViewBag.imagecomment1, 245, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                </a>\r\n                <div class=\"media-body \">\r\n                    <small class=\"float-right\">2h ago</small>\r\n                    <strong>");
#nullable restore
#line 11 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Shared\Components\CommentListAdminBlog\Default.cshtml"
                       Write(x.CommentUserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> ");
#nullable restore
#line 11 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Shared\Components\CommentListAdminBlog\Default.cshtml"
                                                   Write(x.CommentTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <strong></strong>  <br>\r\n                    <small class=\"text-muted\">");
#nullable restore
#line 12 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Shared\Components\CommentListAdminBlog\Default.cshtml"
                                          Write(((DateTime)x.CommentDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                    <div class=\"well\">\r\n                        ");
#nullable restore
#line 14 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Shared\Components\CommentListAdminBlog\Default.cshtml"
                   Write(x.CommentContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"float-right\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 788, "\"", 795, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-xs btn-white\"><i class=\"fa fa-thumbs-up\"></i> Bəyən </a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 896, "\"", 903, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-xs btn-white\"><i class=\"fa fa-heart\"></i> İzlə</a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 998, "\"", 1005, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-xs btn-primary\"><i class=\"fa fa-pencil\"></i> Cavabla</a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 23 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Shared\Components\CommentListAdminBlog\Default.cshtml"

     
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntitylayerCore.Concrete.Comment>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591