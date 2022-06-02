using MiCamioncito.Models;
using MiCamioncito.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiCamioncito.Aplicacion
{
    public class ConsultaCliente
    {
        public ClienteResponse GetClientes() {
            ClienteResponse respuesta = new ClienteResponse();

            try
            {
                using (Mi_camioncitoContext db = new Mi_camioncitoContext()) {
                    var listaClientes = db.Clientes.OrderByDescending(d => d.IdCliente).ToList();
                    respuesta.exito = 1;
                    respuesta.message = "Lista de clientes";
                    respuesta.clientes = listaClientes;
                }
            }
            catch (Exception ex){

                respuesta.message = ex.Message;

            }
            return respuesta;
        }
    }
}
