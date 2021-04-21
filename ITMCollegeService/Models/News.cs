using System;
using System.Collections.Generic;

#nullable disable

namespace ITMCollegeService.Models
{
    public partial class News
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? AdminId { get; set; }
        public DateTime? Created_At { get; set; }
        public DateTime? Updated_At { get; set; }
        public string Thumbnail { get; set; }
        public byte Status { get; set; }
        public byte IsBanner { get; set; }

        public virtual Admin Admin { get; set; }
        public virtual ICollection<CategoryNews> CategoryNews { get; set; }
    }
}
