#pragma checksum "C:\Users\Fernando\Source\Repos\aqui-ou-acola\AquiOuAcola\AquiOuAcola\Views\Home\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "757213542124aa5f8b1c1de22b593a3bc910e0bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.view", @"/Views/Home/Privacy.cshtml")]
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
#line 1 "C:\Users\Fernando\Source\Repos\aqui-ou-acola\AquiOuAcola\AquiOuAcola\Views\_ViewImports.cshtml"
using AquiOuAcola;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Fernando\Source\Repos\aqui-ou-acola\AquiOuAcola\AquiOuAcola\Views\_ViewImports.cshtml"
using AquiOuAcola.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"757213542124aa5f8b1c1de22b593a3bc910e0bb", @"/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28802c4a7a5d81586ffba99e373cb47d25076240", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AquiOuAcola.Entidades.CursoF>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Fernando\Source\Repos\aqui-ou-acola\AquiOuAcola\AquiOuAcola\Views\Home\Privacy.cshtml"
  
    ViewData["Title"] = "Privacy Policy";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 5 "C:\Users\Fernando\Source\Repos\aqui-ou-acola\AquiOuAcola\AquiOuAcola\Views\Home\Privacy.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<p>Exemplo de Uso da Tabela Relacionada.</p>\r\n\r\n\r\n");
#nullable restore
#line 10 "C:\Users\Fernando\Source\Repos\aqui-ou-acola\AquiOuAcola\AquiOuAcola\Views\Home\Privacy.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card col-3 offset-4\">\r\n        <div class=\"card-header\">");
#nullable restore
#line 13 "C:\Users\Fernando\Source\Repos\aqui-ou-acola\AquiOuAcola\AquiOuAcola\Views\Home\Privacy.cshtml"
                            Write(item.Usuario.nome);

#line default
#line hidden
#nullable disable
            WriteLiteral(" recomenda favoritou esse curso</div>\r\n        <div class=\"card-body\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 383, "\"", 406, 1);
#nullable restore
#line 15 "C:\Users\Fernando\Source\Repos\aqui-ou-acola\AquiOuAcola\AquiOuAcola\Views\Home\Privacy.cshtml"
WriteAttributeValue("", 390, item.Curso.link, 390, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 430, "\"", 452, 1);
#nullable restore
#line 16 "C:\Users\Fernando\Source\Repos\aqui-ou-acola\AquiOuAcola\AquiOuAcola\Views\Home\Privacy.cshtml"
WriteAttributeValue("", 436, item.Curso.foto, 436, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"500\" height=\"500\" />\r\n            </a>\r\n        </div>\r\n        <div class=\"card-footer\">\r\n            ");
#nullable restore
#line 20 "C:\Users\Fernando\Source\Repos\aqui-ou-acola\AquiOuAcola\AquiOuAcola\Views\Home\Privacy.cshtml"
       Write(item.Curso.nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <br />\r\n");
#nullable restore
#line 24 "C:\Users\Fernando\Source\Repos\aqui-ou-acola\AquiOuAcola\AquiOuAcola\Views\Home\Privacy.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AquiOuAcola.Entidades.CursoF>> Html { get; private set; }
    }
}
#pragma warning restore 1591
