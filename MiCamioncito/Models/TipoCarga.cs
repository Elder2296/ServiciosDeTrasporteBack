using System;
using System.Collections.Generic;

#nullable disable

namespace MiCamioncito.Models
{
    public partial class TipoCarga
    {
        public TipoCarga()
        {
            Vehiculos = new HashSet<Vehiculo>();
        }

        public int IdCarga { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Vehiculo> Vehiculos { get; set; }
    }
}
