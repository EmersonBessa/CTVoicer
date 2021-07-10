using CTVoicer.Veiculos.Bussiness.Intefaces;
using CTVoicer.Veiculos.Bussiness.Models;
using CTVoicer.Veiculos.Data.Context;

namespace CTVoicer.Veiculos.Data.Repository
{
    public class VeiculoRepository : Repository<Veiculo>, IVeiculoRepository
    {
        public VeiculoRepository(VeiculoContext context) : base(context)
        {
        }
    }
}
