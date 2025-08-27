using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwGlcf1
    {
        [Column("Cash Flow Analysis Code")]
        [StringLength(15)]
        public string CashFlowAnalysisCode { get; set; } = null!;
        [Column("Bold Flag")]
        [StringLength(1)]
        public string? BoldFlag { get; set; }
        [Column("Cash Flow Analysis Name")]
        [StringLength(50)]
        public string? CashFlowAnalysisName { get; set; }
        [Column("Depreciation Flag")]
        [StringLength(1)]
        public string? DepreciationFlag { get; set; }
        [Column("Hide Group Flag")]
        [StringLength(1)]
        public string? HideGroupFlag { get; set; }
        [Column("Reverse Sign Flag")]
        [StringLength(1)]
        public string? ReverseSignFlag { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
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
