namespace BaseballHistoryCore.API.ViewModels
{
    public class AwardsPlayerViewModel
    {
        public string PlayerId { get; set; }
        public string LgId { get; set; }
        public short YearId { get; set; }
        public string AwardId { get; set; }
        public string Tie { get; set; }
        public string Notes { get; set; }

        public virtual MasterViewModel Player { get; set; }
    }
}
