using CSA_SISTEMAS_DAO.DAO;

namespace CSA_SISTEMAS_DAO.CONTROLLERS
{
    public class Cidade
    {
        
        //***************************** CIDADE ************************************//
        #region Cidade
        public void CadastrarCidade(int idEstado, string nomeCidade)
        {
           
                var cidadeDao = new CidadeDAO();
                cidadeDao.cadastrarCidade(idEstado, nomeCidade);
            
        }
        #endregion
    }
}
