using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrganizingСoncerts_Classes;

namespace OrganizingСoncerts.DAL.Controllers

{
    [ApiController]
    [Route("/InvolvementOfConcertEmployee")]
    public class InvolvementOfConcertEmployeeController : ControllerBase
    {
        ApplicationContext db;
        public InvolvementOfConcertEmployeeController(ApplicationContext context)
        {
            db = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<InvolvementOfConcertEmployee>>> Get()
        {
            return await db.InvolvementOfConcertEmployees.ToListAsync();
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<InvolvementOfConcertEmployee>> Get(int Id)
        {
            InvolvementOfConcertEmployee InvolvementOfConcertEmployee = await db.InvolvementOfConcertEmployees.FirstOrDefaultAsync(x => x.InvolvementOfConcertEmployeeId == Id);
            if (InvolvementOfConcertEmployee == null)
                return NotFound();
            return new ObjectResult(InvolvementOfConcertEmployee);
        }

        [HttpPost]
        public async Task<ActionResult<InvolvementOfConcertEmployee>> Post(InvolvementOfConcertEmployee InvolvementOfConcertEmployee)
        {
            if (InvolvementOfConcertEmployee == null)
            {
                return BadRequest();
            }

            db.InvolvementOfConcertEmployees.Add(InvolvementOfConcertEmployee);
            await db.SaveChangesAsync();
            return Ok(InvolvementOfConcertEmployee);
        }

        [HttpPut]
        public async Task<ActionResult<InvolvementOfConcertEmployee>> Put(InvolvementOfConcertEmployee InvolvementOfConcertEmployee)
        {
            if (InvolvementOfConcertEmployee == null)
            {
                return BadRequest();
            }

            db.Update(InvolvementOfConcertEmployee);
            await db.SaveChangesAsync();
            return Ok(InvolvementOfConcertEmployee);
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<InvolvementOfConcertEmployee>> Delete(int Id)
        {
            InvolvementOfConcertEmployee InvolvementOfConcertEmployee = db.InvolvementOfConcertEmployees.FirstOrDefault(x => x.InvolvementOfConcertEmployeeId == Id);
            if (InvolvementOfConcertEmployee == null)
            {
                return NotFound();
            }
            db.InvolvementOfConcertEmployees.Remove(InvolvementOfConcertEmployee);
            await db.SaveChangesAsync();
            return Ok(InvolvementOfConcertEmployee);
        }
    }
}
