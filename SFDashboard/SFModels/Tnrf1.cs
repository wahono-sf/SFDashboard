using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("tnrf1")]
    public partial class Tnrf1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(1)]
        public string? DclrIndFlag { get; set; }
        [StringLength(70)]
        public string? DocFileName01 { get; set; }
        [StringLength(70)]
        public string? DocFileName02 { get; set; }
        [StringLength(70)]
        public string? DocFileName03 { get; set; }
        [StringLength(70)]
        public string? DocFileName04 { get; set; }
        [StringLength(70)]
        public string? DocFileName05 { get; set; }
        [StringLength(70)]
        public string? DocFileName06 { get; set; }
        [StringLength(70)]
        public string? DocFileName07 { get; set; }
        [StringLength(70)]
        public string? DocFileName08 { get; set; }
        [StringLength(70)]
        public string? DocFileName09 { get; set; }
        [StringLength(70)]
        public string? DocFileName10 { get; set; }
        [StringLength(35)]
        public string? DocType01 { get; set; }
        [StringLength(35)]
        public string? DocType02 { get; set; }
        [StringLength(35)]
        public string? DocType03 { get; set; }
        [StringLength(35)]
        public string? DocType04 { get; set; }
        [StringLength(35)]
        public string? DocType05 { get; set; }
        [StringLength(35)]
        public string? DocType06 { get; set; }
        [StringLength(35)]
        public string? DocType07 { get; set; }
        [StringLength(35)]
        public string? DocType08 { get; set; }
        [StringLength(35)]
        public string? DocType09 { get; set; }
        [StringLength(35)]
        public string? DocType10 { get; set; }
        public int? NoOfItems { get; set; }
        [StringLength(6)]
        public string? PermitCode { get; set; }
        [StringLength(17)]
        public string? PermitNo { get; set; }
        [StringLength(17)]
        public string? RecipientMbx1 { get; set; }
        [StringLength(17)]
        public string? RecipientMbx2 { get; set; }
        [StringLength(17)]
        public string? RecipientMbx3 { get; set; }
        [StringLength(17)]
        public string? ReplacementPermitNo { get; set; }
        [StringLength(255)]
        public string? Reason { get; set; }
        [StringLength(4)]
        public string? ReasonCode { get; set; }
        [Column(TypeName = "decimal(16, 2)")]
        public decimal? TotalCustomsRefundAmt { get; set; }
        [Column(TypeName = "decimal(16, 2)")]
        public decimal? TotalExciseRefundAmt { get; set; }
        [Column(TypeName = "decimal(16, 2)")]
        public decimal? TotalGstRefundAmt { get; set; }
        [Column(TypeName = "decimal(16, 2)")]
        public decimal? TotalOtherRefundAmt { get; set; }
        public int? TradenetTrxNo { get; set; }
        [StringLength(3)]
        public string? UpdateIndicator { get; set; }
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
