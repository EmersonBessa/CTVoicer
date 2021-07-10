using CTVoicer.Veiculos.Bussiness.Models;
using CTVoicer.Veiculos.Bussiness.ValueObjects;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CTVoicer.Veiculos.Bussiness.Intefaces.Services
{
    public interface ICorService : IDisposable
    {
        Task<ValidationResult> Adicionar(Cor cor);
        Task<ValidationResult> Atualizar(Cor cor);
        Task<ValidationResult> Remover(Guid id);
        IEnumerable<Cor> ObterTodos();
    }
}
