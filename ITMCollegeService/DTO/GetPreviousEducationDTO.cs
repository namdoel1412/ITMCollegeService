using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITMCollegeService.DTO
{
    public class GetPreviousEducationDTO
    {
        public int Id { get; set; }
        public string School { get; set; }
        public int EnrollmentNumber { get; set; }
        public string Faculty { get; set; }
        public float Gpa { get; set; }
    }
}
