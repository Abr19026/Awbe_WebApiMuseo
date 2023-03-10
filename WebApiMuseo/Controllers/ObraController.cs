using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiMuseo.Entidades;

namespace WebApiMuseo.Controllers
{
    [ApiController]
    [Route("api/obras")]
    public class ObraController: Controller
    {
        private readonly ApplicationDbContext _context;

        public ObraController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("pruebas")]
        public ActionResult<List<Obra>> Get()
        {
            return new List<Obra>()
            {
                new Obra() { Id = 1, nombre = "Starry Night", descripcion = "Pintura Van Gogh", fecha_creacion = new DateTime(1890,1,1) },
                new Obra() { Id = 2, nombre = "Hamlet", descripcion = "Obra teatral", fecha_creacion = new DateTime(1600,1,1) }
            };
        }   

        [HttpPost]
        public async Task<ActionResult> Post(Obra obra)
        {
            _context.Add(obra);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult<List<Obra>>> GetObras() 
        {
            return await _context.Obras.ToListAsync();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> PutObra(Obra obra, int id)
        {
            if (id != obra.Id)
            {
                return BadRequest("La id del objeto no coincide con el parametro id");
            }
            _context.Update(obra);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteObra(int id)
        {
            var existe = await _context.Obras.AnyAsync(x => x.Id == id);

            if (!existe)
            {
                return NotFound();
            }
            
            _context.Remove(new Obra { Id = id });

            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
