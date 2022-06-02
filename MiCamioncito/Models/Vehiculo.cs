using System;
using System.Collections.Generic;

#nullable disable

namespace MiCamioncito.Models
{
    public partial class Vehiculo
    {
        public int IdVehiculo { get; set; }
        public decimal ConsumoKm { get; set; }
        public decimal Capacidad { get; set; }
        public long IdUltimaUbicacion { get; set; }
        public int TipoCarga { get; set; }

        public virtual Ubicacion IdUltimaUbicacionNavigation { get; set; }
        public virtual TipoCarga TipoCargaNavigation { get; set; }
    }
}
