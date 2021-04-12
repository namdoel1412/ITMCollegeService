using System;
using System.Collections.Generic;

#nullable disable

namespace ITMCollegeService.Models
{
    public partial class Status
    {
        public Status()
        {
            Contacts = new HashSet<Contact>();
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
