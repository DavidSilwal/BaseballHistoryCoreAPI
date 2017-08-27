using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using BaseballHistoryCore.Data.DataModels;

namespace BaseballHistoryCore.API.Controllers
{
    [Produces("application/json")]
    [Route("api/FieldingOF")]
    public class FieldingOfController : Controller
    {
        private readonly BaseballStatsContext _context;

        public FieldingOfController(BaseballStatsContext context)
        {
            _context = context;
        }

        // GET: api/FieldingOF
        [HttpGet]
        public IEnumerable<FieldingOf> Get()
        {
            return _context.FieldingOf.ToList();
        }

        // GET: api/FieldingOF/5
        [HttpGet("/api/FieldingOF/{playerId}/{yearId}/{stint}")]
        public FieldingOf Get([FromUri] string playerId, int yearId, int stint)
        {
            IQueryable<FieldingOf> result = _context.FieldingOf.Where(p => p.PlayerId == playerId && p.YearId == yearId && p.Stint == stint);
            return result.FirstOrDefault();
        }
    }
}
