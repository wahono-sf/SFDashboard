using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("tncl1")]
    public partial class Tncl1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(1)]
        public string? CancelDclrIndFlag { get; set; }
        [StringLength(70)]
        public string? CancelDocFileName01 { get; set; }
        [StringLength(70)]
        public string? CancelDocFileName02 { get; set; }
        [StringLength(70)]
        public string? CancelDocFileName03 { get; set; }
        [StringLength(70)]
        public string? CancelDocFileName04 { get; set; }
        [StringLength(70)]
        public string? CancelDocFileName05 { get; set; }
        [StringLength(70)]
        public string? CancelDocFileName06 { get; set; }
        [StringLength(70)]
        public string? CancelDocFileName07 { get; set; }
        [StringLength(70)]
        public string? CancelDocFileName08 { get; set; }
        [StringLength(70)]
        public string? CancelDocFileName09 { get; set; }
        [StringLength(70)]
        public string? CancelDocFileName10 { get; set; }
        [StringLength(35)]
        public string? CancelDocType01 { get; set; }
        [StringLength(35)]
        public string? CancelDocType02 { get; set; }
        [StringLength(35)]
        public string? CancelDocType03 { get; set; }
        [StringLength(35)]
        public string? CancelDocType04 { get; set; }
        [StringLength(35)]
        public string? CancelDocType05 { get; set; }
        [StringLength(35)]
        public string? CancelDocType06 { get; set; }
        [StringLength(35)]
        public string? CancelDocType07 { get; set; }
        [StringLength(35)]
        public string? CancelDocType08 { get; set; }
        [StringLength(35)]
        public string? CancelDocType09 { get; set; }
        [StringLength(35)]
        public string? CancelDocType10 { get; set; }
        [StringLength(17)]
        public string? CancelRecipientMbx1 { get; set; }
        [StringLength(17)]
        public string? CancelRecipientMbx2 { get; set; }
        [StringLength(17)]
        public string? CancelRecipientMbx3 { get; set; }
        [StringLength(17)]
        public string? CancelReplacementPermitNo { get; set; }
        [StringLength(4)]
        public string? CancelReasonCode { get; set; }
        [StringLength(3)]
        public string? CancelUpdateIndicator { get; set; }
        [StringLength(6)]
        public string? PermitCode { get; set; }
        [StringLength(17)]
        public string? PermitNo { get; set; }
        public int? TradenetTrxNo { get; set; }
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
