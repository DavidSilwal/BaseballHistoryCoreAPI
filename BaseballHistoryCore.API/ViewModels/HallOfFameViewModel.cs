using System;
using System.Collections.Generic;

namespace BaseballHistoryCore.API.ViewModels
{
    public partial class HallOfFameViewModel
    {
        public string PlayerId { get; set; }
        public short Yearid { get; set; }
        public string VotedBy { get; set; }
        public short? Ballots { get; set; }
        public short? Needed { get; set; }
        public short? Votes { get; set; }
        public string Inducted { get; set; }
        public string Category { get; set; }
        public string NeededNote { get; set; }

        public virtual MasterViewModel Player { get; set; }
    }
}
