using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueConsole
{
    class Estoque
    {
        public void cadastrarEstoque(int idProduto, int saldo = 0)
        {
            var db = new estoqueEntities();

            var estoque = db.ESTOQUE.Create();

            estoque.PRODUTO_idPRODUTO = idProduto;
            estoque.SALDO = saldo;

            db.ESTOQUE.Add(estoque);
            db.SaveChanges();
        }

        public void atualizarEstoque(int idProduto, int quantidade, bool operacao)
        {
            var db = new estoqueEntities();

            var estoque = db.ESTOQUE.Where(x => x.PRODUTO_idPRODUTO == idProduto).Select(x => x).First();

            if (operacao)
            {
                estoque.SALDO = estoque.SALDO + quantidade;
            } else
            {
                estoque.SALDO = estoque.SALDO - quantidade;
            }

            db.SaveChanges();
        }

        public void removerEstoque(int idProduto)
        {
            var db = new estoqueEntities();
            var estoque = db.ESTOQUE.Where(x => x.PRODUTO_idPRODUTO == idProduto).Select(x => x).First();
            db.ESTOQUE.Remove(estoque);

            db.SaveChanges();
        }
    }
}

