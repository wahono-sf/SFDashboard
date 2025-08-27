using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("amif1")]
    public partial class Amif1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(10)]
        public string AgentCode { get; set; } = null!;
        [StringLength(50)]
        public string? AuthoriseBy { get; set; }
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
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [StringLength(3)]
        public string DestCode { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime? EffectiveDate { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? NetRate01 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? NetRate02 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? NetRate03 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? NetRate04 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? NetRate05 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? NetRate06 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? NetRate07 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? NetRate08 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? NetRate09 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? NetRate10 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? NetRate11 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? NetRate12 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? NetRate13 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? NetRate14 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? NetRate15 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? NetRate16 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? NetRate17 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? NetRate18 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? NetRate19 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? NetRate20 { get; set; }
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
        [StringLength(30)]
        public string? RefNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
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

        [ForeignKey("CommodityCode01")]
        [InverseProperty("Amif1CommodityCode01Navigations")]
        public virtual Rccm1? CommodityCode01Navigation { get; set; }
        [ForeignKey("CommodityCode02")]
        [InverseProperty("Amif1CommodityCode02Navigations")]
        public virtual Rccm1? CommodityCode02Navigation { get; set; }
        [ForeignKey("CommodityCode03")]
        [InverseProperty("Amif1CommodityCode03Navigations")]
        public virtual Rccm1? CommodityCode03Navigation { get; set; }
        [ForeignKey("CommodityCode04")]
        [InverseProperty("Amif1CommodityCode04Navigations")]
        public virtual Rccm1? CommodityCode04Navigation { get; set; }
        [ForeignKey("CommodityCode05")]
        [InverseProperty("Amif1CommodityCode05Navigations")]
        public virtual Rccm1? CommodityCode05Navigation { get; set; }
        [ForeignKey("CommodityCode06")]
        [InverseProperty("Amif1CommodityCode06Navigations")]
        public virtual Rccm1? CommodityCode06Navigation { get; set; }
        [ForeignKey("CommodityCode07")]
        [InverseProperty("Amif1CommodityCode07Navigations")]
        public virtual Rccm1? CommodityCode07Navigation { get; set; }
        [ForeignKey("CommodityCode08")]
        [InverseProperty("Amif1CommodityCode08Navigations")]
        public virtual Rccm1? CommodityCode08Navigation { get; set; }
        [ForeignKey("CommodityCode09")]
        [InverseProperty("Amif1CommodityCode09Navigations")]
        public virtual Rccm1? CommodityCode09Navigation { get; set; }
        [ForeignKey("CommodityCode10")]
        [InverseProperty("Amif1CommodityCode10Navigations")]
        public virtual Rccm1? CommodityCode10Navigation { get; set; }
        [ForeignKey("CommodityCode11")]
        [InverseProperty("Amif1CommodityCode11Navigations")]
        public virtual Rccm1? CommodityCode11Navigation { get; set; }
        [ForeignKey("CommodityCode12")]
        [InverseProperty("Amif1CommodityCode12Navigations")]
        public virtual Rccm1? CommodityCode12Navigation { get; set; }
        [ForeignKey("CommodityCode13")]
        [InverseProperty("Amif1CommodityCode13Navigations")]
        public virtual Rccm1? CommodityCode13Navigation { get; set; }
        [ForeignKey("CommodityCode14")]
        [InverseProperty("Amif1CommodityCode14Navigations")]
        public virtual Rccm1? CommodityCode14Navigation { get; set; }
        [ForeignKey("CommodityCode15")]
        [InverseProperty("Amif1CommodityCode15Navigations")]
        public virtual Rccm1? CommodityCode15Navigation { get; set; }
        [ForeignKey("CommodityCode16")]
        [InverseProperty("Amif1CommodityCode16Navigations")]
        public virtual Rccm1? CommodityCode16Navigation { get; set; }
        [ForeignKey("CommodityCode17")]
        [InverseProperty("Amif1CommodityCode17Navigations")]
        public virtual Rccm1? CommodityCode17Navigation { get; set; }
        [ForeignKey("CommodityCode18")]
        [InverseProperty("Amif1CommodityCode18Navigations")]
        public virtual Rccm1? CommodityCode18Navigation { get; set; }
        [ForeignKey("CommodityCode19")]
        [InverseProperty("Amif1CommodityCode19Navigations")]
        public virtual Rccm1? CommodityCode19Navigation { get; set; }
        [ForeignKey("CommodityCode20")]
        [InverseProperty("Amif1CommodityCode20Navigations")]
        public virtual Rccm1? CommodityCode20Navigation { get; set; }
        [ForeignKey("CurrCode")]
        [InverseProperty("Amif1s")]
        public virtual Glex1? CurrCodeNavigation { get; set; }
        [ForeignKey("DestCode")]
        [InverseProperty("Amif1DestCodeNavigations")]
        public virtual Rcap1 DestCodeNavigation { get; set; } = null!;
        [ForeignKey("OriginCode")]
        [InverseProperty("Amif1OriginCodeNavigations")]
        public virtual Rcap1 OriginCodeNavigation { get; set; } = null!;
    }
}
