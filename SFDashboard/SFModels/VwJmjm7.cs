using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwJmjm7
    {
        [Column("Job No")]
        [StringLength(20)]
        public string JobNo { get; set; } = null!;
        [Column("Job Line Item No")]
        public int JobLineItemNo { get; set; }
        [Column("Event Line Item No")]
        public int EventLineItemNo { get; set; }
        [Column("BCC Email Address")]
        [StringLength(255)]
        public string? BccEmailAddress { get; set; }
        [Column("CC Email Address")]
        [StringLength(255)]
        public string? CcEmailAddress { get; set; }
        [Column("Email Body")]
        [StringLength(3000)]
        public string? EmailBody { get; set; }
        [StringLength(255)]
        public string? Subject { get; set; }
        [Column("To Email Address")]
        [StringLength(255)]
        public string? ToEmailAddress { get; set; }
    }
}
