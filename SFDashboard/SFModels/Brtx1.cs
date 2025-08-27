using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("brtx1")]
    public partial class Brtx1
    {
        [Key]
        [StringLength(15)]
        public string AccCode { get; set; } = null!;
        [StringLength(15)]
        public string? BankAccCode { get; set; }
        [StringLength(6)]
        public string? BankSlipNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BankStatementDate { get; set; }
        [StringLength(18)]
        public string? ChequeNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? CreditAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? CreditStatementAmt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? DebitAmt { get; set; }
        [StringLength(1)]
        public string? DebitCreditFlag { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? DebitStatementAmt { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        public int? NoOfSequenceUsed { get; set; }
        [StringLength(6)]
        public string? PostMth { get; set; }
        [StringLength(1)]
        public string? Reconciled { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        public int? SequenceNo { get; set; }
        [StringLength(1)]
        public string? SourceCode { get; set; }
        public int? TrxNo { get; set; }
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
