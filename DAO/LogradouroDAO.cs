namespace CSA_SISTEMAS_DAO.DAO
{
    public class LogradouroDAO
    {
        public int cadastrarLogradouro(int idBairro, string rua)
        {
            var db = new CSA_GESTOREntities();

            var logradouro = db.LOGRADOURO.Create();

            logradouro.BAIRRO_idBAIRRO = idBairro;
            logradouro.RUA = rua;

            db.LOGRADOURO.Add(logradouro);
            db.SaveChanges();

            return logradouro.idLOGRADOURO;
        }
    }
}
