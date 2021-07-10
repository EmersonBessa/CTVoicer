using CTVoicer.Veiculos.Bussiness.Intefaces;
using CTVoicer.Veiculos.Bussiness.Models;
using CTVoicer.Veiculos.Data.Context;

namespace CTVoicer.Veiculos.Data.Repository
{
    public class TipoVeiculoRepository : Repository<TipoVeiculo>, ITipoVeiculoRepository
    {
        public TipoVeiculoRepository(VeiculoContext context) : base(context)
        {
        }
    }
}
