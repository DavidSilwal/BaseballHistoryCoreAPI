using System;
using System.Collections.Generic;

namespace BaseballHistoryCore.Data.DataModels
{
    public partial class Team
    {
        public Team()
        {
            AllstarFull = new HashSet<AllstarFull>();
            Appearances = new HashSet<Appearance>();
            Batting = new HashSet<Batting>();
            BattingPost = new HashSet<BattingPost>();
            Fielding = new HashSet<Fielding>();
            FieldingOfsplit = new HashSet<FieldingOFsplit>();
            FieldingPost = new HashSet<FieldingPost>();
            HomeGames = new HashSet<HomeGame>();
            Managers = new HashSet<Manager>();
            ManagersHalf = new HashSet<ManagersHalf>();
            Pitching = new HashSet<Pitching>();
            PitchingPost = new HashSet<PitchingPost>();
            Salaries = new HashSet<Salary>();
            SeriesPostTeams = new HashSet<SeriesPost>();
            SeriesPostTeamsNavigation = new HashSet<SeriesPost>();
            TeamsHalf = new HashSet<TeamsHalf>();
        }

        public string TeamId { get; set; }
        public string LgId { get; set; }
        public short YearId { get; set; }
        public string FranchId { get; set; }
        public string DivId { get; set; }
        public short? Rank { get; set; }
        public short? G { get; set; }
        public short? Ghome { get; set; }
        public short? W { get; set; }
        public short? L { get; set; }
        public string DivWin { get; set; }
        public string Wcwin { get; set; }
        public string LgWin { get; set; }
        public string Wswin { get; set; }
        public short? R { get; set; }
        public short? Ab { get; set; }
        public short? H { get; set; }
        public short? _2b { get; set; }
        public short? _3b { get; set; }
        public short? Hr { get; set; }
        public short? Bb { get; set; }
        public short? So { get; set; }
        public short? Sb { get; set; }
        public short? Cs { get; set; }
        public short? Hbp { get; set; }
        public short? Sf { get; set; }
        public short? Ra { get; set; }
        public short? Er { get; set; }
        public double? Era { get; set; }
        public short? Cg { get; set; }
        public short? Sho { get; set; }
        public short? Sv { get; set; }
        public int? Ipouts { get; set; }
        public short? Ha { get; set; }
        public short? Hra { get; set; }
        public short? Bba { get; set; }
        public short? Soa { get; set; }
        public int? E { get; set; }
        public int? Dp { get; set; }
        public double? Fp { get; set; }
        public string Name { get; set; }
        public string Park { get; set; }
        public int? Attendance { get; set; }
        public int? Bpf { get; set; }
        public int? Ppf { get; set; }
        public string TeamIdbr { get; set; }
        public string TeamIdlahman45 { get; set; }
        public string TeamIdretro { get; set; }

        public virtual ICollection<AllstarFull> AllstarFull { get; set; }
        public virtual ICollection<Appearance> Appearances { get; set; }
        public virtual ICollection<Batting> Batting { get; set; }
        public virtual ICollection<BattingPost> BattingPost { get; set; }
        public virtual ICollection<Fielding> Fielding { get; set; }
        public virtual ICollection<FieldingOFsplit> FieldingOfsplit { get; set; }
        public virtual ICollection<FieldingPost> FieldingPost { get; set; }
        public virtual ICollection<HomeGame> HomeGames { get; set; }
        public virtual ICollection<Manager> Managers { get; set; }
        public virtual ICollection<ManagersHalf> ManagersHalf { get; set; }
        public virtual ICollection<Pitching> Pitching { get; set; }
        public virtual ICollection<PitchingPost> PitchingPost { get; set; }
        public virtual ICollection<Salary> Salaries { get; set; }
        public virtual ICollection<SeriesPost> SeriesPostTeams { get; set; }
        public virtual ICollection<SeriesPost> SeriesPostTeamsNavigation { get; set; }
        public virtual ICollection<TeamsHalf> TeamsHalf { get; set; }
        public virtual TeamFranchise Franch { get; set; }
    }
}
