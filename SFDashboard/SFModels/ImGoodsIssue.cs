using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class ImGoodsIssue
    {
        public int TrxNo { get; set; }
        [StringLength(20)]
        public string GoodsIssueNoteNo { get; set; } = null!;
        [StringLength(50)]
        public string? RefNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? IssueDateTime { get; set; }
        [StringLength(10)]
        public string? DeliveryToCode { get; set; }
        [StringLength(80)]
        public string? DeliveryToName { get; set; }
        [StringLength(10)]
        public string? TransportCompanyCode { get; set; }
        [StringLength(80)]
        public string? TransportCompanyName { get; set; }
        [StringLength(50)]
        public string? Description1 { get; set; }
        [StringLength(50)]
        public string? Description2 { get; set; }
        [StringLength(20)]
        public string? PurchaseOrderNo { get; set; }
        [StringLength(2000)]
        public string? DeliveryOrderNo { get; set; }
        [StringLength(50)]
        public string? IssueBy { get; set; }
        [StringLength(50)]
        public string? IssueTo { get; set; }
        [StringLength(3)]
        public string Status { get; set; } = null!;
        public short LineItemNo { get; set; }
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [StringLength(20)]
        public string? GoodsReceiveNoteNo { get; set; }
        public int? ReceiptMovementTrxNo { get; set; }
        [StringLength(255)]
        public string? ProductCode { get; set; }
        [StringLength(255)]
        public string? ProductDescription { get; set; }
        public int? PackingQty { get; set; }
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
        [StringLength(14)]
        public string? StoreNo { get; set; }
        [StringLength(12)]
        public string? BatchNo { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [StringLength(50)]
        public string? UserDefine1 { get; set; }
        [StringLength(50)]
        public string? UserDefine2 { get; set; }
        [StringLength(50)]
        public string? UserDefine3 { get; set; }
    }
}
