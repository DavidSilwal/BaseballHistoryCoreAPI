using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using BaseballHistoryCore.Data.DataModels;

namespace BaseballHistoryCore.API.Controllers
{
    [Produces("application/json")]
    [Route("api/School")]
    public class SchoolController : Controller
    {
        private readonly BaseballStatsContext _context;

        public SchoolController(BaseballStatsContext context)
        {
            _context = context;
        }

        // GET: api/School
        [HttpGet]
        public IEnumerable<School> Get()
        {
            return _context.Schools.ToList();
        }

        // GET: api/School/5
        [HttpGet("/api/School/{playerId}/{teamId}/{lgId}/{yearId}")]
        public School Get([FromUri] string schoolId)
        {
            IQueryable<School> result = _context.Schools.Where(p => p.SchoolId == schoolId);
            return result.FirstOrDefault();
        }

        [HttpGet("/api/School/{schoolID})/CollegePlaying")]
        public IQueryable<CollegePlaying> GetCollegePlaying([FromUri] string schoolId)
        {
            return _context.Schools.Where(p => p.SchoolId == schoolId).SelectMany(p => p.CollegePlaying);
        }
    }
}
