using CSA_SISTEMAS_DAO.DAO;

namespace CSA_SISTEMAS_DAO.CONTROLLERS
{
    public class Logradouro
    {
        #region Logradouro
        //***************************** LOGRADOURO ************************************//
        public void cadastrarLogradouro(int idBairro, string rua)
        {
            var logradouroDao = new LogradouroDAO();
            logradouroDao.cadastrarLogradouro(idBairro, rua);
        }
        #endregion
    }
}
