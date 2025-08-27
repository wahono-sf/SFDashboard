using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("acct2")]
    public partial class Acct2
    {
        [Key]
        [StringLength(5)]
        public string QuoteTableNo { get; set; } = null!;
        [Key]
        public short LineItemNo { get; set; }
        [StringLength(1)]
        public string? ChargeType { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? QuoteAmt { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate01 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate02 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate03 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate04 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate05 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate06 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate07 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate08 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate09 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate10 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate11 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate12 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate13 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate14 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate15 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate16 { get; set; }
        [StringLength(1)]
        public string? RateType { get; set; }
        [StringLength(30)]
        public string? SalesItemCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak01 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak02 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak03 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak04 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak05 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak06 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak07 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak08 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak09 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak10 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak11 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak12 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak13 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak14 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak15 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak16 { get; set; }
    }
}
