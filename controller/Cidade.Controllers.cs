using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueConsole.CONTROLLERS
{
    public class Cidade
    {
        
        #region Cidade
        public void CadastrarCidade(int idEstado, string nomeCidade)
        {
                var cidade = new Cidade();
                cidade.cadastrarCidade(idEstado, nomeCidade);
        }
        #endregion
    }
}
