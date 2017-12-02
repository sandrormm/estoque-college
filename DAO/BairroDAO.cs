namespace CSA_SISTEMAS_DAO.DAO
{
    public class BairroDAO
    {
        public int cadastrarBairro(int idCidade, string nomeBairro)
        {
            var db = new CSA_GESTOREntities();

            var bairro = db.BAIRRO.Create();

            bairro.CIDADE_idCIDADE = idCidade;
            bairro.NOME_BAIRRO = nomeBairro;

            db.BAIRRO.Add(bairro);
            db.SaveChanges();

            return bairro.idBAIRRO;
        }
    }
}
