using CTVoicer.Veiculos.Bussiness.Intefaces;
using CTVoicer.Veiculos.Bussiness.Intefaces.ReadOnly;
using CTVoicer.Veiculos.Bussiness.Intefaces.Services;
using CTVoicer.Veiculos.Bussiness.Models;
using CTVoicer.Veiculos.Bussiness.Validations;
using CTVoicer.Veiculos.Bussiness.ValueObjects;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CTVoicer.Veiculos.Bussiness.Services
{
    public class VeiculoService : IVeiculoService
    {
        private readonly IVeiculoReadOnlyRepository _veiculoReadOnlyRepository;
        private readonly IVeiculoRepository _veiculoRepository;
        public VeiculoService(IVeiculoReadOnlyRepository veiculoReadOnlyRepository, 
            IVeiculoRepository veiculoRepository)
        {
            _veiculoReadOnlyRepository = veiculoReadOnlyRepository;
            _veiculoRepository = veiculoRepository;
        }
        public async Task<ValidationResult> Adicionar(Veiculo veiculo)
        {
            var resultadoValidacao = new ValidationResult();

            var result = new VeiculoValidation(_veiculoReadOnlyRepository).Validar(veiculo);

            if (!result.IsValid)
            {
                resultadoValidacao.AdicionarErro(result);
                return resultadoValidacao;
            }

            await _veiculoRepository.Adicionar(veiculo);

            return resultadoValidacao;
        }

        public async Task<ValidationResult> Atualizar(Veiculo veiculo)
        {
            var resultadoValidacao = new ValidationResult();

            var result = new VeiculoPodeAtualizarValidation(_veiculoReadOnlyRepository).Validar(veiculo);

            if (!result.IsValid)
            {
                resultadoValidacao.AdicionarErro(result);
                return resultadoValidacao;
            }

            await _veiculoRepository.Atualizar(veiculo);

            return resultadoValidacao;
        }

        public void Dispose()
        {
            _veiculoRepository?.Dispose();
        }

        public IEnumerable<Veiculo> ObterGrid(string pesquisa, string ordenacaoCampo, string ordenacaoDirecao, string quantidadePagina, string paginaAtual)
        {
            return _veiculoReadOnlyRepository.ObterGrid(pesquisa, ordenacaoCampo, ordenacaoDirecao, quantidadePagina, paginaAtual);
        }

        public Veiculo ObterPorChassi(string chassi)
        {
            return _veiculoReadOnlyRepository.ObterPorChassi(chassi);
        }

        public Veiculo ObterPorId(Guid id)
        {
            return _veiculoReadOnlyRepository.ObterPorId(id);
        }

        public int ObterTotalRegistros(string pesquisa)
        {
            return _veiculoReadOnlyRepository.ObterTotalRegistros(pesquisa);
        }

        public async Task<ValidationResult> Remover(Guid id)
        {
            var resultadoValidacao = new ValidationResult();

            await _veiculoRepository.Remover(id);

            return resultadoValidacao;
        }
    }
}
