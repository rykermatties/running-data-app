using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunningData.Data;
using RunningData.Models;

namespace RunningData.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RunsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public RunsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Run>>> GetRuns()
        {
            return await _context.Runs.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Run>> CreateRun(Run run)
        {
            _context.Runs.Add(run);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetRuns), new { id = run.Id }, run);
        }
    }
}