using System;
using System.Collections.Generic;

namespace BaseballHistoryCore.API.ViewModels
{
    public partial class SalaryViewModel
    {
        public string PlayerId { get; set; }
        public string TeamId { get; set; }
        public string LgId { get; set; }
        public short YearId { get; set; }
        public double? SalaryAmount { get; set; }

        public virtual MasterViewModel Player { get; set; }
        public virtual TeamViewModel Teams { get; set; }
    }
}
