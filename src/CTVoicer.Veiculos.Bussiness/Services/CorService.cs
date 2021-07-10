using CTVoicer.Veiculos.Bussiness.Intefaces;
using CTVoicer.Veiculos.Bussiness.Intefaces.ReadOnly;
using CTVoicer.Veiculos.Bussiness.Intefaces.Services;
using CTVoicer.Veiculos.Bussiness.Models;
using CTVoicer.Veiculos.Bussiness.ValueObjects;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CTVoicer.Veiculos.Bussiness.Services
{
    public class CorService : ICorService
    {
        private readonly ICorRepository _corRepository;
        private readonly ICorReadOnlyRepository _corReadOnlyRepository;
        public CorService(ICorRepository corRepository, ICorReadOnlyRepository corReadOnlyRepository)
        {
            _corRepository = corRepository;
            _corReadOnlyRepository = corReadOnlyRepository;
        }

        public async Task<ValidationResult> Adicionar(Cor cor)
        {
            var resultadoValidacao = new ValidationResult();
            await _corRepository.Adicionar(cor);

            return resultadoValidacao;
        }

        public async Task<ValidationResult> Atualizar(Cor cor)
        {
            var resultadoValidacao = new ValidationResult();
            await _corRepository.Atualizar(cor);

            return resultadoValidacao;
        }

        public void Dispose()
        {
            _corRepository.Dispose();
        }

        public IEnumerable<Cor> ObterTodos()
        {
            return _corReadOnlyRepository.ObterTodos();
        }

        public async Task<ValidationResult> Remover(Guid id)
        {
            var resultadoValidacao = new ValidationResult();
            await _corRepository.Remover(id);

            return resultadoValidacao;
        }
    }
}
