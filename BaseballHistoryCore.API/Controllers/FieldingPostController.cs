using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using BaseballHistoryCore.Data.DataModels;

namespace BaseballHistoryCore.API.Controllers
{
    [Produces("application/json")]
    [Route("api/FieldingPost")]
    public class FieldingPostController : Controller
    {
        private readonly BaseballStatsContext _context;

        public FieldingPostController(BaseballStatsContext context)
        {
            _context = context;
        }

        // GET: api/FieldingPost
        [HttpGet]
        public IEnumerable<FieldingPost> Get()
        {
            return _context.FieldingPost.ToList();
        }

        // GET: api/FieldingPost/5
        [HttpGet("/api/FieldingPost/{playerId}/{teamId}/{lgId}/{yearId}/{round}/{pos}")]
        public FieldingPost Get([FromUri] string playerId, [FromUri] string teamId, [FromUri] string lgId, [FromUri] int yearId, [FromUri] string round, [FromUri] string pos)
        {
            IQueryable<FieldingPost> result = _context.FieldingPost.Where(p => p.PlayerId == playerId && p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId && p.Round == round && p.Pos == pos);
            return result.FirstOrDefault();
        }
    }
}
