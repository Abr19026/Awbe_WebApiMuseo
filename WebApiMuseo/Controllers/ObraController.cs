using Microsoft.AspNetCore.Mvc;
using WebApiMuseo.Entidades;

namespace WebApiMuseo.Controllers
{
    [ApiController]
    [Route("api/obras")]
    public class ObraController: Controller
    {
        public ActionResult<List<Obra>> Get()
        {
            return new List<Obra>()
            {
                new Obra() { Id = 1, Nombre = "Van Gogh", Descripcion = "Pinturas Van Gogh", fecha_creacion = new DateOnly(2022,1,1) },
                new Obra() { Id = 2, Nombre = "Hamlet", Descripcion = "Obra teatral", fecha_creacion = new DateOnly(2021,3,3) }
            };
        }
    }
}
