using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using BaseballHistoryCore.Data.DataModels;

namespace BaseballHistoryCore.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Team")]
    public class TeamController : Controller
    {
        private readonly BaseballStatsContext _context;

        public TeamController(BaseballStatsContext context)
        {
            _context = context;
        }

        // GET: api/Team
        [HttpGet]
        public IEnumerable<Team> Get()
        {
            return _context.Teams.ToList();
        }

        // GET: api/Team/5
        [HttpGet("/api/Team/{teamId}/{lgId}/{yearId}")]
        public Team Get([FromUri] string teamId, [FromUri] string lgId, [FromUri] int yearId)
        {
            IQueryable<Team> result = _context.Teams.Where(p => p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId);
            return result.FirstOrDefault();
        }

        [HttpGet("/api/Team/{teamID}/{lgID}/{yearID}/Batting")]
        public IQueryable<Batting> GetBatting([FromUri] string teamId, [FromUri] string lgId, [FromUri] int yearId)
        {
            return _context.Teams.Where(p => p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId).SelectMany(p => p.Batting);
        }

        [HttpGet("/api/Team/{teamID}/{lgID}/{yearID}/Pitching")]
        public IQueryable<Pitching> GetPitching([FromUri] string teamId, [FromUri] string lgId, [FromUri] int yearId)
        {
            return _context.Teams.Where(p => p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId).SelectMany(p => p.Pitching);
        }

        [HttpGet("/api/Team/{teamID}/{lgID}/{yearID}/Fielding")]
        public IQueryable<Fielding> GetFielding([FromUri] string teamId, [FromUri] string lgId, [FromUri] int yearId)
        {
            return _context.Teams.Where(p => p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId).SelectMany(p => p.Fielding);
        }

        [HttpGet("/api/Team/{teamID}/{lgID}/{yearID}/AllstarFull")]
        public IQueryable<AllstarFull> GetAllstarFull([FromUri] string teamId, [FromUri] string lgId, [FromUri] int yearId)
        {
            return _context.Teams.Where(p => p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId).SelectMany(p => p.AllstarFull);
        }

        [HttpGet("/api/Team/{teamID}/{lgID}/{yearID}/Appearances")]
        public IQueryable<Appearance> GetAppearances([FromUri] string teamId, [FromUri] string lgId, [FromUri] int yearId)
        {
            return _context.Teams.Where(p => p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId).SelectMany(p => p.Appearances);
        }

        [HttpGet("/api/Team/{teamID}/{lgID}/{yearID}/BattingPost")]
        public IQueryable<BattingPost> GetBattingPost([FromUri] string teamId, [FromUri] string lgId, [FromUri] int yearId)
        {
            return _context.Teams.Where(p => p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId).SelectMany(p => p.BattingPost);
        }

        [HttpGet("/api/Team/{teamID}/{lgID}/{yearID}/FieldingOFsplit")]
        public IQueryable<FieldingOFsplit> GetFieldingOFsplit([FromUri] string teamId, [FromUri] string lgId, [FromUri] int yearId)
        {
            return _context.Teams.Where(p => p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId).SelectMany(p => p.FieldingOfsplit);
        }

        [HttpGet("/api/Team/{teamID}/{lgID}/{yearID}/FieldingPost")]
        public IQueryable<FieldingPost> GetFieldingPost([FromUri] string teamId, [FromUri] string lgId, [FromUri] int yearId)
        {
            return _context.Teams.Where(p => p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId).SelectMany(p => p.FieldingPost);
        }

        [HttpGet("/api/Team/{teamID}/{lgID}/{yearID}/Managers")]
        public IQueryable<Manager> GetManagers([FromUri] string teamId, [FromUri] string lgId, [FromUri] int yearId)
        {
            return _context.Teams.Where(p => p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId).SelectMany(p => p.Managers);
        }

        [HttpGet("/api/Team/{teamID}/{lgID}/{yearID}/ManagersHalf")]
        public IQueryable<ManagersHalf> GetManagersHalf([FromUri] string teamId, [FromUri] string lgId, [FromUri] int yearId)
        {
            return _context.Teams.Where(p => p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId).SelectMany(p => p.ManagersHalf);
        }

        [HttpGet("/api/Team/{teamID}/{lgID}/{yearID}/PitchingPost")]
        public IQueryable<PitchingPost> GetPitchingPost([FromUri] string teamId, [FromUri] string lgId, [FromUri] int yearId)
        {
            return _context.Teams.Where(p => p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId).SelectMany(p => p.PitchingPost);
        }

        [HttpGet("/api/Team/{teamID}/{lgID}/{yearID}/Salaries")]
        public IQueryable<Salary> GetSalaries([FromUri] string teamId, [FromUri] string lgId, [FromUri] int yearId)
        {
            return _context.Teams.Where(p => p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId).SelectMany(p => p.Salaries);
        }

        [HttpGet("/api/Team/{teamID}/{lgID}/{yearID}/ManagersHalf")]
        public IQueryable<HomeGame> GetHomeGames([FromUri] string teamId, [FromUri] string lgId, [FromUri] int yearId)
        {
            return _context.Teams.Where(p => p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId).SelectMany(p => p.HomeGames);
        }

        [HttpGet("/api/Team/{teamID}/{lgID}/{yearID}/PitchingPost")]
        public IQueryable<SeriesPost> GetSeriesPost([FromUri] string teamId, [FromUri] string lgId, [FromUri] int yearId)
        {
            return _context.Teams.Where(p => p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId).SelectMany(p => p.SeriesPostTeams);
        }

        [HttpGet("/api/Team/{teamID}/{lgID}/{yearID}/TeamsHalf")]
        public IQueryable<TeamsHalf> GetTeamsHalf([FromUri] string teamId, [FromUri] string lgId, [FromUri] int yearId)
        {
            return _context.Teams.Where(p => p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId).SelectMany(p => p.TeamsHalf);
        }
    }
}
