using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Composition;
using System.Data;

namespace SFDashboard.Models
{
    public class Tab
    {
        [Key]
        public int TabCode { get; set; }
        public string? TabDescription { get; set; }
        public string? SourceFilter { get; set; }

        [NotMapped]
        public dynamic DataFilter { get; set; }
  

    }
   
}
