using CTVoicer.Veiculos.Bussiness.Intefaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CTVoicer.Veiculos.Web.Controllers
{
    public class TipoVeiculoController : Controller
    {
        private readonly ITipoVeiculoService _tipoVeiculoService;

        public TipoVeiculoController(ITipoVeiculoService tipoVeiculoService)
        {
            _tipoVeiculoService = tipoVeiculoService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public JsonResult ObterTipoVeiculoParaDropDown()
        {
            var resultado = _tipoVeiculoService.ObterTodos();

            var dados = new List<Object> { };
            foreach (var result in resultado)
            {
                dados.Add(new
                {
                    label = result.Nome,
                    title = result.Nome,
                    value = result.Id
                });
            }

            return Json(dados);
        }
    }
}
