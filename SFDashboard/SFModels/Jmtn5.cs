using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    [Table("jmtn5")]
    public partial class Jmtn5
    {
        public int TrxNo { get; set; }
        [StringLength(30)]
        public string? JobNo { get; set; }
        [StringLength(1)]
        public string? AdValoremIndFlag { get; set; }
        [Column(TypeName = "decimal(15, 2)")]
        public decimal? CostAmt { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [Column(TypeName = "decimal(15, 2)")]
        public decimal? FrtAmt { get; set; }
        [Column("FrtAmtSGD", TypeName = "decimal(15, 2)")]
        public decimal? FrtAmtSgd { get; set; }
        [StringLength(3)]
        public string? FrtCurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? FrtCurrRate { get; set; }
        [Column(TypeName = "decimal(7, 3)")]
        public decimal? FrtPercent { get; set; }
        [Column("GSTAmt", TypeName = "decimal(15, 2)")]
        public decimal? Gstamt { get; set; }
        [Column(TypeName = "decimal(15, 2)")]
        public decimal? InsAmt { get; set; }
        [Column("InsAmtSGD", TypeName = "decimal(15, 2)")]
        public decimal? InsAmtSgd { get; set; }
        [StringLength(3)]
        public string? InsCurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? InsCurrRate { get; set; }
        [Column(TypeName = "decimal(7, 3)")]
        public decimal? InsPercent { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InvoiceDate { get; set; }
        [StringLength(35)]
        public string? InvoiceNo { get; set; }
        public int? InvoiceSeqNo { get; set; }
        [Column(TypeName = "decimal(15, 2)")]
        public decimal? OthAmt { get; set; }
        [Column("OthAmtSGD", TypeName = "decimal(15, 2)")]
        public decimal? OthAmtSgd { get; set; }
        [StringLength(3)]
        public string? OthCurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? OthCurrRate { get; set; }
        [Column(TypeName = "decimal(7, 3)")]
        public decimal? OthPercent { get; set; }
        [StringLength(1)]
        public string? PreferentialDutyRateIndFlag { get; set; }
        [StringLength(1)]
        public string? SuppImpRelationFlag { get; set; }
        [StringLength(17)]
        public string? SupplierCode { get; set; }
        [StringLength(50)]
        public string? SupplierName01 { get; set; }
        [StringLength(50)]
        public string? SupplierName02 { get; set; }
        [StringLength(3)]
        public string? TermCode { get; set; }
        [Column(TypeName = "decimal(15, 2)")]
        public decimal? TotalAmt { get; set; }
        [Column("TotalAmtSGD", TypeName = "decimal(15, 2)")]
        public decimal? TotalAmtSgd { get; set; }
    }
}
