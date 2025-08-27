using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("glpp1")]
    [Index("PrepaymentCode", Name = "IX_glpp1", IsUnique = true)]
    public partial class Glpp1
    {
        [Key]
        public int TrxNo { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? AmortizationAmt { get; set; }
        public int? AmortizationBalancePeriod { get; set; }
        [StringLength(20)]
        public string? ChequeNo { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [StringLength(15)]
        public string? ExpensesAccCode { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? ExpensesAmt { get; set; }
        [StringLength(5)]
        public string? ExpensesType { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? InitialPrepaymentBalance { get; set; }
        [StringLength(20)]
        public string? InvoiceNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NextJournalDate { get; set; }
        public int? NoOfAmortizationPeriod { get; set; }
        [StringLength(255)]
        public string? Note { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PaymentDate { get; set; }
        [StringLength(15)]
        public string? PrepaymentAccCode { get; set; }
        [StringLength(10)]
        public string PrepaymentCode { get; set; } = null!;
        [StringLength(50)]
        public string? PrepaymentName { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(10)]
        public string? VendorCode { get; set; }
        [StringLength(50)]
        public string? VendorName { get; set; }
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
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
