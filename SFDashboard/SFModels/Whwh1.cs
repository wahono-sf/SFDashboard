using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("whwh1")]
    public partial class Whwh1
    {
        [Key]
        [StringLength(6)]
        public string WarehouseCode { get; set; } = null!;
        [StringLength(3)]
        public string? SpaceType { get; set; }
        [StringLength(50)]
        public string? SpaceDescription { get; set; }
        [StringLength(50)]
        public string? Address1 { get; set; }
        [StringLength(50)]
        public string? Address2 { get; set; }
        [StringLength(50)]
        public string? Address3 { get; set; }
        [StringLength(50)]
        public string? Address4 { get; set; }
        [StringLength(3)]
        public string? AisleNumberLength { get; set; }
        [StringLength(1)]
        public string? AisleSeparator { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? BalanceSpace { get; set; }
        [StringLength(3)]
        public string? CityCode { get; set; }
        [StringLength(45)]
        public string? CityName { get; set; }
        [StringLength(50)]
        public string? ContactName { get; set; }
        [StringLength(2)]
        public string? CountryCode { get; set; }
        [StringLength(30)]
        public string? DefaultStorageChargeCode { get; set; }
        [StringLength(12)]
        public string? Fax { get; set; }
        [StringLength(30)]
        public string? JobNo { get; set; }
        [StringLength(10)]
        public string? JobType { get; set; }
        [StringLength(1)]
        public string? LicensedFlag { get; set; }
        [StringLength(50)]
        public string? Position { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(3)]
        public string? SectionNumberLength { get; set; }
        [StringLength(1)]
        public string? SectionSeparator { get; set; }
        [StringLength(3)]
        public string? ShelfNumberLength { get; set; }
        [StringLength(1)]
        public string? StoreSeparatorFlag { get; set; }
        [StringLength(12)]
        public string? Telephone { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TotalSpace { get; set; }
        [StringLength(50)]
        public string? UomCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? UsedSpace { get; set; }
        [StringLength(80)]
        public string? WarehouseName { get; set; }
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

        [ForeignKey("UomCode")]
        [InverseProperty("Whwh1s")]
        public virtual Rcum1? UomCodeNavigation { get; set; }
    }
}
