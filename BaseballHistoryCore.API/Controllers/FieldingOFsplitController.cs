using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using BaseballHistoryCore.Data.DataModels;

namespace BaseballHistoryCore.API.Controllers
{
    [Produces("application/json")]
    [Route("api/FieldingOFsplit")]
    public class FieldingOFsplitController : Controller
    {
        private readonly BaseballStatsContext _context;

        public FieldingOFsplitController(BaseballStatsContext context)
        {
            _context = context;
        }

        // GET: api/FieldingOFsplit
        [HttpGet]
        public IEnumerable<FieldingOFsplit> Get()
        {
            return _context.FieldingOfsplit.ToList();
        }

        // GET: api/FieldingOFsplit/5
        [HttpGet("/api/FieldingOFsplit/{playerId}/{teamId}/{lgId}/{yearId}/{stint}/{pos}")]
        public FieldingOFsplit Get([FromUri] string playerId, [FromUri] string teamId, [FromUri] string lgId, [FromUri] int yearId, [FromUri] int stint, [FromUri] string pos)
        {
            IQueryable<FieldingOFsplit> result = _context.FieldingOfsplit.Where(p => p.PlayerId == playerId && p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId && p.Stint == stint && p.Pos == pos);
            return result.FirstOrDefault();
        }
    }
}
