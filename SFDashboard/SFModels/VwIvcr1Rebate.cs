using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwIvcr1Rebate
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Acc Code")]
        [StringLength(15)]
        public string? AccCode { get; set; }
        [Column("Acknowledgement Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? AcknowledgementDate { get; set; }
        [Column("Actual Bill Collector Code")]
        [StringLength(10)]
        public string? ActualBillCollectorCode { get; set; }
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
        [Column("Apply To Invoice")]
        [StringLength(20)]
        public string? ApplyToInvoice { get; set; }
        [Column("Approve By")]
        [StringLength(50)]
        public string? ApproveBy { get; set; }
        [Column("Approve Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ApproveDate { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Attn Name")]
        [StringLength(50)]
        public string? AttnName { get; set; }
        [Column("Awb Or Bl No")]
        [StringLength(30)]
        public string? AwbOrBlNo { get; set; }
        [Column("Bank Code")]
        [StringLength(10)]
        public string? BankCode { get; set; }
        [Column("Bill Collector Code")]
        [StringLength(10)]
        public string? BillCollectorCode { get; set; }
        [Column("Billing Party Code")]
        [StringLength(10)]
        public string? BillingPartyCode { get; set; }
        [Column("Cash Amt", TypeName = "decimal(17, 2)")]
        public decimal? CashAmt { get; set; }
        [Column("Cash Local Amt", TypeName = "decimal(17, 2)")]
        public decimal? CashLocalAmt { get; set; }
        [Column("Charge Rate", TypeName = "decimal(13, 5)")]
        public decimal? ChargeRate { get; set; }
        [Column("Charge Weight", TypeName = "decimal(13, 4)")]
        public decimal? ChargeWeight { get; set; }
        [Column("Cheque Amt", TypeName = "decimal(17, 2)")]
        public decimal? ChequeAmt { get; set; }
        [Column("Cheque Local Amt", TypeName = "decimal(17, 2)")]
        public decimal? ChequeLocalAmt { get; set; }
        [Column("Cheque No")]
        [StringLength(20)]
        public string? ChequeNo { get; set; }
        [Column("Clear Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ClearDate { get; set; }
        [Column("Collect By")]
        [StringLength(50)]
        public string? CollectBy { get; set; }
        [Column("Commodity Code")]
        [StringLength(50)]
        public string? CommodityCode { get; set; }
        [Column("Consignee Code")]
        [StringLength(10)]
        public string? ConsigneeCode { get; set; }
        [Column("Consignee Name")]
        [StringLength(80)]
        public string? ConsigneeName { get; set; }
        [Column("Console Flag")]
        [StringLength(1)]
        public string? ConsoleFlag { get; set; }
        [Column("Copy Template Name")]
        [StringLength(50)]
        public string? CopyTemplateName { get; set; }
        [Column("Copy Template Remark")]
        [StringLength(255)]
        public string? CopyTemplateRemark { get; set; }
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
        [Column("Customer Ref No")]
        [StringLength(50)]
        public string? CustomerRefNo { get; set; }
        [Column("Delivery Agent Code")]
        [StringLength(10)]
        public string? DeliveryAgentCode { get; set; }
        [Column("Dest Code")]
        [StringLength(3)]
        public string? DestCode { get; set; }
        [Column("Dest Name")]
        [StringLength(45)]
        public string? DestName { get; set; }
        [Column("District Code")]
        [StringLength(5)]
        public string? DistrictCode { get; set; }
        [Column("Division Code")]
        [StringLength(10)]
        public string? DivisionCode { get; set; }
        [Column("Doc Remark")]
        [StringLength(255)]
        public string? DocRemark { get; set; }
        [Column("Due Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? DueDate { get; set; }
        [Column("EDI Count")]
        public byte? EdiCount { get; set; }
        [Column("EDI Remark")]
        [StringLength(50)]
        public string? EdiRemark { get; set; }
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
        [StringLength(30)]
        public string? Fax { get; set; }
        [Column("Fax Count")]
        public byte? FaxCount { get; set; }
        [Column("Feeder Vessel Name")]
        [StringLength(30)]
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
        [Column("Goods Description 1")]
        [StringLength(80)]
        public string? GoodsDescription1 { get; set; }
        [Column("Goods Description 2")]
        [StringLength(80)]
        public string? GoodsDescription2 { get; set; }
        [Column("Goods Description 3")]
        [StringLength(80)]
        public string? GoodsDescription3 { get; set; }
        [Column("Goods Description 4")]
        [StringLength(80)]
        public string? GoodsDescription4 { get; set; }
        [Column("Goods Description 5")]
        [StringLength(80)]
        public string? GoodsDescription5 { get; set; }
        [Column("Goods Description 6")]
        [StringLength(80)]
        public string? GoodsDescription6 { get; set; }
        [Column("Goods Description 7")]
        [StringLength(80)]
        public string? GoodsDescription7 { get; set; }
        [Column("Goods Description 8")]
        [StringLength(80)]
        public string? GoodsDescription8 { get; set; }
        [Column("Goods Description 9")]
        [StringLength(80)]
        public string? GoodsDescription9 { get; set; }
        [Column("Gross Profit", TypeName = "decimal(17, 2)")]
        public decimal? GrossProfit { get; set; }
        [Column("Gross Weight", TypeName = "decimal(13, 4)")]
        public decimal? GrossWeight { get; set; }
        [Column("Group Invoice Create By")]
        [StringLength(50)]
        public string? GroupInvoiceCreateBy { get; set; }
        [Column("Group Invoice Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? GroupInvoiceDate { get; set; }
        [Column("H Awb Or H Bl No")]
        [StringLength(30)]
        public string? HAwbOrHBlNo { get; set; }
        [Column("Invoice Amt", TypeName = "decimal(17, 2)")]
        public decimal? InvoiceAmt { get; set; }
        [Column("Invoice And Vat Amt", TypeName = "decimal(17, 2)")]
        public decimal? InvoiceAndVatAmt { get; set; }
        [Column("Invoice And Vat Local Amt", TypeName = "decimal(17, 2)")]
        public decimal? InvoiceAndVatLocalAmt { get; set; }
        [Column("Invoice Cost Amt", TypeName = "decimal(17, 2)")]
        public decimal? InvoiceCostAmt { get; set; }
        [Column("Invoice Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? InvoiceDate { get; set; }
        [Column("Invoice Local Amt", TypeName = "decimal(17, 2)")]
        public decimal? InvoiceLocalAmt { get; set; }
        [Column("Invoice No")]
        [StringLength(20)]
        public string? InvoiceNo { get; set; }
        [Column("Invoice Type")]
        [StringLength(1)]
        [Unicode(false)]
        public string InvoiceType { get; set; } = null!;
        [Column("Job Customer Code")]
        [StringLength(10)]
        public string? JobCustomerCode { get; set; }
        [Column("Job Mth")]
        [StringLength(6)]
        public string? JobMth { get; set; }
        [Column("Job No")]
        [StringLength(30)]
        public string? JobNo { get; set; }
        [Column("Job Seq No")]
        [StringLength(30)]
        public string? JobSeqNo { get; set; }
        [Column("Job Type")]
        [StringLength(10)]
        public string? JobType { get; set; }
        [Column("Letter Of Credit No")]
        [StringLength(15)]
        public string? LetterOfCreditNo { get; set; }
        [StringLength(2)]
        public string? Location { get; set; }
        [Column("M Awb Or O Bl No")]
        [StringLength(30)]
        public string? MAwbOrOBlNo { get; set; }
        [Column("Misc Flag")]
        [StringLength(1)]
        public string? MiscFlag { get; set; }
        [Column("Module Code")]
        [StringLength(2)]
        public string? ModuleCode { get; set; }
        [Column("No Of 20ft Container")]
        public int? NoOf20ftContainer { get; set; }
        [Column("No Of 40ft Container")]
        public int? NoOf40ftContainer { get; set; }
        [Column("No Of 45ft Container")]
        public int? NoOf45ftContainer { get; set; }
        [Column("No Of Billing Day")]
        public int? NoOfBillingDay { get; set; }
        [Column("Origin Code")]
        [StringLength(3)]
        public string? OriginCode { get; set; }
        [Column("Origin Name")]
        [StringLength(45)]
        public string? OriginName { get; set; }
        [Column("Our Ref")]
        [StringLength(24)]
        public string? OurRef { get; set; }
        [Column("Payment By")]
        [StringLength(50)]
        public string? PaymentBy { get; set; }
        [Column("Payment By Contact No")]
        [StringLength(30)]
        public string? PaymentByContactNo { get; set; }
        [Column("Payment By Nric No")]
        [StringLength(15)]
        public string? PaymentByNricNo { get; set; }
        [Column("Payment By Vehicle No")]
        [StringLength(25)]
        public string? PaymentByVehicleNo { get; set; }
        [Column("Pay Mode")]
        [StringLength(5)]
        public string? PayMode { get; set; }
        public int? Pcs { get; set; }
        [Column("Period From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? PeriodFromDate { get; set; }
        [Column("Period To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? PeriodToDate { get; set; }
        [Column("Plan Collection Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? PlanCollectionDate { get; set; }
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
        [Column("Postal Code")]
        [StringLength(10)]
        public string? PostalCode { get; set; }
        [Column("Post By")]
        [StringLength(50)]
        public string? PostBy { get; set; }
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
        [Column("Print Count")]
        public byte? PrintCount { get; set; }
        [Column("Quote No")]
        [StringLength(20)]
        public string? QuoteNo { get; set; }
        [Column("Receipt Amt", TypeName = "decimal(18, 2)")]
        public decimal ReceiptAmt { get; set; }
        [Column("Receipt Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ReceiptDate { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Ref No")]
        [StringLength(10)]
        public string? RefNo { get; set; }
        [Column("Request By")]
        [StringLength(50)]
        public string? RequestBy { get; set; }
        [Column("Request To")]
        [StringLength(255)]
        public string? RequestTo { get; set; }
        [Column("Reversal Flag")]
        [StringLength(1)]
        public string? ReversalFlag { get; set; }
        [Column("Salesman Code")]
        [StringLength(10)]
        public string? SalesmanCode { get; set; }
        [Column("Shipper Code")]
        [StringLength(10)]
        public string? ShipperCode { get; set; }
        [Column("Shipper Name")]
        [StringLength(80)]
        public string? ShipperName { get; set; }
        [Column("Site Code")]
        [StringLength(20)]
        public string? SiteCode { get; set; }
        [Column("Source Ref No")]
        [StringLength(10)]
        public string? SourceRefNo { get; set; }
        [Column("Source Site Code")]
        [StringLength(20)]
        public string? SourceSiteCode { get; set; }
        [Column("Target Ref No")]
        [StringLength(10)]
        public string? TargetRefNo { get; set; }
        [Column("Target Site Code")]
        [StringLength(20)]
        public string? TargetSiteCode { get; set; }
        [StringLength(30)]
        public string? Telephone { get; set; }
        [Column("Template Name")]
        [StringLength(50)]
        public string? TemplateName { get; set; }
        [Column("Term Code")]
        [StringLength(3)]
        public string? TermCode { get; set; }
        [Column("Total Exm Amt", TypeName = "decimal(17, 2)")]
        public decimal? TotalExmAmt { get; set; }
        [Column("Total Local Vat Amt", TypeName = "decimal(17, 2)")]
        public decimal? TotalLocalVatAmt { get; set; }
        [Column("Total Std Amt", TypeName = "decimal(17, 2)")]
        public decimal? TotalStdAmt { get; set; }
        [Column("Total Vat Amt", TypeName = "decimal(17, 2)")]
        public decimal? TotalVatAmt { get; set; }
        [Column("Total Zero Amt", TypeName = "decimal(17, 2)")]
        public decimal? TotalZeroAmt { get; set; }
        [Column("Transfer Flag")]
        [StringLength(1)]
        public string? TransferFlag { get; set; }
        [Column("Trx Type")]
        [StringLength(1)]
        public string? TrxType { get; set; }
        [Column("Vessel Code")]
        [StringLength(50)]
        public string? VesselCode { get; set; }
        [Column("Vessel Name")]
        [StringLength(50)]
        public string? VesselName { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Volume { get; set; }
        [Column("With Holding Tax Amt", TypeName = "decimal(17, 2)")]
        public decimal? WithHoldingTaxAmt { get; set; }
        [Column("With Holding Tax No")]
        [StringLength(20)]
        public string? WithHoldingTaxNo { get; set; }
        [Column("Your Ref")]
        [StringLength(24)]
        public string? YourRef { get; set; }
        [Column("Zero Vat With Holding Tax No")]
        [StringLength(20)]
        public string? ZeroVatWithHoldingTaxNo { get; set; }
        [Column("Work Station")]
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
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
