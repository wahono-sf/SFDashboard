using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class ImGrnByPackingNo
    {
        [Column("Customer Code")]
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [StringLength(80)]
        public string? Name { get; set; }
        [Column("Receipt Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ReceiptDate { get; set; }
        [Column("Goods Receipt Note No")]
        [StringLength(20)]
        public string GoodsReceiptNoteNo { get; set; } = null!;
        [Column("Delivery Order No")]
        [StringLength(50)]
        public string? DeliveryOrderNo { get; set; }
        [Column("Invoice No")]
        [StringLength(50)]
        public string? InvoiceNo { get; set; }
        public int? TrxNo { get; set; }
        public short? LineItemNo { get; set; }
        public int? BarCodePrintQty { get; set; }
        [StringLength(50)]
        public string? BrandName { get; set; }
        [StringLength(2)]
        public string? CountryOfOrigin { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("CustomerCode")]
        [StringLength(10)]
        public string? CustomerCode1 { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [StringLength(1)]
        public string? DimensionFlag { get; set; }
        [StringLength(1)]
        public string? EnterSerialNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ExpiryDate { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Height { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Length { get; set; }
        public int? LooseQty { get; set; }
        [StringLength(20)]
        public string? LotNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ManufactureDate { get; set; }
        public int? MovementTrxNo { get; set; }
        public int? OrderTrxNo { get; set; }
        [StringLength(50)]
        public string? PackingNo { get; set; }
        public int? PackingQty { get; set; }
        public int? PartNoTrxNo { get; set; }
        [StringLength(20)]
        public string? PermitNo { get; set; }
        public int? PoLineItemNo { get; set; }
        [StringLength(50)]
        public string? PoNo { get; set; }
        [StringLength(255)]
        public string? ProductCode { get; set; }
        [StringLength(255)]
        public string? ProductDescription { get; set; }
        public int? ProductTrxNo { get; set; }
        public int? QtyPerPallet { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Rate { get; set; }
        [StringLength(1)]
        public string? RateClassCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? SpaceArea { get; set; }
        [StringLength(50)]
        public string? StoreLocation { get; set; }
        [StringLength(14)]
        public string? StoreNo { get; set; }
        [StringLength(3)]
        public string? UomCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? UnitVol { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? UnitWt { get; set; }
        [StringLength(50)]
        public string? UserDefine1 { get; set; }
        [StringLength(50)]
        public string? UserDefine2 { get; set; }
        [StringLength(50)]
        public string? UserDefine3 { get; set; }
        [StringLength(50)]
        public string? UserDefine4 { get; set; }
        [StringLength(50)]
        public string? UserDefine5 { get; set; }
        [StringLength(50)]
        public string? UserDefine6 { get; set; }
        [StringLength(50)]
        public string? UserDefine7 { get; set; }
        [StringLength(50)]
        public string? UserDefine8 { get; set; }
        [StringLength(50)]
        public string? UserDefine9 { get; set; }
        [StringLength(50)]
        public string? UserDefine10 { get; set; }
        [StringLength(50)]
        public string? UserDefine11 { get; set; }
        [StringLength(50)]
        public string? UserDefine12 { get; set; }
        [StringLength(50)]
        public string? UserDefine13 { get; set; }
        [StringLength(50)]
        public string? UserDefine14 { get; set; }
        [StringLength(50)]
        public string? UserDefine15 { get; set; }
        [StringLength(50)]
        public string? UserDefine16 { get; set; }
        [StringLength(50)]
        public string? UserDefine17 { get; set; }
        [StringLength(50)]
        public string? UserDefine18 { get; set; }
        [StringLength(50)]
        public string? UserDefine19 { get; set; }
        [StringLength(50)]
        public string? UserDefine20 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ValueOfGoods { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Volume { get; set; }
        [StringLength(6)]
        public string? WarehouseCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Weight { get; set; }
        public int? WholeQty { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Width { get; set; }
        [StringLength(50)]
        public string? UpdateBy { get; set; }
    }
}
