using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwWmcy1
    {
        [Column("Billing Cycle Code")]
        [StringLength(3)]
        public string BillingCycleCode { get; set; } = null!;
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Cycle Unit")]
        [StringLength(5)]
        public string? CycleUnit { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [Column("No Of Days")]
        public short? NoOfDays { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Created By")]
        [StringLength(50)]
        public string CreatedBy { get; set; } = null!;
        [Column("Created At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CreatedAt { get; set; }
        [Column("Updated By")]
        [StringLength(50)]
        public string UpdatedBy { get; set; } = null!;
        [Column("Updated At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? UpdatedAt { get; set; }
        [StringLength(3)]
        public string Status { get; set; } = null!;
    }
}
