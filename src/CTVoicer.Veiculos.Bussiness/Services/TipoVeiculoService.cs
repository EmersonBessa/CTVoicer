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
    public class TipoVeiculoService : ITipoVeiculoService
    {
        private readonly ITipoVeiculoRepository _tipoVeiculoRepository;
        private readonly ITipoVeiculoReadOnlyRepository _tipoVeiculoReadOnlyRepository;

        public TipoVeiculoService(ITipoVeiculoRepository tipoVeiculoRepository, 
            ITipoVeiculoReadOnlyRepository tipoVeiculoReadOnlyRepository)
        {
            _tipoVeiculoRepository = tipoVeiculoRepository;
            _tipoVeiculoReadOnlyRepository = tipoVeiculoReadOnlyRepository;
        }


        public async Task<ValidationResult> Adicionar(TipoVeiculo tipoVeiculo)
        {
            var resultadoValidacao = new ValidationResult();
            await _tipoVeiculoRepository.Adicionar(tipoVeiculo);

            return resultadoValidacao;
        }

        public async Task<ValidationResult> Atualizar(TipoVeiculo tipoVeiculo)
        {
            var resultadoValidacao = new ValidationResult();
            await _tipoVeiculoRepository.Atualizar(tipoVeiculo);

            return resultadoValidacao;
        }

        public void Dispose()
        {
            _tipoVeiculoRepository.Dispose();
        }

        public IEnumerable<TipoVeiculo> ObterTodos()
        {
            return _tipoVeiculoReadOnlyRepository.ObterTodos();
        }

        public async Task<ValidationResult> Remover(Guid id)
        {
            var resultadoValidacao = new ValidationResult();
            await _tipoVeiculoRepository.Remover(id);

            return resultadoValidacao;
        }
    }
}
