using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using BaseballHistoryCore.Data.DataModels;

namespace BaseballHistoryCore.API.Controllers
{
    [Produces("application/json")]
    [Route("api/AwardsPlayer")]
    public class AwardsPlayerController : Controller
    {
        private readonly BaseballStatsContext _context;

        public AwardsPlayerController(BaseballStatsContext context)
        {
            _context = context;
        }

        // GET: api/AwardsPlayer
        [HttpGet]
        public IEnumerable<AwardsPlayer> Get()
        {
            return _context.AwardsPlayers.ToList();
        }

        // GET: api/AwardsPlayer/5
        [HttpGet("/api/AwardsPlayer/{playerId}/{lgId}/{yearId}/{awardId}")]
        public AwardsPlayer Get([FromUri] string playerId, [FromUri] string lgId, [FromUri] int yearId, [FromUri] string awardId)
        {
            IQueryable<AwardsPlayer> result = _context.AwardsPlayers.Where(p => p.PlayerId == playerId && p.LgId == lgId && p.YearId == yearId && p.AwardId == awardId);
            return result.FirstOrDefault();
        }
    }
}
