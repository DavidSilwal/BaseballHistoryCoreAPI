using System;
using System.Collections.Generic;

namespace BaseballHistoryCore.Data.DataModels
{
    public partial class TeamFranchise
    {
        public TeamFranchise()
        {
            Teams = new HashSet<Team>();
        }

        public string FranchId { get; set; }
        public string FranchName { get; set; }
        public string Active { get; set; }
        public string Naassoc { get; set; }

        public virtual ICollection<Team> Teams { get; set; }
    }
}
