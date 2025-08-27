using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSmic2
    {
        [Column("Line Item No")]
        public short LineItemNo { get; set; }
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Commodity Code")]
        [StringLength(10)]
        public string? CommodityCode { get; set; }
        [Column("Container Type 01")]
        [StringLength(5)]
        public string? ContainerType01 { get; set; }
        [Column("Container Type 02")]
        [StringLength(5)]
        public string? ContainerType02 { get; set; }
        [Column("Container Type 03")]
        [StringLength(5)]
        public string? ContainerType03 { get; set; }
        [Column("Container Type 04")]
        [StringLength(5)]
        public string? ContainerType04 { get; set; }
        [Column("Container Type 05")]
        [StringLength(5)]
        public string? ContainerType05 { get; set; }
        [Column("Container Type 06")]
        [StringLength(5)]
        public string? ContainerType06 { get; set; }
        [Column("Container Type 07")]
        [StringLength(5)]
        public string? ContainerType07 { get; set; }
        [Column("Container Type 08")]
        [StringLength(5)]
        public string? ContainerType08 { get; set; }
        [Column("Container Type 09")]
        [StringLength(5)]
        public string? ContainerType09 { get; set; }
        [Column("Container Type 10")]
        [StringLength(5)]
        public string? ContainerType10 { get; set; }
        [Column("Container Type 11")]
        [StringLength(5)]
        public string? ContainerType11 { get; set; }
        [Column("Container Type 12")]
        [StringLength(5)]
        public string? ContainerType12 { get; set; }
        [Column("Container Type 13")]
        [StringLength(5)]
        public string? ContainerType13 { get; set; }
        [Column("Container Type 14")]
        [StringLength(5)]
        public string? ContainerType14 { get; set; }
        [Column("Container Type 15")]
        [StringLength(5)]
        public string? ContainerType15 { get; set; }
        [Column("Lcl Volume", TypeName = "decimal(13, 4)")]
        public decimal? LclVolume { get; set; }
        [Column("Lcl Weight", TypeName = "decimal(8, 0)")]
        public decimal? LclWeight { get; set; }
        [Column("Rate 01", TypeName = "decimal(13, 3)")]
        public decimal? Rate01 { get; set; }
        [Column("Rate 02", TypeName = "decimal(13, 3)")]
        public decimal? Rate02 { get; set; }
        [Column("Rate 03", TypeName = "decimal(13, 3)")]
        public decimal? Rate03 { get; set; }
        [Column("Rate 04", TypeName = "decimal(13, 3)")]
        public decimal? Rate04 { get; set; }
        [Column("Rate 05", TypeName = "decimal(13, 3)")]
        public decimal? Rate05 { get; set; }
        [Column("Rate 06", TypeName = "decimal(13, 3)")]
        public decimal? Rate06 { get; set; }
        [Column("Rate 07", TypeName = "decimal(13, 3)")]
        public decimal? Rate07 { get; set; }
        [Column("Rate 08", TypeName = "decimal(13, 3)")]
        public decimal? Rate08 { get; set; }
        [Column("Rate 09", TypeName = "decimal(13, 3)")]
        public decimal? Rate09 { get; set; }
        [Column("Rate 10", TypeName = "decimal(13, 3)")]
        public decimal? Rate10 { get; set; }
        [Column("Rate 11", TypeName = "decimal(13, 3)")]
        public decimal? Rate11 { get; set; }
        [Column("Rate 12", TypeName = "decimal(13, 3)")]
        public decimal? Rate12 { get; set; }
        [Column("Rate 13", TypeName = "decimal(13, 3)")]
        public decimal? Rate13 { get; set; }
        [Column("Rate 14", TypeName = "decimal(13, 3)")]
        public decimal? Rate14 { get; set; }
        [Column("Rate 15", TypeName = "decimal(13, 3)")]
        public decimal? Rate15 { get; set; }
    }
}
