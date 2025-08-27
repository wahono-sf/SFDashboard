using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwAeca1
    {
        [Column("Awb No")]
        [StringLength(20)]
        public string AwbNo { get; set; } = null!;
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Flight Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? FlightDate { get; set; }
        [Column("New Awb No")]
        [StringLength(20)]
        public string? NewAwbNo { get; set; }
        [Column("New Cc Frt Amt", TypeName = "decimal(13, 2)")]
        public decimal? NewCcFrtAmt { get; set; }
        [Column("New Cc Other Amt", TypeName = "decimal(13, 2)")]
        public decimal? NewCcOtherAmt { get; set; }
        [Column("New Charge Weight", TypeName = "decimal(13, 4)")]
        public decimal? NewChargeWeight { get; set; }
        [Column("New Commission Percent", TypeName = "decimal(6, 3)")]
        public decimal? NewCommissionPercent { get; set; }
        [Column("New Dest Code")]
        [StringLength(3)]
        public string? NewDestCode { get; set; }
        [Column("New Execute Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? NewExecuteDate { get; set; }
        [Column("New Pp Frt Amt", TypeName = "decimal(13, 2)")]
        public decimal? NewPpFrtAmt { get; set; }
        [Column("New Pp Other Amt", TypeName = "decimal(13, 2)")]
        public decimal? NewPpOtherAmt { get; set; }
        [Column("Origin Cc Frt Amt", TypeName = "decimal(13, 2)")]
        public decimal? OriginCcFrtAmt { get; set; }
        [Column("Origin Cc Other Amt", TypeName = "decimal(13, 2)")]
        public decimal? OriginCcOtherAmt { get; set; }
        [Column("Origin Charge Weight", TypeName = "decimal(13, 4)")]
        public decimal? OriginChargeWeight { get; set; }
        [Column("Origin Commission Percent", TypeName = "decimal(6, 3)")]
        public decimal? OriginCommissionPercent { get; set; }
        [Column("Origin Dest Code")]
        [StringLength(3)]
        public string? OriginDestCode { get; set; }
        [Column("Origin Execute Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? OriginExecuteDate { get; set; }
        [Column("Origin Pp Frt Amt", TypeName = "decimal(13, 2)")]
        public decimal? OriginPpFrtAmt { get; set; }
        [Column("Origin Pp Other Amt", TypeName = "decimal(13, 2)")]
        public decimal? OriginPpOtherAmt { get; set; }
        [Column("Record Type")]
        [StringLength(1)]
        public string? RecordType { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Remark 1")]
        [StringLength(50)]
        public string? Remark1 { get; set; }
        [Column("Remark 2")]
        [StringLength(50)]
        public string? Remark2 { get; set; }
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
