using System;
using System.Collections.Generic;

#nullable disable

namespace Project.Models
{
    public partial class Login
    {
        public int Id { get; set; }
        public string RollNumber { get; set; }
        public int? Role { get; set; }
        public int? Student { get; set; }
        public int? Staff { get; set; }
        public string Password { get; set; }

        public virtual Staff StaffNavigation { get; set; }
        public virtual Student StudentNavigation { get; set; }
    }
}
