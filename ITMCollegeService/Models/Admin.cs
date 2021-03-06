using System;
using System.Collections.Generic;

#nullable disable

namespace ITMCollegeService.Models
{
    public class Admin
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int GenderId { get; set; }
        public DateTime? Created_At { get; set; }
        public DateTime? Updated_At { get; set; }
        public int UserId { get; set; }

        public virtual Gender Gender { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<News> News { get; set; }
    }
}
