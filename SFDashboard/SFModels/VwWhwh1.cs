using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwWhwh1
    {
        [Column("Warehouse Code")]
        [StringLength(6)]
        public string WarehouseCode { get; set; } = null!;
        [Column("Warehouse Name")]
        [StringLength(80)]
        public string? WarehouseName { get; set; }
        [Column("Address 1")]
        [StringLength(50)]
        public string? Address1 { get; set; }
        [Column("Address 2")]
        [StringLength(50)]
        public string? Address2 { get; set; }
        [Column("Address 3")]
        [StringLength(50)]
        public string? Address3 { get; set; }
        [Column("Address 4")]
        [StringLength(50)]
        public string? Address4 { get; set; }
        [Column("Aisle Number Length")]
        [StringLength(3)]
        public string? AisleNumberLength { get; set; }
        [Column("Aisle Separator")]
        [StringLength(1)]
        public string? AisleSeparator { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Balance Space", TypeName = "decimal(13, 2)")]
        public decimal? BalanceSpace { get; set; }
        [Column("City Code")]
        [StringLength(3)]
        public string? CityCode { get; set; }
        [Column("City Name")]
        [StringLength(45)]
        public string? CityName { get; set; }
        [Column("Contact Name")]
        [StringLength(50)]
        public string? ContactName { get; set; }
        [Column("Country Code")]
        [StringLength(2)]
        public string? CountryCode { get; set; }
        [Column("Default Storage Charge Code")]
        [StringLength(30)]
        public string? DefaultStorageChargeCode { get; set; }
        [StringLength(12)]
        public string? Fax { get; set; }
        [Column("Job No")]
        [StringLength(30)]
        public string? JobNo { get; set; }
        [Column("Job Type")]
        [StringLength(10)]
        public string? JobType { get; set; }
        [Column("Licensed Flag")]
        [StringLength(1)]
        public string? LicensedFlag { get; set; }
        [StringLength(50)]
        public string? Position { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Section Number Length")]
        [StringLength(3)]
        public string? SectionNumberLength { get; set; }
        [Column("Section Separator")]
        [StringLength(1)]
        public string? SectionSeparator { get; set; }
        [Column("Shelf Number Length")]
        [StringLength(3)]
        public string? ShelfNumberLength { get; set; }
        [Column("Space Description")]
        [StringLength(50)]
        public string? SpaceDescription { get; set; }
        [Column("Space Type")]
        [StringLength(3)]
        public string? SpaceType { get; set; }
        [Column("Store Separator Flag")]
        [StringLength(1)]
        public string? StoreSeparatorFlag { get; set; }
        [StringLength(12)]
        public string? Telephone { get; set; }
        [Column("Total Space", TypeName = "decimal(13, 2)")]
        public decimal? TotalSpace { get; set; }
        [Column("Uom Code")]
        [StringLength(50)]
        public string? UomCode { get; set; }
        [Column("Used Space", TypeName = "decimal(13, 2)")]
        public decimal? UsedSpace { get; set; }
        [Column("Created By")]
        [StringLength(50)]
        public string CreatedBy { get; set; } = null!;
        [Column("Created At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CreatedAt { get; set; }
        [Column("Updated By")]
        [StringLength(50)]
        public string UpdatedBy { get; set; } = null!;
        [Column("Updated At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? UpdatedAt { get; set; }
        [StringLength(3)]
        public string Status { get; set; } = null!;
    }
}
