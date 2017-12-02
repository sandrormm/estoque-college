using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueConsole.CONTROLLERS
{
   public class Fornecedor
    {
        //***************************** FORNECEDOR ************************************//
        #region Fornecedor
        public void CadastrarFornecedor(int telefoneFixo, int celular, string razaoSocial, string fantasia, int cnpj, int inscricaoEstadual, string email, string logradouro,
            int cep, int numero, string complemento, string referencia, string pais, string estado, string cidade, string bairro, string rua)
        {
                var fornecedorDAO = new FornecedorDAO();
                fornecedorDAO.cadastrarFornecedor(telefoneFixo, celular, razaoSocial, fantasia, cnpj, inscricaoEstadual, email, logradouro,
                cep, numero, complemento, referencia, pais, estado, cidade, bairro, rua);
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
                var fornecedorDao = new FornecedorDAO();
                fornecedorDao.alterarFornecedor(idFornecedor, telefoneFixo, celular, razaoSocial, fantasia, cnpj, inscricaoEstadual, email, logradouro, cep,
                numero, complemento, referencia, pais, estado, cidade, bairro, rua);
        }

        public void removerFornecedor(int id)
        {
                var fornecedorDao = new FornecedorDAO();
                fornecedorDao.removerFornecedor(id);
        }

        public void Listarfornecedor(string fantasia)
        {
                var fornecedorDao = new FornecedorDAO();
                fornecedorDao.listarFornecedor(fantasia);
        }
        #endregion
    }
}
