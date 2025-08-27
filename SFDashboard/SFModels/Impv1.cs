using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("impv1")]
    public partial class Impv1
    {
        [Key]
        public int TrxNo { get; set; }
        public int? AvailableQty { get; set; }
        public int? AvailableQty1 { get; set; }
        [StringLength(10)]
        public string CustomerCode { get; set; } = null!;
        [StringLength(80)]
        public string? CustomerName { get; set; }
        public int? IncomingQty { get; set; }
        public int? IncomingQty1 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYearUnits { get; set; }
        public int? LooseQty { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? MtdUnits { get; set; }
        public int? OnOrderQty { get; set; }
        [Column("OnOrderQTy1")]
        public int? OnOrderQty1 { get; set; }
        [StringLength(10)]
        public string? ProductClassCode { get; set; }
        [StringLength(24)]
        public string ProductCode { get; set; } = null!;
        public int? Qty { get; set; }
        public int? QtyOnHand { get; set; }
        public int? QtyOnHand1 { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        public int? ReservedQty { get; set; }
        public int? ReservedQty1 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? SpaceArea { get; set; }
        [StringLength(50)]
        public string? UomCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Volume { get; set; }
        [StringLength(6)]
        public string? WarehouseCode { get; set; }
        [StringLength(50)]
        public string? WarehouseLocation { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Weight { get; set; }
        public int? WholeQty { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? YtdUnits { get; set; }
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
