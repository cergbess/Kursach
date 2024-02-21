using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using OrganizingСoncerts_Classes;

namespace OrganizingСoncerts.DAL.Controllers

{
    [ApiController]
    [Route("/Concert")]
    public class ConcertController : ControllerBase
    {
        ApplicationContext db;
        public ConcertController(ApplicationContext context)
        {
            db = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Concert>>> Get(string? ConcertTitle, int? ArtistId, int? SceneId,int? ConcertId)
        {
            IQueryable<Concert> query = db.Concerts;
            if (!string.IsNullOrEmpty(ConcertTitle))
                query = query.Where(c => c.ConcertTitle != null && c.ConcertTitle.Contains(ConcertTitle));
            if (ArtistId != null)
                query = query.Where(c => c.ArtistId == ArtistId);
            if (SceneId != null)
                query = query.Where(c => c.SceneId == SceneId);
            if (ConcertId != null)
                query = query.Where(c => c.ConcertId == ConcertId);
            return await query.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Concert>> Post(Concert Concert)
        {
            if (Concert == null)
            {
                return BadRequest();
            }

            db.Concerts.Add(Concert);
            await db.SaveChangesAsync();
            return Ok(Concert);
        }

        [HttpPut]
        public async Task<ActionResult<Concert>> Put(Concert Concert)
        {
            if (Concert == null)
            {
                return BadRequest();
            }

            db.Update(Concert);
            await db.SaveChangesAsync();
            return Ok(Concert);
        }

        [HttpDelete]
        [Route("delete")]
        public async Task<ActionResult<Concert>> Delete(int ConcertId)
        {
            Concert Concert = db.Concerts.FirstOrDefault(x => x.ConcertId == ConcertId);
            if (Concert == null)
            {
                return NotFound();
            }
            db.Concerts.Remove(Concert);
            await db.SaveChangesAsync();
            return Ok(Concert);
        }
    }
}
