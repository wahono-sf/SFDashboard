using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSlbs1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Bank Acc Code")]
        [StringLength(15)]
        public string? BankAccCode { get; set; }
        [Column("Bank Code")]
        [StringLength(10)]
        public string? BankCode { get; set; }
        [Column("Bank Slip Amt", TypeName = "decimal(38, 2)")]
        public decimal? BankSlipAmt { get; set; }
        [Column("Bank Slip Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? BankSlipDate { get; set; }
        [Column("Bank Slip No")]
        [StringLength(10)]
        public string? BankSlipNo { get; set; }
        [Column("Bank Slip Seq No")]
        [StringLength(8000)]
        [Unicode(false)]
        public string? BankSlipSeqNo { get; set; }
        [Column("Bank Slip Type")]
        [StringLength(10)]
        public string? BankSlipType { get; set; }
        [Column("Pay Mode")]
        [StringLength(5)]
        public string? PayMode { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
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
