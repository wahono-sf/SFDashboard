using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class SeJobInvoice
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Ata Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? AtaDate { get; set; }
        [Column("Agent Code")]
        [StringLength(10)]
        public string? AgentCode { get; set; }
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
        [Column("Also Notify Code")]
        [StringLength(10)]
        public string? AlsoNotifyCode { get; set; }
        [Column("Also Notify Name")]
        [StringLength(80)]
        public string? AlsoNotifyName { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Billing Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? BillingDate { get; set; }
        [Column("Billing Instruction")]
        [StringLength(255)]
        public string? BillingInstruction { get; set; }
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
        [Column("Bl Surrender Flag")]
        [StringLength(1)]
        public string? BlSurrenderFlag { get; set; }
        [Column("Booking No")]
        [StringLength(20)]
        public string? BookingNo { get; set; }
        [Column("Cargo Type")]
        [StringLength(5)]
        public string? CargoType { get; set; }
        [Column("Cargo Class")]
        [StringLength(10)]
        public string? CargoClass { get; set; }
        [Column("Carrier Booking Ref")]
        [StringLength(50)]
        public string? CarrierBookingRef { get; set; }
        [Column("Close Consol")]
        [StringLength(1)]
        public string? CloseConsol { get; set; }
        [Column("Close Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CloseDateTime { get; set; }
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
        [Column("Consignee Code")]
        [StringLength(10)]
        public string? ConsigneeCode { get; set; }
        [Column("Consignee Name")]
        [StringLength(80)]
        public string? ConsigneeName { get; set; }
        [Column("Container No")]
        [StringLength(500)]
        public string? ContainerNo { get; set; }
        [Column("Container Seal No")]
        [StringLength(1000)]
        public string? ContainerSealNo { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [Column("Customer Code")]
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [Column("Customer Name")]
        [StringLength(80)]
        public string? CustomerName { get; set; }
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
        [Column("Delivery Agent Code")]
        [StringLength(10)]
        public string? DeliveryAgentCode { get; set; }
        [Column("Delivery Agent Name")]
        [StringLength(80)]
        public string? DeliveryAgentName { get; set; }
        [Column("Delivery Pcs")]
        public int? DeliveryPcs { get; set; }
        [Column("Delivery Type")]
        [StringLength(5)]
        public string? DeliveryType { get; set; }
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
        [Column("Depot Code")]
        [StringLength(10)]
        public string? DepotCode { get; set; }
        [Column("Depot Name")]
        [StringLength(80)]
        public string? DepotName { get; set; }
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
        [Column("Frt Bill Party Code")]
        [StringLength(10)]
        public string? FrtBillPartyCode { get; set; }
        [Column("Frt Pp Cc Flag")]
        [StringLength(1)]
        public string? FrtPpCcFlag { get; set; }
        [Column("Goods Description")]
        [StringLength(764)]
        public string? GoodsDescription { get; set; }
        [Column("House Job No")]
        [StringLength(20)]
        public string? HouseJobNo { get; set; }
        [Column("Import Job No")]
        [StringLength(20)]
        public string? ImportJobNo { get; set; }
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
        [Column("Laden Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LadenDate { get; set; }
        [Column("Letter Of Credit No")]
        [StringLength(50)]
        public string? LetterOfCreditNo { get; set; }
        [Column("Lot No")]
        [StringLength(50)]
        public string? LotNo { get; set; }
        [Column("Mark No")]
        [StringLength(50)]
        public string? MarkNo { get; set; }
        [Column("Master Job No")]
        [StringLength(20)]
        public string? MasterJobNo { get; set; }
        [Column("Max Gross Weight", TypeName = "decimal(13, 4)")]
        public decimal? MaxGrossWeight { get; set; }
        [Column("Max Volume", TypeName = "decimal(13, 4)")]
        public decimal? MaxVolume { get; set; }
        [Column("No Of 20ft Container")]
        public int? NoOf20ftContainer { get; set; }
        [Column("No Of 40ft Container")]
        public int? NoOf40ftContainer { get; set; }
        [Column("No Of 45ft Container")]
        public int? NoOf45ftContainer { get; set; }
        [Column("No Of Origin Bl")]
        public byte? NoOfOriginBl { get; set; }
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
        [Column("Notify Code")]
        [StringLength(10)]
        public string? NotifyCode { get; set; }
        [Column("Notify Name")]
        [StringLength(80)]
        public string? NotifyName { get; set; }
        [Column("O Bl No")]
        [StringLength(20)]
        public string? OBlNo { get; set; }
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
        [Column("Principle Agent Code")]
        [StringLength(12)]
        public string? PrincipleAgentCode { get; set; }
        [Column("Print Count")]
        public byte? PrintCount { get; set; }
        [Column("Quotation No")]
        [StringLength(15)]
        public string? QuotationNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Salesman Code")]
        [StringLength(10)]
        public string? SalesmanCode { get; set; }
        [Column("Scn Code")]
        [StringLength(10)]
        public string? ScnCode { get; set; }
        [Column("Second Via Port Code")]
        [StringLength(5)]
        public string? SecondViaPortCode { get; set; }
        [Column("Shipment Type")]
        [StringLength(1)]
        public string? ShipmentType { get; set; }
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
        [Column("Shipper Code")]
        [StringLength(10)]
        public string? ShipperCode { get; set; }
        [Column("Shipper Count Flag")]
        [StringLength(1)]
        public string? ShipperCountFlag { get; set; }
        [Column("Shipper Name")]
        [StringLength(80)]
        public string? ShipperName { get; set; }
        [Column("Shipping Description")]
        [StringLength(2000)]
        public string? ShippingDescription { get; set; }
        [Column("Shipping Pkg")]
        [StringLength(255)]
        public string? ShippingPkg { get; set; }
        [Column("Shippingline Code")]
        [StringLength(12)]
        public string? ShippinglineCode { get; set; }
        [Column("Shipping Mark No")]
        [StringLength(1000)]
        public string? ShippingMarkNo { get; set; }
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
        [Column("Stuff Agent Code")]
        [StringLength(10)]
        public string? StuffAgentCode { get; set; }
        [Column("Stuff Agent Name")]
        [StringLength(80)]
        public string? StuffAgentName { get; set; }
        [Column("Stuff Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? StuffDate { get; set; }
        [Column("Sub Master Flag")]
        [StringLength(1)]
        public string? SubMasterFlag { get; set; }
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
        [Column("Tax Refund Company Name")]
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
        [Column("Trx No In String")]
        [StringLength(30)]
        [Unicode(false)]
        public string? TrxNoInString { get; set; }
        [Column("Ucr No")]
        [StringLength(50)]
        public string? UcrNo { get; set; }
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
        [Column("Voyage Id")]
        [StringLength(10)]
        public string? VoyageId { get; set; }
        [Column("Voyage No")]
        [StringLength(20)]
        public string? VoyageNo { get; set; }
        [Column("Work Station")]
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
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
        [Column("Invoice Trx No")]
        public int? InvoiceTrxNo { get; set; }
        [Column("Acc Code")]
        [StringLength(15)]
        public string? AccCode { get; set; }
        [Column("Address 1")]
        [StringLength(45)]
        public string? Address1 { get; set; }
        [Column("Address 2")]
        [StringLength(45)]
        public string? Address2 { get; set; }
        [Column("Address 3")]
        [StringLength(45)]
        public string? Address3 { get; set; }
        [Column("Address 4")]
        [StringLength(45)]
        public string? Address4 { get; set; }
        [Column("Apply To Invoice")]
        [StringLength(20)]
        public string? ApplyToInvoice { get; set; }
        [Column("Attn Name")]
        [StringLength(50)]
        public string? AttnName { get; set; }
        [Column("Billing Party Code")]
        [StringLength(10)]
        public string? BillingPartyCode { get; set; }
        [Column("Cash Amt", TypeName = "decimal(13, 2)")]
        public decimal? CashAmt { get; set; }
        [Column("Cash Local Amt", TypeName = "decimal(13, 2)")]
        public decimal? CashLocalAmt { get; set; }
        [Column("Charge Rate", TypeName = "decimal(13, 5)")]
        public decimal? ChargeRate { get; set; }
        [Column("Charge Weight", TypeName = "decimal(13, 4)")]
        public decimal? ChargeWeight { get; set; }
        [Column("Cheque Amt", TypeName = "decimal(13, 2)")]
        public decimal? ChequeAmt { get; set; }
        [Column("Cheque Local Amt", TypeName = "decimal(13, 2)")]
        public decimal? ChequeLocalAmt { get; set; }
        [Column("Cheque No")]
        [StringLength(18)]
        public string? ChequeNo { get; set; }
        [Column("Collect By")]
        [StringLength(50)]
        public string? CollectBy { get; set; }
        [Column("Invoice Curr Code")]
        [StringLength(3)]
        public string? InvoiceCurrCode { get; set; }
        [Column("Invoice Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? InvoiceCurrRate { get; set; }
        [Column("Invoice Customer Code")]
        [StringLength(10)]
        public string? InvoiceCustomerCode { get; set; }
        [Column("Invoice Customer Name")]
        [StringLength(50)]
        public string? InvoiceCustomerName { get; set; }
        [Column("Due Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? DueDate { get; set; }
        [Column("Invoice Edi Count")]
        public byte? InvoiceEdiCount { get; set; }
        [Column("Invoice Email Count")]
        public byte? InvoiceEmailCount { get; set; }
        [Column("Invoice Export Count")]
        public byte? InvoiceExportCount { get; set; }
        [Column("Invoice Fax Count")]
        public byte? InvoiceFaxCount { get; set; }
        [Column("Goods Description 1")]
        [StringLength(50)]
        public string? GoodsDescription1 { get; set; }
        [Column("Goods Description 2")]
        [StringLength(50)]
        public string? GoodsDescription2 { get; set; }
        [Column("Goods Description 3")]
        [StringLength(50)]
        public string? GoodsDescription3 { get; set; }
        [Column("Goods Description 4")]
        [StringLength(50)]
        public string? GoodsDescription4 { get; set; }
        [Column("Gross Profit", TypeName = "decimal(13, 2)")]
        public decimal? GrossProfit { get; set; }
        [Column("Invoice Amt", TypeName = "decimal(13, 2)")]
        public decimal? InvoiceAmt { get; set; }
        [Column("Invoice And Vat Amt", TypeName = "decimal(13, 2)")]
        public decimal? InvoiceAndVatAmt { get; set; }
        [Column("Invoice And Vat Local Amt", TypeName = "decimal(13, 2)")]
        public decimal? InvoiceAndVatLocalAmt { get; set; }
        [Column("Invoice Cost Amt", TypeName = "decimal(13, 2)")]
        public decimal? InvoiceCostAmt { get; set; }
        [Column("Invoice Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? InvoiceDate { get; set; }
        [Column("Invoice Local Amt", TypeName = "decimal(13, 2)")]
        public decimal? InvoiceLocalAmt { get; set; }
        [Column("Invoice No")]
        [StringLength(20)]
        public string? InvoiceNo { get; set; }
        [Column("Invoice Type")]
        [StringLength(1)]
        public string? InvoiceType { get; set; }
        [Column("Our Ref")]
        [StringLength(24)]
        public string? OurRef { get; set; }
        [Column("Postal Code")]
        [StringLength(10)]
        public string? PostalCode { get; set; }
        [Column("Post Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? PostDate { get; set; }
        [Column("Post Flag")]
        [StringLength(1)]
        public string? PostFlag { get; set; }
        [Column("Post Mth")]
        [StringLength(6)]
        public string? PostMth { get; set; }
        [Column("Pp Cc Flag")]
        [StringLength(1)]
        public string? PpCcFlag { get; set; }
        [Column("Invoice Print Count")]
        public byte? InvoicePrintCount { get; set; }
        [Column("Invoice Remark")]
        [StringLength(255)]
        public string? InvoiceRemark { get; set; }
        [StringLength(30)]
        public string? Telephone { get; set; }
        [Column("Term Code")]
        [StringLength(3)]
        public string? TermCode { get; set; }
        [Column("Total Exm Amt", TypeName = "decimal(13, 2)")]
        public decimal? TotalExmAmt { get; set; }
        [Column("Total Local Vat Amt", TypeName = "decimal(13, 2)")]
        public decimal? TotalLocalVatAmt { get; set; }
        [Column("Total Std Amt", TypeName = "decimal(13, 2)")]
        public decimal? TotalStdAmt { get; set; }
        [Column("Total Vat Amt", TypeName = "decimal(13, 2)")]
        public decimal? TotalVatAmt { get; set; }
        [Column("Total Zero Amt", TypeName = "decimal(13, 2)")]
        public decimal? TotalZeroAmt { get; set; }
        [Column("Trx Type")]
        [StringLength(1)]
        public string? TrxType { get; set; }
        [Column("With Holding Tax Amt", TypeName = "decimal(13, 2)")]
        public decimal? WithHoldingTaxAmt { get; set; }
        [Column("With Holding Tax No")]
        [StringLength(20)]
        public string? WithHoldingTaxNo { get; set; }
        [Column("Your Ref")]
        [StringLength(24)]
        public string? YourRef { get; set; }
        [Column("Invoice Created By")]
        [StringLength(50)]
        public string? InvoiceCreatedBy { get; set; }
        [Column("Invoice Created At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? InvoiceCreatedAt { get; set; }
        [Column("Invoice Updated By")]
        [StringLength(50)]
        public string? InvoiceUpdatedBy { get; set; }
        [Column("Invoice Updated At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? InvoiceUpdatedAt { get; set; }
        [Column("Invoice Status")]
        [StringLength(3)]
        public string? InvoiceStatus { get; set; }
    }
}
