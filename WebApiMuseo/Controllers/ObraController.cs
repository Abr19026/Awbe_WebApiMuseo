using Microsoft.AspNetCore.Mvc;
using WebApiMuseo.Entidades;

namespace WebApiMuseo.Controllers
{
    [ApiController]
    [Route("api/obras")]
    public class ObraController: Controller
    {
        [HttpGet]
        public ActionResult<List<Obra>> Get()
        {
            return new List<Obra>()
            {
                new Obra() { Id = 1, nombre = "Starry Night", descripcion = "Pintura Van Gogh", fecha_creacion = new DateTime(1890,1,1) },
                new Obra() { Id = 2, nombre = "Hamlet", descripcion = "Obra teatral", fecha_creacion = new DateTime(1600,1,1) }
            };
        }
    }
}
