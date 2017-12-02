using CSA_SISTEMAS_DAO.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSA_SISTEMAS_DAO.CONTROLLERS
{
   public class Fornecedor
    {
        public void Validar()
        {
            var openDb = new ValidarConexao();
            var closeDb = new FecharConexao();
            openDb.AbrirConexao();
            closeDb.FechaConexao();
        }

        //***************************** FORNECEDOR ************************************//
        #region Fornecedor
        public void CadastrarFornecedor(int telefoneFixo, int celular, string razaoSocial, string fantasia, int cnpj, int inscricaoEstadual, string email, string logradouro,
            int cep, int numero, string complemento, string referencia, string pais, string estado, string cidade, string bairro, string rua)
        {
            try
            {
                Validar();
                var fornecedorDAO = new FornecedorDAO();
                fornecedorDAO.cadastrarFornecedor(telefoneFixo, celular, razaoSocial, fantasia, cnpj, inscricaoEstadual, email, logradouro,
                cep, numero, complemento, referencia, pais, estado, cidade, bairro, rua);
            }
            finally
            {
                Validar();
            }
        }

        public void AlterarFornecedor(int idFornecedor,
            int telefoneFixo,
            int celular,
            string razaoSocial,
            string fantasia,
            int cnpj,
            int inscricaoEstadual,
            string email,
            string logradouro,
            int cep,
            int numero,
            string complemento,
            string referencia,
            string pais,
            string estado,
            string cidade,
            string bairro,
            string rua)
        {
            try
            {
                Validar();
                var fornecedorDao = new FornecedorDAO();
                fornecedorDao.alterarFornecedor(idFornecedor, telefoneFixo, celular, razaoSocial, fantasia, cnpj, inscricaoEstadual, email, logradouro, cep,
                numero, complemento, referencia, pais, estado, cidade, bairro, rua);
            }
            finally
            {
                Validar();
            }
        }

        public void removerFornecedor(int id)
        {
            try
            {
                Validar();
                var fornecedorDao = new FornecedorDAO();
                fornecedorDao.removerFornecedor(id);
            }
            finally
            {
                Validar();
            }
        }

        public void Listarfornecedor(string fantasia)
        {
            try
            {
                Validar();
                var fornecedorDao = new FornecedorDAO();
                fornecedorDao.listarFornecedor(fantasia);
            }
            finally
            {
                Validar();
            }
        }
        #endregion
    }
}
