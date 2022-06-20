using System;
using System.Collections.Generic;

#nullable disable

namespace Project.Models
{
    public partial class Folk
    {
        public Folk()
        {
            Students = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
