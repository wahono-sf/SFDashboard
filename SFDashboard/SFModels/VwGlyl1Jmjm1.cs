using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwGlyl1Jmjm1
    {
        [Column("Acc Code")]
        [StringLength(15)]
        public string? AccCode { get; set; }
        [Column("Acc Description")]
        [StringLength(50)]
        public string? AccDescription { get; set; }
        [Column("Agent Sell Amt", TypeName = "decimal(20, 2)")]
        public decimal? AgentSellAmt { get; set; }
        [Column("Also Notify Party Code")]
        [StringLength(10)]
        public string? AlsoNotifyPartyCode { get; set; }
        [Column("Also Notify Party Name")]
        [StringLength(80)]
        public string? AlsoNotifyPartyName { get; set; }
        [Column(TypeName = "decimal(20, 2)")]
        public decimal? Amt { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Bank Slip Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? BankSlipDate { get; set; }
        [Column("Bank Slip No")]
        [StringLength(10)]
        public string? BankSlipNo { get; set; }
        [Column("Branch Code")]
        [StringLength(10)]
        public string? BranchCode { get; set; }
        [Column("Cheque Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ChequeDate { get; set; }
        [Column("Cheque No")]
        [StringLength(20)]
        public string? ChequeNo { get; set; }
        [Column("Clear Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ClearDate { get; set; }
        [Column("Contract Code")]
        [StringLength(20)]
        public string? ContractCode { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [Column("Customer Or Vendor Code")]
        [StringLength(10)]
        public string? CustomerOrVendorCode { get; set; }
        [Column("Customer Or Vendor Name")]
        [StringLength(80)]
        public string? CustomerOrVendorName { get; set; }
        [Column("Department Code")]
        [StringLength(10)]
        public string? DepartmentCode { get; set; }
        [StringLength(255)]
        public string? Description { get; set; }
        [Column("Financial Year")]
        [StringLength(4)]
        public string? FinancialYear { get; set; }
        [Column("H Awb Or H Bl No")]
        [StringLength(30)]
        public string? HAwbOrHBlNo { get; set; }
        [Column("Invoice Cheque No")]
        [StringLength(20)]
        public string? InvoiceChequeNo { get; set; }
        [Column("Item Code")]
        [StringLength(30)]
        public string? ItemCode { get; set; }
        [Column("Job Item Trx No")]
        public int? JobItemTrxNo { get; set; }
        [Column("Job No")]
        [StringLength(30)]
        public string? JobNo { get; set; }
        [Column("Journal Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? JournalDate { get; set; }
        [Column("Journal No")]
        [StringLength(20)]
        public string? JournalNo { get; set; }
        [Column("Journal Type")]
        [StringLength(3)]
        public string? JournalType { get; set; }
        [Column("Line Item No")]
        public int? LineItemNo { get; set; }
        [Column("Local Amt", TypeName = "decimal(20, 2)")]
        public decimal? LocalAmt { get; set; }
        [Column("M Awb Or O Bl No")]
        [StringLength(30)]
        public string? MAwbOrOBlNo { get; set; }
        [Column("Post Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? PostDate { get; set; }
        [Column("Post Mth")]
        [StringLength(6)]
        public string? PostMth { get; set; }
        [Column("Receipt Or Voucher No")]
        [StringLength(20)]
        public string? ReceiptOrVoucherNo { get; set; }
        [Column("Reconcil Flag")]
        [StringLength(1)]
        public string? ReconcilFlag { get; set; }
        [StringLength(20)]
        public string? Reference { get; set; }
        [Column("Ref No")]
        [StringLength(10)]
        public string? RefNo { get; set; }
        [StringLength(1000)]
        public string? Remark { get; set; }
        [Column("Trx Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? TrxDate { get; set; }
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Trx Type")]
        [StringLength(1)]
        public string? TrxType { get; set; }
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
        [Column("Airline Code")]
        [StringLength(3)]
        public string? AirlineCode { get; set; }
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
        [Column("AJU")]
        [StringLength(50)]
        public string? Aju { get; set; }
        [Column("Job Attachment Flag")]
        [StringLength(1)]
        public string? JobAttachmentFlag { get; set; }
        [Column("Awb Bl No")]
        [StringLength(30)]
        public string? AwbBlNo { get; set; }
        [Column("Awb Bl Status")]
        [StringLength(1)]
        public string? AwbBlStatus { get; set; }
        [Column("Awb Bl Type")]
        [StringLength(50)]
        public string? AwbBlType { get; set; }
        [Column("BC 1.1")]
        [StringLength(50)]
        public string? Bc11 { get; set; }
        [Column("BC 20/2.3")]
        [StringLength(50)]
        public string? Bc2023 { get; set; }
        [Column("Billing Flag")]
        [StringLength(1)]
        public string? BillingFlag { get; set; }
        [Column("Billing instruction")]
        [StringLength(255)]
        public string? BillingInstruction { get; set; }
        [Column("Billing Remark")]
        [StringLength(255)]
        public string? BillingRemark { get; set; }
        [Column("Business Party Salesman Code")]
        [StringLength(10)]
        public string? BusinessPartySalesmanCode { get; set; }
        [Column("Cargo Desciption")]
        [StringLength(100)]
        public string? CargoDesciption { get; set; }
        [Column("Cargo Type")]
        [StringLength(5)]
        public string? CargoType { get; set; }
        [Column("Carrier Name")]
        [StringLength(80)]
        public string? CarrierName { get; set; }
        [Column("Charge Rate", TypeName = "decimal(13, 2)")]
        public decimal? ChargeRate { get; set; }
        [Column("Charge Weight", TypeName = "decimal(13, 4)")]
        public decimal? ChargeWeight { get; set; }
        [Column("Close Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CloseDateTime { get; set; }
        [Column("Close Job By")]
        [StringLength(50)]
        public string? CloseJobBy { get; set; }
        [Column("Close Job Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CloseJobDateTime { get; set; }
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
        [Column("Collection Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CollectionDateTime { get; set; }
        [Column("Collection From Place")]
        [StringLength(10)]
        public string? CollectionFromPlace { get; set; }
        [Column("Coloader Code")]
        [StringLength(10)]
        public string? ColoaderCode { get; set; }
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
        [Column("Cost Amt", TypeName = "decimal(13, 2)")]
        public decimal? CostAmt { get; set; }
        [Column("Cost Charge Weight", TypeName = "decimal(18, 9)")]
        public decimal? CostChargeWeight { get; set; }
        [Column("Costing Approve Flag")]
        [StringLength(1)]
        public string? CostingApproveFlag { get; set; }
        [Column("Country Code")]
        [StringLength(2)]
        public string? CountryCode { get; set; }
        [Column("Custom Approve Flag")]
        [StringLength(1)]
        public string? CustomApproveFlag { get; set; }
        [Column("Custom Brokerage Flag")]
        [StringLength(1)]
        public string? CustomBrokerageFlag { get; set; }
        [Column("Customer Code")]
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [Column("Customer Name")]
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [Column("Customer Ref No")]
        [StringLength(50)]
        public string? CustomerRefNo { get; set; }
        [Column("Delivery Agent Code")]
        [StringLength(10)]
        public string? DeliveryAgentCode { get; set; }
        [Column("Delivery Agent Name")]
        [StringLength(80)]
        public string? DeliveryAgentName { get; set; }
        [Column("Delivery Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? DeliveryDateTime { get; set; }
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
        [Column("Delivery Term")]
        [StringLength(20)]
        public string? DeliveryTerm { get; set; }
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
        [Column("Dest Code")]
        [StringLength(3)]
        public string? DestCode { get; set; }
        [Column("Dest Name")]
        [StringLength(45)]
        public string? DestName { get; set; }
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
        [Column("EDI Remark")]
        [StringLength(50)]
        public string? EdiRemark { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? Eta { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? Etd { get; set; }
        [Column("Export Job No")]
        [StringLength(30)]
        public string? ExportJobNo { get; set; }
        [Column("Feeder Vessel Name")]
        [StringLength(50)]
        public string? FeederVesselName { get; set; }
        [Column("Feeder Voyage")]
        [StringLength(20)]
        public string? FeederVoyage { get; set; }
        [Column("First Via Port Code")]
        [StringLength(5)]
        public string? FirstViaPortCode { get; set; }
        [Column("Flight Or Voyage No")]
        [StringLength(20)]
        public string? FlightOrVoyageNo { get; set; }
        [Column("Free Time")]
        [StringLength(50)]
        public string? FreeTime { get; set; }
        [Column("Frt Pp Cc Flag")]
        [StringLength(1)]
        public string? FrtPpCcFlag { get; set; }
        [Column("General Remark")]
        [StringLength(255)]
        public string? GeneralRemark { get; set; }
        [Column("Generating BB Fee Flag")]
        [StringLength(1)]
        public string? GeneratingBbFeeFlag { get; set; }
        [Column("Gross Profit", TypeName = "decimal(13, 2)")]
        public decimal? GrossProfit { get; set; }
        [Column("Gross Weight", TypeName = "decimal(13, 4)")]
        public decimal? GrossWeight { get; set; }
        [Column("H Awb Hbl No")]
        [StringLength(30)]
        public string? HAwbHblNo { get; set; }
        [Column("House Seq No")]
        [StringLength(10)]
        public string? HouseSeqNo { get; set; }
        [Column("Import Job No")]
        [StringLength(30)]
        public string? ImportJobNo { get; set; }
        [Column("Invoice Complete Flag")]
        [StringLength(1)]
        public string? InvoiceCompleteFlag { get; set; }
        [Column("Invoice Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? InvoiceDate { get; set; }
        [Column("Invoice Local Amt", TypeName = "decimal(38, 2)")]
        public decimal? InvoiceLocalAmt { get; set; }
        [Column("Invoice No")]
        [StringLength(20)]
        public string? InvoiceNo { get; set; }
        [Column("Job Costing Remark")]
        [StringLength(255)]
        public string? JobCostingRemark { get; set; }
        [Column("Job Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? JobDate { get; set; }
        [Column("Job Mth")]
        [StringLength(6)]
        public string? JobMth { get; set; }
        [Column("Job Seq No")]
        [StringLength(30)]
        public string? JobSeqNo { get; set; }
        [Column("Job Status")]
        [StringLength(4)]
        public string? JobStatus { get; set; }
        [Column("Job Type")]
        [StringLength(10)]
        public string? JobType { get; set; }
        [Column("Linking To Auto Job")]
        [StringLength(1)]
        public string? LinkingToAutoJob { get; set; }
        [Column("Local Job Flag")]
        [StringLength(1)]
        public string? LocalJobFlag { get; set; }
        [Column("Lock Document Flag")]
        [StringLength(1)]
        public string? LockDocumentFlag { get; set; }
        [Column("Mark No")]
        [StringLength(50)]
        public string? MarkNo { get; set; }
        [Column("Master Job No")]
        [StringLength(30)]
        public string? MasterJobNo { get; set; }
        [Column("M Awb Obl No")]
        [StringLength(30)]
        public string? MAwbOblNo { get; set; }
        [Column("Misc Flag")]
        [StringLength(1)]
        public string? MiscFlag { get; set; }
        [Column("Module Code")]
        [StringLength(2)]
        public string? ModuleCode { get; set; }
        [Column("Mother Vessel Name")]
        [StringLength(50)]
        public string? MotherVesselName { get; set; }
        [Column("Mother Voyage")]
        [StringLength(20)]
        public string? MotherVoyage { get; set; }
        [Column("Multi Modal Flag")]
        [StringLength(1)]
        public string? MultiModalFlag { get; set; }
        [Column("Multi Modal Job No")]
        [StringLength(30)]
        public string? MultiModalJobNo { get; set; }
        [Column("Nomination Flag")]
        [StringLength(1)]
        public string? NominationFlag { get; set; }
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
        [StringLength(255)]
        public string? Note { get; set; }
        [Column("Notify Party Code")]
        [StringLength(10)]
        public string? NotifyPartyCode { get; set; }
        [Column("Notify Party Name")]
        [StringLength(80)]
        public string? NotifyPartyName { get; set; }
        [Column("Order No")]
        public string? OrderNo { get; set; }
        [Column("Origin Code")]
        [StringLength(3)]
        public string? OriginCode { get; set; }
        [Column("Origin Name")]
        [StringLength(45)]
        public string? OriginName { get; set; }
        [Column("Original Job No")]
        [StringLength(30)]
        public string? OriginalJobNo { get; set; }
        [Column("Other Pp Cc Flag")]
        [StringLength(1)]
        public string? OtherPpCcFlag { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Payment { get; set; }
        [Column("Payment Remark")]
        [StringLength(255)]
        public string? PaymentRemark { get; set; }
        [Column("Payment Instruction")]
        [StringLength(255)]
        public string? PaymentInstruction { get; set; }
        public int? Pcs { get; set; }
        [Column("Permit No")]
        [StringLength(260)]
        public string? PermitNo { get; set; }
        [StringLength(10)]
        public string? Place { get; set; }
        [Column("Plexis On Hand No")]
        [StringLength(30)]
        public string? PlexisOnHandNo { get; set; }
        [Column("Port Of Discharge Code")]
        [StringLength(5)]
        public string? PortOfDischargeCode { get; set; }
        [Column("Port Of Discharge Name")]
        [StringLength(45)]
        public string? PortOfDischargeName { get; set; }
        [Column("Port Of Loading")]
        [StringLength(5)]
        public string? PortOfLoading { get; set; }
        [Column("Port Of Loading Name")]
        [StringLength(45)]
        public string? PortOfLoadingName { get; set; }
        [Column("Post Flag")]
        [StringLength(1)]
        public string? PostFlag { get; set; }
        [Column("Pp Cc Flag")]
        [StringLength(1)]
        public string? PpCcFlag { get; set; }
        [Column("Product Code")]
        [StringLength(10)]
        public string? ProductCode { get; set; }
        [Column("Provision Cost Amt", TypeName = "decimal(13, 2)")]
        public decimal? ProvisionCostAmt { get; set; }
        [Column("Purchase Amt", TypeName = "decimal(13, 2)")]
        public decimal? PurchaseAmt { get; set; }
        [Column("Purchase Order No")]
        public string? PurchaseOrderNo { get; set; }
        [Column("Receipt Amt", TypeName = "decimal(13, 2)")]
        public decimal? ReceiptAmt { get; set; }
        [Column("Job Remark")]
        [StringLength(255)]
        public string? JobRemark { get; set; }
        [Column("Sales Amt", TypeName = "decimal(13, 2)")]
        public decimal? SalesAmt { get; set; }
        [Column("Sales Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? SalesDate { get; set; }
        [Column("Salesman Code")]
        [StringLength(10)]
        public string? SalesmanCode { get; set; }
        [Column("Shipment Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ShipmentDate { get; set; }
        [Column("Shipment Type")]
        [StringLength(2)]
        public string? ShipmentType { get; set; }
        [Column("Shipper Code")]
        [StringLength(10)]
        public string? ShipperCode { get; set; }
        [Column("Shipper Name")]
        [StringLength(80)]
        public string? ShipperName { get; set; }
        [Column("Shippingline Code")]
        [StringLength(12)]
        public string? ShippinglineCode { get; set; }
        [Column("Source Job No")]
        [StringLength(30)]
        public string? SourceJobNo { get; set; }
        [Column("Source Site Code")]
        [StringLength(20)]
        public string? SourceSiteCode { get; set; }
        [Column("Sub Master Flag")]
        [StringLength(1)]
        public string? SubMasterFlag { get; set; }
        [Column("Suspense Invoice Agent Flag")]
        [StringLength(1)]
        public string? SuspenseInvoiceAgentFlag { get; set; }
        [Column("Suspense Invoice Airline Flag")]
        [StringLength(1)]
        public string? SuspenseInvoiceAirlineFlag { get; set; }
        [Column("Template Name")]
        [StringLength(50)]
        public string? TemplateName { get; set; }
        [Column("Term Code")]
        [StringLength(3)]
        public string? TermCode { get; set; }
        [Column("Total Container")]
        [StringLength(50)]
        public string? TotalContainer { get; set; }
        [Column("Total Packages")]
        [StringLength(50)]
        public string? TotalPackages { get; set; }
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
        [Column("Transport Job No")]
        [StringLength(30)]
        public string? TransportJobNo { get; set; }
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
        [Column("User Define 21")]
        [StringLength(255)]
        public string? UserDefine21 { get; set; }
        [Column("User Define 22")]
        [StringLength(255)]
        public string? UserDefine22 { get; set; }
        [Column("User Define 23")]
        [StringLength(255)]
        public string? UserDefine23 { get; set; }
        [Column("User Define 24")]
        [StringLength(255)]
        public string? UserDefine24 { get; set; }
        [Column("User Define 25")]
        [StringLength(255)]
        public string? UserDefine25 { get; set; }
        [Column("User Define 26")]
        [StringLength(255)]
        public string? UserDefine26 { get; set; }
        [Column("User Define 27")]
        [StringLength(255)]
        public string? UserDefine27 { get; set; }
        [Column("User Define 28")]
        [StringLength(255)]
        public string? UserDefine28 { get; set; }
        [Column("User Define 29")]
        [StringLength(255)]
        public string? UserDefine29 { get; set; }
        [Column("User Define 30")]
        [StringLength(255)]
        public string? UserDefine30 { get; set; }
        [Column("User Define 31")]
        [StringLength(255)]
        public string? UserDefine31 { get; set; }
        [Column("User Define 32")]
        [StringLength(255)]
        public string? UserDefine32 { get; set; }
        [Column("User Define 33")]
        [StringLength(255)]
        public string? UserDefine33 { get; set; }
        [Column("User Define 34")]
        [StringLength(255)]
        public string? UserDefine34 { get; set; }
        [Column("User Define 35")]
        [StringLength(255)]
        public string? UserDefine35 { get; set; }
        [Column("User Define 36")]
        [StringLength(255)]
        public string? UserDefine36 { get; set; }
        [Column("User Define 37")]
        [StringLength(255)]
        public string? UserDefine37 { get; set; }
        [Column("User Define 38")]
        [StringLength(255)]
        public string? UserDefine38 { get; set; }
        [Column("User Define 39")]
        [StringLength(255)]
        public string? UserDefine39 { get; set; }
        [Column("User Define 40")]
        [StringLength(255)]
        public string? UserDefine40 { get; set; }
        [Column("User Define 41")]
        [StringLength(255)]
        public string? UserDefine41 { get; set; }
        [Column("User Define 42")]
        [StringLength(255)]
        public string? UserDefine42 { get; set; }
        [Column("User Define 43")]
        [StringLength(255)]
        public string? UserDefine43 { get; set; }
        [Column("User Define 44")]
        [StringLength(255)]
        public string? UserDefine44 { get; set; }
        [Column("User Define 45")]
        [StringLength(255)]
        public string? UserDefine45 { get; set; }
        [Column("User Define 46")]
        [StringLength(255)]
        public string? UserDefine46 { get; set; }
        [Column("User Define 47")]
        [StringLength(255)]
        public string? UserDefine47 { get; set; }
        [Column("User Define 48")]
        [StringLength(255)]
        public string? UserDefine48 { get; set; }
        [Column("User Define 49")]
        [StringLength(255)]
        public string? UserDefine49 { get; set; }
        [Column("User Define 50")]
        [StringLength(255)]
        public string? UserDefine50 { get; set; }
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
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Volume { get; set; }
        [Column("Voyage No")]
        [StringLength(20)]
        public string? VoyageNo { get; set; }
        [Column("Work Station")]
        [StringLength(50)]
        public string? WorkStation { get; set; }
        [Column("Original Branch Code")]
        [StringLength(10)]
        public string? OriginalBranchCode { get; set; }
        [Column("Original Department Code")]
        [StringLength(10)]
        public string? OriginalDepartmentCode { get; set; }
        [Column("Job Branch Code")]
        [StringLength(10)]
        public string? JobBranchCode { get; set; }
        [Column("Job Department Code")]
        [StringLength(10)]
        public string? JobDepartmentCode { get; set; }
    }
}
