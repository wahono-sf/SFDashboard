using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSlcs1
    {
        [Column("Key ID")]
        public int KeyId { get; set; }
        [Column("Acc Code")]
        [StringLength(15)]
        public string? AccCode { get; set; }
        [Column(TypeName = "decimal(20, 2)")]
        public decimal? Amt { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Bank Slip Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? BankSlipDate { get; set; }
        [Column("Bank Slip No")]
        [StringLength(10)]
        public string? BankSlipNo { get; set; }
        [Column("Cheque No")]
        [StringLength(20)]
        public string? ChequeNo { get; set; }
        [Column("Cheque Date", TypeName = "datetime")]
        public DateTime? ChequeDate { get; set; }
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
        [StringLength(255)]
        public string? Description { get; set; }
        [Column("H Awb Or H Bl No")]
        [StringLength(30)]
        public string? HAwbOrHBlNo { get; set; }
        [Column("Item Code")]
        [StringLength(30)]
        public string? ItemCode { get; set; }
        [Column("Invoice Cheque No")]
        [StringLength(20)]
        public string? InvoiceChequeNo { get; set; }
        [Column("Job No")]
        [StringLength(30)]
        public string? JobNo { get; set; }
        [Column("Journal Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? JournalDate { get; set; }
        [Column("Journal No")]
        [StringLength(20)]
        public string? JournalNo { get; set; }
        [Column("Line Item No")]
        public int? LineItemNo { get; set; }
        [Column("Local Amt", TypeName = "decimal(20, 2)")]
        public decimal? LocalAmt { get; set; }
        [Column("M Awb Or O Bl No")]
        [StringLength(30)]
        public string? MAwbOrOBlNo { get; set; }
        [Column("Post Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? PostDate { get; set; }
        [Column("Post Mth")]
        [StringLength(6)]
        public string? PostMth { get; set; }
        [Column("Receipt No")]
        [StringLength(20)]
        public string? ReceiptNo { get; set; }
        [Column("Ref No")]
        [StringLength(10)]
        public string? RefNo { get; set; }
        [StringLength(1000)]
        public string? Remark { get; set; }
        [Column("Sale Order No")]
        [StringLength(1)]
        [Unicode(false)]
        public string SaleOrderNo { get; set; } = null!;
        [Column("Transit No")]
        [StringLength(1)]
        [Unicode(false)]
        public string TransitNo { get; set; } = null!;
        [Column("Trx Type")]
        [StringLength(1)]
        public string? TrxType { get; set; }
        [Column("Trx Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? TrxDate { get; set; }
        [Column("Voucher No")]
        [StringLength(20)]
        public string? VoucherNo { get; set; }
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
