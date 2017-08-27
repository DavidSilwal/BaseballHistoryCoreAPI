using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using BaseballHistoryCore.Data.DataModels;

namespace BaseballHistoryCore.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Pitching")]
    public class PitchingController : Controller
    {
        private readonly BaseballStatsContext _context;

        public PitchingController(BaseballStatsContext context)
        {
            _context = context;
        }

        // GET: api/Pitching
        [HttpGet]
        public IEnumerable<Pitching> Get()
        {
            return _context.Pitching.ToList();
        }

        // GET: api/Pitching/5
        [HttpGet("/api/Pitching/{playerId}/{teamId}/{lgId}/{yearId}/{stint}")]
        public Pitching Get([FromUri] string playerId, [FromUri] string teamId, [FromUri] string lgId, [FromUri] int yearId, [FromUri] int stint)
        {
            IQueryable<Pitching> result = _context.Pitching.Where(p => p.PlayerId == playerId && p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId && p.Stint == stint);
            return result.FirstOrDefault();
        }
    }
}
