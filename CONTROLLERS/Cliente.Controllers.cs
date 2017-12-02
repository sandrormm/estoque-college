using CSA_SISTEMAS_DAO.DAO;
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueConsole.CONTROLLERS
{
    public class Cliente
    {
       
        #region Clientes
        public void CadastrarCliente(int telefoneFixo, int celular, string nome, string cpf, DateTime nascimento, string email, string logradouro, int cep, int numero, string complemento,
            string referencia, string pais, string estado, string cidade, string bairro, string rua)
        {
            var clientes = new Cliente();
            clientes.cadastrarCliente(telefoneFixo, celular, nome, cpf, nascimento, email, logradouro, cep, numero, complemento, referencia, pais, estado, cidade, bairro, rua);
        }

        public void AlterarCliente(int idCliente, int telefoneFixo, int celular, string nome, string cpf, DateTime nascimento, string email, string logradouro, int cep, int numero, string complemento,
            string referencia, string pais, string estado, string cidade, string bairro, string rua)
        {
            var clientes = new Cliente();
            clientes.alterarCliente(idCliente, telefoneFixo, celular, nome, cpf, nascimento, email, logradouro, cep, numero, complemento, referencia, pais, estado, cidade, bairro, rua);
        }

        public void RemoverCliente(int id)
        {
            var cliente = new Cliente();
            cliente.removerCliente(id);
        }

        public void ListarCliente(string nome)
        {
            var clientes = new Cliente();
            clientes.listarCliente(nome);
        }
        #endregion
    }
}
