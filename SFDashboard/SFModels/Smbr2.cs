using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("smbr2")]
    public partial class Smbr2
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
        [StringLength(3)]
        public string CurrCode { get; set; } = null!;
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? LclVolume { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? LclWeight { get; set; }
        [StringLength(3)]
        public string DestCode { get; set; } = null!;
        [StringLength(3)]
        public string OriginCode { get; set; } = null!;
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
        [StringLength(5)]
        public string Via { get; set; } = null!;

        [ForeignKey("TrxNo")]
        [InverseProperty("Smbr2s")]
        public virtual Smbr1 TrxNoNavigation { get; set; } = null!;
    }
}
