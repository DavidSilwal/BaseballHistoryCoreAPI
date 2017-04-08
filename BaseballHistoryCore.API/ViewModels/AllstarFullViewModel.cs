using System;
using System.Collections.Generic;

namespace BaseballHistoryCore.API.ViewModels
{
    public partial class AllstarFullViewModel
    {
        public string PlayerId { get; set; }
        public string TeamId { get; set; }
        public string LgId { get; set; }
        public short YearId { get; set; }
        public string GameId { get; set; }
        public short? StartingPos { get; set; }
        public short GameNum { get; set; }
        public short? Gp { get; set; }

        public virtual MasterViewModel Player { get; set; }
        public virtual TeamViewModel Teams { get; set; }
    }
}
