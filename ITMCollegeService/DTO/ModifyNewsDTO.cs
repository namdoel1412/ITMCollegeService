using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITMCollegeService.DTO
{
    public class ModifyNewsDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int? AdminId { get; set; }
        public DateTime? Created_At { get; set; }
        public DateTime? Updated_At { get; set; }
        public byte Status { get; set; }
        public byte IsBanner { get; set; }
    }
}
