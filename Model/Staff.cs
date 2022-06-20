using System;
using System.Collections.Generic;

#nullable disable

namespace Project.Models
{
    public partial class Staff
    {
        public Staff()
        {
            Logins = new HashSet<Login>();
        }

        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Phonenumber { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Login> Logins { get; set; }
    }
}
