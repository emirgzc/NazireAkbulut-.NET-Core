#pragma checksum "C:\Users\emirgzc\source\repos\NazireAkbulut-Core5\NazireAkbulut-Core5\Views\Shared\Components\CommentListMyWriteDetails\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "b99467a13466ce16c1abfc15a3f9368c459abb578dc60a7821bee413a057624f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CommentListMyWriteDetails_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CommentListMyWriteDetails/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"b99467a13466ce16c1abfc15a3f9368c459abb578dc60a7821bee413a057624f", @"/Views/Shared/Components/CommentListMyWriteDetails/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"e417b237546a8144152d68379423c914745ef4b5e18a8c34d07680cf979fc285", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_CommentListMyWriteDetails_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Comment>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/katen/html/images/wave.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("wave"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Nazire Akbulut"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"section-header\">\r\n\t<h3 class=\"section-title\">Yorumlar (");
#nullable restore
#line 5 "C:\Users\emirgzc\source\repos\NazireAkbulut-Core5\NazireAkbulut-Core5\Views\Shared\Components\CommentListMyWriteDetails\Default.cshtml"
                                Write(Model.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h3>\r\n\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b99467a13466ce16c1abfc15a3f9368c459abb578dc60a7821bee413a057624f6324", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n<!-- post comments -->\r\n<div class=\"comments bordered padding-30 rounded\">\r\n\t<ul class=\"comments\">\r\n\t\t<!-- comment item -->\r\n\t\t\r\n");
#nullable restore
#line 13 "C:\Users\emirgzc\source\repos\NazireAkbulut-Core5\NazireAkbulut-Core5\Views\Shared\Components\CommentListMyWriteDetails\Default.cshtml"
   if (Model.Count!=0)
		{
			

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\emirgzc\source\repos\NazireAkbulut-Core5\NazireAkbulut-Core5\Views\Shared\Components\CommentListMyWriteDetails\Default.cshtml"
    foreach (var item in Model)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<li class=\"comment rounded\">\r\n\t\t\t\t\t<div class=\"details\">\r\n\t\t\t\t\t\t<h4 class=\"name\"><a href=\"#\">");
#nullable restore
#line 19 "C:\Users\emirgzc\source\repos\NazireAkbulut-Core5\NazireAkbulut-Core5\Views\Shared\Components\CommentListMyWriteDetails\Default.cshtml"
                              Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 19 "C:\Users\emirgzc\source\repos\NazireAkbulut-Core5\NazireAkbulut-Core5\Views\Shared\Components\CommentListMyWriteDetails\Default.cshtml"
                                         Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n\t\t\t\t\t\t<span class=\"date\">\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 21 "C:\Users\emirgzc\source\repos\NazireAkbulut-Core5\NazireAkbulut-Core5\Views\Shared\Components\CommentListMyWriteDetails\Default.cshtml"
   Write(((DateTime)item.CommentDate).ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t</span>\r\n\t\t\t\t\t\t<p>");
#nullable restore
#line 23 "C:\Users\emirgzc\source\repos\NazireAkbulut-Core5\NazireAkbulut-Core5\Views\Shared\Components\CommentListMyWriteDetails\Default.cshtml"
    Write(item.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</li>\r\n");
#nullable restore
#line 26 "C:\Users\emirgzc\source\repos\NazireAkbulut-Core5\NazireAkbulut-Core5\Views\Shared\Components\CommentListMyWriteDetails\Default.cshtml"
			}

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\emirgzc\source\repos\NazireAkbulut-Core5\NazireAkbulut-Core5\Views\Shared\Components\CommentListMyWriteDetails\Default.cshtml"
    

		}
		else
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<li class=\"comment rounded\">\r\n\t\t\t\t<div class=\"details\">\r\n\t\t\t\t\t<h4 class=\"name\" style=\"color:darkgrey\">Henüz Yapılmış Yorum Yok</h4>\t\t\t\t\t\r\n\t\t\t\t</div>\r\n\t\t\t</li>\r\n");
#nullable restore
#line 36 "C:\Users\emirgzc\source\repos\NazireAkbulut-Core5\NazireAkbulut-Core5\Views\Shared\Components\CommentListMyWriteDetails\Default.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t</ul>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Comment>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
