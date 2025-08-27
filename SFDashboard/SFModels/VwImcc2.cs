using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwImcc2
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Line Item No")]
        public short LineItemNo { get; set; }
        [Column("Loose Qty")]
        public int? LooseQty { get; set; }
        [Column("Movement Trx No")]
        public int? MovementTrxNo { get; set; }
        [Column("Org Loose Qty")]
        public int? OrgLooseQty { get; set; }
        [Column("Org On Hand Loose Qty")]
        public int? OrgOnHandLooseQty { get; set; }
        [Column("Org On Hand Packing Qty")]
        public int? OrgOnHandPackingQty { get; set; }
        [Column("Org On Hand Whole Qty")]
        public int? OrgOnHandWholeQty { get; set; }
        [Column("Org Packing Qty")]
        public int? OrgPackingQty { get; set; }
        [Column("Org Space Area", TypeName = "numeric(13, 4)")]
        public decimal? OrgSpaceArea { get; set; }
        [Column("Org Volume", TypeName = "numeric(13, 4)")]
        public decimal? OrgVolume { get; set; }
        [Column("Org Weight", TypeName = "numeric(13, 4)")]
        public decimal? OrgWeight { get; set; }
        [Column("Org Whole Qty")]
        public int? OrgWholeQty { get; set; }
        [Column("Packing Qty")]
        public int? PackingQty { get; set; }
        [Column("Product Trx No")]
        public int? ProductTrxNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Space Area", TypeName = "numeric(13, 4)")]
        public decimal? SpaceArea { get; set; }
        [Column("Store No")]
        [StringLength(14)]
        public string? StoreNo { get; set; }
        [Column(TypeName = "numeric(13, 4)")]
        public decimal? Volume { get; set; }
        [Column("Warehouse Code")]
        [StringLength(6)]
        public string? WarehouseCode { get; set; }
        [Column(TypeName = "numeric(13, 4)")]
        public decimal? Weight { get; set; }
        [Column("Whole Qty")]
        public int? WholeQty { get; set; }
        [Column("Updated By")]
        [StringLength(50)]
        public string? UpdatedBy { get; set; }
    }
}
