using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueConsole.CONTROLLERS
{
    public class Logradouro
    {
        #region Logradouro
        //***************************** LOGRADOURO ************************************//
        public void cadastrarLogradouro(int idBairro, string rua)
        {
            var logradouroDao = new LogradouroDAO();
            logradouroDao.cadastrarLogradouro(idBairro, rua);
        }
        #endregion
    }
}
