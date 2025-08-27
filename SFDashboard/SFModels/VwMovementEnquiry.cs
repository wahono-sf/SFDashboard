using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwMovementEnquiry
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Batch No")]
        [StringLength(12)]
        public string? BatchNo { get; set; }
        [Column("Batch Line Item No")]
        public int? BatchLineItemNo { get; set; }
        [Column("Trx Type")]
        [StringLength(3)]
        [Unicode(false)]
        public string TrxType { get; set; } = null!;
        [Column("Note No")]
        [StringLength(20)]
        public string? NoteNo { get; set; }
        [Column("Note Line Item No")]
        public short? NoteLineItemNo { get; set; }
        [Column("Trx Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? TrxDate { get; set; }
        [Column("Packing No")]
        [StringLength(50)]
        public string? PackingNo { get; set; }
        [Column("Product Code")]
        [StringLength(255)]
        public string? ProductCode { get; set; }
        [Column("Product Description")]
        [StringLength(255)]
        public string? ProductDescription { get; set; }
        [Column("Part No")]
        [StringLength(50)]
        public string? PartNo { get; set; }
        [Column("Ref No")]
        [StringLength(50)]
        public string? RefNo { get; set; }
        [Column("DO Or Inv No")]
        [StringLength(2000)]
        public string? DoOrInvNo { get; set; }
        [Column("Goods User Define 1")]
        [StringLength(50)]
        public string? GoodsUserDefine1 { get; set; }
        [Column("Goods User Define 2")]
        [StringLength(50)]
        public string? GoodsUserDefine2 { get; set; }
        [Column("Goods User Define 3")]
        [StringLength(50)]
        public string? GoodsUserDefine3 { get; set; }
        [Column("GRN User Define 1")]
        [StringLength(50)]
        public string? GrnUserDefine1 { get; set; }
        [Column("GRN User Define 2")]
        [StringLength(50)]
        public string? GrnUserDefine2 { get; set; }
        [Column("GRN User Define 3")]
        [StringLength(50)]
        public string? GrnUserDefine3 { get; set; }
        [Column("GIN User Define 1")]
        [StringLength(50)]
        public string? GinUserDefine1 { get; set; }
        [Column("GIN User Define 2")]
        [StringLength(50)]
        public string? GinUserDefine2 { get; set; }
        [Column("GIN User Define 3")]
        [StringLength(50)]
        public string? GinUserDefine3 { get; set; }
        [Column("Warehouse Code")]
        [StringLength(6)]
        public string? WarehouseCode { get; set; }
        [Column("Store No")]
        [StringLength(14)]
        public string? StoreNo { get; set; }
        [Column("Dimension Flag")]
        [StringLength(1)]
        public string? DimensionFlag { get; set; }
        [Column("Packing Qty")]
        public int? PackingQty { get; set; }
        [Column("Balance Packing Qty")]
        public int? BalancePackingQty { get; set; }
        [Column("Whole Qty")]
        public int? WholeQty { get; set; }
        [Column("Balance Whole Qty")]
        public int? BalanceWholeQty { get; set; }
        [Column("Loose Qty")]
        public int? LooseQty { get; set; }
        [Column("Balance Loose Qty")]
        public int? BalanceLooseQty { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Weight { get; set; }
        [Column("Balance Weight", TypeName = "decimal(13, 4)")]
        public decimal? BalanceWeight { get; set; }
        [Column(TypeName = "decimal(15, 6)")]
        public decimal? Volume { get; set; }
        [Column("Balance Volume", TypeName = "decimal(13, 4)")]
        public decimal? BalanceVolume { get; set; }
        [Column("Update By")]
        [StringLength(50)]
        public string UpdateBy { get; set; } = null!;
        [Column("Update Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? UpdateDateTime { get; set; }
        [Column("Receipt Date", TypeName = "datetime")]
        public DateTime? ReceiptDate { get; set; }
        [Column("Customer Code")]
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [Column("Customer Name")]
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [Column("Lot No")]
        [StringLength(20)]
        public string? LotNo { get; set; }
        [Column("Permit No")]
        [StringLength(20)]
        public string? PermitNo { get; set; }
        [Column("Part No Trx No")]
        public int? PartNoTrxNo { get; set; }
        [Column("MAWB OBL No")]
        [StringLength(50)]
        public string? MawbOblNo { get; set; }
        [Column("Vessel Name")]
        [StringLength(80)]
        public string? VesselName { get; set; }
    }
}
