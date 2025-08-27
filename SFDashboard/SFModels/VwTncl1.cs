using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwTncl1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Cancel Dclr Ind Flag")]
        [StringLength(1)]
        public string? CancelDclrIndFlag { get; set; }
        [Column("Cancel Doc File Name 01")]
        [StringLength(70)]
        public string? CancelDocFileName01 { get; set; }
        [Column("Cancel Doc File Name 02")]
        [StringLength(70)]
        public string? CancelDocFileName02 { get; set; }
        [Column("Cancel Doc File Name 03")]
        [StringLength(70)]
        public string? CancelDocFileName03 { get; set; }
        [Column("Cancel Doc File Name 04")]
        [StringLength(70)]
        public string? CancelDocFileName04 { get; set; }
        [Column("Cancel Doc File Name 05")]
        [StringLength(70)]
        public string? CancelDocFileName05 { get; set; }
        [Column("Cancel Doc File Name 06")]
        [StringLength(70)]
        public string? CancelDocFileName06 { get; set; }
        [Column("Cancel Doc File Name 07")]
        [StringLength(70)]
        public string? CancelDocFileName07 { get; set; }
        [Column("Cancel Doc File Name 08")]
        [StringLength(70)]
        public string? CancelDocFileName08 { get; set; }
        [Column("Cancel Doc File Name 09")]
        [StringLength(70)]
        public string? CancelDocFileName09 { get; set; }
        [Column("Cancel Doc File Name 10")]
        [StringLength(70)]
        public string? CancelDocFileName10 { get; set; }
        [Column("Cancel Doc Type 01")]
        [StringLength(35)]
        public string? CancelDocType01 { get; set; }
        [Column("Cancel Doc Type 02")]
        [StringLength(35)]
        public string? CancelDocType02 { get; set; }
        [Column("Cancel Doc Type 03")]
        [StringLength(35)]
        public string? CancelDocType03 { get; set; }
        [Column("Cancel Doc Type 04")]
        [StringLength(35)]
        public string? CancelDocType04 { get; set; }
        [Column("Cancel Doc Type 05")]
        [StringLength(35)]
        public string? CancelDocType05 { get; set; }
        [Column("Cancel Doc Type 06")]
        [StringLength(35)]
        public string? CancelDocType06 { get; set; }
        [Column("Cancel Doc Type 07")]
        [StringLength(35)]
        public string? CancelDocType07 { get; set; }
        [Column("Cancel Doc Type 08")]
        [StringLength(35)]
        public string? CancelDocType08 { get; set; }
        [Column("Cancel Doc Type 09")]
        [StringLength(35)]
        public string? CancelDocType09 { get; set; }
        [Column("Cancel Doc Type 10")]
        [StringLength(35)]
        public string? CancelDocType10 { get; set; }
        [Column("Cancel Recipient Mbx 1")]
        [StringLength(17)]
        public string? CancelRecipientMbx1 { get; set; }
        [Column("Cancel Recipient Mbx 2")]
        [StringLength(17)]
        public string? CancelRecipientMbx2 { get; set; }
        [Column("Cancel Recipient Mbx 3")]
        [StringLength(17)]
        public string? CancelRecipientMbx3 { get; set; }
        [Column("Cancel Replacement Permit No")]
        [StringLength(17)]
        public string? CancelReplacementPermitNo { get; set; }
        [Column("Cancel Reason Code")]
        [StringLength(4)]
        public string? CancelReasonCode { get; set; }
        [Column("Cancel Update Indicator")]
        [StringLength(3)]
        public string? CancelUpdateIndicator { get; set; }
        [Column("Permit Code")]
        [StringLength(6)]
        public string? PermitCode { get; set; }
        [Column("Permit No")]
        [StringLength(17)]
        public string? PermitNo { get; set; }
        [Column("Tradenet Trx No")]
        public int? TradenetTrxNo { get; set; }
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
