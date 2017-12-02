using CSA_SISTEMAS.CLASSES;
using System.Linq;

namespace CSA_SISTEMAS_DAO.DAO
// CLASSE PERSISTENCE - PERSISTENCIA DOS DADOS
{
    public class UsuarioDAO
    {
        public void CadastrarUsuario(Usuario usuarios)
        {
            var db = new CSA_GESTOREntities();
            var usuario = db.USUARIO.Create();
            usuario.NOME_USUARIO = usuarios.Nome;
            usuario.SENHA = usuarios.Senha;
            db.USUARIO.Add(usuario);
            db.SaveChanges();
        }

        public void AlterarUsuario(USUARIO usuario)
        {
            var db = new CSA_GESTOREntities();
            var usuarios = db.USUARIO.Where(u => u.IdUSUARIO == usuario.IdUSUARIO).Select(u => u).First();
            usuarios.NOME_USUARIO = usuario.NOME_USUARIO;
            usuarios.SENHA = usuario.SENHA;
            db.SaveChanges();
        }

        public void DeletarUsuario(USUARIO usuario)
        {
            var db = new CSA_GESTOREntities();
            var usuarios = db.USUARIO.Where(u => u.IdUSUARIO == usuario.IdUSUARIO).Select(u => u).First();
            usuarios.NOME_USUARIO = usuario.NOME_USUARIO;
            usuarios.SENHA = usuario.SENHA;
            db.SaveChanges();
        }
    }
}
