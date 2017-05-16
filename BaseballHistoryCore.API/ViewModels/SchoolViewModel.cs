using System.Collections.Generic;

namespace BaseballHistoryCore.API.ViewModels
{
    public class SchoolViewModel
    {
        public string SchoolId { get; set; }
        public string NameFull { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public virtual ICollection<CollegePlayingViewModel> CollegePlaying { get; set; }
    }
}
