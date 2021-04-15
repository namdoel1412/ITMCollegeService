﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ITMCollegeService.Models
{
    public partial class Semester
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
