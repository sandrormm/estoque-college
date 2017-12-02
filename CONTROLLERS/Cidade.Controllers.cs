using CSA_SISTEMAS_DAO.DAO;

namespace CSA_SISTEMAS_DAO.CONTROLLERS
{
    public class Cidade
    {
        public void Validar()
        {
            var openDb = new ValidarConexao();
            var closeDb = new FecharConexao();
            openDb.AbrirConexao();
            closeDb.FechaConexao();
        }

        //***************************** CIDADE ************************************//
        #region Cidade
        public void CadastrarCidade(int idEstado, string nomeCidade)
        {
            try
            {
                Validar();
                var cidadeDao = new CidadeDAO();
                cidadeDao.cadastrarCidade(idEstado, nomeCidade);
            }
            finally
            {
                Validar();
            }
        }
        #endregion
    }
}
