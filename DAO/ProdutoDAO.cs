using System.Collections.Generic;
using System.Linq;

namespace CSA_SISTEMAS_DAO.DAO
{
    public class ProdutoDAO
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int codBarras { get; set; }
        public int grupo { get; set; }
        public string unidade { get; set; }
        public List<PRODUTO> listarProdutos()
        {
            var db = new CSA_GESTOREntities();
            List<PRODUTO> produtos = new List<PRODUTO>();
            produtos = db.PRODUTO.Select(x => new PRODUTO
            {
                id = x.idPRODUTO,
                nome = x.NOME_PROD,
                COD_BARRAS = x.COD_BARRAS,
                GRUPO = x.GRUPO,
                UN = x.UN
            }).ToList();
            return produtos;
        }

        public void cadastrarProduto(string nome, int codBarras, int grupo, string unidade)
        {
            var db = new CSA_GESTOREntities();
            var produto = db.PRODUTO.Create();
            produto.NOME_PROD = nome;
            produto.COD_BARRAS = codBarras;
            produto.GRUPO = grupo;
            produto.UN = unidade;
            db.PRODUTO.Add(produto);
            db.SaveChanges();

            EstoqueDAO estoque = new EstoqueDAO();
            estoque.cadastrarEstoque(produto.idPRODUTO);
        }

        public void alterarProduto(int codigo, string nome, int codBarras, int grupo, string unidade)
        {
            var db = new CSA_GESTOREntities();
            var produto = db.PRODUTO.Where(x => x.idPRODUTO == codigo).Select(x => x).First();
            produto.NOME_PROD = nome;
            produto.COD_BARRAS = codBarras;
            produto.GRUPO = grupo;
            produto.UN = unidade;
            db.SaveChanges();
        }

        public void removerProduto(int codigo)
        {
            var db = new CSA_GESTOREntities();
            var produto = db.PRODUTO.Where(x => x.idPRODUTO == codigo).Select(x => x).First();
            db.PRODUTO.Remove(produto);
            db.SaveChanges();
        }
    }
}
