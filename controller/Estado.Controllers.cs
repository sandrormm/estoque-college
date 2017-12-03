using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueConsole.CONTROLLERS
{
    public class Estado
    {
        #region UF
        public void CadastrarEstado(int idPais, string nomeEstado, string uf = "")
        {
                var uf = new Estado();
                uf.cadastrarEstado(idPais, nomeEstado, uf);
        }
        #endregion
    }
}
