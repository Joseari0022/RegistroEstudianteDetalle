using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estudiantes
    {
        [Key]
        public int EstudianteId { get; set; }
        public string Nombres { get; set; }

        public virtual List<Grupos> Grupos { get; set; }
        public Estudiantes()
        {
            this.Grupos = new List<Grupos>();
        }

        public Estudiantes(int estudianteid,string nombres)
        {
            this.EstudianteId = estudianteid;
            this.Nombres = nombres;
            this.Grupos = new List<Grupos>();
        }
    }
}
