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
        public void Validar()
        {
            var openDb = new ValidarConexao();
            var closeDb = new FecharConexao();
            openDb.AbrirConexao();
            closeDb.FechaConexao();
        }

        //***************************** PRODUTO ************************************//
        #region Produto
        public void cadastrarproduto(string nome, int codbarras, int grupos, string unidade)
        {
            try
            {
                Validar();
                var prodDao = new ProdutoDAO();
                prodDao.cadastrarProduto(nome, codbarras, grupos, unidade);
            }
            finally
            {
                Validar();
            }
        }

        public void AlterarProduto(int codigo, string nome, int codBarras, int grupo, string unidade)
        {
            try
            {
                Validar();
                var proDao = new ProdutoDAO();
                proDao.alterarProduto(codigo, nome, codBarras, grupo, unidade);
            }
            finally
            {
                Validar();
            }
        }

        public void ExcluirProduto(int codigo)
        {
            try
            {
                Validar();
                var proDao = new ProdutoDAO();
                proDao.removerProduto(codigo);
            }
            finally
            {
                Validar();
            }
        }
        #endregion
    }
}
