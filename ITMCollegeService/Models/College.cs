using System;
using System.Collections.Generic;

#nullable disable

namespace ITMCollegeService.Models
{
    public partial class College
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Logo { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Collegeaddress> Collegeaddresses { get; set; }
    }
}
