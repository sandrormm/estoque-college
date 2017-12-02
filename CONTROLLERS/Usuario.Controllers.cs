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

        //***************************** USUÁRIO ************************************//
        public void CadastrarUsuario(Usuario usuario)
        {
            var userDao = new UsuarioDAO();
            userDao.CadastrarUsuario(usuario);
        }

        public void AlterarUsuario(USUARIO usuario)
        {
            var userDao = new UsuarioDAO();
            userDao.AlterarUsuario(usuario);
        }

        public void DeletarUsuario(USUARIO usuario)
        {
           
                var userDao = new UsuarioDAO();
                userDao.DeletarUsuario(usuario);
           
        }
        #endregion
    }
}
