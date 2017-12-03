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
        public void CadastrarEndereco(string logradouro, int cep, int numero,
            string complemento,
            string referencia,
            string pais = "",
            string estado = "",
            string cidade = "",
            string bairro = "",
            string rua = "")
        {
            var endereco = new Endereco();
            endereco.cadastrarEndereco(logradouro, cep, numero, complemento, referencia, pais, estado, cidade, bairro, rua);
        }
        #endregion
    }
}
