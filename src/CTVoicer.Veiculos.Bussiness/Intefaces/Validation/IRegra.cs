using System;
using System.Collections.Generic;
using System.Text;

namespace CTVoicer.Veiculos.Bussiness.Intefaces.Validation
{
    public interface IRegra<in TEntity>
    {
        string MensagemErro { get; }
        bool Validar(TEntity entity);
    }
}
