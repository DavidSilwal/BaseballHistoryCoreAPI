using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using BaseballHistoryCore.Data.DataModels;

namespace BaseballHistoryCore.API.Controllers
{
    [Produces("application/json")]
    [Route("api/HomeGame")]
    public class HomeGameController : Controller
    {
        private readonly BaseballStatsContext _context;

        public HomeGameController(BaseballStatsContext context)
        {
            _context = context;
        }

        // GET: api/HomeGame
        [HttpGet]
        public IEnumerable<HomeGame> Get()
        {
            return _context.HomeGames.ToList();
        }

        // GET: api/HomeGame/5
        [HttpGet("/api/HomeGame/{teamId}/{lgId}/{yearId}/{parkkey}")]
        public HomeGame Get([FromUri] string teamId, [FromUri] string lgId, [FromUri] int yearId, [FromUri] string parkkey)
        {
            IQueryable<HomeGame> result = _context.HomeGames.Where(p => p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId && p.Parkkey == parkkey);
            return result.FirstOrDefault();
        }
    }
}
