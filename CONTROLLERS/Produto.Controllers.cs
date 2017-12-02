using CSA_SISTEMAS_DAO.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSA_SISTEMAS_DAO.CONTROLLERS
{
    public class Produto
    {

        //***************************** PRODUTO ************************************//
        #region Produto
        public void cadastrarproduto(string nome, int codbarras, int grupos, string unidade)
        {
                var prodDao = new ProdutoDAO();
                prodDao.cadastrarProduto(nome, codbarras, grupos, unidade);
        }

        public void AlterarProduto(int codigo, string nome, int codBarras, int grupo, string unidade)
        {
                var proDao = new ProdutoDAO();
                proDao.alterarProduto(codigo, nome, codBarras, grupo, unidade);
        }

        public void ExcluirProduto(int codigo)
        {
                var proDao = new ProdutoDAO();
                proDao.removerProduto(codigo);
        }
        #endregion
    }
}
