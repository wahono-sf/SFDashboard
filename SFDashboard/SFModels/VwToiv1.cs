using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwToiv1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
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
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Attn Name")]
        [StringLength(80)]
        public string? AttnName { get; set; }
        [Column("Bill Inst")]
        [StringLength(1)]
        public string? BillInst { get; set; }
        [Column("B L No")]
        [StringLength(20)]
        public string? BLNo { get; set; }
        [Column("Billing Party Code")]
        [StringLength(10)]
        public string? BillingPartyCode { get; set; }
        [Column("Cancelled Flag")]
        [StringLength(1)]
        public string? CancelledFlag { get; set; }
        [Column("Cargo Type")]
        [StringLength(3)]
        public string? CargoType { get; set; }
        [Column("Cash Amt", TypeName = "decimal(13, 2)")]
        public decimal? CashAmt { get; set; }
        [Column("Charge Weight", TypeName = "decimal(13, 4)")]
        public decimal? ChargeWeight { get; set; }
        [Column("Cheque Local Amt", TypeName = "decimal(13, 2)")]
        public decimal? ChequeLocalAmt { get; set; }
        [Column("Cheque No")]
        [StringLength(18)]
        public string? ChequeNo { get; set; }
        [Column("Collect By")]
        [StringLength(50)]
        public string? CollectBy { get; set; }
        [Column("Commodity Code")]
        [StringLength(10)]
        public string? CommodityCode { get; set; }
        [Column("Country Code")]
        [StringLength(2)]
        public string? CountryCode { get; set; }
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
        [Column("Dest Code")]
        [StringLength(3)]
        public string? DestCode { get; set; }
        [Column("District Code")]
        [StringLength(5)]
        public string? DistrictCode { get; set; }
        [Column("Division Code")]
        [StringLength(10)]
        public string? DivisionCode { get; set; }
        [Column("Due Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? DueDate { get; set; }
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
        [Column("Feeder Vessel")]
        [StringLength(30)]
        public string? FeederVessel { get; set; }
        [Column("Feeder Voyage")]
        [StringLength(12)]
        public string? FeederVoyage { get; set; }
        [Column("Fifth Via Port Code")]
        [StringLength(5)]
        public string? FifthViaPortCode { get; set; }
        [Column("First Via Port Code")]
        [StringLength(5)]
        public string? FirstViaPortCode { get; set; }
        [Column("Footer 1")]
        [StringLength(60)]
        public string? Footer1 { get; set; }
        [Column("Footer 2")]
        [StringLength(60)]
        public string? Footer2 { get; set; }
        [Column("Footer 3")]
        [StringLength(60)]
        public string? Footer3 { get; set; }
        [Column("Footer 4")]
        [StringLength(60)]
        public string? Footer4 { get; set; }
        [Column("Footer 5")]
        [StringLength(60)]
        public string? Footer5 { get; set; }
        [Column("Foot Note Flag")]
        [StringLength(1)]
        public string? FootNoteFlag { get; set; }
        [Column("Fourth Via Port Code")]
        [StringLength(5)]
        public string? FourthViaPortCode { get; set; }
        [Column("Freight Cost Amt", TypeName = "decimal(13, 2)")]
        public decimal? FreightCostAmt { get; set; }
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
        [Column("Gross Weight", TypeName = "decimal(13, 4)")]
        public decimal? GrossWeight { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Grt { get; set; }
        [Column("H B L No")]
        [StringLength(20)]
        public string? HBLNo { get; set; }
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
        [Column("Job No")]
        [StringLength(20)]
        public string? JobNo { get; set; }
        [Column("Job Type")]
        [StringLength(100)]
        public string? JobType { get; set; }
        [Column("Letter Of Credit No")]
        [StringLength(15)]
        public string? LetterOfCreditNo { get; set; }
        [Column("No Of 20ft Container")]
        public int? NoOf20ftContainer { get; set; }
        [Column("No Of 40ft Container")]
        public int? NoOf40ftContainer { get; set; }
        [Column("No Of 45ft Container")]
        public int? NoOf45ftContainer { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Nrt { get; set; }
        [Column("O B L No")]
        [StringLength(20)]
        public string? OBLNo { get; set; }
        [Column("Origin Code")]
        [StringLength(3)]
        public string? OriginCode { get; set; }
        [Column("Our Ref")]
        [StringLength(24)]
        public string? OurRef { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Pcs { get; set; }
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
        [Column("Post Received Flag")]
        [StringLength(1)]
        public string? PostReceivedFlag { get; set; }
        [Column("Print Count")]
        public byte? PrintCount { get; set; }
        [Column("Receipt Amt", TypeName = "decimal(13, 2)")]
        public decimal ReceiptAmt { get; set; }
        [Column("Receipt Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ReceiptDate { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Salesman Code")]
        [StringLength(10)]
        public string? SalesmanCode { get; set; }
        [Column("Scr No")]
        [StringLength(4)]
        public string? ScrNo { get; set; }
        [Column("Second Via Port Code")]
        [StringLength(5)]
        public string? SecondViaPortCode { get; set; }
        [Column("Site Code")]
        [StringLength(20)]
        public string? SiteCode { get; set; }
        [Column("Term Code")]
        [StringLength(3)]
        public string? TermCode { get; set; }
        [Column("Third Via Port Code")]
        [StringLength(5)]
        public string? ThirdViaPortCode { get; set; }
        [Column("Total Cash Amt", TypeName = "decimal(13, 2)")]
        public decimal? TotalCashAmt { get; set; }
        [Column("Total Cheque Amt", TypeName = "decimal(13, 2)")]
        public decimal? TotalChequeAmt { get; set; }
        [Column("Total Cost Amt", TypeName = "decimal(13, 2)")]
        public decimal? TotalCostAmt { get; set; }
        [Column("Total Exm Amt", TypeName = "decimal(13, 2)")]
        public decimal? TotalExmAmt { get; set; }
        [Column("Total Local Cash Amt", TypeName = "decimal(13, 2)")]
        public decimal? TotalLocalCashAmt { get; set; }
        [Column("Total Local Cheque Amt", TypeName = "decimal(13, 2)")]
        public decimal? TotalLocalChequeAmt { get; set; }
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
        [Column("Vessel Code")]
        [StringLength(50)]
        public string? VesselCode { get; set; }
        [Column("Vessel Name")]
        [StringLength(80)]
        public string? VesselName { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Volume { get; set; }
        [Column("Voyage Or Flight No")]
        [StringLength(12)]
        public string? VoyageOrFlightNo { get; set; }
        [Column("Work Station")]
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
        [Column("Your Ref")]
        [StringLength(24)]
        public string? YourRef { get; set; }
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
