using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwImip1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("In Product Code")]
        [StringLength(24)]
        public string? InProductCode { get; set; }
        [Column("In Qty")]
        public int? InQty { get; set; }
        [Column("In Qty 1")]
        public int? InQty1 { get; set; }
        [Column("In Warehouse Code")]
        [StringLength(6)]
        public string? InWarehouseCode { get; set; }
        [Column("Out Product Code")]
        [StringLength(24)]
        public string? OutProductCode { get; set; }
        [Column("Out Qty")]
        public int? OutQty { get; set; }
        [Column("Out Qty 1")]
        public int? OutQty1 { get; set; }
        [Column("Out Space", TypeName = "decimal(13, 4)")]
        public decimal? OutSpace { get; set; }
        [Column("Out Volume", TypeName = "decimal(13, 4)")]
        public decimal? OutVolume { get; set; }
        [Column("Out Warehouse Code")]
        [StringLength(6)]
        public string? OutWarehouseCode { get; set; }
        [Column("Out Weight", TypeName = "decimal(13, 4)")]
        public decimal? OutWeight { get; set; }
        [Column("Reference No")]
        [StringLength(6)]
        public string? ReferenceNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Transfer Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? TransferDate { get; set; }
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
