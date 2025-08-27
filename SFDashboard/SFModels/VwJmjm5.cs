using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwJmjm5
    {
        [Column("Job No")]
        [StringLength(20)]
        public string JobNo { get; set; } = null!;
        [Column("Line Item No")]
        public int LineItemNo { get; set; }
        [Column("Event Code")]
        [StringLength(10)]
        public string? EventCode { get; set; }
        [Column("Job Old Status")]
        [StringLength(10)]
        public string? JobOldStatus { get; set; }
        [Column("Job Status")]
        [StringLength(10)]
        public string? JobStatus { get; set; }
        [Column("Job Status Date")]
        [StringLength(16)]
        [Unicode(false)]
        public string? JobStatusDate { get; set; }
    }
}
