using CTVoicer.Veiculos.Bussiness.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace CTVoicer.Veiculos.Web.ViewModels
{
    public class VeiculoViewModel
    {
        public Guid? Id { get; set; }
        public DateTime DataCriacao { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Chassi { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]

        public Guid TipoVeiculoId { get; set; }
        public TipoVeiculo TipoVeiculo { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]

        public Guid CorId { get; set; }
        public Cor Cor { get; set; }

    }
}
