using System;
using System.Collections.Generic;

#nullable disable

namespace MiCamioncito.Models
{
    public partial class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dpi { get; set; }
        public string Nit { get; set; }
        public string TelefonoDomiciliar { get; set; }
        public string TelefonoPersonal { get; set; }
        public string CorreoElectronico { get; set; }
    }
}
