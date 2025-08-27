using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class GlBankTransaction
    {
        [Column("Acc Code")]
        [StringLength(15)]
        public string? AccCode { get; set; }
        [Column("Cheque No")]
        [StringLength(20)]
        public string? ChequeNo { get; set; }
        [Column("Clear Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ClearDate { get; set; }
        [Column(TypeName = "decimal(20, 2)")]
        public decimal? Amt { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Curr Rate", TypeName = "decimal(13, 6)")]
        public decimal? CurrRate { get; set; }
        [Column("Local Amt", TypeName = "decimal(20, 2)")]
        public decimal? LocalAmt { get; set; }
        [Column("Reconcil Flag")]
        [StringLength(1)]
        public string? ReconcilFlag { get; set; }
        [Column("Ref No")]
        [StringLength(10)]
        public string? RefNo { get; set; }
        [Column("Cheque Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ChequeDate { get; set; }
        [Column("Trx Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? TrxDate { get; set; }
        [Column("Post Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? PostDate { get; set; }
        [Column("Journal No")]
        [StringLength(20)]
        public string? JournalNo { get; set; }
        [StringLength(3)]
        public string Status { get; set; } = null!;
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
        [Column("Acc Description")]
        [StringLength(50)]
        public string? AccDescription { get; set; }
        [Column("Customer Or Vendor Code")]
        [StringLength(10)]
        public string? CustomerOrVendorCode { get; set; }
        [Column("Customer Or Vendor Name")]
        [StringLength(80)]
        public string? CustomerOrVendorName { get; set; }
        [StringLength(255)]
        public string? Description { get; set; }
        [Column("Invoice Cheque No")]
        [StringLength(20)]
        public string? InvoiceChequeNo { get; set; }
        [Column("Job No")]
        [StringLength(20)]
        public string? JobNo { get; set; }
        [Column("Post Mth")]
        [StringLength(6)]
        public string? PostMth { get; set; }
        [Column("Receipt Or Voucher No")]
        [StringLength(20)]
        public string? ReceiptOrVoucherNo { get; set; }
    }
}
