using CSA_SISTEMAS_DAO.DAO;

namespace CSA_SISTEMAS_DAO.CONTROLLERS
{
    public class Bairro
    {
        
        //***************************** BAIRRO ************************************//
        #region Bairro

        public void CadastrarBairro(int idCidade, string nomeBairro)
        {
                var bairroDao = new BairroDAO();
                bairroDao.cadastrarBairro(idCidade, nomeBairro);
        }

        #endregion
    }
}
