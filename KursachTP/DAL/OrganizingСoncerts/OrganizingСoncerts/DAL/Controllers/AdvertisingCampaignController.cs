using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrganizingСoncerts_Classes;

namespace OrganizingСoncerts.DAL.Controllers

{
    [ApiController]
    [Route("/AdvertisingCampaign")]
    public class AdvertisingCampaignController : ControllerBase
    {
        ApplicationContext db;
        public AdvertisingCampaignController(ApplicationContext context)
        {
            db = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AdvertisingCampaign>>> Get()
        {
            return await db.AdvertisingCampaigns.ToListAsync();
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<AdvertisingCampaign>> Get(int Id)
        {
            AdvertisingCampaign AdvertisingCampaign = await db.AdvertisingCampaigns.FirstOrDefaultAsync(x => x.AdvertisingCampaignId == Id);
            if (AdvertisingCampaign == null)
                return NotFound();
            return new ObjectResult(AdvertisingCampaign);
        }

        [HttpPost]
        public async Task<ActionResult<AdvertisingCampaign>> Post(AdvertisingCampaign AdvertisingCampaign)
        {
            if (AdvertisingCampaign == null)
            {
                return BadRequest();
            }

            db.AdvertisingCampaigns.Add(AdvertisingCampaign);
            await db.SaveChangesAsync();
            return Ok(AdvertisingCampaign);
        }

        [HttpPut]
        public async Task<ActionResult<AdvertisingCampaign>> Put(AdvertisingCampaign AdvertisingCampaign)
        {
            if (AdvertisingCampaign == null)
            {
                return BadRequest();
            }

            db.Update(AdvertisingCampaign);
            await db.SaveChangesAsync();
            return Ok(AdvertisingCampaign);
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<AdvertisingCampaign>> Delete(int Id)
        {
            AdvertisingCampaign AdvertisingCampaign = db.AdvertisingCampaigns.FirstOrDefault(x => x.AdvertisingCampaignId == Id);
            if (AdvertisingCampaign == null)
            {
                return NotFound();
            }
            db.AdvertisingCampaigns.Remove(AdvertisingCampaign);
            await db.SaveChangesAsync();
            return Ok(AdvertisingCampaign);
        }
    }
}
