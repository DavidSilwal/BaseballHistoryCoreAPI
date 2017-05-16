using System.Collections.Generic;

namespace BaseballHistoryCore.API.ViewModels
{
    public class MasterViewModel
    {
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

        public virtual ICollection<AllstarFullViewModel> AllstarFull { get; set; }
        public virtual ICollection<AppearanceViewModel> Appearances { get; set; }
        public virtual ICollection<AwardsManagerViewModel> AwardsManagers { get; set; }
        public virtual ICollection<AwardsPlayerViewModel> AwardsPlayers { get; set; }
        public virtual ICollection<AwardsShareManagerViewModel> AwardsShareManagers { get; set; }
        public virtual ICollection<AwardsSharePlayerViewModel> AwardsSharePlayers { get; set; }
        public virtual ICollection<BattingViewModel> Batting { get; set; }
        public virtual ICollection<BattingPostViewModel> BattingPost { get; set; }
        public virtual ICollection<CollegePlayingViewModel> CollegePlaying { get; set; }
        public virtual ICollection<FieldingViewModel> Fielding { get; set; }
        public virtual ICollection<FieldingOfViewModel> FieldingOf { get; set; }
        public virtual ICollection<FieldingOFsplitViewModel> FieldingOfsplit { get; set; }
        public virtual ICollection<FieldingPostViewModel> FieldingPost { get; set; }
        public virtual ICollection<HallOfFameViewModel> HallOfFame { get; set; }
        public virtual ICollection<ManagerViewModel> Managers { get; set; }
        public virtual ICollection<ManagersHalfViewModel> ManagersHalf { get; set; }
        public virtual ICollection<PitchingViewModel> Pitching { get; set; }
        public virtual ICollection<PitchingPostViewModel> PitchingPost { get; set; }
        public virtual ICollection<SalaryViewModel> Salaries { get; set; }
    }
}
