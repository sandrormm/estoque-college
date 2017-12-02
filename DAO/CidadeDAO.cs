namespace CSA_SISTEMAS_DAO.DAO
{
    public class CidadeDAO
    {
        public int idEstado { get; set; }
        public string cidade { get; set; }

        public int cadastrarCidade(int idEstado, string nomeCidade)
        {
            var db = new CSA_GESTOREntities();

            var cidade = db.CIDADE.Create();

            cidade.ESTADO_idESTADO = idEstado;
            cidade.NOME_CIDADE = nomeCidade;

            db.CIDADE.Add(cidade);
            db.SaveChanges();

            return cidade.idCIDADE;
        }
    }
}
