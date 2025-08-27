using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class ImGoodsRcvIssue
    {
        [StringLength(20)]
        public string GoodsReceiptNoteNo { get; set; } = null!;
        [StringLength(50)]
        public string? RcvRefNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReceiptDate { get; set; }
        [StringLength(50)]
        public string? RcvDeliveryOrderNo { get; set; }
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [StringLength(255)]
        public string? ProductCode { get; set; }
        [StringLength(255)]
        public string? ProductDescription { get; set; }
        [StringLength(14)]
        public string? StoreNo { get; set; }
        public int? PackingQty { get; set; }
        public int? WholeQty { get; set; }
        public int? LooseQty { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Volume { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Weight { get; set; }
        [StringLength(6)]
        public string? WarehouseCode { get; set; }
        [StringLength(50)]
        public string? BrandName { get; set; }
        [StringLength(50)]
        public string? RcvRemark { get; set; }
        [StringLength(50)]
        public string? RcvPurchaseOrderNo { get; set; }
        [StringLength(50)]
        public string? PackingRefNo { get; set; }
        [StringLength(20)]
        public string GoodsIssueNoteNo { get; set; } = null!;
        [StringLength(50)]
        public string? IssueRefNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? IssueDateTime { get; set; }
        [StringLength(80)]
        public string? DeliveryToName { get; set; }
        [StringLength(80)]
        public string? TransportCompanyName { get; set; }
        [StringLength(20)]
        public string? IssuePurchaseOrderNo { get; set; }
        [StringLength(2000)]
        public string? IssueDeliveryOrderNo { get; set; }
        [StringLength(3)]
        public string? Status { get; set; }
        [StringLength(6)]
        public string? IssueWarehouseCode { get; set; }
        [StringLength(14)]
        public string? IssueStoreNo { get; set; }
        public int? IssuePackingQty { get; set; }
        public int? IssueWholeQty { get; set; }
        public int? IssueLooseQty { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? IssueVolume { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? IssueWeight { get; set; }
        [StringLength(50)]
        public string? IssueRemark { get; set; }
        [StringLength(50)]
        public string? InvNo { get; set; }
        [StringLength(50)]
        public string? PkNo { get; set; }
    }
}
