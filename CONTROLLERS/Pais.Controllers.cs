using CSA_SISTEMAS_DAO.DAO;

namespace CSA_SISTEMAS_DAO.CONTROLLERS
{
    public class Pais
    {
        public void Validar()
        {
            var openDb = new ValidarConexao();
            var closeDb = new FecharConexao();
            openDb.AbrirConexao();
            closeDb.FechaConexao();
        }

        #region Pais
        //***************************** PAÍS ************************************//
        public void cadastrarPais(string nomePais)
        {
            Validar();
            var paisDao = new PaisDAO();
            paisDao.cadastrarPais(nomePais);
        }
        #endregion
    }
}
