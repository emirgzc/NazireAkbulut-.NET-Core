#pragma checksum "C:\Users\emirgzc\source\repos\NazireAkbulut-Core5\NazireAkbulut-Core5\Views\AnaLayoutPartial\_SearchPopUpPartial.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "705698bb3128fe039dcb6a53ec23b36cf4ce2f5d74d46be9ffc5a3e613a257cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AnaLayoutPartial__SearchPopUpPartial), @"mvc.1.0.view", @"/Views/AnaLayoutPartial/_SearchPopUpPartial.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\emirgzc\source\repos\NazireAkbulut-Core5\NazireAkbulut-Core5\Views\_ViewImports.cshtml"
using NazireAkbulut_Core5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\emirgzc\source\repos\NazireAkbulut-Core5\NazireAkbulut-Core5\Views\_ViewImports.cshtml"
using NazireAkbulut_Core5.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\emirgzc\source\repos\NazireAkbulut-Core5\NazireAkbulut-Core5\Views\_ViewImports.cshtml"
using NazireAkbulut_Core5.Models.About;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\emirgzc\source\repos\NazireAkbulut-Core5\NazireAkbulut-Core5\Views\_ViewImports.cshtml"
using NazireAkbulut_Core5.Models.MyWrite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\emirgzc\source\repos\NazireAkbulut-Core5\NazireAkbulut-Core5\Views\_ViewImports.cshtml"
using NazireAkbulut_Core5.Models.Writer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\emirgzc\source\repos\NazireAkbulut-Core5\NazireAkbulut-Core5\Views\_ViewImports.cshtml"
using NazireAkbulut_Core5.Models.FileNazire;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\emirgzc\source\repos\NazireAkbulut-Core5\NazireAkbulut-Core5\Views\_ViewImports.cshtml"
using NazireAkbulut_Core5.Models.AppUser;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\emirgzc\source\repos\NazireAkbulut-Core5\NazireAkbulut-Core5\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"705698bb3128fe039dcb6a53ec23b36cf4ce2f5d74d46be9ffc5a3e613a257cc", @"/Views/AnaLayoutPartial/_SearchPopUpPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"e417b237546a8144152d68379423c914745ef4b5e18a8c34d07680cf979fc285", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_AnaLayoutPartial__SearchPopUpPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex search-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<div class=""search-popup"">
	<!-- close button -->
	<button type=""button"" class=""btn-close"" aria-label=""Close""></button>
	<!-- content -->
	<div class=""search-content"">
		<div class=""text-center"">
			<h3 class=""mb-4 mt-0"">Kapatmak için X butonuna basınız</h3>
		</div>
		<!-- form -->
		");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "705698bb3128fe039dcb6a53ec23b36cf4ce2f5d74d46be9ffc5a3e613a257cc5549", async() => {
                WriteLiteral("\r\n\t\t\t<input class=\"form-control me-2\" type=\"search\" placeholder=\"Aramak istediğiniz kelimeyi giriniz ...\" aria-label=\"Search\">\r\n\t\t\t<button class=\"btn btn-default btn-lg\" type=\"submit\"><i class=\"icon-magnifier\"></i></button>\r\n\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t</div>\r\n</div>");
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
