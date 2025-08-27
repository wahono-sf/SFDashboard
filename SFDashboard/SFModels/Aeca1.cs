using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("aeca1")]
    public partial class Aeca1
    {
        [Key]
        [StringLength(20)]
        public string AwbNo { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime? FlightDate { get; set; }
        [StringLength(20)]
        public string? NewAwbNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? NewCcFrtAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? NewCcOtherAmt { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? NewChargeWeight { get; set; }
        [Column(TypeName = "decimal(6, 3)")]
        public decimal? NewCommissionPercent { get; set; }
        [StringLength(3)]
        public string? NewDestCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NewExecuteDate { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? NewPpFrtAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? NewPpOtherAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? OriginCcFrtAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? OriginCcOtherAmt { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? OriginChargeWeight { get; set; }
        [Column(TypeName = "decimal(6, 3)")]
        public decimal? OriginCommissionPercent { get; set; }
        [StringLength(3)]
        public string? OriginDestCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OriginExecuteDate { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? OriginPpFrtAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? OriginPpOtherAmt { get; set; }
        [StringLength(1)]
        public string? Recordtype { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(50)]
        public string? Remark1 { get; set; }
        [StringLength(50)]
        public string? Remark2 { get; set; }
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
