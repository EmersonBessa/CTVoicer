using CTVoicer.Veiculos.Bussiness.Intefaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CTVoicer.Veiculos.Web.Controllers
{
    public class CorController : Controller
    {
        private readonly ICorService _corService;

        public CorController(ICorService corService)
        {
            _corService = corService;
        }

        public IActionResult Index()
        {            
            return View();
        }

        public JsonResult ObterCorParaDropDown()
        {
            var resultado = _corService.ObterTodos();

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
