using CTVoicer.Veiculos.Bussiness.Intefaces.ReadOnly;
using CTVoicer.Veiculos.Bussiness.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CTVoicer.Veiculos.Data.Repository.ReadOnly
{
    public class CorReadOnlyRepository : ReadOnlyRepositoryBase, ICorReadOnlyRepository
    {
        private readonly IConfiguration _config;

        public CorReadOnlyRepository(IConfiguration config)
        {
            _config = config;
        }
        public IEnumerable<Cor> ObterTodos()
        {
            using (SqlConnection cn = new SqlConnection(_config.GetConnectionString("DefaultConnection")))
            {
                var sql = $@"Select * from Cor";
                var cores = cn.Query<Cor>(sql);
                return cores;
            }

        }
    }
}
