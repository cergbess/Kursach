using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrganizingСoncerts_Classes;

namespace OrganizingСoncerts.DAL.Controllers

{
    [ApiController]
    [Route("/Equipment")]
    public class EquipmentController : ControllerBase
    {
        ApplicationContext db;
        public EquipmentController(ApplicationContext context)
        {
            db = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Equipment>>> Get()
        {
            return await db.Equipments.ToListAsync();
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<Equipment>> Get(int Id)
        {
            Equipment Equipment = await db.Equipments.FirstOrDefaultAsync(x => x.EquipmentId == Id);
            if (Equipment == null)
                return NotFound();
            return new ObjectResult(Equipment);
        }

        [HttpPost]
        public async Task<ActionResult<Equipment>> Post(Equipment Equipment)
        {
            if (Equipment == null)
            {
                return BadRequest();
            }

            db.Equipments.Add(Equipment);
            await db.SaveChangesAsync();
            return Ok(Equipment);
        }

        [HttpPut]
        public async Task<ActionResult<Equipment>> Put(Equipment Equipment)
        {
            if (Equipment == null)
            {
                return BadRequest();
            }

            db.Update(Equipment);
            await db.SaveChangesAsync();
            return Ok(Equipment);
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<Equipment>> Delete(int Id)
        {
            Equipment Equipment = db.Equipments.FirstOrDefault(x => x.EquipmentId == Id);
            if (Equipment == null)
            {
                return NotFound();
            }
            db.Equipments.Remove(Equipment);
            await db.SaveChangesAsync();
            return Ok(Equipment);
        }
    }
}
