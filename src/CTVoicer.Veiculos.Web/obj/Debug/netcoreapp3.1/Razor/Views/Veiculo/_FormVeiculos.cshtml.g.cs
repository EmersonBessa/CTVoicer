#pragma checksum "C:\git\CtVoicer\CTVoicer\src\CTVoicer.Veiculos.Web\Views\Veiculo\_FormVeiculos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5e6310d9e90cb06e509a7f9713ac8a58a75fa6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Veiculo__FormVeiculos), @"mvc.1.0.view", @"/Views/Veiculo/_FormVeiculos.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5e6310d9e90cb06e509a7f9713ac8a58a75fa6d", @"/Views/Veiculo/_FormVeiculos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"361f028ad790e831b8eceb7e7a7ce2c4f2688731", @"/Views/_ViewImports.cshtml")]
    public class Views_Veiculo__FormVeiculos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""modal fade"" id=""modalNovo"" tabindex="" -1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">
            <div class=""modal-body gray-bg"">
                <div class=""ibox float-e-margins"">
                    <div class=""ibox-title"">
                        <h3>Cadastro de Veículos</h3>
                    </div>
                    <div class=""ibox-content"">
                        <input type=""hidden"" id=""Id"" class=""form-control"" />
                        <input type=""hidden"" id=""Operacao"" class=""form-control"" />
                        <div class=""row"">
                            <div class=""col-md-8"">
                                <label>Chassi</label>
                                <input type=""text"" class=""form-control"" id=""Chassi"" />
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""");
            WriteLiteral(@"col-md-4"">
                                <label>Tipo Veículo</label>
                                <select id=""TipoVeiculoId"" class=""form-control""></select>
                                <input type=""hidden"" id=""TipoVeiculoIdTemp"" class=""form-control"" />
                            </div>
                            <div class=""col-md-4"">
                                <label>Cor Veículo</label>
                                <select id=""CorId"" class=""form-control""></select>
                                <input type=""hidden"" id=""CorIdTemp"" class=""form-control"" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""modal-footer "">
                <button type=""button"" class=""btn btn-success"" id=""btn-salvar""> Salvar </button>
                <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Cancelar</button>
            </div>
        </div>
    </div>
</div>");
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