#pragma checksum "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Message\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce0808f12ae02e5a22130dfdedb4aaebeb22d570"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Message_Add), @"mvc.1.0.view", @"/Areas/Admin/Views/Message/Add.cshtml")]
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
#line 1 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Message\Add.cshtml"
using EntitylayerCore.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce0808f12ae02e5a22130dfdedb4aaebeb22d570", @"/Areas/Admin/Views/Message/Add.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Message_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MessageTwo>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Message\Add.cshtml"
  
    ViewData["Title"] = "Add";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""wrapper wrapper-content"">
    <div class=""row"">
        <div class=""col-lg-3"">
            <div class=""ibox "">
                <div class=""ibox-content mailbox-content"">
                    <div class=""file-manager"">
                        <a class=""btn btn-block btn-primary compose-mail"" href=""mail_compose.html"">Mesaj Göndər</a>
                        <div class=""space-25""></div>
                        <h5>Mesalar</h5>
                        <ul class=""folder-list m-b-md"" style=""padding: 0"">
                            <li><a href=""/Admin/Message/Index/""> <i class=""fa fa-inbox ""></i> İnbox <span class=""label label-warning float-right"">16</span> </a></li>
                            <li><a href=""/Admin/Message/Add/""> <i class=""fa fa-envelope-o""></i> Mesaj Göndər</a></li>
                            <li><a href=""/Admin/Message/MailSend""> <i class=""fa fa-certificate""></i>Gmail İlə Göndər</a></li>
                            <li><a href=""/Admin/Message/Send/""> <i class=""fa fa-file-");
            WriteLiteral(@"text-o""></i> Göndərilən Mesajlar <span class=""label label-danger float-right"">2</span></a></li>
                            <li><a href=""mailbox.html""> <i class=""fa fa-trash-o""></i> Silinənlər</a></li>
                        </ul>
                        <h5>Kateqoriyalar</h5>
                        <ul class=""category-list"" style=""padding: 0"">
                            <li><a href=""#""> <i class=""fa fa-circle text-navy""></i> Biznes </a></li>
                            <li><a href=""#""> <i class=""fa fa-circle text-danger""></i> İdarəetmə</a></li>
                            <li><a href=""#""> <i class=""fa fa-circle text-primary""></i> Sosial</a></li>
                            <li><a href=""#""> <i class=""fa fa-circle text-info""></i> Əyləncə</a></li>
                            <li><a href=""#""> <i class=""fa fa-circle text-warning""></i> Müştərilər</a></li>
                        </ul>
                        <h5 class=""tag-title"">Heştəq</h5>
                        <ul class=""tag-list"" style=""paddin");
            WriteLiteral("g: 0\">\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 2234, "\"", 2241, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-tag\"></i> Ailə</a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 2318, "\"", 2325, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-tag\"></i> İş</a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 2400, "\"", 2407, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-tag\"></i> Ev</a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 2482, "\"", 2489, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-tag\"></i> Əylənə</a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 2568, "\"", 2575, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-tag\"></i> BAyramlar</a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 2657, "\"", 2664, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-tag\"></i> Musiqi</a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 2743, "\"", 2750, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-tag\"></i> Şəkillər</a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 2831, "\"", 2838, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fa fa-tag""></i> Film</a></li>
                        </ul>
                        <div class=""clearfix""></div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-lg-9 animated fadeInRight"">
            <div class=""mail-box-header"">
                <div class=""float-right tooltip-demo"">
                    <a href=""mailbox.html"" class=""btn btn-white btn-sm"" data-toggle=""tooltip"" data-placement=""top"" title=""sil""><i class=""fa fa-pencil""></i> Sil</a>
                    <a href=""mailbox.html"" class=""btn btn-danger btn-sm"" data-toggle=""tooltip"" data-placement=""top"" title=""ləğv et""><i class=""fa fa-times""></i> Ləğv et</a>
                </div>
                <h2>
                    Mesaj Göndər
                </h2>
            </div>
            <div class=""mail-box"">


                <div class=""mail-body"">

                    <form method=""post""  >
                        <label for=""validationCustom01"">Başlıq</label");
            WriteLiteral(">\r\n                        ");
#nullable restore
#line 65 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Message\Add.cshtml"
                   Write(Html.TextBoxFor(x=>x.Subject, new {@class ="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        <br />\r\n                        <label for=\"exampleInputPassword1 mb-2\">Göndəriləcək İstifadəşi</label>\r\n                        ");
#nullable restore
#line 69 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Message\Add.cshtml"
                   Write(Html.DropDownListFor(x=>x.ReceiverID,(IEnumerable<SelectListItem>)ViewBag.vappuse,new {@class="form-control"} ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        <br />\r\n                        <label for=\"validationCustom02\">Mesajınız</label>\r\n                        ");
#nullable restore
#line 73 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Message\Add.cshtml"
                   Write(Html.TextAreaFor(x=>x.MessageDetail, 10, 2,   new { @class ="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        <br />
                        <br />
                        <button type=""submit"" id=""btn1"" class=""btn btn-primary submit mb-4"">Təsdiqlə</button>

                    </form>

                </div>

                <div class=""mail-text h-200"">

                    <div class=""summernote"">
                        ");
#nullable restore
#line 85 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Areas\Admin\Views\Message\Add.cshtml"
                   Write(await Component.InvokeAsync("WriterAboutOndashboard"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


                    </div>
                    <div class=""clearfix""></div>
                </div>
                <div class=""mail-body text-right tooltip-demo"">
                    <a class=""btn btn-sm btn-white"" href=""mail_compose.html""><i class=""fa fa-reply""></i> Cavabla</a>
                    <a class=""btn btn-sm btn-white"" href=""mail_compose.html""><i class=""fa fa-arrow-right""></i> Başqasına Göndər</a>
                    <button");
            BeginWriteAttribute("title", " title=\"", 5291, "\"", 5299, 0);
            EndWriteAttribute();
            WriteLiteral(" data-placement=\"top\" data-toggle=\"tooltip\" type=\"button\" data-original-title=\"Print\" class=\"btn btn-sm btn-white\"><i class=\"fa fa-print\"></i> Çap et</button>\r\n                    <button");
            BeginWriteAttribute("title", " title=\"", 5487, "\"", 5495, 0);
            EndWriteAttribute();
            WriteLiteral(@" data-placement=""top"" data-toggle=""tooltip"" data-original-title=""Trash"" class=""btn btn-sm btn-white""><i class=""fa fa-trash-o""></i> Sil</button>
                </div>
                <div class=""clearfix""></div>



            </div>
        </div>
    </div>
</div>

<script>
    $('#btn1').click(function () {
        Swal.fire('Mesajınız göndərildi');
    });
</script>
<script src=""
https://cdn.jsdelivr.net/npm/sweetalert2@11.7.11/dist/sweetalert2.all.min.js
""></script>
<link href=""
https://cdn.jsdelivr.net/npm/sweetalert2@11.7.11/dist/sweetalert2.min.css
"" rel=""stylesheet"">
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MessageTwo> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
