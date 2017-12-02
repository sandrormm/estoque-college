using System.Data.Entity.Infrastructure;
using System.Linq;

namespace CSA_SISTEMAS_DAO.DAO
{
    public class TelefoneDAO
    {
        public int cadastrarTelefone(int fixo, int celular)
        {
            var db = new CSA_GESTOREntities();

            try
            {
                var telefone = db.TELEFONE.Create();

                telefone.FIXO = fixo;
                telefone.CELULAR = celular;

                db.TELEFONE.Add(telefone);
                db.SaveChanges();

                return telefone.idTELEFONE;
            }
            catch (DbUpdateException ex)
            {
                throw new DbUpdateException(ex.Message);
            }
        }

        public void removerTelefone(int id)
        {
            var db = new CSA_GESTOREntities();
            var telefone = db.TELEFONE.Where(x => x.idTELEFONE == id).Select(x => x).First();
            db.TELEFONE.Remove(telefone);

            db.SaveChanges();
        }

    }
}
