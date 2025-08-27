using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("aiaw1")]
    [Index("AwbNo", Name = "INDEX_Aiaw1_AwbNo")]
    [Index("ConsigneeName", Name = "INDEX_Aiaw1_ConsigneeName")]
    [Index("CustomerName", Name = "INDEX_Aiaw1_CustomerName")]
    [Index("DeliveryAgentName", Name = "INDEX_Aiaw1_DeliveryAgentName")]
    [Index("FirstFlightDate", Name = "INDEX_Aiaw1_FirstFlightDate")]
    [Index("FlightNo", Name = "INDEX_Aiaw1_FlightNo")]
    [Index("JobNo", Name = "INDEX_Aiaw1_JobNo")]
    [Index("JobType", Name = "INDEX_Aiaw1_JobType")]
    [Index("MawbNo", Name = "INDEX_Aiaw1_MAwbNo")]
    [Index("MasterJobNo", Name = "INDEX_Aiaw1_MasterJobNo")]
    [Index("OriginCode", Name = "INDEX_Aiaw1_OriginCode")]
    [Index("SalesmanCode", Name = "INDEX_Aiaw1_SalesmanCode")]
    [Index("StatusCode", Name = "INDEX_Aiaw1_StatusCode")]
    [Index("UpdateDateTime", Name = "INDEX_Aiaw1_UpdateDateTime")]
    [Index("WorkStation", Name = "INDEX_Aiaw1_WorkStation")]
    public partial class Aiaw1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(20)]
        public string? AwbNo { get; set; }
        [StringLength(30)]
        public string? JobNo { get; set; }
        [Column("HAwbNo")]
        [StringLength(20)]
        public string? HawbNo { get; set; }
        [StringLength(30)]
        public string? HouseJobNo { get; set; }
        [StringLength(30)]
        public string? MasterJobNo { get; set; }
        [Column("MAwbNo")]
        [StringLength(20)]
        public string? MawbNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ActualDeliveryDateTime { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? ActualGrossWeight { get; set; }
        [StringLength(6)]
        public string? ActualOriginCode1 { get; set; }
        [StringLength(6)]
        public string? ActualOriginCode2 { get; set; }
        [StringLength(6)]
        public string? ActualOriginCode3 { get; set; }
        [StringLength(1)]
        public string? AirExportFlag { get; set; }
        [StringLength(10)]
        public string? ApptAgentCode { get; set; }
        [StringLength(80)]
        public string? ApptAgentName { get; set; }
        [StringLength(50)]
        public string? ApptAgentContact { get; set; }
        [StringLength(30)]
        public string? ApptAgentTelephone { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ArrivalDateTime { get; set; }
        public int? AvailablePcs { get; set; }
        [StringLength(1)]
        public string? BankDraftFlag { get; set; }
        [StringLength(13)]
        public string? BankDraftNo { get; set; }
        [StringLength(1)]
        public string? BankDraftStampFlag { get; set; }
        [StringLength(1)]
        public string? BankEndorseFlag { get; set; }
        [StringLength(1)]
        public string? BankEndorseStampFlag { get; set; }
        [StringLength(255)]
        public string? BillingInstruction { get; set; }
        [StringLength(10)]
        public string? BillingParty01 { get; set; }
        [StringLength(10)]
        public string? BillingParty02 { get; set; }
        [StringLength(2)]
        public string? BillMode { get; set; }
        [StringLength(8)]
        public string? BillToCode { get; set; }
        [StringLength(1)]
        public string? BrandFlag { get; set; }
        [StringLength(10)]
        public string? BreakBulkAgentCode { get; set; }
        [StringLength(80)]
        public string? BreakBulkAgentName { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? BuyRate { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? BuyTotalAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? BuyTotalLocalAmt { get; set; }
        [StringLength(2)]
        public string? CargoClass { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CargoReadyDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CargoReceiptDate { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? CarriageDeclareValue { get; set; }
        [StringLength(8)]
        public string? CashStatusCode { get; set; }
        [Column("CCFeePercent", TypeName = "decimal(13, 2)")]
        public decimal? CcfeePercent { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? ChargeWeight { get; set; }
        [StringLength(1)]
        public string? CollectFlag { get; set; }
        [StringLength(10)]
        public string? CollectFromCode { get; set; }
        [StringLength(80)]
        public string? CollectFromName { get; set; }
        [StringLength(50)]
        public string? CollectFromAddress1 { get; set; }
        [StringLength(50)]
        public string? CollectFromAddress2 { get; set; }
        [StringLength(50)]
        public string? CollectFromAddress3 { get; set; }
        [StringLength(50)]
        public string? CollectFromAddress4 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CollectionDateTime { get; set; }
        [StringLength(10)]
        public string? CollectionFromPlace { get; set; }
        [StringLength(50)]
        public string? CommodityCode { get; set; }
        [StringLength(50)]
        public string? CommodityDescription { get; set; }
        [StringLength(255)]
        public string? CommodityDescription01 { get; set; }
        [StringLength(3)]
        public string? ComputerCode { get; set; }
        [StringLength(10)]
        public string? ConsigneeCode { get; set; }
        [StringLength(80)]
        public string? ConsigneeName { get; set; }
        [StringLength(50)]
        public string? ConsigneeAddress1 { get; set; }
        [StringLength(50)]
        public string? ConsigneeAddress2 { get; set; }
        [StringLength(50)]
        public string? ConsigneeAddress3 { get; set; }
        [StringLength(50)]
        public string? ConsigneeAddress4 { get; set; }
        [StringLength(50)]
        public string? ConsigneeContact { get; set; }
        [StringLength(10)]
        public string? ConsigneePostalCode { get; set; }
        [StringLength(30)]
        public string? ConsigneeTelephone { get; set; }
        [StringLength(4)]
        public string? ContrFlag { get; set; }
        [StringLength(50)]
        public string? CopyTemplateName { get; set; }
        [StringLength(255)]
        public string? CopyTemplateRemark { get; set; }
        [StringLength(2)]
        public string? CountryCode { get; set; }
        [StringLength(1)]
        public string? CreditFlag { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [StringLength(13)]
        public string? CustomBondClearNo { get; set; }
        [StringLength(1)]
        public string? CustomBondFlag { get; set; }
        [StringLength(13)]
        public string? CustomBondReceiptNo { get; set; }
        [StringLength(1)]
        public string? CustomBondStampFlag { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? CustomDeclareValue { get; set; }
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [StringLength(50)]
        public string? CustomerContactName { get; set; }
        [StringLength(50)]
        public string? CustomerRefNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateAdded { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateChanged { get; set; }
        [StringLength(10)]
        public string? DeliveryAgentCode { get; set; }
        [StringLength(80)]
        public string? DeliveryAgentName { get; set; }
        [StringLength(50)]
        public string? DeliveryBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DeliveryDate { get; set; }
        [StringLength(60)]
        public string? DeliveryInstruction1 { get; set; }
        [StringLength(60)]
        public string? DeliveryInstruction2 { get; set; }
        [StringLength(60)]
        public string? DeliveryInstruction3 { get; set; }
        [StringLength(60)]
        public string? DeliveryInstruction4 { get; set; }
        [StringLength(60)]
        public string? DeliveryInstruction5 { get; set; }
        [StringLength(10)]
        public string? DeliveryNo { get; set; }
        [StringLength(1)]
        public string? DeliveryOrderFlag { get; set; }
        public short? DeliveryPcs { get; set; }
        [StringLength(5)]
        public string? DeliveryTerm { get; set; }
        [StringLength(10)]
        public string? DeliveryToCode { get; set; }
        [StringLength(80)]
        public string? DeliveryToName { get; set; }
        [StringLength(50)]
        public string? DeliveryToAddress1 { get; set; }
        [StringLength(50)]
        public string? DeliveryToAddress2 { get; set; }
        [StringLength(50)]
        public string? DeliveryToAddress3 { get; set; }
        [StringLength(50)]
        public string? DeliveryToAddress4 { get; set; }
        [StringLength(3)]
        public string? DestCode { get; set; }
        [StringLength(45)]
        public string? DestName { get; set; }
        [StringLength(10)]
        public string? DivisionCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocReleaseDate { get; set; }
        [StringLength(1)]
        public string? DocumentNoteFlag { get; set; }
        [StringLength(15)]
        public string? DriverCode { get; set; }
        [StringLength(50)]
        public string? DriverName { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? DueAgentCcAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? DueAgentPpAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? DueCarrierCcAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? DueCarrierPpAmt { get; set; }
        public byte? EdiCount { get; set; }
        public byte? EmailCount { get; set; }
        [StringLength(5)]
        public string? EnquiryStatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EtaDate1 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EtaDate2 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EtaDate3 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EtdDate1 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EtdDate2 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EtdDate3 { get; set; }
        [StringLength(255)]
        public string? ExportBookingNo { get; set; }
        public byte? ExportCount { get; set; }
        [StringLength(255)]
        public string? ExportJobNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Factor { get; set; }
        public byte? FaxCount { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? FinalAmt { get; set; }
        [StringLength(3)]
        public string? FinalCurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? FinalRate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FirstFlightDate { get; set; }
        [StringLength(12)]
        public string? FlightNo { get; set; }
        [StringLength(12)]
        public string? FlightNo1 { get; set; }
        [StringLength(12)]
        public string? FlightNo2 { get; set; }
        [StringLength(12)]
        public string? FlightNo3 { get; set; }
        [StringLength(80)]
        public string? Footer1 { get; set; }
        [StringLength(80)]
        public string? Footer2 { get; set; }
        [StringLength(80)]
        public string? Footer3 { get; set; }
        [StringLength(80)]
        public string? Footer4 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? FrtAmt { get; set; }
        [StringLength(1)]
        public string? GenerateApFlag { get; set; }
        [StringLength(1)]
        public string? GenerateInvFlag { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? GrossWeight { get; set; }
        [StringLength(9)]
        public string? HsCode { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? IataRate { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? IataTotalAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? IataTotalLocalAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? InsuranceAmt { get; set; }
        [StringLength(8)]
        public string? InvoiceStatusCode { get; set; }
        [StringLength(8)]
        public string? IssuerChanged { get; set; }
        [StringLength(8)]
        public string? IssuerCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? JobDate { get; set; }
        [StringLength(6)]
        public string? JobMth { get; set; }
        [StringLength(10)]
        public string? JobType { get; set; }
        [StringLength(1)]
        public string? KgLbFlag { get; set; }
        [StringLength(2)]
        public string? LastSeqNo { get; set; }
        [StringLength(50)]
        public string? Marking { get; set; }
        [StringLength(1)]
        public string? NominationFlag { get; set; }
        [StringLength(50)]
        public string? NominationRemark { get; set; }
        [StringLength(10)]
        public string? NotifyCode { get; set; }
        [StringLength(80)]
        public string? NotifyName { get; set; }
        [StringLength(50)]
        public string? NotifyAddress1 { get; set; }
        [StringLength(50)]
        public string? NotifyAddress2 { get; set; }
        [StringLength(50)]
        public string? NotifyAddress3 { get; set; }
        [StringLength(50)]
        public string? NotifyAddress4 { get; set; }
        [StringLength(20)]
        public string? OriginAwbNo { get; set; }
        [StringLength(3)]
        public string? OriginCode { get; set; }
        [StringLength(45)]
        public string? OriginName { get; set; }
        [StringLength(12)]
        public string? OriginCode1 { get; set; }
        [StringLength(12)]
        public string? OriginCode2 { get; set; }
        [StringLength(12)]
        public string? OriginCode3 { get; set; }
        [Column("OriginMAwbNo")]
        [StringLength(20)]
        public string? OriginMawbNo { get; set; }
        [StringLength(1)]
        public string? OtherFlag { get; set; }
        [StringLength(1)]
        public string? PartialNo { get; set; }
        public int? Pcs { get; set; }
        [Column(TypeName = "decimal(6, 3)")]
        public decimal? PercentOfProfitShare { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PermitDate { get; set; }
        [StringLength(260)]
        public string? PermitNo { get; set; }
        [StringLength(10)]
        public string? Place { get; set; }
        [StringLength(1)]
        public string? PostFlag { get; set; }
        [StringLength(1)]
        public string? PpCcFlag01 { get; set; }
        [StringLength(1)]
        public string? PpCcFlag02 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Price { get; set; }
        public byte? PrintCount { get; set; }
        [StringLength(1)]
        public string? ProfitShareFlag { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? ProfitShareRate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ProofDeliverDateTime { get; set; }
        [StringLength(15)]
        public string? QuotationNo { get; set; }
        [StringLength(15)]
        public string? QuoteNo { get; set; }
        [StringLength(1)]
        public string? RateClassCode { get; set; }
        [StringLength(20)]
        public string? RateGroup { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReceiveCallDateTime { get; set; }
        [StringLength(80)]
        public string? RecipientName { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? RecoverableAmt { get; set; }
        [StringLength(3)]
        public string? RecStatus { get; set; }
        [StringLength(5)]
        public string? RegionCode { get; set; }
        [StringLength(1000)]
        public string? Remark { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? SalesAmt { get; set; }
        [StringLength(20)]
        public string? SalesCoordinator1 { get; set; }
        [StringLength(20)]
        public string? SalesCoordinator2 { get; set; }
        [StringLength(80)]
        public string? SalesDescription1 { get; set; }
        [StringLength(80)]
        public string? SalesDescription2 { get; set; }
        [StringLength(10)]
        public string? SalesmanCode { get; set; }
        [StringLength(1)]
        public string? SeaExportFlag { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? SellRate { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? SellTotalAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? SellTotalLocalAmt { get; set; }
        [StringLength(2)]
        public string? SeqNo { get; set; }
        [StringLength(2)]
        public string? ServiceIndicator { get; set; }
        [StringLength(10)]
        public string? ServiceLevel { get; set; }
        [StringLength(1)]
        public string? ShipmentType { get; set; }
        [StringLength(50)]
        public string? ShipMode { get; set; }
        [StringLength(10)]
        public string? ShipperCode { get; set; }
        [StringLength(80)]
        public string? ShipperName { get; set; }
        [StringLength(15)]
        public string? ShipperAccCode { get; set; }
        [StringLength(50)]
        public string? ShipperAddress1 { get; set; }
        [StringLength(50)]
        public string? ShipperAddress2 { get; set; }
        [StringLength(50)]
        public string? ShipperAddress3 { get; set; }
        [StringLength(50)]
        public string? ShipperAddress4 { get; set; }
        [StringLength(1)]
        public string? ShortLandedFlag { get; set; }
        [StringLength(20)]
        public string? SiteCode { get; set; }
        [Column("SMawbNo")]
        [StringLength(20)]
        public string? SmawbNo { get; set; }
        [StringLength(50)]
        public string? SourceCreateBy { get; set; }
        [StringLength(50)]
        public string? SourceJobCreateBy { get; set; }
        [StringLength(30)]
        public string? SourceJobNo { get; set; }
        [StringLength(20)]
        public string? SourceSiteCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TaxCcAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TaxPpAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TotalCcAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TotalLocalAmt { get; set; }
        public int? TotalPcs { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TotalPpAmt { get; set; }
        [StringLength(1)]
        public string? TransferFlag { get; set; }
        [StringLength(1)]
        public string? TranshipmentFlag { get; set; }
        [StringLength(10)]
        public string? TransportCompanyCode { get; set; }
        [StringLength(80)]
        public string? TransportCompanyName { get; set; }
        [StringLength(50)]
        public string? TransportCompanyAddress1 { get; set; }
        [StringLength(50)]
        public string? TransportCompanyAddress2 { get; set; }
        [StringLength(50)]
        public string? TransportCompanyAddress3 { get; set; }
        [StringLength(50)]
        public string? TransportCompanyAddress4 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TrkReceiptDate { get; set; }
        [StringLength(1)]
        public string? UlFlag { get; set; }
        [StringLength(50)]
        public string? UomCode { get; set; }
        [StringLength(255)]
        public string? UserDefine01 { get; set; }
        [StringLength(255)]
        public string? UserDefine02 { get; set; }
        [StringLength(255)]
        public string? UserDefine03 { get; set; }
        [StringLength(255)]
        public string? UserDefine04 { get; set; }
        [StringLength(255)]
        public string? UserDefine05 { get; set; }
        [StringLength(255)]
        public string? UserDefine06 { get; set; }
        [StringLength(255)]
        public string? UserDefine07 { get; set; }
        [StringLength(255)]
        public string? UserDefine08 { get; set; }
        [StringLength(255)]
        public string? UserDefine09 { get; set; }
        [StringLength(255)]
        public string? UserDefine10 { get; set; }
        [StringLength(255)]
        public string? UserDefine11 { get; set; }
        [StringLength(255)]
        public string? UserDefine12 { get; set; }
        [StringLength(255)]
        public string? UserDefine13 { get; set; }
        [StringLength(255)]
        public string? UserDefine14 { get; set; }
        [StringLength(255)]
        public string? UserDefine15 { get; set; }
        [StringLength(255)]
        public string? UserDefine16 { get; set; }
        [StringLength(255)]
        public string? UserDefine17 { get; set; }
        [StringLength(255)]
        public string? UserDefine18 { get; set; }
        [StringLength(255)]
        public string? UserDefine19 { get; set; }
        [StringLength(255)]
        public string? UserDefine20 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ValueChargeCcAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ValueChargePpAmt { get; set; }
        [StringLength(30)]
        public string? VehicleNo { get; set; }
        [StringLength(10)]
        public string? ViaAgentCode { get; set; }
        [StringLength(80)]
        public string? ViaAgentName { get; set; }
        [Column(TypeName = "decimal(12, 4)")]
        public decimal? VolumetricWeight { get; set; }
        [Column("WeightChargeCCAmt", TypeName = "decimal(13, 2)")]
        public decimal? WeightChargeCcamt { get; set; }
        [Column("WeightChargePPAmt", TypeName = "decimal(13, 2)")]
        public decimal? WeightChargePpamt { get; set; }
        [StringLength(1)]
        public string? WeightValueFlag { get; set; }
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
        [StringLength(10)]
        public string? OriginalBranchCode { get; set; }
        [StringLength(10)]
        public string? OriginalDepartmentCode { get; set; }
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
    }
}
