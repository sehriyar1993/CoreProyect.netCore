#pragma checksum "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Shared\Components\WriterNotification\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62ffd1487bce2821b11e291b742a3d61db398e0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_WriterNotification_Default), @"mvc.1.0.view", @"/Views/Shared/Components/WriterNotification/Default.cshtml")]
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
#line 1 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Shared\Components\WriterNotification\Default.cshtml"
using EntitylayerCore.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62ffd1487bce2821b11e291b742a3d61db398e0c", @"/Views/Shared/Components/WriterNotification/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f611d8a26e9ddd131eab235047e43c94299cee7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_WriterNotification_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Notification>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<li class=""nav-item dropdown"">
    <a class=""nav-link count-indicator dropdown-toggle"" id=""notificationDropdown"" href=""#"" data-toggle=""dropdown"">
        <i class=""mdi mdi-bell-outline""></i>
        <span class=""count-symbol bg-danger""></span>
    </a>
    <div class=""dropdown-menu dropdown-menu-right navbar-dropdown preview-list"" aria-labelledby=""notificationDropdown"">
        <h6 class=""p-3 mb-0"">Bildirimlər</h6>
");
#nullable restore
#line 10 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Shared\Components\WriterNotification\Default.cshtml"
         foreach(var item in Model.Where(x=>x.NotificationStatus == true).OrderByDescending(x=>x.NotificationID).Take(5))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""dropdown-divider""></div>
            <a class=""dropdown-item preview-item"">
                <div class=""preview-thumbnail"">
                    <div class=""preview-icon bg-@*@item.NotificationColor*@"">
                        <i");
            BeginWriteAttribute("class", " class=\"", 877, "\"", 917, 3);
            WriteAttributeValue("", 885, "mdi", 885, 3, true);
            WriteAttributeValue(" ", 888, "mdi-", 889, 5, true);
#nullable restore
#line 16 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Shared\Components\WriterNotification\Default.cshtml"
WriteAttributeValue("", 893, item.NotificationSembol, 893, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                    </div>\r\n                </div>\r\n                <div class=\"preview-item-content d-flex align-items-start flex-column justify-content-center\">\r\n                    <h6 class=\"preview-subject font-weight-normal mb-1\">");
#nullable restore
#line 20 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Shared\Components\WriterNotification\Default.cshtml"
                                                                   Write(item.NotificationType);

#line default
#line hidden
#nullable disable
            WriteLiteral(":  ");
#nullable restore
#line 20 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Shared\Components\WriterNotification\Default.cshtml"
                                                                                             Write(((DateTime)item.NotificationDate).ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                    <p class=\"text-gray ellipsis mb-0\"> ");
#nullable restore
#line 21 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Shared\Components\WriterNotification\Default.cshtml"
                                                   Write(item.NotificationDetails);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                </div>\r\n            </a>\r\n");
#nullable restore
#line 24 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Shared\Components\WriterNotification\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("      \r\n        <h6 class=\"p-3 mb-0 text-center\">Bütün Bildirimlərə Bax</h6>\r\n    </div>\r\n</li>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Notification>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
