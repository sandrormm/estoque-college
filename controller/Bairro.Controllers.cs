using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueConsole.CONTROLLERS
{
    public class Bairro
    {
        #region Bairro
        public void CadastrarBairro(int idCidade, string nomeBairro)
        {
                var bairro = new Bairro();
                bairro.cadastrarBairro(idCidade, nomeBairro);
        }

        #endregion
    }
}
