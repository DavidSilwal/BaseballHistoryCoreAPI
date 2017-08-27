using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using BaseballHistoryCore.Data.DataModels;

namespace BaseballHistoryCore.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Batting")]
    public class BattingController : Controller
    {
        private readonly BaseballStatsContext _context;

        public BattingController(BaseballStatsContext context)
        {
            _context = context;
        }

        // GET: api/Batting
        [HttpGet]
        public IEnumerable<Batting> Get()
        {
            return _context.Batting.ToList();
        }

        // GET: api/Batting/5
        [HttpGet("/api/Batting/{playerId}/{teamId}/{lgId}/{yearId}/{stint}")]
        public Batting Get([FromUri] string playerId, [FromUri] string teamId, [FromUri] string lgId, [FromUri]int yearId, [FromUri] int stint)
        {
            IQueryable<Batting> result = _context.Batting.Where(p => p.PlayerId == playerId && p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId && p.Stint == stint);
            return result.FirstOrDefault();
        }
    }
}
