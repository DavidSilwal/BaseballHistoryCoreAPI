using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using BaseballHistoryCore.Data.DataModels;

namespace BaseballHistoryCore.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Park")]
    public class ParkController : Controller
    {
        private readonly BaseballStatsContext _context;

        public ParkController(BaseballStatsContext context)
        {
            _context = context;
        }

        // GET: api/Park
        [HttpGet]
        public IEnumerable<Park> Get()
        {
            return _context.Parks.ToList();
        }

        // GET: api/Park/5
        [HttpGet("/api/Park/{id}")]
        public Park Get([FromUri] int id)
        {
            IQueryable<Park> result = _context.Parks.Where(p => p.Id == id);
            return result.FirstOrDefault();
        }
    }
}
