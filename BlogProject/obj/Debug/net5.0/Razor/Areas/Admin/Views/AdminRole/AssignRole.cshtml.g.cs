#pragma checksum "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\AdminRole\AssignRole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3679efad543ede840a5c9ef4e363add13531cc9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminRole_AssignRole), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminRole/AssignRole.cshtml")]
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
#line 1 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\AdminRole\AssignRole.cshtml"
using BlogProject.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3679efad543ede840a5c9ef4e363add13531cc9", @"/Areas/Admin/Views/AdminRole/AssignRole.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_AdminRole_AssignRole : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<RoleAssignViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\AdminRole\AssignRole.cshtml"
  
    ViewData["Title"] = "AssignRole";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Rol ver</h1>\r\n\r\n<form method=\"post\">\r\n");
#nullable restore
#line 12 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\AdminRole\AssignRole.cshtml"
     for (int i = 0; i < Model.Count; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-check\">\r\n            ");
#nullable restore
#line 15 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\AdminRole\AssignRole.cshtml"
       Write(Html.HiddenFor(x=>x[i].RoleId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 16 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\AdminRole\AssignRole.cshtml"
       Write(Html.HiddenFor(x=>x[i].RoleName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 17 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\AdminRole\AssignRole.cshtml"
       Write(Html.CheckBoxFor(m => m[i].RoleExist, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            <label class=\"form-check-label\"");
            BeginWriteAttribute("for", " for=\"", 525, "\"", 550, 1);
#nullable restore
#line 19 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\AdminRole\AssignRole.cshtml"
WriteAttributeValue("", 531, Model[i].RoleExist, 531, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 19 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\AdminRole\AssignRole.cshtml"
                                                                 Write(Model[i].RoleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 28 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\AdminRole\AssignRole.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button class=\"btn btn-outline-primary\">Dəyişiklikləri yüklə</button>\r\n</form>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<RoleAssignViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591