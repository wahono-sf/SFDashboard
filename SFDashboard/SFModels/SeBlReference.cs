using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class SeBlReference
    {
        [StringLength(20)]
        public string? Reference { get; set; }
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Agent Code")]
        [StringLength(10)]
        public string? AgentCode { get; set; }
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
        [StringLength(45)]
        public string? AlsoNotifyAddress1 { get; set; }
        [Column("Also Notify Address 2")]
        [StringLength(45)]
        public string? AlsoNotifyAddress2 { get; set; }
        [Column("Also Notify Address 3")]
        [StringLength(45)]
        public string? AlsoNotifyAddress3 { get; set; }
        [Column("Also Notify Address 4")]
        [StringLength(45)]
        public string? AlsoNotifyAddress4 { get; set; }
        [Column("Ata Date")]
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
        [Column("Bill Mode")]
        [StringLength(50)]
        public string? BillMode { get; set; }
        [Column("Billing Instruction")]
        [StringLength(255)]
        public string? BillingInstruction { get; set; }
        [Column("Bill To Code")]
        [StringLength(8)]
        public string? BillToCode { get; set; }
        [Column("Bl Attach Flag")]
        [StringLength(1)]
        public string? BlAttachFlag { get; set; }
        [Column("Bl Issue Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? BlIssueDate { get; set; }
        [Column("Bl Issue Place")]
        [StringLength(45)]
        public string? BlIssuePlace { get; set; }
        [Column("Bl No")]
        [StringLength(20)]
        public string? BlNo { get; set; }
        [Column("Bl Ready Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? BlReadyDate { get; set; }
        [Column("Bl Surrender Flag")]
        [StringLength(1)]
        public string? BlSurrenderFlag { get; set; }
        [Column("Booking No")]
        [StringLength(20)]
        public string? BookingNo { get; set; }
        [Column("Cargo Class")]
        [StringLength(10)]
        public string? CargoClass { get; set; }
        [Column("Cargo Receipt Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? CargoReceiptDate { get; set; }
        [Column("Cargo Type")]
        [StringLength(5)]
        public string? CargoType { get; set; }
        [Column("Carrier Booking Ref")]
        [StringLength(50)]
        public string? CarrierBookingRef { get; set; }
        [Column("Close Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CloseDateTime { get; set; }
        [Column("Close Consol")]
        [StringLength(1)]
        public string? CloseConsol { get; set; }
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
        [StringLength(10)]
        public string? CommodityCode { get; set; }
        [Column("Commodity Description")]
        [StringLength(50)]
        public string? CommodityDescription { get; set; }
        [Column("Confirm Arrival Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ConfirmArrivalDate { get; set; }
        [Column("Confirm Departure Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ConfirmDepartureDate { get; set; }
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
        [Column("Container No")]
        [StringLength(500)]
        public string? ContainerNo { get; set; }
        [Column("Container Seal No")]
        [StringLength(1000)]
        public string? ContainerSealNo { get; set; }
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
        [Column("Contr Flag")]
        [StringLength(4)]
        public string? ContrFlag { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Curr Rate", TypeName = "decimal(13, 6)")]
        public decimal? CurrRate { get; set; }
        [Column("Customer Code")]
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [Column("Customer Name")]
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [Column("Custom Value", TypeName = "decimal(13, 2)")]
        public decimal? CustomValue { get; set; }
        [Column("Delivery Agent Code")]
        [StringLength(10)]
        public string? DeliveryAgentCode { get; set; }
        [Column("Delivery Agent Name")]
        [StringLength(80)]
        public string? DeliveryAgentName { get; set; }
        [Column("Delivery Agent Address 1")]
        [StringLength(45)]
        public string? DeliveryAgentAddress1 { get; set; }
        [Column("Delivery Agent Address 2")]
        [StringLength(45)]
        public string? DeliveryAgentAddress2 { get; set; }
        [Column("Delivery Agent Address 3")]
        [StringLength(45)]
        public string? DeliveryAgentAddress3 { get; set; }
        [Column("Delivery Agent Address 4")]
        [StringLength(45)]
        public string? DeliveryAgentAddress4 { get; set; }
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
        [Column("Delivery Pcs")]
        public int? DeliveryPcs { get; set; }
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
        [StringLength(45)]
        public string? DepotAddress1 { get; set; }
        [Column("Depot Address 2")]
        [StringLength(45)]
        public string? DepotAddress2 { get; set; }
        [Column("Depot Address 3")]
        [StringLength(45)]
        public string? DepotAddress3 { get; set; }
        [Column("Depot Address 4")]
        [StringLength(45)]
        public string? DepotAddress4 { get; set; }
        [Column("Dest Cargo Type")]
        [StringLength(5)]
        public string? DestCargoType { get; set; }
        [Column("Dest Code")]
        [StringLength(3)]
        public string? DestCode { get; set; }
        [Column("Dest Eta")]
        [StringLength(10)]
        [Unicode(false)]
        public string? DestEta { get; set; }
        [Column("Division Code")]
        [StringLength(10)]
        public string? DivisionCode { get; set; }
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
        [Column("Ff Receipt Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? FfReceiptDate { get; set; }
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
        [Column("Fourth Via Port Code")]
        [StringLength(5)]
        public string? FourthViaPortCode { get; set; }
        [Column("Free House Flag")]
        [StringLength(50)]
        public string? FreeHouseFlag { get; set; }
        [Column("Frt Bill Party Code")]
        [StringLength(10)]
        public string? FrtBillPartyCode { get; set; }
        [Column("Frt Pp Cc Flag")]
        [StringLength(1)]
        public string? FrtPpCcFlag { get; set; }
        [Column("Haulier Remark")]
        [StringLength(255)]
        public string? HaulierRemark { get; set; }
        [Column("House Job No")]
        [StringLength(20)]
        public string? HouseJobNo { get; set; }
        [Column("Import Job No")]
        [StringLength(20)]
        public string? ImportJobNo { get; set; }
        [Column("Import Rate", TypeName = "decimal(13, 2)")]
        public decimal? ImportRate { get; set; }
        [Column("Insurance Amt", TypeName = "decimal(13, 2)")]
        public decimal? InsuranceAmt { get; set; }
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
        [Column("Job Type")]
        [StringLength(2)]
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
        [Column("Lodge Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LodgeDate { get; set; }
        [Column("Lot No")]
        [StringLength(50)]
        public string? LotNo { get; set; }
        [Column("Master Job No")]
        [StringLength(20)]
        public string? MasterJobNo { get; set; }
        [Column("Max Gross Weight", TypeName = "decimal(13, 4)")]
        public decimal? MaxGrossWeight { get; set; }
        [Column("Max Volume", TypeName = "decimal(13, 4)")]
        public decimal? MaxVolume { get; set; }
        [Column("Mother Vessel Name")]
        [StringLength(50)]
        public string? MotherVesselName { get; set; }
        [Column("Mother Voyage")]
        [StringLength(20)]
        public string? MotherVoyage { get; set; }
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
        [Column("No Of Origin Bl")]
        public byte? NoOfOriginBl { get; set; }
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
        [StringLength(45)]
        public string? NotifyAddress1 { get; set; }
        [Column("Notify Address 2")]
        [StringLength(45)]
        public string? NotifyAddress2 { get; set; }
        [Column("Notify Address 3")]
        [StringLength(45)]
        public string? NotifyAddress3 { get; set; }
        [Column("Notify Address 4")]
        [StringLength(45)]
        public string? NotifyAddress4 { get; set; }
        [Column("O Bl No")]
        [StringLength(20)]
        public string? OBlNo { get; set; }
        [Column("On Carriage Charges", TypeName = "decimal(13, 2)")]
        public decimal? OnCarriageCharges { get; set; }
        [Column("Origin Code")]
        [StringLength(3)]
        public string? OriginCode { get; set; }
        [Column("Other Bill Party Code")]
        [StringLength(10)]
        public string? OtherBillPartyCode { get; set; }
        [Column("Other Pp Cc Flag")]
        [StringLength(1)]
        public string? OtherPpCcFlag { get; set; }
        [Column("Payable At")]
        [StringLength(45)]
        public string? PayableAt { get; set; }
        [Column("Permit No")]
        [StringLength(260)]
        public string? PermitNo { get; set; }
        [Column("Pick Up Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? PickUpDate { get; set; }
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
        [Column("Pp Amt", TypeName = "decimal(13, 2)")]
        public decimal? PpAmt { get; set; }
        [Column("Pp At")]
        [StringLength(45)]
        public string? PpAt { get; set; }
        [Column("Pre Alert Dest Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? PreAlertDestDate { get; set; }
        [Column("Principle Agent Code")]
        [StringLength(12)]
        public string? PrincipleAgentCode { get; set; }
        [Column("Print Count")]
        public byte? PrintCount { get; set; }
        [Column("Quotation No")]
        [StringLength(15)]
        public string? QuotationNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Rebate { get; set; }
        [Column("Rec Status")]
        [StringLength(5)]
        public string? RecStatus { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Request Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? RequestDate { get; set; }
        [Column("Salesman Code")]
        [StringLength(10)]
        public string? SalesmanCode { get; set; }
        [Column("Scn Code")]
        [StringLength(10)]
        public string? ScnCode { get; set; }
        [Column("Second Via Port Code")]
        [StringLength(5)]
        public string? SecondViaPortCode { get; set; }
        [StringLength(50)]
        public string? Sector { get; set; }
        [Column("Service Indicator")]
        [StringLength(50)]
        public string? ServiceIndicator { get; set; }
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
        [Column("Shipper Count Flag")]
        [StringLength(1)]
        public string? ShipperCountFlag { get; set; }
        [Column("Shipping Description")]
        [StringLength(2000)]
        public string? ShippingDescription { get; set; }
        [Column("Shippingline Code")]
        [StringLength(12)]
        public string? ShippinglineCode { get; set; }
        [Column("Shipping Mark No")]
        [StringLength(1000)]
        public string? ShippingMarkNo { get; set; }
        [Column("Shipping Pkg")]
        [StringLength(255)]
        public string? ShippingPkg { get; set; }
        [Column("Short Booking No")]
        public int? ShortBookingNo { get; set; }
        [Column("Sign By")]
        [StringLength(50)]
        public string? SignBy { get; set; }
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
        [StringLength(20)]
        public string? SourceJobNo { get; set; }
        [Column("Source Site Code")]
        [StringLength(10)]
        public string? SourceSiteCode { get; set; }
        [Column("Stuff Agent Code")]
        [StringLength(10)]
        public string? StuffAgentCode { get; set; }
        [Column("Stuff Agent Name")]
        [StringLength(80)]
        public string? StuffAgentName { get; set; }
        [Column("Stuff Agent Address1")]
        [StringLength(45)]
        public string? StuffAgentAddress1 { get; set; }
        [Column("Stuff Agent Address2")]
        [StringLength(45)]
        public string? StuffAgentAddress2 { get; set; }
        [Column("Stuff Agent Address3")]
        [StringLength(45)]
        public string? StuffAgentAddress3 { get; set; }
        [Column("Stuff Agent Address4")]
        [StringLength(45)]
        public string? StuffAgentAddress4 { get; set; }
        [Column("Stuff Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? StuffDate { get; set; }
        [Column("Sub Master Flag")]
        [StringLength(1)]
        public string? SubMasterFlag { get; set; }
        [Column("Supplier Amt", TypeName = "decimal(12, 2)")]
        public decimal? SupplierAmt { get; set; }
        [Column("Supplier Curr Code")]
        [StringLength(50)]
        public string? SupplierCurrCode { get; set; }
        [Column("Supplier Local Amt", TypeName = "decimal(13, 2)")]
        public decimal? SupplierLocalAmt { get; set; }
        [Column("Switch Consignee Code")]
        [StringLength(10)]
        public string? SwitchConsigneeCode { get; set; }
        [Column("Switch Consignee Name")]
        [StringLength(80)]
        public string? SwitchConsigneeName { get; set; }
        [Column("Switch Consignee Address 1")]
        [StringLength(45)]
        public string? SwitchConsigneeAddress1 { get; set; }
        [Column("Switch Consignee Address 2")]
        [StringLength(45)]
        public string? SwitchConsigneeAddress2 { get; set; }
        [Column("Switch Consignee Address 3")]
        [StringLength(45)]
        public string? SwitchConsigneeAddress3 { get; set; }
        [Column("Switch Consignee Address 4")]
        [StringLength(45)]
        public string? SwitchConsigneeAddress4 { get; set; }
        [Column("Switch Delivery Agent Code")]
        [StringLength(10)]
        public string? SwitchDeliveryAgentCode { get; set; }
        [Column("Switch Delivery Agent Name")]
        [StringLength(80)]
        public string? SwitchDeliveryAgentName { get; set; }
        [Column("Switch Delivery Agent Address 1")]
        [StringLength(45)]
        public string? SwitchDeliveryAgentAddress1 { get; set; }
        [Column("Switch Delivery Agent Address 2")]
        [StringLength(45)]
        public string? SwitchDeliveryAgentAddress2 { get; set; }
        [Column("Switch Delivery Agent Address 3")]
        [StringLength(45)]
        public string? SwitchDeliveryAgentAddress3 { get; set; }
        [Column("Switch Delivery Agent Address 4")]
        [StringLength(45)]
        public string? SwitchDeliveryAgentAddress4 { get; set; }
        [Column("Switch Notify Code")]
        [StringLength(10)]
        public string? SwitchNotifyCode { get; set; }
        [Column("Switch Notify Name")]
        [StringLength(80)]
        public string? SwitchNotifyName { get; set; }
        [Column("Switch Notify Address 1")]
        [StringLength(45)]
        public string? SwitchNotifyAddress1 { get; set; }
        [Column("Switch Notify Address 2")]
        [StringLength(45)]
        public string? SwitchNotifyAddress2 { get; set; }
        [Column("Switch Notify Address 3")]
        [StringLength(45)]
        public string? SwitchNotifyAddress3 { get; set; }
        [Column("Switch Notify Address 4")]
        [StringLength(45)]
        public string? SwitchNotifyAddress4 { get; set; }
        [Column("Switch Shipper Code")]
        [StringLength(10)]
        public string? SwitchShipperCode { get; set; }
        [Column("Switch Shipper Name")]
        [StringLength(80)]
        public string? SwitchShipperName { get; set; }
        [Column("Switch Shipper Address 1")]
        [StringLength(45)]
        public string? SwitchShipperAddress1 { get; set; }
        [Column("Switch Shipper Address 2")]
        [StringLength(45)]
        public string? SwitchShipperAddress2 { get; set; }
        [Column("Switch Shipper Address 3")]
        [StringLength(45)]
        public string? SwitchShipperAddress3 { get; set; }
        [Column("Switch Shipper Address 4")]
        [StringLength(45)]
        public string? SwitchShipperAddress4 { get; set; }
        [Column("Target Company Code")]
        [StringLength(5)]
        public string? TargetCompanyCode { get; set; }
        [Column("Target Job No")]
        [StringLength(20)]
        public string? TargetJobNo { get; set; }
        [Column("Target Site Code")]
        [StringLength(10)]
        public string? TargetSiteCode { get; set; }
        [Column("Tax Cc Amt", TypeName = "decimal(13, 2)")]
        public decimal? TaxCcAmt { get; set; }
        [Column("Tax Pp Amt", TypeName = "decimal(13, 2)")]
        public decimal? TaxPpAmt { get; set; }
        [Column("Tax Refund Company Code")]
        [StringLength(10)]
        public string? TaxRefundCompanyCode { get; set; }
        [Column("Tax Refund Company  Name")]
        [StringLength(80)]
        public string? TaxRefundCompanyName { get; set; }
        [Column("Tax Refund Issue Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? TaxRefundIssueDate { get; set; }
        [Column("Tax Refund No")]
        [StringLength(20)]
        public string? TaxRefundNo { get; set; }
        [Column("Tax Refund Return Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? TaxRefundReturnDate { get; set; }
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
        [Column("Total Charge Weight", TypeName = "decimal(13, 4)")]
        public decimal? TotalChargeWeight { get; set; }
        [Column("Total Gross Weight", TypeName = "decimal(13, 4)")]
        public decimal? TotalGrossWeight { get; set; }
        [Column("Total Pcs")]
        public int? TotalPcs { get; set; }
        [Column("Total Pcs In Word")]
        [StringLength(254)]
        public string? TotalPcsInWord { get; set; }
        [Column("Total Volume", TypeName = "decimal(13, 4)")]
        public decimal? TotalVolume { get; set; }
        [Column("Transport Company Code")]
        [StringLength(10)]
        public string? TransportCompanyCode { get; set; }
        [Column("Transport Company Name")]
        [StringLength(80)]
        public string? TransportCompanyName { get; set; }
        [Column("Trucking Date ")]
        [StringLength(10)]
        [Unicode(false)]
        public string? TruckingDate { get; set; }
        [Column("Ucr No")]
        [StringLength(50)]
        public string? UcrNo { get; set; }
        [Column("Uom Code")]
        [StringLength(3)]
        public string? UomCode { get; set; }
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
        [Column("Yard Code")]
        [StringLength(10)]
        public string? YardCode { get; set; }
        [Column("Yard Name")]
        [StringLength(80)]
        public string? YardName { get; set; }
        [Column("Yard Address 1")]
        [StringLength(45)]
        public string? YardAddress1 { get; set; }
        [Column("Yard Address 2")]
        [StringLength(45)]
        public string? YardAddress2 { get; set; }
        [Column("Yard Address 3")]
        [StringLength(45)]
        public string? YardAddress3 { get; set; }
        [Column("Yard Address 4")]
        [StringLength(45)]
        public string? YardAddress4 { get; set; }
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
