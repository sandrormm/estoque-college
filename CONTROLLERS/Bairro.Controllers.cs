using CSA_SISTEMAS_DAO.DAO;

namespace CSA_SISTEMAS_DAO.CONTROLLERS
{
    public class Bairro
    {
        public void Validar()
        {
            var openDb = new ValidarConexao();
            var closeDb = new FecharConexao();
            openDb.AbrirConexao();
            closeDb.FechaConexao();
        }

        //***************************** BAIRRO ************************************//
        #region Bairro

        public void CadastrarBairro(int idCidade, string nomeBairro)
        {
            try
            {
                Validar();
                var bairroDao = new BairroDAO();
                bairroDao.cadastrarBairro(idCidade, nomeBairro);
            }
            finally
            {
                Validar();
            }
        }

        #endregion
    }
}
