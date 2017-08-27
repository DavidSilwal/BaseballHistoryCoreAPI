using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using BaseballHistoryCore.Data.DataModels;

namespace BaseballHistoryCore.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Master")]
    public class MasterController : Controller
    {
        private readonly BaseballStatsContext _context;

        public MasterController(BaseballStatsContext context)
        {
            _context = context;
        }

        // GET: api/Master
        [HttpGet]
        public IEnumerable<Master> Get()
        {
            return _context.Master.ToList();
        }

        // GET: api/Master/5
        [HttpGet("/api/Master/{playerId}")]
        public Master Get([FromUri] string playerId)
        {
            IQueryable<Master> result = _context.Master.Where(p => p.PlayerId == playerId);
            return result.FirstOrDefault();
        }

        [HttpGet("/api/Master/{playerID}/Batting")]
        public IQueryable<Batting> GetBatting([FromUri] string playerId)
        {
            return _context.Master.Where(p => p.PlayerId == playerId).SelectMany(p => p.Batting);
        }

        [HttpGet("/api/Master/{playerID}/Pitching")]
        public IQueryable<Pitching> GetPitching([FromUri] string playerId)
        {
            return _context.Master.Where(p => p.PlayerId == playerId).SelectMany(p => p.Pitching);
        }

        [HttpGet("/api/Master/{playerID}/Fielding")]
        public IQueryable<Fielding> GetFielding([FromUri] string playerId)
        {
            return _context.Master.Where(p => p.PlayerId == playerId).SelectMany(p => p.Fielding);
        }

        [HttpGet("/api/Master/{playerID}/AllstarFull")]
        public IQueryable<AllstarFull> GetAllstarFull([FromUri] string playerId)
        {
            return _context.Master.Where(p => p.PlayerId == playerId).SelectMany(p => p.AllstarFull);
        }

        [HttpGet("/api/Master/{playerID}/Appearances")]
        public IQueryable<Appearance> GetAppearances([FromUri] string playerId)
        {
            return _context.Master.Where(p => p.PlayerId == playerId).SelectMany(p => p.Appearances);
        }

        [HttpGet("/api/Master/{playerID}/AwardsManagers")]
        public IQueryable<AwardsManager> GetAwardsManagers([FromUri] string playerId)
        {
            return _context.Master.Where(p => p.PlayerId == playerId).SelectMany(p => p.AwardsManagers);
        }

        [HttpGet("/api/Master/{playerID}/AwardsPlayers")]
        public IQueryable<AwardsPlayer> GetAwardsPlayers([FromUri] string playerId)
        {
            return _context.Master.Where(p => p.PlayerId == playerId).SelectMany(p => p.AwardsPlayers);
        }

        [HttpGet("/api/Master/{playerID}/AwardsShareManagers")]
        public IQueryable<AwardsShareManager> GetAwardsShareManagers([FromUri] string playerId)
        {
            return _context.Master.Where(p => p.PlayerId == playerId).SelectMany(p => p.AwardsShareManagers);
        }

        [HttpGet("/api/Master/{playerID}/AwardsSharePlayers")]
        public IQueryable<AwardsSharePlayer> GetAwardsSharePlayers([FromUri] string playerId)
        {
            return _context.Master.Where(p => p.PlayerId == playerId).SelectMany(p => p.AwardsSharePlayers);
        }

        [HttpGet("/api/Master/{playerID}/BattingPost")]
        public IQueryable<BattingPost> GetBattingPost([FromUri] string playerId)
        {
            return _context.Master.Where(p => p.PlayerId == playerId).SelectMany(p => p.BattingPost);
        }

        [HttpGet("/api/Master/{playerID}/CollegePlaying")]
        public IQueryable<CollegePlaying> GetCollegePlaying([FromUri] string playerId)
        {
            return _context.Master.Where(p => p.PlayerId == playerId).SelectMany(p => p.CollegePlaying);
        }

        [HttpGet("/api/Master/{playerID}/FieldingOF")]
        public IQueryable<FieldingOf> GetFieldingOf([FromUri] string playerId)
        {
            return _context.Master.Where(p => p.PlayerId == playerId).SelectMany(p => p.FieldingOf);
        }

        [HttpGet("/api/Master/{playerID}/FieldingOFsplit")]
        public IQueryable<FieldingOFsplit> GetFieldingOFsplit([FromUri] string playerId)
        {
            return _context.Master.Where(p => p.PlayerId == playerId).SelectMany(p => p.FieldingOfsplit);
        }

        [HttpGet("/api/Master/{playerID}/FieldingPost")]
        public IQueryable<FieldingPost> GetFieldingPost([FromUri] string playerId)
        {
            return _context.Master.Where(p => p.PlayerId == playerId).SelectMany(p => p.FieldingPost);
        }

        [HttpGet("/api/Master/{playerID}/HallOfFame")]
        public IQueryable<HallOfFame> GetHallOfFame([FromUri] string playerId)
        {
            return _context.Master.Where(p => p.PlayerId == playerId).SelectMany(p => p.HallOfFame);
        }

        [HttpGet("/api/Master/{playerID}/Managers")]
        public IQueryable<Manager> GetManagers([FromUri] string playerId)
        {
            return _context.Master.Where(p => p.PlayerId == playerId).SelectMany(p => p.Managers);
        }

        [HttpGet("/api/Master/{playerID}/ManagersHalf")]
        public IQueryable<ManagersHalf> GetManagersHalf([FromUri] string playerId)
        {
            return _context.Master.Where(p => p.PlayerId == playerId).SelectMany(p => p.ManagersHalf);
        }

        [HttpGet("/api/Master/{playerID}/PitchingPost")]
        public IQueryable<PitchingPost> GetPitchingPost([FromUri] string playerId)
        {
            return _context.Master.Where(p => p.PlayerId == playerId).SelectMany(p => p.PitchingPost);
        }

        [HttpGet("/api/Master/{playerID}/Salaries")]
        public IQueryable<Salary> GetSalaries([FromUri] string playerId)
        {
            return _context.Master.Where(p => p.PlayerId == playerId).SelectMany(p => p.Salaries);
        }
    }
}
