using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSecp1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Apply To Invoice")]
        [StringLength(10)]
        public string? ApplyToInvoice { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Bank Acc Code")]
        [StringLength(15)]
        public string? BankAccCode { get; set; }
        [Column("Cheque Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ChequeDate { get; set; }
        [Column("Cheque No")]
        [StringLength(18)]
        public string? ChequeNo { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
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
        [Column("Discount Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? DiscountDate { get; set; }
        [Column("Discount Day")]
        public int? DiscountDay { get; set; }
        [Column("Discount Due Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? DiscountDueDate { get; set; }
        [Column("Discount Foreign Amt", TypeName = "decimal(13, 2)")]
        public decimal? DiscountForeignAmt { get; set; }
        [Column("Discount Local Amt", TypeName = "decimal(13, 2)")]
        public decimal? DiscountLocalAmt { get; set; }
        [Column("Discount Percent", TypeName = "decimal(6, 3)")]
        public decimal? DiscountPercent { get; set; }
        [Column("Division Code")]
        [StringLength(10)]
        public string? DivisionCode { get; set; }
        [Column("Due Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? DueDate { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Freight { get; set; }
        [Column("H Bl No")]
        [StringLength(20)]
        public string? HBlNo { get; set; }
        [Column("Hold Next No")]
        [StringLength(1)]
        public string? HoldNextNo { get; set; }
        [Column("Invoice Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? InvoiceDate { get; set; }
        [Column("Invoice Foreign Amt", TypeName = "decimal(13, 2)")]
        public decimal? InvoiceForeignAmt { get; set; }
        [Column("Invoice Local Amt", TypeName = "decimal(13, 2)")]
        public decimal? InvoiceLocalAmt { get; set; }
        [Column("Invoice No")]
        [StringLength(10)]
        public string? InvoiceNo { get; set; }
        [Column("Job No")]
        [StringLength(30)]
        public string? JobNo { get; set; }
        [Column("Net Day")]
        public int? NetDay { get; set; }
        [Column("Net Of Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? NetOfDate { get; set; }
        [Column("O Bl No")]
        [StringLength(20)]
        public string? OBlNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Other { get; set; }
        [Column("Pay Code")]
        [StringLength(1)]
        public string? PayCode { get; set; }
        [Column("Post Flag")]
        [StringLength(1)]
        public string? PostFlag { get; set; }
        [Column("Post Liab Flag")]
        [StringLength(1)]
        public string? PostLiabFlag { get; set; }
        [Column("Purchase Order No")]
        [StringLength(10)]
        public string? PurchaseOrderNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Retainer Foreign Amt", TypeName = "decimal(13, 2)")]
        public decimal? RetainerForeignAmt { get; set; }
        [Column("Retainer Local Amt", TypeName = "decimal(13, 2)")]
        public decimal? RetainerLocalAmt { get; set; }
        [Column("Retainer Percent", TypeName = "decimal(6, 3)")]
        public decimal? RetainerPercent { get; set; }
        [Column("Site Code")]
        [StringLength(20)]
        public string? SiteCode { get; set; }
        [Column("Source Code")]
        [StringLength(1)]
        public string? SourceCode { get; set; }
        [Column("Sub Total Amt", TypeName = "decimal(13, 2)")]
        public decimal? SubTotalAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Tax { get; set; }
        [Column("Taxable Flag")]
        [StringLength(1)]
        public string? TaxableFlag { get; set; }
        [Column("Trx Type")]
        [StringLength(1)]
        public string? TrxType { get; set; }
        [Column("Vat Amt", TypeName = "decimal(13, 2)")]
        public decimal? VatAmt { get; set; }
        [Column("Vat Registration No")]
        [StringLength(20)]
        public string? VatRegistrationNo { get; set; }
        [Column("Vendor Code")]
        [StringLength(10)]
        public string? VendorCode { get; set; }
        [Column("Vendor Name")]
        [StringLength(80)]
        public string? VendorName { get; set; }
        [Column("Voucher No")]
        [StringLength(10)]
        public string? VoucherNo { get; set; }
        [Column("Voucher Type")]
        [StringLength(2)]
        public string? VoucherType { get; set; }
        [Column("Warehouse No")]
        [StringLength(5)]
        public string? WarehouseNo { get; set; }
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
