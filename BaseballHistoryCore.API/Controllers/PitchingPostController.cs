using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using BaseballHistoryCore.Data.DataModels;

namespace BaseballHistoryCore.API.Controllers
{
    [Produces("application/json")]
    [Route("api/PitchingPost")]
    public class PitchingPostController : Controller
    {
        private readonly BaseballStatsContext _context;

        public PitchingPostController(BaseballStatsContext context)
        {
            _context = context;
        }

        // GET: api/PitchingPost
        [HttpGet]
        public IEnumerable<PitchingPost> Get()
        {
            return _context.PitchingPost.ToList();
        }

        // GET: api/PitchingPost/5
        [HttpGet("/api/PitchingPost/{playerId}/{teamId}/{lgId}/{yearId}/{round}")]
        public PitchingPost Get([FromUri] string playerId, [FromUri] string teamId, [FromUri] string lgId, [FromUri] int yearId, [FromUri] string round)
        {
            IQueryable<PitchingPost> result = _context.PitchingPost.Where(p => p.PlayerId == playerId && p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId && p.Round == round);
            return result.FirstOrDefault();
        }
    }
}
