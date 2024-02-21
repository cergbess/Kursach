using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrganizingСoncerts_Classes;

namespace OrganizingСoncerts.DAL.Controllers

{
    [ApiController]
    [Route("/TechRider")]
    public class TechRiderController : ControllerBase
    {
        ApplicationContext db;
        public TechRiderController(ApplicationContext context)
        {
            db = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TechRider>>> Get()
        {
            return await db.TechRiders.ToListAsync();
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<TechRider>> Get(int Id)
        {
            TechRider TechRider = await db.TechRiders.FirstOrDefaultAsync(x => x.TechRiderId == Id);
            if (TechRider == null)
                return NotFound();
            return new ObjectResult(TechRider);
        }

        [HttpPost]
        public async Task<ActionResult<TechRider>> Post(TechRider TechRider)
        {
            if (TechRider == null)
            {
                return BadRequest();
            }

            db.TechRiders.Add(TechRider);
            await db.SaveChangesAsync();
            return Ok(TechRider);
        }

        [HttpPut]
        public async Task<ActionResult<TechRider>> Put(TechRider TechRider)
        {
            if (TechRider == null)
            {
                return BadRequest();
            }

            db.Update(TechRider);
            await db.SaveChangesAsync();
            return Ok(TechRider);
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<TechRider>> Delete(int Id)
        {
            TechRider TechRider = db.TechRiders.FirstOrDefault(x => x.TechRiderId == Id);
            if (TechRider == null)
            {
                return NotFound();
            }
            db.TechRiders.Remove(TechRider);
            await db.SaveChangesAsync();
            return Ok(TechRider);
        }
    }
}