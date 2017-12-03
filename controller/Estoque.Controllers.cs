using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueConsole.CONTROLLERS
{
    public class Estoque
    {
       
        #region Estoque
        public void CadastrarEstoque(int idProduto, int saldo = 0)
        {
                var estoque = new Estoque();
                estoque.cadastrarEstoque(idProduto, saldo);
        }

        public void AtualizarEstoque(int idProduto, int quantidade, bool operacao)
        {
                var estoque = new Estoque();
                estoque.atualizarEstoque(idProduto, quantidade, operacao);
        }

        public void RemoverEstoque(int idProduto)
        {
                var estoque = new Estoque();
                estoque.removerEstoque(idProduto);
        }
        #endregion
    }
}
