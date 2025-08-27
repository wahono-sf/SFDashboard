using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("ampa1")]
    public partial class Ampa1
    {
        [Key]
        [StringLength(1)]
        public string UniqueKey { get; set; } = null!;
        [StringLength(1)]
        public string? ApproveAttachmentFlag { get; set; }
        /// <summary>
        /// Default the Curr Code as Curr Code in Charges in Freight Quotataion
        /// </summary>
        [StringLength(3)]
        public string? CurrCode { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(5)]
        public string? DefHdr01 { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(5)]
        public string? DefHdr02 { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(5)]
        public string? DefHdr03 { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(5)]
        public string? DefHdr04 { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(5)]
        public string? DefHdr05 { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(5)]
        public string? DefHdr06 { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(5)]
        public string? DefHdr07 { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(5)]
        public string? DefHdr08 { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(5)]
        public string? DefHdr09 { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(5)]
        public string? DefHdr10 { get; set; }
        /// <summary>
        /// Default the Rate Class M, N, Q, C to all Rate Table
        /// </summary>
        [StringLength(1)]
        public string? DefRateClassCode01 { get; set; }
        /// <summary>
        /// Default the Rate Class M, N, Q, C to all Rate Table
        /// </summary>
        [StringLength(1)]
        public string? DefRateClassCode02 { get; set; }
        /// <summary>
        /// Default the Rate Class M, N, Q, C to all Rate Table
        /// </summary>
        [StringLength(1)]
        public string? DefRateClassCode03 { get; set; }
        /// <summary>
        /// Default the Rate Class M, N, Q, C to all Rate Table
        /// </summary>
        [StringLength(1)]
        public string? DefRateClassCode04 { get; set; }
        /// <summary>
        /// Default the Rate Class M, N, Q, C to all Rate Table
        /// </summary>
        [StringLength(1)]
        public string? DefRateClassCode05 { get; set; }
        /// <summary>
        /// Default the Rate Class M, N, Q, C to all Rate Table
        /// </summary>
        [StringLength(1)]
        public string? DefRateClassCode06 { get; set; }
        /// <summary>
        /// Default the Rate Class M, N, Q, C to all Rate Table
        /// </summary>
        [StringLength(1)]
        public string? DefRateClassCode07 { get; set; }
        /// <summary>
        /// Default the Rate Class M, N, Q, C to all Rate Table
        /// </summary>
        [StringLength(1)]
        public string? DefRateClassCode08 { get; set; }
        /// <summary>
        /// Default the Rate Class M, N, Q, C to all Rate Table
        /// </summary>
        [StringLength(1)]
        public string? DefRateClassCode09 { get; set; }
        /// <summary>
        /// Default the Rate Class M, N, Q, C to all Rate Table
        /// </summary>
        [StringLength(1)]
        public string? DefRateClassCode10 { get; set; }
        /// <summary>
        /// Default the Break Point 01 when enter new IATA or Freight Quotation
        /// </summary>
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? DefWeightBreak01 { get; set; }
        /// <summary>
        /// Default the Break Point 02 when enter new IATA or Freight Quotation
        /// </summary>
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? DefWeightBreak02 { get; set; }
        /// <summary>
        /// Default the Break Point 03 when enter new IATA or Freight Quotation
        /// </summary>
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? DefWeightBreak03 { get; set; }
        /// <summary>
        /// Default the Break Point 04 when enter new IATA or Freight Quotation
        /// </summary>
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? DefWeightBreak04 { get; set; }
        /// <summary>
        /// Default the Break Point 05 when enter new IATA or Freight Quotation
        /// </summary>
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? DefWeightBreak05 { get; set; }
        /// <summary>
        /// Default the Break Point 06 when enter new IATA or Freight Quotation
        /// </summary>
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? DefWeightBreak06 { get; set; }
        /// <summary>
        /// Default the Break Point 07 when enter new IATA or Freight Quotation
        /// </summary>
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? DefWeightBreak07 { get; set; }
        /// <summary>
        /// Default the Break Point 08 when enter new IATA or Freight Quotation
        /// </summary>
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? DefWeightBreak08 { get; set; }
        /// <summary>
        /// Default the Break Point 09 when enter new IATA or Freight Quotation
        /// </summary>
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? DefWeightBreak09 { get; set; }
        /// <summary>
        /// Default the Break Point 10 when enter new IATA or Freight Quotation
        /// </summary>
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? DefWeightBreak10 { get; set; }
        /// <summary>
        /// Default the Break Point 11 when enter new IATA or Freight Quotation
        /// </summary>
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? DefWeightBreak11 { get; set; }
        /// <summary>
        /// Default the Break Point 12 when enter new IATA or Freight Quotation
        /// </summary>
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? DefWeightBreak12 { get; set; }
        /// <summary>
        /// Default the Break Point 13 when enter new IATA or Freight Quotation
        /// </summary>
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? DefWeightBreak13 { get; set; }
        /// <summary>
        /// Default the Break Point 14 when enter new IATA or Freight Quotation
        /// </summary>
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? DefWeightBreak14 { get; set; }
        /// <summary>
        /// Default the Break Point 15 when enter new IATA or Freight Quotation
        /// </summary>
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? DefWeightBreak15 { get; set; }
        /// <summary>
        /// Default the Break Point 16 when enter new IATA or Freight Quotation
        /// </summary>
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? DefWeightBreak16 { get; set; }
        /// <summary>
        /// Default to aeaw1 KaLbFlag
        /// </summary>
        [StringLength(1)]
        public string? DefWeightType { get; set; }
        /// <summary>
        /// Quotation No format
        /// - If set as 1, Quotation No format is Quotation Type(2 digits) + Salesman Code(2 digits) + YY + Next No
        /// - If leave blank, Quotation No format is Salesman Code + ‘-‘ + A + No(5 digits)
        /// </summary>
        [StringLength(1)]
        public string? FormatType { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(1)]
        public string? HideCostRateFlag { get; set; }
        /// <summary>
        /// The percentage to mark the Currency Rate
        /// </summary>
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? MarkupRate { get; set; }
        /// <summary>
        /// Set Next Quote No for Freight Quotation(Amfq1)
        /// </summary>
        [StringLength(10)]
        public string? NextQuoteNo { get; set; }
        /// <summary>
        /// Set as Y, show JobCostingRemark as a column instead of picture icon.
        /// </summary>
        [StringLength(1)]
        public string? ShowJobCostingRemarkFlag { get; set; }
        [StringLength(1)]
        public string? ShowQuotationNoFlag { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(16)]
        public string? Validity { get; set; }
        /// <summary>
        /// Default No. of Day of Validity Days to Freight Quotation
        /// </summary>
        public short? ValidityDays { get; set; }
        [StringLength(3)]
        public string StatusCode { get; set; } = null!;
        [StringLength(50)]
        public string CreateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CreateDateTime { get; set; }
        [StringLength(50)]
        public string UpdateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime UpdateDateTime { get; set; }
    }
}
