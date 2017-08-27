using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using BaseballHistoryCore.Data.DataModels;

namespace BaseballHistoryCore.API.Controllers
{
    [Produces("application/json")]
    [Route("api/BattingPost")]
    public class BattingPostController : Controller
    {
        private readonly BaseballStatsContext _context;

        public BattingPostController(BaseballStatsContext context)
        {
            _context = context;
        }

        // GET: api/BattingPost
        [HttpGet]
        public IEnumerable<BattingPost> Get()
        {
            return _context.BattingPost.ToList();
        }

        // GET: api/BattingPost/5
        [HttpGet("/api/BattingPost/{playerId}/{teamId}/{lgId}/{yearId}/{round}")]
        public BattingPost Get([FromUri] string playerId, [FromUri] string teamId, [FromUri] string lgId, [FromUri] int yearId, [FromUri] string round)
        {
            IQueryable<BattingPost> result = _context.BattingPost.Where(p => p.PlayerId == playerId && p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId && p.Round == round);
            return result.FirstOrDefault();
        }
    }
}
