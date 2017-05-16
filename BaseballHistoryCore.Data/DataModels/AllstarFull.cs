namespace BaseballHistoryCore.Data.DataModels
{
    public class AllstarFull
    {
        public string PlayerId { get; set; }
        public string TeamId { get; set; }
        public string LgId { get; set; }
        public short YearId { get; set; }
        public string GameId { get; set; }
        public short? StartingPos { get; set; }
        public short GameNum { get; set; }
        public short? Gp { get; set; }

        public virtual Master Player { get; set; }
        public virtual Team Teams { get; set; }
    }
}
