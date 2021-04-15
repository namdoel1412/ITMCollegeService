using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITMCollegeService.DTO
{
    public class GetCategoryNewsDTO
    {
        public int Id { get; set; }
        public int NewsId { get; set; }
        public int CategoryId { get; set; }
    }
}
