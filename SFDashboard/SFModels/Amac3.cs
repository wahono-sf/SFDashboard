using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    [Table("amac3")]
    public partial class Amac3
    {
        public int TrxNo { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? Amount01 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? Amount02 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? Amount03 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? Amount04 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? Amount05 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? Amount06 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? Amount07 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? Amount08 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? Amount09 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? Amount10 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? Amount11 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? Amount12 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? Amount13 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? Amount14 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? Amount15 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? Amount16 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? Amount17 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? Amount18 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? Amount19 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? Amount20 { get; set; }
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
        [StringLength(1)]
        public string? PercentFlag01 { get; set; }
        [StringLength(1)]
        public string? PercentFlag02 { get; set; }
        [StringLength(1)]
        public string? PercentFlag03 { get; set; }
        [StringLength(1)]
        public string? PercentFlag04 { get; set; }
        [StringLength(1)]
        public string? PercentFlag05 { get; set; }
        [StringLength(1)]
        public string? PercentFlag06 { get; set; }
        [StringLength(1)]
        public string? PercentFlag07 { get; set; }
        [StringLength(1)]
        public string? PercentFlag08 { get; set; }
        [StringLength(1)]
        public string? PercentFlag09 { get; set; }
        [StringLength(1)]
        public string? PercentFlag10 { get; set; }
        [StringLength(1)]
        public string? PercentFlag11 { get; set; }
        [StringLength(1)]
        public string? PercentFlag12 { get; set; }
        [StringLength(1)]
        public string? PercentFlag13 { get; set; }
        [StringLength(1)]
        public string? PercentFlag14 { get; set; }
        [StringLength(1)]
        public string? PercentFlag15 { get; set; }
        [StringLength(1)]
        public string? PercentFlag16 { get; set; }
        [StringLength(1)]
        public string? PercentFlag17 { get; set; }
        [StringLength(1)]
        public string? PercentFlag18 { get; set; }
        [StringLength(1)]
        public string? PercentFlag19 { get; set; }
        [StringLength(1)]
        public string? PercentFlag20 { get; set; }
        [StringLength(10)]
        public string? ProductCode { get; set; }
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
