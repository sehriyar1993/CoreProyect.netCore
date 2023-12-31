#pragma checksum "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Client\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19f9f79efc2b240ea2c03d11a4b9f95a4532f7ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Client_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Client/Index.cshtml")]
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
#line 1 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Client\Index.cshtml"
using EntitylayerCore.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Client\Index.cshtml"
using X.PagedList.Mvc.Core.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Client\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Client\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19f9f79efc2b240ea2c03d11a4b9f95a4532f7ca", @"/Areas/Admin/Views/Client/Index.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Client_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<AppUser>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Client\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral(@"                <div class=""ibox-content"">
                    <h2>İstifadəçilər</h2>

                    <div class=""input-group"">
                        <input type=""text"" placeholder=""İstifadəçi axtar "" class=""input form-control"">
                        <span class=""input-group-append"">
                            <button type=""button"" class=""btn btn btn-primary""> <i class=""fa fa-search""></i> Axtar</button>
                        </span>
                    </div>
                    <div class=""clients-list"">

                        <div class=""tab-content"">
                            <div id=""tab-1"" class=""tab-pane active"">
                                <div class=""full-height-scroll"">
                                    <div class=""table-responsive"">
                                        <table class=""table table-striped table-hover"">
                                            <tbody>
");
#nullable restore
#line 34 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Client\Index.cshtml"
                                                 foreach (var x in Model)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr>\r\n                                                        <td class=\"client-avatar\"><img alt=\"image\"");
            BeginWriteAttribute("src", " src=\"", 1617, "\"", 1634, 1);
#nullable restore
#line 37 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Client\Index.cshtml"
WriteAttributeValue("", 1623, x.ImageUrl, 1623, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:20px; height:20px;\"> </td>\r\n                                                        <td><a");
            BeginWriteAttribute("href", " href=\"", 1739, "\"", 1772, 2);
            WriteAttributeValue("", 1746, "/Admin/Client/Detail/", 1746, 21, true);
#nullable restore
#line 38 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Client\Index.cshtml"
WriteAttributeValue("", 1767, x.Id, 1767, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"client-link\">");
#nullable restore
#line 38 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Client\Index.cshtml"
                                                                                                                Write(x.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 38 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Client\Index.cshtml"
                                                                                                                         Write(x.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                                        <td> ");
#nullable restore
#line 39 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Client\Index.cshtml"
                                                        Write(x.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td class=\"contact-type\"><i class=\"fa fa-envelope\"> </i></td>\r\n                                                        <td> ");
#nullable restore
#line 41 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Client\Index.cshtml"
                                                        Write(x.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 42 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Client\Index.cshtml"
                                         if (x.About != null) 
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td class=\"client-status\"><span class=\"label label-primary\">");
#nullable restore
#line 44 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Client\Index.cshtml"
                                                                                               Write(x.About.Substring(0,Math.Min(x.About.Length,30)));

#line default
#line hidden
#nullable disable
            WriteLiteral("...</span></td>\r\n");
#nullable restore
#line 45 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Client\Index.cshtml"
                                        }
                                        else 
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td class=\"client-status\"><span class=\"label label-primary\">Məlumat yoxdur.</span></td>\r\n");
#nullable restore
#line 49 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Client\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <td>\r\n                                                            <a");
            BeginWriteAttribute("href", " href=\"", 2999, "\"", 3032, 2);
            WriteAttributeValue("", 3006, "/Admin/Client/Delete/", 3006, 21, true);
#nullable restore
#line 52 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Client\Index.cshtml"
WriteAttributeValue("", 3027, x.Id, 3027, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a>\r\n\r\n                                                        </td>\r\n                                                    </tr>\r\n");
#nullable restore
#line 56 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Client\Index.cshtml"

                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>
                        </div>

                    </div>
    ");
#nullable restore
#line 67 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Client\Index.cshtml"
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
            WriteLiteral("\r\n                </div>\r\n");
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<AppUser>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
