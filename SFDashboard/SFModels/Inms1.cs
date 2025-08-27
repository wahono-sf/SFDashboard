using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("inms1")]
    public partial class Inms1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(10)]
        public string CustomerCode { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime? EffectiveDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? InsuranceRate { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? MinPremium { get; set; }
        [StringLength(1)]
        public string RateType { get; set; } = null!;
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? TranshipmentRate { get; set; }
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
