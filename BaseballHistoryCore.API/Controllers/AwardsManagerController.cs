using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using BaseballHistoryCore.Data.DataModels;

namespace BaseballHistoryCore.API.Controllers
{
    [Produces("application/json")]
    [Route("api/AwardsManager")]
    public class AwardsManagerController : Controller
    {
        private readonly BaseballStatsContext _context;

        public AwardsManagerController(BaseballStatsContext context)
        {
            _context = context;
        }

        // GET: api/AwardsManager
        [HttpGet]
        public IEnumerable<AwardsManager> Get()
        {
            return _context.AwardsManagers.ToList();
        }

        // GET: api/AwardsManager/5
        [HttpGet("/api/AwardsManager/{playerId}/{lgId}/{yearId}/{awardId}")]
        public AwardsManager Get([FromUri] string playerId, [FromUri] string lgId, [FromUri] int yearId, [FromUri] string awardId)
        {
            IQueryable<AwardsManager> result = _context.AwardsManagers.Where(p => p.PlayerId == playerId && p.LgId == lgId && p.YearId == yearId && p.AwardId == awardId);
            return result.FirstOrDefault();
        }
    }
}
