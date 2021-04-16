using System;
using System.Collections.Generic;

#nullable disable

namespace ITMCollegeService.Models
{
    public partial class User
    {

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int StatusId { get; set; }

        public virtual Status Status { get; set; }
        public virtual Student Student { get; set; }
        public virtual ICollection<Admin> Admins { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
