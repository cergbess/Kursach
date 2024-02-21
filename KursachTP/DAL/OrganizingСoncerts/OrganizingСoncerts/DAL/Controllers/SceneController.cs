using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrganizingСoncerts_Classes;

namespace OrganizingСoncerts.DAL.Controllers

{
    [ApiController]
    [Route("/Scene")]
    public class SceneController : ControllerBase
    {
        ApplicationContext db;
        public SceneController(ApplicationContext context)
        {
            db = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Scene>>> Get()
        {
            return await db.Scenes.ToListAsync();
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<Scene>> Get(int Id)
        {
            Scene Scene = await db.Scenes.FirstOrDefaultAsync(x => x.SceneId == Id);
            if (Scene == null)
                return NotFound();
            return new ObjectResult(Scene);
        }

        [HttpPost]
        public async Task<ActionResult<Scene>> Post(Scene Scene)
        {
            if (Scene == null)
            {
                return BadRequest();
            }

            db.Scenes.Add(Scene);
            await db.SaveChangesAsync();
            return Ok(Scene);
        }

        [HttpPut]
        public async Task<ActionResult<Scene>> Put(Scene Scene)
        {
            if (Scene == null)
            {
                return BadRequest();
            }

            db.Update(Scene);
            await db.SaveChangesAsync();
            return Ok(Scene);
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<Scene>> Delete(int Id)
        {
            Scene Scene = db.Scenes.FirstOrDefault(x => x.SceneId == Id);
            if (Scene == null)
            {
                return NotFound();
            }
            db.Scenes.Remove(Scene);
            await db.SaveChangesAsync();
            return Ok(Scene);
        }
    }
}
