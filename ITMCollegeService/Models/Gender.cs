using System;
using System.Collections.Generic;

#nullable disable

namespace ITMCollegeService.Models
{
    public partial class Gender
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Admin> Admins { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
