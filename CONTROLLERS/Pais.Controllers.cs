using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueConsole.CONTROLLERS
{
    public class Pais
    {
        #region Pais
        //***************************** PAÍS ************************************//
        public void cadastrarPais(string nomePais)
        {
            var paisDao = new PaisDAO();
            paisDao.cadastrarPais(nomePais);
        }
        #endregion
    }
}
