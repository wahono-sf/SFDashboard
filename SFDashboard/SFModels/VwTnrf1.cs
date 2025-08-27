using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwTnrf1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Dclr Ind Flag")]
        [StringLength(1)]
        public string? DclrIndFlag { get; set; }
        [Column("Doc File Name 01")]
        [StringLength(70)]
        public string? DocFileName01 { get; set; }
        [Column("Doc File Name 02")]
        [StringLength(70)]
        public string? DocFileName02 { get; set; }
        [Column("Doc File Name 03")]
        [StringLength(70)]
        public string? DocFileName03 { get; set; }
        [Column("Doc File Name 04")]
        [StringLength(70)]
        public string? DocFileName04 { get; set; }
        [Column("Doc File Name 05")]
        [StringLength(70)]
        public string? DocFileName05 { get; set; }
        [Column("Doc File Name 06")]
        [StringLength(70)]
        public string? DocFileName06 { get; set; }
        [Column("Doc File Name 07")]
        [StringLength(70)]
        public string? DocFileName07 { get; set; }
        [Column("Doc File Name 08")]
        [StringLength(70)]
        public string? DocFileName08 { get; set; }
        [Column("Doc File Name 09")]
        [StringLength(70)]
        public string? DocFileName09 { get; set; }
        [Column("Doc File Name 10")]
        [StringLength(70)]
        public string? DocFileName10 { get; set; }
        [Column("Doc Type 01")]
        [StringLength(35)]
        public string? DocType01 { get; set; }
        [Column("Doc Type 02")]
        [StringLength(35)]
        public string? DocType02 { get; set; }
        [Column("Doc Type 03")]
        [StringLength(35)]
        public string? DocType03 { get; set; }
        [Column("Doc Type 04")]
        [StringLength(35)]
        public string? DocType04 { get; set; }
        [Column("Doc Type 05")]
        [StringLength(35)]
        public string? DocType05 { get; set; }
        [Column("Doc Type 06")]
        [StringLength(35)]
        public string? DocType06 { get; set; }
        [Column("Doc Type 07")]
        [StringLength(35)]
        public string? DocType07 { get; set; }
        [Column("Doc Type 08")]
        [StringLength(35)]
        public string? DocType08 { get; set; }
        [Column("Doc Type 09")]
        [StringLength(35)]
        public string? DocType09 { get; set; }
        [Column("Doc Type 10")]
        [StringLength(35)]
        public string? DocType10 { get; set; }
        [Column("No Of Items")]
        public int? NoOfItems { get; set; }
        [Column("Permit Code")]
        [StringLength(6)]
        public string? PermitCode { get; set; }
        [Column("Permit No")]
        [StringLength(17)]
        public string? PermitNo { get; set; }
        [Column("Recipient Mbx 1")]
        [StringLength(17)]
        public string? RecipientMbx1 { get; set; }
        [Column("Recipient Mbx 2")]
        [StringLength(17)]
        public string? RecipientMbx2 { get; set; }
        [Column("Recipient Mbx 3")]
        [StringLength(17)]
        public string? RecipientMbx3 { get; set; }
        [Column("Replacement Permit No")]
        [StringLength(17)]
        public string? ReplacementPermitNo { get; set; }
        [StringLength(255)]
        public string? Reason { get; set; }
        [Column("Reason Code")]
        [StringLength(4)]
        public string? ReasonCode { get; set; }
        [Column("Total Customs Refund Amt", TypeName = "decimal(16, 2)")]
        public decimal? TotalCustomsRefundAmt { get; set; }
        [Column("Total Excise Refund Amt", TypeName = "decimal(16, 2)")]
        public decimal? TotalExciseRefundAmt { get; set; }
        [Column("Total Gst Refund Amt", TypeName = "decimal(16, 2)")]
        public decimal? TotalGstRefundAmt { get; set; }
        [Column("Total Other Refund Amt", TypeName = "decimal(16, 2)")]
        public decimal? TotalOtherRefundAmt { get; set; }
        [Column("Tradenet Trx No")]
        public int? TradenetTrxNo { get; set; }
        [Column("Update Indicator")]
        [StringLength(3)]
        public string? UpdateIndicator { get; set; }
        [StringLength(3)]
        public string? Status { get; set; }
        [Column("Created By")]
        [StringLength(50)]
        public string? CreatedBy { get; set; }
        [Column("Created At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CreatedAt { get; set; }
        [Column("Updated By")]
        [StringLength(50)]
        public string? UpdatedBy { get; set; }
        [Column("Updated At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? UpdatedAt { get; set; }
    }
}
