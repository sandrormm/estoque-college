using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueConsole.CONTROLLERS
{
    public class Cidade
    {
        
        //***************************** CIDADE ************************************//
        #region Cidade
        public void CadastrarCidade(int idEstado, string nomeCidade)
        {
           
                var cidadeDao = new CidadeDAO();
                cidadeDao.cadastrarCidade(idEstado, nomeCidade);
            
        }
        #endregion
    }
}
