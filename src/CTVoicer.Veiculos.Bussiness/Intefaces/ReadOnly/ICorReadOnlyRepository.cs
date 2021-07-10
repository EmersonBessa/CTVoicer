using CTVoicer.Veiculos.Bussiness.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CTVoicer.Veiculos.Bussiness.Intefaces.ReadOnly
{
    public interface ICorReadOnlyRepository
    {
        IEnumerable<Cor> ObterTodos();

    }
}
