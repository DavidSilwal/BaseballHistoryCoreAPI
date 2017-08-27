using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using BaseballHistoryCore.Data.DataModels;

namespace BaseballHistoryCore.API.Controllers
{
    [Produces("application/json")]
    [Route("api/TeamsHalf")]
    public class TeamsHalfController : Controller
    {
        private readonly BaseballStatsContext _context;

        public TeamsHalfController(BaseballStatsContext context)
        {
            _context = context;
        }

        // GET: api/TeamsHalf
        [HttpGet]
        public IEnumerable<TeamsHalf> Get()
        {
            return _context.TeamsHalf.ToList();
        }

        // GET: api/TeamsHalf/5
        [HttpGet("/api/TeamsHalf/{teamId}/{lgId}/{yearId}/{half}")]
        public TeamsHalf Get([FromUri] string teamId, [FromUri] string lgId, [FromUri] int yearId, [FromUri] string half)
        {
            IQueryable<TeamsHalf> result = _context.TeamsHalf.Where(p => p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId && p.Half == half);
            return result.FirstOrDefault();
        }
    }
}
