using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using BaseballHistoryCore.Data.DataModels;
using Microsoft.EntityFrameworkCore;

namespace BaseballHistoryCore.API.Controllers
{
    [Produces("application/json")]
    [Route("api/AllstarFull")]
    public class AllstarFullController : Controller
    {
        private readonly BaseballStatsContext _context;

        public AllstarFullController(BaseballStatsContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<AllstarFull> Get()
        {
            return _context.AllstarFull.ToList();
        }

        [HttpGet("/api/AllstarFull/{playerId}/{teamId}/{lgId}/{yearId}/{gameId}")]
        public AllstarFull Get([FromUri] string playerId, [FromUri] string teamId, [FromUri] string lgId, [FromUri] int yearId, [FromUri] string gameId)
        {
            IQueryable<AllstarFull> result = _context.AllstarFull.Where(p =>
                p.PlayerId == playerId && p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId &&
                p.GameId == gameId);
            return result.FirstOrDefault();
        }
    }
}
