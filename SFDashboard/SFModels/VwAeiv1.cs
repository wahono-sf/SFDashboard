using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwAeiv1
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
        [StringLength(50)]
        public string? AttnName { get; set; }
        [Column("Billing Party Code")]
        [StringLength(10)]
        public string? BillingPartyCode { get; set; }
        [Column("Awb No")]
        [StringLength(20)]
        public string? AwbNo { get; set; }
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
        [Column("Commodity Code")]
        [StringLength(10)]
        public string? CommodityCode { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [Column("Customer Code")]
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [Column("Customer Name")]
        [StringLength(50)]
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
        public byte EdiCount { get; set; }
        [Column("Email Count")]
        public byte EmailCount { get; set; }
        [Column("Flight Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? FlightDate { get; set; }
        [Column("Export Count")]
        public byte ExportCount { get; set; }
        [Column("Fax Count")]
        public byte FaxCount { get; set; }
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
        [Column("HAWB No")]
        [StringLength(20)]
        public string? HawbNo { get; set; }
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
        [StringLength(10)]
        public string? JobType { get; set; }
        [Column("Letter Of Credit No")]
        [StringLength(15)]
        public string? LetterOfCreditNo { get; set; }
        [Column("M Awb No")]
        [StringLength(20)]
        public string? MAwbNo { get; set; }
        [Column("Origin Code")]
        [StringLength(3)]
        public string? OriginCode { get; set; }
        [Column("Our Ref")]
        [StringLength(24)]
        public string? OurRef { get; set; }
        public int? Pcs { get; set; }
        [Column("Postal Code")]
        [StringLength(10)]
        public string? PostalCode { get; set; }
        [Column("Post Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? PostDate { get; set; }
        [Column("Post Flag")]
        [StringLength(1)]
        public string PostFlag { get; set; } = null!;
        [Column("Post Mth")]
        [StringLength(6)]
        public string? PostMth { get; set; }
        [Column("Pp Cc Flag")]
        [StringLength(1)]
        public string? PpCcFlag { get; set; }
        [Column("Print Count")]
        public byte PrintCount { get; set; }
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
        [Column("Site Code")]
        [StringLength(20)]
        public string? SiteCode { get; set; }
        [StringLength(30)]
        public string? Telephone { get; set; }
        [Column("Template Name")]
        [StringLength(50)]
        public string? TemplateName { get; set; }
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
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Volume { get; set; }
        [Column("Flight No")]
        [StringLength(12)]
        public string? FlightNo { get; set; }
        [Column("With Holding Tax Amt", TypeName = "decimal(13, 2)")]
        public decimal? WithHoldingTaxAmt { get; set; }
        [Column("With Holding Tax No")]
        [StringLength(50)]
        public string? WithHoldingTaxNo { get; set; }
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
