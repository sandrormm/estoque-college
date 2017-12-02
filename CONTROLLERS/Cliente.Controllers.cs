using CSA_SISTEMAS_DAO.DAO;
using System;

namespace CSA_SISTEMAS_DAO.CONTROLLERS
{
    public class Cliente
    {
        public void Validar()
        {
            var openDb = new ValidarConexao();
            var closeDb = new FecharConexao();
            openDb.AbrirConexao();
            closeDb.FechaConexao();
        }

        //***************************** CLIENTE ************************************//
        #region Clientes
        public void CadastrarCliente(int telefoneFixo, int celular, string nome, string cpf, DateTime nascimento, string email, string logradouro, int cep, int numero, string complemento,
            string referencia, string pais, string estado, string cidade, string bairro, string rua)
        {
            Validar();
            var clientesDao = new ClienteDAO();
            clientesDao.cadastrarCliente(telefoneFixo, celular, nome, cpf, nascimento, email, logradouro, cep, numero, complemento, referencia, pais, estado, cidade, bairro, rua);
        }

        public void AlterarCliente(int idCliente, int telefoneFixo, int celular, string nome, string cpf, DateTime nascimento, string email, string logradouro, int cep, int numero, string complemento,
            string referencia, string pais, string estado, string cidade, string bairro, string rua)
        {
            Validar();
            var clientesDao = new ClienteDAO();
            clientesDao.alterarCliente(idCliente, telefoneFixo, celular, nome, cpf, nascimento, email, logradouro, cep, numero, complemento, referencia, pais, estado, cidade, bairro, rua);
        }

        public void RemoverCliente(int id)
        {
            Validar();
            var clienteDao = new ClienteDAO();
            clienteDao.removerCliente(id);
        }

        public void ListarCliente(string nome)
        {
            Validar();
            var clientesDao = new ClienteDAO();
            clientesDao.listarCliente(nome);
        }
        #endregion
    }
}
