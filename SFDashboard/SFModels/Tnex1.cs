using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("tnex1")]
    public partial class Tnex1
    {
        [Key]
        [StringLength(3)]
        public string CurrCode { get; set; } = null!;
        [StringLength(30)]
        public string? CurrDescription { get; set; }
        [StringLength(30)]
        public string? LargeCurrName { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? MarkupPercent { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(30)]
        public string? SmallCurrName { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? VariancePercent { get; set; }
        [StringLength(3)]
        public string StatusCode { get; set; } = null!;
        [StringLength(50)]
        public string CreateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CreateDateTime { get; set; }
        [StringLength(50)]
        public string UpdateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime UpdateDateTime { get; set; }
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
    }
}
