using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("amie1")]
    public partial class Amie1
    {
        [Key]
        public int TrxNo { get; set; }
        [Column("AirlineID")]
        [StringLength(2)]
        public string AirlineId { get; set; } = null!;
        [StringLength(50)]
        public string? AirlineName { get; set; }
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
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? BreakPoint11 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? BreakPoint12 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? BreakPoint13 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? BreakPoint14 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? BreakPoint15 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? BreakPoint16 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? BreakPoint17 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? BreakPoint18 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? BreakPoint19 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? BreakPoint20 { get; set; }
        [StringLength(3)]
        public string? ByAirlineCode { get; set; }
        [StringLength(50)]
        public string? CommodityCode01 { get; set; }
        [StringLength(50)]
        public string? CommodityCode02 { get; set; }
        [StringLength(50)]
        public string? CommodityCode03 { get; set; }
        [StringLength(50)]
        public string? CommodityCode04 { get; set; }
        [StringLength(50)]
        public string? CommodityCode05 { get; set; }
        [StringLength(50)]
        public string? CommodityCode06 { get; set; }
        [StringLength(50)]
        public string? CommodityCode07 { get; set; }
        [StringLength(50)]
        public string? CommodityCode08 { get; set; }
        [StringLength(50)]
        public string? CommodityCode09 { get; set; }
        [StringLength(50)]
        public string? CommodityCode10 { get; set; }
        [StringLength(50)]
        public string? CommodityCode11 { get; set; }
        [StringLength(50)]
        public string? CommodityCode12 { get; set; }
        [StringLength(50)]
        public string? CommodityCode13 { get; set; }
        [StringLength(50)]
        public string? CommodityCode14 { get; set; }
        [StringLength(50)]
        public string? CommodityCode15 { get; set; }
        [StringLength(50)]
        public string? CommodityCode16 { get; set; }
        [StringLength(50)]
        public string? CommodityCode17 { get; set; }
        [StringLength(50)]
        public string? CommodityCode18 { get; set; }
        [StringLength(50)]
        public string? CommodityCode19 { get; set; }
        [StringLength(50)]
        public string? CommodityCode20 { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [StringLength(10)]
        public string CustomerCode { get; set; } = null!;
        [StringLength(5)]
        public string DeliveryType { get; set; } = null!;
        [StringLength(3)]
        public string DestCode { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime? FirstFlightDate { get; set; }
        [StringLength(6)]
        public string FlightNo { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime? LastQuoteDate { get; set; }
        [StringLength(10)]
        public string? LastQuoteNo { get; set; }
        [StringLength(3)]
        public string OriginCode { get; set; } = null!;
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? QuoteAmt01 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? QuoteAmt02 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? QuoteAmt03 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? QuoteAmt04 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? QuoteAmt05 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? QuoteAmt06 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? QuoteAmt07 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? QuoteAmt08 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? QuoteAmt09 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? QuoteAmt10 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? QuoteAmt11 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? QuoteAmt12 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? QuoteAmt13 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? QuoteAmt14 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? QuoteAmt15 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? QuoteAmt16 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? QuoteAmt17 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? QuoteAmt18 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? QuoteAmt19 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? QuoteAmt20 { get; set; }
        [StringLength(10)]
        public string? QuoteApproveCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? QuoteDate { get; set; }
        [StringLength(10)]
        public string? QuoteNo { get; set; }
        [StringLength(1)]
        public string? RateClassCode01 { get; set; }
        [StringLength(1)]
        public string? RateClassCode02 { get; set; }
        [StringLength(1)]
        public string? RateClassCode03 { get; set; }
        [StringLength(1)]
        public string? RateClassCode04 { get; set; }
        [StringLength(1)]
        public string? RateClassCode05 { get; set; }
        [StringLength(1)]
        public string? RateClassCode06 { get; set; }
        [StringLength(1)]
        public string? RateClassCode07 { get; set; }
        [StringLength(1)]
        public string? RateClassCode08 { get; set; }
        [StringLength(1)]
        public string? RateClassCode09 { get; set; }
        [StringLength(1)]
        public string? RateClassCode10 { get; set; }
        [StringLength(1)]
        public string? RateClassCode11 { get; set; }
        [StringLength(1)]
        public string? RateClassCode12 { get; set; }
        [StringLength(1)]
        public string? RateClassCode13 { get; set; }
        [StringLength(1)]
        public string? RateClassCode14 { get; set; }
        [StringLength(1)]
        public string? RateClassCode15 { get; set; }
        [StringLength(1)]
        public string? RateClassCode16 { get; set; }
        [StringLength(1)]
        public string? RateClassCode17 { get; set; }
        [StringLength(1)]
        public string? RateClassCode18 { get; set; }
        [StringLength(1)]
        public string? RateClassCode19 { get; set; }
        [StringLength(1)]
        public string? RateClassCode20 { get; set; }
        [StringLength(30)]
        public string? RefNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        public short? RevisionNo { get; set; }
        [StringLength(10)]
        public string? SalesmanCode { get; set; }
        [StringLength(1)]
        public string Type { get; set; } = null!;
        [StringLength(1)]
        public string? WeightType { get; set; }
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
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
    }
}
