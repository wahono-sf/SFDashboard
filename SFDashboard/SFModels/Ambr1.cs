using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("ambr1")]
    public partial class Ambr1
    {
        [Key]
        public int TrxNo { get; set; }
        [Column("AirlineID")]
        [StringLength(2)]
        public string AirlineId { get; set; } = null!;
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
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? CollectRate01 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? CollectRate02 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? CollectRate03 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? CollectRate04 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? CollectRate05 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? CollectRate06 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? CollectRate07 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? CollectRate08 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? CollectRate09 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? CollectRate10 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? CollectRate11 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? CollectRate12 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? CollectRate13 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? CollectRate14 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? CollectRate15 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? CollectRate16 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? CollectRate17 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? CollectRate18 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? CollectRate19 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? CollectRate20 { get; set; }
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
        [StringLength(5)]
        public string DeliveryType { get; set; } = null!;
        [StringLength(3)]
        public string DestCode { get; set; } = null!;
        [StringLength(3)]
        public string OriginCode { get; set; } = null!;
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
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? RetailRate01 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? RetailRate02 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? RetailRate03 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? RetailRate04 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? RetailRate05 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? RetailRate06 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? RetailRate07 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? RetailRate08 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? RetailRate09 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? RetailRate10 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? RetailRate11 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? RetailRate12 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? RetailRate13 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? RetailRate14 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? RetailRate15 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? RetailRate16 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? RetailRate17 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? RetailRate18 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? RetailRate19 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? RetailRate20 { get; set; }
        public short? RevisionNo { get; set; }
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
