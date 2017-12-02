using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueConsole.CONTROLLERS
{
    public class Telefone
    {
        //***************************** TELEFONE ************************************//
        #region Telefone
        public void cadastrarTelefone(int fixo, int celular)
        {
            var telefoneDao = new TelefoneDAO();
            telefoneDao.cadastrarTelefone(fixo, celular);
        }
        #endregion
    }
}
