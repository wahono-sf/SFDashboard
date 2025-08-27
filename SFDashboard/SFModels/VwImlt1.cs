using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwImlt1
    {
        [Column("Lot No")]
        [StringLength(20)]
        public string LotNo { get; set; } = null!;
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Available Qty")]
        public int? AvailableQty { get; set; }
        [Column("Available Qty 1")]
        public int? AvailableQty1 { get; set; }
        [Column("Container No")]
        [StringLength(13)]
        public string? ContainerNo { get; set; }
        [Column("Incoming Qty")]
        public int? IncomingQty { get; set; }
        [Column("Incoming Qty 1")]
        public int? IncomingQty1 { get; set; }
        [Column("Loose Qty")]
        public int? LooseQty { get; set; }
        [Column("On Order Qty")]
        public int? OnOrderQty { get; set; }
        [Column("On Order Q Ty 1")]
        public int? OnOrderQTy1 { get; set; }
        [Column("Permit Duty Amt", TypeName = "decimal(13, 2)")]
        public decimal? PermitDutyAmt { get; set; }
        [Column("Permit No")]
        [StringLength(20)]
        public string? PermitNo { get; set; }
        [Column("Permit Qty Unit")]
        [StringLength(3)]
        public string? PermitQtyUnit { get; set; }
        [Column("Permit Unit Weight")]
        public int? PermitUnitWeight { get; set; }
        [Column("Permit Unit Weight Unit")]
        [StringLength(3)]
        public string? PermitUnitWeightUnit { get; set; }
        [Column("Prev Qty")]
        public int? PrevQty { get; set; }
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
        [Column("Space Area", TypeName = "decimal(13, 4)")]
        public decimal? SpaceArea { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Volume { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Weight { get; set; }
        [Column("Whole Qty")]
        public int? WholeQty { get; set; }
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
