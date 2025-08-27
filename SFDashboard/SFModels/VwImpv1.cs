using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwImpv1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Available Qty")]
        public int? AvailableQty { get; set; }
        [Column("Available Qty 1")]
        public int? AvailableQty1 { get; set; }
        [Column("Customer Code")]
        [StringLength(10)]
        public string CustomerCode { get; set; } = null!;
        [Column("Customer Name")]
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [Column("Incoming Qty")]
        public int? IncomingQty { get; set; }
        [Column("Incoming Qty 1")]
        public int? IncomingQty1 { get; set; }
        [Column("Last Year Units", TypeName = "decimal(13, 2)")]
        public decimal? LastYearUnits { get; set; }
        [Column("Loose Qty")]
        public int? LooseQty { get; set; }
        [Column("Mtd Units", TypeName = "decimal(13, 2)")]
        public decimal? MtdUnits { get; set; }
        [Column("On Order Qty")]
        public int? OnOrderQty { get; set; }
        [Column("On Order Qty 1")]
        public int? OnOrderQty1 { get; set; }
        [Column("Product Class Code")]
        [StringLength(10)]
        public string? ProductClassCode { get; set; }
        [Column("Product Code")]
        [StringLength(24)]
        public string ProductCode { get; set; } = null!;
        public int? Qty { get; set; }
        [Column("Qty On Hand")]
        public int? QtyOnHand { get; set; }
        [Column("Qty On Hand 1")]
        public int? QtyOnHand1 { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Reserved Qty")]
        public int? ReservedQty { get; set; }
        [Column("Reserved Qty 1")]
        public int? ReservedQty1 { get; set; }
        [Column("Uom Code")]
        [StringLength(3)]
        public string? UomCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Volume { get; set; }
        [Column("Warehouse Code")]
        [StringLength(6)]
        public string? WarehouseCode { get; set; }
        [Column("Warehouse Location")]
        [StringLength(50)]
        public string? WarehouseLocation { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Weight { get; set; }
        [Column("Space Area", TypeName = "decimal(13, 4)")]
        public decimal? SpaceArea { get; set; }
        [Column("Whole Qty")]
        public int? WholeQty { get; set; }
        [Column("Ytd Units", TypeName = "decimal(13, 2)")]
        public decimal? YtdUnits { get; set; }
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
