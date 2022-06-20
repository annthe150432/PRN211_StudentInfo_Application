using System;
using System.Collections.Generic;

#nullable disable

namespace Project.Models
{
    public partial class City
    {
        public City()
        {
            Districts = new HashSet<District>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? Province { get; set; }

        public virtual Province ProvinceNavigation { get; set; }
        public virtual ICollection<District> Districts { get; set; }
    }
}
