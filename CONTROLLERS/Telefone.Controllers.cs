using CSA_SISTEMAS_DAO.DAO;

namespace CSA_SISTEMAS_DAO.CONTROLLERS
{
    public class Telefone
    {
        public void Validar()
        {
            var openDb = new ValidarConexao();
            var closeDb = new FecharConexao();
            openDb.AbrirConexao();
            closeDb.FechaConexao();
        }

        //***************************** TELEFONE ************************************//
        #region Telefone
        public void cadastrarTelefone(int fixo, int celular)
        {
            Validar();
            var telefoneDao = new TelefoneDAO();
            telefoneDao.cadastrarTelefone(fixo, celular);
        }
        #endregion
    }
}
