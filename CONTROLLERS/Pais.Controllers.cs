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
        public void CadastrarPais(string nomePais)
        {
            var pais = new Pais();
            pais.cadastrarPais(nomePais);
        }
        #endregion
    }
}
