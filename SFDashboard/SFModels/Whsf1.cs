using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("whsf1")]
    public partial class Whsf1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(6)]
        public string WarehouseCode { get; set; } = null!;
        [Column(TypeName = "decimal(13, 2)")]
        public decimal Area { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? BalanceSpace { get; set; }
        [StringLength(3)]
        public string? Measurement { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? PhysicalMeasurement { get; set; }
        [StringLength(1)]
        public string? RackedFlag { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(14)]
        public string StoreNo { get; set; } = null!;
        [StringLength(50)]
        public string? StoreLocation { get; set; }
        [StringLength(50)]
        public string? SpaceDescription { get; set; }
        [StringLength(3)]
        public string? SpaceType { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TotalSpace { get; set; }
        [StringLength(50)]
        public string? UomCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? UsedSpace { get; set; }
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
