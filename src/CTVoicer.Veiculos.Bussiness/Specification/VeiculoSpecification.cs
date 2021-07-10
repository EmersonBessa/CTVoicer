using CTVoicer.Veiculos.Bussiness.Intefaces.ReadOnly;
using CTVoicer.Veiculos.Bussiness.Intefaces.Specification;
using CTVoicer.Veiculos.Bussiness.Models;


namespace CTVoicer.Veiculos.Bussiness.Specification
{
    public class VeiculoSpecification : ISpecification<Veiculo>
    {
        private readonly IVeiculoReadOnlyRepository _veiculoReadOnlyRepository;

        public VeiculoSpecification(IVeiculoReadOnlyRepository veiculoReadOnlyRepository)
        {
            _veiculoReadOnlyRepository = veiculoReadOnlyRepository;
        }

        public bool IsSatisfiedBy(Veiculo veiculo)
        {
            var carro = _veiculoReadOnlyRepository.ObterPorChassi(veiculo.Chassi);
            return carro == null;
        }
    }
}
