using CSA_SISTEMAS_DAO.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSA_SISTEMAS_DAO.CONTROLLERS
{
    public class Estado
    {

        //***************************** ESTADO ************************************//
        #region UF
        public void CadastrarEstado(int idPais, string nomeEstado, string uf = "")
        {
                var ufDao = new EstadoDAO();
                ufDao.cadastrarEstado(idPais, nomeEstado, uf);
        }
        #endregion
    }
}
