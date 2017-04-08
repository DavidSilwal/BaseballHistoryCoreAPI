using System;
using System.Collections.Generic;

namespace BaseballHistoryCore.API.ViewModels
{
    public partial class AwardsSharePlayerViewModel
    {
        public string PlayerId { get; set; }
        public string LgId { get; set; }
        public short YearId { get; set; }
        public string AwardId { get; set; }
        public double? PointsWon { get; set; }
        public short? PointsMax { get; set; }
        public double? VotesFirst { get; set; }

        public virtual MasterViewModel Player { get; set; }
    }
}
