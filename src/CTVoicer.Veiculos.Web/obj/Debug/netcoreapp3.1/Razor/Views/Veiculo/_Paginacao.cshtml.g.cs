#pragma checksum "C:\git\CtVoicer\CTVoicer\src\CTVoicer.Veiculos.Web\Views\Veiculo\_Paginacao.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "403a5924a80b1dea6bd300a4768412f0100d0655"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Veiculo__Paginacao), @"mvc.1.0.view", @"/Views/Veiculo/_Paginacao.cshtml")]
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
#line 1 "C:\git\CtVoicer\CTVoicer\src\CTVoicer.Veiculos.Web\Views\_ViewImports.cshtml"
using CTVoicer.Veiculos.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\git\CtVoicer\CTVoicer\src\CTVoicer.Veiculos.Web\Views\_ViewImports.cshtml"
using CTVoicer.Veiculos.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"403a5924a80b1dea6bd300a4768412f0100d0655", @"/Views/Veiculo/_Paginacao.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"361f028ad790e831b8eceb7e7a7ce2c4f2688731", @"/Views/_ViewImports.cshtml")]
    public class Views_Veiculo__Paginacao : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\git\CtVoicer\CTVoicer\src\CTVoicer.Veiculos.Web\Views\Veiculo\_Paginacao.cshtml"
 if (ViewBag.TotalRegistros > 5)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <nav aria-label=\"Page navigation example\">\r\n        <ul class=\"pagination\">\r\n            <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 172, "\"", 270, 1);
#nullable restore
#line 5 "C:\git\CtVoicer\CTVoicer\src\CTVoicer.Veiculos.Web\Views\Veiculo\_Paginacao.cshtml"
WriteAttributeValue("", 179, Url.Action("Index", "lista-TiposProcessos", new { page = 1, pesquisa = ViewBag.Pesquisa }), 179, 91, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Primeira</a></li>\r\n");
#nullable restore
#line 6 "C:\git\CtVoicer\CTVoicer\src\CTVoicer.Veiculos.Web\Views\Veiculo\_Paginacao.cshtml"
             for (var i = (ViewBag.PaginaAtual - 4); i <= (ViewBag.PaginaAtual - 1); i++)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\git\CtVoicer\CTVoicer\src\CTVoicer.Veiculos.Web\Views\Veiculo\_Paginacao.cshtml"
                 if (i >= 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li");
            BeginWriteAttribute("class", " class=\"", 469, "\"", 530, 2);
            WriteAttributeValue("", 477, "page-item", 477, 9, true);
#nullable restore
#line 10 "C:\git\CtVoicer\CTVoicer\src\CTVoicer.Veiculos.Web\Views\Veiculo\_Paginacao.cshtml"
WriteAttributeValue(" ", 486, i == ViewBag.PaginaAtual ? "active" : "", 487, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-current=\"page\">\r\n                        <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 598, "\"", 696, 1);
#nullable restore
#line 11 "C:\git\CtVoicer\CTVoicer\src\CTVoicer.Veiculos.Web\Views\Veiculo\_Paginacao.cshtml"
WriteAttributeValue("", 605, Url.Action("Index", "lista-TiposProcessos", new { page = i, pesquisa = ViewBag.Pesquisa }), 605, 91, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 11 "C:\git\CtVoicer\CTVoicer\src\CTVoicer.Veiculos.Web\Views\Veiculo\_Paginacao.cshtml"
                                                                                                                                           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    </li>\r\n");
#nullable restore
#line 13 "C:\git\CtVoicer\CTVoicer\src\CTVoicer.Veiculos.Web\Views\Veiculo\_Paginacao.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\git\CtVoicer\CTVoicer\src\CTVoicer.Veiculos.Web\Views\Veiculo\_Paginacao.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 16 "C:\git\CtVoicer\CTVoicer\src\CTVoicer.Veiculos.Web\Views\Veiculo\_Paginacao.cshtml"
             for (var i = (ViewBag.PaginaAtual); i <= (ViewBag.PaginaAtual + 4); i++)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\git\CtVoicer\CTVoicer\src\CTVoicer.Veiculos.Web\Views\Veiculo\_Paginacao.cshtml"
                 if (i <= (ViewBag.TotalRegistros / 5))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li");
            BeginWriteAttribute("class", " class=\"", 970, "\"", 1031, 2);
            WriteAttributeValue("", 978, "page-item", 978, 9, true);
#nullable restore
#line 20 "C:\git\CtVoicer\CTVoicer\src\CTVoicer.Veiculos.Web\Views\Veiculo\_Paginacao.cshtml"
WriteAttributeValue(" ", 987, i == ViewBag.PaginaAtual ? "active" : "", 988, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-current=\"page\">\r\n                        <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1099, "\"", 1197, 1);
#nullable restore
#line 21 "C:\git\CtVoicer\CTVoicer\src\CTVoicer.Veiculos.Web\Views\Veiculo\_Paginacao.cshtml"
WriteAttributeValue("", 1106, Url.Action("Index", "lista-TiposProcessos", new { page = i, pesquisa = ViewBag.Pesquisa }), 1106, 91, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 21 "C:\git\CtVoicer\CTVoicer\src\CTVoicer.Veiculos.Web\Views\Veiculo\_Paginacao.cshtml"
                                                                                                                                           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    </li>\r\n");
#nullable restore
#line 23 "C:\git\CtVoicer\CTVoicer\src\CTVoicer.Veiculos.Web\Views\Veiculo\_Paginacao.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\git\CtVoicer\CTVoicer\src\CTVoicer.Veiculos.Web\Views\Veiculo\_Paginacao.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1324, "\"", 1449, 1);
#nullable restore
#line 26 "C:\git\CtVoicer\CTVoicer\src\CTVoicer.Veiculos.Web\Views\Veiculo\_Paginacao.cshtml"
WriteAttributeValue("", 1331, Url.Action("Index", "lista-TiposProcessos", new { page = (ViewBag.TotalRegistros / 5), pesquisa = ViewBag.Pesquisa }), 1331, 118, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">??ltima</a></li>\r\n        </ul>\r\n    </nav>\r\n");
#nullable restore
#line 29 "C:\git\CtVoicer\CTVoicer\src\CTVoicer.Veiculos.Web\Views\Veiculo\_Paginacao.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
