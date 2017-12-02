﻿using CSA_SISTEMAS_DAO.DAO;

namespace CSA_SISTEMAS_DAO.CONTROLLERS
{
    public class Endereco
    {
        public void Validar()
        {
            var openDb = new ValidarConexao();
            var closeDb = new FecharConexao();
            openDb.AbrirConexao();
            closeDb.FechaConexao();
        }

        #region Endereco
        //***************************** ENDEREÇO ************************************//
        public void CadastrarEndereco(string logradouro, int cep, int numero,
            string complemento,
            string referencia,
            string pais = "",
            string estado = "",
            string cidade = "",
            string bairro = "",
            string rua = "")
        {
            Validar();
            var enderecoDao = new EnderecoDAO();
            enderecoDao.cadastrarEndereco(logradouro, cep, numero, complemento, referencia, pais, estado, cidade, bairro, rua);
        }
        #endregion
    }
}