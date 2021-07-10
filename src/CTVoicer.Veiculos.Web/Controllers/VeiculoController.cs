using CTVoicer.Veiculos.Bussiness.Intefaces.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using CTVoicer.Veiculos.Web.ViewModels;
using CTVoicer.Veiculos.Bussiness.Models;
using CTVoicer.Veiculos.Bussiness.ValueObjects;
using System;
using System.Linq;

namespace CTVoicer.Veiculos.Web.Controllers
{
    public class VeiculoController : Controller
    {
        private readonly IVeiculoService _veiculoService;
        private readonly ITipoVeiculoService _tipoVeiculoService;
        private readonly IMapper _mapper;

        public VeiculoController(IVeiculoService veiculoService, IMapper mapper, ITipoVeiculoService tipoVeiculoService)
        {
            _veiculoService = veiculoService;
            _mapper = mapper;
            _tipoVeiculoService = tipoVeiculoService;
        }

        [Route("lista-veiculos")]
        public IActionResult Index(string pesquisa, string ordenacaoCampo, string ordenacaoDirecao, string quantidadePagina, string paginaAtual)
        {
            return View();
        }


        [Route("grid-veiculos")]
        public JsonResult ObterGridVeiculos(string pesquisa, string ordenacaoCampo, string ordenacaoDirecao, string quantidadePagina, string paginaAtual)
        {

            var veiculo = _veiculoService.ObterGrid(pesquisa, ordenacaoCampo, ordenacaoDirecao, quantidadePagina, paginaAtual);
            var veiculoViewModel = _mapper.Map<IEnumerable<VeiculoViewModel>>(veiculo);
            var dados = new
            {
                rows = veiculoViewModel,
                total = _veiculoService.ObterTotalRegistros(pesquisa)
            };

            return Json(dados);
        }

        [IgnoreAntiforgeryToken]
        [HttpPost]
        [Route("criar-veiculo")]
        public async Task<ActionResult> Create(VeiculoViewModel veiculosViewModel, string operacao)
        {
            if (!ModelState.IsValid)
            {
                var errors = ViewData.ModelState.Where(n => n.Value.Errors.Count > 0).ToList(); 

                foreach (var erro in errors)
                {
                    ModelState.AddModelError(string.Empty, erro.Key);
                }

                return Json(new
                {
                    success = ModelState.IsValid,
                    errors = ValidationsViewModels.ValidationsViewModels.ValidarViewModel(ModelState)
                });
            }

            ValidationResult result = null;

            if (operacao != "update")
            {
                result = await _veiculoService.Adicionar(_mapper.Map<Veiculo>(veiculosViewModel));

                foreach (var validationAppError in result.Erros)
                {
                    ModelState.AddModelError(string.Empty, validationAppError.Message);
                }
            }
            else
            {
                result = await  _veiculoService.Atualizar(_mapper.Map<Veiculo>(veiculosViewModel));

                foreach (var validationAppError in result.Erros)
                {
                    ModelState.AddModelError(string.Empty, validationAppError.Message);
                }
            }

            return Json(new
            {
                success = result.IsValid,
                errors = ModelState.Keys.SelectMany(k => ModelState[k].Errors)
                                .Select(m => m.ErrorMessage).ToArray()
            });

        }

        [IgnoreAntiforgeryToken]
        [HttpPost]
        [Route("excluir-veiculo")]
        public async Task<JsonResult> DeleteConfirmed(Guid id)
        {
            var veiculosViewModel = _veiculoService.ObterPorId(id);

            ValidationResult result = null;

            result = await _veiculoService.Remover(veiculosViewModel.Id);

            foreach (var validationAppError in result.Erros)
            {
                ModelState.AddModelError(string.Empty, validationAppError.Message);
            }

            return Json(new
            {
                success = result.IsValid,
                mensagem = "Veículo excluído com Sucesso!",
                errors = ModelState.Keys.SelectMany(k => ModelState[k].Errors)
                                .Select(m => m.ErrorMessage).ToArray()
            });
        }

        [IgnoreAntiforgeryToken]
        [HttpPost]
        [Route("obter-veiculo")]
        public JsonResult ObterVeiculo(Guid veiculoId)
        {
            var veiculo = _veiculoService.ObterPorId(veiculoId);
            return Json(veiculo);
        }
    }
}
