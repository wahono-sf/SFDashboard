using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwTnex1
    {
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string CurrCode { get; set; } = null!;
        [Column("Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [Column("Curr Description")]
        [StringLength(30)]
        public string? CurrDescription { get; set; }
        [Column("Large Curr Name")]
        [StringLength(30)]
        public string? LargeCurrName { get; set; }
        [Column("Markup Percent", TypeName = "decimal(13, 2)")]
        public decimal? MarkupPercent { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Small Curr Name")]
        [StringLength(30)]
        public string? SmallCurrName { get; set; }
        [Column("Variance Percent", TypeName = "decimal(13, 3)")]
        public decimal? VariancePercent { get; set; }
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
