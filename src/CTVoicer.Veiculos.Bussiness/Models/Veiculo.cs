
using System;

namespace CTVoicer.Veiculos.Bussiness.Models
{
    public class Veiculo : Entity
    {
        public string Chassi { get; set; }
        public Guid TipoVeiculoId { get; set; }
        public virtual TipoVeiculo TipoVeiculo { get; set; }
        public Guid CorId { get; set; }
        public virtual Cor Cor { get; set; }
    }
}
