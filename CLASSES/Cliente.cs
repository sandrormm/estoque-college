using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSA_SISTEMAS.CLASSES
{
    [Table("CLIENTE")]
    public class Cliente
    {
        public int id { get; set; }
        public int idTelefone { get; set; }
        public int idEndereco { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public DateTime nascimento { get; set; }
        public string email { get; set; }
    }
}
