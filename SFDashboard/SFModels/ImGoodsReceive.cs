using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class ImGoodsReceive
    {
        [StringLength(20)]
        public string GoodsReceiptNoteNo { get; set; } = null!;
        [StringLength(50)]
        public string? RefNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReceiptDate { get; set; }
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        public int TrxNo { get; set; }
        [StringLength(50)]
        public string? Description1 { get; set; }
        [StringLength(50)]
        public string? Description2 { get; set; }
        [StringLength(50)]
        public string? DeliveryOrderNo { get; set; }
        [StringLength(50)]
        public string? ReceiveBy { get; set; }
        [StringLength(50)]
        public string? ReceiveFrom { get; set; }
        [StringLength(3)]
        public string Status { get; set; } = null!;
        public short LineItemNo { get; set; }
        [StringLength(255)]
        public string? ProductCode { get; set; }
        [StringLength(255)]
        public string? ProductDescription { get; set; }
        [StringLength(14)]
        public string? StoreNo { get; set; }
        public int? WholeQty { get; set; }
        public int? LooseQty { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Volume { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Weight { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? SpaceArea { get; set; }
        [StringLength(6)]
        public string? WarehouseCode { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [StringLength(50)]
        public string? BrandName { get; set; }
        public int? PackingQty { get; set; }
        [StringLength(50)]
        public string? UserDefine1 { get; set; }
        [StringLength(50)]
        public string? UserDefine2 { get; set; }
        [StringLength(50)]
        public string? UserDefine3 { get; set; }
    }
}
