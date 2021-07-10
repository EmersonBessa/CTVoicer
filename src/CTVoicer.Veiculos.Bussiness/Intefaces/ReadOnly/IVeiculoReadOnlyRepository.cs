using CTVoicer.Veiculos.Bussiness.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CTVoicer.Veiculos.Bussiness.Intefaces.ReadOnly
{
    public interface IVeiculoReadOnlyRepository
    {
        int ObterTotalRegistros(string pesquisa);
        IEnumerable<Veiculo> ObterGrid(string pesquisa, string ordenacaoCampo, string ordenacaoDirecao, string quantidadePagina, string paginaAtual);
        Veiculo ObterPorChassi(string chassi);
        Veiculo ObterPorId(Guid id);
    }
}
