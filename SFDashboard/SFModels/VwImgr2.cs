using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwImgr2
    {
        [Column("Line Item No")]
        public short LineItemNo { get; set; }
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Alcohol Percent", TypeName = "decimal(13, 3)")]
        public decimal? AlcoholPercent { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Bar Code Print Qty")]
        public int? BarCodePrintQty { get; set; }
        [Column("Brand Name")]
        [StringLength(50)]
        public string? BrandName { get; set; }
        [Column("Cargo Condition")]
        [StringLength(10)]
        public string? CargoCondition { get; set; }
        [Column("Country Of Origin")]
        [StringLength(2)]
        public string? CountryOfOrigin { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [Column("Customer Code")]
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [Column("Delivery Term Code")]
        [StringLength(3)]
        public string? DeliveryTermCode { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [Column("Dimension Flag")]
        [StringLength(1)]
        public string? DimensionFlag { get; set; }
        [Column("Doc Ref No")]
        [StringLength(2000)]
        public string? DocRefNo { get; set; }
        [Column("Enter Serial No")]
        [StringLength(1)]
        public string? EnterSerialNo { get; set; }
        [Column("Expiry Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ExpiryDate { get; set; }
        [Column("Freight Local Amt", TypeName = "decimal(13, 2)")]
        public decimal? FreightLocalAmt { get; set; }
        [Column("Goods Receipt Note No")]
        [StringLength(20)]
        public string GoodsReceiptNoteNo { get; set; } = null!;
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
        [Column("Insurance Local Amt", TypeName = "decimal(13, 2)")]
        public decimal? InsuranceLocalAmt { get; set; }
        [Column("Invoice Amt", TypeName = "decimal(13, 2)")]
        public decimal? InvoiceAmt { get; set; }
        [Column("Invoice Local Amt", TypeName = "decimal(13, 2)")]
        public decimal? InvoiceLocalAmt { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Length { get; set; }
        [Column("Loose Qty")]
        public int? LooseQty { get; set; }
        [Column("Lot No")]
        [StringLength(20)]
        public string? LotNo { get; set; }
        [Column("Manufacture Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ManufactureDate { get; set; }
        [Column("Movement Trx No")]
        public int? MovementTrxNo { get; set; }
        [Column("Net Weight", TypeName = "decimal(13, 2)")]
        public decimal? NetWeight { get; set; }
        [Column("No Of Stick", TypeName = "decimal(13, 2)")]
        public decimal? NoOfStick { get; set; }
        [Column("Order Line Item No")]
        public int? OrderLineItemNo { get; set; }
        [Column("Order Trx No")]
        public int? OrderTrxNo { get; set; }
        [Column("Other Local Amt", TypeName = "decimal(13, 2)")]
        public decimal? OtherLocalAmt { get; set; }
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
        [Column("Po Line Item No")]
        public int? PoLineItemNo { get; set; }
        [Column("Po No")]
        [StringLength(50)]
        public string? PoNo { get; set; }
        [Column("Product Code")]
        [StringLength(255)]
        public string? ProductCode { get; set; }
        [Column("Product Description")]
        [StringLength(255)]
        public string? ProductDescription { get; set; }
        [Column("Product Trx No")]
        public int? ProductTrxNo { get; set; }
        [Column("Qty Per Pallet")]
        public int? QtyPerPallet { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Rate { get; set; }
        [Column("Rate Class Code")]
        [StringLength(1)]
        public string? RateClassCode { get; set; }
        [Column("Space Area", TypeName = "decimal(13, 4)")]
        public decimal? SpaceArea { get; set; }
        [Column("Store Location")]
        [StringLength(50)]
        public string? StoreLocation { get; set; }
        [Column("Store No")]
        [StringLength(14)]
        public string? StoreNo { get; set; }
        [Column("Unit Price", TypeName = "decimal(13, 2)")]
        public decimal? UnitPrice { get; set; }
        [Column("Unit Volume", TypeName = "decimal(15, 6)")]
        public decimal? UnitVolume { get; set; }
        [Column("Unit Volume Flag")]
        [StringLength(1)]
        public string? UnitVolumeFlag { get; set; }
        [Column("Unit Weight", TypeName = "decimal(13, 4)")]
        public decimal? UnitWeight { get; set; }
        [Column("Uom Code")]
        [StringLength(50)]
        public string? UomCode { get; set; }
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
        [Column("Value Of Goods", TypeName = "decimal(13, 2)")]
        public decimal? ValueOfGoods { get; set; }
        [Column(TypeName = "decimal(15, 6)")]
        public decimal? Volume { get; set; }
        [Column("Volume Per Bottle", TypeName = "decimal(13, 3)")]
        public decimal? VolumePerBottle { get; set; }
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
