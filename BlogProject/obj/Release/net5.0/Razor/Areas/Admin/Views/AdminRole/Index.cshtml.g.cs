#pragma checksum "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\AdminRole\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0667e459d616b1d870018f7847f587d619c0925"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminRole_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminRole/Index.cshtml")]
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
#line 1 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\AdminRole\Index.cshtml"
using EntitylayerCore.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0667e459d616b1d870018f7847f587d619c0925", @"/Areas/Admin/Views/AdminRole/Index.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_AdminRole_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AppRole>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\AdminRole\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Rol Siyahısı</h1>\r\n");
#nullable restore
#line 10 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\AdminRole\Index.cshtml"
 if (Model.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-bordered\">\r\n        <tr>\r\n            <th>#</th>\r\n            <th>Rol Adı</th>\r\n            <th>Rolu Sil</th>\r\n            <th>Rolu Yenilə</th>\r\n        </tr>\r\n\r\n");
#nullable restore
#line 20 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\AdminRole\Index.cshtml"
         foreach (var item in Model)
        {
            count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\AdminRole\Index.cshtml"
               Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\AdminRole\Index.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 593, "\"", 636, 2);
            WriteAttributeValue("", 600, "/Admin/AdminRole/DeleteRole/", 600, 28, true);
#nullable restore
#line 26 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\AdminRole\Index.cshtml"
WriteAttributeValue("", 628, item.Id, 628, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\"> Sil</a></td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 706, "\"", 749, 2);
            WriteAttributeValue("", 713, "/Admin/AdminRole/UpdateRole/", 713, 28, true);
#nullable restore
#line 27 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\AdminRole\Index.cshtml"
WriteAttributeValue("", 741, item.Id, 741, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Yenilə</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 29 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\AdminRole\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n");
#nullable restore
#line 32 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\AdminRole\Index.cshtml"
}

else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\">\r\n        <span> Rol Tapılmadı</span>\r\n    </div>\r\n");
#nullable restore
#line 39 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\AdminRole\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<a href=\"/Admin/AdminRole/CreateRole/\" class=\"btn btn-outline-primary\">Yeni Rol</a>\r\n<a href=\"/Admin/AdminRole/UserList/\" class=\"btn btn-outline-primary\">Rol Ver</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AppRole>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591