using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using BaseballHistoryCore.Data.DataModels;

namespace BaseballHistoryCore.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Appearance")]
    public class AppearanceController : Controller
    {
        private readonly BaseballStatsContext _context;

        public AppearanceController(BaseballStatsContext context)
        {
            _context = context;
        }

        // GET: api/Appearance
        [HttpGet]
        public IEnumerable<Appearance> Get()
        {
            return _context.Appearances.ToList();
        }

        // GET: api/Appearance/5
        [HttpGet("/api/Appearance/{playerId}/{teamId}/{lgId}/{yearId}")]
        public Appearance Get([FromUri] string playerId, [FromUri] string teamId, [FromUri] string lgId, [FromUri] int yearId)
        {
            IQueryable<Appearance> result = _context.Appearances.Where(p => p.PlayerId == playerId && p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId);
            return result.FirstOrDefault();
        }
    }
}
