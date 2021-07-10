using CTVoicer.Veiculos.Bussiness.Models;
using System.Collections.Generic;

namespace CTVoicer.Veiculos.Bussiness.Intefaces.ReadOnly
{
    public interface ITipoVeiculoReadOnlyRepository
    {
        IEnumerable<TipoVeiculo> ObterTodos();
    }
}
