using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiMuseo.Entidades;

namespace WebApiMuseo.Controllers
{
    [ApiController]
    [Route("api/exposiciones")]
    public class ExposicionController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ExposicionController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Exposicion>>> GetExposiciones() {
            return await _context.Exposiciones.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult> PostExpo(Exposicion exposicion)
        {
            _context.Add(exposicion);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> PutExpo(Exposicion exposicion, int id)
        {
            if(id != exposicion.Id)
            {
                return BadRequest("La id del objeto no coincide con el parametro id");
            }
            _context.Update(exposicion);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteExpo(int id)
        {
            var existe = await _context.Exposiciones.AnyAsync(x => x.Id == id);

            if(!existe)
            {
                return NotFound();
            }

            _context.Remove(new Exposicion { Id = id });

            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
