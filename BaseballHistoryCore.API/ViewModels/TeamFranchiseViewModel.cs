using System.Collections.Generic;

namespace BaseballHistoryCore.API.ViewModels
{
    public class TeamFranchiseViewModel
    {
        public string FranchId { get; set; }
        public string FranchName { get; set; }
        public string Active { get; set; }
        public string Naassoc { get; set; }

        public virtual ICollection<TeamViewModel> Teams { get; set; }
    }
}
