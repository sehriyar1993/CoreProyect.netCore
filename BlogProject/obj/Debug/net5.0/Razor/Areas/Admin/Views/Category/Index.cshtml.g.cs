#pragma checksum "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d1c7cb9dcc6cbfe0e4f90e617ec3139d4611eeb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/Index.cshtml")]
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
#line 1 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Category\Index.cshtml"
using EntitylayerCore.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Category\Index.cshtml"
using X.PagedList.Mvc.Core.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Category\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Category\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d1c7cb9dcc6cbfe0e4f90e617ec3139d4611eeb", @"/Areas/Admin/Views/Category/Index.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<Category>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row wrapper border-bottom white-bg page-heading"">
    <div class=""col-lg-9"">
        <h2>Kateqoriyalar</h2>
        <ol class=""breadcrumb"">
            <li class=""breadcrumb-item"">
                <a href=""index.html"">Ana Səhifə</a>
            </li>
            <li class=""breadcrumb-item"">
                İdarəetmə
            </li>
            <li class=""breadcrumb-item active"">
                <strong>Kateqoriyalar</strong>
            </li>
        </ol>
    </div>
</div>
<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""wrapper wrapper-content animated fadeInUp"">
            <ul class=""notes"">
");
#nullable restore
#line 31 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Category\Index.cshtml"
                 foreach(var x in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>\r\n                        <div>\r\n                            <small>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1087, "\"", 1138, 2);
            WriteAttributeValue("", 1094, "/Admin/Category/CateqoryUpdate/", 1094, 31, true);
#nullable restore
#line 36 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Category\Index.cshtml"
WriteAttributeValue("", 1125, x.CategoryID, 1125, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"fa fa-retweet\">Yenilə</a>\r\n                            </small>\r\n                            <small> Statusu:");
#nullable restore
#line 38 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Category\Index.cshtml"
                                       Write(x.CategoryStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                            <h4>");
#nullable restore
#line 39 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Category\Index.cshtml"
                           Write(x.CategoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral(" -> ");
#nullable restore
#line 39 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Category\Index.cshtml"
                                            Write(x.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            <p>");
#nullable restore
#line 40 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Category\Index.cshtml"
                          Write(x.CategoryDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 41 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Category\Index.cshtml"
                              
                                if (x.CategoryStatus == true)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a");
            BeginWriteAttribute("href", " href=\"", 1581, "\"", 1631, 2);
            WriteAttributeValue("", 1588, "/Admin/Category/ChangeToFalse/", 1588, 30, true);
#nullable restore
#line 44 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Category\Index.cshtml"
WriteAttributeValue("", 1618, x.CategoryID, 1618, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-power-off \"> Passiv et</i></a>\r\n");
#nullable restore
#line 45 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Category\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a");
            BeginWriteAttribute("href", " href=\"", 1827, "\"", 1876, 2);
            WriteAttributeValue("", 1834, "/Admin/Category/ChangeToTrue/", 1834, 29, true);
#nullable restore
#line 48 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Category\Index.cshtml"
WriteAttributeValue("", 1863, x.CategoryID, 1863, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-superpowers \"> Aktiv et</i></a>\r\n");
#nullable restore
#line 49 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Category\Index.cshtml"

                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </li>\r\n");
#nullable restore
#line 55 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Category\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </div>\r\n\r\n    </div>\r\n\r\n    ");
#nullable restore
#line 62 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Category\Index.cshtml"
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
            WriteLiteral("\r\n</div>\r\n<br />\r\n<a href=\"/Admin/Category/CateqoriyaAdd\" class=\"btn btn-outline-primary\">Yeni Kateqoriya</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
