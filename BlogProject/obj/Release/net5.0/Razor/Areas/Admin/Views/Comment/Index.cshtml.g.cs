#pragma checksum "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Comment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05c91c59a60230964a9f2c9fd9a6c1b49021a7af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Comment_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Comment/Index.cshtml")]
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
#line 1 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Comment\Index.cshtml"
using EntitylayerCore.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Comment\Index.cshtml"
using X.PagedList.Mvc.Core.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Comment\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Comment\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05c91c59a60230964a9f2c9fd9a6c1b49021a7af", @"/Areas/Admin/Views/Comment/Index.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Comment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<Comment>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Comment\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""row wrapper border-bottom white-bg page-heading"">
    <div class=""col-sm-4"">
        <h2>Rəylər</h2>
        <ol class=""breadcrumb"">
            <li class=""breadcrumb-item"">
                <a href=""index.html"">Ana Səhifə</a>
            </li>
            <li class=""breadcrumb-item active"">
                <strong>Rəylətin Siyahısı</strong>
            </li>
        </ol>
    </div>
</div>
<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""wrapper wrapper-content animated fadeInRight"">
");
#nullable restore
#line 28 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Comment\Index.cshtml"
             foreach(var x in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""vote-item"">
                    <div class=""row"">
                        <div class=""col-md-10"">
                            <div class=""vote-actions"">
                                <a href=""#"">
                                    <i class=""fa fa-chevron-up""> </i>
                                </a>
                                <div>");
#nullable restore
#line 37 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Comment\Index.cshtml"
                                Write(x.CommentId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                <a href=""#"">
                                    <i class=""fa fa-chevron-down""> </i>
                                </a>
                            </div>
                            <a href=""#"" class=""vote-title"">
                                ");
#nullable restore
#line 43 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Comment\Index.cshtml"
                           Write(x.CommentContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </a>\r\n\r\n                            <div class=\"vote-info\">\r\n\r\n                                <i class=\"fa fa-comments-o\"></i> <a href=\"#\">");
#nullable restore
#line 48 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Comment\Index.cshtml"
                                                                        Write(x.CommentTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n                                <i class=\"fa fa-outdent\"></i> <a href=\"#\">");
#nullable restore
#line 49 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Comment\Index.cshtml"
                                                                     Write(x.Blog.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n                                <i class=\"fa fa-clock-o\"></i> <a href=\"#\">");
#nullable restore
#line 50 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Comment\Index.cshtml"
                                                                      Write(((DateTime)x.CommentDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                <i class=\"fa fa-user\"></i> <a href=\"#\">");
#nullable restore
#line 51 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Comment\Index.cshtml"
                                                                  Write(x.CommentUserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                            </div>
                        </div>
                        <div class=""col-md-2 "">
                            <div class=""vote-icon"">
                                <i class=""fa fa-css3""></i>
                            </div>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 61 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Comment\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("           \r\n        </div>\r\n    </div>\r\n    ");
#nullable restore
#line 66 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Comment\Index.cshtml"
Write(Html.PagedListPager(Model,
    page => Url.Action("Index", new { page }),
    new PagedListRenderOptions {
    DisplayLinkToIndividualPages = true,
    DisplayPageCountAndCurrentLocation = false,
    MaximumPageNumbersToDisplay = 10,
    LiElementClasses = new string[] { "page-item" },
    PageClasses = new string[] { "page-link" },
    }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<Comment>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
