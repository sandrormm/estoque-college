using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueConsole.CONTROLLERS
{
    public class Produto
    {

        #region Produto
        public void CadastrarProduto(string nome, int codbarras, int grupos, string unidade)
        {
                var prod = new Produto();
                prod.cadastrarProduto(nome, codbarras, grupos, unidade);
        }

        public void AlterarProduto(int codigo, string nome, int codBarras, int grupo, string unidade)
        {
                var prod = new Produto();
                prod.alterarProduto(codigo, nome, codBarras, grupo, unidade);
        }

        public void ExcluirProduto(int codigo)
        {
                var prod = new Produto();
                prod.removerProduto(codigo);
        }
        #endregion
    }
}
