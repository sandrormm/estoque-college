using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueConsole
{
    class Telefone
    {
        public int cadastrarTelefone(int fixo, int celular)
        {
            var db = new estoqueEntities();

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
            var db = new estoqueEntities();
            var telefone = db.TELEFONE.Where(x => x.idTELEFONE == id).Select(x => x).First();
            db.TELEFONE.Remove(telefone);

            db.SaveChanges();
        }
    }
}

