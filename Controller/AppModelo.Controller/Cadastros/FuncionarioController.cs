using AppModelo.Model.Domain.Entities;
using AppModelo.Model.Infra.Repositories;
using System.Collections.Generic;


namespace AppModelo.Controller.Cadastros
{
    public class FuncionarioController
    {
        public bool Cadastrar(string descricao)
        {
            var repositorio = new FuncionarioRepository();

            var resposta = repositorio.Inserir(descricao);
            return resposta;
        }

        public IEnumerable<FuncionarioEntity> ObterTodasNacionalidades()
        {
            var repositorio = new FuncionarioRepository();
            var resposta = repositorio.ObterTodos();
            return (IEnumerable<FuncionarioEntity>)resposta;
        }
    }
}
