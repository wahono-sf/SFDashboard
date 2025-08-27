using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("rcbo1")]
    public partial class Rcbo1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(2)]
        public string? BargeFlag { get; set; }
        [Column("BargeID")]
        [StringLength(10)]
        public string? BargeId { get; set; }
        [StringLength(50)]
        public string? BargeName { get; set; }
        [StringLength(20)]
        public string? BargeNo { get; set; }
        [Column(TypeName = "decimal(9, 3)")]
        public decimal? Beam { get; set; }
        [Column(TypeName = "decimal(9, 3)")]
        public decimal? Draft { get; set; }
        [Column("GRT", TypeName = "decimal(8, 2)")]
        public decimal? Grt { get; set; }
        [Column(TypeName = "decimal(9, 3)")]
        public decimal? Length { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(50)]
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
