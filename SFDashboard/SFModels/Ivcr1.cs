using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("ivcr1")]
    [Index("CustomerName", Name = "INDEX_Ivcr1_CustomerName")]
    [Index("InvoiceDate", Name = "INDEX_Ivcr1_InvoiceDate")]
    [Index("InvoiceNo", Name = "INDEX_Ivcr1_InvoiceNo")]
    [Index("JobNo", Name = "INDEX_Ivcr1_JobNo")]
    [Index("JobType", Name = "INDEX_Ivcr1_JobType")]
    [Index("ModuleCode", Name = "INDEX_Ivcr1_ModuleCode")]
    [Index("PostDate", Name = "INDEX_Ivcr1_PostDate")]
    [Index("PostFlag", Name = "INDEX_Ivcr1_PostFlag")]
    [Index("StatusCode", Name = "INDEX_Ivcr1_StatusCode")]
    [Index("TrxType", Name = "INDEX_Ivcr1_TrxType")]
    [Index("UpdateDateTime", Name = "INDEX_Ivcr1_UpdateDateTime")]
    [Index("WorkStation", Name = "INDEX_Ivcr1_WorkStation")]
    public partial class Ivcr1
    {
        public Ivcr1()
        {
            Ivcr2s = new HashSet<Ivcr2>();
        }

        [Key]
        public int TrxNo { get; set; }
        [StringLength(20)]
        public string? InvoiceNo { get; set; }
        [StringLength(15)]
        public string? AccCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AcknowledgementDate { get; set; }
        [StringLength(10)]
        public string? ActualBillCollectorCode { get; set; }
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
        [StringLength(50)]
        public string? AttnName { get; set; }
        [StringLength(30)]
        public string? AwbOrBlNo { get; set; }
        [StringLength(10)]
        public string? BankCode { get; set; }
        [StringLength(20)]
        public string? BatchNo { get; set; }
        [StringLength(10)]
        public string? BillCollectorCode { get; set; }
        [StringLength(8)]
        public string? BillFlag { get; set; }
        [StringLength(6)]
        public string? BillIndicator { get; set; }
        [StringLength(10)]
        public string? BillingPartyCode { get; set; }
        [StringLength(4)]
        public string? BillMode { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? CashAmt { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? CashLocalAmt { get; set; }
        [Column(TypeName = "decimal(13, 5)")]
        public decimal? ChargeRate { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? ChargeWeight { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? ChequeAmt { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? ChequeLocalAmt { get; set; }
        [StringLength(20)]
        public string? ChequeNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ClearDate { get; set; }
        [StringLength(50)]
        public string? CollectBy { get; set; }
        [StringLength(50)]
        public string? CommodityCode { get; set; }
        [StringLength(10)]
        public string? ConsigneeCode { get; set; }
        [StringLength(1)]
        public string? ConsoleFlag { get; set; }
        [StringLength(50)]
        public string? CopyTemplateName { get; set; }
        [StringLength(255)]
        public string? CopyTemplateRemark { get; set; }
        [StringLength(15)]
        public string? CostCentre { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CurrDate { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [StringLength(10)]
        public string? DeliveryAgentCode { get; set; }
        [StringLength(3)]
        public string? DestCode { get; set; }
        [StringLength(45)]
        public string? DestName { get; set; }
        [StringLength(5)]
        public string? DistrictCode { get; set; }
        [StringLength(10)]
        public string? DivisionCode { get; set; }
        [StringLength(255)]
        public string? DocRemark { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DueDate { get; set; }
        public byte? EdiCount { get; set; }
        [StringLength(50)]
        public string? EdiRemark { get; set; }
        public byte? EmailCount { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EtaDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EtdDate { get; set; }
        [StringLength(50)]
        public string? EventTemplateName { get; set; }
        public byte? ExportCount { get; set; }
        [StringLength(30)]
        public string? Fax { get; set; }
        public byte? FaxCount { get; set; }
        [StringLength(30)]
        public string? FeederVesselName { get; set; }
        [StringLength(20)]
        public string? FeederVoyage { get; set; }
        [StringLength(5)]
        public string? FirstViaPortCode { get; set; }
        [StringLength(20)]
        public string? FlightOrVoyageNo { get; set; }
        [StringLength(2000)]
        public string? FollowUpJob { get; set; }
        [StringLength(80)]
        public string? Footer1 { get; set; }
        [StringLength(80)]
        public string? Footer2 { get; set; }
        [StringLength(80)]
        public string? Footer3 { get; set; }
        [StringLength(80)]
        public string? Footer4 { get; set; }
        [StringLength(80)]
        public string? Footer5 { get; set; }
        [StringLength(80)]
        public string? GoodsDescription1 { get; set; }
        [StringLength(80)]
        public string? GoodsDescription2 { get; set; }
        [StringLength(80)]
        public string? GoodsDescription3 { get; set; }
        [StringLength(80)]
        public string? GoodsDescription4 { get; set; }
        [StringLength(80)]
        public string? GoodsDescription5 { get; set; }
        [StringLength(80)]
        public string? GoodsDescription6 { get; set; }
        [StringLength(80)]
        public string? GoodsDescription7 { get; set; }
        [StringLength(80)]
        public string? GoodsDescription8 { get; set; }
        [StringLength(80)]
        public string? GoodsDescription9 { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? GrossProfit { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? GrossWeight { get; set; }
        [StringLength(50)]
        public string? GroupInvoiceCreateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? GroupInvoiceDate { get; set; }
        [Column("HAwbOrHBlNo")]
        [StringLength(30)]
        public string? HawbOrHblNo { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? InvoiceAmt { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? InvoiceAndVatAmt { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? InvoiceAndVatLocalAmt { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? InvoiceCostAmt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InvoiceDate { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? InvoiceLocalAmt { get; set; }
        [StringLength(1)]
        public string? InvoiceType { get; set; }
        [StringLength(10)]
        public string? JobCustomerCode { get; set; }
        [StringLength(30)]
        public string? JobNo { get; set; }
        [StringLength(10)]
        public string? JobType { get; set; }
        [StringLength(15)]
        public string? LetterOfCreditNo { get; set; }
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
        public int? NoOf20ftContainer { get; set; }
        public int? NoOf40ftContainer { get; set; }
        public int? NoOf45ftContainer { get; set; }
        public int? NoOfBillingDay { get; set; }
        public int? OpInvoiceTrxNo { get; set; }
        [StringLength(3)]
        public string? OriginCode { get; set; }
        [StringLength(45)]
        public string? OriginName { get; set; }
        [StringLength(24)]
        public string? OurRef { get; set; }
        [StringLength(50)]
        public string? PaymentBy { get; set; }
        [StringLength(30)]
        public string? PaymentByContactNo { get; set; }
        [StringLength(15)]
        public string? PaymentByNricNo { get; set; }
        [StringLength(25)]
        public string? PaymentByVehicleNo { get; set; }
        [StringLength(5)]
        public string? PayMode { get; set; }
        public int? Pcs { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PeriodFromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PeriodToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PlanCollectionDate { get; set; }
        [StringLength(5)]
        public string? PortOfDischargeCode { get; set; }
        [StringLength(45)]
        public string? PortOfDischargeName { get; set; }
        [StringLength(5)]
        public string? PortOfLoadingCode { get; set; }
        [StringLength(45)]
        public string? PortOfLoadingName { get; set; }
        [StringLength(10)]
        public string? PostalCode { get; set; }
        [StringLength(50)]
        public string? PostBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PostDate { get; set; }
        [StringLength(1)]
        public string? PostFlag { get; set; }
        [StringLength(6)]
        public string? PostMth { get; set; }
        [StringLength(1)]
        public string? PpCcFlag { get; set; }
        public byte? PrintCount { get; set; }
        [StringLength(20)]
        public string? QuoteNo { get; set; }
        [StringLength(1)]
        public string? ReconcilFlag { get; set; }
        [StringLength(10)]
        public string? RefNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(50)]
        public string? RequestBy { get; set; }
        [StringLength(255)]
        public string? RequestTo { get; set; }
        [StringLength(1)]
        public string? ReversalFlag { get; set; }
        [StringLength(10)]
        public string? SalesmanCode { get; set; }
        [StringLength(10)]
        public string? ShipperCode { get; set; }
        [StringLength(20)]
        public string? SiteCode { get; set; }
        [StringLength(10)]
        public string? SourceRefNo { get; set; }
        [StringLength(20)]
        public string? SourceSiteCode { get; set; }
        [StringLength(10)]
        public string? TargetRefNo { get; set; }
        [StringLength(20)]
        public string? TargetSiteCode { get; set; }
        [StringLength(30)]
        public string? Telephone { get; set; }
        [StringLength(50)]
        public string? TemplateName { get; set; }
        [StringLength(3)]
        public string? TermCode { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? TotalExmAmt { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? TotalLocalVatAmt { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? TotalStdAmt { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? TotalVatAmt { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? TotalZeroAmt { get; set; }
        [StringLength(1)]
        public string? TransferFlag { get; set; }
        [StringLength(1)]
        public string? TrxType { get; set; }
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
        [Column(TypeName = "datetime")]
        public DateTime? VatDate { get; set; }
        [StringLength(50)]
        public string? VesselCode { get; set; }
        [StringLength(50)]
        public string? VesselName { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Volume { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? WithHoldingTaxAmt { get; set; }
        [StringLength(20)]
        public string? WithHoldingTaxNo { get; set; }
        [StringLength(24)]
        public string? YourRef { get; set; }
        [StringLength(20)]
        public string? ZeroVatWithHoldingTaxNo { get; set; }
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
        public virtual ICollection<Ivcr2> Ivcr2s { get; set; }
    }
}
