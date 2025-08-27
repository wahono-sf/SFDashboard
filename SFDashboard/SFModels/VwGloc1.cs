using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwGloc1
    {
        [Column("Charge Code")]
        [StringLength(3)]
        public string ChargeCode { get; set; } = null!;
        [Column("Amt 1", TypeName = "decimal(13, 2)")]
        public decimal? Amt1 { get; set; }
        [Column("Amt 2", TypeName = "decimal(13, 2)")]
        public decimal? Amt2 { get; set; }
        [Column("Amt 3", TypeName = "decimal(13, 2)")]
        public decimal? Amt3 { get; set; }
        [Column("Amt 4", TypeName = "decimal(13, 2)")]
        public decimal? Amt4 { get; set; }
        [Column("Amt 5", TypeName = "decimal(13, 2)")]
        public decimal? Amt5 { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Gl Acc Code 1")]
        [StringLength(15)]
        public string? GlAccCode1 { get; set; }
        [Column("Gl Acc Code 2")]
        [StringLength(15)]
        public string? GlAccCode2 { get; set; }
        [Column("Gl Acc Code 3")]
        [StringLength(15)]
        public string? GlAccCode3 { get; set; }
        [Column("Gl Acc Code 4")]
        [StringLength(15)]
        public string? GlAccCode4 { get; set; }
        [Column("Gl Acc Code 5")]
        [StringLength(15)]
        public string? GlAccCode5 { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Type 1")]
        [StringLength(1)]
        public string? Type1 { get; set; }
        [Column("Type 2")]
        [StringLength(1)]
        public string? Type2 { get; set; }
        [Column("Type 3")]
        [StringLength(1)]
        public string? Type3 { get; set; }
        [Column("Type 4")]
        [StringLength(1)]
        public string? Type4 { get; set; }
        [Column("Type 5")]
        [StringLength(1)]
        public string? Type5 { get; set; }
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
