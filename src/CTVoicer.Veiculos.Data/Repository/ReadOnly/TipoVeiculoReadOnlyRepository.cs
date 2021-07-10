using CTVoicer.Veiculos.Bussiness.Intefaces.ReadOnly;
using CTVoicer.Veiculos.Bussiness.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace CTVoicer.Veiculos.Data.Repository.ReadOnly
{
    public class TipoVeiculoReadOnlyRepository : ReadOnlyRepositoryBase, ITipoVeiculoReadOnlyRepository
    {
        private readonly IConfiguration _config;

        public TipoVeiculoReadOnlyRepository(IConfiguration config)
        {
            _config = config;
        }
        public IEnumerable<TipoVeiculo> ObterTodos()
        {
            using (SqlConnection cn = new SqlConnection(_config.GetConnectionString("DefaultConnection")))
            {
                var sql = $@"Select * from TipoVeiculo";
                var tipo = cn.Query<TipoVeiculo>(sql);
                return tipo;
            }

        }
    }
}
