#pragma checksum "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Notification\AllowNotification.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1a3074a9db785e01ff0fc022ce1027e0489f52e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Notification_AllowNotification), @"mvc.1.0.view", @"/Views/Notification/AllowNotification.cshtml")]
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
#line 1 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Notification\AllowNotification.cshtml"
using EntitylayerCore.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1a3074a9db785e01ff0fc022ce1027e0489f52e", @"/Views/Notification/AllowNotification.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f611d8a26e9ddd131eab235047e43c94299cee7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Notification_AllowNotification : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Notification>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Notification\AllowNotification.cshtml"
  
    ViewData["Title"] = "AllowNotification";
    Layout = "~/Views/Shared/_MemberLayout.cshtml";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table Basic form elements\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Başlıq</th>\r\n        <th>Hazırlanma Vaxdı</th>\r\n");
            WriteLiteral("    </tr>\r\n");
#nullable restore
#line 19 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Notification\AllowNotification.cshtml"
     foreach (var item in Model)
    {
        count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Notification\AllowNotification.cshtml"
           Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Notification\AllowNotification.cshtml"
           Write(item.NotificationDetails);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Notification\AllowNotification.cshtml"
            Write(((DateTime)item.NotificationDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n         \r\n");
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 31 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Notification\AllowNotification.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
