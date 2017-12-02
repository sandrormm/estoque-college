using CSA_SISTEMAS_DAO.DAO;

namespace CSA_SISTEMAS_DAO.CONTROLLERS
{
    public class Pais
    {
        #region Pais
        //***************************** PAÍS ************************************//
        public void cadastrarPais(string nomePais)
        {
            var paisDao = new PaisDAO();
            paisDao.cadastrarPais(nomePais);
        }
        #endregion
    }
}
