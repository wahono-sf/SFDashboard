using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwBrtx1
    {
        [Column("Acc Code")]
        [StringLength(15)]
        public string AccCode { get; set; } = null!;
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Bank Acc Code")]
        [StringLength(15)]
        public string? BankAccCode { get; set; }
        [Column("Bank Slip No")]
        [StringLength(6)]
        public string? BankSlipNo { get; set; }
        [Column("Bank Statement Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? BankStatementDate { get; set; }
        [Column("Cheque No")]
        [StringLength(18)]
        public string? ChequeNo { get; set; }
        [Column("Credit Amt", TypeName = "decimal(13, 2)")]
        public decimal? CreditAmt { get; set; }
        [Column("Credit Statement Amt", TypeName = "decimal(13, 2)")]
        public decimal? CreditStatementAmt { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? Date { get; set; }
        [Column("Debit Amt", TypeName = "decimal(13, 2)")]
        public decimal? DebitAmt { get; set; }
        [Column("Debit Credit Flag")]
        [StringLength(1)]
        public string? DebitCreditFlag { get; set; }
        [Column("Debit Statement Amt", TypeName = "decimal(13, 2)")]
        public decimal? DebitStatementAmt { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [Column("No Of Sequence Used")]
        public int? NoOfSequenceUsed { get; set; }
        [Column("Post Mth")]
        [StringLength(6)]
        public string? PostMth { get; set; }
        [StringLength(1)]
        public string? Reconciled { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Sequence No")]
        public int? SequenceNo { get; set; }
        [Column("Source Code")]
        [StringLength(1)]
        public string? SourceCode { get; set; }
        [Column("Trx No")]
        public int? TrxNo { get; set; }
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
