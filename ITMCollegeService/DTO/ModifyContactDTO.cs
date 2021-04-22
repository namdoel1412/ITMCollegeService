using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITMCollegeService.DTO
{
    public class ModifyContactDTO
    {
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public int StatusId { get; set; }
        public DateTime? Created_At { get; set; }
    }
}
