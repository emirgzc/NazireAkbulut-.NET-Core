#pragma checksum "C:\Users\emirgzc\source\repos\NazireAkbulut-Core5\NazireAkbulut-Core5\Views\Comment\AdCommentListForMyWrite.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "b5c9f8ab0bab8a6df02db2309b1ab91428909b473854c6f73f850169f2c2d8cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comment_AdCommentListForMyWrite), @"mvc.1.0.view", @"/Views/Comment/AdCommentListForMyWrite.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"b5c9f8ab0bab8a6df02db2309b1ab91428909b473854c6f73f850169f2c2d8cf", @"/Views/Comment/AdCommentListForMyWrite.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"e417b237546a8144152d68379423c914745ef4b5e18a8c34d07680cf979fc285", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Comment_AdCommentListForMyWrite : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Comment>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\emirgzc\source\repos\NazireAkbulut-Core5\NazireAkbulut-Core5\Views\Comment\AdCommentListForMyWrite.cshtml"
  
    ViewData["Title"] = "AdCommentListForMyWrite";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    int sayac = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-12"">
    <div class=""card"">
        <div class=""card-body"">
            <div class=""card-title"">
                <h4>Yorumlar</h4>
            </div>
            <div class=""table-responsive"">
                <table class=""table table-bordered"">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Ad Soyad</th>
                            <th>Tarih</th>
                            <th>Mail Adresi</th>
                            <th>Yazı</th>
                            <th>Yorum</th>
                            <th>Yorum Durumu</th>
                            <th>İşlem</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 30 "C:\Users\emirgzc\source\repos\NazireAkbulut-Core5\NazireAkbulut-Core5\Views\Comment\AdCommentListForMyWrite.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <th>");
#nullable restore
#line 33 "C:\Users\emirgzc\source\repos\NazireAkbulut-Core5\NazireAkbulut-Core5\Views\Comment\AdCommentListForMyWrite.cshtml"
                               Write(sayac);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <td>");
#nullable restore
#line 34 "C:\Users\emirgzc\source\repos\NazireAkbulut-Core5\NazireAkbulut-Core5\Views\Comment\AdCommentListForMyWrite.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 34 "C:\Users\emirgzc\source\repos\NazireAkbulut-Core5\NazireAkbulut-Core5\Views\Comment\AdCommentListForMyWrite.cshtml"
                                          Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 35 "C:\Users\emirgzc\source\repos\NazireAkbulut-Core5\NazireAkbulut-Core5\Views\Comment\AdCommentListForMyWrite.cshtml"
                                Write(((DateTime)item.CommentDate).ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 36 "C:\Users\emirgzc\source\repos\NazireAkbulut-Core5\NazireAkbulut-Core5\Views\Comment\AdCommentListForMyWrite.cshtml"
                               Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 37 "C:\Users\emirgzc\source\repos\NazireAkbulut-Core5\NazireAkbulut-Core5\Views\Comment\AdCommentListForMyWrite.cshtml"
                               Write(item.MyWrite.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 38 "C:\Users\emirgzc\source\repos\NazireAkbulut-Core5\NazireAkbulut-Core5\Views\Comment\AdCommentListForMyWrite.cshtml"
                               Write(item.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n");
#nullable restore
#line 40 "C:\Users\emirgzc\source\repos\NazireAkbulut-Core5\NazireAkbulut-Core5\Views\Comment\AdCommentListForMyWrite.cshtml"
                                     if (item.Status)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"text-success\">Yayında</span>\r\n");
#nullable restore
#line 43 "C:\Users\emirgzc\source\repos\NazireAkbulut-Core5\NazireAkbulut-Core5\Views\Comment\AdCommentListForMyWrite.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"text-danger\">Pasif</span>\r\n");
#nullable restore
#line 47 "C:\Users\emirgzc\source\repos\NazireAkbulut-Core5\NazireAkbulut-Core5\Views\Comment\AdCommentListForMyWrite.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n                                <td>\r\n");
#nullable restore
#line 50 "C:\Users\emirgzc\source\repos\NazireAkbulut-Core5\NazireAkbulut-Core5\Views\Comment\AdCommentListForMyWrite.cshtml"
                                     if (item.Status)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a");
            BeginWriteAttribute("href", " href=\"", 2111, "\"", 2159, 2);
            WriteAttributeValue("", 2118, "/Comment/AdCommentDoFalse/", 2118, 26, true);
#nullable restore
#line 52 "C:\Users\emirgzc\source\repos\NazireAkbulut-Core5\NazireAkbulut-Core5\Views\Comment\AdCommentListForMyWrite.cshtml"
WriteAttributeValue("", 2144, item.CommentId, 2144, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Yorumu Kaldır</a>\r\n");
#nullable restore
#line 53 "C:\Users\emirgzc\source\repos\NazireAkbulut-Core5\NazireAkbulut-Core5\Views\Comment\AdCommentListForMyWrite.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a");
            BeginWriteAttribute("href", " href=\"", 2365, "\"", 2412, 2);
            WriteAttributeValue("", 2372, "/Comment/AdCommentDoTrue/", 2372, 25, true);
#nullable restore
#line 56 "C:\Users\emirgzc\source\repos\NazireAkbulut-Core5\NazireAkbulut-Core5\Views\Comment\AdCommentListForMyWrite.cshtml"
WriteAttributeValue("", 2397, item.CommentId, 2397, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Yorumu Yayınla</a>\r\n");
#nullable restore
#line 57 "C:\Users\emirgzc\source\repos\NazireAkbulut-Core5\NazireAkbulut-Core5\Views\Comment\AdCommentListForMyWrite.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 60 "C:\Users\emirgzc\source\repos\NazireAkbulut-Core5\NazireAkbulut-Core5\Views\Comment\AdCommentListForMyWrite.cshtml"
                            sayac++;
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
