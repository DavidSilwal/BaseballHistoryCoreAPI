using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using BaseballHistoryCore.Data.DataModels;

namespace BaseballHistoryCore.API.Controllers
{
    [Produces("application/json")]
    [Route("api/AwardsShareManager")]
    public class AwardsShareManagerController : Controller
    {
        private readonly BaseballStatsContext _context;

        public AwardsShareManagerController(BaseballStatsContext context)
        {
            _context = context;
        }

        // GET: api/AwardsShareManager
        [HttpGet]
        public IEnumerable<AwardsShareManager> Get()
        {
            return _context.AwardsShareManagers.ToList();
        }

        // GET: api/AwardsShareManager/5
        [HttpGet("/api/AwardsShareManager/{playerId}/{lgId}/{yearId}/{awardId}")]
        public AwardsShareManager Get([FromUri] string playerId, [FromUri] string lgId, [FromUri] int yearId, [FromUri] string awardId)
        {
            IQueryable<AwardsShareManager> result = _context.AwardsShareManagers.Where(p => p.PlayerId == playerId && p.LgId == lgId && p.YearId == yearId && p.AwardId == awardId);
            return result.FirstOrDefault();
        }
    }
}
