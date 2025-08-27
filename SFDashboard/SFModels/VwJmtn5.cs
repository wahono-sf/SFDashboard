using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwJmtn5
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Job No")]
        [StringLength(20)]
        public string? JobNo { get; set; }
        [Column("Ad Valorem Ind Flag")]
        [StringLength(1)]
        public string? AdValoremIndFlag { get; set; }
        [Column("Cost Amt", TypeName = "decimal(15, 2)")]
        public decimal? CostAmt { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [Column("Frt Amt", TypeName = "decimal(15, 2)")]
        public decimal? FrtAmt { get; set; }
        [Column("Frt Amt SGD", TypeName = "decimal(15, 2)")]
        public decimal? FrtAmtSgd { get; set; }
        [Column("Frt Curr Code")]
        [StringLength(3)]
        public string? FrtCurrCode { get; set; }
        [Column("Frt Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? FrtCurrRate { get; set; }
        [Column("Frt Percent", TypeName = "decimal(7, 3)")]
        public decimal? FrtPercent { get; set; }
        [Column("GST Amt", TypeName = "decimal(15, 2)")]
        public decimal? GstAmt { get; set; }
        [Column("Ins Amt", TypeName = "decimal(15, 2)")]
        public decimal? InsAmt { get; set; }
        [Column("Ins Amt SGD", TypeName = "decimal(15, 2)")]
        public decimal? InsAmtSgd { get; set; }
        [Column("Ins Curr Code")]
        [StringLength(3)]
        public string? InsCurrCode { get; set; }
        [Column("Ins Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? InsCurrRate { get; set; }
        [Column("Ins Percent", TypeName = "decimal(7, 3)")]
        public decimal? InsPercent { get; set; }
        [Column("Invoice Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? InvoiceDate { get; set; }
        [Column("Invoice No")]
        [StringLength(35)]
        public string? InvoiceNo { get; set; }
        [Column("Invoice Seq No")]
        public int? InvoiceSeqNo { get; set; }
        [Column("Oth Amt", TypeName = "decimal(15, 2)")]
        public decimal? OthAmt { get; set; }
        [Column("Oth Amt SGD", TypeName = "decimal(15, 2)")]
        public decimal? OthAmtSgd { get; set; }
        [Column("Oth Curr Code")]
        [StringLength(3)]
        public string? OthCurrCode { get; set; }
        [Column("Oth Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? OthCurrRate { get; set; }
        [Column("Oth Percent", TypeName = "decimal(7, 3)")]
        public decimal? OthPercent { get; set; }
        [Column("Preferential Duty Rate Ind Flag")]
        [StringLength(1)]
        public string? PreferentialDutyRateIndFlag { get; set; }
        [Column("Supp Imp Relation Flag")]
        [StringLength(1)]
        public string? SuppImpRelationFlag { get; set; }
        [Column("Supplier Code")]
        [StringLength(17)]
        public string? SupplierCode { get; set; }
        [Column("Supplier Name 01")]
        [StringLength(50)]
        public string? SupplierName01 { get; set; }
        [Column("Supplier Name 02")]
        [StringLength(50)]
        public string? SupplierName02 { get; set; }
        [Column("Term Code")]
        [StringLength(3)]
        public string? TermCode { get; set; }
        [Column("Total Amt", TypeName = "decimal(15, 2)")]
        public decimal? TotalAmt { get; set; }
        [Column("Total Amt SGD", TypeName = "decimal(15, 2)")]
        public decimal? TotalAmtSgd { get; set; }
    }
}
