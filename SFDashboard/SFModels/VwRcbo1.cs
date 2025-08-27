using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwRcbo1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Barge Flag")]
        [StringLength(2)]
        public string? BargeFlag { get; set; }
        [Column("Barge ID")]
        [StringLength(10)]
        public string? BargeId { get; set; }
        [Column("Barge Name")]
        [StringLength(50)]
        public string? BargeName { get; set; }
        [Column("Barge No")]
        [StringLength(20)]
        public string? BargeNo { get; set; }
        [Column(TypeName = "decimal(9, 3)")]
        public decimal? Beam { get; set; }
        [Column(TypeName = "decimal(9, 3)")]
        public decimal? Draft { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        public decimal? Grt { get; set; }
        [Column(TypeName = "decimal(9, 3)")]
        public decimal? Length { get; set; }
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
        [StringLength(50)]
        public string Status { get; set; } = null!;
    }
}
