#pragma checksum "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Writer\SendMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf79cf90d61cbf187725d3814fa5d593f41e2afb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Writer_SendMessage), @"mvc.1.0.view", @"/Views/Writer/SendMessage.cshtml")]
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
#line 1 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Writer\SendMessage.cshtml"
using EntitylayerCore.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf79cf90d61cbf187725d3814fa5d593f41e2afb", @"/Views/Writer/SendMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f611d8a26e9ddd131eab235047e43c94299cee7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Writer_SendMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MessageTwo>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Writer\SendMessage.cshtml"
  
    ViewData["Title"] = "SendMessage";
    Layout = "~/Views/Shared/_MemberLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-12 grid-margin"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Göndərdiyim Mesajlar</h4>
                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th>#</th>
                                <th>Qəbul Edən</th>
                                <th>Başlıq</th>
");
            WriteLiteral("                                <th>Tarix</th>\r\n                                <th>Saytda Bax</th>\r\n\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 28 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Writer\SendMessage.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 32 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Writer\SendMessage.cshtml"
                                   Write(item.MessageId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 1330, "\"", 1366, 1);
#nullable restore
#line 35 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Writer\SendMessage.cshtml"
WriteAttributeValue("", 1336, item.RecieverAppUser.ImageUrl, 1336, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"mr-2\" alt=\"image\"> ");
#nullable restore
#line 35 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Writer\SendMessage.cshtml"
                                                                                                       Write(item.RecieverAppUser.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n\r\n");
            WriteLiteral("                                    <td> <label class=\"badge badge-gradient-success\">");
#nullable restore
#line 39 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Writer\SendMessage.cshtml"
                                                                                Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>  </td>\r\n\r\n                                    <td> ");
#nullable restore
#line 41 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Writer\SendMessage.cshtml"
                                     Write(((DateTime)item.MessageDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 1838, "\"", 1882, 2);
            WriteAttributeValue("", 1845, "/Writer/MessageDetail/", 1845, 22, true);
#nullable restore
#line 43 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Writer\SendMessage.cshtml"
WriteAttributeValue("", 1867, item.MessageId, 1867, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">Ətraflı</a>\r\n\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 47 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Writer\SendMessage.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                    </table>
                    <a href=""/Writer/AddMessage/"" class=""btn btn-outline-success"">Yeni Mesaj </a>
                    <a href=""/Writer/WriterMessage/"" class=""btn btn-outline-success"">Gələnlər </a>

                </div>
            </div>
        </div>
    </div>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MessageTwo>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
