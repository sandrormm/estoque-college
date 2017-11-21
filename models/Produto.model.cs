using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueConsole
{
    class Produto
    {
        public int    id        { get; set; }
        public string nome      { get; set; }
        public int    codBarras { get; set; }
        public int    grupo     { get; set; }
        public string unidade   { get; set; }

        public List<Produto> listarProdutos()
        {
            var db = new estoqueEntities();

            List<Produto> produtos = new List<Produto>();

            produtos = db.PRODUTO.Select(x => new Produto
            {
                id = x.idPRODUTO,
                nome = x.NOME_PROD,
                codBarras = x.COD_BARRAS,
                grupo = x.GRUPO,
                unidade = x.UN
            }).ToList();

            return produtos;
        }

        public Produto listarProduto(string nome)
        {
            var db = new estoqueEntities();

            var produto = db.PRODUTO.Where(x => x.NOME_PROD == nome).Select(x => new Produto
            {
                id = x.idPRODUTO,
                nome = x.NOME_PROD,
                codBarras = x.COD_BARRAS,
                grupo = x.GRUPO,
                unidade = x.UN
            }).First();

            return produto;
        }

        public void cadastrarProduto(string nome, int codBarras, int grupo, string unidade)
        {
            var db = new estoqueEntities();

            var produto = db.PRODUTO.Create();
            produto.NOME_PROD = nome;
            produto.COD_BARRAS = codBarras;
            produto.GRUPO = grupo;
            produto.UN = unidade;

            db.PRODUTO.Add(produto);
            db.SaveChanges();
        }

        public void alterarProduto(int codigo, string nome, int codBarras, int grupo, string unidade)
        {
            var db = new estoqueEntities();

            var produto = db.PRODUTO.Where(x => x.idPRODUTO == codigo).Select(x => x).First();

            produto.NOME_PROD = nome;
            produto.COD_BARRAS = codBarras;
            produto.GRUPO = grupo;
            produto.UN = unidade;

            db.SaveChanges();
        }

        public void removerProduto(int codigo)
        {
            var db = new estoqueEntities();
            var produto = db.PRODUTO.Where(x => x.idPRODUTO == codigo).Select(x => x).First();
            db.PRODUTO.Remove(produto);

            db.SaveChanges();
        }
    }
}
