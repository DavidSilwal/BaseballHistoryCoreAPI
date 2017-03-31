using System;
using System.Collections.Generic;

namespace BaseballHistoryCore.Data.DataModels
{
    public partial class HomeGame
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

        public virtual Park ParkkeyNavigation { get; set; }
        public virtual Team Teams { get; set; }
    }
}
