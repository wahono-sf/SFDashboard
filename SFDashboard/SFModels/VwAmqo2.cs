using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwAmqo2
    {
        [Column("Quote Table No")]
        [StringLength(10)]
        public string QuoteTableNo { get; set; } = null!;
        [Column("Line Item No")]
        public short LineItemNo { get; set; }
        [Column("Awb Charge Code")]
        [StringLength(3)]
        public string? AwbChargeCode { get; set; }
        [Column("Awb Flag")]
        [StringLength(1)]
        public string? AwbFlag { get; set; }
        [Column("Break Rate Type 01")]
        [StringLength(1)]
        public string? BreakRateType01 { get; set; }
        [Column("Break Rate Type 02")]
        [StringLength(1)]
        public string? BreakRateType02 { get; set; }
        [Column("Break Rate Type 03")]
        [StringLength(1)]
        public string? BreakRateType03 { get; set; }
        [Column("Break Rate Type 04")]
        [StringLength(1)]
        public string? BreakRateType04 { get; set; }
        [Column("Break Rate Type 05")]
        [StringLength(1)]
        public string? BreakRateType05 { get; set; }
        [Column("Break Rate Type 06")]
        [StringLength(1)]
        public string? BreakRateType06 { get; set; }
        [Column("Break Rate Type 07")]
        [StringLength(1)]
        public string? BreakRateType07 { get; set; }
        [Column("Break Rate Type 08")]
        [StringLength(1)]
        public string? BreakRateType08 { get; set; }
        [Column("Break Rate Type 09")]
        [StringLength(1)]
        public string? BreakRateType09 { get; set; }
        [Column("Break Rate Type 10")]
        [StringLength(1)]
        public string? BreakRateType10 { get; set; }
        [Column("Break Rate Type 11")]
        [StringLength(1)]
        public string? BreakRateType11 { get; set; }
        [Column("Break Rate Type 12")]
        [StringLength(1)]
        public string? BreakRateType12 { get; set; }
        [Column("Break Rate Type 13")]
        [StringLength(1)]
        public string? BreakRateType13 { get; set; }
        [Column("Break Rate Type 14")]
        [StringLength(1)]
        public string? BreakRateType14 { get; set; }
        [Column("Break Rate Type 15")]
        [StringLength(1)]
        public string? BreakRateType15 { get; set; }
        [Column("Break Rate Type 16")]
        [StringLength(1)]
        public string? BreakRateType16 { get; set; }
        [Column("Charge Description")]
        [StringLength(50)]
        public string? ChargeDescription { get; set; }
        [Column("Charge Type")]
        [StringLength(1)]
        public string? ChargeType { get; set; }
        [Column("Charge Unit")]
        [StringLength(1)]
        public string? ChargeUnit { get; set; }
        [Column("Default Charge Flag")]
        [StringLength(1)]
        public string? DefaultChargeFlag { get; set; }
        [Column("Due Party")]
        [StringLength(1)]
        public string? DueParty { get; set; }
        [Column("Pp Cc Flag")]
        [StringLength(1)]
        public string? PpCcFlag { get; set; }
        [Column("Quote Amt", TypeName = "decimal(13, 2)")]
        public decimal? QuoteAmt { get; set; }
        [Column("Quote Rate 01", TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate01 { get; set; }
        [Column("Quote Rate 02", TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate02 { get; set; }
        [Column("Quote Rate 03", TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate03 { get; set; }
        [Column("Quote Rate 04", TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate04 { get; set; }
        [Column("Quote Rate 05", TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate05 { get; set; }
        [Column("Quote Rate 06", TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate06 { get; set; }
        [Column("Quote Rate 07", TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate07 { get; set; }
        [Column("Quote Rate 08", TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate08 { get; set; }
        [Column("Quote Rate 09", TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate09 { get; set; }
        [Column("Quote Rate 10", TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate10 { get; set; }
        [Column("Quote Rate 11", TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate11 { get; set; }
        [Column("Quote Rate 12", TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate12 { get; set; }
        [Column("Quote Rate 13", TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate13 { get; set; }
        [Column("Quote Rate 14", TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate14 { get; set; }
        [Column("Quote Rate 15", TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate15 { get; set; }
        [Column("Quote Rate 16", TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate16 { get; set; }
        [Column("Rate Type")]
        [StringLength(1)]
        public string? RateType { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Sales Item Code")]
        [StringLength(30)]
        public string? SalesItemCode { get; set; }
        [Column("Uom Code")]
        [StringLength(3)]
        public string? UomCode { get; set; }
        [Column("Weight Break 01", TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak01 { get; set; }
        [Column("Weight Break 02", TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak02 { get; set; }
        [Column("Weight Break 03", TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak03 { get; set; }
        [Column("Weight Break 04", TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak04 { get; set; }
        [Column("Weight Break 05", TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak05 { get; set; }
        [Column("Weight Break 06", TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak06 { get; set; }
        [Column("Weight Break 07", TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak07 { get; set; }
        [Column("Weight Break 08", TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak08 { get; set; }
        [Column("Weight Break 09", TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak09 { get; set; }
        [Column("Weight Break 10", TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak10 { get; set; }
        [Column("Weight Break 11", TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak11 { get; set; }
        [Column("Weight Break 12", TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak12 { get; set; }
        [Column("Weight Break 13", TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak13 { get; set; }
        [Column("Weight Break 14", TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak14 { get; set; }
        [Column("Weight Break 15", TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak15 { get; set; }
        [Column("Weight Break 16", TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak16 { get; set; }
        [Column("Weight Type")]
        [StringLength(1)]
        public string? WeightType { get; set; }
    }
}
