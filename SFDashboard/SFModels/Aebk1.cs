using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("aebk1")]
    [Index("AirportDestCode", Name = "INDEX_Aebk1_AirportDestCode")]
    [Index("AwbNo", Name = "INDEX_Aebk1_AwbNo")]
    [Index("BookingNo", Name = "INDEX_Aebk1_BookingNo")]
    [Index("CustomerName", Name = "INDEX_Aebk1_CustomerName")]
    [Index("FirstFlightDate", Name = "INDEX_Aebk1_FirstFlightDate")]
    [Index("FirstFlightNo", Name = "INDEX_Aebk1_FisrtFlightNo")]
    [Index("JobType", Name = "INDEX_Aebk1_JobType")]
    [Index("MawbNo", Name = "INDEX_Aebk1_MAwbNo")]
    [Index("StatusCode", Name = "INDEX_Aebk1_StatusCode")]
    [Index("UpdateDateTime", Name = "INDEX_Aebk1_UpdateDateTime")]
    public partial class Aebk1
    {
        [Key]
        [StringLength(20)]
        public string BookingNo { get; set; } = null!;
        [StringLength(20)]
        public string? AwbNo { get; set; }
        [Column("MAwbNo")]
        [StringLength(20)]
        public string? MawbNo { get; set; }
        [StringLength(30)]
        public string? AccountInfo1 { get; set; }
        [StringLength(30)]
        public string? AccountInfo2 { get; set; }
        [StringLength(30)]
        public string? AccountInfo3 { get; set; }
        [StringLength(30)]
        public string? AccountInfo4 { get; set; }
        [StringLength(30)]
        public string? AccountInfo5 { get; set; }
        [StringLength(30)]
        public string? AccountInfo6 { get; set; }
        [StringLength(1)]
        public string? AdhocFilingFlag { get; set; }
        [StringLength(80)]
        public string? AdhocRateRemark { get; set; }
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
        [StringLength(10)]
        public string? AirlineConfirmCode { get; set; }
        [StringLength(50)]
        public string? AirlineContactName { get; set; }
        [StringLength(3)]
        public string? AirportDeptCode { get; set; }
        [StringLength(45)]
        public string? AirportDeptName { get; set; }
        [StringLength(3)]
        public string? AirportDestCode { get; set; }
        [StringLength(45)]
        public string? AirportDestName { get; set; }
        [StringLength(50)]
        public string? ApproveBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ApproveDate { get; set; }
        [StringLength(1)]
        public string? AsArrangeFlag { get; set; }
        [StringLength(10)]
        public string? AwbPrefix { get; set; }
        [StringLength(1)]
        public string? AwbPrintFlag { get; set; }
        [StringLength(1)]
        public string? AwbReceivedFlag { get; set; }
        [StringLength(10)]
        public string? BillingPartyCode { get; set; }
        public int? BlockBookingTrxNo { get; set; }
        [StringLength(50)]
        public string? BookedFrom { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BookingDateTime { get; set; }
        [Column("BookingETA", TypeName = "datetime")]
        public DateTime? BookingEta { get; set; }
        [Column("BookingETD", TypeName = "datetime")]
        public DateTime? BookingEtd { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? BookingGrossWeight { get; set; }
        public int? BookingPcs { get; set; }
        [StringLength(1)]
        public string? BookingSlipFlag { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? BookingVolume { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? BookingVolumetricWeight { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? BuyChargeWeight { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? BuyingAdhocRate { get; set; }
        [StringLength(80)]
        public string? BuyingAdhocRemark { get; set; }
        [StringLength(1)]
        public string? BuyIataFlag { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? BuyRate { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? BuyRateLessPercent { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? BuyTotalAmt { get; set; }
        [StringLength(10)]
        public string? CarriageDeclareValue { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? CarrierCcAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? CarrierPpAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ChargeAmt { get; set; }
        [StringLength(5)]
        public string? ChargeTableNo { get; set; }
        [StringLength(13)]
        public string? CollectionNoteNo { get; set; }
        [StringLength(1)]
        public string? CollectionStatusFlag { get; set; }
        [StringLength(10)]
        public string? ColoaderCode { get; set; }
        [StringLength(80)]
        public string? ColoaderName { get; set; }
        [StringLength(50)]
        public string? CommodityCode { get; set; }
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
        [StringLength(200)]
        public string? ContactEmail { get; set; }
        [StringLength(30)]
        public string? ContactTelephone { get; set; }
        [StringLength(50)]
        public string? CopyTemplateName { get; set; }
        [StringLength(255)]
        public string? CopyTemplateRemark { get; set; }
        [StringLength(2)]
        public string? CountryOfOrigin { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [StringLength(10)]
        public string? CustomDeclareValue { get; set; }
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [StringLength(50)]
        public string? CustomerRefNo { get; set; }
        [StringLength(1)]
        public string? CustomerServiceFlag { get; set; }
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
        [StringLength(5)]
        public string? DeliveryType { get; set; }
        [StringLength(55)]
        public string? Description01 { get; set; }
        [StringLength(55)]
        public string? Description02 { get; set; }
        [StringLength(55)]
        public string? Description03 { get; set; }
        [StringLength(55)]
        public string? Description04 { get; set; }
        [StringLength(55)]
        public string? Description05 { get; set; }
        [StringLength(55)]
        public string? Description06 { get; set; }
        [StringLength(55)]
        public string? Description07 { get; set; }
        [StringLength(55)]
        public string? Description08 { get; set; }
        [StringLength(55)]
        public string? Description09 { get; set; }
        [StringLength(55)]
        public string? Description10 { get; set; }
        [StringLength(55)]
        public string? Description11 { get; set; }
        [StringLength(55)]
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
        public string? EventTemplateName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ExecuteDate { get; set; }
        public byte? ExportCount { get; set; }
        public byte? FaxCount { get; set; }
        [Column("FirstByAirlineID")]
        [StringLength(3)]
        public string? FirstByAirlineId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FirstFlightDate { get; set; }
        [StringLength(6)]
        public string? FirstFlightNo { get; set; }
        [StringLength(3)]
        public string? FirstToDestCode { get; set; }
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
        public string? Footer6 { get; set; }
        [StringLength(80)]
        public string? Footer7 { get; set; }
        [StringLength(80)]
        public string? Footer8 { get; set; }
        [StringLength(80)]
        public string? Footer9 { get; set; }
        [StringLength(80)]
        public string? Footer10 { get; set; }
        [StringLength(2000)]
        public string? Footnote { get; set; }
        [Column("FourthByAirlineID")]
        [StringLength(3)]
        public string? FourthByAirlineId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FourthFlightDate { get; set; }
        [StringLength(6)]
        public string? FourthFlightNo { get; set; }
        [StringLength(3)]
        public string? FourthToDestCode { get; set; }
        [StringLength(10)]
        public string? FrtBillPartyCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? GrossWeight { get; set; }
        [StringLength(64)]
        public string? HandlingInfo1 { get; set; }
        [StringLength(64)]
        public string? HandlingInfo2 { get; set; }
        [StringLength(30)]
        public string? ImportJobNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? InsuranceAmt { get; set; }
        [StringLength(10)]
        public string? JobType { get; set; }
        [StringLength(1)]
        public string? KgLbFlag { get; set; }
        [StringLength(1)]
        public string? NominationFlag { get; set; }
        [StringLength(50)]
        public string? NominationRemark { get; set; }
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
        [StringLength(1)]
        public string? OnlineBookingFlag { get; set; }
        [StringLength(3)]
        public string? OriginCode { get; set; }
        [StringLength(45)]
        public string? OriginName { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? OtherAmt { get; set; }
        [StringLength(10)]
        public string? OtherBillPartyCode { get; set; }
        [StringLength(44)]
        public string? OtherCharge1 { get; set; }
        [StringLength(44)]
        public string? OtherCharge2 { get; set; }
        [StringLength(44)]
        public string? OtherCharge3 { get; set; }
        [StringLength(1)]
        public string? OtherChargePpCcFlag { get; set; }
        [StringLength(1)]
        public string? OtherFlag { get; set; }
        public int? Pcs { get; set; }
        [StringLength(15)]
        public string? PermitNo { get; set; }
        [StringLength(1)]
        public string? PostFlag { get; set; }
        public byte? PrintCount { get; set; }
        [StringLength(1)]
        public string? PrintDimFlag { get; set; }
        [StringLength(10)]
        public string? ProductCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ProfitSharePercent { get; set; }
        [StringLength(10)]
        public string? QuoteNo { get; set; }
        [StringLength(1)]
        public string? RateClassCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? RatePercent { get; set; }
        [StringLength(1000)]
        public string? Remark { get; set; }
        [StringLength(50)]
        public string? RequestBy { get; set; }
        [StringLength(250)]
        public string? RequestTo { get; set; }
        [StringLength(1)]
        public string? RoundingFlag { get; set; }
        [StringLength(10)]
        public string? SalesmanCode { get; set; }
        [Column("SecondByAirlineID")]
        [StringLength(3)]
        public string? SecondByAirlineId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SecondFlightDate { get; set; }
        [StringLength(6)]
        public string? SecondFlightNo { get; set; }
        [StringLength(3)]
        public string? SecondToDestCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? SellChargeWeight { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? SellingAdhocRate { get; set; }
        [StringLength(80)]
        public string? SellingAdhocRemark { get; set; }
        [StringLength(1)]
        public string? SellIataFlag { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? SellRate { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? SellRateLessPercent { get; set; }
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
        [StringLength(20)]
        public string? SiteCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? TactChargeWeight { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? TactRate { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TactTotalAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TaxChargeCcAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TaxChargePpAmt { get; set; }
        [Column("ThirdByAirlineID")]
        [StringLength(3)]
        public string? ThirdByAirlineId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ThirdFlightDate { get; set; }
        [StringLength(6)]
        public string? ThirdFlightNo { get; set; }
        [StringLength(3)]
        public string? ThirdToDestCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TotalCcAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TotalPpAmt { get; set; }
        public int TrxNo { get; set; }
        [StringLength(50)]
        public string? UomCode { get; set; }
        [StringLength(1)]
        public string? Uplift1Flag { get; set; }
        [StringLength(1)]
        public string? Uplift2Flag { get; set; }
        [StringLength(1)]
        public string? Uplift3Flag { get; set; }
        [StringLength(1)]
        public string? Uplift4Flag { get; set; }
        [StringLength(200)]
        public string? Uplift1Remark { get; set; }
        [StringLength(200)]
        public string? Uplift2Remark { get; set; }
        [StringLength(200)]
        public string? Uplift3Remark { get; set; }
        [StringLength(200)]
        public string? Uplift4Remark { get; set; }
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
        public decimal? Volume { get; set; }
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
