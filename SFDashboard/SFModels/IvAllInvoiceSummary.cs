using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class IvAllInvoiceSummary
    {
        [Column("Customer Code")]
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [Column("Customer Name")]
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [Column("Awb Or Bl No")]
        [StringLength(20)]
        public string? AwbOrBlNo { get; set; }
        [Column("M Awb Or O Bl No")]
        [StringLength(20)]
        public string? MAwbOrOBlNo { get; set; }
        [Column("Job No")]
        [StringLength(20)]
        public string? JobNo { get; set; }
        [Column("Job Type")]
        [StringLength(2)]
        public string? JobType { get; set; }
        [Column("Invoice No")]
        [StringLength(20)]
        public string? InvoiceNo { get; set; }
        [Column("Apply To Invoice")]
        [StringLength(20)]
        public string? ApplyToInvoice { get; set; }
        [Column("Trx Type")]
        [StringLength(1)]
        public string? TrxType { get; set; }
        [Column("Invoice Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? InvoiceDate { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Curr Rate", TypeName = "decimal(13, 6)")]
        public decimal? CurrRate { get; set; }
        [Column("Invoice And Vat Amt", TypeName = "decimal(13, 2)")]
        public decimal? InvoiceAndVatAmt { get; set; }
        [Column("Invoice And Vat Local Amt", TypeName = "decimal(13, 2)")]
        public decimal? InvoiceAndVatLocalAmt { get; set; }
        [Column("Invoice Local Amt", TypeName = "decimal(13, 2)")]
        public decimal? InvoiceLocalAmt { get; set; }
        [Column("Invoice Cost Amt", TypeName = "decimal(13, 2)")]
        public decimal? InvoiceCostAmt { get; set; }
        [Column("Post Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? PostDate { get; set; }
        [Column("Post Mth")]
        [StringLength(6)]
        public string? PostMth { get; set; }
        [StringLength(3)]
        public string Status { get; set; } = null!;
        [Column("Ref No")]
        [StringLength(10)]
        public string? RefNo { get; set; }
        [StringLength(2)]
        public string? Location { get; set; }
    }
}
