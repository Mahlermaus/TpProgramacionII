
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;

using Newtonsoft.Json;
using FacturacionBackend.servicio.implementaciones;
using FacturacionBackend.dominio;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicioController : ControllerBase
    {
        private IFacturaService app;

        public ServicioController()
        {
            app = new FacturaService(new DaoFactory());

        }

        [HttpGet("cargar_articulos")]
        public IActionResult GetArticulos()
        {
            string JSONresult;
            JSONresult = JsonConvert.SerializeObject(app.CargarArticulos());
            return Ok(JSONresult);
        }
        [HttpGet("cargar_clientes")]
        public IActionResult GetClientes()
        {
            string JSONresult;
            JSONresult = JsonConvert.SerializeObject(app.CargarClientes());
            return Ok(JSONresult);
        }

        [HttpGet("cargar_forma_pago")]
        public IActionResult GetFormaPago()
        {
            string JSONresult;
            JSONresult = JsonConvert.SerializeObject(app.CargarFormasPago());
            return Ok(JSONresult);
        }


        [HttpPost("articulo_nuevo")]
        public IActionResult PostArticulo(Articulo oArticulo)
        {
            if (oArticulo == null)
            {
                return BadRequest("Articulo null");
            }

            if (app.GuardarArticulo(oArticulo))
                return Ok("Se guardo el articulo");
            else
                return BadRequest("No se pudo grabar el artículo");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteArticulo(int id)
        {
            if (id == 0)
            {
                return BadRequest("Id es requerido");
            }
            else 
            { 
                return Ok(app.EliminarArticulo(id)); 
            }
        }


    }

}
