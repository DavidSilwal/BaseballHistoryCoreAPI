using System;
using System.Collections.Generic;

namespace BaseballHistoryCore.Data.DataModels
{
    public partial class Salary
    {
        public string PlayerId { get; set; }
        public string TeamId { get; set; }
        public string LgId { get; set; }
        public short YearId { get; set; }
        public double? SalaryAmount { get; set; }

        public virtual Master Player { get; set; }
        public virtual Team Teams { get; set; }
    }
}
