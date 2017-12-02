using CSA_SISTEMAS_DAO.DAO;

namespace CSA_SISTEMAS_DAO.CONTROLLERS
{
    public class Telefone
    {
        //***************************** TELEFONE ************************************//
        #region Telefone
        public void cadastrarTelefone(int fixo, int celular)
        {
            var telefoneDao = new TelefoneDAO();
            telefoneDao.cadastrarTelefone(fixo, celular);
        }
        #endregion
    }
}
