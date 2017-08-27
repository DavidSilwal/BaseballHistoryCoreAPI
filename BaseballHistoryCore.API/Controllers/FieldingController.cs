using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using BaseballHistoryCore.Data.DataModels;

namespace BaseballHistoryCore.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Fielding")]
    public class FieldingController : Controller
    {
        private readonly BaseballStatsContext _context;

        public FieldingController(BaseballStatsContext context)
        {
            _context = context;
        }

        // GET: api/Fielding
        [HttpGet]
        public IEnumerable<Fielding> Get()
        {
            return _context.Fielding.ToList();
        }

        // GET: api/Fielding/5
        [HttpGet("/api/Fielding/{playerId}/{teamId}/{lgId}/{yearId}/{stint}/{pos}")]
        public Fielding Get([FromUri] string playerId, [FromUri] string teamId, [FromUri] string lgId, [FromUri] int yearId, [FromUri] int stint, [FromUri] string pos)
        {
            IQueryable<Fielding> result = _context.Fielding.Where(p => p.PlayerId == playerId && p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId && p.Stint == stint && p.Pos == pos);
            return result.FirstOrDefault();
        }
    }
}
