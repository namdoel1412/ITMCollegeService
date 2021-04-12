using System;
using System.Collections.Generic;

#nullable disable

namespace ITMCollegeService.Models
{
    public partial class Student
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

        public virtual Department Department { get; set; }
        public virtual Faculty Faculty { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual Previouseducation PreviousEducation { get; set; }
        public virtual User User { get; set; }
    }
}
