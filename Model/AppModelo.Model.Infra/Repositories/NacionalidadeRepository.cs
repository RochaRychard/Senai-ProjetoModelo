using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.Model.Infra.Repositories
{
    public class NacionalidadeRepository
    {
        //CRUD - create - read - update- delete
        //       insert - select - update - delete
         Public bool Inserir() { }

         Public bool Atualizar() { }

         Public bool Remover() { }

         Public List <NacionalidadeEntity> ObterTodos()
         {
            var sql = "SELECT * FROM nacionalidades";
         }

         Public NacionalidadeEntity ObterPorId() { }
    }
}
