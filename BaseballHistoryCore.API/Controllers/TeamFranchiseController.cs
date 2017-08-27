using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using BaseballHistoryCore.Data.DataModels;

namespace BaseballHistoryCore.API.Controllers
{
    [Produces("application/json")]
    [Route("api/TeamFranchise")]
    public class TeamFranchiseController : Controller
    {
        private readonly BaseballStatsContext _context;

        public TeamFranchiseController(BaseballStatsContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<TeamFranchise> Get()
        {
            return _context.TeamFranchises.ToList();
        }

        [HttpGet("/api/TeamFranchise/{franchID}")]
        public TeamFranchise Get([FromUri] string franchId)
        {
            IQueryable<TeamFranchise> result = _context.TeamFranchises.Where(p => p.FranchId == franchId);
            return result.FirstOrDefault();
        }

        [HttpGet("/api/TeamFranchise/{franchID}/Teams")]
        public IQueryable<Team> GetTeams([FromUri] string franchId)
        {
            return _context.TeamFranchises.Where(p => p.FranchId == franchId).SelectMany(p => p.Teams);
        }
    }
}
