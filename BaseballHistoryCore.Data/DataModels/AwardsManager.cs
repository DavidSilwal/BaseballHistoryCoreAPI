using System;
using System.Collections.Generic;

namespace BaseballHistoryCore.Data.DataModels
{
    public partial class AwardsManager
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
