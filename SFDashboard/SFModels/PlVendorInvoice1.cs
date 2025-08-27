using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class PlVendorInvoice1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Acc Code")]
        [StringLength(15)]
        public string? AccCode { get; set; }
        [Column("Accured Flag")]
        [StringLength(1)]
        public string? AccuredFlag { get; set; }
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
        [Column("Apply To Invoice")]
        [StringLength(20)]
        public string? ApplyToInvoice { get; set; }
        [Column("Approve By")]
        [StringLength(50)]
        public string? ApproveBy { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Awb Or Bl No")]
        [StringLength(20)]
        public string? AwbOrBlNo { get; set; }
        [Column("Bank Code")]
        [StringLength(10)]
        public string? BankCode { get; set; }
        [Column("Cash Amt", TypeName = "decimal(13, 2)")]
        public decimal? CashAmt { get; set; }
        [Column("Cash Local Amt", TypeName = "decimal(13, 2)")]
        public decimal? CashLocalAmt { get; set; }
        [Column("Cheque Amt", TypeName = "decimal(13, 2)")]
        public decimal? ChequeAmt { get; set; }
        [Column("Cheque Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ChequeDate { get; set; }
        [Column("Cheque Local Amt", TypeName = "decimal(13, 2)")]
        public decimal? ChequeLocalAmt { get; set; }
        [Column("Cheque No")]
        [StringLength(20)]
        public string? ChequeNo { get; set; }
        [Column("Clear Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ClearDate { get; set; }
        [Column("Container No")]
        [StringLength(500)]
        public string? ContainerNo { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Curr Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? CurrDate { get; set; }
        [Column("Curr Rate", TypeName = "decimal(13, 6)")]
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
        [Column("Doc No")]
        [StringLength(20)]
        public string? DocNo { get; set; }
        [Column("Doc Remark")]
        [StringLength(255)]
        public string? DocRemark { get; set; }
        [Column("Due Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? DueDate { get; set; }
        [Column("EDI Count")]
        public byte? EdiCount { get; set; }
        [Column("Email Count")]
        public byte? EmailCount { get; set; }
        [Column("Eta Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? EtaDate { get; set; }
        [Column("Etd Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? EtdDate { get; set; }
        [Column("Export Count")]
        public byte? ExportCount { get; set; }
        [Column("Fax Count")]
        public byte? FaxCount { get; set; }
        [Column("H Awb Or H Bl No")]
        [StringLength(20)]
        public string? HAwbOrHBlNo { get; set; }
        [Column("Hire Purchase Code")]
        [StringLength(10)]
        public string? HirePurchaseCode { get; set; }
        [Column("Invoice Amt", TypeName = "decimal(13, 2)")]
        public decimal? InvoiceAmt { get; set; }
        [Column("Invoice And Vat Amt")]
        [StringLength(10)]
        [Unicode(false)]
        public string? InvoiceAndVatAmt { get; set; }
        [Column("Invoice And Vat Local Amt", TypeName = "decimal(13, 2)")]
        public decimal? InvoiceAndVatLocalAmt { get; set; }
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
        [Column("Job Type")]
        [StringLength(2)]
        public string? JobType { get; set; }
        [Column("Lock By")]
        [StringLength(20)]
        public string? LockBy { get; set; }
        [Column("Lock Flag")]
        [StringLength(1)]
        public string? LockFlag { get; set; }
        [Column("M Awb Or O Bl No")]
        [StringLength(20)]
        public string? MAwbOrOBlNo { get; set; }
        [Column("Module Code")]
        [StringLength(2)]
        public string? ModuleCode { get; set; }
        [Column("Net Day")]
        public short? NetDay { get; set; }
        [Column("Net Of Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? NetOfDate { get; set; }
        [Column("Our Ref")]
        [StringLength(24)]
        public string? OurRef { get; set; }
        [Column("Pay Code")]
        [StringLength(1)]
        public string? PayCode { get; set; }
        [Column("Pay Mode")]
        [StringLength(5)]
        public string? PayMode { get; set; }
        [Column("Payment Amt", TypeName = "decimal(14, 2)")]
        public decimal PaymentAmt { get; set; }
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
        [Column("Purchase Order No")]
        [StringLength(20)]
        public string? PurchaseOrderNo { get; set; }
        [StringLength(50)]
        public string? Recipient { get; set; }
        [Column("Ref No")]
        [StringLength(10)]
        public string? RefNo { get; set; }
        [Column("Reimburse Type")]
        [StringLength(2)]
        public string? ReimburseType { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Request By")]
        [StringLength(50)]
        public string? RequestBy { get; set; }
        [StringLength(50)]
        public string? Requestor { get; set; }
        [Column("Site Code")]
        [StringLength(20)]
        public string? SiteCode { get; set; }
        [Column("Source Code")]
        [StringLength(1)]
        public string? SourceCode { get; set; }
        [Column("Sub Total Amt", TypeName = "decimal(13, 2)")]
        public decimal? SubTotalAmt { get; set; }
        [Column("Template Name")]
        [StringLength(50)]
        public string? TemplateName { get; set; }
        [Column("Total Exm Amt", TypeName = "decimal(13, 2)")]
        public decimal? TotalExmAmt { get; set; }
        [Column("Total Local Vat Amt", TypeName = "decimal(13, 2)")]
        public decimal? TotalLocalVatAmt { get; set; }
        [Column("Total Std Amt", TypeName = "decimal(13, 2)")]
        public decimal? TotalStdAmt { get; set; }
        [Column("Total Vat Amt", TypeName = "decimal(13, 2)")]
        public decimal? TotalVatAmt { get; set; }
        [Column("Total Zer Amt", TypeName = "decimal(13, 2)")]
        public decimal? TotalZerAmt { get; set; }
        [Column("Transfer Flag")]
        [StringLength(1)]
        public string? TransferFlag { get; set; }
        [Column("Trx Type")]
        [StringLength(1)]
        public string? TrxType { get; set; }
        [Column("User Define 01")]
        [StringLength(100)]
        public string? UserDefine01 { get; set; }
        [Column("User Define 02")]
        [StringLength(100)]
        public string? UserDefine02 { get; set; }
        [Column("User Define 03")]
        [StringLength(100)]
        public string? UserDefine03 { get; set; }
        [Column("User Define 04")]
        [StringLength(100)]
        public string? UserDefine04 { get; set; }
        [Column("User Define 05")]
        [StringLength(100)]
        public string? UserDefine05 { get; set; }
        [Column("User Define 06")]
        [StringLength(100)]
        public string? UserDefine06 { get; set; }
        [Column("User Define 07")]
        [StringLength(100)]
        public string? UserDefine07 { get; set; }
        [Column("User Define 08")]
        [StringLength(100)]
        public string? UserDefine08 { get; set; }
        [Column("User Define 09")]
        [StringLength(100)]
        public string? UserDefine09 { get; set; }
        [Column("User Define 10")]
        [StringLength(100)]
        public string? UserDefine10 { get; set; }
        [Column("Vat Amt", TypeName = "decimal(13, 2)")]
        public decimal? VatAmt { get; set; }
        [Column("Vat Code")]
        [StringLength(3)]
        public string? VatCode { get; set; }
        [Column("Vat Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? VatDate { get; set; }
        [Column("Vat Registration No")]
        [StringLength(20)]
        public string? VatRegistrationNo { get; set; }
        [Column("Vendor Code")]
        [StringLength(10)]
        public string? VendorCode { get; set; }
        [Column("Vendor Name")]
        [StringLength(80)]
        public string? VendorName { get; set; }
        [Column("Vendor Payment Bank Code")]
        [StringLength(10)]
        public string? VendorPaymentBankCode { get; set; }
        [Column("Vendor Payment Voucher No")]
        [StringLength(20)]
        public string? VendorPaymentVoucherNo { get; set; }
        [Column("Voucher No")]
        [StringLength(20)]
        public string? VoucherNo { get; set; }
        [Column("Voucher Type")]
        [StringLength(2)]
        public string? VoucherType { get; set; }
        [Column("Warehouse Code")]
        [StringLength(6)]
        public string? WarehouseCode { get; set; }
        [Column("Work Station")]
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
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
