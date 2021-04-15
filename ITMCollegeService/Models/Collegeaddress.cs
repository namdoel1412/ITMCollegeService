using System;
using System.Collections.Generic;

#nullable disable

namespace ITMCollegeService.Models
{
    public partial class Collegeaddress
    {

        public int Id { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public byte IsMainFacility { get; set; }
        public int? CollegeId { get; set; }

        public virtual College College { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
