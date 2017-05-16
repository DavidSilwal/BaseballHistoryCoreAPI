namespace BaseballHistoryCore.Data.DataModels
{
    public class AwardsPlayer
    {
        public string PlayerId { get; set; }
        public string LgId { get; set; }
        public short YearId { get; set; }
        public string AwardId { get; set; }
        public string Tie { get; set; }
        public string Notes { get; set; }

        public virtual Master Player { get; set; }
    }
}
