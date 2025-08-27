using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class PlVendorPayment2
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Address 1")]
        [StringLength(45)]
        public string? Address1 { get; set; }
        [Column("Address 2")]
        [StringLength(45)]
        public string? Address2 { get; set; }
        [Column("Address 3")]
        [StringLength(45)]
        public string? Address3 { get; set; }
        [Column("Address 4")]
        [StringLength(45)]
        public string? Address4 { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Auto Hand Flag")]
        [StringLength(1)]
        public string? AutoHandFlag { get; set; }
        [Column("Bank Acc Code")]
        [StringLength(15)]
        public string? BankAccCode { get; set; }
        [Column("Bank Code")]
        [StringLength(10)]
        public string? BankCode { get; set; }
        [Column("Charge Amt 1", TypeName = "decimal(13, 2)")]
        public decimal? ChargeAmt1 { get; set; }
        [Column("Charge Amt 2", TypeName = "decimal(13, 2)")]
        public decimal? ChargeAmt2 { get; set; }
        [Column("Charge Amt 3", TypeName = "decimal(13, 2)")]
        public decimal? ChargeAmt3 { get; set; }
        [Column("Charge Amt 4", TypeName = "decimal(13, 2)")]
        public decimal? ChargeAmt4 { get; set; }
        [Column("Charge Amt 5", TypeName = "decimal(13, 2)")]
        public decimal? ChargeAmt5 { get; set; }
        [Column("Cheque Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ChequeDate { get; set; }
        [Column("Cheque No")]
        [StringLength(20)]
        public string? ChequeNo { get; set; }
        [Column("Clear Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ClearDate { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Curr Rate", TypeName = "decimal(13, 6)")]
        public decimal? CurrRate { get; set; }
        [Column("Customer Code")]
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [Column("Description 1")]
        [StringLength(50)]
        public string? Description1 { get; set; }
        [Column("Description 2")]
        [StringLength(50)]
        public string? Description2 { get; set; }
        [Column("Description 3")]
        [StringLength(50)]
        public string? Description3 { get; set; }
        [Column("Description 4")]
        [StringLength(50)]
        public string? Description4 { get; set; }
        [Column("Description 5")]
        [StringLength(50)]
        public string? Description5 { get; set; }
        [Column("Doc No")]
        [StringLength(20)]
        public string? DocNo { get; set; }
        [Column("Gl Acc Code 1")]
        [StringLength(15)]
        public string? GlAccCode1 { get; set; }
        [Column("Gl Acc Code 2")]
        [StringLength(15)]
        public string? GlAccCode2 { get; set; }
        [Column("Gl Acc Code 3")]
        [StringLength(15)]
        public string? GlAccCode3 { get; set; }
        [Column("Gl Acc Code 4")]
        [StringLength(15)]
        public string? GlAccCode4 { get; set; }
        [Column("Gl Acc Code 5")]
        [StringLength(15)]
        public string? GlAccCode5 { get; set; }
        [Column("Invoice No")]
        [StringLength(20)]
        public string? InvoiceNo { get; set; }
        [Column("Pay Code")]
        [StringLength(3)]
        public string? PayCode { get; set; }
        [Column("Payment Amt", TypeName = "decimal(13, 2)")]
        public decimal? PaymentAmt { get; set; }
        [Column("Payment Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? PaymentDate { get; set; }
        [Column("Payment Local Amt", TypeName = "decimal(13, 2)")]
        public decimal? PaymentLocalAmt { get; set; }
        [Column("Pay Mode")]
        [StringLength(5)]
        public string? PayMode { get; set; }
        [Column("Post By")]
        [StringLength(50)]
        public string? PostBy { get; set; }
        [Column("Post Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? PostDate { get; set; }
        [Column("Post Flag")]
        [StringLength(1)]
        public string? PostFlag { get; set; }
        [Column("Post Mth")]
        [StringLength(6)]
        public string? PostMth { get; set; }
        [Column("Ref No")]
        [StringLength(10)]
        public string? RefNo { get; set; }
        [StringLength(50)]
        public string? Reference { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Site Code")]
        [StringLength(20)]
        public string? SiteCode { get; set; }
        [Column("Trx Type")]
        [StringLength(1)]
        public string? TrxType { get; set; }
        [Column("Vendor Code")]
        [StringLength(10)]
        public string? VendorCode { get; set; }
        [Column("Vendor Name")]
        [StringLength(80)]
        public string? VendorName { get; set; }
        [Column("Voucher No")]
        [StringLength(20)]
        public string? VoucherNo { get; set; }
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
        [Column("Line Item No")]
        public short? LineItemNo { get; set; }
        [Column("Item Acc Code")]
        [StringLength(15)]
        public string? ItemAccCode { get; set; }
        [Column("Apply To Invoice")]
        [StringLength(20)]
        public string? ApplyToInvoice { get; set; }
        [Column("Pay Local Amt", TypeName = "decimal(13, 2)")]
        public decimal? PayLocalAmt { get; set; }
        [Column("Item Pay Amt", TypeName = "decimal(13, 2)")]
        public decimal? ItemPayAmt { get; set; }
        [Column("Paid Invoice No")]
        [StringLength(20)]
        public string? PaidInvoiceNo { get; set; }
        [Column("Item Description")]
        [StringLength(50)]
        public string? ItemDescription { get; set; }
    }
}
