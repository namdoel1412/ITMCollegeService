using System;
using System.Collections.Generic;

#nullable disable

namespace ITMCollegeService.Models
{
    public partial class Previouseducation
    {

        public int Id { get; set; }
        public string School { get; set; }
        public int EnrollmentNumber { get; set; }
        public string Faculty { get; set; }
        public float Gpa { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
