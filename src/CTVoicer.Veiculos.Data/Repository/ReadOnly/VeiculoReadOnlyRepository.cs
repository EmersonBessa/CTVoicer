using CTVoicer.Veiculos.Bussiness.Intefaces.ReadOnly;
using CTVoicer.Veiculos.Bussiness.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using System.Linq;
using Microsoft.Extensions.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;
using System;

namespace CTVoicer.Veiculos.Data.Repository.ReadOnly
{
    public class VeiculoReadOnlyRepository : IVeiculoReadOnlyRepository 
    {
        private readonly IConfiguration _config;

        public VeiculoReadOnlyRepository(IConfiguration config)
        {
            _config = config;
        }
        public IEnumerable<Veiculo> ObterGrid(string pesquisa, string ordenacaoCampo, string ordenacaoDirecao, string quantidadePagina, string paginaAtual)
        {
            using (SqlConnection cn = new SqlConnection(_config.GetConnectionString("DefaultConnection")))
            {
                var sql = $@"Select v.*, tp.*, c.*
                                From Veiculo v
                                Join TipoVeiculo tp on tp.Id = v.TipoVeiculoId
                                Join Cor c on c.Id = v.CorId
                                where 
                                (@sPesquisa is null 
                                    OR v.Chassi Like '%' + @sPesquisa + '%' COLLATE Latin1_General_CI_AI
                                    or tp.Nome Like '%' + @sPesquisa + '%' COLLATE Latin1_General_CI_AI
                                    or c.Nome Like '%' + @sPesquisa + '%' COLLATE Latin1_General_CI_AI
                                )
                            ORDER BY {ordenacaoCampo} {ordenacaoDirecao}
                            OFFSET {quantidadePagina} * ({paginaAtual} -1) ROWS
                            FETCH NEXT {quantidadePagina} ROWS ONLY";
                cn.Open();
                try
                {
                    var multi = cn.QueryMultiple(sql, new { @sPesquisa = pesquisa });
                    var gr = multi.Read<Veiculo, TipoVeiculo, Cor, Veiculo>
                        ((v, tp, c) =>
                        {
                            v.TipoVeiculoId = tp.Id;
                            v.TipoVeiculo = tp;

                            v.CorId = c.Id;
                            v.Cor = c;

                            return v;
                        }, splitOn: "Id,Id,Id");

                    return gr;
                }catch(Exception ex)
                {
                    return null;
                }

            }

        }

        public Veiculo ObterPorChassi(string chassi)
        {
            using (SqlConnection cn = new SqlConnection(_config.GetConnectionString("DefaultConnection")))
            {
                var sql = $@"Select v.*, tp.*, c.*
                                From Veiculo v
                                Join TipoVeiculo tp on tp.Id = v.TipoVeiculoId
                                Join Cor c on c.Id = v.CorId
                                where 
                                v.Chassi = '{chassi}' ";
                cn.Open();

                var multi = cn.QueryMultiple(sql);
                var carro = multi.Read<Veiculo, TipoVeiculo, Cor, Veiculo>
                    ((v, tp, c) =>
                    {
                        v.TipoVeiculoId = tp.Id;
                        v.TipoVeiculo = tp;

                        v.CorId = c.Id;
                        v.Cor = c;

                        return v;
                    }, splitOn: "Id,Id,Id");

                return carro.FirstOrDefault();
            }
        }

        public Veiculo ObterPorId(Guid id)
        {
            using (SqlConnection cn = new SqlConnection(_config.GetConnectionString("DefaultConnection")))
            {
                var sql = $@"Select *
                                From Veiculo v
                                where 
                                v.Id = '{id}' ";
                cn.Open();

                var carro = cn.Query<Veiculo>(sql);
                return carro.FirstOrDefault();
            }

        }

        public int ObterTotalRegistros(string pesquisa)
        {
            using (SqlConnection cn = new SqlConnection(_config.GetConnectionString("DefaultConnection")))
            {
                var sql = $@"Select count(*) as 'TOTAL'
                                From Veiculo v
                                Join TipoVeiculo tp on tp.Id = v.TipoVeiculoId
                                Join Cor c on c.Id = v.CorId
                                where 
                                (@sPesquisa is null 
                                    OR v.Chassi Like '%' + @sPesquisa + '%' COLLATE Latin1_General_CI_AI
                                    or tp.Nome Like '%' + @sPesquisa + '%' COLLATE Latin1_General_CI_AI
                                    or c.Nome Like '%' + @sPesquisa + '%' COLLATE Latin1_General_CI_AI
                                )";
                cn.Open();

                var total = (int) cn.ExecuteScalar(sql, new { @sPesquisa = pesquisa });
                return total;
            }
        }
    }
}
