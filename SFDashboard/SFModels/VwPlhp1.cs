using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwPlhp1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Acc Code")]
        [StringLength(15)]
        public string? AccCode { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Bank Code")]
        [StringLength(10)]
        public string? BankCode { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Hire Purchase Agreement No")]
        [StringLength(20)]
        public string? HirePurchaseAgreementNo { get; set; }
        [Column("Hire Purchase Amt", TypeName = "decimal(13, 2)")]
        public decimal? HirePurchaseAmt { get; set; }
        [Column("Hire Purchase Code")]
        [StringLength(10)]
        public string HirePurchaseCode { get; set; } = null!;
        [Column("Hire Purchase Company Code")]
        [StringLength(10)]
        public string? HirePurchaseCompanyCode { get; set; }
        [Column("Hire Purchase Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? HirePurchaseDate { get; set; }
        [Column("Hire Purchase Name")]
        [StringLength(50)]
        public string? HirePurchaseName { get; set; }
        [Column("Initial Outstanding Balance", TypeName = "decimal(13, 2)")]
        public decimal? InitialOutstandingBalance { get; set; }
        [Column("Interest Acc Code")]
        [StringLength(15)]
        public string? InterestAccCode { get; set; }
        [Column("Interest Rate", TypeName = "decimal(13, 4)")]
        public decimal? InterestRate { get; set; }
        [Column("Interest Suspense Acc Code")]
        [StringLength(15)]
        public string? InterestSuspenseAccCode { get; set; }
        [Column("Last Interest Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastInterestAmt { get; set; }
        [Column("Monthly Interest Amt", TypeName = "decimal(13, 2)")]
        public decimal? MonthlyInterestAmt { get; set; }
        [Column("Monthly Payment Amt", TypeName = "decimal(13, 2)")]
        public decimal? MonthlyPaymentAmt { get; set; }
        [Column("Next Due Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? NextDueDate { get; set; }
        [Column("No Of Installment")]
        public int? NoOfInstallment { get; set; }
        [StringLength(255)]
        public string? Note { get; set; }
        [Column("Pay Mode")]
        [StringLength(5)]
        public string? PayMode { get; set; }
        [Column("Purchase Amt", TypeName = "decimal(13, 2)")]
        public decimal? PurchaseAmt { get; set; }
        [Column("Purchase Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? PurchaseDate { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Unpaid Installment")]
        public int? UnpaidInstallment { get; set; }
        [Column("Vendor Code")]
        [StringLength(10)]
        public string? VendorCode { get; set; }
        [Column("Voucher Type")]
        [StringLength(2)]
        public string? VoucherType { get; set; }
        [Column("Work Station")]
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
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
        [StringLength(3)]
        public string Status { get; set; } = null!;
    }
}
