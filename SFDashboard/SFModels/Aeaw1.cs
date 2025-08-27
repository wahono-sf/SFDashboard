using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("aeaw1")]
    [Index("AirportDestCode", Name = "INDEX_Aeaw1_AirportDestCode")]
    [Index("AirportDestName", Name = "INDEX_Aeaw1_AirportDestName")]
    [Index("AwbNo", Name = "INDEX_Aeaw1_AwbNo")]
    [Index("BookingNo", Name = "INDEX_Aeaw1_BookingNo")]
    [Index("CustomerName", Name = "INDEX_Aeaw1_CustomerName")]
    [Index("DeliveryAgentName", Name = "INDEX_Aeaw1_DeliveryAgentName")]
    [Index("FirstFlightDate", Name = "INDEX_Aeaw1_FirstFlightDate")]
    [Index("FirstFlightNo", Name = "INDEX_Aeaw1_FisrtFlightNo")]
    [Index("JobNo", Name = "INDEX_Aeaw1_JobNo")]
    [Index("JobType", Name = "INDEX_Aeaw1_JobType")]
    [Index("MawbNo", Name = "INDEX_Aeaw1_MAwbNo")]
    [Index("MasterJobNo", Name = "INDEX_Aeaw1_MasterJobNo")]
    [Index("SalesmanCode", Name = "INDEX_Aeaw1_SalesmanCode")]
    [Index("ShipperName", Name = "INDEX_Aeaw1_ShipperName")]
    [Index("StatusCode", Name = "INDEX_Aeaw1_StatusCode")]
    [Index("UpdateDateTime", Name = "INDEX_Aeaw1_UpdateDateTime")]
    [Index("SmawbNo", Name = "IX_aeaw1")]
    [Index("MawbNo", Name = "IX_aeaw1_1")]
    [Index("JobNo", Name = "IX_aeaw1_2")]
    [Index("BookingNo", Name = "IX_aeaw1_3")]
    [Index("AwbNo", Name = "IX_aeaw1_4", IsUnique = true)]
    public partial class Aeaw1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(20)]
        public string AwbNo { get; set; } = null!;
        [StringLength(30)]
        public string? JobNo { get; set; }
        [Column("MAwbNo")]
        [StringLength(20)]
        public string? MawbNo { get; set; }
        [StringLength(30)]
        public string? MasterJobNo { get; set; }
        [StringLength(50)]
        public string? AccountInfo1 { get; set; }
        [StringLength(50)]
        public string? AccountInfo2 { get; set; }
        [StringLength(50)]
        public string? AccountInfo3 { get; set; }
        [StringLength(50)]
        public string? AccountInfo4 { get; set; }
        [StringLength(50)]
        public string? AccountInfo5 { get; set; }
        [StringLength(50)]
        public string? AccountInfo6 { get; set; }
        [StringLength(50)]
        public string? AccountInfo7 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? ActualChargeWeight { get; set; }
        [StringLength(10)]
        public string? AgentCode { get; set; }
        [StringLength(15)]
        public string? AgentAccCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? AgentCcAmt { get; set; }
        [StringLength(25)]
        public string? AgentIataCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? AgentPpAmt { get; set; }
        [StringLength(3)]
        public string? AirportDeptCode { get; set; }
        [StringLength(45)]
        public string? AirportDeptName { get; set; }
        [StringLength(3)]
        public string? AirportDestCode { get; set; }
        [StringLength(45)]
        public string? AirportDestName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ArrivalDateTime { get; set; }
        [StringLength(1)]
        public string? AsArrangeFlag { get; set; }
        [StringLength(10)]
        public string? AwbPrefix { get; set; }
        [StringLength(1)]
        public string? AwbPrintFlag { get; set; }
        [StringLength(1)]
        public string? BankFlag { get; set; }
        [StringLength(255)]
        public string? BillingInstruction { get; set; }
        [StringLength(2)]
        public string? BillMode { get; set; }
        [StringLength(8)]
        public string? BillToCode { get; set; }
        [StringLength(20)]
        public string? BookingNo { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? BuyChargeWeight { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? BuyRate { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? BuyTotalAmt { get; set; }
        [StringLength(2)]
        public string? CargoClass { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CargoReceiptDate { get; set; }
        [StringLength(20)]
        public string? CarriageDeclareValue { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? CarrierCcAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? CarrierPpAmt { get; set; }
        [StringLength(50)]
        public string? CarrierRemark01 { get; set; }
        [StringLength(50)]
        public string? CarrierRemark02 { get; set; }
        [StringLength(50)]
        public string? CartageType { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ChargeAmt { get; set; }
        [StringLength(50)]
        public string? ChargeId { get; set; }
        [StringLength(5)]
        public string? ChargeTableNo { get; set; }
        [StringLength(1)]
        public string? CloseConsol { get; set; }
        [StringLength(3)]
        public string? CollectCurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? CollectCurrRate { get; set; }
        [StringLength(10)]
        public string? ColoaderCode { get; set; }
        [StringLength(50)]
        public string? CommodityCode { get; set; }
        [StringLength(50)]
        public string? CommodityDescription { get; set; }
        [StringLength(50)]
        public string? CommodityDescription01 { get; set; }
        [StringLength(50)]
        public string? CommodityDescription02 { get; set; }
        [StringLength(50)]
        public string? CommodityDescription03 { get; set; }
        [StringLength(50)]
        public string? CommodityDescription04 { get; set; }
        [StringLength(50)]
        public string? CommodityDescription05 { get; set; }
        [StringLength(50)]
        public string? CommodityDescription06 { get; set; }
        [StringLength(50)]
        public string? CommodityDescription07 { get; set; }
        [StringLength(50)]
        public string? CommodityDescription08 { get; set; }
        [StringLength(50)]
        public string? CommodityDescription09 { get; set; }
        [StringLength(50)]
        public string? CommodityDescription10 { get; set; }
        [StringLength(50)]
        public string? CommodityDescription11 { get; set; }
        [StringLength(50)]
        public string? CommodityDescription12 { get; set; }
        [StringLength(50)]
        public string? CommodityDescription13 { get; set; }
        [StringLength(50)]
        public string? CommodityDescription14 { get; set; }
        [StringLength(1)]
        public string? ComputeFlag { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ConfirmArrivalDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ConfirmDepartureDate { get; set; }
        [StringLength(10)]
        public string? ConsigneeCode { get; set; }
        [StringLength(80)]
        public string? ConsigneeName { get; set; }
        [StringLength(15)]
        public string? ConsigneeAccCode { get; set; }
        [StringLength(50)]
        public string? ConsigneeAddress1 { get; set; }
        [StringLength(50)]
        public string? ConsigneeAddress2 { get; set; }
        [StringLength(50)]
        public string? ConsigneeAddress3 { get; set; }
        [StringLength(50)]
        public string? ConsigneeAddress4 { get; set; }
        [StringLength(50)]
        public string? ConsigneeAddress5 { get; set; }
        [StringLength(4)]
        public string? ContrFlag { get; set; }
        [StringLength(50)]
        public string? CopyTemplateName { get; set; }
        [StringLength(255)]
        public string? CopyTemplateRemark { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [StringLength(3)]
        public string? CustomCurrCode { get; set; }
        [StringLength(20)]
        public string? CustomDeclareValue { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? CustomLocalAmt { get; set; }
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [StringLength(50)]
        public string? CustomerRefNo { get; set; }
        [StringLength(10)]
        public string? DeliveryAgentCode { get; set; }
        [StringLength(80)]
        public string? DeliveryAgentName { get; set; }
        [StringLength(50)]
        public string? DeliveryAgentAddress1 { get; set; }
        [StringLength(50)]
        public string? DeliveryAgentAddress2 { get; set; }
        [StringLength(50)]
        public string? DeliveryAgentAddress3 { get; set; }
        [StringLength(50)]
        public string? DeliveryAgentAddress4 { get; set; }
        [StringLength(50)]
        public string? DeliveryAgentAddress5 { get; set; }
        [StringLength(5)]
        public string? DeliveryType { get; set; }
        [StringLength(500)]
        public string? Description { get; set; }
        [StringLength(100)]
        public string? Description01 { get; set; }
        [StringLength(100)]
        public string? Description02 { get; set; }
        [StringLength(100)]
        public string? Description03 { get; set; }
        [StringLength(100)]
        public string? Description04 { get; set; }
        [StringLength(100)]
        public string? Description05 { get; set; }
        [StringLength(100)]
        public string? Description06 { get; set; }
        [StringLength(100)]
        public string? Description07 { get; set; }
        [StringLength(100)]
        public string? Description08 { get; set; }
        [StringLength(100)]
        public string? Description09 { get; set; }
        [StringLength(100)]
        public string? Description10 { get; set; }
        [StringLength(100)]
        public string? Description11 { get; set; }
        [StringLength(100)]
        public string? Description12 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? DestCcAmt { get; set; }
        [StringLength(3)]
        public string? DestCode { get; set; }
        [StringLength(45)]
        public string? DestName { get; set; }
        [StringLength(3)]
        public string? DestCurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? DestCurrRate { get; set; }
        [StringLength(1)]
        public string? DgFlag { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Dimension { get; set; }
        [StringLength(2)]
        public string? DimType { get; set; }
        [StringLength(10)]
        public string? DivisionCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? DocChargeWeight { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? DocRate { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? DocTotalAmt { get; set; }
        [StringLength(1)]
        public string? DueAgentAwbFlag01 { get; set; }
        [StringLength(1)]
        public string? DueAgentAwbFlag02 { get; set; }
        [StringLength(1)]
        public string? DueAgentAwbFlag03 { get; set; }
        [StringLength(1)]
        public string? DueAgentAwbFlag04 { get; set; }
        [StringLength(1)]
        public string? DueAgentAwbFlag05 { get; set; }
        [StringLength(1)]
        public string? DueAgentAwbFlag06 { get; set; }
        [StringLength(1)]
        public string? DueAgentAwbFlag07 { get; set; }
        [StringLength(1)]
        public string? DueAgentAwbFlag08 { get; set; }
        [StringLength(1)]
        public string? DueAgentAwbFlag09 { get; set; }
        [StringLength(1)]
        public string? DueAgentAwbFlag10 { get; set; }
        [StringLength(1)]
        public string? DueAgentAwbFlag11 { get; set; }
        [StringLength(1)]
        public string? DueAgentAwbFlag12 { get; set; }
        [StringLength(3)]
        public string? DueAgentChargeCode01 { get; set; }
        [StringLength(3)]
        public string? DueAgentChargeCode02 { get; set; }
        [StringLength(3)]
        public string? DueAgentChargeCode03 { get; set; }
        [StringLength(3)]
        public string? DueAgentChargeCode04 { get; set; }
        [StringLength(3)]
        public string? DueAgentChargeCode05 { get; set; }
        [StringLength(3)]
        public string? DueAgentChargeCode06 { get; set; }
        [StringLength(3)]
        public string? DueAgentChargeCode07 { get; set; }
        [StringLength(3)]
        public string? DueAgentChargeCode08 { get; set; }
        [StringLength(3)]
        public string? DueAgentChargeCode09 { get; set; }
        [StringLength(3)]
        public string? DueAgentChargeCode10 { get; set; }
        [StringLength(3)]
        public string? DueAgentChargeCode11 { get; set; }
        [StringLength(3)]
        public string? DueAgentChargeCode12 { get; set; }
        [StringLength(1)]
        public string? DueAgentPpCcFlag01 { get; set; }
        [StringLength(1)]
        public string? DueAgentPpCcFlag02 { get; set; }
        [StringLength(1)]
        public string? DueAgentPpCcFlag03 { get; set; }
        [StringLength(1)]
        public string? DueAgentPpCcFlag04 { get; set; }
        [StringLength(1)]
        public string? DueAgentPpCcFlag05 { get; set; }
        [StringLength(1)]
        public string? DueAgentPpCcFlag06 { get; set; }
        [StringLength(1)]
        public string? DueAgentPpCcFlag07 { get; set; }
        [StringLength(1)]
        public string? DueAgentPpCcFlag08 { get; set; }
        [StringLength(1)]
        public string? DueAgentPpCcFlag09 { get; set; }
        [StringLength(1)]
        public string? DueAgentPpCcFlag10 { get; set; }
        [StringLength(1)]
        public string? DueAgentPpCcFlag11 { get; set; }
        [StringLength(1)]
        public string? DueAgentPpCcFlag12 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? DueAgentRate01 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? DueAgentRate02 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? DueAgentRate03 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? DueAgentRate04 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? DueAgentRate05 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? DueAgentRate06 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? DueAgentRate07 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? DueAgentRate08 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? DueAgentRate09 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? DueAgentRate10 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? DueAgentRate11 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? DueAgentRate12 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? DueAgentTotalAmt { get; set; }
        [StringLength(1)]
        public string? DueCarrierAwbFlag01 { get; set; }
        [StringLength(1)]
        public string? DueCarrierAwbFlag02 { get; set; }
        [StringLength(1)]
        public string? DueCarrierAwbFlag03 { get; set; }
        [StringLength(1)]
        public string? DueCarrierAwbFlag04 { get; set; }
        [StringLength(1)]
        public string? DueCarrierAwbFlag05 { get; set; }
        [StringLength(1)]
        public string? DueCarrierAwbFlag06 { get; set; }
        [StringLength(1)]
        public string? DueCarrierAwbFlag07 { get; set; }
        [StringLength(1)]
        public string? DueCarrierAwbFlag08 { get; set; }
        [StringLength(1)]
        public string? DueCarrierAwbFlag09 { get; set; }
        [StringLength(1)]
        public string? DueCarrierAwbFlag10 { get; set; }
        [StringLength(1)]
        public string? DueCarrierAwbFlag11 { get; set; }
        [StringLength(1)]
        public string? DueCarrierAwbFlag12 { get; set; }
        [StringLength(3)]
        public string? DueCarrierChargeCode01 { get; set; }
        [StringLength(3)]
        public string? DueCarrierChargeCode02 { get; set; }
        [StringLength(3)]
        public string? DueCarrierChargeCode03 { get; set; }
        [StringLength(3)]
        public string? DueCarrierChargeCode04 { get; set; }
        [StringLength(3)]
        public string? DueCarrierChargeCode05 { get; set; }
        [StringLength(3)]
        public string? DueCarrierChargeCode06 { get; set; }
        [StringLength(3)]
        public string? DueCarrierChargeCode07 { get; set; }
        [StringLength(3)]
        public string? DueCarrierChargeCode08 { get; set; }
        [StringLength(3)]
        public string? DueCarrierChargeCode09 { get; set; }
        [StringLength(3)]
        public string? DueCarrierChargeCode10 { get; set; }
        [StringLength(3)]
        public string? DueCarrierChargeCode11 { get; set; }
        [StringLength(3)]
        public string? DueCarrierChargeCode12 { get; set; }
        [StringLength(1)]
        public string? DueCarrierPpCcFlag01 { get; set; }
        [StringLength(1)]
        public string? DueCarrierPpCcFlag02 { get; set; }
        [StringLength(1)]
        public string? DueCarrierPpCcFlag03 { get; set; }
        [StringLength(1)]
        public string? DueCarrierPpCcFlag04 { get; set; }
        [StringLength(1)]
        public string? DueCarrierPpCcFlag05 { get; set; }
        [StringLength(1)]
        public string? DueCarrierPpCcFlag06 { get; set; }
        [StringLength(1)]
        public string? DueCarrierPpCcFlag07 { get; set; }
        [StringLength(1)]
        public string? DueCarrierPpCcFlag08 { get; set; }
        [StringLength(1)]
        public string? DueCarrierPpCcFlag09 { get; set; }
        [StringLength(1)]
        public string? DueCarrierPpCcFlag10 { get; set; }
        [StringLength(1)]
        public string? DueCarrierPpCcFlag11 { get; set; }
        [StringLength(1)]
        public string? DueCarrierPpCcFlag12 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? DueCarrierRate01 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? DueCarrierRate02 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? DueCarrierRate03 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? DueCarrierRate04 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? DueCarrierRate05 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? DueCarrierRate06 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? DueCarrierRate07 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? DueCarrierRate08 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? DueCarrierRate09 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? DueCarrierRate10 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? DueCarrierRate11 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? DueCarrierRate12 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? DueCarrierTotalAmt { get; set; }
        public byte? EdiCount { get; set; }
        public byte? EmailCount { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EtaDate1 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EtaDate2 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EtaDate3 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EtaDate4 { get; set; }
        [StringLength(50)]
        public string? ExecuteBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ExecuteDate { get; set; }
        [StringLength(50)]
        public string? ExecutePlace { get; set; }
        public byte? ExportCount { get; set; }
        public byte? FaxCount { get; set; }
        [Column("FirstByAirlineID")]
        [StringLength(3)]
        public string? FirstByAirlineId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FirstFlightDate { get; set; }
        [StringLength(7)]
        public string? FirstFlightNo { get; set; }
        [StringLength(3)]
        public string? FirstToDestCode { get; set; }
        [Column("FourthByAirlineID")]
        [StringLength(3)]
        public string? FourthByAirlineId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FourthFlightDate { get; set; }
        [StringLength(7)]
        public string? FourthFlightNo { get; set; }
        [StringLength(3)]
        public string? FourthToDestCode { get; set; }
        [StringLength(10)]
        public string? FrtBillPartyCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? GrossWeight { get; set; }
        [StringLength(80)]
        public string? HandlingInfo1 { get; set; }
        [StringLength(80)]
        public string? HandlingInfo2 { get; set; }
        [StringLength(80)]
        public string? HandlingInfo3 { get; set; }
        [Column("HAwbNo")]
        [StringLength(20)]
        public string? HawbNo { get; set; }
        [StringLength(30)]
        public string? HouseJobNo { get; set; }
        [StringLength(30)]
        public string? ImportJobNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? InsuranceAmt { get; set; }
        [StringLength(3)]
        public string? InsureCurrCode { get; set; }
        [Column(TypeName = "decimal(11, 2)")]
        public decimal? InsureLocalAmt { get; set; }
        [StringLength(80)]
        public string? IssueByName { get; set; }
        [StringLength(50)]
        public string? IssueByAddress1 { get; set; }
        [StringLength(50)]
        public string? IssueByAddress2 { get; set; }
        [StringLength(50)]
        public string? IssueByAddress3 { get; set; }
        [StringLength(50)]
        public string? IssueByAddress4 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? JobDate { get; set; }
        [StringLength(6)]
        public string? JobMth { get; set; }
        [StringLength(10)]
        public string? JobType { get; set; }
        [StringLength(1)]
        public string? KgLbFlag { get; set; }
        [StringLength(10)]
        public string? KnownConsigneeFlag { get; set; }
        public int? LineItemNo { get; set; }
        [StringLength(50)]
        public string? LicenseNo { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? LocalProfitPercent { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LodgeDate { get; set; }
        [StringLength(1)]
        public string? LoggerFlag { get; set; }
        [StringLength(80)]
        public string? ManifestConsigneeName { get; set; }
        [StringLength(50)]
        public string? ManifestConsigneeAddress1 { get; set; }
        [StringLength(50)]
        public string? ManifestConsigneeAddress2 { get; set; }
        [StringLength(50)]
        public string? ManifestConsigneeAddress3 { get; set; }
        [StringLength(50)]
        public string? ManifestConsigneeAddress4 { get; set; }
        [StringLength(50)]
        public string? ManifestDescription1 { get; set; }
        [StringLength(50)]
        public string? ManifestDescription2 { get; set; }
        [StringLength(50)]
        public string? ManifestDescription3 { get; set; }
        [StringLength(50)]
        public string? ManifestDescription4 { get; set; }
        [StringLength(50)]
        public string? ManifestDescription5 { get; set; }
        [StringLength(50)]
        public string? ManifestDescription6 { get; set; }
        [StringLength(50)]
        public string? ManifestDescription7 { get; set; }
        [StringLength(50)]
        public string? ManifestDescription8 { get; set; }
        [StringLength(50)]
        public string? ManifestDescription9 { get; set; }
        [StringLength(50)]
        public string? ManifestDescription10 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? ManifestGrossWeight { get; set; }
        [StringLength(80)]
        public string? ManifestShipperName { get; set; }
        [StringLength(50)]
        public string? ManifestShipperAddress1 { get; set; }
        [StringLength(50)]
        public string? ManifestShipperAddress2 { get; set; }
        [StringLength(50)]
        public string? ManifestShipperAddress3 { get; set; }
        [StringLength(50)]
        public string? ManifestShipperAddress4 { get; set; }
        [StringLength(1)]
        public string? NominationFlag { get; set; }
        [StringLength(50)]
        public string? NominationRemark { get; set; }
        public int? NoOfContainer { get; set; }
        public int? NoOfHighPallet { get; set; }
        public int? NoOfLowPallet { get; set; }
        [StringLength(255)]
        public string? Note { get; set; }
        [StringLength(10)]
        public string? NotifyCode { get; set; }
        [StringLength(80)]
        public string? NotifyName { get; set; }
        [StringLength(15)]
        public string? NotifyAcctCode { get; set; }
        [StringLength(50)]
        public string? NotifyAddress1 { get; set; }
        [StringLength(50)]
        public string? NotifyAddress2 { get; set; }
        [StringLength(50)]
        public string? NotifyAddress3 { get; set; }
        [StringLength(50)]
        public string? NotifyAddress4 { get; set; }
        [StringLength(50)]
        public string? NotifyAddress5 { get; set; }
        [StringLength(3)]
        public string? OriginCode { get; set; }
        [StringLength(45)]
        public string? OriginName { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? OtherAmt { get; set; }
        [StringLength(10)]
        public string? OtherBillPartyCode { get; set; }
        [StringLength(60)]
        public string? OtherCharge1 { get; set; }
        [StringLength(60)]
        public string? OtherCharge2 { get; set; }
        [StringLength(60)]
        public string? OtherCharge3 { get; set; }
        [StringLength(1)]
        public string? OtherChargePpCcFlag { get; set; }
        [StringLength(1)]
        public string? OtherFlag { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? OtherProfitPercent { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? OverseasProfitPercent { get; set; }
        public int? Pcs { get; set; }
        [StringLength(260)]
        public string? PermitNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PickupDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PickupFfDate { get; set; }
        [StringLength(1)]
        public string? PostFlag { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PreAlertDestDate { get; set; }
        public byte? PrintCount { get; set; }
        [StringLength(1)]
        public string? PrintDimFlag { get; set; }
        [StringLength(10)]
        public string? ProductCode { get; set; }
        [StringLength(15)]
        public string? QuotationNo { get; set; }
        [StringLength(15)]
        public string? QuoteNo { get; set; }
        [StringLength(1)]
        public string? RateClassCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? RatePercent { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReceiveFfDate { get; set; }
        [StringLength(5)]
        public string? RecStatus { get; set; }
        [StringLength(1000)]
        public string? Remark { get; set; }
        [StringLength(1)]
        public string? RoundingFlag { get; set; }
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
        [Column("SecondByAirlineID")]
        [StringLength(3)]
        public string? SecondByAirlineId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SecondFlightDate { get; set; }
        [StringLength(7)]
        public string? SecondFlightNo { get; set; }
        [StringLength(3)]
        public string? SecondToDestCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? SellChargeWeight { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? SellRate { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? SellTotalAmt { get; set; }
        [StringLength(1)]
        public string? ShipmentType { get; set; }
        [StringLength(2)]
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
        [StringLength(50)]
        public string? ShipperAddress5 { get; set; }
        [StringLength(20)]
        public string? SiteCode { get; set; }
        [Column("SLACQty", TypeName = "decimal(10, 0)")]
        public decimal? Slacqty { get; set; }
        [Column("SLACuomCode")]
        [StringLength(50)]
        public string? SlacuomCode { get; set; }
        [Column("SMAwbNo")]
        [StringLength(20)]
        public string? SmawbNo { get; set; }
        [StringLength(50)]
        public string? SourceJobCreateBy { get; set; }
        [StringLength(4000)]
        public string? SummaryDescription { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? SupplierAmt { get; set; }
        [StringLength(50)]
        public string? SupplierCurrCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? TactChargeWeight { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? TactRate { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TactTotalAmt { get; set; }
        [StringLength(30)]
        public string? TargetJobNo { get; set; }
        [StringLength(20)]
        public string? TargetSiteCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TaxChargeCcAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TaxChargePpAmt { get; set; }
        [StringLength(20)]
        public string? Temperature { get; set; }
        [StringLength(50)]
        public string? TemplateName { get; set; }
        [StringLength(20)]
        public string? TerminalCode { get; set; }
        [Column("ThirdByAirlineID")]
        [StringLength(3)]
        public string? ThirdByAirlineId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ThirdFlightDate { get; set; }
        [StringLength(7)]
        public string? ThirdFlightNo { get; set; }
        [StringLength(3)]
        public string? ThirdToDestCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TotalCcAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TotalPpAmt { get; set; }
        [StringLength(1)]
        public string? TransferFlag { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TrfDate { get; set; }
        [StringLength(1)]
        public string? TrfFlag { get; set; }
        [StringLength(8)]
        public string? TrfFormNo { get; set; }
        [StringLength(50)]
        public string? UomCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? UserChargeWeight { get; set; }
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
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? VolumetricWeight { get; set; }
        public short? VolumetricWeightRatio { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightChargeCcAmt { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightChargePpAmt { get; set; }
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
