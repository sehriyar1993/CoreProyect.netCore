#pragma checksum "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Shared\Components\BlogListDashBoard\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b84a922fdf3edac03c2e6cb7a94305bae9e9426"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BlogListDashBoard_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BlogListDashBoard/Default.cshtml")]
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
#line 1 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Shared\Components\BlogListDashBoard\Default.cshtml"
using EntitylayerCore.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b84a922fdf3edac03c2e6cb7a94305bae9e9426", @"/Views/Shared/Components/BlogListDashBoard/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f611d8a26e9ddd131eab235047e43c94299cee7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_BlogListDashBoard_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-12 grid-margin"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Son 10 Blog</h4>
                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th>#</th>
                                <th>Şəkil</th>
                                <th>Başlıq</th>
                                <th>Kateqoriya</th>
                                <th>Saytda Bax</th>
                                <th>Tarix</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 22 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Shared\Components\BlogListDashBoard\Default.cshtml"
                             foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\n                                    <td>\n                                        ");
#nullable restore
#line 26 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Shared\Components\BlogListDashBoard\Default.cshtml"
                                   Write(item.BlogId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    </td>\n                                <td>\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 1081, "\"", 1102, 1);
#nullable restore
#line 29 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Shared\Components\BlogListDashBoard\Default.cshtml"
WriteAttributeValue("", 1087, item.BlogImage, 1087, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"mr-2\" alt=\"image\"> \n                                </td>\n                               \n                                    <td> ");
#nullable restore
#line 32 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Shared\Components\BlogListDashBoard\Default.cshtml"
                                    Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </td>\n                                    <td> <label class=\"badge badge-gradient-success\">");
#nullable restore
#line 33 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Shared\Components\BlogListDashBoard\Default.cshtml"
                                                                                Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label  </td>\n                                <td>\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1467, "\"", 1504, 2);
            WriteAttributeValue("", 1474, "/Blog/BlogReadAll/", 1474, 18, true);
#nullable restore
#line 35 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Shared\Components\BlogListDashBoard\Default.cshtml"
WriteAttributeValue("", 1492, item.BlogId, 1492, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">Saytda Gör</a>\n\n");
            WriteLiteral("                                </td>\n                                    <td> ");
#nullable restore
#line 39 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Shared\Components\BlogListDashBoard\Default.cshtml"
                                     Write(((DateTime)item.BlogDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            </tr>\n");
#nullable restore
#line 41 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Shared\Components\BlogListDashBoard\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\n                    </table>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n");
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
