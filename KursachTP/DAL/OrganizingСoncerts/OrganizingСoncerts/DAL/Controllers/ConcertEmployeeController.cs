using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrganizingСoncerts_Classes;

namespace OrganizingСoncerts.DAL.Controllers

{
    [ApiController]
    [Route("/ConcertEmployee")]
    public class ConcertEmployeeController : ControllerBase
    {
        ApplicationContext db;
        public ConcertEmployeeController(ApplicationContext context)
        {
            db = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ConcertEmployee>>> Get()
        {
            return await db.ConcertEmployees.ToListAsync();
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<ConcertEmployee>> Get(int Id)
        {
            ConcertEmployee ConcertEmployee = await db.ConcertEmployees.FirstOrDefaultAsync(x => x.ConcertEmployeeId == Id);
            if (ConcertEmployee == null)
                return NotFound();
            return new ObjectResult(ConcertEmployee);
        }

        [HttpPost]
        public async Task<ActionResult<ConcertEmployee>> Post(ConcertEmployee ConcertEmployee)
        {
            if (ConcertEmployee == null)
            {
                return BadRequest();
            }

            db.ConcertEmployees.Add(ConcertEmployee);
            await db.SaveChangesAsync();
            return Ok(ConcertEmployee);
        }

        [HttpPut]
        public async Task<ActionResult<ConcertEmployee>> Put(ConcertEmployee ConcertEmployee)
        {
            if (ConcertEmployee == null)
            {
                return BadRequest();
            }

            db.Update(ConcertEmployee);
            await db.SaveChangesAsync();
            return Ok(ConcertEmployee);
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<ConcertEmployee>> Delete(int Id)
        {
            ConcertEmployee ConcertEmployee = db.ConcertEmployees.FirstOrDefault(x => x.ConcertEmployeeId == Id);
            if (ConcertEmployee == null)
            {
                return NotFound();
            }
            db.ConcertEmployees.Remove(ConcertEmployee);
            await db.SaveChangesAsync();
            return Ok(ConcertEmployee);
        }
    }
}
