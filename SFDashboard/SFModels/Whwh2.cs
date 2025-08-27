using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("whwh2")]
    public partial class Whwh2
    {
        [Key]
        [StringLength(6)]
        public string WarehouseCode { get; set; } = null!;
        [Key]
        public int LineItemNo { get; set; }
        [StringLength(14)]
        public string? StoreNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? BalanceSpace { get; set; }
        [StringLength(1)]
        public string? BillFlag { get; set; }
        public int? BinQty { get; set; }
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Height { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Length { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? PalletSpace { get; set; }
        [StringLength(1)]
        public string? PhasePickingFlag { get; set; }
        [StringLength(1)]
        public string? PickFlag { get; set; }
        [StringLength(1)]
        public string? StagingAreaFlag { get; set; }
        [StringLength(50)]
        public string? StoreLocation { get; set; }
        public int? StoreQty { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? StoreSpace { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? UsedSpace { get; set; }
        [StringLength(1)]
        public string? UserFlag { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Width { get; set; }
    }
}
