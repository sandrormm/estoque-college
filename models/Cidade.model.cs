using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueConsole
{
    class Cidade
    {
        public int idEstado { get; set; }
        public string cidade { get; set; }

        public int cadastrarCidade(int idEstado, string nomeCidade)
        {
            var db = new estoqueEntities();

            var cidade = db.CIDADE.Create();

            cidade.ESTADO_idESTADO = idEstado;
            cidade.NOME_CIDADE = nomeCidade;

            db.CIDADE.Add(cidade);
            db.SaveChanges();

            return cidade.idCIDADE;
        }
    }
}
