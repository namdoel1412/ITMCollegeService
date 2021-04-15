using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITMCollegeService.DTO
{
    public class GetStudentDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public int? UserId { get; set; }
        public int? FacultyId { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public int GenderId { get; set; }
        public string ResidentialAddress { get; set; }
        public string PermanentAddress { get; set; }
        public string SportsDetail { get; set; }
        public int? PreviousEducationId { get; set; }
        public DateTime? Created_At { get; set; }
        public DateTime? Updated_At { get; set; }
        public int? DepartmentId { get; set; }
    }
}
