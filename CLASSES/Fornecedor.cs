namespace CSA_SISTEMAS_DAO.DAO
{
    public class Fornecedor
    {
        public int cnpj { get; set; }
        public string email { get; set; }
        public string fantasia { get; set; }
        public int id { get; set; }
        public int idEndereco { get; set; }
        public int idTelefone { get; set; }
        public int inscricaoEstadual { get; set; }
        public string razaoSocial { get; set; }
    }
}