using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwImpv2
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Line Item No")]
        public short LineItemNo { get; set; }
        [Column("Business Party Code")]
        [StringLength(10)]
        public string? BusinessPartyCode { get; set; }
        [Column("Customer Code")]
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [Column("Goods Receipt Note Or Goods Issue Note No")]
        [StringLength(11)]
        public string? GoodsReceiptNoteOrGoodsIssueNoteNo { get; set; }
        [Column("Loose Qty")]
        public int? LooseQty { get; set; }
        [Column("Lot No")]
        [StringLength(20)]
        public string? LotNo { get; set; }
        [Column("Part No Trx No")]
        public int? PartNoTrxNo { get; set; }
        [Column("Permit No")]
        [StringLength(20)]
        public string? PermitNo { get; set; }
        [Column("Product Code")]
        [StringLength(24)]
        public string? ProductCode { get; set; }
        [Column("Receipt Or Issue Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ReceiptOrIssueDate { get; set; }
        [Column("Receipt Or Issue Trx No")]
        public int? ReceiptOrIssueTrxNo { get; set; }
        [Column("Space Area", TypeName = "decimal(13, 4)")]
        public decimal? SpaceArea { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Volume { get; set; }
        [Column("Warehouse Code")]
        [StringLength(6)]
        public string? WarehouseCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Weight { get; set; }
        [Column("Whole Qty")]
        public int? WholeQty { get; set; }
    }
}
