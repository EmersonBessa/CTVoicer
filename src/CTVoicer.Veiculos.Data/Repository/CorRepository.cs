using CTVoicer.Veiculos.Bussiness.Intefaces;
using CTVoicer.Veiculos.Bussiness.Models;
using CTVoicer.Veiculos.Data.Context;

namespace CTVoicer.Veiculos.Data.Repository
{
    public class CorRepository : Repository<Cor>, ICorRepository
    {
        public CorRepository(VeiculoContext context) : base(context)
        {
        }
    }
}
