using CTVoicer.Veiculos.Bussiness.Intefaces.ReadOnly;
using CTVoicer.Veiculos.Bussiness.Intefaces.Specification;
using CTVoicer.Veiculos.Bussiness.Models;

namespace CTVoicer.Veiculos.Bussiness.Specification
{
    class VeiculoPodeAtualizarSpecification : ISpecification<Veiculo>
    {
        private readonly IVeiculoReadOnlyRepository _veiculoReadOnlyRepository;

        public VeiculoPodeAtualizarSpecification(IVeiculoReadOnlyRepository veiculoReadOnlyRepository)
        {
            _veiculoReadOnlyRepository = veiculoReadOnlyRepository;
        }
        public bool IsSatisfiedBy(Veiculo veiculo)
        {
            var carro = _veiculoReadOnlyRepository.ObterPorChassi(veiculo.Chassi);
            if (carro == null)
            {
                return true;
            }
            else
            {
                return carro.Id == veiculo.Id;
            }
        }
    }
}
