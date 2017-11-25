using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueConsole
{
    class Bairro
    {
        public int cadastrarBairro(int idCidade, string nomeBairro)
        {
            var db = new estoqueEntities();

            var bairro = db.BAIRRO.Create();

            bairro.CIDADE_idCIDADE = idCidade;
            bairro.NOME_BAIRRO = nomeBairro;

            db.BAIRRO.Add(bairro);
            db.SaveChanges();

            return bairro.idBAIRRO;
        }
    }
}

