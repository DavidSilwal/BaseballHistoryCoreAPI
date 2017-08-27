namespace BaseballHistoryCore.API.ViewModels
{
    public class AppearanceViewModel
    {
        public string PlayerId { get; set; }
        public string TeamId { get; set; }
        public string LgId { get; set; }
        public short YearId { get; set; }
        public short? GAll { get; set; }
        public short? Gs { get; set; }
        public short? GBatting { get; set; }
        public short? GDefense { get; set; }
        public short? Gp { get; set; }
        public short? Gc { get; set; }
        public short? G1B { get; set; }
        public short? G2B { get; set; }
        public short? G3B { get; set; }
        public short? GSs { get; set; }
        public short? GLf { get; set; }
        public short? GCf { get; set; }
        public short? GRf { get; set; }
        public short? GOf { get; set; }
        public short? GDh { get; set; }
        public short? GPh { get; set; }
        public short? GPr { get; set; }

        public virtual MasterViewModel Player { get; set; }
        public virtual TeamViewModel Teams { get; set; }
    }
}
