using System;
using System.Collections.Generic;

#nullable disable

namespace Project.Models
{
    public partial class Application
    {
        public int Id { get; set; }
        public int? TypeId { get; set; }
        public int? Student { get; set; }
        public string Purpose { get; set; }
        public string File { get; set; }
        public int? Status { get; set; }
        public string Note { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public virtual Student StudentNavigation { get; set; }
        public virtual ApplicationType Type { get; set; }
    }
}
