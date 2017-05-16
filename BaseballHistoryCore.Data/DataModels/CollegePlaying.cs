namespace BaseballHistoryCore.Data.DataModels
{
    public class CollegePlaying
    {
        public string PlayerId { get; set; }
        public short YearId { get; set; }
        public string SchoolId { get; set; }

        public virtual Master Player { get; set; }
        public virtual School School { get; set; }
    }
}
