using System;
using System.Collections.Generic;

#nullable disable

namespace Project.Models
{
    public partial class District
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? City { get; set; }

        public virtual City CityNavigation { get; set; }
    }
}
