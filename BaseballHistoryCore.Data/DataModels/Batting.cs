namespace BaseballHistoryCore.Data.DataModels
{
    public class Batting
    {
        public string PlayerId { get; set; }
        public string TeamId { get; set; }
        public string LgId { get; set; }
        public short YearId { get; set; }
        public short Stint { get; set; }
        public short? G { get; set; }
        public short? GBatting { get; set; }
        public short? Ab { get; set; }
        public short? R { get; set; }
        public short? H { get; set; }
        public short? _2B { get; set; }
        public short? _3B { get; set; }
        public short? Hr { get; set; }
        public short? Rbi { get; set; }
        public short? Sb { get; set; }
        public short? Cs { get; set; }
        public short? Bb { get; set; }
        public short? So { get; set; }
        public short? Ibb { get; set; }
        public short? Hbp { get; set; }
        public short? Sh { get; set; }
        public short? Sf { get; set; }
        public short? Gidp { get; set; }
        public short? GOld { get; set; }

        public virtual Master Player { get; set; }
        public virtual Team Teams { get; set; }
    }
}
