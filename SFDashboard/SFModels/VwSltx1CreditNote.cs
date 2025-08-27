using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSltx1CreditNote
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Acc Code")]
        [StringLength(15)]
        public string? AccCode { get; set; }
        [Column("Ageing Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? AgeingDate { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? Amt { get; set; }
        [Column("Apply To Invoice")]
        [StringLength(20)]
        public string? ApplyToInvoice { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? Balance { get; set; }
        [Column("Cheque No")]
        [StringLength(20)]
        public string? ChequeNo { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [Column("Customer Code")]
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [Column("Customer Name")]
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [Column("Customer Type")]
        [StringLength(5)]
        public string? CustomerType { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [Column("Due Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? DueDate { get; set; }
        [Column("Hawb Or Hbl No")]
        [StringLength(30)]
        public string? HawbOrHblNo { get; set; }
        [Column("Invoice Or Cheque No")]
        [StringLength(20)]
        public string? InvoiceOrChequeNo { get; set; }
        [Column("Job No")]
        [StringLength(30)]
        public string? JobNo { get; set; }
        [Column("Local Amt", TypeName = "decimal(17, 2)")]
        public decimal? LocalAmt { get; set; }
        [Column("Local Balance Amt", TypeName = "decimal(17, 2)")]
        public decimal? LocalBalanceAmt { get; set; }
        [Column("Mark Invoice Flag")]
        [StringLength(1)]
        public string? MarkInvoiceFlag { get; set; }
        [Column("Mawb Or Obl No")]
        [StringLength(30)]
        public string? MawbOrOblNo { get; set; }
        [Column("Payment Flag")]
        [StringLength(1)]
        public string? PaymentFlag { get; set; }
        [Column("Post Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? PostDate { get; set; }
        [Column("Post Mth")]
        [StringLength(6)]
        public string? PostMth { get; set; }
        [StringLength(10)]
        public string? Prefix { get; set; }
        [Column("Purchase Order No")]
        [StringLength(20)]
        public string? PurchaseOrderNo { get; set; }
        [Column("Ref No")]
        [StringLength(10)]
        public string? RefNo { get; set; }
        [StringLength(255)]
        public string? Remarks { get; set; }
        [Column("Revaluate Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? RevaluateCurrRate { get; set; }
        [Column("Salesman Code")]
        [StringLength(10)]
        public string? SalesmanCode { get; set; }
        [Column("Sequence No")]
        public int? SequenceNo { get; set; }
        [Column("Statement Customer Name")]
        [StringLength(80)]
        public string? StatementCustomerName { get; set; }
        [Column("Statement Flag")]
        [StringLength(1)]
        public string? StatementFlag { get; set; }
        [Column("Trx Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? TrxDate { get; set; }
        [Column("Trx Type")]
        [StringLength(1)]
        public string? TrxType { get; set; }
        [Column("Work Station")]
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
        [Column("Branch Code")]
        [StringLength(10)]
        public string? BranchCode { get; set; }
        [Column("Department Code")]
        [StringLength(10)]
        public string? DepartmentCode { get; set; }
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
