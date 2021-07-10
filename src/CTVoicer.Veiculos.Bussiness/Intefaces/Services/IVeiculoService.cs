using CTVoicer.Veiculos.Bussiness.Models;
using CTVoicer.Veiculos.Bussiness.ValueObjects;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CTVoicer.Veiculos.Bussiness.Intefaces.Services
{
    public interface IVeiculoService : IDisposable
    {
        Task<ValidationResult> Adicionar(Veiculo veiculo);
        Task<ValidationResult> Atualizar(Veiculo veiculo);
        Task<ValidationResult> Remover(Guid id);
        int ObterTotalRegistros(string pesquisa);
        IEnumerable<Veiculo> ObterGrid(string pesquisa, string ordenacaoCampo, string ordenacaoDirecao, string quantidadePagina, string paginaAtual);
        Veiculo ObterPorChassi(string chassi);
        Veiculo ObterPorId(Guid id);
    }
}
