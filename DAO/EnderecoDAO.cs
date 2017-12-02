using CSA_SISTEMAS.CLASSES;
using CSA_SISTEMAS_DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSA_SISTEMAS_DAO.DAO
{
    public class EnderecoDAO
    {
        public int idLogradouro { get; set; }
        public string cep { get; set; }
        public int numero { get; set; }
        public string complemento { get; set; }
        public string referencia { get; set; }

        public int cadastrarEndereco(string logradouro, int cep, int numero,
            string complemento,
            string referencia,
            string pais = "",
            string estado = "",
            string cidade = "",
            string bairro = "",
            string rua = ""
        )
        {
            var db = new CSA_GESTOREntities();
            var endereco = db.ENDERECO.Create();

            // verifica se cep ja esta cadastrado
            // se existe cep, a rua/logradouro ja existe no banco
            int logCadastrado = db.ENDERECO.Where(x => x.CEP == cep).Select(x => x.LOGRADOURO_idLOGRADOURO).FirstOrDefault();

            if (logCadastrado > 0)
            {
                endereco.LOGRADOURO_idLOGRADOURO = logCadastrado;
            }
            else
            {
                var paisObj = new PaisDAO();
                int idPaisCadastrado = paisObj.cadastrarPais(pais);

                var estadoObj = new EstadoDAO();
                int idEstadoCadastrado = estadoObj.cadastrarEstado(idPaisCadastrado, estado);

                var cidadeObj = new CidadeDAO();
                int idCidadeCadastrada = cidadeObj.cadastrarCidade(idEstadoCadastrado, cidade);

                var bairroObj = new BairroDAO();
                int bairroCadastrado = bairroObj.cadastrarBairro(idCidadeCadastrada, bairro);

                var logradouroObj = new LogradouroDAO();
                int idLogradouroCadstrado = logradouroObj.cadastrarLogradouro(bairroCadastrado, rua);

                endereco.LOGRADOURO_idLOGRADOURO = idLogradouroCadstrado;
            }

            endereco.CEP = cep;
            endereco.NUMERO = numero;
            endereco.COMPLEMENTO = complemento;
            endereco.REFERENCIA = referencia;

            db.ENDERECO.Add(endereco);
            db.SaveChanges();

            return endereco.idENDERECO;
        }
    }
}
