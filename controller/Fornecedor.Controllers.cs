using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueConsole.CONTROLLERS
{
   public class Fornecedor
    {
        #region Fornecedor
        public void CadastrarFornecedor(int telefoneFixo, int celular, string razaoSocial, string fantasia, int cnpj, int inscricaoEstadual, string email, string logradouro,
            int cep, int numero, string complemento, string referencia, string pais, string estado, string cidade, string bairro, string rua)
        {
                var fornecedor = new Fornecedor();
                fornecedor.cadastrarFornecedor(telefoneFixo, celular, razaoSocial, fantasia, cnpj, inscricaoEstadual, email, logradouro,
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
                var fornecedor = new Fornecedor();
                fornecedor.alterarFornecedor(idFornecedor, telefoneFixo, celular, razaoSocial, fantasia, cnpj, inscricaoEstadual, email, logradouro, cep,
                numero, complemento, referencia, pais, estado, cidade, bairro, rua);
        }

        public void RemoverFornecedor(int id)
        {
                var fornecedor = new Fornecedor();
                fornecedor.removerFornecedor(id);
        }

        public void Listarfornecedor(string fantasia)
        {
                var fornecedor = new Fornecedor();
                fornecedor.listarFornecedor(fantasia);
        }
        #endregion
    }
}
