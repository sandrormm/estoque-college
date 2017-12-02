namespace CSA_SISTEMAS_DAO.DAO
{
    public class PaisDAO
    {
        public string pais { get; set; }
        public string sigla { get; set; }

        public int cadastrarPais(string nomePais, string sigla = "")
        {
            var db = new CSA_GESTOREntities();

            var pais = db.PAIS.Create();
            pais.NOME_PAIS = nomePais;
            pais.SIGLA_PAIS = sigla;

            db.PAIS.Add(pais);
            db.SaveChanges();

            return pais.idPAIS;
        }
    }
}
