using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwWhiv1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
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
        [Column("Bank Acc Code")]
        [StringLength(15)]
        public string? BankAccCode { get; set; }
        [Column("Batch No")]
        [StringLength(20)]
        public string? BatchNo { get; set; }
        [Column("Business Party Code")]
        [StringLength(10)]
        public string? BusinessPartyCode { get; set; }
        [Column("Cash Amt", TypeName = "decimal(13, 2)")]
        public decimal? CashAmt { get; set; }
        [Column("Cash Local Amt", TypeName = "decimal(13, 2)")]
        public decimal? CashLocalAmt { get; set; }
        [Column("Charge Rate", TypeName = "decimal(13, 6)")]
        public decimal? ChargeRate { get; set; }
        [Column("Charge Weight", TypeName = "decimal(13, 6)")]
        public decimal? ChargeWeight { get; set; }
        [Column("Cheque No")]
        [StringLength(18)]
        public string? ChequeNo { get; set; }
        [Column("Cheque Amt", TypeName = "decimal(13, 2)")]
        public decimal? ChequeAmt { get; set; }
        [Column("Cheque Local Amt", TypeName = "decimal(13, 2)")]
        public decimal? ChequeLocalAmt { get; set; }
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
        [Column("Due Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? DueDate { get; set; }
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
        [Column("Invoice Amt", TypeName = "decimal(13, 2)")]
        public decimal? InvoiceAmt { get; set; }
        [Column("Invoice And Vat Amt", TypeName = "decimal(13, 2)")]
        public decimal? InvoiceAndVatAmt { get; set; }
        [Column("Invoice And Vat Local Amt", TypeName = "decimal(13, 2)")]
        public decimal? InvoiceAndVatLocalAmt { get; set; }
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
        [Column("Period From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? PeriodFromDate { get; set; }
        [Column("Period To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? PeriodToDate { get; set; }
        [Column("Post Date", TypeName = "datetime")]
        public DateTime? PostDate { get; set; }
        [Column("Post Flag")]
        [StringLength(1)]
        public string? PostFlag { get; set; }
        [Column("Post Mth")]
        [StringLength(6)]
        public string? PostMth { get; set; }
        [Column("Print Count")]
        public byte? PrintCount { get; set; }
        [Column("Receipt Amt", TypeName = "decimal(13, 2)")]
        public decimal ReceiptAmt { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Receipt Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ReceiptDate { get; set; }
        [Column("Term Code")]
        [StringLength(3)]
        public string? TermCode { get; set; }
        [Column("Total Cost Amt", TypeName = "decimal(13, 2)")]
        public decimal? TotalCostAmt { get; set; }
        [Column("Total Exm Amt", TypeName = "decimal(13, 2)")]
        public decimal? TotalExmAmt { get; set; }
        [Column("Total Std Amt", TypeName = "decimal(13, 2)")]
        public decimal? TotalStdAmt { get; set; }
        [Column("Total Vat Amt", TypeName = "decimal(13, 2)")]
        public decimal? TotalVatAmt { get; set; }
        [Column("Total Zero Amt", TypeName = "decimal(13, 2)")]
        public decimal? TotalZeroAmt { get; set; }
        [Column("Trx Type")]
        [StringLength(1)]
        public string? TrxType { get; set; }
        [Column("Work Station")]
        [StringLength(50)]
        public string? WorkStation { get; set; }
        [Column("Created By")]
        [StringLength(50)]
        public string? CreatedBy { get; set; }
        [Column("Created At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CreatedAt { get; set; }
        [Column("Updated By")]
        [StringLength(50)]
        public string? UpdatedBy { get; set; }
        [Column("Updated At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? UpdatedAt { get; set; }
        [StringLength(3)]
        public string? Status { get; set; }
    }
}
