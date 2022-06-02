using MiCamioncito.Aplicacion;
using MiCamioncito.Models.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiCamioncito.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {

        private readonly ConsultaCliente _consulta;
        public ClienteController() {
            _consulta = new ConsultaCliente();
        }
        [HttpGet]
        public IActionResult Get() {
            return Ok(_consulta.GetClientes());
        }
    }
}
