using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrganizingСoncerts_Classes;

namespace OrganizingСoncerts.DAL.Controllers

{
    [ApiController]
    [Route("/Artist")]
    public class ArtistController : ControllerBase
    {
        ApplicationContext db;
        public ArtistController(ApplicationContext context)
        {
            db = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Artist>>> Get()
        {
            return await db.Artists.ToListAsync();
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<Artist>> Get(int Id)
        {
            Artist Artist = await db.Artists.FirstOrDefaultAsync(x => x.ArtistId == Id);
            if (Artist == null)
                return NotFound();
            return new ObjectResult(Artist);
        }

        [HttpPost]
        public async Task<ActionResult<Artist>> Post(Artist Artist)
        {
            if (Artist == null)
            {
                return BadRequest();
            }

            db.Artists.Add(Artist);
            await db.SaveChangesAsync();
            return Ok(Artist);
        }

        [HttpPut]
        public async Task<ActionResult<Artist>> Put(Artist Artist)
        {
            if (Artist == null)
            {
                return BadRequest();
            }

            db.Update(Artist);
            await db.SaveChangesAsync();
            return Ok(Artist);
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<Artist>> Delete(int Id)
        {
            Artist Artist = db.Artists.FirstOrDefault(x => x.ArtistId == Id);
            if (Artist == null)
            {
                return NotFound();
            }
            db.Artists.Remove(Artist);
            await db.SaveChangesAsync();
            return Ok(Artist);
        }
    }
}