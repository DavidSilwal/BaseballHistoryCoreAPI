namespace BaseballHistoryCore.API.ViewModels
{
    public class FieldingOfViewModel
    {
        public string PlayerId { get; set; }
        public short YearId { get; set; }
        public short Stint { get; set; }
        public short? Glf { get; set; }
        public short? Gcf { get; set; }
        public short? Grf { get; set; }

        public virtual MasterViewModel Player { get; set; }
    }
}
