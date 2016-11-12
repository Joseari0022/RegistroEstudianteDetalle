using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;
namespace BLL
{
    public class EstudianteBll
    {
        public static bool Guardar(Estudiantes es)
        {
            bool re = false;
            try
            {
                SistemaGrupoDb db = new SistemaGrupoDb();

                db.Estudiantes.Add(es);
                db.SaveChanges();
                db.Dispose();
                re = true;
            }catch(Exception ex)
            {
                throw ex;
            }
            return re;
        }

        public static Estudiantes Buscar(int id)
        {
            Estudiantes estudiante = new Estudiantes();
            var db = new SistemaGrupoDb();
            return estudiante = db.Estudiantes.Find(id);
        }

        public static void Eliminar(int id)
        {
            var db = new SistemaGrupoDb();
            Estudiantes es = db.Estudiantes.Find(id);

            db.Estudiantes.Remove(es);
            db.SaveChanges();
        }

        public static List<Estudiantes> GetLista()
        {
            var lista = new List<Estudiantes>();
            var db = new SistemaGrupoDb();
            lista = db.Estudiantes.ToList();
            return lista;
        }

        public static List<Estudiantes> GetListaNombre(string aux)
        {
            List<Estudiantes> lista = new List<Estudiantes>();
            var db = new SistemaGrupoDb();
            lista = db.Estudiantes.Where(p => p.Nombres == aux).ToList();
            return lista;
        }
    }
}
