using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSebk1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Actual Gross Weight", TypeName = "decimal(13, 4)")]
        public decimal ActualGrossWeight { get; set; }
        [Column("Actual Pcs")]
        public int ActualPcs { get; set; }
        [Column("Actual Pickup Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? ActualPickupDateTime { get; set; }
        [Column("Actual Volume", TypeName = "decimal(13, 4)")]
        public decimal ActualVolume { get; set; }
        [Column("Address 1")]
        [StringLength(50)]
        public string? Address1 { get; set; }
        [Column("Address 2")]
        [StringLength(50)]
        public string? Address2 { get; set; }
        [Column("Address 3")]
        [StringLength(50)]
        public string? Address3 { get; set; }
        [Column("Address 4")]
        [StringLength(50)]
        public string? Address4 { get; set; }
        [Column("Also Notify Code")]
        [StringLength(10)]
        public string? AlsoNotifyCode { get; set; }
        [Column("Also Notify Name")]
        [StringLength(80)]
        public string? AlsoNotifyName { get; set; }
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
        [Column("Ata Date")]
        [StringLength(16)]
        [Unicode(false)]
        public string? AtaDate { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("AVA Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? AvaDateTime { get; set; }
        [Column("Bar Code")]
        [StringLength(50)]
        public string? BarCode { get; set; }
        [Column("Billing Remark")]
        [StringLength(600)]
        public string? BillingRemark { get; set; }
        [Column("Bl No")]
        [StringLength(30)]
        public string? BlNo { get; set; }
        [Column("Bl Type")]
        [StringLength(10)]
        public string? BlType { get; set; }
        [Column("Booking Customer Code")]
        [StringLength(10)]
        public string? BookingCustomerCode { get; set; }
        [Column("Booking Customer Name")]
        [StringLength(80)]
        public string? BookingCustomerName { get; set; }
        [Column("Booking Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? BookingDate { get; set; }
        [Column("Booking Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? BookingDateTime { get; set; }
        [Column("Booking Ref No")]
        [StringLength(30)]
        public string? BookingRefNo { get; set; }
        [Column("Booking No")]
        [StringLength(30)]
        public string? BookingNo { get; set; }
        [Column("Booking Seq No")]
        [StringLength(4)]
        public string? BookingSeqNo { get; set; }
        [Column("Cargo Class")]
        [StringLength(10)]
        public string? CargoClass { get; set; }
        [Column("Cargo Receipt Date")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CargoReceiptDate { get; set; }
        [Column("Cargo Receipt Flag")]
        [StringLength(1)]
        public string? CargoReceiptFlag { get; set; }
        [Column("Cargo Receipt Remark")]
        [StringLength(255)]
        public string? CargoReceiptRemark { get; set; }
        [Column("Cargo Type")]
        [StringLength(5)]
        public string? CargoType { get; set; }
        [Column("Carrier Booking Ref")]
        [StringLength(250)]
        public string? CarrierBookingRef { get; set; }
        [Column("Carrier Name")]
        [StringLength(80)]
        public string? CarrierName { get; set; }
        [Column("Close Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CloseDateTime { get; set; }
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
        [Column("Collect From Template Name")]
        [StringLength(50)]
        public string? CollectFromTemplateName { get; set; }
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
        [Column("Combine Booking No")]
        [StringLength(30)]
        public string? CombineBookingNo { get; set; }
        [Column("Combine Job No")]
        [StringLength(30)]
        public string? CombineJobNo { get; set; }
        [Column("Commodity Code")]
        [StringLength(50)]
        public string? CommodityCode { get; set; }
        [Column("Commodity Description")]
        [StringLength(50)]
        public string? CommodityDescription { get; set; }
        [Column("Consignee Code")]
        [StringLength(10)]
        public string? ConsigneeCode { get; set; }
        [Column("Consignee Name")]
        [StringLength(80)]
        public string? ConsigneeName { get; set; }
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
        [Column("Contact Fax")]
        [StringLength(30)]
        public string? ContactFax { get; set; }
        [Column("Contact Name")]
        [StringLength(50)]
        public string? ContactName { get; set; }
        [Column("Contact Telephone")]
        [StringLength(30)]
        public string? ContactTelephone { get; set; }
        [Column("Container No")]
        [StringLength(1000)]
        public string? ContainerNo { get; set; }
        [Column("Container Type 1")]
        [StringLength(5)]
        public string? ContainerType1 { get; set; }
        [Column("Container Type 2")]
        [StringLength(5)]
        public string? ContainerType2 { get; set; }
        [Column("Container Type 3")]
        [StringLength(5)]
        public string? ContainerType3 { get; set; }
        [Column("Container Type 4")]
        [StringLength(5)]
        public string? ContainerType4 { get; set; }
        [Column("Container Type 5")]
        [StringLength(5)]
        public string? ContainerType5 { get; set; }
        [Column("Container Type 6")]
        [StringLength(5)]
        public string? ContainerType6 { get; set; }
        [Column("Container Type 7")]
        [StringLength(5)]
        public string? ContainerType7 { get; set; }
        [Column("Container Type 8")]
        [StringLength(5)]
        public string? ContainerType8 { get; set; }
        [Column("Container Weight 1", TypeName = "decimal(16, 4)")]
        public decimal? ContainerWeight1 { get; set; }
        [Column("Container Weight 2", TypeName = "decimal(16, 4)")]
        public decimal? ContainerWeight2 { get; set; }
        [Column("Container Weight 3", TypeName = "decimal(16, 4)")]
        public decimal? ContainerWeight3 { get; set; }
        [Column("Container Weight 4", TypeName = "decimal(16, 4)")]
        public decimal? ContainerWeight4 { get; set; }
        [Column("Copy Template Name")]
        [StringLength(50)]
        public string? CopyTemplateName { get; set; }
        [Column("Copy Template Remark")]
        [StringLength(255)]
        public string? CopyTemplateRemark { get; set; }
        [Column("Costing Flag")]
        [StringLength(1)]
        [Unicode(false)]
        public string CostingFlag { get; set; } = null!;
        [Column("Country Of Origin")]
        [StringLength(2)]
        public string? CountryOfOrigin { get; set; }
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
        [Column("Delivery Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? DeliveryDateTime { get; set; }
        [Column("Delivery Instruction 1")]
        [StringLength(80)]
        public string? DeliveryInstruction1 { get; set; }
        [Column("Delivery Instruction 2")]
        [StringLength(80)]
        public string? DeliveryInstruction2 { get; set; }
        [Column("Delivery Instruction 3")]
        [StringLength(80)]
        public string? DeliveryInstruction3 { get; set; }
        [Column("Delivery Instruction 4")]
        [StringLength(80)]
        public string? DeliveryInstruction4 { get; set; }
        [Column("Delivery Instruction 5")]
        [StringLength(80)]
        public string? DeliveryInstruction5 { get; set; }
        [Column("Delivery Instruction 6")]
        [StringLength(80)]
        public string? DeliveryInstruction6 { get; set; }
        [Column("Delivery Instruction 7")]
        [StringLength(80)]
        public string? DeliveryInstruction7 { get; set; }
        [Column("Delivery Instruction 8")]
        [StringLength(80)]
        public string? DeliveryInstruction8 { get; set; }
        [Column("Delivery Instruction Template Name")]
        [StringLength(50)]
        public string? DeliveryInstructionTemplateName { get; set; }
        [Column("Delivery Status Code")]
        [StringLength(3)]
        public string? DeliveryStatusCode { get; set; }
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
        [Column("Delivery Type")]
        [StringLength(5)]
        public string? DeliveryType { get; set; }
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
        [Column("Dest Cargo Type")]
        [StringLength(5)]
        public string? DestCargoType { get; set; }
        [Column("Dest Code")]
        [StringLength(3)]
        public string? DestCode { get; set; }
        [Column("Dest Name")]
        [StringLength(45)]
        public string? DestName { get; set; }
        [Column("Dest Country Code")]
        [StringLength(2)]
        public string? DestCountryCode { get; set; }
        [Column("Dest Eta")]
        [StringLength(10)]
        [Unicode(false)]
        public string? DestEta { get; set; }
        [Column("Dg Flag")]
        [StringLength(1)]
        public string? DgFlag { get; set; }
        [Column("Division Code")]
        [StringLength(10)]
        public string? DivisionCode { get; set; }
        [Column("Driver Code")]
        [StringLength(15)]
        public string? DriverCode { get; set; }
        [Column("Driver Contact No 1")]
        [StringLength(30)]
        public string? DriverContactNo1 { get; set; }
        [Column("Driver Contact No 2")]
        [StringLength(30)]
        public string? DriverContactNo2 { get; set; }
        [Column("Driver2 Code")]
        [StringLength(15)]
        public string? Driver2Code { get; set; }
        [Column("Driver2 Contact No 1")]
        [StringLength(30)]
        public string? Driver2ContactNo1 { get; set; }
        [Column("Driver2 Contact No 2")]
        [StringLength(30)]
        public string? Driver2ContactNo2 { get; set; }
        [Column("Driver2 Name")]
        [StringLength(50)]
        public string? Driver2Name { get; set; }
        [Column("Edi Count")]
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
        [Column("Event Template Name")]
        [StringLength(50)]
        public string? EventTemplateName { get; set; }
        [Column("Export Count")]
        public byte? ExportCount { get; set; }
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
        [Column("First Via Ata Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? FirstViaAtaDate { get; set; }
        [Column("First Via Eta Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? FirstViaEtaDate { get; set; }
        [Column("First Via Etd Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? FirstViaEtdDate { get; set; }
        [Column("First Via Port Code")]
        [StringLength(5)]
        public string? FirstViaPortCode { get; set; }
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
        [Column("Footer 1 Bold")]
        [StringLength(1)]
        public string? Footer1Bold { get; set; }
        [Column("Footer 2 Bold")]
        [StringLength(1)]
        public string? Footer2Bold { get; set; }
        [Column("Footer 3 Bold")]
        [StringLength(1)]
        public string? Footer3Bold { get; set; }
        [Column("Footer 4 Bold")]
        [StringLength(1)]
        public string? Footer4Bold { get; set; }
        [Column("Footer 5 Bold")]
        [StringLength(1)]
        public string? Footer5Bold { get; set; }
        [Column("Footer 6 Bold")]
        [StringLength(1)]
        public string? Footer6Bold { get; set; }
        [Column("Footer 7 Bold")]
        [StringLength(1)]
        public string? Footer7Bold { get; set; }
        [Column("Footer 8 Bold")]
        [StringLength(1)]
        public string? Footer8Bold { get; set; }
        [Column("Footer 9 Bold")]
        [StringLength(1)]
        public string? Footer9Bold { get; set; }
        [Column("Footer 10 Bold")]
        [StringLength(1)]
        public string? Footer10Bold { get; set; }
        [Column("Footer Template Name")]
        [StringLength(50)]
        public string? FooterTemplateName { get; set; }
        [Column("Forward Agent Code")]
        [StringLength(10)]
        public string? ForwardAgentCode { get; set; }
        [Column("Forward Agent Name")]
        [StringLength(80)]
        public string? ForwardAgentName { get; set; }
        [Column("Fourth Via Port Code")]
        [StringLength(5)]
        public string? FourthViaPortCode { get; set; }
        [Column("Frt Pp Cc Flag")]
        [StringLength(1)]
        public string? FrtPpCcFlag { get; set; }
        [Column("Fumigation Company Code")]
        [StringLength(10)]
        public string? FumigationCompanyCode { get; set; }
        [Column("Fumigation Company Name")]
        [StringLength(80)]
        public string? FumigationCompanyName { get; set; }
        [Column("Fumigation Company Address 1")]
        [StringLength(50)]
        public string? FumigationCompanyAddress1 { get; set; }
        [Column("Fumigation Company Address 2")]
        [StringLength(50)]
        public string? FumigationCompanyAddress2 { get; set; }
        [Column("Fumigation Company Address 3")]
        [StringLength(50)]
        public string? FumigationCompanyAddress3 { get; set; }
        [Column("Fumigation Company Address 4")]
        [StringLength(50)]
        public string? FumigationCompanyAddress4 { get; set; }
        [Column("Fumigation Company Contact Name")]
        [StringLength(50)]
        public string? FumigationCompanyContactName { get; set; }
        [Column("Fumigation Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? FumigationDateTime { get; set; }
        [Column("Fumigation Instruction 1")]
        [StringLength(80)]
        public string? FumigationInstruction1 { get; set; }
        [Column("Fumigation Instruction 2")]
        [StringLength(80)]
        public string? FumigationInstruction2 { get; set; }
        [Column("Fumigation Instruction 3")]
        [StringLength(80)]
        public string? FumigationInstruction3 { get; set; }
        [Column("Fumigation Instruction 4")]
        [StringLength(80)]
        public string? FumigationInstruction4 { get; set; }
        [Column("Fumigation Instruction 5")]
        [StringLength(80)]
        public string? FumigationInstruction5 { get; set; }
        [Column("Fumigation Instruction 6")]
        [StringLength(80)]
        public string? FumigationInstruction6 { get; set; }
        [Column("Fumigation Instruction 7")]
        [StringLength(80)]
        public string? FumigationInstruction7 { get; set; }
        [Column("Fumigation Instruction 8")]
        [StringLength(80)]
        public string? FumigationInstruction8 { get; set; }
        [Column("Fumigation Instruction Template Name")]
        [StringLength(50)]
        public string? FumigationInstructionTemplateName { get; set; }
        [Column("Fumigation Flag")]
        [StringLength(1)]
        public string? FumigationFlag { get; set; }
        [Column("Fumigation Remark")]
        [StringLength(50)]
        public string? FumigationRemark { get; set; }
        [Column("History Flag")]
        [StringLength(1)]
        public string? HistoryFlag { get; set; }
        [Column("House Job No")]
        [StringLength(30)]
        public string? HouseJobNo { get; set; }
        [Column("Image 01", TypeName = "image")]
        public byte[]? Image01 { get; set; }
        [Column("Image 01 Flag")]
        [StringLength(1)]
        [Unicode(false)]
        public string Image01Flag { get; set; } = null!;
        [StringLength(20)]
        public string? Imco { get; set; }
        [Column("Import Eta Date", TypeName = "datetime")]
        public DateTime? ImportEtaDate { get; set; }
        [Column("Import Job No")]
        [StringLength(30)]
        public string? ImportJobNo { get; set; }
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
        [Column("Insurance Flag")]
        [StringLength(1)]
        public string? InsuranceFlag { get; set; }
        [Column("Insurance Remark")]
        [StringLength(50)]
        public string? InsuranceRemark { get; set; }
        [Column("Job Costing Flag")]
        [StringLength(1)]
        [Unicode(false)]
        public string JobCostingFlag { get; set; } = null!;
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
        [Column("Letter Of Credit No")]
        [StringLength(15)]
        public string? LetterOfCreditNo { get; set; }
        [Column("Loose Qty")]
        public int? LooseQty { get; set; }
        [Column("Loose Uom Code")]
        [StringLength(50)]
        public string? LooseUomCode { get; set; }
        [Column("Mark No")]
        [StringLength(50)]
        public string? MarkNo { get; set; }
        [Column("Master Job No")]
        [StringLength(30)]
        public string? MasterJobNo { get; set; }
        [Column("Mother Vessel Name")]
        [StringLength(50)]
        public string? MotherVesselName { get; set; }
        [Column("Mother Voyage")]
        [StringLength(20)]
        public string? MotherVoyage { get; set; }
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
        [Column("No Of Container 1")]
        public int? NoOfContainer1 { get; set; }
        [Column("No Of Container 2")]
        public int? NoOfContainer2 { get; set; }
        [Column("No Of Container 3")]
        public int? NoOfContainer3 { get; set; }
        [Column("No Of Container 4")]
        public int? NoOfContainer4 { get; set; }
        [Column("No Of Container 5")]
        public int? NoOfContainer5 { get; set; }
        [Column("No Of Container 6")]
        public int? NoOfContainer6 { get; set; }
        [Column("No Of Container 7")]
        public int? NoOfContainer7 { get; set; }
        [Column("No Of Container 8")]
        public int? NoOfContainer8 { get; set; }
        [Column("Notify Code")]
        [StringLength(10)]
        public string? NotifyCode { get; set; }
        [Column("Notify Name")]
        [StringLength(80)]
        public string? NotifyName { get; set; }
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
        [Column("Other Pp Cc Flag")]
        [StringLength(1)]
        public string? OtherPpCcFlag { get; set; }
        [Column("Permit Flag")]
        [StringLength(1)]
        public string? PermitFlag { get; set; }
        [Column("Permit No")]
        [StringLength(255)]
        public string? PermitNo { get; set; }
        [Column("Permit Remark")]
        [StringLength(50)]
        public string? PermitRemark { get; set; }
        [Column("Pickup Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? PickupDateTime { get; set; }
        [Column("Pickup Date Time Remark")]
        [StringLength(50)]
        public string? PickupDateTimeRemark { get; set; }
        [Column("Pickup No")]
        [StringLength(20)]
        public string? PickupNo { get; set; }
        [Column("Pickup Template Name")]
        [StringLength(80)]
        public string? PickupTemplateName { get; set; }
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
        [Column("Principle Agent Code")]
        [StringLength(12)]
        public string? PrincipleAgentCode { get; set; }
        [Column("Print Count")]
        public byte? PrintCount { get; set; }
        [Column("Profit Share Percent", TypeName = "decimal(13, 2)")]
        public decimal? ProfitSharePercent { get; set; }
        [StringLength(80)]
        public string? Psn { get; set; }
        [Column("Quotation No")]
        [StringLength(15)]
        public string? QuotationNo { get; set; }
        [Column("Railing Flag")]
        [StringLength(1)]
        public string? RailingFlag { get; set; }
        [Column("Railing Instruction Flag")]
        [StringLength(1)]
        public string? RailingInstructionFlag { get; set; }
        [Column("Railing Instruction Remark")]
        [StringLength(50)]
        public string? RailingInstructionRemark { get; set; }
        [Column("Railing Remark")]
        [StringLength(100)]
        public string? RailingRemark { get; set; }
        [Column("Receipt Gross Weight", TypeName = "decimal(13, 4)")]
        public decimal? ReceiptGrossWeight { get; set; }
        [Column("Receipt Pcs")]
        public int? ReceiptPcs { get; set; }
        [Column("Receipt Volume", TypeName = "decimal(13, 4)")]
        public decimal? ReceiptVolume { get; set; }
        [Column("Reefer Container Flag")]
        [StringLength(1)]
        public string? ReeferContainerFlag { get; set; }
        [Column("Reefer Setting 1")]
        [StringLength(1)]
        public string? ReeferSetting1 { get; set; }
        [Column("Reefer Setting 2")]
        [StringLength(1)]
        public string? ReeferSetting2 { get; set; }
        [Column("Reefer Setting 3")]
        [StringLength(1)]
        public string? ReeferSetting3 { get; set; }
        [Column("Reefer Setting 4")]
        [StringLength(1)]
        public string? ReeferSetting4 { get; set; }
        [StringLength(1000)]
        public string? Remark { get; set; }
        [Column("Remark Only")]
        [StringLength(4000)]
        public string? RemarkOnly { get; set; }
        [Column("Request Transport No")]
        [StringLength(20)]
        public string? RequestTransportNo { get; set; }
        [Column("Salesman Code")]
        [StringLength(10)]
        public string? SalesmanCode { get; set; }
        [Column("Scn Code")]
        [StringLength(10)]
        public string? ScnCode { get; set; }
        [Column("Second Vessel Code")]
        [StringLength(12)]
        public string? SecondVesselCode { get; set; }
        [Column("Second Via Port Code")]
        [StringLength(5)]
        public string? SecondViaPortCode { get; set; }
        [Column("Second Voyage No")]
        [StringLength(20)]
        public string? SecondVoyageNo { get; set; }
        [Column("Send Direct Bold")]
        [StringLength(1)]
        public string? SendDirectBold { get; set; }
        [Column("Send Direct Flag")]
        [StringLength(1)]
        public string? SendDirectFlag { get; set; }
        [Column("Service Level")]
        [StringLength(10)]
        public string? ServiceLevel { get; set; }
        [Column("Shipment Type")]
        [StringLength(3)]
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
        [Column("Short Booking No")]
        public int? ShortBookingNo { get; set; }
        [Column("Site Code")]
        [StringLength(20)]
        public string? SiteCode { get; set; }
        [Column("Smk Ship Agent Code")]
        [StringLength(12)]
        public string? SmkShipAgentCode { get; set; }
        [Column("Source Company Code")]
        [StringLength(5)]
        public string? SourceCompanyCode { get; set; }
        [Column("Source Job No")]
        [StringLength(30)]
        public string? SourceJobNo { get; set; }
        [Column("Source Site Code")]
        [StringLength(20)]
        public string? SourceSiteCode { get; set; }
        [Column("Stack Bold")]
        [StringLength(1)]
        public string? StackBold { get; set; }
        [Column("Stack Flag")]
        [StringLength(1)]
        public string? StackFlag { get; set; }
        [Column("Stamping Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? StampingDateTime { get; set; }
        [Column("Stuff Agent Code")]
        [StringLength(10)]
        public string? StuffAgentCode { get; set; }
        [Column("Stuff Agent Name")]
        [StringLength(80)]
        public string? StuffAgentName { get; set; }
        [Column("Stuff Agent Address1")]
        [StringLength(50)]
        public string? StuffAgentAddress1 { get; set; }
        [Column("Stuff Agent Address2")]
        [StringLength(50)]
        public string? StuffAgentAddress2 { get; set; }
        [Column("Stuff Agent Address3")]
        [StringLength(50)]
        public string? StuffAgentAddress3 { get; set; }
        [Column("Stuff Agent Address4")]
        [StringLength(50)]
        public string? StuffAgentAddress4 { get; set; }
        [Column("Stuff Agent Contact Name")]
        [StringLength(50)]
        public string? StuffAgentContactName { get; set; }
        [Column("Stuff Agent Instruction Template Name")]
        [StringLength(50)]
        public string? StuffAgentInstructionTemplateName { get; set; }
        [Column("Stuff Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? StuffDate { get; set; }
        [Column("Stuffing Flag")]
        [StringLength(1)]
        public string? StuffingFlag { get; set; }
        [Column("Stuffing Remark")]
        [StringLength(50)]
        public string? StuffingRemark { get; set; }
        [Column("Sub Master Flag")]
        [StringLength(1)]
        public string? SubMasterFlag { get; set; }
        [Column("Table Name")]
        [StringLength(10)]
        public string? TableName { get; set; }
        [Column("Take Photo Bold")]
        [StringLength(1)]
        public string? TakePhotoBold { get; set; }
        [Column("Take Photo Flag")]
        [StringLength(1)]
        public string? TakePhotoFlag { get; set; }
        [Column("Temperature 1")]
        [StringLength(20)]
        public string? Temperature1 { get; set; }
        [Column("Temperature 2")]
        [StringLength(20)]
        public string? Temperature2 { get; set; }
        [Column("Temperature 3")]
        [StringLength(20)]
        public string? Temperature3 { get; set; }
        [Column("Temperature 4")]
        [StringLength(20)]
        public string? Temperature4 { get; set; }
        [StringLength(20)]
        public string? Terminal { get; set; }
        [Column("Third Via Port Code")]
        [StringLength(5)]
        public string? ThirdViaPortCode { get; set; }
        [Column("Total Charge Weight", TypeName = "decimal(13, 4)")]
        public decimal? TotalChargeWeight { get; set; }
        [Column("Total Container")]
        [StringLength(50)]
        public string? TotalContainer { get; set; }
        [Column("Total F Iata Amt", TypeName = "decimal(13, 2)")]
        public decimal? TotalFIataAmt { get; set; }
        [Column("Total Gross Weight", TypeName = "decimal(13, 4)")]
        public decimal? TotalGrossWeight { get; set; }
        [Column("Total Net Weight", TypeName = "decimal(38, 4)")]
        public decimal? TotalNetWeight { get; set; }
        [Column("Total Net Volume", TypeName = "decimal(16, 4)")]
        public decimal? TotalNetVolume { get; set; }
        [Column("Total Pcs")]
        public int? TotalPcs { get; set; }
        [Column("Total Volume", TypeName = "decimal(13, 4)")]
        public decimal? TotalVolume { get; set; }
        [StringLength(1)]
        [Unicode(false)]
        public string Transhipment { get; set; } = null!;
        [Column("Transport Company Code")]
        [StringLength(10)]
        public string? TransportCompanyCode { get; set; }
        [Column("Transport Company Name")]
        [StringLength(80)]
        public string? TransportCompanyName { get; set; }
        [Column("Transport Company Contact Name")]
        [StringLength(50)]
        public string? TransportCompanyContactName { get; set; }
        [Column("Transport Address 1")]
        [StringLength(50)]
        public string? TransportAddress1 { get; set; }
        [Column("Transport Address 2")]
        [StringLength(50)]
        public string? TransportAddress2 { get; set; }
        [Column("Transport Address 3")]
        [StringLength(50)]
        public string? TransportAddress3 { get; set; }
        [Column("Transport Address 4")]
        [StringLength(50)]
        public string? TransportAddress4 { get; set; }
        [Column("Ucr No")]
        [StringLength(250)]
        public string? UcrNo { get; set; }
        [Column("Un No")]
        [StringLength(20)]
        public string? UnNo { get; set; }
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
        [StringLength(10)]
        public string? VehicleNo { get; set; }
        [Column("Ventilation Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? VentilationDateTime { get; set; }
        [Column("Vessel Code")]
        [StringLength(50)]
        public string? VesselCode { get; set; }
        [Column("Vessel Name")]
        [StringLength(50)]
        public string? VesselName { get; set; }
        [Column("Voyage ID")]
        [StringLength(10)]
        public string? VoyageId { get; set; }
        [Column("Voyage No")]
        [StringLength(20)]
        public string? VoyageNo { get; set; }
        [Column("Warehouse Remark")]
        [StringLength(800)]
        public string? WarehouseRemark { get; set; }
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
        public string? Status { get; set; }
    }
}
