using System;
using System.Collections.Generic;

#nullable disable

namespace Project.Models
{
    public partial class ApplicationType
    {
        public ApplicationType()
        {
            Applications = new HashSet<Application>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Application> Applications { get; set; }
    }
}
