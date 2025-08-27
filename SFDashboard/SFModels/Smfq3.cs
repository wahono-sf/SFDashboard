using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("smfq3")]
    public partial class Smfq3
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public short QuoteLineItemNo { get; set; }
        [Key]
        public short LineItemNo { get; set; }
        [StringLength(1)]
        public string? BlFlag { get; set; }
        [StringLength(1)]
        public string? BreakRateType01 { get; set; }
        [StringLength(1)]
        public string? BreakRateType02 { get; set; }
        [StringLength(1)]
        public string? BreakRateType03 { get; set; }
        [StringLength(1)]
        public string? BreakRateType04 { get; set; }
        [StringLength(1)]
        public string? BreakRateType05 { get; set; }
        [StringLength(1)]
        public string? BreakRateType06 { get; set; }
        [StringLength(1)]
        public string? BreakRateType07 { get; set; }
        [StringLength(1)]
        public string? BreakRateType08 { get; set; }
        [StringLength(1)]
        public string? BreakRateType09 { get; set; }
        [StringLength(1)]
        public string? BreakRateType10 { get; set; }
        [StringLength(1)]
        public string? BreakRateType11 { get; set; }
        [StringLength(1)]
        public string? BreakRateType12 { get; set; }
        [StringLength(1)]
        public string? BreakRateType13 { get; set; }
        [StringLength(1)]
        public string? BreakRateType14 { get; set; }
        [StringLength(1)]
        public string? BreakRateType15 { get; set; }
        [StringLength(1)]
        public string? BreakRateType16 { get; set; }
        [StringLength(1)]
        public string? BreakUnit01 { get; set; }
        [StringLength(5)]
        public string? CargoType { get; set; }
        [StringLength(50)]
        public string? ChargeDescription { get; set; }
        [StringLength(1)]
        public string? ChargeType { get; set; }
        [StringLength(1)]
        public string? ChargeUnit { get; set; }
        [StringLength(5)]
        public string? ContainerType { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? CostAmt { get; set; }
        [StringLength(255)]
        public string? CostRemark { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [StringLength(1)]
        public string? DefaultChargeFlag { get; set; }
        [StringLength(2)]
        public string? DgCargoClass { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? MinAmt { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? MinQty { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Percentage { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? PerUnit { get; set; }
        [StringLength(1)]
        public string? PpCcFlag { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Qty { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? QuoteAmt { get; set; }
        [StringLength(50)]
        public string? QuoteCost01 { get; set; }
        [StringLength(50)]
        public string? QuoteCost02 { get; set; }
        [StringLength(50)]
        public string? QuoteCost03 { get; set; }
        [StringLength(50)]
        public string? QuoteCost04 { get; set; }
        [StringLength(50)]
        public string? QuoteCost05 { get; set; }
        [StringLength(50)]
        public string? QuoteCost06 { get; set; }
        [StringLength(50)]
        public string? QuoteCost07 { get; set; }
        [StringLength(50)]
        public string? QuoteCost08 { get; set; }
        [StringLength(50)]
        public string? QuoteCost09 { get; set; }
        [StringLength(50)]
        public string? QuoteCost10 { get; set; }
        [StringLength(50)]
        public string? QuoteCost11 { get; set; }
        [StringLength(50)]
        public string? QuoteCost12 { get; set; }
        [StringLength(50)]
        public string? QuoteCost13 { get; set; }
        [StringLength(50)]
        public string? QuoteCost14 { get; set; }
        [StringLength(50)]
        public string? QuoteCost15 { get; set; }
        [StringLength(50)]
        public string? QuoteCost16 { get; set; }
        [StringLength(50)]
        public string? QuoteRate01 { get; set; }
        [StringLength(50)]
        public string? QuoteRate02 { get; set; }
        [StringLength(50)]
        public string? QuoteRate03 { get; set; }
        [StringLength(50)]
        public string? QuoteRate04 { get; set; }
        [StringLength(50)]
        public string? QuoteRate05 { get; set; }
        [StringLength(50)]
        public string? QuoteRate06 { get; set; }
        [StringLength(50)]
        public string? QuoteRate07 { get; set; }
        [StringLength(50)]
        public string? QuoteRate08 { get; set; }
        [StringLength(50)]
        public string? QuoteRate09 { get; set; }
        [StringLength(50)]
        public string? QuoteRate10 { get; set; }
        [StringLength(50)]
        public string? QuoteRate11 { get; set; }
        [StringLength(50)]
        public string? QuoteRate12 { get; set; }
        [StringLength(50)]
        public string? QuoteRate13 { get; set; }
        [StringLength(50)]
        public string? QuoteRate14 { get; set; }
        [StringLength(50)]
        public string? QuoteRate15 { get; set; }
        [StringLength(50)]
        public string? QuoteRate16 { get; set; }
        [StringLength(1)]
        public string? RateType { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(1)]
        public string? ReviseFlag { get; set; }
        [StringLength(30)]
        public string? SalesItemCode { get; set; }
        public int? SortItemNo { get; set; }
        [StringLength(50)]
        public string? UomCode { get; set; }
        [StringLength(50)]
        public string? UomCode01 { get; set; }
        [StringLength(50)]
        public string? UomCode02 { get; set; }
        [StringLength(50)]
        public string? UomCode03 { get; set; }
        [StringLength(50)]
        public string? UomCode04 { get; set; }
        [StringLength(50)]
        public string? UomCode05 { get; set; }
        [StringLength(50)]
        public string? UomCode06 { get; set; }
        [StringLength(50)]
        public string? UomCode07 { get; set; }
        [StringLength(50)]
        public string? UomCode08 { get; set; }
        [StringLength(50)]
        public string? UomCode09 { get; set; }
        [StringLength(50)]
        public string? UomCode10 { get; set; }
        [StringLength(50)]
        public string? UomCode11 { get; set; }
        [StringLength(50)]
        public string? UomCode12 { get; set; }
        [StringLength(50)]
        public string? UomCode13 { get; set; }
        [StringLength(50)]
        public string? UomCode14 { get; set; }
        [StringLength(50)]
        public string? UomCode15 { get; set; }
        [StringLength(50)]
        public string? UomCode16 { get; set; }
        [StringLength(10)]
        public string? VatCode { get; set; }
        [StringLength(10)]
        public string? VendorCode { get; set; }
        [StringLength(80)]
        public string? VendorName { get; set; }
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
        [StringLength(50)]
        public string? CreateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateDateTime { get; set; }
        [StringLength(50)]
        public string? UpdateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdateDateTime { get; set; }
    }
}
