namespace BaseballHistoryCore.API.ViewModels
{
    public class HomeGameViewModel
    {
        public string TeamId { get; set; }
        public string LgId { get; set; }
        public short YearId { get; set; }
        public string Parkkey { get; set; }
        public string Spanfirst { get; set; }
        public string Spanlast { get; set; }
        public short? Games { get; set; }
        public short? Openings { get; set; }
        public int? Attendance { get; set; }

        public virtual ParkViewModel ParkkeyNavigation { get; set; }
        public virtual TeamViewModel Teams { get; set; }
    }
}
