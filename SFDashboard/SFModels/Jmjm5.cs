using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("jmjm5")]
    public partial class Jmjm5
    {
        [Key]
        [StringLength(30)]
        public string JobNo { get; set; } = null!;
        [Key]
        public int LineItemNo { get; set; }
        [StringLength(10)]
        public string? EventCode { get; set; }
        [StringLength(10)]
        public string? JobOldStatus { get; set; }
        [StringLength(10)]
        public string? JobStatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? JobStatusDate { get; set; }
    }
}
