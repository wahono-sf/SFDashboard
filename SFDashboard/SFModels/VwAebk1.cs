using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwAebk1
    {
        [Column("Airline Code")]
        [StringLength(3)]
        public string? AirlineCode { get; set; }
        [Column("Master Airline Code")]
        [StringLength(3)]
        public string? MasterAirlineCode { get; set; }
        [Column("Account Info 1")]
        [StringLength(30)]
        public string? AccountInfo1 { get; set; }
        [Column("Account Info 2")]
        [StringLength(30)]
        public string? AccountInfo2 { get; set; }
        [Column("Account Info 3")]
        [StringLength(30)]
        public string? AccountInfo3 { get; set; }
        [Column("Account Info 4")]
        [StringLength(30)]
        public string? AccountInfo4 { get; set; }
        [Column("Account Info 5")]
        [StringLength(30)]
        public string? AccountInfo5 { get; set; }
        [Column("Account Info 6")]
        [StringLength(30)]
        public string? AccountInfo6 { get; set; }
        [Column("Adhoc Filing Flag")]
        [StringLength(1)]
        public string? AdhocFilingFlag { get; set; }
        [Column("Adhoc Rate Remark")]
        [StringLength(80)]
        public string? AdhocRateRemark { get; set; }
        [Column("Agent Acc Code")]
        [StringLength(15)]
        public string? AgentAccCode { get; set; }
        [Column("Agent Cc Amt", TypeName = "decimal(13, 2)")]
        public decimal? AgentCcAmt { get; set; }
        [Column("Agent Code")]
        [StringLength(10)]
        public string? AgentCode { get; set; }
        [Column("Agent Iata Code")]
        [StringLength(25)]
        public string? AgentIataCode { get; set; }
        [Column("Agent Pp Amt", TypeName = "decimal(13, 2)")]
        public decimal? AgentPpAmt { get; set; }
        [Column("Airline Confirm Code")]
        [StringLength(10)]
        public string? AirlineConfirmCode { get; set; }
        [Column("Airline Contact Name")]
        [StringLength(50)]
        public string? AirlineContactName { get; set; }
        [Column("Airport Dept Code")]
        [StringLength(3)]
        public string? AirportDeptCode { get; set; }
        [Column("Airport Dept Name")]
        [StringLength(45)]
        public string? AirportDeptName { get; set; }
        [Column("Airport Dest Code")]
        [StringLength(3)]
        public string? AirportDestCode { get; set; }
        [Column("Airport Dest Name")]
        [StringLength(45)]
        public string? AirportDestName { get; set; }
        [Column("Air Waybill No")]
        [StringLength(20)]
        public string? AirWaybillNo { get; set; }
        [Column("Approve By")]
        [StringLength(50)]
        public string? ApproveBy { get; set; }
        [Column("Approve Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ApproveDate { get; set; }
        [Column("As Arrange Flag")]
        [StringLength(1)]
        public string? AsArrangeFlag { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Awb No")]
        [StringLength(20)]
        public string? AwbNo { get; set; }
        [Column("Awb Prefix")]
        [StringLength(10)]
        public string? AwbPrefix { get; set; }
        [Column("Awb Print Flag")]
        [StringLength(1)]
        public string? AwbPrintFlag { get; set; }
        [Column("Awb Received Flag")]
        [StringLength(1)]
        public string? AwbReceivedFlag { get; set; }
        [Column("Billing Party Code")]
        [StringLength(10)]
        public string? BillingPartyCode { get; set; }
        [Column("Block Booking Trx No")]
        public int? BlockBookingTrxNo { get; set; }
        [Column("Booked From")]
        [StringLength(50)]
        public string? BookedFrom { get; set; }
        [Column("Booking Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? BookingDate { get; set; }
        [Column("Booking Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? BookingDateTime { get; set; }
        [Column("Booking ETA")]
        [StringLength(16)]
        [Unicode(false)]
        public string? BookingEta { get; set; }
        [Column("Booking ETD")]
        [StringLength(16)]
        [Unicode(false)]
        public string? BookingEtd { get; set; }
        [Column("Booking Gross Weight", TypeName = "decimal(13, 4)")]
        public decimal? BookingGrossWeight { get; set; }
        [Column("Booking No")]
        [StringLength(20)]
        public string BookingNo { get; set; } = null!;
        [Column("Booking Pcs")]
        public int? BookingPcs { get; set; }
        [Column("Booking Slip Flag")]
        [StringLength(1)]
        public string? BookingSlipFlag { get; set; }
        [Column("Booking Volume", TypeName = "decimal(13, 4)")]
        public decimal? BookingVolume { get; set; }
        [Column("Booking Volumetric Weight", TypeName = "decimal(13, 4)")]
        public decimal? BookingVolumetricWeight { get; set; }
        [Column("Buy Charge Weight", TypeName = "decimal(13, 4)")]
        public decimal? BuyChargeWeight { get; set; }
        [Column("Buy IATA Flag")]
        [StringLength(1)]
        public string? BuyIataFlag { get; set; }
        [Column("Buying Adhoc Rate", TypeName = "decimal(13, 2)")]
        public decimal? BuyingAdhocRate { get; set; }
        [Column("Buying Adhoc Remark")]
        [StringLength(80)]
        public string? BuyingAdhocRemark { get; set; }
        [Column("Buy Rate", TypeName = "decimal(13, 3)")]
        public decimal? BuyRate { get; set; }
        [Column("Buy Rate Less Percent", TypeName = "decimal(13, 3)")]
        public decimal? BuyRateLessPercent { get; set; }
        [Column("Buy Total Amt", TypeName = "decimal(13, 2)")]
        public decimal? BuyTotalAmt { get; set; }
        [Column("Carriage Declare Value")]
        [StringLength(10)]
        public string? CarriageDeclareValue { get; set; }
        [Column("Carrier Cc Amt", TypeName = "decimal(13, 2)")]
        public decimal? CarrierCcAmt { get; set; }
        [Column("Carrier Pp Amt", TypeName = "decimal(13, 2)")]
        public decimal? CarrierPpAmt { get; set; }
        [Column("Charge Amt", TypeName = "decimal(13, 2)")]
        public decimal? ChargeAmt { get; set; }
        [Column("Charge Table No")]
        [StringLength(5)]
        public string? ChargeTableNo { get; set; }
        [Column("Collection Note No")]
        [StringLength(13)]
        public string? CollectionNoteNo { get; set; }
        [Column("Collection Status Flag")]
        [StringLength(1)]
        public string? CollectionStatusFlag { get; set; }
        [Column("Coloader Code")]
        [StringLength(10)]
        public string? ColoaderCode { get; set; }
        [Column("Coloader Name")]
        [StringLength(80)]
        public string? ColoaderName { get; set; }
        [Column("Commodity Code")]
        [StringLength(50)]
        public string? CommodityCode { get; set; }
        [Column("Commodity Description 01")]
        [StringLength(50)]
        public string? CommodityDescription01 { get; set; }
        [Column("Commodity Description 02")]
        [StringLength(50)]
        public string? CommodityDescription02 { get; set; }
        [Column("Commodity Description 03")]
        [StringLength(50)]
        public string? CommodityDescription03 { get; set; }
        [Column("Commodity Description 04")]
        [StringLength(50)]
        public string? CommodityDescription04 { get; set; }
        [Column("Commodity Description 05")]
        [StringLength(50)]
        public string? CommodityDescription05 { get; set; }
        [Column("Commodity Description 06")]
        [StringLength(50)]
        public string? CommodityDescription06 { get; set; }
        [Column("Commodity Description 07")]
        [StringLength(50)]
        public string? CommodityDescription07 { get; set; }
        [Column("Commodity Description 08")]
        [StringLength(50)]
        public string? CommodityDescription08 { get; set; }
        [Column("Commodity Description 09")]
        [StringLength(50)]
        public string? CommodityDescription09 { get; set; }
        [Column("Commodity Description 10")]
        [StringLength(50)]
        public string? CommodityDescription10 { get; set; }
        [Column("Commodity Description 11")]
        [StringLength(50)]
        public string? CommodityDescription11 { get; set; }
        [Column("Commodity Description 12")]
        [StringLength(50)]
        public string? CommodityDescription12 { get; set; }
        [Column("Commodity Description 13")]
        [StringLength(50)]
        public string? CommodityDescription13 { get; set; }
        [Column("Commodity Description 14")]
        [StringLength(50)]
        public string? CommodityDescription14 { get; set; }
        [Column("Consignee Code")]
        [StringLength(10)]
        public string? ConsigneeCode { get; set; }
        [Column("Consignee Name")]
        [StringLength(80)]
        public string? ConsigneeName { get; set; }
        [Column("Consignee Acc Code")]
        [StringLength(15)]
        public string? ConsigneeAccCode { get; set; }
        [Column("Consignee Address 1")]
        [StringLength(50)]
        public string? ConsigneeAddress1 { get; set; }
        [Column("Consignee Address 2")]
        [StringLength(50)]
        public string? ConsigneeAddress2 { get; set; }
        [Column("Consignee Address 3")]
        [StringLength(50)]
        public string? ConsigneeAddress3 { get; set; }
        [Column("Consignee Address 4")]
        [StringLength(50)]
        public string? ConsigneeAddress4 { get; set; }
        [Column("Contact Email")]
        [StringLength(200)]
        public string? ContactEmail { get; set; }
        [Column("Contact Telephone")]
        [StringLength(30)]
        public string? ContactTelephone { get; set; }
        [Column("Copy Template Name")]
        [StringLength(50)]
        public string? CopyTemplateName { get; set; }
        [Column("Copy Template Remark")]
        [StringLength(255)]
        public string? CopyTemplateRemark { get; set; }
        [Column("Country Of Origin")]
        [StringLength(2)]
        public string? CountryOfOrigin { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Custom Declare Value")]
        [StringLength(10)]
        public string? CustomDeclareValue { get; set; }
        [Column("Customer Code")]
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [Column("Customer Name")]
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [Column("Customer Service Flag")]
        [StringLength(1)]
        public string? CustomerServiceFlag { get; set; }
        [Column("Customer Ref No")]
        [StringLength(50)]
        public string? CustomerRefNo { get; set; }
        [Column("Delivery Agent Code")]
        [StringLength(10)]
        public string? DeliveryAgentCode { get; set; }
        [Column("Delivery Agent Name")]
        [StringLength(80)]
        public string? DeliveryAgentName { get; set; }
        [Column("Delivery Agent Address1")]
        [StringLength(50)]
        public string? DeliveryAgentAddress1 { get; set; }
        [Column("Delivery Agent Address2")]
        [StringLength(50)]
        public string? DeliveryAgentAddress2 { get; set; }
        [Column("Delivery Agent Address3")]
        [StringLength(50)]
        public string? DeliveryAgentAddress3 { get; set; }
        [Column("Delivery Agent Address4")]
        [StringLength(50)]
        public string? DeliveryAgentAddress4 { get; set; }
        [Column("Delivery Type")]
        [StringLength(5)]
        public string? DeliveryType { get; set; }
        [Column("Description 01")]
        [StringLength(55)]
        public string? Description01 { get; set; }
        [Column("Description 02")]
        [StringLength(55)]
        public string? Description02 { get; set; }
        [Column("Description 03")]
        [StringLength(55)]
        public string? Description03 { get; set; }
        [Column("Description 04")]
        [StringLength(55)]
        public string? Description04 { get; set; }
        [Column("Description 05")]
        [StringLength(55)]
        public string? Description05 { get; set; }
        [Column("Description 06")]
        [StringLength(55)]
        public string? Description06 { get; set; }
        [Column("Description 07")]
        [StringLength(55)]
        public string? Description07 { get; set; }
        [Column("Description 08")]
        [StringLength(55)]
        public string? Description08 { get; set; }
        [Column("Description 09")]
        [StringLength(55)]
        public string? Description09 { get; set; }
        [Column("Description 10")]
        [StringLength(55)]
        public string? Description10 { get; set; }
        [Column("Description 11")]
        [StringLength(55)]
        public string? Description11 { get; set; }
        [Column("Description 12")]
        [StringLength(55)]
        public string? Description12 { get; set; }
        [Column("Dest Cc Amt", TypeName = "decimal(13, 2)")]
        public decimal? DestCcAmt { get; set; }
        [Column("Dest Code")]
        [StringLength(3)]
        public string? DestCode { get; set; }
        [Column("Dest Curr Code")]
        [StringLength(3)]
        public string? DestCurrCode { get; set; }
        [Column("Dest Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? DestCurrRate { get; set; }
        [Column("Dest Name")]
        [StringLength(45)]
        public string? DestName { get; set; }
        public string? Dimension { get; set; }
        [Column("Dim Type")]
        [StringLength(2)]
        public string? DimType { get; set; }
        [Column("Division Code")]
        [StringLength(10)]
        public string? DivisionCode { get; set; }
        [Column("Doc Charge Weight", TypeName = "decimal(13, 4)")]
        public decimal? DocChargeWeight { get; set; }
        [Column("Doc Rate", TypeName = "decimal(13, 3)")]
        public decimal? DocRate { get; set; }
        [Column("Doc Total Amt", TypeName = "decimal(13, 2)")]
        public decimal? DocTotalAmt { get; set; }
        [Column("Due Agent Awb Flag 01")]
        [StringLength(1)]
        public string? DueAgentAwbFlag01 { get; set; }
        [Column("Due Agent Awb Flag 02")]
        [StringLength(1)]
        public string? DueAgentAwbFlag02 { get; set; }
        [Column("Due Agent Awb Flag 03")]
        [StringLength(1)]
        public string? DueAgentAwbFlag03 { get; set; }
        [Column("Due Agent Awb Flag 04")]
        [StringLength(1)]
        public string? DueAgentAwbFlag04 { get; set; }
        [Column("Due Agent Awb Flag 05")]
        [StringLength(1)]
        public string? DueAgentAwbFlag05 { get; set; }
        [Column("Due Agent Awb Flag 06")]
        [StringLength(1)]
        public string? DueAgentAwbFlag06 { get; set; }
        [Column("Due Agent Awb Flag 07")]
        [StringLength(1)]
        public string? DueAgentAwbFlag07 { get; set; }
        [Column("Due Agent Awb Flag 08")]
        [StringLength(1)]
        public string? DueAgentAwbFlag08 { get; set; }
        [Column("Due Agent Awb Flag 09")]
        [StringLength(1)]
        public string? DueAgentAwbFlag09 { get; set; }
        [Column("Due Agent Awb Flag 10")]
        [StringLength(1)]
        public string? DueAgentAwbFlag10 { get; set; }
        [Column("Due Agent Awb Flag 11")]
        [StringLength(1)]
        public string? DueAgentAwbFlag11 { get; set; }
        [Column("Due Agent Awb Flag 12")]
        [StringLength(1)]
        public string? DueAgentAwbFlag12 { get; set; }
        [Column("Due Agent Charge Code 01")]
        [StringLength(3)]
        public string? DueAgentChargeCode01 { get; set; }
        [Column("Due Agent Charge Code 02")]
        [StringLength(3)]
        public string? DueAgentChargeCode02 { get; set; }
        [Column("Due Agent Charge Code 03")]
        [StringLength(3)]
        public string? DueAgentChargeCode03 { get; set; }
        [Column("Due Agent Charge Code 04")]
        [StringLength(3)]
        public string? DueAgentChargeCode04 { get; set; }
        [Column("Due Agent Charge Code 05")]
        [StringLength(3)]
        public string? DueAgentChargeCode05 { get; set; }
        [Column("Due Agent Charge Code 06")]
        [StringLength(3)]
        public string? DueAgentChargeCode06 { get; set; }
        [Column("Due Agent Charge Code 07")]
        [StringLength(3)]
        public string? DueAgentChargeCode07 { get; set; }
        [Column("Due Agent Charge Code 08")]
        [StringLength(3)]
        public string? DueAgentChargeCode08 { get; set; }
        [Column("Due Agent Charge Code 09")]
        [StringLength(3)]
        public string? DueAgentChargeCode09 { get; set; }
        [Column("Due Agent Charge Code 10")]
        [StringLength(3)]
        public string? DueAgentChargeCode10 { get; set; }
        [Column("Due Agent Charge Code 11")]
        [StringLength(3)]
        public string? DueAgentChargeCode11 { get; set; }
        [Column("Due Agent Charge Code 12")]
        [StringLength(3)]
        public string? DueAgentChargeCode12 { get; set; }
        [Column("Due Agent Pp Cc Flag 01")]
        [StringLength(1)]
        public string? DueAgentPpCcFlag01 { get; set; }
        [Column("Due Agent Pp Cc Flag 02")]
        [StringLength(1)]
        public string? DueAgentPpCcFlag02 { get; set; }
        [Column("Due Agent Pp Cc Flag 03")]
        [StringLength(1)]
        public string? DueAgentPpCcFlag03 { get; set; }
        [Column("Due Agent Pp Cc Flag 04")]
        [StringLength(1)]
        public string? DueAgentPpCcFlag04 { get; set; }
        [Column("Due Agent Pp Cc Flag 05")]
        [StringLength(1)]
        public string? DueAgentPpCcFlag05 { get; set; }
        [Column("Due Agent Pp Cc Flag 06")]
        [StringLength(1)]
        public string? DueAgentPpCcFlag06 { get; set; }
        [Column("Due Agent Pp Cc Flag 07")]
        [StringLength(1)]
        public string? DueAgentPpCcFlag07 { get; set; }
        [Column("Due Agent Pp Cc Flag 08")]
        [StringLength(1)]
        public string? DueAgentPpCcFlag08 { get; set; }
        [Column("Due Agent Pp Cc Flag 09")]
        [StringLength(1)]
        public string? DueAgentPpCcFlag09 { get; set; }
        [Column("Due Agent Pp Cc Flag 10")]
        [StringLength(1)]
        public string? DueAgentPpCcFlag10 { get; set; }
        [Column("Due Agent Pp Cc Flag 11")]
        [StringLength(1)]
        public string? DueAgentPpCcFlag11 { get; set; }
        [Column("Due Agent Pp Cc Flag 12")]
        [StringLength(1)]
        public string? DueAgentPpCcFlag12 { get; set; }
        [Column("Due Agent Rate 01", TypeName = "decimal(13, 2)")]
        public decimal? DueAgentRate01 { get; set; }
        [Column("Due Agent Rate 02", TypeName = "decimal(13, 2)")]
        public decimal? DueAgentRate02 { get; set; }
        [Column("Due Agent Rate 03", TypeName = "decimal(13, 2)")]
        public decimal? DueAgentRate03 { get; set; }
        [Column("Due Agent Rate 04", TypeName = "decimal(13, 2)")]
        public decimal? DueAgentRate04 { get; set; }
        [Column("Due Agent Rate 05", TypeName = "decimal(13, 2)")]
        public decimal? DueAgentRate05 { get; set; }
        [Column("Due Agent Rate 06", TypeName = "decimal(13, 2)")]
        public decimal? DueAgentRate06 { get; set; }
        [Column("Due Agent Rate 07", TypeName = "decimal(13, 2)")]
        public decimal? DueAgentRate07 { get; set; }
        [Column("Due Agent Rate 08", TypeName = "decimal(13, 2)")]
        public decimal? DueAgentRate08 { get; set; }
        [Column("Due Agent Rate 09", TypeName = "decimal(13, 2)")]
        public decimal? DueAgentRate09 { get; set; }
        [Column("Due Agent Rate 10", TypeName = "decimal(13, 2)")]
        public decimal? DueAgentRate10 { get; set; }
        [Column("Due Agent Rate 11", TypeName = "decimal(13, 2)")]
        public decimal? DueAgentRate11 { get; set; }
        [Column("Due Agent Rate 12", TypeName = "decimal(13, 2)")]
        public decimal? DueAgentRate12 { get; set; }
        [Column("Due Agent Total Amt", TypeName = "decimal(13, 2)")]
        public decimal? DueAgentTotalAmt { get; set; }
        [Column("Due Carrier Awb Flag 01")]
        [StringLength(1)]
        public string? DueCarrierAwbFlag01 { get; set; }
        [Column("Due Carrier Awb Flag 02")]
        [StringLength(1)]
        public string? DueCarrierAwbFlag02 { get; set; }
        [Column("Due Carrier Awb Flag 03")]
        [StringLength(1)]
        public string? DueCarrierAwbFlag03 { get; set; }
        [Column("Due Carrier Awb Flag 04")]
        [StringLength(1)]
        public string? DueCarrierAwbFlag04 { get; set; }
        [Column("Due Carrier Awb Flag 05")]
        [StringLength(1)]
        public string? DueCarrierAwbFlag05 { get; set; }
        [Column("Due Carrier Awb Flag 06")]
        [StringLength(1)]
        public string? DueCarrierAwbFlag06 { get; set; }
        [Column("Due Carrier Awb Flag 07")]
        [StringLength(1)]
        public string? DueCarrierAwbFlag07 { get; set; }
        [Column("Due Carrier Awb Flag 08")]
        [StringLength(1)]
        public string? DueCarrierAwbFlag08 { get; set; }
        [Column("Due Carrier Awb Flag 09")]
        [StringLength(1)]
        public string? DueCarrierAwbFlag09 { get; set; }
        [Column("Due Carrier Awb Flag 10")]
        [StringLength(1)]
        public string? DueCarrierAwbFlag10 { get; set; }
        [Column("Due Carrier Awb Flag 11")]
        [StringLength(1)]
        public string? DueCarrierAwbFlag11 { get; set; }
        [Column("Due Carrier Awb Flag 12")]
        [StringLength(1)]
        public string? DueCarrierAwbFlag12 { get; set; }
        [Column("Due Carrier Charge Code 01")]
        [StringLength(3)]
        public string? DueCarrierChargeCode01 { get; set; }
        [Column("Due Carrier Charge Code 02")]
        [StringLength(3)]
        public string? DueCarrierChargeCode02 { get; set; }
        [Column("Due Carrier Charge Code 03")]
        [StringLength(3)]
        public string? DueCarrierChargeCode03 { get; set; }
        [Column("Due Carrier Charge Code 04")]
        [StringLength(3)]
        public string? DueCarrierChargeCode04 { get; set; }
        [Column("Due Carrier Charge Code 05")]
        [StringLength(3)]
        public string? DueCarrierChargeCode05 { get; set; }
        [Column("Due Carrier Charge Code 06")]
        [StringLength(3)]
        public string? DueCarrierChargeCode06 { get; set; }
        [Column("Due Carrier Charge Code 07")]
        [StringLength(3)]
        public string? DueCarrierChargeCode07 { get; set; }
        [Column("Due Carrier Charge Code 08")]
        [StringLength(3)]
        public string? DueCarrierChargeCode08 { get; set; }
        [Column("Due Carrier Charge Code 09")]
        [StringLength(3)]
        public string? DueCarrierChargeCode09 { get; set; }
        [Column("Due Carrier Charge Code 10")]
        [StringLength(3)]
        public string? DueCarrierChargeCode10 { get; set; }
        [Column("Due Carrier Charge Code 11")]
        [StringLength(3)]
        public string? DueCarrierChargeCode11 { get; set; }
        [Column("Due Carrier Charge Code 12")]
        [StringLength(3)]
        public string? DueCarrierChargeCode12 { get; set; }
        [Column("Due Carrier Pp Cc Flag 01")]
        [StringLength(1)]
        public string? DueCarrierPpCcFlag01 { get; set; }
        [Column("Due Carrier Pp Cc Flag 02")]
        [StringLength(1)]
        public string? DueCarrierPpCcFlag02 { get; set; }
        [Column("Due Carrier Pp Cc Flag 03")]
        [StringLength(1)]
        public string? DueCarrierPpCcFlag03 { get; set; }
        [Column("Due Carrier Pp Cc Flag 04")]
        [StringLength(1)]
        public string? DueCarrierPpCcFlag04 { get; set; }
        [Column("Due Carrier Pp Cc Flag 05")]
        [StringLength(1)]
        public string? DueCarrierPpCcFlag05 { get; set; }
        [Column("Due Carrier Pp Cc Flag 06")]
        [StringLength(1)]
        public string? DueCarrierPpCcFlag06 { get; set; }
        [Column("Due Carrier Pp Cc Flag 07")]
        [StringLength(1)]
        public string? DueCarrierPpCcFlag07 { get; set; }
        [Column("Due Carrier Pp Cc Flag 08")]
        [StringLength(1)]
        public string? DueCarrierPpCcFlag08 { get; set; }
        [Column("Due Carrier Pp Cc Flag 09")]
        [StringLength(1)]
        public string? DueCarrierPpCcFlag09 { get; set; }
        [Column("Due Carrier Pp Cc Flag 10")]
        [StringLength(1)]
        public string? DueCarrierPpCcFlag10 { get; set; }
        [Column("Due Carrier Pp Cc Flag 11")]
        [StringLength(1)]
        public string? DueCarrierPpCcFlag11 { get; set; }
        [Column("Due Carrier Pp Cc Flag 12")]
        [StringLength(1)]
        public string? DueCarrierPpCcFlag12 { get; set; }
        [Column("Due Carrier Rate 01", TypeName = "decimal(13, 2)")]
        public decimal? DueCarrierRate01 { get; set; }
        [Column("Due Carrier Rate 02", TypeName = "decimal(13, 2)")]
        public decimal? DueCarrierRate02 { get; set; }
        [Column("Due Carrier Rate 03", TypeName = "decimal(13, 2)")]
        public decimal? DueCarrierRate03 { get; set; }
        [Column("Due Carrier Rate 04", TypeName = "decimal(13, 2)")]
        public decimal? DueCarrierRate04 { get; set; }
        [Column("Due Carrier Rate 05", TypeName = "decimal(13, 2)")]
        public decimal? DueCarrierRate05 { get; set; }
        [Column("Due Carrier Rate 06", TypeName = "decimal(13, 2)")]
        public decimal? DueCarrierRate06 { get; set; }
        [Column("Due Carrier Rate 07", TypeName = "decimal(13, 2)")]
        public decimal? DueCarrierRate07 { get; set; }
        [Column("Due Carrier Rate 08", TypeName = "decimal(13, 2)")]
        public decimal? DueCarrierRate08 { get; set; }
        [Column("Due Carrier Rate 09", TypeName = "decimal(13, 2)")]
        public decimal? DueCarrierRate09 { get; set; }
        [Column("Due Carrier Rate 10", TypeName = "decimal(13, 2)")]
        public decimal? DueCarrierRate10 { get; set; }
        [Column("Due Carrier Rate 11", TypeName = "decimal(13, 2)")]
        public decimal? DueCarrierRate11 { get; set; }
        [Column("Due Carrier Rate 12", TypeName = "decimal(13, 2)")]
        public decimal? DueCarrierRate12 { get; set; }
        [Column("Due Carrier Total Amt", TypeName = "decimal(13, 2)")]
        public decimal? DueCarrierTotalAmt { get; set; }
        [Column("EDI Count")]
        public byte? EdiCount { get; set; }
        [Column("Email Count")]
        public byte? EmailCount { get; set; }
        [Column("Event Template Name")]
        [StringLength(50)]
        public string? EventTemplateName { get; set; }
        [Column("Execute Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ExecuteDate { get; set; }
        [Column("Export Count")]
        public byte? ExportCount { get; set; }
        [Column("Fax Count")]
        public byte? FaxCount { get; set; }
        [Column("First By Airline ID")]
        [StringLength(3)]
        public string? FirstByAirlineId { get; set; }
        [Column("First Eta Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? FirstEtaDate { get; set; }
        [Column("First Eta Time")]
        [StringLength(5)]
        [Unicode(false)]
        public string? FirstEtaTime { get; set; }
        [Column("First Flight Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? FirstFlightDate { get; set; }
        [Column("First Flight Time")]
        [StringLength(5)]
        [Unicode(false)]
        public string? FirstFlightTime { get; set; }
        [Column("First Flight No")]
        [StringLength(6)]
        public string? FirstFlightNo { get; set; }
        [Column("First To Dest Code")]
        [StringLength(3)]
        public string? FirstToDestCode { get; set; }
        [Column("Footer 1")]
        [StringLength(80)]
        public string? Footer1 { get; set; }
        [Column("Footer 2")]
        [StringLength(80)]
        public string? Footer2 { get; set; }
        [Column("Footer 3")]
        [StringLength(80)]
        public string? Footer3 { get; set; }
        [Column("Footer 4")]
        [StringLength(80)]
        public string? Footer4 { get; set; }
        [Column("Footer 5")]
        [StringLength(80)]
        public string? Footer5 { get; set; }
        [Column("Footer 6")]
        [StringLength(80)]
        public string? Footer6 { get; set; }
        [Column("Footer 7")]
        [StringLength(80)]
        public string? Footer7 { get; set; }
        [Column("Footer 8")]
        [StringLength(80)]
        public string? Footer8 { get; set; }
        [Column("Footer 9")]
        [StringLength(80)]
        public string? Footer9 { get; set; }
        [Column("Footer 10")]
        [StringLength(80)]
        public string? Footer10 { get; set; }
        [StringLength(2000)]
        public string? Footnote { get; set; }
        [Column("Fourth By Airline ID")]
        [StringLength(3)]
        public string? FourthByAirlineId { get; set; }
        [Column("Fourth Eta Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? FourthEtaDate { get; set; }
        [Column("Fourth Eta Time")]
        [StringLength(5)]
        [Unicode(false)]
        public string? FourthEtaTime { get; set; }
        [Column("Fourth Flight Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? FourthFlightDate { get; set; }
        [Column("Fourth Flight Time")]
        [StringLength(5)]
        [Unicode(false)]
        public string? FourthFlightTime { get; set; }
        [Column("Fourth Flight No")]
        [StringLength(6)]
        public string? FourthFlightNo { get; set; }
        [Column("Fourth To Dest Code")]
        [StringLength(3)]
        public string? FourthToDestCode { get; set; }
        [Column("Frt Bill Party Code")]
        [StringLength(10)]
        public string? FrtBillPartyCode { get; set; }
        [Column("Gross Weight", TypeName = "decimal(13, 4)")]
        public decimal? GrossWeight { get; set; }
        [Column("Handling Info 1")]
        [StringLength(64)]
        public string? HandlingInfo1 { get; set; }
        [Column("Handling Info 2")]
        [StringLength(64)]
        public string? HandlingInfo2 { get; set; }
        [Column("Import Job No")]
        [StringLength(30)]
        public string? ImportJobNo { get; set; }
        [Column("Insurance Amt", TypeName = "decimal(13, 2)")]
        public decimal? InsuranceAmt { get; set; }
        [Column("Invoice No")]
        [StringLength(20)]
        public string? InvoiceNo { get; set; }
        [Column("Job Costing Flag")]
        [StringLength(1)]
        [Unicode(false)]
        public string JobCostingFlag { get; set; } = null!;
        [Column("Job No")]
        [StringLength(30)]
        public string? JobNo { get; set; }
        [Column("Job Type")]
        [StringLength(10)]
        public string? JobType { get; set; }
        [Column("Kg Lb Flag")]
        [StringLength(1)]
        public string? KgLbFlag { get; set; }
        [Column("M Awb No")]
        [StringLength(20)]
        public string? MAwbNo { get; set; }
        [Column("Master Air Waybill No")]
        [StringLength(13)]
        public string? MasterAirWaybillNo { get; set; }
        [Column("Nomination Flag")]
        [StringLength(1)]
        public string? NominationFlag { get; set; }
        [Column("Nomination Remark")]
        [StringLength(50)]
        public string? NominationRemark { get; set; }
        [Column("Notify Code")]
        [StringLength(10)]
        public string? NotifyCode { get; set; }
        [Column("Notify Name")]
        [StringLength(80)]
        public string? NotifyName { get; set; }
        [Column("Notify Acct Code")]
        [StringLength(15)]
        public string? NotifyAcctCode { get; set; }
        [Column("Notify Address 1")]
        [StringLength(50)]
        public string? NotifyAddress1 { get; set; }
        [Column("Notify Address 2")]
        [StringLength(50)]
        public string? NotifyAddress2 { get; set; }
        [Column("Notify Address 3")]
        [StringLength(50)]
        public string? NotifyAddress3 { get; set; }
        [Column("Notify Address 4")]
        [StringLength(50)]
        public string? NotifyAddress4 { get; set; }
        [Column("Online Booking Flag")]
        [StringLength(1)]
        public string? OnlineBookingFlag { get; set; }
        [Column("Origin Code")]
        [StringLength(3)]
        public string? OriginCode { get; set; }
        [Column("Origin Name")]
        [StringLength(45)]
        public string? OriginName { get; set; }
        [Column("Other Amt", TypeName = "decimal(13, 2)")]
        public decimal? OtherAmt { get; set; }
        [Column("Other Bill Party Code")]
        [StringLength(10)]
        public string? OtherBillPartyCode { get; set; }
        [Column("Other Charge 1")]
        [StringLength(44)]
        public string? OtherCharge1 { get; set; }
        [Column("Other Charge 2")]
        [StringLength(44)]
        public string? OtherCharge2 { get; set; }
        [Column("Other Charge 3")]
        [StringLength(44)]
        public string? OtherCharge3 { get; set; }
        [Column("Other Charge Pp Cc Flag")]
        [StringLength(1)]
        public string? OtherChargePpCcFlag { get; set; }
        [Column("Other Flag")]
        [StringLength(1)]
        public string? OtherFlag { get; set; }
        public int? Pcs { get; set; }
        [Column("Permit No")]
        [StringLength(15)]
        public string? PermitNo { get; set; }
        [Column("Post Flag")]
        [StringLength(1)]
        public string? PostFlag { get; set; }
        [Column("Print Count")]
        public byte? PrintCount { get; set; }
        [Column("Print Dim Flag")]
        [StringLength(1)]
        public string? PrintDimFlag { get; set; }
        [Column("Product Code")]
        [StringLength(10)]
        public string? ProductCode { get; set; }
        [Column("Profit Share Percent", TypeName = "decimal(13, 2)")]
        public decimal? ProfitSharePercent { get; set; }
        [Column("Quote No")]
        [StringLength(10)]
        public string? QuoteNo { get; set; }
        [Column("Rate Class Code")]
        [StringLength(1)]
        public string? RateClassCode { get; set; }
        [Column("Rate Percent", TypeName = "decimal(13, 2)")]
        public decimal? RatePercent { get; set; }
        [StringLength(1000)]
        public string? Remark { get; set; }
        [Column("Remark Only")]
        [StringLength(4000)]
        public string? RemarkOnly { get; set; }
        [Column("Request By")]
        [StringLength(50)]
        public string? RequestBy { get; set; }
        [Column("Request To")]
        [StringLength(250)]
        public string? RequestTo { get; set; }
        [Column("Rounding Flag")]
        [StringLength(1)]
        public string? RoundingFlag { get; set; }
        [Column("Salesman Code")]
        [StringLength(10)]
        public string? SalesmanCode { get; set; }
        [Column("Second By Airline I D")]
        [StringLength(3)]
        public string? SecondByAirlineID { get; set; }
        [Column("Second Eta Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? SecondEtaDate { get; set; }
        [Column("Second Eta Time")]
        [StringLength(5)]
        [Unicode(false)]
        public string? SecondEtaTime { get; set; }
        [Column("Second Flight Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? SecondFlightDate { get; set; }
        [Column("Second Flight Time")]
        [StringLength(5)]
        [Unicode(false)]
        public string? SecondFlightTime { get; set; }
        [Column("Second Flight No")]
        [StringLength(6)]
        public string? SecondFlightNo { get; set; }
        [Column("Second To Dest Code")]
        [StringLength(3)]
        public string? SecondToDestCode { get; set; }
        [Column("Sell Charge Weight", TypeName = "decimal(13, 4)")]
        public decimal? SellChargeWeight { get; set; }
        [Column("Sell IATA Flag")]
        [StringLength(1)]
        public string? SellIataFlag { get; set; }
        [Column("Selling Adhoc Rate", TypeName = "decimal(13, 2)")]
        public decimal? SellingAdhocRate { get; set; }
        [Column("Selling Adhoc Remark")]
        [StringLength(80)]
        public string? SellingAdhocRemark { get; set; }
        [Column("Sell Rate", TypeName = "decimal(13, 3)")]
        public decimal? SellRate { get; set; }
        [Column("Sell Rate Less Percent", TypeName = "decimal(13, 3)")]
        public decimal? SellRateLessPercent { get; set; }
        [Column("Sell Total Amt", TypeName = "decimal(13, 2)")]
        public decimal? SellTotalAmt { get; set; }
        [Column("Shipment Type")]
        [StringLength(1)]
        public string? ShipmentType { get; set; }
        [Column("Ship Mode")]
        [StringLength(2)]
        public string? ShipMode { get; set; }
        [Column("Shipper Code")]
        [StringLength(10)]
        public string? ShipperCode { get; set; }
        [Column("Shipper Name")]
        [StringLength(80)]
        public string? ShipperName { get; set; }
        [Column("Shipper Acc Code")]
        [StringLength(15)]
        public string? ShipperAccCode { get; set; }
        [Column("Shipper Address 1")]
        [StringLength(50)]
        public string? ShipperAddress1 { get; set; }
        [Column("Shipper Address 2")]
        [StringLength(50)]
        public string? ShipperAddress2 { get; set; }
        [Column("Shipper Address 3")]
        [StringLength(50)]
        public string? ShipperAddress3 { get; set; }
        [Column("Shipper Address 4")]
        [StringLength(50)]
        public string? ShipperAddress4 { get; set; }
        [Column("Site Code")]
        [StringLength(20)]
        public string? SiteCode { get; set; }
        [Column("Tact Charge Weight", TypeName = "decimal(13, 4)")]
        public decimal? TactChargeWeight { get; set; }
        [Column("Tact Rate", TypeName = "decimal(13, 3)")]
        public decimal? TactRate { get; set; }
        [Column("Tact Total Amt", TypeName = "decimal(13, 2)")]
        public decimal? TactTotalAmt { get; set; }
        [Column("Tax Charge Cc Amt", TypeName = "decimal(13, 2)")]
        public decimal? TaxChargeCcAmt { get; set; }
        [Column("Tax Charge Pp Amt", TypeName = "decimal(13, 2)")]
        public decimal? TaxChargePpAmt { get; set; }
        [Column("Third By Airline ID")]
        [StringLength(3)]
        public string? ThirdByAirlineId { get; set; }
        [Column("Third Eta Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ThirdEtaDate { get; set; }
        [Column("Third Eta Time")]
        [StringLength(5)]
        [Unicode(false)]
        public string? ThirdEtaTime { get; set; }
        [Column("Third Flight Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ThirdFlightDate { get; set; }
        [Column("Third Flight Time")]
        [StringLength(5)]
        [Unicode(false)]
        public string? ThirdFlightTime { get; set; }
        [Column("Third Flight No")]
        [StringLength(6)]
        public string? ThirdFlightNo { get; set; }
        [Column("Third To Dest Code")]
        [StringLength(3)]
        public string? ThirdToDestCode { get; set; }
        [Column("Total Cc Amt", TypeName = "decimal(13, 2)")]
        public decimal? TotalCcAmt { get; set; }
        [Column("Total Pp Amt", TypeName = "decimal(13, 2)")]
        public decimal? TotalPpAmt { get; set; }
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Uom Code")]
        [StringLength(50)]
        public string? UomCode { get; set; }
        [Column("Uplift 1 Flag")]
        [StringLength(1)]
        public string? Uplift1Flag { get; set; }
        [Column("Uplift 2 Flag")]
        [StringLength(1)]
        public string? Uplift2Flag { get; set; }
        [Column("Uplift 3 Flag")]
        [StringLength(1)]
        public string? Uplift3Flag { get; set; }
        [Column("Uplift 4 Flag")]
        [StringLength(1)]
        public string? Uplift4Flag { get; set; }
        [Column("Uplift 1 Remark")]
        [StringLength(200)]
        public string? Uplift1Remark { get; set; }
        [Column("Uplift 2 Remark")]
        [StringLength(200)]
        public string? Uplift2Remark { get; set; }
        [Column("Uplift 3 Remark")]
        [StringLength(200)]
        public string? Uplift3Remark { get; set; }
        [Column("Uplift 4 Remark")]
        [StringLength(200)]
        public string? Uplift4Remark { get; set; }
        [Column("User Define 01")]
        [StringLength(255)]
        public string? UserDefine01 { get; set; }
        [Column("User Define 02")]
        [StringLength(255)]
        public string? UserDefine02 { get; set; }
        [Column("User Define 03")]
        [StringLength(255)]
        public string? UserDefine03 { get; set; }
        [Column("User Define 04")]
        [StringLength(255)]
        public string? UserDefine04 { get; set; }
        [Column("User Define 05")]
        [StringLength(255)]
        public string? UserDefine05 { get; set; }
        [Column("User Define 06")]
        [StringLength(255)]
        public string? UserDefine06 { get; set; }
        [Column("User Define 07")]
        [StringLength(255)]
        public string? UserDefine07 { get; set; }
        [Column("User Define 08")]
        [StringLength(255)]
        public string? UserDefine08 { get; set; }
        [Column("User Define 09")]
        [StringLength(255)]
        public string? UserDefine09 { get; set; }
        [Column("User Define 10")]
        [StringLength(255)]
        public string? UserDefine10 { get; set; }
        [Column("User Define 11")]
        [StringLength(255)]
        public string? UserDefine11 { get; set; }
        [Column("User Define 12")]
        [StringLength(255)]
        public string? UserDefine12 { get; set; }
        [Column("User Define 13")]
        [StringLength(255)]
        public string? UserDefine13 { get; set; }
        [Column("User Define 14")]
        [StringLength(255)]
        public string? UserDefine14 { get; set; }
        [Column("User Define 15")]
        [StringLength(255)]
        public string? UserDefine15 { get; set; }
        [Column("User Define 16")]
        [StringLength(255)]
        public string? UserDefine16 { get; set; }
        [Column("User Define 17")]
        [StringLength(255)]
        public string? UserDefine17 { get; set; }
        [Column("User Define 18")]
        [StringLength(255)]
        public string? UserDefine18 { get; set; }
        [Column("User Define 19")]
        [StringLength(255)]
        public string? UserDefine19 { get; set; }
        [Column("User Define 20")]
        [StringLength(255)]
        public string? UserDefine20 { get; set; }
        [Column("Value Charge Cc Amt", TypeName = "decimal(13, 2)")]
        public decimal? ValueChargeCcAmt { get; set; }
        [Column("Value Charge Pp Amt", TypeName = "decimal(13, 2)")]
        public decimal? ValueChargePpAmt { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Volume { get; set; }
        [Column("Volumetric Weight", TypeName = "decimal(13, 4)")]
        public decimal? VolumetricWeight { get; set; }
        [Column("Volumetric Weight Ratio")]
        public short? VolumetricWeightRatio { get; set; }
        [Column("Weight Charge Cc Amt", TypeName = "decimal(13, 4)")]
        public decimal? WeightChargeCcAmt { get; set; }
        [Column("Weight Charge Pp Amt", TypeName = "decimal(13, 4)")]
        public decimal? WeightChargePpAmt { get; set; }
        [Column("Weight Value Flag")]
        [StringLength(1)]
        public string? WeightValueFlag { get; set; }
        [Column("Work Station")]
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
        [Column("Original Branch Code")]
        [StringLength(10)]
        public string? OriginalBranchCode { get; set; }
        [Column("Original Department Code")]
        [StringLength(10)]
        public string? OriginalDepartmentCode { get; set; }
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
