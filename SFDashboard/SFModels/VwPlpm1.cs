using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwPlpm1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Address 1")]
        [StringLength(50)]
        public string? Address1 { get; set; }
        [Column("Address 2")]
        [StringLength(50)]
        public string? Address2 { get; set; }
        [Column("Address 3")]
        [StringLength(50)]
        public string? Address3 { get; set; }
        [Column("Address 4")]
        [StringLength(50)]
        public string? Address4 { get; set; }
        [Column("Approve By")]
        [StringLength(50)]
        public string? ApproveBy { get; set; }
        [Column("Approve Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ApproveDate { get; set; }
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
        [Column("Charge Amt 1", TypeName = "decimal(17, 2)")]
        public decimal? ChargeAmt1 { get; set; }
        [Column("Charge Amt 2", TypeName = "decimal(17, 2)")]
        public decimal? ChargeAmt2 { get; set; }
        [Column("Charge Amt 3", TypeName = "decimal(17, 2)")]
        public decimal? ChargeAmt3 { get; set; }
        [Column("Charge Amt 4", TypeName = "decimal(17, 2)")]
        public decimal? ChargeAmt4 { get; set; }
        [Column("Charge Amt 5", TypeName = "decimal(17, 2)")]
        public decimal? ChargeAmt5 { get; set; }
        [Column("Check By")]
        [StringLength(50)]
        public string? CheckBy { get; set; }
        [Column("Check Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? CheckDate { get; set; }
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
        [Column("Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [Column("Customer Code")]
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [Column("Customer Name")]
        [StringLength(80)]
        public string? CustomerName { get; set; }
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
        [Column("Event Template Name")]
        [StringLength(50)]
        public string? EventTemplateName { get; set; }
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
        [Column("Lock By")]
        [StringLength(50)]
        public string? LockBy { get; set; }
        [Column("Lock Flag")]
        [StringLength(1)]
        public string? LockFlag { get; set; }
        [Column("Pay Code")]
        [StringLength(3)]
        public string? PayCode { get; set; }
        [Column("Payment Amt", TypeName = "decimal(17, 2)")]
        public decimal? PaymentAmt { get; set; }
        [Column("Payment Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? PaymentDate { get; set; }
        [Column("Payment Local Amt", TypeName = "decimal(17, 2)")]
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
        [Column("Print Count")]
        public byte? PrintCount { get; set; }
        [Column("Ref No")]
        [StringLength(10)]
        public string? RefNo { get; set; }
        [StringLength(50)]
        public string? Reference { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Request By")]
        [StringLength(50)]
        public string? RequestBy { get; set; }
        [Column("Request To")]
        [StringLength(250)]
        public string? RequestTo { get; set; }
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
        [Column("Vendor Type")]
        [StringLength(5)]
        public string? VendorType { get; set; }
        [Column("Voucher No")]
        [StringLength(20)]
        public string? VoucherNo { get; set; }
        [Column("Voucher Type")]
        [StringLength(2)]
        public string? VoucherType { get; set; }
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
