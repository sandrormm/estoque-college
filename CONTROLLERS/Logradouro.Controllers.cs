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
        public void CadastrarLogradouro(int idBairro, string rua)
        {
            var logradouro = new Logradouro();
            logradouro.cadastrarLogradouro(idBairro, rua);
        }
        #endregion
    }
}
