#pragma checksum "C:\Users\emirgzc\source\repos\NazireAkbulut-Core5\NazireAkbulut-Core5\Views\About\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "597f413d1baa6176dd56233af56844e7d368387df05ae316a9d636e46fc68211"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"597f413d1baa6176dd56233af56844e7d368387df05ae316a9d636e46fc68211", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"e417b237546a8144152d68379423c914745ef4b5e18a8c34d07680cf979fc285", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<About>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\emirgzc\source\repos\NazireAkbulut-Core5\NazireAkbulut-Core5\Views\About\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AnaLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"main-content\">\r\n\t<div class=\"container-xl\">\r\n\r\n\t\t<div class=\"row gy-4\">\r\n\r\n\t\t\t<div class=\"col-lg-8\">\r\n\r\n\t\t\t\t<div class=\"page-content bordered rounded padding-30\">\r\n\r\n");
#nullable restore
#line 19 "C:\Users\emirgzc\source\repos\NazireAkbulut-Core5\NazireAkbulut-Core5\Views\About\Index.cshtml"
      foreach (var item in Model)
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 353, "\"", 375, 1);
#nullable restore
#line 21 "C:\Users\emirgzc\source\repos\NazireAkbulut-Core5\NazireAkbulut-Core5\Views\About\Index.cshtml"
WriteAttributeValue("", 359, item.AboutImage, 359, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Nazire Akbulut\" class=\"rounded mb-4\" style=\"object-fit:cover; width:-webkit-fill-available; height:450px;\" />\r\n");
            WriteLiteral("\t\t\t\t\t\t<h3 class=\"title mt-0 mb-3\">");
#nullable restore
#line 23 "C:\Users\emirgzc\source\repos\NazireAkbulut-Core5\NazireAkbulut-Core5\Views\About\Index.cshtml"
                             Write(item.AboutTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
            WriteLiteral("\t\t\t\t\t\t<p>");
#nullable restore
#line 25 "C:\Users\emirgzc\source\repos\NazireAkbulut-Core5\NazireAkbulut-Core5\Views\About\Index.cshtml"
    Write(Html.Raw(item.AboutDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 26 "C:\Users\emirgzc\source\repos\NazireAkbulut-Core5\NazireAkbulut-Core5\Views\About\Index.cshtml"
					}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t<hr class=\"my-4\" />\r\n\r\n\t\t\t\t\t");
#nullable restore
#line 30 "C:\Users\emirgzc\source\repos\NazireAkbulut-Core5\NazireAkbulut-Core5\Views\About\Index.cshtml"
Write(await Component.InvokeAsync("SocialMediaListForPublic"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\t\t\t\t</div>\t\t\t\t\r\n\r\n\t\t\t</div>\r\n\t\t\t\r\n\t\t\t<div class=\"col-lg-4\">\r\n\r\n\t\t\t\t<!-- sidebar -->\r\n\t\t\t\t<div class=\"sidebar\">\r\n\t\t\t\t\t<!-- widget about -->\r\n\t\t\t\t\t");
#nullable restore
#line 41 "C:\Users\emirgzc\source\repos\NazireAkbulut-Core5\NazireAkbulut-Core5\Views\About\Index.cshtml"
Write(await Component.InvokeAsync("SocialMediaWithAboutInHome"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\t\t\t\t\t<!-- widget popular posts -->\r\n\t\t\t\t\t");
#nullable restore
#line 44 "C:\Users\emirgzc\source\repos\NazireAkbulut-Core5\NazireAkbulut-Core5\Views\About\Index.cshtml"
Write(await Component.InvokeAsync("MyWriteLastPostRightBar"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\t\t\t\t\t<!-- widget categories -->\r\n\t\t\t\t\t");
#nullable restore
#line 47 "C:\Users\emirgzc\source\repos\NazireAkbulut-Core5\NazireAkbulut-Core5\Views\About\Index.cshtml"
Write(await Component.InvokeAsync("CategoriListForHomeRightBar"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\t\t\t\t</div>\r\n\r\n\t\t\t</div>\r\n\r\n\t\t</div>\r\n\r\n\t</div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<About>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
