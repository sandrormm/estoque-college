using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueConsole
{
    class Logradouro
    {
        public int cadastrarLogradouro(int idBairro, string rua)
        {
            var db = new estoqueEntities();

            var logradouro = db.LOGRADOURO.Create();

            logradouro.BAIRRO_idBAIRRO = idBairro;
            logradouro.RUA = rua;

            db.LOGRADOURO.Add(logradouro);
            db.SaveChanges();

            return logradouro.idLOGRADOURO;
        }
    }
}

