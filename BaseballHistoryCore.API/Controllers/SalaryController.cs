using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using BaseballHistoryCore.Data.DataModels;

namespace BaseballHistoryCore.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Salary")]
    public class SalaryController : Controller
    {
        private readonly BaseballStatsContext _context;

        public SalaryController(BaseballStatsContext context)
        {
            _context = context;
        }

        // GET: api/Salary
        [HttpGet]
        public IEnumerable<Salary> Get()
        {
            return _context.Salaries.ToList();
        }

        // GET: api/Salary/5
        [HttpGet("/api/Salary/{playerId}/{teamId}/{lgId}/{yearId}")]
        public Salary Get([FromUri] string playerId, [FromUri] string teamId, [FromUri] string lgId, [FromUri] int yearId)
        {
            IQueryable<Salary> result = _context.Salaries.Where(p => p.PlayerId == playerId && p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId);
            return result.FirstOrDefault();
        }
    }
}
