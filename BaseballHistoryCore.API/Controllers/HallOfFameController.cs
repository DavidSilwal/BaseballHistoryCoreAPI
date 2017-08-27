using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using BaseballHistoryCore.Data.DataModels;

namespace BaseballHistoryCore.API.Controllers
{
    [Produces("application/json")]
    [Route("api/HallOfFame")]
    public class HallOfFameController : Controller
    {
        private readonly BaseballStatsContext _context;

        public HallOfFameController(BaseballStatsContext context)
        {
            _context = context;
        }

        // GET: api/HallOfFame
        [HttpGet]
        public IEnumerable<HallOfFame> Get()
        {
            return _context.HallOfFame.ToList();
        }

        // GET: api/HallOfFame/5
        [HttpGet("/api/HallOfFame/{playerId}/{yearId}/{votedBy}")]
        public HallOfFame Get([FromUri] string playerId, [FromUri] int yearId, [FromUri] string votedBy)
        {
            IQueryable<HallOfFame> result = _context.HallOfFame.Where(p => p.PlayerId == playerId && p.Yearid == yearId && p.VotedBy == votedBy);
            return result.FirstOrDefault();
        }
    }
}
