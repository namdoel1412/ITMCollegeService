using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITMCollegeService.DTO
{
    public class ModifyDepartmentDTO
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public int FacultyId { get; set; }
    }
}
