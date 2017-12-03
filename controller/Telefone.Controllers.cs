using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueConsole.CONTROLLERS
{
    public class Telefone
    {
        #region Telefone
        public void CadastrarTelefone(int fixo, int celular)
        {
            var telefone = new Telefone();
            telefone.cadastrarTelefone(fixo, celular);
        }
        #endregion
    }
}
