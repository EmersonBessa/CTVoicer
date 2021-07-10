using CTVoicer.Veiculos.Bussiness.Intefaces.ReadOnly;
using CTVoicer.Veiculos.Bussiness.Models;
using CTVoicer.Veiculos.Bussiness.Specification;


namespace CTVoicer.Veiculos.Bussiness.Validations
{
    public class VeiculoPodeAtualizarValidation : FiscalBase<Veiculo>
    {
        public VeiculoPodeAtualizarValidation(IVeiculoReadOnlyRepository veiculoReadOnlyRepository)
        {
            var veiculo = new VeiculoPodeAtualizarSpecification(veiculoReadOnlyRepository);
            base.AdicionarRegra("veiculo", new Regra<Veiculo>(veiculo, "Chassi Já Cadastrado"));
        }
    }
}
