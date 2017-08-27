using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using BaseballHistoryCore.Data.DataModels;

namespace BaseballHistoryCore.API.Controllers
{
    [Produces("application/json")]
    [Route("api/CollegePlaying")]
    public class CollegePlayingController : Controller
    {
        private readonly BaseballStatsContext _context;

        public CollegePlayingController(BaseballStatsContext context)
        {
            _context = context;
        }

        // GET: api/CollegePlaying
        [HttpGet]
        public IEnumerable<CollegePlaying> Get()
        {
            return _context.CollegePlaying.ToList();
        }

        // GET: api/CollegePlaying/5
        [HttpGet("/api/CollegePlaying/{playerId}/{yearId}/{schoolId}")]
        public CollegePlaying Get([FromUri] string playerId, [FromUri] int yearId, [FromUri] string schoolId)
        {
            IQueryable<CollegePlaying> result = _context.CollegePlaying.Where(p => p.PlayerId == playerId && p.YearId == yearId && p.SchoolId == schoolId);
            return result.FirstOrDefault();
        }
    }
}
