using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwImgi2
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Line Item No")]
        public short LineItemNo { get; set; }
        [Column("Kit Product Line Item No")]
        public short? KitProductLineItemNo { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Bar Code Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? BarCodeDateTime { get; set; }
        [Column("Batch No")]
        [StringLength(12)]
        public string? BatchNo { get; set; }
        [Column("Brand Name")]
        [StringLength(50)]
        public string? BrandName { get; set; }
        [Column("Confirm Qty")]
        public int? ConfirmQty { get; set; }
        [Column("Confirm Qty 1")]
        public int? ConfirmQty1 { get; set; }
        [Column("Customer Code")]
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [Column("Dimension Flag")]
        [StringLength(1)]
        public string? DimensionFlag { get; set; }
        [Column("Duty Amt", TypeName = "decimal(13, 2)")]
        public decimal? DutyAmt { get; set; }
        [Column("Expiry Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ExpiryDate { get; set; }
        [Column("Goods Receive Note No")]
        [StringLength(20)]
        public string? GoodsReceiveNoteNo { get; set; }
        [StringLength(25)]
        public string? Grade { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Height { get; set; }
        [Column("HS Code")]
        [StringLength(8)]
        public string? HsCode { get; set; }
        [Column("HS Product Code")]
        [StringLength(35)]
        public string? HsProductCode { get; set; }
        [Column("HS Product Uom Code")]
        [StringLength(3)]
        public string? HsProductUomCode { get; set; }
        [Column("HS Uom Code")]
        [StringLength(50)]
        public string? HsUomCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Length { get; set; }
        [StringLength(50)]
        public string? Location { get; set; }
        [Column("Loose Qty")]
        public int? LooseQty { get; set; }
        [Column("Lot No")]
        [StringLength(20)]
        public string? LotNo { get; set; }
        [Column("Manufacture Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ManufactureDate { get; set; }
        [Column("Packing No")]
        [StringLength(50)]
        public string? PackingNo { get; set; }
        [Column("Packing Qty")]
        public int? PackingQty { get; set; }
        [Column("Part No")]
        [StringLength(50)]
        public string? PartNo { get; set; }
        [Column("Part No Trx No")]
        public int? PartNoTrxNo { get; set; }
        [Column("Permit No")]
        [StringLength(20)]
        public string? PermitNo { get; set; }
        [Column("Product Code")]
        [StringLength(255)]
        public string? ProductCode { get; set; }
        [Column("Product Description")]
        [StringLength(255)]
        public string? ProductDescription { get; set; }
        [Column("Product Trx No")]
        public int? ProductTrxNo { get; set; }
        [Column("Qty On Hand")]
        public int? QtyOnHand { get; set; }
        [Column("Receipt Movement Trx No")]
        public int? ReceiptMovementTrxNo { get; set; }
        [Column("SO Line Item No")]
        public int? SoLineItemNo { get; set; }
        [Column("SO No")]
        [StringLength(50)]
        public string? SoNo { get; set; }
        [Column("Space Area", TypeName = "decimal(13, 4)")]
        public decimal? SpaceArea { get; set; }
        [Column("Store No")]
        [StringLength(14)]
        public string? StoreNo { get; set; }
        [Column("User Define 1")]
        [StringLength(50)]
        public string? UserDefine1 { get; set; }
        [Column("User Define 2")]
        [StringLength(50)]
        public string? UserDefine2 { get; set; }
        [Column("User Define 3")]
        [StringLength(50)]
        public string? UserDefine3 { get; set; }
        [Column("User Define 4")]
        [StringLength(50)]
        public string? UserDefine4 { get; set; }
        [Column("User Define 5")]
        [StringLength(50)]
        public string? UserDefine5 { get; set; }
        [Column("User Define 6")]
        [StringLength(50)]
        public string? UserDefine6 { get; set; }
        [Column("User Define 7")]
        [StringLength(50)]
        public string? UserDefine7 { get; set; }
        [Column("User Define 8")]
        [StringLength(50)]
        public string? UserDefine8 { get; set; }
        [Column("User Define 9")]
        [StringLength(50)]
        public string? UserDefine9 { get; set; }
        [Column("User Define 10")]
        [StringLength(50)]
        public string? UserDefine10 { get; set; }
        [Column("User Define 11")]
        [StringLength(50)]
        public string? UserDefine11 { get; set; }
        [Column("User Define 12")]
        [StringLength(50)]
        public string? UserDefine12 { get; set; }
        [Column("User Define 13")]
        [StringLength(50)]
        public string? UserDefine13 { get; set; }
        [Column("User Define 14")]
        [StringLength(50)]
        public string? UserDefine14 { get; set; }
        [Column("User Define 15")]
        [StringLength(50)]
        public string? UserDefine15 { get; set; }
        [Column("User Define 16")]
        [StringLength(50)]
        public string? UserDefine16 { get; set; }
        [Column("User Define 17")]
        [StringLength(50)]
        public string? UserDefine17 { get; set; }
        [Column("User Define 18")]
        [StringLength(50)]
        public string? UserDefine18 { get; set; }
        [Column("User Define 19")]
        [StringLength(50)]
        public string? UserDefine19 { get; set; }
        [Column("User Define 20")]
        [StringLength(50)]
        public string? UserDefine20 { get; set; }
        [Column("Uom Code")]
        [StringLength(50)]
        public string? UomCode { get; set; }
        [Column(TypeName = "decimal(15, 6)")]
        public decimal? Volume { get; set; }
        [Column("Warehouse Code")]
        [StringLength(6)]
        public string? WarehouseCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Weight { get; set; }
        [Column("Whole Qty")]
        public int? WholeQty { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Width { get; set; }
        [Column("Update By")]
        [StringLength(50)]
        public string? UpdateBy { get; set; }
    }
}
