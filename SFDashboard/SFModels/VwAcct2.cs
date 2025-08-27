using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwAcct2
    {
        [Column("Quote Table No")]
        [StringLength(5)]
        public string QuoteTableNo { get; set; } = null!;
        [Column("Line Item No")]
        public short LineItemNo { get; set; }
        [Column("Charge Type")]
        [StringLength(1)]
        public string? ChargeType { get; set; }
        [Column("Quote Amt", TypeName = "decimal(13, 2)")]
        public decimal? QuoteAmt { get; set; }
        [Column("Quote Rate 0 1", TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate01 { get; set; }
        [Column("Quote Rate 0 2", TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate02 { get; set; }
        [Column("Quote Rate 0 3", TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate03 { get; set; }
        [Column("Quote Rate 0 4", TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate04 { get; set; }
        [Column("Quote Rate 0 5", TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate05 { get; set; }
        [Column("Quote Rate 0 6", TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate06 { get; set; }
        [Column("Quote Rate 0 7", TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate07 { get; set; }
        [Column("Quote Rate 0 8", TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate08 { get; set; }
        [Column("Quote Rate 0 9", TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate09 { get; set; }
        [Column("Quote Rate 1 0", TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate10 { get; set; }
        [Column("Quote Rate 1 1", TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate11 { get; set; }
        [Column("Quote Rate 1 2", TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate12 { get; set; }
        [Column("Quote Rate 1 3", TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate13 { get; set; }
        [Column("Quote Rate 1 4", TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate14 { get; set; }
        [Column("Quote Rate 1 5", TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate15 { get; set; }
        [Column("Quote Rate 1 6", TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate16 { get; set; }
        [Column("Rate Type")]
        [StringLength(1)]
        public string? RateType { get; set; }
        [Column("Sales Item Code")]
        [StringLength(30)]
        public string? SalesItemCode { get; set; }
        [Column("Weight Break 0 1", TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak01 { get; set; }
        [Column("Weight Break 0 2", TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak02 { get; set; }
        [Column("Weight Break 0 3", TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak03 { get; set; }
        [Column("Weight Break 0 4", TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak04 { get; set; }
        [Column("Weight Break 0 5", TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak05 { get; set; }
        [Column("Weight Break 0 6", TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak06 { get; set; }
        [Column("Weight Break 0 7", TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak07 { get; set; }
        [Column("Weight Break 0 8", TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak08 { get; set; }
        [Column("Weight Break 0 9", TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak09 { get; set; }
        [Column("Weight Break 1 0", TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak10 { get; set; }
        [Column("Weight Break 1 1", TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak11 { get; set; }
        [Column("Weight Break 1 2", TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak12 { get; set; }
        [Column("Weight Break 1 3", TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak13 { get; set; }
        [Column("Weight Break 1 4", TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak14 { get; set; }
        [Column("Weight Break 1 5", TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak15 { get; set; }
        [Column("Weight Break 1 6", TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak16 { get; set; }
    }
}
