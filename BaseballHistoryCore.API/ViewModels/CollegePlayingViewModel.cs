namespace BaseballHistoryCore.API.ViewModels
{
    public class CollegePlayingViewModel
    {
        public string PlayerId { get; set; }
        public short YearId { get; set; }
        public string SchoolId { get; set; }

        public virtual MasterViewModel Player { get; set; }
        public virtual SchoolViewModel School { get; set; }
    }
}
