using CSA_SISTEMAS_DAO.DAO;
using CSA_SISTEMAS.CLASSES;

namespace CSA_SISTEMAS_DAO.CONTROLLERS
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
