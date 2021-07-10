using CTVoicer.Veiculos.Bussiness.Models;
using CTVoicer.Veiculos.Bussiness.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CTVoicer.Veiculos.Bussiness.Intefaces.Services
{
    public interface ITipoVeiculoService : IDisposable
    {
        Task<ValidationResult> Adicionar(TipoVeiculo tipoVeiculo);
        Task<ValidationResult> Atualizar(TipoVeiculo tipoVeiculo);
        Task<ValidationResult> Remover(Guid id);
        IEnumerable<TipoVeiculo> ObterTodos();

    }
}
