using CSA_SISTEMAS_DAO.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSA_SISTEMAS_DAO.CONTROLLERS
{
    public class Estoque
    {
        public void Validar()
        {
            var openDb = new ValidarConexao();
            var closeDb = new FecharConexao();
            openDb.AbrirConexao();
            closeDb.FechaConexao();
        }

        //***************************** ESTOQUE ************************************//
        #region Estoque
        public void CadastrarEstoque(int idProduto, int saldo = 0)
        {
            try
            {
                Validar();
                var Estoquedao = new EstoqueDAO();
                Estoquedao.cadastrarEstoque(idProduto, saldo);
            }
            finally
            {
                Validar();
            }
        }

        public void atualizarEstoque(int idProduto, int quantidade, bool operacao)
        {
            try
            {
                Validar();
                var estoquedao = new EstoqueDAO();
                estoquedao.atualizarEstoque(idProduto, quantidade, operacao);
            }
            finally
            {
                Validar();
            }
        }

        public void removerEstoque(int idProduto)
        {
            try
            {
                Validar();
                var estoquedao = new EstoqueDAO();
                estoquedao.removerEstoque(idProduto);
            }
            finally
            {
                Validar();
            }
        }
        #endregion
    }
}
