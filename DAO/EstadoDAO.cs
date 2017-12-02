using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSA_SISTEMAS_DAO.DAO
{
    public class EstadoDAO
    {
        public int cadastrarEstado(int idPais, string nomeEstado, string uf = "")
        {
            var db = new CSA_GESTOREntities();

            var estado = db.ESTADO.Create();

            estado.PAIS_idPAIS = idPais;
            estado.NOME_ESTADO = nomeEstado;
            estado.UF = uf;

            db.ESTADO.Add(estado);
            db.SaveChanges();

            return estado.idESTADO;
        }
    }
}
