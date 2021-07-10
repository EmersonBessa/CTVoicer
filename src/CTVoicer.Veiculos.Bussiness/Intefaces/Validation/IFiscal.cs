using CTVoicer.Veiculos.Bussiness.ValueObjects;

namespace CTVoicer.Veiculos.Bussiness.Intefaces.Validation
{
    public interface IFiscal<in TEntity>
    {
        ValidationResult Validar(TEntity entity);

    }
}
