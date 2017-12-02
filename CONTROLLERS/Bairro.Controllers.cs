using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueConsole.CONTROLLERS
{
    public class Bairro
    {
        //***************************** BAIRRO ************************************//
        #region Bairro

        public void CadastrarBairro(int idCidade, string nomeBairro)
        {
                var bairroDao = new BairroDAO();
                bairroDao.cadastrarBairro(idCidade, nomeBairro);
        }

        #endregion
    }
}
