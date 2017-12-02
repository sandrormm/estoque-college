using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSA_SISTEMAS.CLASSES
{ //ORM
    [Table("USUARIO")]
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("idUSUARIO")]
        public int idProduto { get; set; }

        [Column("NOME_USUARIO")]
        public string Nome { get; set; }

        [Column("SENHA")]
        public string Senha { get; set; }

    }
}
