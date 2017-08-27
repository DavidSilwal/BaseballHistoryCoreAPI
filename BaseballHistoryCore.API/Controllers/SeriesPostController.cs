using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using BaseballHistoryCore.Data.DataModels;

namespace BaseballHistoryCore.API.Controllers
{
    [Produces("application/json")]
    [Route("api/SeriesPost")]
    public class SeriesPostController : Controller
    {
        private readonly BaseballStatsContext _context;

        public SeriesPostController(BaseballStatsContext context)
        {
            _context = context;
        }

        // GET: api/SeriesPost
        [HttpGet]
        public IEnumerable<SeriesPost> Get()
        {
            return _context.SeriesPost.ToList();
        }

        // GET: api/SeriesPost/5
        [HttpGet("/api/SeriesPost/{teamIDwinner}/{lgIDwinner}/{yearId}/{round}")]
        public SeriesPost Get([FromUri] string teamIDwinner, [FromUri] string lgIDwinner, [FromUri] int yearId, [FromUri] string round)
        {
            IQueryable<SeriesPost> result = _context.SeriesPost.Where(p => p.TeamIdwinner == teamIDwinner && p.LgIdwinner == lgIDwinner && p.YearId == yearId && p.Round == round);
            return result.FirstOrDefault();
        }
    }
}
