using System;
using System.Collections.Generic;

#nullable disable

namespace MiCamioncito.Models
{
    public partial class Departament
    {
        public Departament()
        {
            Munis = new HashSet<Muni>();
            Ubicacions = new HashSet<Ubicacion>();
        }

        public int IdDepartamento { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Muni> Munis { get; set; }
        public virtual ICollection<Ubicacion> Ubicacions { get; set; }
    }
}
