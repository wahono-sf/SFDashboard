using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class PlCashPurchase2
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Apply To Invoice")]
        [StringLength(20)]
        public string? ApplyToInvoice { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Bank Acc Code")]
        [StringLength(15)]
        public string? BankAccCode { get; set; }
        [Column("Bank Code")]
        [StringLength(10)]
        public string? BankCode { get; set; }
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
        [Column("Curr Rate", TypeName = "decimal(13, 6)")]
        public decimal? CurrRate { get; set; }
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
        [Column("Discount Amt", TypeName = "decimal(13, 2)")]
        public decimal? DiscountAmt { get; set; }
        [Column("Discount Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? DiscountDate { get; set; }
        [Column("Discount Day")]
        public short? DiscountDay { get; set; }
        [Column("Discount Due Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? DiscountDueDate { get; set; }
        [Column("Discount Local Amt", TypeName = "decimal(13, 2)")]
        public decimal? DiscountLocalAmt { get; set; }
        [Column(TypeName = "decimal(6, 3)")]
        public decimal? Discountpercent { get; set; }
        [Column("Division Code")]
        [StringLength(10)]
        public string? DivisionCode { get; set; }
        [Column("Due Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? DueDate { get; set; }
        [Column("H Awb Or HBl No")]
        [StringLength(20)]
        public string? HAwbOrHblNo { get; set; }
        [Column("Invoice Amt", TypeName = "decimal(13, 2)")]
        public decimal? InvoiceAmt { get; set; }
        [Column("Invoice Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? InvoiceDate { get; set; }
        [Column("Invoice Local Amt", TypeName = "decimal(13, 2)")]
        public decimal? InvoiceLocalAmt { get; set; }
        [Column("Invoice No")]
        [StringLength(20)]
        public string? InvoiceNo { get; set; }
        [Column("Job No")]
        [StringLength(20)]
        public string? JobNo { get; set; }
        [Column("M Awb Or Obl No")]
        [StringLength(20)]
        public string? MAwbOrOblNo { get; set; }
        [Column("Module Code")]
        [StringLength(1)]
        [Unicode(false)]
        public string ModuleCode { get; set; } = null!;
        [Column("Net Day")]
        public short? NetDay { get; set; }
        [Column("Net Of Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? NetOfDate { get; set; }
        [Column("Pay Code")]
        [StringLength(1)]
        public string? PayCode { get; set; }
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
        [Column("Purchase Order No")]
        [StringLength(10)]
        public string? PurchaseOrderNo { get; set; }
        [Column("Ref No")]
        [StringLength(10)]
        public string? RefNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Site Code")]
        [StringLength(20)]
        public string? SiteCode { get; set; }
        [Column("Source Code")]
        [StringLength(1)]
        public string? SourceCode { get; set; }
        [Column("Sub Total Amt", TypeName = "decimal(13, 2)")]
        public decimal? SubTotalAmt { get; set; }
        [Column("Total Exm Amt", TypeName = "decimal(13, 2)")]
        public decimal? TotalExmAmt { get; set; }
        [Column("Total Std Amt", TypeName = "decimal(13, 2)")]
        public decimal? TotalStdAmt { get; set; }
        [Column("Total Zer Amt", TypeName = "decimal(13, 2)")]
        public decimal? TotalZerAmt { get; set; }
        [Column("Trx Type")]
        [StringLength(1)]
        public string? TrxType { get; set; }
        [Column("Vat Amt", TypeName = "decimal(13, 2)")]
        public decimal? VatAmt { get; set; }
        [Column("Vat Code")]
        [StringLength(3)]
        public string? VatCode { get; set; }
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
        [Column("Warehouse Code")]
        [StringLength(6)]
        public string? WarehouseCode { get; set; }
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
        [Column("Line Item No")]
        public short? LineItemNo { get; set; }
        [Column("Item Acc Code")]
        [StringLength(15)]
        public string? ItemAccCode { get; set; }
        [Column("Item Code")]
        [StringLength(30)]
        public string? ItemCode { get; set; }
        [Column("Item Description")]
        [StringLength(50)]
        public string? ItemDescription { get; set; }
        [Column("Item Amt", TypeName = "decimal(13, 2)")]
        public decimal? ItemAmt { get; set; }
        [Column("Item Local Amt", TypeName = "decimal(13, 2)")]
        public decimal? ItemLocalAmt { get; set; }
        [Column("Item Remark")]
        [StringLength(255)]
        public string? ItemRemark { get; set; }
        [Column("Item Job No")]
        [StringLength(20)]
        public string? ItemJobNo { get; set; }
    }
}
