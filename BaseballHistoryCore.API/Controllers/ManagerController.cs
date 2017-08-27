using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using BaseballHistoryCore.Data.DataModels;

namespace BaseballHistoryCore.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Manager")]
    public class ManagerController : Controller
    {
        private readonly BaseballStatsContext _context;

        public ManagerController(BaseballStatsContext context)
        {
            _context = context;
        }

        // GET: api/Manager
        [HttpGet]
        public IEnumerable<Manager> Get()
        {
            return _context.Managers.ToList();
        }

        // GET: api/Manager/5
        [HttpGet("/api/Manager/{playerId}/{teamId}/{lgId}/{yearId}/{inseason}")]
        public Manager Get([FromUri] string playerId, [FromUri] string teamId, [FromUri] string lgId, [FromUri] int yearId, [FromUri] int inseason)
        {
            IQueryable<Manager> result = _context.Managers.Where(p => p.PlayerId == playerId && p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId && p.Inseason == inseason);
            return result.FirstOrDefault();
        }
    }
}
