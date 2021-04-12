﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ITMCollegeService.Models
{
    public partial class Category
    {
        public Category()
        {
            CategoryNews = new HashSet<CategoryNews>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CategoryNews> CategoryNews { get; set; }
    }
}
