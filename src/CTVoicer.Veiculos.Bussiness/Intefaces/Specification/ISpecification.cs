using System.Threading.Tasks;

namespace CTVoicer.Veiculos.Bussiness.Intefaces.Specification
{
    public interface ISpecification<in T>
    {
        bool IsSatisfiedBy(T entity);
    }
}
