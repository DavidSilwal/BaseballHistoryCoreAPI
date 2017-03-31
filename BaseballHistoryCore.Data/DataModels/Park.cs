using System;
using System.Collections.Generic;

namespace BaseballHistoryCore.Data.DataModels
{
    public partial class Park
    {
        public Park()
        {
            HomeGames = new HashSet<HomeGame>();
        }

        public int Id { get; set; }
        public string Parkalias { get; set; }
        public string Parkkey { get; set; }
        public string Parkname { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public virtual ICollection<HomeGame> HomeGames { get; set; }
    }
}
