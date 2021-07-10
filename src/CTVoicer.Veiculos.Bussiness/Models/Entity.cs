using System;
using System.Collections.Generic;
using System.Text;

namespace CTVoicer.Veiculos.Bussiness.Models
{
    public class Entity
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
            DataCriacao = DateTime.Now;
        }

        public Guid Id { get; set; }
        public DateTime DataCriacao { get; set; }

    }
}
