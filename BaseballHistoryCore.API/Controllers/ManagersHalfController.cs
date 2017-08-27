using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using BaseballHistoryCore.Data.DataModels;

namespace BaseballHistoryCore.API.Controllers
{
    [Produces("application/json")]
    [Route("api/ManagersHalf")]
    public class ManagersHalfController : Controller
    {
        private readonly BaseballStatsContext _context;

        public ManagersHalfController(BaseballStatsContext context)
        {
            _context = context;
        }

        // GET: api/ManagersHalf
        [HttpGet]
        public IEnumerable<ManagersHalf> Get()
        {
            return _context.ManagersHalf.ToList();
        }

        // GET: api/ManagersHalf/5
        [HttpGet("/api/ManagersHalf/{playerId}/{teamId}/{lgId}/{yearId}/{inseason}/{half}")]
        public ManagersHalf Get([FromUri] string playerId, [FromUri] string teamId, [FromUri] string lgId, [FromUri] int yearId, [FromUri] int inseason, [FromUri] int half)
        {
            IQueryable<ManagersHalf> result = _context.ManagersHalf.Where(p => p.PlayerId == playerId && p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId && p.Inseason == inseason && p.Half == half);
            return result.FirstOrDefault();
        }
    }
}
