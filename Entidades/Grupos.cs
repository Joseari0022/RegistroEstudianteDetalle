using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Grupos
    {
        [Key]
        public int GrupoId { get; set; }
        public string Nombres { get; set; }

        public virtual List<Estudiantes> Estudiantes { get; set; }
        public Grupos()
        {
            this.Estudiantes = new List<Estudiantes>();
        }

        public Grupos(int grupoid,string nombres)
        {
            this.GrupoId = grupoid;
            this.Nombres = nombres;
            this.Estudiantes = new List<Estudiantes>();
        }
    }
}
