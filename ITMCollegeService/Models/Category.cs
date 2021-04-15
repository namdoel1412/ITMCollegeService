using System;
using System.Collections.Generic;

#nullable disable

namespace ITMCollegeService.Models
{
    public partial class Category
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public byte IsOnHeader { get; set; }

        public virtual ICollection<CategoryNews> CategoryNews { get; set; }
    }
}
