#pragma checksum "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Shared\Partial3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9676434c1b93cf95375d49f3dadf78cea0102cbb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Partial3), @"mvc.1.0.view", @"/Views/Shared/Partial3.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9676434c1b93cf95375d49f3dadf78cea0102cbb", @"/Views/Shared/Partial3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f611d8a26e9ddd131eab235047e43c94299cee7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Partial3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Newletter/SubscribeMail/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<footer>
	<div class=""container"">
		<div class=""row"">
			<div class=""col-lg-4 footer-grid-agileits-w3ls text-left"">
				<h3>Haqqımızda</h3>
				<p>
					Bloq, əsasən yenidən köhnəyə doğru sıralanmış yazıların və şərhlərin yayımlandığı bir saytdır. Demək olar ki, bloq saytlarındakı şərhlər həmin bloqun əsas hərəkətverici qüvvəsidir. Şərhlərin sayəsində bloq müəllifi ilə oxucular arasında rabitə yaranır. Zaman keçdikcə bloqlarda yazılardan əlavə video....
				</p>
				<div class=""read"">
					<a href=""/About/Index/"" class=""btn btn-primary read-m"">Davamını Oxu</a>
				</div>
			</div>
			<div class=""col-lg-4 footer-grid-agileits-w3ls text-left"">

				<div class=""tech-btm"">
					
					");
#nullable restore
#line 17 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Shared\Partial3.cshtml"
               Write(await Component.InvokeAsync("BlogLast3"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

				</div>
			</div>
			<!-- subscribe -->
			<div class=""col-lg-4 subscribe-main footer-grid-agileits-w3ls text-left"">
				<p>Mail Adresinizlə Abunə olun</p>
				<div class=""subscribe-main text-left"">
					<div class=""tech-btm"">
						<h4>Yeniliklərdən Xəbarda ol</h4>
						");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9676434c1b93cf95375d49f3dadf78cea0102cbb5214", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t<input type=\"email\" placeholder=\"Email\" name=\"Mail\"");
                BeginWriteAttribute("required", " required=\"", 1149, "\"", 1160, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t\t\t\t\t<input type=\"submit\" value=\"Abunə Olun\">\r\n\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

					</div>
					<p>Spam Mesajlar göndərilmir!</p>
				</div>
				<!-- //subscribe -->
			</div>
		</div>
		<!-- footer -->
		<div class=""footer-cpy text-center"">
			<div class=""footer-social"">
				<div class=""copyrighttop"">
					<ul>
						<li class=""mx-3"">
							<a class=""facebook"" href=""#"">
								<i class=""fab fa-facebook-f""></i>
								<span>Facebook</span>
							</a>
						</li>
						<li>
							<a class=""facebook"" href=""#"">
								<i class=""fab fa-twitter""></i>
								<span>Twitter</span>
							</a>
						</li>
						<li class=""mx-3"">
							<a class=""facebook"" href=""#"">
								<i class=""fab fa-google-plus-g""></i>
								<span>Google+</span>
							</a>
						</li>
						<li>
							<a class=""facebook"" href=""#"">
								<i class=""fab fa-pinterest-p""></i>
								<span>Pinterest</span>
							</a>
						</li>
					</ul>

				</div>
			</div>
			<div class=""w3layouts-agile-copyrightbottom"">
				<p>
					© ");
#nullable restore
#line 73 "C:\Users\Hp Pavilion Gaming\source\repos\BlogProject\Views\Shared\Partial3.cshtml"
                 Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Bütün haqqlar qorunur | Design by Şəhriyar Hacıyev\r\n\t\t\t\t</p>\r\n\r\n\t\t\t</div>\r\n\t\t</div>\r\n\r\n\t\t<!-- //footer -->\r\n\r\n\r\n\t</div>\r\n</footer>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
