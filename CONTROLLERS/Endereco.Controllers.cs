using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueConsole.CONTROLLERS
{
    public class Endereco
    {
       
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
            var enderecoDao = new EnderecoDAO();
            enderecoDao.cadastrarEndereco(logradouro, cep, numero, complemento, referencia, pais, estado, cidade, bairro, rua);
        }
        #endregion
    }
}
