using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiCamioncito.Models.Request
{
    public class ClienteResponse
    {
        public int exito { get; set; }
        public string message { get; set; }
        public object clientes { get; set; }

        public ClienteResponse() { this.exito = 0; }
    }
}
