using AppModelo.Model.Domain.Entities;
using Dapper;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;

namespace AppModelo.Model.Infra.Repositories
{
    public class NacionalidadeRepository
    {
        private IEnumerable<NacionalidadeEntity> resultado;

        //CRUD - create - read - update- delete
        //       insert - select - update - delete
        public bool Inserir(string descricao) 
         {
            //STRING INTERPOLATION
            var sql = $"INSERT INTO nacionalidades(Descricao) VALUES('{descricao}')";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());

            var resultado = conexaoBd.Execute(sql);

            return resultado > 0;
        }

         public bool Atualizar() 
         { 
            return false;
         }

         public bool Remover() 
         {
            return false;
         }

        public IEnumerable<NacionalidadeEntity> GetResultado()
        {
            return resultado;
        }

        public IEnumerable<NacionalidadeEntity> GetObterTodos(IEnumerable<NacionalidadeEntity> resultado)
        {
            //var sql = "SELECT Id, Descricao nacionalidades ORDER BY descricao ASC";
            var sql = "SELECT Id, Descricao FROM nacionalidades ORDER BY Descricao ASC";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());

            var v = conexaoBd.Query<NacionalidadeEntity>(sql);

            return v;
        }

        public NacionalidadeEntity ObterPorId() 
         {
            return new NacionalidadeEntity();
         }
    }
}
