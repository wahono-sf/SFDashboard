using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwGlpp1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Amortization Amt", TypeName = "decimal(17, 2)")]
        public decimal? AmortizationAmt { get; set; }
        [Column("Amortization Balance Period")]
        public int? AmortizationBalancePeriod { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Cheque No")]
        [StringLength(20)]
        public string? ChequeNo { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Expenses Acc Code")]
        [StringLength(15)]
        public string? ExpensesAccCode { get; set; }
        [Column("Expenses Amt", TypeName = "decimal(17, 2)")]
        public decimal? ExpensesAmt { get; set; }
        [Column("Expenses Type")]
        [StringLength(5)]
        public string? ExpensesType { get; set; }
        [Column("Initial Prepayment Balance", TypeName = "decimal(17, 2)")]
        public decimal? InitialPrepaymentBalance { get; set; }
        [Column("Invoice No")]
        [StringLength(20)]
        public string? InvoiceNo { get; set; }
        [Column("Next Journal Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? NextJournalDate { get; set; }
        [Column("No Of Amortization Period")]
        public int? NoOfAmortizationPeriod { get; set; }
        [StringLength(255)]
        public string? Note { get; set; }
        [Column("Payment Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? PaymentDate { get; set; }
        [Column("Prepayment Acc Code")]
        [StringLength(15)]
        public string? PrepaymentAccCode { get; set; }
        [Column("Prepayment Code")]
        [StringLength(10)]
        public string PrepaymentCode { get; set; } = null!;
        [Column("Prepayment Name")]
        [StringLength(50)]
        public string? PrepaymentName { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Vendor Code")]
        [StringLength(10)]
        public string? VendorCode { get; set; }
        [Column("Vendor Name")]
        [StringLength(50)]
        public string? VendorName { get; set; }
        [Column("Work Station")]
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
        [StringLength(3)]
        public string Status { get; set; } = null!;
        [Column("Created By")]
        [StringLength(50)]
        public string CreatedBy { get; set; } = null!;
        [Column("Created At")]
        [StringLength(19)]
        [Unicode(false)]
        public string? CreatedAt { get; set; }
        [Column("Updated By")]
        [StringLength(50)]
        public string UpdatedBy { get; set; } = null!;
        [Column("Updated At")]
        [StringLength(19)]
        [Unicode(false)]
        public string? UpdatedAt { get; set; }
    }
}
