using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwGlma1
    {
        [Column("Acc Code")]
        [StringLength(15)]
        public string AccCode { get; set; } = null!;
        [Column("Acc Class")]
        [StringLength(1)]
        public string? AccClass { get; set; }
        [Column("Acc Description")]
        [StringLength(50)]
        public string? AccDescription { get; set; }
        [Column("Acc Type")]
        [StringLength(1)]
        public string? AccType { get; set; }
        [Column("Analysis Code 1")]
        [StringLength(15)]
        public string AnalysisCode1 { get; set; } = null!;
        [Column("Analysis Code 2")]
        [StringLength(15)]
        public string AnalysisCode2 { get; set; } = null!;
        [Column("Analysis Code 3")]
        [StringLength(15)]
        public string AnalysisCode3 { get; set; } = null!;
        [Column("Analysis Code 4")]
        [StringLength(15)]
        public string AnalysisCode4 { get; set; } = null!;
        [Column("Analysis Code 5")]
        [StringLength(15)]
        public string AnalysisCode5 { get; set; } = null!;
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Control Acc Flag")]
        [StringLength(1)]
        public string? ControlAccFlag { get; set; }
        [Column("Heading Flag")]
        [StringLength(1)]
        public string? HeadingFlag { get; set; }
        [Column("Main Acc Flag")]
        [StringLength(1)]
        public string? MainAccFlag { get; set; }
        [Column("Reconcil Flag")]
        [StringLength(1)]
        public string? ReconcilFlag { get; set; }
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
