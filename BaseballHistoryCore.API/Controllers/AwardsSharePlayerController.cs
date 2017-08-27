using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using BaseballHistoryCore.Data.DataModels;

namespace BaseballHistoryCore.API.Controllers
{
    [Produces("application/json")]
    [Route("api/AwardsSharePlayer")]
    public class AwardsSharePlayerController : Controller
    {
        private readonly BaseballStatsContext _context;

        public AwardsSharePlayerController(BaseballStatsContext context)
        {
            _context = context;
        }

        // GET: api/AwardsSharePlayer
        [HttpGet]
        public IEnumerable<AwardsSharePlayer> Get()
        {
            return _context.AwardsSharePlayers.ToList();
        }

        // GET: api/AwardsSharePlayer/5
        [HttpGet("/api/AwardsSharePlayer/{playerId}/{lgId}/{yearId}/{awardId}")]
        public AwardsSharePlayer Get([FromUri] string playerId, [FromUri] string lgId, [FromUri] int yearId, [FromUri] string awardId)
        {
            IQueryable<AwardsSharePlayer> result = _context.AwardsSharePlayers.Where(p => p.PlayerId == playerId && p.LgId == lgId && p.YearId == yearId && p.AwardId == awardId);
            return result.FirstOrDefault();
        }
    }
}
