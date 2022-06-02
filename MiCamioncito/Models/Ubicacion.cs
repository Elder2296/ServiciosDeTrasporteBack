using System;
using System.Collections.Generic;

#nullable disable

namespace MiCamioncito.Models
{
    public partial class Ubicacion
    {
        public Ubicacion()
        {
            Vehiculos = new HashSet<Vehiculo>();
        }

        public long IdUbicacion { get; set; }
        public int IdDepartamento { get; set; }
        public int IdMunicipio { get; set; }
        public string Direccion { get; set; }

        public virtual Departament IdDepartamentoNavigation { get; set; }
        public virtual ICollection<Vehiculo> Vehiculos { get; set; }
    }
}
