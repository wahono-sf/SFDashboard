using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwWhsf1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal Area { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Balance Space", TypeName = "decimal(13, 2)")]
        public decimal? BalanceSpace { get; set; }
        [StringLength(3)]
        public string? Measurement { get; set; }
        [Column("Physical Measurement", TypeName = "decimal(13, 2)")]
        public decimal? PhysicalMeasurement { get; set; }
        [Column("Racked Flag")]
        [StringLength(1)]
        public string? RackedFlag { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Space Description")]
        [StringLength(50)]
        public string? SpaceDescription { get; set; }
        [Column("Space Type")]
        [StringLength(3)]
        public string? SpaceType { get; set; }
        [Column("Store Location")]
        [StringLength(50)]
        public string? StoreLocation { get; set; }
        [Column("Store No")]
        [StringLength(14)]
        public string StoreNo { get; set; } = null!;
        [Column("Total Space", TypeName = "decimal(13, 2)")]
        public decimal? TotalSpace { get; set; }
        [Column("Uom Code")]
        [StringLength(3)]
        public string? UomCode { get; set; }
        [Column("Used Space", TypeName = "decimal(13, 2)")]
        public decimal? UsedSpace { get; set; }
        [Column("Warehouse Code")]
        [StringLength(6)]
        public string WarehouseCode { get; set; } = null!;
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
