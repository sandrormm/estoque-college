using CSA_SISTEMAS_DAO.DAO;
using CSA_SISTEMAS.CLASSES;

namespace CSA_SISTEMAS_DAO.CONTROLLERS
{
    public class Usuarios
    {
        public void Validar()
        {
            var openDb = new ValidarConexao();
            var closeDb = new FecharConexao();
            openDb.AbrirConexao();
            closeDb.FechaConexao();
        }

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
            try
            {
                Validar();
                var userDao = new UsuarioDAO();
                userDao.DeletarUsuario(usuario);
            }
            finally
            {
                Validar();
            }
        }
        #endregion
    }
}
