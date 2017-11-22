using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueConsole
{
    class Pais
    {
        public string pais { get; set; }
        public string sigla { get; set; }

        public int cadastrarPais(string nomePais, string sigla = "")
        {
            var db = new estoqueEntities();

            var pais = db.PAIS.Create();
            pais.NOME_PAIS = nomePais;
            pais.SIGLA_PAIS = sigla;

            db.PAIS.Add(pais);
            db.SaveChanges();

            return pais.idPAIS;
        }
    }
}

