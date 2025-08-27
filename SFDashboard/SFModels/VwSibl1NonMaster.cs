using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSibl1NonMaster
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Agent Cc Amt", TypeName = "decimal(13, 2)")]
        public decimal? AgentCcAmt { get; set; }
        [Column("Agent Code")]
        [StringLength(10)]
        public string? AgentCode { get; set; }
        [Column("Agent Pp Amt", TypeName = "decimal(13, 2)")]
        public decimal? AgentPpAmt { get; set; }
        [Column("Air Export Flag")]
        [StringLength(1)]
        public string? AirExportFlag { get; set; }
        [Column("Also Notify Code")]
        [StringLength(10)]
        public string? AlsoNotifyCode { get; set; }
        [Column("Also Notify Name")]
        [StringLength(80)]
        public string? AlsoNotifyName { get; set; }
        [Column("Also Notify Acct Code")]
        [StringLength(15)]
        public string? AlsoNotifyAcctCode { get; set; }
        [Column("Also Notify Address 1")]
        [StringLength(50)]
        public string? AlsoNotifyAddress1 { get; set; }
        [Column("Also Notify Address 2")]
        [StringLength(50)]
        public string? AlsoNotifyAddress2 { get; set; }
        [Column("Also Notify Address 3")]
        [StringLength(50)]
        public string? AlsoNotifyAddress3 { get; set; }
        [Column("Also Notify Address 4")]
        [StringLength(50)]
        public string? AlsoNotifyAddress4 { get; set; }
        [Column("Alternate Bl No")]
        [StringLength(30)]
        public string? AlternateBlNo { get; set; }
        [Column("Appoint Agent Code")]
        [StringLength(10)]
        public string? AppointAgentCode { get; set; }
        [Column("Appoint Agent Name")]
        [StringLength(80)]
        public string? AppointAgentName { get; set; }
        [Column("Appoint Agent Address 1")]
        [StringLength(50)]
        public string? AppointAgentAddress1 { get; set; }
        [Column("Appoint Agent Address 2")]
        [StringLength(50)]
        public string? AppointAgentAddress2 { get; set; }
        [Column("Appoint Agent Address 3")]
        [StringLength(50)]
        public string? AppointAgentAddress3 { get; set; }
        [Column("Appoint Agent Address 4")]
        [StringLength(50)]
        public string? AppointAgentAddress4 { get; set; }
        [Column("Appoint Agent Contact Name")]
        [StringLength(50)]
        public string? AppointAgentContactName { get; set; }
        [Column("Appoint Agent Fax")]
        [StringLength(30)]
        public string? AppointAgentFax { get; set; }
        [Column("Appoint Agent Telephone")]
        [StringLength(30)]
        public string? AppointAgentTelephone { get; set; }
        [Column("Arrival Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? ArrivalDateTime { get; set; }
        [Column("Arrival Notice By")]
        [StringLength(50)]
        public string? ArrivalNoticeBy { get; set; }
        [Column("Arrival Notice Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? ArrivalNoticeDateTime { get; set; }
        [Column("ATA Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? AtaDate { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Bar Code")]
        [StringLength(50)]
        public string? BarCode { get; set; }
        [Column("Billing Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? BillingDate { get; set; }
        [Column("Billing Instruction")]
        [StringLength(255)]
        public string? BillingInstruction { get; set; }
        [Column("Bill Mode")]
        [StringLength(2)]
        public string? BillMode { get; set; }
        [Column("Bill To Code")]
        [StringLength(8)]
        public string? BillToCode { get; set; }
        [Column("Bl Issue Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? BlIssueDate { get; set; }
        [Column("Bl Issue Place")]
        [StringLength(45)]
        public string? BlIssuePlace { get; set; }
        [Column("Bl No")]
        [StringLength(30)]
        public string BlNo { get; set; } = null!;
        [Column("Bl Type")]
        [StringLength(10)]
        public string? BlType { get; set; }
        [Column("Break Bulk Agent Code")]
        [StringLength(10)]
        public string? BreakBulkAgentCode { get; set; }
        [Column("Break Bulk Agent Name")]
        [StringLength(80)]
        public string? BreakBulkAgentName { get; set; }
        [Column("Break Bulk Agent Address 1")]
        [StringLength(50)]
        public string? BreakBulkAgentAddress1 { get; set; }
        [Column("Break Bulk Agent Address 2")]
        [StringLength(50)]
        public string? BreakBulkAgentAddress2 { get; set; }
        [Column("Break Bulk Agent Address 3")]
        [StringLength(50)]
        public string? BreakBulkAgentAddress3 { get; set; }
        [Column("Break Bulk Agent Address 4")]
        [StringLength(50)]
        public string? BreakBulkAgentAddress4 { get; set; }
        [Column("Break Bulk Agent Contact Name")]
        [StringLength(50)]
        public string? BreakBulkAgentContactName { get; set; }
        [Column("By Whom")]
        [StringLength(50)]
        public string? ByWhom { get; set; }
        [Column("Cargo Class")]
        [StringLength(10)]
        public string? CargoClass { get; set; }
        [Column("Cargo Collection Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? CargoCollectionDate { get; set; }
        [Column("Cargo Location")]
        [StringLength(255)]
        public string? CargoLocation { get; set; }
        [Column("Cargo Rcv Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? CargoRcvDate { get; set; }
        [Column("Cargo Ready Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? CargoReadyDate { get; set; }
        [Column("Cargo Receipt Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? CargoReceiptDate { get; set; }
        [Column("Cargo Receipt Flag")]
        [StringLength(1)]
        public string? CargoReceiptFlag { get; set; }
        [Column("Cargo Type")]
        [StringLength(5)]
        public string? CargoType { get; set; }
        [Column("Car Model")]
        [StringLength(100)]
        public string? CarModel { get; set; }
        [Column("Carrier Booking Ref")]
        [StringLength(50)]
        public string? CarrierBookingRef { get; set; }
        [Column("Carrier Cc Amt", TypeName = "decimal(13, 2)")]
        public decimal? CarrierCcAmt { get; set; }
        [Column("Carrier Pp Amt", TypeName = "decimal(13, 2)")]
        public decimal? CarrierPpAmt { get; set; }
        [Column("CFS Charge Instruction")]
        [StringLength(255)]
        public string? CfsChargeInstruction { get; set; }
        [Column("CFS Update By")]
        [StringLength(50)]
        public string? CfsUpdateBy { get; set; }
        [Column("CFS Update Date Time")]
        [StringLength(10)]
        [Unicode(false)]
        public string? CfsUpdateDateTime { get; set; }
        [Column("Charge Collect Amt", TypeName = "decimal(13, 2)")]
        public decimal? ChargeCollectAmt { get; set; }
        [Column("Charge Collect Remark")]
        [StringLength(80)]
        public string? ChargeCollectRemark { get; set; }
        [Column("Chassis No")]
        [StringLength(200)]
        public string? ChassisNo { get; set; }
        [Column("Cleared By")]
        [StringLength(50)]
        public string? ClearedBy { get; set; }
        [Column("Cleared On")]
        [StringLength(16)]
        [Unicode(false)]
        public string? ClearedOn { get; set; }
        [Column("Clearing Remark")]
        [StringLength(255)]
        public string? ClearingRemark { get; set; }
        [Column("Client Code")]
        [StringLength(8)]
        public string? ClientCode { get; set; }
        [Column("Collect Cash Amt", TypeName = "decimal(13, 2)")]
        public decimal? CollectCashAmt { get; set; }
        [Column("Collect Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CollectDateTime { get; set; }
        [Column("Collect From Code")]
        [StringLength(10)]
        public string? CollectFromCode { get; set; }
        [Column("Collect From Name")]
        [StringLength(80)]
        public string? CollectFromName { get; set; }
        [Column("Collect From Address 1")]
        [StringLength(50)]
        public string? CollectFromAddress1 { get; set; }
        [Column("Collect From Address 2")]
        [StringLength(50)]
        public string? CollectFromAddress2 { get; set; }
        [Column("Collect From Address 3")]
        [StringLength(50)]
        public string? CollectFromAddress3 { get; set; }
        [Column("Collect From Address 4")]
        [StringLength(50)]
        public string? CollectFromAddress4 { get; set; }
        [Column("Collect From Contact Name")]
        [StringLength(50)]
        public string? CollectFromContactName { get; set; }
        [Column("Collection From Place")]
        [StringLength(10)]
        public string? CollectionFromPlace { get; set; }
        [Column("Coloader Code")]
        [StringLength(10)]
        public string? ColoaderCode { get; set; }
        [Column("Coloader Name")]
        [StringLength(80)]
        public string? ColoaderName { get; set; }
        [Column("Coloader Ref No")]
        [StringLength(20)]
        public string? ColoaderRefNo { get; set; }
        [Column("Commodity Code")]
        [StringLength(50)]
        public string? CommodityCode { get; set; }
        [Column("Commodity Description")]
        [StringLength(50)]
        public string? CommodityDescription { get; set; }
        [Column("Commodity Description 01")]
        [StringLength(255)]
        public string? CommodityDescription01 { get; set; }
        [Column("Consignee Code")]
        [StringLength(10)]
        public string? ConsigneeCode { get; set; }
        [Column("Consignee Name")]
        [StringLength(80)]
        public string? ConsigneeName { get; set; }
        [Column("Consignee Acc Code")]
        [StringLength(16)]
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
        [Column("Consignee Contact")]
        [StringLength(50)]
        public string? ConsigneeContact { get; set; }
        [Column("Consignee Postal Code")]
        [StringLength(10)]
        public string? ConsigneePostalCode { get; set; }
        [Column("Consignee Telephone")]
        [StringLength(30)]
        public string? ConsigneeTelephone { get; set; }
        [Column("Container Deposit Amt", TypeName = "decimal(13, 2)")]
        public decimal? ContainerDepositAmt { get; set; }
        [Column("Container No")]
        [StringLength(1000)]
        public string? ContainerNo { get; set; }
        [Column("Container No Type")]
        [StringLength(2000)]
        public string? ContainerNoType { get; set; }
        [Column("Container Seal No")]
        [StringLength(2000)]
        public string? ContainerSealNo { get; set; }
        [Column("Container Seal No Type")]
        [StringLength(2000)]
        public string? ContainerSealNoType { get; set; }
        [Column("Contr Flag")]
        [StringLength(4)]
        public string? ContrFlag { get; set; }
        [Column("Copy Template Name")]
        [StringLength(50)]
        public string? CopyTemplateName { get; set; }
        [Column("Copy Template Remark")]
        [StringLength(255)]
        public string? CopyTemplateRemark { get; set; }
        [Column("Cr No")]
        [StringLength(15)]
        public string? CrNo { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [Column("Custome Declare Value", TypeName = "decimal(13, 2)")]
        public decimal? CustomeDeclareValue { get; set; }
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
        [Column("Delivery Agent Code")]
        [StringLength(10)]
        public string? DeliveryAgentCode { get; set; }
        [Column("Delivery Agent Name")]
        [StringLength(80)]
        public string? DeliveryAgentName { get; set; }
        [Column("Delivery Agent Address 1")]
        [StringLength(50)]
        public string? DeliveryAgentAddress1 { get; set; }
        [Column("Delivery Agent Address 2")]
        [StringLength(50)]
        public string? DeliveryAgentAddress2 { get; set; }
        [Column("Delivery Agent Address 3")]
        [StringLength(50)]
        public string? DeliveryAgentAddress3 { get; set; }
        [Column("Delivery Agent Address 4")]
        [StringLength(50)]
        public string? DeliveryAgentAddress4 { get; set; }
        [Column("Delivery Date")]
        [StringLength(16)]
        [Unicode(false)]
        public string? DeliveryDate { get; set; }
        [Column("Delivery Instruction 1")]
        [StringLength(60)]
        public string? DeliveryInstruction1 { get; set; }
        [Column("Delivery Instruction 2")]
        [StringLength(60)]
        public string? DeliveryInstruction2 { get; set; }
        [Column("Delivery Instruction 3")]
        [StringLength(60)]
        public string? DeliveryInstruction3 { get; set; }
        [Column("Delivery Instruction 4")]
        [StringLength(60)]
        public string? DeliveryInstruction4 { get; set; }
        [Column("Delivery Instruction 5")]
        [StringLength(60)]
        public string? DeliveryInstruction5 { get; set; }
        [Column("Delivery Instruction 6")]
        [StringLength(60)]
        public string? DeliveryInstruction6 { get; set; }
        [Column("Delivery Instruction 7")]
        [StringLength(60)]
        public string? DeliveryInstruction7 { get; set; }
        [Column("Delivery Instruction 8")]
        [StringLength(60)]
        public string? DeliveryInstruction8 { get; set; }
        [Column("Delivery Instruction Template Name")]
        [StringLength(50)]
        public string? DeliveryInstructionTemplateName { get; set; }
        [Column("Delivery No")]
        [StringLength(10)]
        public string? DeliveryNo { get; set; }
        [Column("Delivery Order No")]
        [StringLength(20)]
        public string? DeliveryOrderNo { get; set; }
        [Column("Delivery Order Ready Flag")]
        [StringLength(1)]
        public string? DeliveryOrderReadyFlag { get; set; }
        [Column("Delivery Order Ready Remark")]
        [StringLength(50)]
        public string? DeliveryOrderReadyRemark { get; set; }
        [Column("Delivery Order Release Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? DeliveryOrderReleaseDate { get; set; }
        [Column("Delivery Order Release To")]
        [StringLength(80)]
        public string? DeliveryOrderReleaseTo { get; set; }
        [Column("Delivery Pcs")]
        public int? DeliveryPcs { get; set; }
        [Column("Delivery Template Name")]
        [StringLength(80)]
        public string? DeliveryTemplateName { get; set; }
        [Column("Delivery To Code")]
        [StringLength(10)]
        public string? DeliveryToCode { get; set; }
        [Column("Delivery To Name")]
        [StringLength(80)]
        public string? DeliveryToName { get; set; }
        [Column("Delivery To Address 1")]
        [StringLength(50)]
        public string? DeliveryToAddress1 { get; set; }
        [Column("Delivery To Address 2")]
        [StringLength(50)]
        public string? DeliveryToAddress2 { get; set; }
        [Column("Delivery To Address 3")]
        [StringLength(50)]
        public string? DeliveryToAddress3 { get; set; }
        [Column("Delivery To Address 4")]
        [StringLength(50)]
        public string? DeliveryToAddress4 { get; set; }
        [Column("Delivery To Contact Name")]
        [StringLength(50)]
        public string? DeliveryToContactName { get; set; }
        [Column("Delivery Type")]
        [StringLength(5)]
        public string? DeliveryType { get; set; }
        [Column("Demurrage Free Day")]
        public int? DemurrageFreeDay { get; set; }
        [Column("Depot Code")]
        [StringLength(10)]
        public string? DepotCode { get; set; }
        [Column("Depot Name")]
        [StringLength(80)]
        public string? DepotName { get; set; }
        [Column("Depot Address 1")]
        [StringLength(50)]
        public string? DepotAddress1 { get; set; }
        [Column("Depot Address 2")]
        [StringLength(50)]
        public string? DepotAddress2 { get; set; }
        [Column("Depot Address 3")]
        [StringLength(50)]
        public string? DepotAddress3 { get; set; }
        [Column("Depot Address 4")]
        [StringLength(50)]
        public string? DepotAddress4 { get; set; }
        [Column("Depot Instruction 1")]
        [StringLength(60)]
        public string? DepotInstruction1 { get; set; }
        [Column("Depot Instruction 2")]
        [StringLength(60)]
        public string? DepotInstruction2 { get; set; }
        [Column("Depot Instruction 3")]
        [StringLength(60)]
        public string? DepotInstruction3 { get; set; }
        [Column("Depot Instruction 4")]
        [StringLength(60)]
        public string? DepotInstruction4 { get; set; }
        [Column("Descrepancy Description")]
        [StringLength(100)]
        public string? DescrepancyDescription { get; set; }
        [Column("Dest Cargo Type")]
        [StringLength(5)]
        public string? DestCargoType { get; set; }
        [Column("Dest Code")]
        [StringLength(3)]
        public string? DestCode { get; set; }
        [Column("Dest Name")]
        [StringLength(45)]
        public string? DestName { get; set; }
        [Column("Dest Eta")]
        [StringLength(10)]
        [Unicode(false)]
        public string? DestEta { get; set; }
        [Column("Detention Free Day")]
        public int? DetentionFreeDay { get; set; }
        [Column("Dg Flag")]
        [StringLength(1)]
        public string? DgFlag { get; set; }
        [Column("Division Code")]
        [StringLength(10)]
        public string? DivisionCode { get; set; }
        [Column("Doc Rcv Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? DocRcvDate { get; set; }
        [Column("Doc Ref No")]
        [StringLength(20)]
        public string? DocRefNo { get; set; }
        [Column("Doc Remark")]
        [StringLength(255)]
        public string? DocRemark { get; set; }
        [Column("Driver Code")]
        [StringLength(15)]
        public string? DriverCode { get; set; }
        [Column("Driver Name")]
        [StringLength(50)]
        public string? DriverName { get; set; }
        [Column("Driver Contact No 1")]
        [StringLength(30)]
        public string? DriverContactNo1 { get; set; }
        [Column("Driver Contact No 2")]
        [StringLength(30)]
        public string? DriverContactNo2 { get; set; }
        [Column("Driver 2 Code")]
        [StringLength(15)]
        public string? Driver2Code { get; set; }
        [Column("Driver 2 Name")]
        [StringLength(50)]
        public string? Driver2Name { get; set; }
        [Column("Driver 2 Contact No 1")]
        [StringLength(30)]
        public string? Driver2ContactNo1 { get; set; }
        [Column("Driver 2 Contact No 2")]
        [StringLength(30)]
        public string? Driver2ContactNo2 { get; set; }
        [Column("EDI Count")]
        public byte? EdiCount { get; set; }
        [Column("Email Count")]
        public byte? EmailCount { get; set; }
        [Column("Empty Container Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? EmptyContainerDateTime { get; set; }
        [Column("Eta Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? EtaDate { get; set; }
        [Column("Etd Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? EtdDate { get; set; }
        [Column("Export Booking No")]
        [StringLength(30)]
        public string? ExportBookingNo { get; set; }
        [Column("Export Coloader Code")]
        [StringLength(10)]
        public string? ExportColoaderCode { get; set; }
        [Column("Export Coloader Name")]
        [StringLength(80)]
        public string? ExportColoaderName { get; set; }
        [Column("Export Coloader Ref No")]
        [StringLength(20)]
        public string? ExportColoaderRefNo { get; set; }
        [Column("Export Count")]
        public byte? ExportCount { get; set; }
        [Column("Export Etd")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ExportEtd { get; set; }
        [Column("Export Eta")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ExportEta { get; set; }
        [Column("Export Job No")]
        [StringLength(30)]
        public string? ExportJobNo { get; set; }
        [Column("Export Note")]
        [StringLength(255)]
        public string? ExportNote { get; set; }
        [Column("Export Port Of Discharge Code")]
        [StringLength(5)]
        public string? ExportPortOfDischargeCode { get; set; }
        [Column("Export Vessel Code")]
        [StringLength(50)]
        public string? ExportVesselCode { get; set; }
        [Column("Export Vessel Name")]
        [StringLength(80)]
        public string? ExportVesselName { get; set; }
        [Column("Export Voyage")]
        [StringLength(20)]
        public string? ExportVoyage { get; set; }
        [Column("Fax Count")]
        public byte? FaxCount { get; set; }
        [Column("Feeder Vessel Name")]
        [StringLength(50)]
        public string? FeederVesselName { get; set; }
        [Column("Feeder Voyage")]
        [StringLength(20)]
        public string? FeederVoyage { get; set; }
        [Column("Fifth Via Port Code")]
        [StringLength(5)]
        public string? FifthViaPortCode { get; set; }
        [Column("First Via Port Code")]
        [StringLength(5)]
        public string? FirstViaPortCode { get; set; }
        [Column("First Via Eta Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? FirstViaEtaDate { get; set; }
        [Column("First Via Etd Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? FirstViaEtdDate { get; set; }
        [Column("First Via Shipping Line Code")]
        [StringLength(12)]
        public string? FirstViaShippingLineCode { get; set; }
        [Column("First Via Vessel Code")]
        [StringLength(50)]
        public string? FirstViaVesselCode { get; set; }
        [Column("First Via Vessel Name")]
        [StringLength(50)]
        public string? FirstViaVesselName { get; set; }
        [Column("Flash Point")]
        [StringLength(20)]
        public string? FlashPoint { get; set; }
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
        [Column("Footer Template Name")]
        [StringLength(50)]
        public string? FooterTemplateName { get; set; }
        [Column("Fourth Via Port Code")]
        [StringLength(5)]
        public string? FourthViaPortCode { get; set; }
        [Column("Frt Bill Party Code")]
        [StringLength(10)]
        public string? FrtBillPartyCode { get; set; }
        [Column("Frt Pp Cc Flag")]
        [StringLength(1)]
        public string? FrtPpCcFlag { get; set; }
        [Column("Haulier Remark")]
        [StringLength(255)]
        public string? HaulierRemark { get; set; }
        [Column("H Bl No")]
        [StringLength(30)]
        public string? HBlNo { get; set; }
        [Column("House Job No")]
        [StringLength(30)]
        public string? HouseJobNo { get; set; }
        [StringLength(20)]
        public string? Imco { get; set; }
        [Column("Import Curr Code")]
        [StringLength(3)]
        public string? ImportCurrCode { get; set; }
        [Column("Import Rate", TypeName = "decimal(13, 2)")]
        public decimal? ImportRate { get; set; }
        [Column("Instruction 1")]
        [StringLength(80)]
        public string? Instruction1 { get; set; }
        [Column("Instruction 2")]
        [StringLength(80)]
        public string? Instruction2 { get; set; }
        [Column("Instruction 3")]
        [StringLength(80)]
        public string? Instruction3 { get; set; }
        [Column("Instruction 4")]
        [StringLength(80)]
        public string? Instruction4 { get; set; }
        [Column("Instruction Template Name")]
        [StringLength(50)]
        public string? InstructionTemplateName { get; set; }
        [Column("Insurance Amt", TypeName = "decimal(13, 2)")]
        public decimal? InsuranceAmt { get; set; }
        [Column("Issue By")]
        [StringLength(50)]
        public string? IssueBy { get; set; }
        [Column("Job Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? JobDate { get; set; }
        [Column("Job Mth")]
        [StringLength(6)]
        public string? JobMth { get; set; }
        [Column("Job No")]
        [StringLength(30)]
        public string? JobNo { get; set; }
        [Column("Job Type")]
        [StringLength(10)]
        public string? JobType { get; set; }
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
        [Column("Job Seq No 9")]
        [StringLength(9)]
        public string? JobSeqNo9 { get; set; }
        [Column("Job Seq No10")]
        [StringLength(10)]
        public string? JobSeqNo10 { get; set; }
        [Column("Laden Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LadenDate { get; set; }
        [Column("Letter Of Credit No")]
        [StringLength(50)]
        public string? LetterOfCreditNo { get; set; }
        [StringLength(50)]
        public string? Marking { get; set; }
        [Column("Master Gross Weight", TypeName = "decimal(13, 4)")]
        public decimal? MasterGrossWeight { get; set; }
        [Column("Master Job No")]
        [StringLength(30)]
        public string? MasterJobNo { get; set; }
        [Column("Master Pcs")]
        public int? MasterPcs { get; set; }
        [Column("Master Volume", TypeName = "decimal(13, 4)")]
        public decimal? MasterVolume { get; set; }
        [Column("Mother Vessel Name")]
        [StringLength(50)]
        public string? MotherVesselName { get; set; }
        [Column("Mother Voyage")]
        [StringLength(20)]
        public string? MotherVoyage { get; set; }
        [Column("NBl No")]
        [StringLength(30)]
        public string? NblNo { get; set; }
        [Column("Nomination Customer Code")]
        [StringLength(10)]
        public string? NominationCustomerCode { get; set; }
        [Column("Nomination Flag")]
        [StringLength(1)]
        public string? NominationFlag { get; set; }
        [Column("Nomination Remark")]
        [StringLength(50)]
        public string? NominationRemark { get; set; }
        [Column("No Of 20ft Container")]
        public int? NoOf20ftContainer { get; set; }
        [Column("No Of 40ft Container")]
        public int? NoOf40ftContainer { get; set; }
        [Column("No Of 45ft Container")]
        public int? NoOf45ftContainer { get; set; }
        [Column("No Of Origin Bl")]
        public byte? NoOfOriginBl { get; set; }
        [StringLength(2000)]
        public string? Note { get; set; }
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
        [Column("NVOCC Code")]
        [StringLength(10)]
        public string? NvoccCode { get; set; }
        [Column("O Bl No")]
        [StringLength(30)]
        public string? OBlNo { get; set; }
        [Column("Origin Bl No")]
        [StringLength(30)]
        public string? OriginBlNo { get; set; }
        [Column("Origin Code")]
        [StringLength(3)]
        public string? OriginCode { get; set; }
        [Column("Origin Name")]
        [StringLength(45)]
        public string? OriginName { get; set; }
        [Column("Other Bill Party Code")]
        [StringLength(10)]
        public string? OtherBillPartyCode { get; set; }
        [Column("Other Pp Cc Flag")]
        [StringLength(1)]
        public string? OtherPpCcFlag { get; set; }
        [Column("Payable Amt")]
        [StringLength(45)]
        public string? PayableAmt { get; set; }
        [Column("Permit Flag")]
        [StringLength(1)]
        public string? PermitFlag { get; set; }
        [Column("Permit No")]
        [StringLength(260)]
        public string? PermitNo { get; set; }
        [StringLength(20)]
        public string? PhoneNo { get; set; }
        [StringLength(10)]
        public string? Place { get; set; }
        [Column("Place Of Delivery")]
        [StringLength(45)]
        public string? PlaceOfDelivery { get; set; }
        [Column("Place Of Receipt")]
        [StringLength(45)]
        public string? PlaceOfReceipt { get; set; }
        [Column("Port Of Discharge Code")]
        [StringLength(5)]
        public string? PortOfDischargeCode { get; set; }
        [Column("Port Of Discharge Name")]
        [StringLength(45)]
        public string? PortOfDischargeName { get; set; }
        [Column("Port Of Loading Code")]
        [StringLength(5)]
        public string? PortOfLoadingCode { get; set; }
        [Column("Port Of Loading Name")]
        [StringLength(45)]
        public string? PortOfLoadingName { get; set; }
        [Column("Pp At")]
        [StringLength(45)]
        public string? PpAt { get; set; }
        [Column("Principle Agent Code")]
        [StringLength(12)]
        public string? PrincipleAgentCode { get; set; }
        [Column("Print Count")]
        public byte? PrintCount { get; set; }
        [StringLength(80)]
        public string? Psn { get; set; }
        [Column("Quotation No")]
        [StringLength(15)]
        public string? QuotationNo { get; set; }
        [Column("Rate Group")]
        [StringLength(20)]
        public string? RateGroup { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Rebate { get; set; }
        [Column("Rebate Flag")]
        [StringLength(1)]
        public string? RebateFlag { get; set; }
        [Column("Rebate Per Shipment", TypeName = "decimal(13, 2)")]
        public decimal? RebatePerShipment { get; set; }
        [Column("Receipt Gross Weight", TypeName = "decimal(13, 4)")]
        public decimal? ReceiptGrossWeight { get; set; }
        [Column("Receipt Pcs")]
        public int? ReceiptPcs { get; set; }
        [Column("Receipt Volume", TypeName = "decimal(13, 4)")]
        public decimal? ReceiptVolume { get; set; }
        [Column("Rec Status")]
        [StringLength(5)]
        public string? RecStatus { get; set; }
        [StringLength(1000)]
        public string? Remark { get; set; }
        [Column("Sales Coordinator 1")]
        [StringLength(20)]
        public string? SalesCoordinator1 { get; set; }
        [Column("Sales Coordinator 2")]
        [StringLength(20)]
        public string? SalesCoordinator2 { get; set; }
        [Column("Sales Description 1")]
        [StringLength(80)]
        public string? SalesDescription1 { get; set; }
        [Column("Sales Description 2")]
        [StringLength(80)]
        public string? SalesDescription2 { get; set; }
        [Column("Salesman Code")]
        [StringLength(10)]
        public string? SalesmanCode { get; set; }
        [Column("S Bl No")]
        [StringLength(30)]
        public string? SBlNo { get; set; }
        [Column("Scn Code")]
        [StringLength(10)]
        public string? ScnCode { get; set; }
        [Column("Sea Export Flag")]
        [StringLength(1)]
        public string? SeaExportFlag { get; set; }
        [Column("Second Via Port Code")]
        [StringLength(5)]
        public string? SecondViaPortCode { get; set; }
        [Column("Service Level")]
        [StringLength(10)]
        public string? ServiceLevel { get; set; }
        [Column("Ship Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ShipDate { get; set; }
        [Column("Shipment ID")]
        [StringLength(16)]
        public string? ShipmentId { get; set; }
        [Column("Shipment Type")]
        [StringLength(1)]
        public string? ShipmentType { get; set; }
        [Column("Ship Mode")]
        [StringLength(50)]
        public string? ShipMode { get; set; }
        [Column("Shipper Code")]
        [StringLength(10)]
        public string? ShipperCode { get; set; }
        [Column("Shipper Name")]
        [StringLength(80)]
        public string? ShipperName { get; set; }
        [Column("Shipper Acc Code")]
        [StringLength(16)]
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
        [Column("Shippingline Code")]
        [StringLength(12)]
        public string? ShippinglineCode { get; set; }
        [Column("Carrier Name")]
        [StringLength(80)]
        public string? CarrierName { get; set; }
        [Column("Site Code")]
        [StringLength(20)]
        public string? SiteCode { get; set; }
        [Column("Smk Ship Agent Code")]
        [StringLength(12)]
        public string? SmkShipAgentCode { get; set; }
        [Column("Source Company Code")]
        [StringLength(5)]
        public string? SourceCompanyCode { get; set; }
        [Column("Source Create By")]
        [StringLength(50)]
        public string? SourceCreateBy { get; set; }
        [Column("Source Job Create By")]
        [StringLength(50)]
        public string? SourceJobCreateBy { get; set; }
        [Column("Source Job No")]
        [StringLength(30)]
        public string? SourceJobNo { get; set; }
        [Column("Source Job Trx No")]
        public int? SourceJobTrxNo { get; set; }
        [Column("Source Site Code")]
        [StringLength(20)]
        public string? SourceSiteCode { get; set; }
        [Column("Sub Master Flag")]
        [StringLength(1)]
        public string? SubMasterFlag { get; set; }
        [Column("Supplier Curr Code")]
        [StringLength(3)]
        public string? SupplierCurrCode { get; set; }
        [Column("Switch Bl Issue Date")]
        [StringLength(16)]
        [Unicode(false)]
        public string? SwitchBlIssueDate { get; set; }
        [Column("Switch Bl Issue Place")]
        [StringLength(45)]
        public string? SwitchBlIssuePlace { get; set; }
        [Column("Switch Consignee Code")]
        [StringLength(10)]
        public string? SwitchConsigneeCode { get; set; }
        [Column("Switch Consignee Name")]
        [StringLength(80)]
        public string? SwitchConsigneeName { get; set; }
        [Column("Switch Consignee Address 1")]
        [StringLength(50)]
        public string? SwitchConsigneeAddress1 { get; set; }
        [Column("Switch Consignee Address 2")]
        [StringLength(50)]
        public string? SwitchConsigneeAddress2 { get; set; }
        [Column("Switch Consignee Address 3")]
        [StringLength(50)]
        public string? SwitchConsigneeAddress3 { get; set; }
        [Column("Switch Consignee Address 4")]
        [StringLength(50)]
        public string? SwitchConsigneeAddress4 { get; set; }
        [Column("Switch Delivery Agent Code")]
        [StringLength(10)]
        public string? SwitchDeliveryAgentCode { get; set; }
        [Column("Switch Delivery Agent Name")]
        [StringLength(80)]
        public string? SwitchDeliveryAgentName { get; set; }
        [Column("Switch Delivery Agent Address 1")]
        [StringLength(50)]
        public string? SwitchDeliveryAgentAddress1 { get; set; }
        [Column("Switch Delivery Agent Address 2")]
        [StringLength(50)]
        public string? SwitchDeliveryAgentAddress2 { get; set; }
        [Column("Switch Delivery Agent Address 3")]
        [StringLength(50)]
        public string? SwitchDeliveryAgentAddress3 { get; set; }
        [Column("Switch Delivery Agent Address 4")]
        [StringLength(50)]
        public string? SwitchDeliveryAgentAddress4 { get; set; }
        [Column("Switch Laden Date")]
        [StringLength(16)]
        [Unicode(false)]
        public string? SwitchLadenDate { get; set; }
        [Column("Switch Notify Code")]
        [StringLength(10)]
        public string? SwitchNotifyCode { get; set; }
        [Column("Switch Notify Name")]
        [StringLength(80)]
        public string? SwitchNotifyName { get; set; }
        [Column("Switch Notify Address 1")]
        [StringLength(50)]
        public string? SwitchNotifyAddress1 { get; set; }
        [Column("Switch Notify Address 2")]
        [StringLength(50)]
        public string? SwitchNotifyAddress2 { get; set; }
        [Column("Switch Notify Address 3")]
        [StringLength(50)]
        public string? SwitchNotifyAddress3 { get; set; }
        [Column("Switch Notify Address 4")]
        [StringLength(50)]
        public string? SwitchNotifyAddress4 { get; set; }
        [Column("Switch Shipper Code")]
        [StringLength(10)]
        public string? SwitchShipperCode { get; set; }
        [Column("Switch Shipper Name")]
        [StringLength(80)]
        public string? SwitchShipperName { get; set; }
        [Column("Switch Shipper Address 1")]
        [StringLength(50)]
        public string? SwitchShipperAddress1 { get; set; }
        [Column("Switch Shipper Address 2")]
        [StringLength(50)]
        public string? SwitchShipperAddress2 { get; set; }
        [Column("Switch Shipper Address 3")]
        [StringLength(50)]
        public string? SwitchShipperAddress3 { get; set; }
        [Column("Switch Shipper Address 4")]
        [StringLength(50)]
        public string? SwitchShipperAddress4 { get; set; }
        [Column("Switch Vessel Name")]
        [StringLength(50)]
        public string? SwitchVesselName { get; set; }
        [Column("Switch Voyage No")]
        [StringLength(20)]
        public string? SwitchVoyageNo { get; set; }
        [Column("Table Name")]
        [StringLength(10)]
        public string? TableName { get; set; }
        [Column("Tally By")]
        [StringLength(50)]
        public string? TallyBy { get; set; }
        [Column("Target Company Code")]
        [StringLength(5)]
        public string? TargetCompanyCode { get; set; }
        [Column("Target Job No")]
        [StringLength(30)]
        public string? TargetJobNo { get; set; }
        [Column("Target Site Code")]
        [StringLength(20)]
        public string? TargetSiteCode { get; set; }
        [Column("Tax Cc Amt", TypeName = "decimal(13, 2)")]
        public decimal? TaxCcAmt { get; set; }
        [Column("Tax Pp Amt", TypeName = "decimal(13, 2)")]
        public decimal? TaxPpAmt { get; set; }
        [Column("Telex Release Flag")]
        [StringLength(1)]
        public string? TelexReleaseFlag { get; set; }
        [Column("Template Name")]
        [StringLength(50)]
        public string? TemplateName { get; set; }
        [StringLength(20)]
        public string? Terminal { get; set; }
        [Column("Third Via Port Code")]
        [StringLength(5)]
        public string? ThirdViaPortCode { get; set; }
        [Column("Total Actual Volume", TypeName = "decimal(13, 4)")]
        public decimal? TotalActualVolume { get; set; }
        [Column("Total Charge Weight", TypeName = "decimal(13, 4)")]
        public decimal? TotalChargeWeight { get; set; }
        [Column("Total Container")]
        [StringLength(50)]
        public string? TotalContainer { get; set; }
        [Column("Total Gross Weight", TypeName = "decimal(13, 4)")]
        public decimal? TotalGrossWeight { get; set; }
        [Column("Total Pcs")]
        public int? TotalPcs { get; set; }
        [Column("Total Volume", TypeName = "decimal(13, 4)")]
        public decimal? TotalVolume { get; set; }
        [Column("Transhipment Amt", TypeName = "decimal(13, 2)")]
        public decimal? TranshipmentAmt { get; set; }
        [Column("Transhipment Curr Code")]
        [StringLength(3)]
        public string? TranshipmentCurrCode { get; set; }
        [Column("Transhipment Flag")]
        [StringLength(2)]
        public string? TranshipmentFlag { get; set; }
        [Column("Transhipment Rate", TypeName = "decimal(13, 2)")]
        public decimal? TranshipmentRate { get; set; }
        [Column("Transhipment Rate Remark")]
        [StringLength(50)]
        public string? TranshipmentRateRemark { get; set; }
        [Column("Transport Company Code")]
        [StringLength(10)]
        public string? TransportCompanyCode { get; set; }
        [Column("Transport Company Name")]
        [StringLength(80)]
        public string? TransportCompanyName { get; set; }
        [Column("Transport Company Address 1")]
        [StringLength(50)]
        public string? TransportCompanyAddress1 { get; set; }
        [Column("Transport Company Address 2")]
        [StringLength(50)]
        public string? TransportCompanyAddress2 { get; set; }
        [Column("Transport Company Address 3")]
        [StringLength(50)]
        public string? TransportCompanyAddress3 { get; set; }
        [Column("Transport Company Address 4")]
        [StringLength(50)]
        public string? TransportCompanyAddress4 { get; set; }
        [Column("Transport Company Contact Name")]
        [StringLength(50)]
        public string? TransportCompanyContactName { get; set; }
        [Column("Transport Company Fax")]
        [StringLength(30)]
        public string? TransportCompanyFax { get; set; }
        [Column("Transport Company Telephone")]
        [StringLength(30)]
        public string? TransportCompanyTelephone { get; set; }
        [Column("Trk Rcv Date Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? TrkRcvDateDate { get; set; }
        [Column("Trk Receipt Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? TrkReceiptDate { get; set; }
        [Column("Trucker Code")]
        [StringLength(8)]
        public string? TruckerCode { get; set; }
        [Column("Trucker Name")]
        [StringLength(50)]
        public string? TruckerName { get; set; }
        [Column("Trucking Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? TruckingDate { get; set; }
        [Column("Truck In Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? TruckInDateTime { get; set; }
        [Column("Truck Out Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? TruckOutDateTime { get; set; }
        [Column("Ucr No")]
        [StringLength(50)]
        public string? UcrNo { get; set; }
        [Column("Un No")]
        [StringLength(20)]
        public string? UnNo { get; set; }
        [Column("Unstuff Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? UnstuffDate { get; set; }
        [Column("Uom Code")]
        [StringLength(50)]
        public string? UomCode { get; set; }
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
        [Column("User Group")]
        [StringLength(10)]
        public string? UserGroup { get; set; }
        [Column("Vehicle No")]
        [StringLength(12)]
        public string? VehicleNo { get; set; }
        [Column("Vessel Code")]
        [StringLength(50)]
        public string? VesselCode { get; set; }
        [Column("Vessel Name")]
        [StringLength(50)]
        public string? VesselName { get; set; }
        [Column("Voyage No")]
        [StringLength(20)]
        public string? VoyageNo { get; set; }
        [Column("Yard Code")]
        [StringLength(10)]
        public string? YardCode { get; set; }
        [Column("Yard Name")]
        [StringLength(80)]
        public string? YardName { get; set; }
        [Column("Yard Address 1")]
        [StringLength(50)]
        public string? YardAddress1 { get; set; }
        [Column("Yard Address 2")]
        [StringLength(50)]
        public string? YardAddress2 { get; set; }
        [Column("Yard Address 3")]
        [StringLength(50)]
        public string? YardAddress3 { get; set; }
        [Column("Yard Address 4")]
        [StringLength(50)]
        public string? YardAddress4 { get; set; }
        [Column("Warehouse Charge Template Name")]
        [StringLength(50)]
        public string? WarehouseChargeTemplateName { get; set; }
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
