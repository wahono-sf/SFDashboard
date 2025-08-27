using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class AiAwbEntry
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Awb No")]
        [StringLength(20)]
        public string? AwbNo { get; set; }
        [Column("Actual Origin Code1")]
        [StringLength(6)]
        public string? ActualOriginCode1 { get; set; }
        [Column("Actual Origin Code2")]
        [StringLength(6)]
        public string? ActualOriginCode2 { get; set; }
        [Column("Actual Origin Code3")]
        [StringLength(6)]
        public string? ActualOriginCode3 { get; set; }
        [Column("Air Export Flag")]
        [StringLength(1)]
        public string? AirExportFlag { get; set; }
        [Column("Appt Agent Code")]
        [StringLength(10)]
        public string? ApptAgentCode { get; set; }
        [Column("Appt Agent Name")]
        [StringLength(80)]
        public string? ApptAgentName { get; set; }
        [Column("Appt Agent Contact")]
        [StringLength(50)]
        public string? ApptAgentContact { get; set; }
        [Column("Appt Agent Telephone")]
        [StringLength(30)]
        public string? ApptAgentTelephone { get; set; }
        [Column("Airline Code")]
        [StringLength(3)]
        public string? AirlineCode { get; set; }
        [Column("Master Airline Code")]
        [StringLength(3)]
        public string? MasterAirlineCode { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Arrival Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? ArrivalDateTime { get; set; }
        [Column("Available Pcs")]
        public int AvailablePcs { get; set; }
        [Column("Bank Draft Flag")]
        [StringLength(1)]
        public string? BankDraftFlag { get; set; }
        [Column("Bank Draft No")]
        [StringLength(13)]
        public string? BankDraftNo { get; set; }
        [Column("Bank Draft Stamp Flag")]
        [StringLength(1)]
        public string? BankDraftStampFlag { get; set; }
        [Column("Bank Endorse Flag")]
        [StringLength(1)]
        public string? BankEndorseFlag { get; set; }
        [Column("Bank Endorse Stamp Flag")]
        [StringLength(1)]
        public string? BankEndorseStampFlag { get; set; }
        [Column("Billing Instruction")]
        [StringLength(255)]
        public string? BillingInstruction { get; set; }
        [Column("Billing Party 01")]
        [StringLength(10)]
        public string? BillingParty01 { get; set; }
        [Column("Billing Party 02")]
        [StringLength(10)]
        public string? BillingParty02 { get; set; }
        [Column("Bill Mode")]
        [StringLength(2)]
        public string? BillMode { get; set; }
        [Column("Bill To Code")]
        [StringLength(8)]
        public string? BillToCode { get; set; }
        [Column("Break Bulk Agent Code")]
        [StringLength(10)]
        public string? BreakBulkAgentCode { get; set; }
        [Column("Break Bulk Agent Name")]
        [StringLength(80)]
        public string? BreakBulkAgentName { get; set; }
        [Column("Business Party Salesman Code")]
        [StringLength(10)]
        public string? BusinessPartySalesmanCode { get; set; }
        [Column("Buy Rate", TypeName = "decimal(13, 3)")]
        public decimal? BuyRate { get; set; }
        [Column("Buy Total Amt", TypeName = "decimal(13, 2)")]
        public decimal? BuyTotalAmt { get; set; }
        [Column("Buy Total Local Amt", TypeName = "decimal(13, 2)")]
        public decimal? BuyTotalLocalAmt { get; set; }
        [Column("Cargo Class")]
        [StringLength(2)]
        public string? CargoClass { get; set; }
        [Column("Cargo Ready Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? CargoReadyDate { get; set; }
        [Column("Cargo Receipt Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? CargoReceiptDate { get; set; }
        [Column("Carriage Declare Value", TypeName = "decimal(13, 2)")]
        public decimal? CarriageDeclareValue { get; set; }
        [Column("Cash Status Code")]
        [StringLength(8)]
        public string? CashStatusCode { get; set; }
        [Column("Charge Weight", TypeName = "decimal(13, 4)")]
        public decimal? ChargeWeight { get; set; }
        [Column("Collect Flag")]
        [StringLength(1)]
        public string? CollectFlag { get; set; }
        [Column("Commodity Code")]
        [StringLength(10)]
        public string? CommodityCode { get; set; }
        [Column("Commodity Description")]
        [StringLength(50)]
        public string? CommodityDescription { get; set; }
        [Column("Computer Code")]
        [StringLength(3)]
        public string? ComputerCode { get; set; }
        [Column("Consignee Code")]
        [StringLength(10)]
        public string? ConsigneeCode { get; set; }
        [Column("Consignee Name")]
        [StringLength(80)]
        public string? ConsigneeName { get; set; }
        [Column("Consignee Address 1")]
        [StringLength(45)]
        public string? ConsigneeAddress1 { get; set; }
        [Column("Consignee Address 2")]
        [StringLength(45)]
        public string? ConsigneeAddress2 { get; set; }
        [Column("Consignee Address 3")]
        [StringLength(45)]
        public string? ConsigneeAddress3 { get; set; }
        [Column("Consignee Address 4")]
        [StringLength(45)]
        public string? ConsigneeAddress4 { get; set; }
        [Column("Consignee Contact")]
        [StringLength(50)]
        public string? ConsigneeContact { get; set; }
        [Column("Consignee Telephone")]
        [StringLength(30)]
        public string? ConsigneeTelephone { get; set; }
        [Column("Contr Flag")]
        [StringLength(4)]
        public string? ContrFlag { get; set; }
        [Column("Copy Template Name")]
        [StringLength(50)]
        public string? CopyTemplateName { get; set; }
        [Column("Copy Template Remark")]
        [StringLength(255)]
        public string? CopyTemplateRemark { get; set; }
        [Column("Country Code")]
        [StringLength(2)]
        public string? CountryCode { get; set; }
        [Column("Credit Flag")]
        [StringLength(1)]
        public string? CreditFlag { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Curr Rate", TypeName = "decimal(13, 6)")]
        public decimal? CurrRate { get; set; }
        [Column("Custom Bond Clear No")]
        [StringLength(13)]
        public string? CustomBondClearNo { get; set; }
        [Column("Custom Bond Flag")]
        [StringLength(1)]
        public string? CustomBondFlag { get; set; }
        [Column("Custom Bond Receipt No")]
        [StringLength(13)]
        public string? CustomBondReceiptNo { get; set; }
        [Column("Custom Bond Stamp Flag")]
        [StringLength(1)]
        public string? CustomBondStampFlag { get; set; }
        [Column("Custom Declare Value", TypeName = "decimal(13, 2)")]
        public decimal? CustomDeclareValue { get; set; }
        [Column("Customer Code")]
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [Column("Customer Name")]
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [Column("Customer Contact Name")]
        [StringLength(50)]
        public string? CustomerContactName { get; set; }
        [Column("Customer Ref No")]
        [StringLength(50)]
        public string? CustomerRefNo { get; set; }
        [Column("Date Added", TypeName = "datetime")]
        public DateTime? DateAdded { get; set; }
        [Column("Date Changed", TypeName = "datetime")]
        public DateTime? DateChanged { get; set; }
        [Column("Delivery Agent Code")]
        [StringLength(10)]
        public string? DeliveryAgentCode { get; set; }
        [Column("Delivery Agent Name")]
        [StringLength(80)]
        public string? DeliveryAgentName { get; set; }
        [Column("Delivery Order Flag")]
        [StringLength(1)]
        public string? DeliveryOrderFlag { get; set; }
        [Column("Delivery Pcs")]
        public short? DeliveryPcs { get; set; }
        [Column("Delivery Term")]
        [StringLength(5)]
        public string? DeliveryTerm { get; set; }
        [Column("Dest Code")]
        [StringLength(3)]
        public string? DestCode { get; set; }
        [Column("Dest Name")]
        [StringLength(45)]
        public string? DestName { get; set; }
        [Column("Division Code")]
        [StringLength(10)]
        public string? DivisionCode { get; set; }
        [Column("Doc Release Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? DocReleaseDate { get; set; }
        [Column("Document Note Flag")]
        [StringLength(1)]
        public string? DocumentNoteFlag { get; set; }
        [Column("Due Agent Cc Amt", TypeName = "decimal(13, 2)")]
        public decimal? DueAgentCcAmt { get; set; }
        [Column("Due Agent Pp Amt", TypeName = "decimal(13, 2)")]
        public decimal? DueAgentPpAmt { get; set; }
        [Column("Due Carrier Cc Amt", TypeName = "decimal(13, 2)")]
        public decimal? DueCarrierCcAmt { get; set; }
        [Column("Due Carrier Pp Amt", TypeName = "decimal(13, 2)")]
        public decimal? DueCarrierPpAmt { get; set; }
        [Column("Edi Count")]
        public byte? EdiCount { get; set; }
        [Column("Email Count")]
        public byte? EmailCount { get; set; }
        [Column("Enquiry Status")]
        [StringLength(5)]
        public string? EnquiryStatus { get; set; }
        [Column("First Eta Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? FirstEtaDate { get; set; }
        [Column("First Eta Time")]
        [StringLength(5)]
        [Unicode(false)]
        public string? FirstEtaTime { get; set; }
        [Column("Second Eta Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? SecondEtaDate { get; set; }
        [Column("Second Eta Time")]
        [StringLength(5)]
        [Unicode(false)]
        public string? SecondEtaTime { get; set; }
        [Column("Third Eta Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ThirdEtaDate { get; set; }
        [Column("Third Eta Time")]
        [StringLength(5)]
        [Unicode(false)]
        public string? ThirdEtaTime { get; set; }
        [Column("First Etd Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? FirstEtdDate { get; set; }
        [Column("First Etd Time")]
        [StringLength(5)]
        [Unicode(false)]
        public string? FirstEtdTime { get; set; }
        [Column("Second Etd Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? SecondEtdDate { get; set; }
        [Column("Second Etd Time")]
        [StringLength(5)]
        [Unicode(false)]
        public string? SecondEtdTime { get; set; }
        [Column("Third Etd Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ThirdEtdDate { get; set; }
        [Column("Third Etd Time")]
        [StringLength(5)]
        [Unicode(false)]
        public string? ThirdEtdTime { get; set; }
        [Column("Export Booking No")]
        [StringLength(255)]
        public string? ExportBookingNo { get; set; }
        [Column("Export Count")]
        public byte? ExportCount { get; set; }
        [Column("Export Job No")]
        [StringLength(255)]
        public string? ExportJobNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Factor { get; set; }
        [Column("Fax Count")]
        public byte? FaxCount { get; set; }
        [Column("Final Amt", TypeName = "decimal(13, 2)")]
        public decimal? FinalAmt { get; set; }
        [Column("Final Curr Code")]
        [StringLength(3)]
        public string? FinalCurrCode { get; set; }
        [Column("Final Rate", TypeName = "decimal(13, 6)")]
        public decimal? FinalRate { get; set; }
        [Column("First Flight Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? FirstFlightDate { get; set; }
        [Column("First Flight Time")]
        [StringLength(5)]
        [Unicode(false)]
        public string? FirstFlightTime { get; set; }
        [Column("Flight No")]
        [StringLength(12)]
        public string? FlightNo { get; set; }
        [Column("First Flight No")]
        [StringLength(12)]
        public string? FirstFlightNo { get; set; }
        [Column("Second Flight No")]
        [StringLength(12)]
        public string? SecondFlightNo { get; set; }
        [Column("Third Flight No")]
        [StringLength(12)]
        public string? ThirdFlightNo { get; set; }
        [Column("Frt Amt", TypeName = "decimal(13, 2)")]
        public decimal? FrtAmt { get; set; }
        [Column("Generate Ap Flag")]
        [StringLength(1)]
        public string? GenerateApFlag { get; set; }
        [Column("Generate Inv Flag")]
        [StringLength(1)]
        public string? GenerateInvFlag { get; set; }
        [Column("Gross Weight", TypeName = "decimal(13, 4)")]
        public decimal? GrossWeight { get; set; }
        [Column("H Awb No")]
        [StringLength(13)]
        public string? HAwbNo { get; set; }
        [Column("House Job No")]
        [StringLength(20)]
        public string? HouseJobNo { get; set; }
        [Column("Hs Code")]
        [StringLength(9)]
        public string? HsCode { get; set; }
        [Column("Iata Rate", TypeName = "decimal(13, 3)")]
        public decimal? IataRate { get; set; }
        [Column("Iata Total Amt", TypeName = "decimal(13, 2)")]
        public decimal? IataTotalAmt { get; set; }
        [Column("Iata Total Local Amt", TypeName = "decimal(13, 2)")]
        public decimal? IataTotalLocalAmt { get; set; }
        [Column("Insurance Amt", TypeName = "decimal(13, 2)")]
        public decimal? InsuranceAmt { get; set; }
        [Column("Invoice Status Code")]
        [StringLength(8)]
        public string? InvoiceStatusCode { get; set; }
        [Column("Issuer Changed")]
        [StringLength(8)]
        public string? IssuerChanged { get; set; }
        [Column("Issuer Code")]
        [StringLength(8)]
        public string? IssuerCode { get; set; }
        [Column("Job Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? JobDate { get; set; }
        [Column("Job Mth")]
        [StringLength(6)]
        public string? JobMth { get; set; }
        [Column("Job No")]
        [StringLength(20)]
        public string? JobNo { get; set; }
        [Column("Job Seq No 1")]
        [StringLength(1)]
        public string? JobSeqNo1 { get; set; }
        [Column("Job Seq No 2")]
        [StringLength(2)]
        public string? JobSeqNo2 { get; set; }
        [Column("Job Seq No 3")]
        [StringLength(3)]
        public string? JobSeqNo3 { get; set; }
        [Column("Job Seq No 4")]
        [StringLength(4)]
        public string? JobSeqNo4 { get; set; }
        [Column("Job Seq No 5")]
        [StringLength(5)]
        public string? JobSeqNo5 { get; set; }
        [Column("Job Seq No 6")]
        [StringLength(6)]
        public string? JobSeqNo6 { get; set; }
        [Column("Job Seq No 7")]
        [StringLength(7)]
        public string? JobSeqNo7 { get; set; }
        [Column("Job Seq No 8")]
        [StringLength(8)]
        public string? JobSeqNo8 { get; set; }
        [Column("Job Type")]
        [StringLength(2)]
        public string? JobType { get; set; }
        [Column("Kg Lb Flag")]
        [StringLength(1)]
        public string? KgLbFlag { get; set; }
        [Column("Last Seq No")]
        [StringLength(2)]
        public string? LastSeqNo { get; set; }
        [Column("M Awb No")]
        [StringLength(20)]
        public string? MAwbNo { get; set; }
        [Column("Master Job No")]
        [StringLength(20)]
        public string? MasterJobNo { get; set; }
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
        [Column("Notify Address1")]
        [StringLength(45)]
        public string? NotifyAddress1 { get; set; }
        [Column("Notify Address2")]
        [StringLength(45)]
        public string? NotifyAddress2 { get; set; }
        [Column("Notify Address3")]
        [StringLength(45)]
        public string? NotifyAddress3 { get; set; }
        [Column("Notify Address4")]
        [StringLength(45)]
        public string? NotifyAddress4 { get; set; }
        [Column("Origin Awb No")]
        [StringLength(20)]
        public string? OriginAwbNo { get; set; }
        [Column("Origin Code")]
        [StringLength(3)]
        public string? OriginCode { get; set; }
        [Column("Origin Code 1")]
        [StringLength(12)]
        public string? OriginCode1 { get; set; }
        [Column("Origin Code 2")]
        [StringLength(12)]
        public string? OriginCode2 { get; set; }
        [Column("Origin Code 3")]
        [StringLength(12)]
        public string? OriginCode3 { get; set; }
        [Column("Origin MAwb No")]
        [StringLength(20)]
        public string? OriginMawbNo { get; set; }
        [Column("Origin Name")]
        [StringLength(45)]
        public string? OriginName { get; set; }
        [Column("Other Flag")]
        [StringLength(1)]
        public string? OtherFlag { get; set; }
        [Column("Partial No")]
        [StringLength(1)]
        public string? PartialNo { get; set; }
        public int? Pcs { get; set; }
        [Column("Percent Of Profit Share", TypeName = "decimal(6, 3)")]
        public decimal? PercentOfProfitShare { get; set; }
        [Column("Permit Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? PermitDate { get; set; }
        [Column("Permit No")]
        [StringLength(260)]
        public string? PermitNo { get; set; }
        [Column("Post Flag")]
        [StringLength(1)]
        public string? PostFlag { get; set; }
        [Column("Pp Cc Flag 01")]
        [StringLength(1)]
        public string? PpCcFlag01 { get; set; }
        [Column("Pp Cc Flag 02")]
        [StringLength(1)]
        public string? PpCcFlag02 { get; set; }
        [Column("Print Count")]
        public byte? PrintCount { get; set; }
        [Column("Profit Share Flag")]
        [StringLength(1)]
        public string? ProfitShareFlag { get; set; }
        [Column("Profit Share Rate", TypeName = "decimal(13, 3)")]
        public decimal? ProfitShareRate { get; set; }
        [Column("Proof Deliver Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? ProofDeliverDateTime { get; set; }
        [Column("Quote No")]
        [StringLength(15)]
        public string? QuoteNo { get; set; }
        [Column("Rate Class Code")]
        [StringLength(1)]
        public string? RateClassCode { get; set; }
        [Column("Receive Call Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? ReceiveCallDateTime { get; set; }
        [Column("Recipient Name")]
        [StringLength(80)]
        public string? RecipientName { get; set; }
        [Column("Recoverable Amt", TypeName = "decimal(13, 2)")]
        public decimal? RecoverableAmt { get; set; }
        [Column("Rec Status")]
        [StringLength(3)]
        public string? RecStatus { get; set; }
        [Column("Region Code")]
        [StringLength(5)]
        public string? RegionCode { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Sales Amt", TypeName = "decimal(13, 2)")]
        public decimal? SalesAmt { get; set; }
        [Column("Salesman Code")]
        [StringLength(10)]
        public string? SalesmanCode { get; set; }
        [Column("Sea Export Flag")]
        [StringLength(1)]
        public string? SeaExportFlag { get; set; }
        [Column("Sell Rate", TypeName = "decimal(13, 3)")]
        public decimal? SellRate { get; set; }
        [Column("Sell Total Amt", TypeName = "decimal(13, 2)")]
        public decimal? SellTotalAmt { get; set; }
        [Column("Sell Total Local Amt", TypeName = "decimal(13, 2)")]
        public decimal? SellTotalLocalAmt { get; set; }
        [Column("Seq No")]
        [StringLength(2)]
        public string? SeqNo { get; set; }
        [Column("Service Indicator")]
        [StringLength(2)]
        public string? ServiceIndicator { get; set; }
        [Column("Ship Mode")]
        [StringLength(2)]
        public string? ShipMode { get; set; }
        [Column("Shipment Type")]
        [StringLength(1)]
        public string? ShipmentType { get; set; }
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
        [StringLength(45)]
        public string? ShipperAddress1 { get; set; }
        [Column("Shipper Address 2")]
        [StringLength(45)]
        public string? ShipperAddress2 { get; set; }
        [Column("Shipper Address 3")]
        [StringLength(45)]
        public string? ShipperAddress3 { get; set; }
        [Column("Shipper Address 4")]
        [StringLength(45)]
        public string? ShipperAddress4 { get; set; }
        [Column("Short Landed Flag")]
        [StringLength(1)]
        public string? ShortLandedFlag { get; set; }
        [Column("Site Code")]
        [StringLength(20)]
        public string? SiteCode { get; set; }
        [Column("S Mawb No")]
        [StringLength(20)]
        public string? SMawbNo { get; set; }
        [Column("Tax Cc Amt", TypeName = "decimal(13, 2)")]
        public decimal? TaxCcAmt { get; set; }
        [Column("Tax Pp Amt", TypeName = "decimal(13, 2)")]
        public decimal? TaxPpAmt { get; set; }
        [Column("Total Cc Amt", TypeName = "decimal(13, 2)")]
        public decimal? TotalCcAmt { get; set; }
        [Column("Total Local Amt", TypeName = "decimal(13, 2)")]
        public decimal? TotalLocalAmt { get; set; }
        [Column("Total Pcs")]
        public int? TotalPcs { get; set; }
        [Column("Total Pp Amt", TypeName = "decimal(13, 2)")]
        public decimal? TotalPpAmt { get; set; }
        [Column("Transfer Flag")]
        [StringLength(1)]
        public string? TransferFlag { get; set; }
        [Column("Transhipment Flag")]
        [StringLength(1)]
        public string? TranshipmentFlag { get; set; }
        [Column("Transport Company Code")]
        [StringLength(10)]
        public string? TransportCompanyCode { get; set; }
        [Column("Transport Company Name")]
        [StringLength(80)]
        public string? TransportCompanyName { get; set; }
        [Column("Transport Company Address 1")]
        [StringLength(45)]
        public string? TransportCompanyAddress1 { get; set; }
        [Column("Transport Company Address 2")]
        [StringLength(45)]
        public string? TransportCompanyAddress2 { get; set; }
        [Column("Transport Company Address 3")]
        [StringLength(45)]
        public string? TransportCompanyAddress3 { get; set; }
        [Column("Transport Company Address 4")]
        [StringLength(45)]
        public string? TransportCompanyAddress4 { get; set; }
        [Column("Trk Receipt Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? TrkReceiptDate { get; set; }
        [Column("Ul Flag")]
        [StringLength(1)]
        public string? UlFlag { get; set; }
        [Column("Uom Code")]
        [StringLength(3)]
        public string? UomCode { get; set; }
        [Column("User Define 01")]
        [StringLength(50)]
        public string? UserDefine01 { get; set; }
        [Column("User Define 02")]
        [StringLength(50)]
        public string? UserDefine02 { get; set; }
        [Column("User Define 03")]
        [StringLength(50)]
        public string? UserDefine03 { get; set; }
        [Column("User Define 04")]
        [StringLength(50)]
        public string? UserDefine04 { get; set; }
        [Column("User Define 05")]
        [StringLength(50)]
        public string? UserDefine05 { get; set; }
        [Column("User Define 06")]
        [StringLength(50)]
        public string? UserDefine06 { get; set; }
        [Column("User Define 07")]
        [StringLength(50)]
        public string? UserDefine07 { get; set; }
        [Column("User Define 08")]
        [StringLength(50)]
        public string? UserDefine08 { get; set; }
        [Column("User Define 09")]
        [StringLength(50)]
        public string? UserDefine09 { get; set; }
        [Column("User Define 10")]
        [StringLength(50)]
        public string? UserDefine10 { get; set; }
        [Column("User Define 11")]
        [StringLength(50)]
        public string? UserDefine11 { get; set; }
        [Column("User Define 12")]
        [StringLength(50)]
        public string? UserDefine12 { get; set; }
        [Column("User Define 13")]
        [StringLength(50)]
        public string? UserDefine13 { get; set; }
        [Column("User Define 14")]
        [StringLength(50)]
        public string? UserDefine14 { get; set; }
        [Column("User Define 15")]
        [StringLength(50)]
        public string? UserDefine15 { get; set; }
        [Column("User Define 16")]
        [StringLength(50)]
        public string? UserDefine16 { get; set; }
        [Column("User Define 17")]
        [StringLength(50)]
        public string? UserDefine17 { get; set; }
        [Column("User Define 18")]
        [StringLength(50)]
        public string? UserDefine18 { get; set; }
        [Column("User Define 19")]
        [StringLength(50)]
        public string? UserDefine19 { get; set; }
        [Column("User Define 20")]
        [StringLength(50)]
        public string? UserDefine20 { get; set; }
        [Column("Value Charge Cc Amt", TypeName = "decimal(13, 2)")]
        public decimal? ValueChargeCcAmt { get; set; }
        [Column("Value Charge Pp Amt", TypeName = "decimal(13, 2)")]
        public decimal? ValueChargePpAmt { get; set; }
        [Column("Via Agent Code")]
        [StringLength(10)]
        public string? ViaAgentCode { get; set; }
        [Column("Via Agent Name")]
        [StringLength(80)]
        public string? ViaAgentName { get; set; }
        [Column("Volumetric Weight", TypeName = "decimal(12, 4)")]
        public decimal? VolumetricWeight { get; set; }
        [Column("Weight Charge C C Amt", TypeName = "decimal(13, 2)")]
        public decimal? WeightChargeCCAmt { get; set; }
        [Column("Weight Charge P P Amt", TypeName = "decimal(13, 2)")]
        public decimal? WeightChargePPAmt { get; set; }
        [Column("Weight Value Flag")]
        [StringLength(1)]
        public string? WeightValueFlag { get; set; }
        [Column("Work Station")]
        [StringLength(50)]
        public string? WorkStation { get; set; }
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
