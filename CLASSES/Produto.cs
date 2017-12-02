using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSA_SISTEMAS.CLASSES
{
    [Table("PRODUTO")]
    public class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("idPRODUTO")]
        public int idProduto { get; set; }

        [Column("NOME_PROD")]
        public string Nome_produto { get; set; }

        [Column("COD_BARRAS")]
        public int Cod_barras { get; set; }

        [Column("GRUPO")]
        public int Grupos { get; set; }

        [Column("UN")]
        public string unidade { get; set; }

       

    }
}
