using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mission10_Smith.Data;


namespace mission10_Smith.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly BowlingDbContext _context;

        public HomeController(BowlingDbContext context)
        {
            _context = context;
        }

        

        [HttpGet()]
        public IActionResult GetMarlinsAndSharksBowlers()
        {
            var bowlers = _context.Bowlers
                .Include(b => b.Team) // Eager-load team data
                .Where(b => b.Team != null &&
                            (b.Team.TeamName == "Marlins" || b.Team.TeamName == "Sharks"))
                .ToList();

            return Ok(bowlers);
        }
    }
}
