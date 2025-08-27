using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("gloc1")]
    public partial class Gloc1
    {
        [Key]
        [StringLength(3)]
        public string ChargeCode { get; set; } = null!;
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Amt1 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Amt2 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Amt3 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Amt4 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Amt5 { get; set; }
        [Column("GLAccCode1")]
        [StringLength(15)]
        public string? GlaccCode1 { get; set; }
        [Column("GLAccCode2")]
        [StringLength(15)]
        public string? GlaccCode2 { get; set; }
        [Column("GLAccCode3")]
        [StringLength(15)]
        public string? GlaccCode3 { get; set; }
        [Column("GLAccCode4")]
        [StringLength(15)]
        public string? GlaccCode4 { get; set; }
        [Column("GLAccCode5")]
        [StringLength(15)]
        public string? GlaccCode5 { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(1)]
        public string? Type1 { get; set; }
        [StringLength(1)]
        public string? Type2 { get; set; }
        [StringLength(1)]
        public string? Type3 { get; set; }
        [StringLength(1)]
        public string? Type4 { get; set; }
        [StringLength(1)]
        public string? Type5 { get; set; }
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
