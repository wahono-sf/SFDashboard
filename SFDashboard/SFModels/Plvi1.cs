using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("plvi1")]
    [Index("ChequeNo", Name = "INDEX_Plvi1_ChequeNo")]
    [Index("InvoiceDate", Name = "INDEX_Plvi1_InvoiceDate")]
    [Index("InvoiceNo", Name = "INDEX_Plvi1_InvoiceNo")]
    [Index("JobNo", Name = "INDEX_Plvi1_JobNo")]
    [Index("ModuleCode", Name = "INDEX_Plvi1_ModuleCode")]
    [Index("PostDate", Name = "INDEX_Plvi1_PostDate")]
    [Index("PostFlag", Name = "INDEX_Plvi1_PostFlag")]
    [Index("StatusCode", Name = "INDEX_Plvi1_StatusCode")]
    [Index("TrxType", Name = "INDEX_Plvi1_TrxType")]
    [Index("UpdateDateTime", Name = "INDEX_Plvi1_UpdateDateTime")]
    [Index("VendorName", Name = "INDEX_Plvi1_VendorName")]
    [Index("VoucherNo", Name = "INDEX_Plvi1_VoucherNo")]
    [Index("WorkStation", Name = "INDEX_Plvi1_WorkStation")]
    public partial class Plvi1
    {
        public Plvi1()
        {
            Plvi2s = new HashSet<Plvi2>();
        }

        [Key]
        public int TrxNo { get; set; }
        [StringLength(10)]
        public string? RefNo { get; set; }
        [StringLength(20)]
        public string? InvoiceNo { get; set; }
        [StringLength(30)]
        public string? JobNo { get; set; }
        [StringLength(15)]
        public string? AccCode { get; set; }
        [StringLength(1)]
        public string? AccuredFlag { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ActivityDate { get; set; }
        [StringLength(50)]
        public string? Address1 { get; set; }
        [StringLength(50)]
        public string? Address2 { get; set; }
        [StringLength(50)]
        public string? Address3 { get; set; }
        [StringLength(50)]
        public string? Address4 { get; set; }
        [StringLength(20)]
        public string? ApplyToInvoice { get; set; }
        [StringLength(50)]
        public string? ApproveBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ApproveDate { get; set; }
        [StringLength(30)]
        public string? AwbOrBlNo { get; set; }
        [StringLength(10)]
        public string? BankCode { get; set; }
        [StringLength(5)]
        public string? CashAdvanceType { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? CashAmt { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? CashLocalAmt { get; set; }
        [StringLength(50)]
        public string? CheckBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CheckDate { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? ChequeAmt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ChequeDate { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? ChequeLocalAmt { get; set; }
        [StringLength(20)]
        public string? ChequeNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ClearDate { get; set; }
        [StringLength(10)]
        public string? ConsigneeCode { get; set; }
        [StringLength(1)]
        public string? ConsoleFlag { get; set; }
        [StringLength(50)]
        public string? CopyTemplateName { get; set; }
        [StringLength(255)]
        public string? CopyTemplateRemark { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CurrDate { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [StringLength(50)]
        public string? Description1 { get; set; }
        [StringLength(50)]
        public string? Description2 { get; set; }
        [StringLength(50)]
        public string? Description3 { get; set; }
        [StringLength(50)]
        public string? Description4 { get; set; }
        [StringLength(50)]
        public string? Description5 { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? DiscountAmt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DiscountDate { get; set; }
        public short? DiscountDay { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DiscountDueDate { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? DiscountLocalAmt { get; set; }
        [Column(TypeName = "decimal(6, 3)")]
        public decimal? DiscountPercent { get; set; }
        [StringLength(10)]
        public string? DivisionCode { get; set; }
        [StringLength(30)]
        public string? DocNo { get; set; }
        [StringLength(255)]
        public string? DocRemark { get; set; }
        [StringLength(1)]
        public string? DocType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DueDate { get; set; }
        public byte? EdiCount { get; set; }
        [StringLength(50)]
        public string? EdiRemark { get; set; }
        public byte? EmailCount { get; set; }
        [StringLength(50)]
        public string? EventTemplateName { get; set; }
        public byte? ExportCount { get; set; }
        public byte? FaxCount { get; set; }
        /// <summary>
        /// E Invoice EDI
        /// </summary>
        [StringLength(50)]
        public string? Guid { get; set; }
        [Column("HAwbOrHBlNo")]
        [StringLength(30)]
        public string? HawbOrHblNo { get; set; }
        [StringLength(10)]
        public string? HirePurchaseCode { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? InvoiceAmt { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? InvoiceAndVatAmt { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? InvoiceAndVatLocalAmt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InvoiceDate { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? InvoiceLocalAmt { get; set; }
        [StringLength(1)]
        public string? InvoiceType { get; set; }
        [StringLength(10)]
        public string? JobCustomerCode { get; set; }
        [StringLength(10)]
        public string? JobType { get; set; }
        [StringLength(2)]
        public string? Location { get; set; }
        [StringLength(20)]
        public string? LockBy { get; set; }
        [StringLength(1)]
        public string? LockFlag { get; set; }
        [Column("MAwbOrOBlNo")]
        [StringLength(30)]
        public string? MawbOrOblNo { get; set; }
        [StringLength(1)]
        public string? MiscFlag { get; set; }
        [StringLength(2)]
        public string? ModuleCode { get; set; }
        public short? NetDay { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NetOfDate { get; set; }
        [StringLength(24)]
        public string? OurRef { get; set; }
        [StringLength(1)]
        public string? OwnOrOnBehalf { get; set; }
        [StringLength(1)]
        public string? PayCode { get; set; }
        [StringLength(5)]
        public string? PayMode { get; set; }
        [StringLength(50)]
        public string? PostBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PostDate { get; set; }
        [StringLength(1)]
        public string? PostFlag { get; set; }
        [StringLength(6)]
        public string? PostMth { get; set; }
        public byte? PrintCount { get; set; }
        [StringLength(1)]
        public string? ProvReverseFlag { get; set; }
        [StringLength(20)]
        public string? PurchaseOrderNo { get; set; }
        [StringLength(50)]
        public string? Recipient { get; set; }
        [StringLength(1)]
        public string? ReconcilFlag { get; set; }
        [StringLength(2)]
        public string? ReimburseType { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(50)]
        public string? RequestBy { get; set; }
        [StringLength(250)]
        public string? RequestTo { get; set; }
        [StringLength(50)]
        public string? Requestor { get; set; }
        [StringLength(1)]
        public string? ReversalFlag { get; set; }
        [StringLength(1)]
        public string? SettlementFlag { get; set; }
        [StringLength(10)]
        public string? ShipperCode { get; set; }
        [StringLength(20)]
        public string? SiteCode { get; set; }
        [StringLength(1)]
        public string? SourceCode { get; set; }
        [StringLength(10)]
        public string? SourceRefNo { get; set; }
        [StringLength(20)]
        public string? SourceSiteCode { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? SubTotalAmt { get; set; }
        [StringLength(10)]
        public string? TargetRefNo { get; set; }
        [StringLength(20)]
        public string? TargetSiteCode { get; set; }
        [StringLength(50)]
        public string? TemplateName { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? TotalExmAmt { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? TotalLocalVatAmt { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? TotalStdAmt { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? TotalVatAmt { get; set; }
        [Column("TotalWHTAmt", TypeName = "decimal(13, 2)")]
        public decimal? TotalWhtamt { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? TotalZerAmt { get; set; }
        [StringLength(1)]
        public string? TransferFlag { get; set; }
        [StringLength(1)]
        public string? TrxType { get; set; }
        [StringLength(1)]
        public string? UploadFlag { get; set; }
        [StringLength(100)]
        public string? UserDefine01 { get; set; }
        [StringLength(100)]
        public string? UserDefine02 { get; set; }
        [StringLength(100)]
        public string? UserDefine03 { get; set; }
        [StringLength(100)]
        public string? UserDefine04 { get; set; }
        [StringLength(100)]
        public string? UserDefine05 { get; set; }
        [StringLength(100)]
        public string? UserDefine06 { get; set; }
        [StringLength(100)]
        public string? UserDefine07 { get; set; }
        [StringLength(100)]
        public string? UserDefine08 { get; set; }
        [StringLength(100)]
        public string? UserDefine09 { get; set; }
        [StringLength(100)]
        public string? UserDefine10 { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? VatAmt { get; set; }
        [StringLength(10)]
        public string? VatCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? VatDate { get; set; }
        [StringLength(20)]
        public string? VatRegistrationNo { get; set; }
        [StringLength(10)]
        public string? VendorCode { get; set; }
        [StringLength(80)]
        public string? VendorName { get; set; }
        [StringLength(20)]
        public string? VoucherNo { get; set; }
        [StringLength(2)]
        public string? VoucherType { get; set; }
        [StringLength(6)]
        public string? WarehouseCode { get; set; }
        [Column("WHTNo")]
        [StringLength(255)]
        public string? Whtno { get; set; }
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
        [StringLength(10)]
        public string? BranchCode { get; set; }
        [StringLength(10)]
        public string? DepartmentCode { get; set; }
        [StringLength(3)]
        public string StatusCode { get; set; } = null!;
        [StringLength(50)]
        public string CreateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CreateDateTime { get; set; }
        [StringLength(50)]
        public string UpdateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime UpdateDateTime { get; set; }
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }

        [InverseProperty("TrxNoNavigation")]
        public virtual ICollection<Plvi2> Plvi2s { get; set; }
    }
}
