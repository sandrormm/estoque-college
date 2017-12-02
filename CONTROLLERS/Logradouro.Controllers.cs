using CSA_SISTEMAS_DAO.DAO;

namespace CSA_SISTEMAS_DAO.CONTROLLERS
{
    public class Logradouro
    {
        public void Validar()
        {
            var openDb = new ValidarConexao();
            var closeDb = new FecharConexao();
            openDb.AbrirConexao();
            closeDb.FechaConexao();
        }

        #region Logradouro
        //***************************** LOGRADOURO ************************************//
        public void cadastrarLogradouro(int idBairro, string rua)
        {
            Validar();
            var logradouroDao = new LogradouroDAO();
            logradouroDao.cadastrarLogradouro(idBairro, rua);
        }
        #endregion
    }
}
