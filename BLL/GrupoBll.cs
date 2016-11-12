using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;
using System.Data.Entity;

namespace BLL
{
    public class GrupoBll
    {
        public static bool Guardar(Grupos gr)
        {
            bool re = false;
            try
            {
                var db = new SistemaGrupoDb();

                db.Grupos.Add(gr);
                var gp = db.Grupos.Add(gr);
                foreach(var estud in gr.Estudiantes)
                {
                    db.Entry(estud).State = EntityState.Unchanged;
                }
                db.SaveChanges();
                db.Dispose();
                re = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return re;
        }

        public static Grupos Buscar(int id)
        {
            Grupos grupo = new Grupos();
            var db = new SistemaGrupoDb();
            return grupo = db.Grupos.Find(id);
        }

        public static void Eliminar(int id)
        {
            var db = new SistemaGrupoDb();
            Grupos gr = db.Grupos.Find(id);

            db.Grupos.Remove(gr);
            db.SaveChanges();
        }

        public static List<Grupos> GetLista()
        {
            var lista = new List<Grupos>();
            var db = new SistemaGrupoDb();
            lista = db.Grupos.ToList();
            return lista;
        }

        public static List<Grupos> GetListaNombre(string aux)
        {
            List<Grupos> lista = new List<Grupos>();
            var db = new SistemaGrupoDb();
            lista = db.Grupos.Where(p => p.Nombres == aux).ToList();
            return lista;
        }
    }
}
