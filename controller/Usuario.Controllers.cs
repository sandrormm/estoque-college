using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueConsole.CONTROLLERS
{
    public class Usuarios
    {
        #region Usuario
        public void CadastrarUsuario(Usuario usuario)
        {
            var user = new Usuario();
            user.CadastrarUsuario(usuario);
        }

        public void AlterarUsuario(USUARIO usuario)
        {
            var user = new Usuario();
            user.AlterarUsuario(usuario);
        }

        public void DeletarUsuario(USUARIO usuario)
        {
            var user = new Usuario();
            user.DeletarUsuario(usuario);
        }
        #endregion
    }
}
