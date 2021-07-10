using CTVoicer.Veiculos.Bussiness.Intefaces.ReadOnly;
using CTVoicer.Veiculos.Bussiness.Models;
using CTVoicer.Veiculos.Bussiness.Specification;


namespace CTVoicer.Veiculos.Bussiness.Validations
{
    public class VeiculoValidation : FiscalBase<Veiculo>
    {
        public VeiculoValidation(IVeiculoReadOnlyRepository veiculoReadOnlyRepository)
        {
            var veiculo = new VeiculoSpecification(veiculoReadOnlyRepository);
            base.AdicionarRegra("veiculo", new Regra<Veiculo>(veiculo, "Chassi Já Cadastrado"));
        }
    }
}
