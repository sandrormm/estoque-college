using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueConsole.CONTROLLERS
{
    public class Estoque
    {
       
        //***************************** ESTOQUE ************************************//
        #region Estoque
        public void CadastrarEstoque(int idProduto, int saldo = 0)
        {
                var Estoquedao = new EstoqueDAO();
                Estoquedao.cadastrarEstoque(idProduto, saldo);
        }

        public void atualizarEstoque(int idProduto, int quantidade, bool operacao)
        {
                var estoquedao = new EstoqueDAO();
                estoquedao.atualizarEstoque(idProduto, quantidade, operacao);
        }

        public void removerEstoque(int idProduto)
        {
                var estoquedao = new EstoqueDAO();
                estoquedao.removerEstoque(idProduto);
        }
        #endregion
    }
}
