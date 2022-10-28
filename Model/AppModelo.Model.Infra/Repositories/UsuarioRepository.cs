﻿using AppModelo.Model.Domain.Entities;
using Dapper;
using MySql.Data.MySqlClient;
using System.Data;

namespace AppModelo.Model.Infra.Repositories
{
    public class UsuarioRepository
    {
        public UsuarioEntity obter(string usuario, string senha)
        {
            var sql = $"SELECT Email, Senha FROM usuarios WHERE Email = '{usuario}' AND Senha = '{senha}';";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());

            var resultado = conexaoBd.QuerySingleOrDefault<UsuarioEntity>(sql);

            return resultado;
        }
        public UsuarioEntity ObterPorEmail(string email)
        {
            var sql = $"SELECT Email, Nome Senha FROM usuarios WHERE Email = '{email}' ";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());

            var resultado = conexaoBd.QuerySingleOrDefault<UsuarioEntity>(sql);

            return resultado;
        }
        public bool AtualizarSenha(string email, string novaSenha)
        {
            var sql = $"UPDATE usuarios SET Senha = '{novaSenha}' WHERE email = '{email}'";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());

            var resultado = conexaoBd.Execute(sql);

            return resultado > 0;
        }
    }
}
