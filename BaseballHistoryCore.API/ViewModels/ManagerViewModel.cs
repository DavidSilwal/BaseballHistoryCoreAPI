﻿namespace BaseballHistoryCore.API.ViewModels
{
    public class ManagerViewModel
    {
        public string PlayerId { get; set; }
        public string TeamId { get; set; }
        public string LgId { get; set; }
        public short YearId { get; set; }
        public short Inseason { get; set; }
        public short? G { get; set; }
        public short? W { get; set; }
        public short? L { get; set; }
        public short? Rank { get; set; }
        public string PlyrMgr { get; set; }

        public virtual MasterViewModel Player { get; set; }
        public virtual TeamViewModel Teams { get; set; }
    }
}
