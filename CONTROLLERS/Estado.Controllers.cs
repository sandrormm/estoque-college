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
        public void Validar()
        {
            var openDb = new ValidarConexao();
            var closeDb = new FecharConexao();
            openDb.AbrirConexao();
            closeDb.FechaConexao();
        }

        //***************************** ESTADO ************************************//
        #region UF
        public void CadastrarEstado(int idPais, string nomeEstado, string uf = "")
        {
            try
            {
                Validar();
                var ufDao = new EstadoDAO();
                ufDao.cadastrarEstado(idPais, nomeEstado, uf);
            }
            finally
            {
                Validar();
            }
        }
        #endregion
    }
}
