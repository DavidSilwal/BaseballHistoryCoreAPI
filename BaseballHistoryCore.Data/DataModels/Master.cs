using System.Collections.Generic;

namespace BaseballHistoryCore.Data.DataModels
{
    public class Master
    {
        public Master()
        {
            AllstarFull = new HashSet<AllstarFull>();
            Appearances = new HashSet<Appearance>();
            AwardsManagers = new HashSet<AwardsManager>();
            AwardsPlayers = new HashSet<AwardsPlayer>();
            AwardsShareManagers = new HashSet<AwardsShareManager>();
            AwardsSharePlayers = new HashSet<AwardsSharePlayer>();
            Batting = new HashSet<Batting>();
            BattingPost = new HashSet<BattingPost>();
            CollegePlaying = new HashSet<CollegePlaying>();
            Fielding = new HashSet<Fielding>();
            FieldingOf = new HashSet<FieldingOf>();
            FieldingOfsplit = new HashSet<FieldingOFsplit>();
            FieldingPost = new HashSet<FieldingPost>();
            HallOfFame = new HashSet<HallOfFame>();
            Managers = new HashSet<Manager>();
            ManagersHalf = new HashSet<ManagersHalf>();
            Pitching = new HashSet<Pitching>();
            PitchingPost = new HashSet<PitchingPost>();
            Salaries = new HashSet<Salary>();
        }

        public string PlayerId { get; set; }
        public short? BirthYear { get; set; }
        public short? BirthMonth { get; set; }
        public short? BirthDay { get; set; }
        public string BirthCountry { get; set; }
        public string BirthState { get; set; }
        public string BirthCity { get; set; }
        public short? DeathYear { get; set; }
        public short? DeathMonth { get; set; }
        public short? DeathDay { get; set; }
        public string DeathCountry { get; set; }
        public string DeathState { get; set; }
        public string DeathCity { get; set; }
        public string NameFirst { get; set; }
        public string NameLast { get; set; }
        public string NameGiven { get; set; }
        public short? Weight { get; set; }
        public short? Height { get; set; }
        public string Bats { get; set; }
        public string Throws { get; set; }
        public string Debut { get; set; }
        public string FinalGame { get; set; }
        public string RetroId { get; set; }
        public string BbrefId { get; set; }

        public virtual ICollection<AllstarFull> AllstarFull { get; set; }
        public virtual ICollection<Appearance> Appearances { get; set; }
        public virtual ICollection<AwardsManager> AwardsManagers { get; set; }
        public virtual ICollection<AwardsPlayer> AwardsPlayers { get; set; }
        public virtual ICollection<AwardsShareManager> AwardsShareManagers { get; set; }
        public virtual ICollection<AwardsSharePlayer> AwardsSharePlayers { get; set; }
        public virtual ICollection<Batting> Batting { get; set; }
        public virtual ICollection<BattingPost> BattingPost { get; set; }
        public virtual ICollection<CollegePlaying> CollegePlaying { get; set; }
        public virtual ICollection<Fielding> Fielding { get; set; }
        public virtual ICollection<FieldingOf> FieldingOf { get; set; }
        public virtual ICollection<FieldingOFsplit> FieldingOfsplit { get; set; }
        public virtual ICollection<FieldingPost> FieldingPost { get; set; }
        public virtual ICollection<HallOfFame> HallOfFame { get; set; }
        public virtual ICollection<Manager> Managers { get; set; }
        public virtual ICollection<ManagersHalf> ManagersHalf { get; set; }
        public virtual ICollection<Pitching> Pitching { get; set; }
        public virtual ICollection<PitchingPost> PitchingPost { get; set; }
        public virtual ICollection<Salary> Salaries { get; set; }
    }
}
