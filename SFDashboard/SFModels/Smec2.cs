using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("smec2")]
    public partial class Smec2
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public short LineItemNo { get; set; }
        [StringLength(50)]
        public string? CommodityCode { get; set; }
        [StringLength(5)]
        public string? ContainerType01 { get; set; }
        [StringLength(5)]
        public string? ContainerType02 { get; set; }
        [StringLength(5)]
        public string? ContainerType03 { get; set; }
        [StringLength(5)]
        public string? ContainerType04 { get; set; }
        [StringLength(5)]
        public string? ContainerType05 { get; set; }
        [StringLength(5)]
        public string? ContainerType06 { get; set; }
        [StringLength(5)]
        public string? ContainerType07 { get; set; }
        [StringLength(5)]
        public string? ContainerType08 { get; set; }
        [StringLength(5)]
        public string? ContainerType09 { get; set; }
        [StringLength(5)]
        public string? ContainerType10 { get; set; }
        [StringLength(5)]
        public string? ContainerType11 { get; set; }
        [StringLength(5)]
        public string? ContainerType12 { get; set; }
        [StringLength(5)]
        public string? ContainerType13 { get; set; }
        [StringLength(5)]
        public string? ContainerType14 { get; set; }
        [StringLength(5)]
        public string? ContainerType15 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? LclVolume { get; set; }
        [Column(TypeName = "decimal(8, 0)")]
        public decimal? LclWeight { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? Rate01 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? Rate02 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? Rate03 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? Rate04 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? Rate05 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? Rate06 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? Rate07 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? Rate08 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? Rate09 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? Rate10 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? Rate11 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? Rate12 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? Rate13 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? Rate14 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? Rate15 { get; set; }

        [ForeignKey("CommodityCode")]
        [InverseProperty("Smec2s")]
        public virtual Rccm1? CommodityCodeNavigation { get; set; }
        [ForeignKey("ContainerType01")]
        [InverseProperty("Smec2ContainerType01Navigations")]
        public virtual Rcco1? ContainerType01Navigation { get; set; }
        [ForeignKey("ContainerType02")]
        [InverseProperty("Smec2ContainerType02Navigations")]
        public virtual Rcco1? ContainerType02Navigation { get; set; }
        [ForeignKey("ContainerType03")]
        [InverseProperty("Smec2ContainerType03Navigations")]
        public virtual Rcco1? ContainerType03Navigation { get; set; }
        [ForeignKey("ContainerType04")]
        [InverseProperty("Smec2ContainerType04Navigations")]
        public virtual Rcco1? ContainerType04Navigation { get; set; }
        [ForeignKey("ContainerType05")]
        [InverseProperty("Smec2ContainerType05Navigations")]
        public virtual Rcco1? ContainerType05Navigation { get; set; }
        [ForeignKey("ContainerType06")]
        [InverseProperty("Smec2ContainerType06Navigations")]
        public virtual Rcco1? ContainerType06Navigation { get; set; }
        [ForeignKey("ContainerType07")]
        [InverseProperty("Smec2ContainerType07Navigations")]
        public virtual Rcco1? ContainerType07Navigation { get; set; }
        [ForeignKey("ContainerType08")]
        [InverseProperty("Smec2ContainerType08Navigations")]
        public virtual Rcco1? ContainerType08Navigation { get; set; }
        [ForeignKey("ContainerType09")]
        [InverseProperty("Smec2ContainerType09Navigations")]
        public virtual Rcco1? ContainerType09Navigation { get; set; }
        [ForeignKey("ContainerType10")]
        [InverseProperty("Smec2ContainerType10Navigations")]
        public virtual Rcco1? ContainerType10Navigation { get; set; }
        [ForeignKey("ContainerType11")]
        [InverseProperty("Smec2ContainerType11Navigations")]
        public virtual Rcco1? ContainerType11Navigation { get; set; }
        [ForeignKey("ContainerType12")]
        [InverseProperty("Smec2ContainerType12Navigations")]
        public virtual Rcco1? ContainerType12Navigation { get; set; }
        [ForeignKey("ContainerType13")]
        [InverseProperty("Smec2ContainerType13Navigations")]
        public virtual Rcco1? ContainerType13Navigation { get; set; }
        [ForeignKey("ContainerType14")]
        [InverseProperty("Smec2ContainerType14Navigations")]
        public virtual Rcco1? ContainerType14Navigation { get; set; }
        [ForeignKey("ContainerType15")]
        [InverseProperty("Smec2ContainerType15Navigations")]
        public virtual Rcco1? ContainerType15Navigation { get; set; }
        [ForeignKey("TrxNo")]
        [InverseProperty("Smec2s")]
        public virtual Smec1 TrxNoNavigation { get; set; } = null!;
    }
}
