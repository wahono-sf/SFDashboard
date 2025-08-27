using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("wmbr2")]
    [Index("BillingCycleCode", Name = "INDEX_Wmbr2_BillingCycleCode")]
    [Index("ProductClassCode", Name = "INDEX_Wmbr2_ProductClassCode")]
    [Index("SalesItemCode", Name = "INDEX_Wmbr2_SalesItemCode")]
    [Index("TableNo", Name = "INDEX_Wmbr2_TableNo")]
    public partial class Wmbr2
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public short LineItemNo { get; set; }
        [StringLength(3)]
        public string? BillingChargeType { get; set; }
        [StringLength(3)]
        public string? BillingCycleCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? BillingRate { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? BondedAmt { get; set; }
        [StringLength(50)]
        public string? BreakFormula01 { get; set; }
        [StringLength(50)]
        public string? BreakFormula02 { get; set; }
        [StringLength(50)]
        public string? BreakFormula03 { get; set; }
        [StringLength(50)]
        public string? BreakFormula04 { get; set; }
        [StringLength(50)]
        public string? BreakFormula05 { get; set; }
        [StringLength(50)]
        public string? BreakFormula06 { get; set; }
        [StringLength(50)]
        public string? BreakFormula07 { get; set; }
        [StringLength(50)]
        public string? BreakFormula08 { get; set; }
        [StringLength(50)]
        public string? BreakFormula09 { get; set; }
        [StringLength(50)]
        public string? BreakFormula10 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? BreakPoint01 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? BreakPoint02 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? BreakPoint03 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? BreakPoint04 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? BreakPoint05 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? BreakPoint06 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? BreakPoint07 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? BreakPoint08 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? BreakPoint09 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? BreakPoint10 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? BreakRate01 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? BreakRate02 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? BreakRate03 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? BreakRate04 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? BreakRate05 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? BreakRate06 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? BreakRate07 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? BreakRate08 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? BreakRate09 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? BreakRate10 { get; set; }
        [StringLength(3)]
        public string? BreakUnit { get; set; }
        [StringLength(1)]
        public string? ChargeType { get; set; }
        [StringLength(3)]
        public string? ChargeUnit { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? DiscountPercent { get; set; }
        [StringLength(3)]
        public string? DiscountStartType { get; set; }
        [StringLength(10)]
        public string? FreeDayFlag { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? MinAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? MinAmtPerInvoice { get; set; }
        [StringLength(20)]
        public string? ProductClassCode { get; set; }
        [StringLength(10)]
        public string? ProRateFlag { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(30)]
        public string? SalesItemCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? StdAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? StdAmt01 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? StdAmt02 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? StdAmt03 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? StdAmt04 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? StdAmt05 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? StdAmt06 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? StdAmt07 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? StdAmt08 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? StdAmt09 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? StdAmt10 { get; set; }
        [StringLength(10)]
        public string TableNo { get; set; } = null!;
        [StringLength(50)]
        public string? UomCode { get; set; }
        [StringLength(50)]
        public string? UpdateBy { get; set; }
    }
}
