using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueConsole
{
    class Fornecedor
    {
        public int id { get; set; }
        public int idTelefone { get; set; }
        public int idEndereco { get; set; }
        public string razaoSocial { get; set; }
        public string fantasia { get; set; }
        public int cnpj { get; set; }
        public int inscricaoEstadual { get; set; }
        public string email { get; set; }

        public void cadastrarFornecedor(
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
            string rua
        )
        {
            var db = new estoqueEntities();

            Telefone telefoneObj = new Telefone();
            int telefone = telefoneObj.cadastrarTelefone(telefoneFixo, celular);

            Endereco enderecoObj = new Endereco();
            int endereco = enderecoObj.cadastrarEndereco(logradouro, cep, numero, complemento,
                referencia, pais, estado, cidade, bairro, rua);

            var fornecedor = db.FORNECEDOR.Create();
            fornecedor.TELEFONE_idTELEFONE = telefone;
            fornecedor.ENDERECO_idENDERECO = endereco;
            fornecedor.RAZAO_SOCIAL = razaoSocial;
            fornecedor.NOME_FANTASIA = fantasia;
            fornecedor.CNPJ = cnpj;
            fornecedor.IE = inscricaoEstadual;
            fornecedor.EMAIL = email;

            db.FORNECEDOR.Add(fornecedor);
            db.SaveChanges();
        }

        public void alterarFornecedor(
            int idFornecedor,
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
            string rua
        )
        {
            var db = new estoqueEntities();

            Telefone telefoneObj = new Telefone();
            int telefone = telefoneObj.cadastrarTelefone(telefoneFixo, celular);

            Endereco enderecoObj = new Endereco();
            int endereco = enderecoObj.cadastrarEndereco(logradouro, cep, numero, complemento,
                referencia, pais, estado, cidade, bairro, rua);

            var fornecedor = db.FORNECEDOR.Where(x => x.idFORNECEDOR == idFornecedor).Select(x => x).First();

            fornecedor.TELEFONE_idTELEFONE = telefone;
            fornecedor.ENDERECO_idENDERECO = endereco;
            fornecedor.RAZAO_SOCIAL = razaoSocial;
            fornecedor.NOME_FANTASIA = fantasia;
            fornecedor.CNPJ = cnpj;
            fornecedor.IE = inscricaoEstadual;
            fornecedor.EMAIL = email;

            db.SaveChanges();
        }

        public void removerFornecedor(int id)
        {
            var db = new estoqueEntities();
            var fornecedor = db.FORNECEDOR.Where(x => x.idFORNECEDOR == id).Select(x => x).First();
            db.FORNECEDOR.Remove(fornecedor);

            db.SaveChanges();
        }

        public List<Fornecedor> listarFornecedores()
        {
            var db = new estoqueEntities();

            List<Fornecedor> fornecedores = new List<Fornecedor>();

            fornecedores = db.FORNECEDOR.Select(x => new Fornecedor
            {
                id = x.idFORNECEDOR,
                idTelefone = x.TELEFONE_idTELEFONE,
                idEndereco = x.ENDERECO_idENDERECO,
                razaoSocial = x.RAZAO_SOCIAL,
                fantasia = x.NOME_FANTASIA,
                cnpj = x.CNPJ,
                inscricaoEstadual = x.IE,
                email = x.EMAIL
            }).ToList();

            return fornecedores;
        }

        public Fornecedor listarFornecedor(string fantasia)
        {
            var db = new estoqueEntities();

            var fornecedor = db.FORNECEDOR.Where(x => x.NOME_FANTASIA == fantasia)
            .Select(x => new Fornecedor
            {
                id = x.idFORNECEDOR,
                idTelefone = x.TELEFONE_idTELEFONE,
                idEndereco = x.ENDERECO_idENDERECO,
                razaoSocial = x.RAZAO_SOCIAL,
                fantasia = x.NOME_FANTASIA,
                cnpj = x.CNPJ,
                inscricaoEstadual = x.IE,
                email = x.EMAIL
            }).First();

            return fornecedor;
        }
    }
}

