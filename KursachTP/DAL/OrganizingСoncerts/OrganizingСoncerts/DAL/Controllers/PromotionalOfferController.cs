using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrganizingСoncerts_Classes;

namespace OrganizingСoncerts.DAL.Controllers

{
    [ApiController]
    [Route("/PromotionalOffer")]
    public class PromotionalOfferController : ControllerBase
    {
        ApplicationContext db;
        public PromotionalOfferController(ApplicationContext context)
        {
            db = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PromotionalOffer>>> Get()
        {
            return await db.PromotionalOffers.ToListAsync();
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<PromotionalOffer>> Get(int Id)
        {
            PromotionalOffer PromotionalOffer = await db.PromotionalOffers.FirstOrDefaultAsync(x => x.PromotionalOfferId == Id);
            if (PromotionalOffer == null)
                return NotFound();
            return new ObjectResult(PromotionalOffer);
        }

        [HttpPost]
        public async Task<ActionResult<PromotionalOffer>> Post(PromotionalOffer PromotionalOffer)
        {
            if (PromotionalOffer == null)
            {
                return BadRequest();
            }

            db.PromotionalOffers.Add(PromotionalOffer);
            await db.SaveChangesAsync();
            return Ok(PromotionalOffer);
        }

        [HttpPut]
        public async Task<ActionResult<PromotionalOffer>> Put(PromotionalOffer PromotionalOffer)
        {
            if (PromotionalOffer == null)
            {
                return BadRequest();
            }

            db.Update(PromotionalOffer);
            await db.SaveChangesAsync();
            return Ok(PromotionalOffer);
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<PromotionalOffer>> Delete(int Id)
        {
            PromotionalOffer PromotionalOffer = db.PromotionalOffers.FirstOrDefault(x => x.PromotionalOfferId == Id);
            if (PromotionalOffer == null)
            {
                return NotFound();
            }
            db.PromotionalOffers.Remove(PromotionalOffer);
            await db.SaveChangesAsync();
            return Ok(PromotionalOffer);
        }
    }
}