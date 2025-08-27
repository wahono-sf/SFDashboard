using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("impr1")]
    [Index("BrandName", Name = "INDEX_Impr1_BrandName")]
    [Index("CustomerCode", Name = "INDEX_Impr1_CustomerCode")]
    [Index("Model", Name = "INDEX_Impr1_Model")]
    [Index("ProductClassCode", Name = "INDEX_Impr1_ProductClassCode")]
    [Index("ProductCode", Name = "INDEX_Impr1_ProductCode")]
    [Index("ProductName", Name = "INDEX_Impr1_ProductName")]
    [Index("UserDefine01", Name = "INDEX_Impr1_UserDefine01")]
    [Index("UserDefine02", Name = "INDEX_Impr1_UserDefine02")]
    [Index("UserDefine03", Name = "INDEX_Impr1_UserDefine03")]
    public partial class Impr1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(15)]
        public string? AccCode { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? AlcoholPercent { get; set; }
        [StringLength(50)]
        public string? BrandName { get; set; }
        [StringLength(1)]
        public string? CheckDimQtyFlag { get; set; }
        [StringLength(50)]
        public string? CommodityCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? CostAmt { get; set; }
        [StringLength(2)]
        public string? CountryOfOrigin { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [StringLength(1)]
        public string? DgIndicator { get; set; }
        [StringLength(1)]
        public string? DimensionFlag { get; set; }
        [StringLength(1)]
        public string? ExpiryDateFlag { get; set; }
        public int? ExpiryPromptDays { get; set; }
        [StringLength(8)]
        public string? HsCode { get; set; }
        [StringLength(35)]
        public string? HsProductCode { get; set; }
        [StringLength(50)]
        public string? IssueMethod { get; set; }
        [StringLength(1)]
        public string? KitMasterFlag { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? LooseHeight { get; set; }
        public int? LooseIncomingQty { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? LooseLength { get; set; }
        public int? LooseOnOrderQty { get; set; }
        public int? LooseQty { get; set; }
        public int? LooseQtyOnHand { get; set; }
        public int? LooseReservedQty { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? LooseSpaceArea { get; set; }
        [StringLength(50)]
        public string? LooseUomCode { get; set; }
        [Column(TypeName = "decimal(15, 6)")]
        public decimal? LooseVolume { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? LooseWeight { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? LooseWidth { get; set; }
        [StringLength(1)]
        public string? ManufacturingDateFlag { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? MinSellingPrice { get; set; }
        [StringLength(50)]
        public string? Model { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? NoOfStick { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? PackingHeight { get; set; }
        public int? PackingIncomingQty { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? PackingLength { get; set; }
        public int? PackingOnOrderQty { get; set; }
        public int? PackingPackageSize { get; set; }
        public int? PackingQty { get; set; }
        public int? PackingQtyOnHand { get; set; }
        public int? PackingReservedQty { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? PackingSpaceArea { get; set; }
        [StringLength(50)]
        public string? PackingUomCode { get; set; }
        [Column(TypeName = "decimal(15, 6)")]
        public decimal? PackingVolume { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? PackingWeight { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? PackingWidth { get; set; }
        [StringLength(50)]
        public string? ProdCastRefFormat { get; set; }
        [StringLength(20)]
        public string? ProductClassCode { get; set; }
        [StringLength(50)]
        public string? ProductClassDescription { get; set; }
        [StringLength(255)]
        public string ProductCode { get; set; } = null!;
        [StringLength(255)]
        public string? ProductName { get; set; }
        [StringLength(50)]
        public string? PutAwayMethod { get; set; }
        public int? QtyPerPallet { get; set; }
        [StringLength(50)]
        public string? Remark { get; set; }
        public int? ReorderQty { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? SellingPrice { get; set; }
        [StringLength(1)]
        public string? SerialNoFlag { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? ShippingWeight { get; set; }
        [StringLength(3)]
        public string? StorageType { get; set; }
        [StringLength(3)]
        public string? StoreType { get; set; }
        [StringLength(15)]
        public string? TariffCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? UnitPrice { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? UnitVol { get; set; }
        [StringLength(1)]
        public string? UnitVolFlag { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? UnitWt { get; set; }
        [StringLength(50)]
        public string? UserDefine01 { get; set; }
        [StringLength(50)]
        public string? UserDefine02 { get; set; }
        [StringLength(50)]
        public string? UserDefine03 { get; set; }
        [StringLength(50)]
        public string? UserDefine04 { get; set; }
        [StringLength(50)]
        public string? UserDefine05 { get; set; }
        [StringLength(50)]
        public string? UserDefine06 { get; set; }
        [StringLength(50)]
        public string? UserDefine07 { get; set; }
        [StringLength(50)]
        public string? UserDefine08 { get; set; }
        [StringLength(50)]
        public string? UserDefine09 { get; set; }
        [StringLength(50)]
        public string? UserDefine10 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? VolumePerBottle { get; set; }
        public int? WarrantyMth { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WholeHeight { get; set; }
        public int? WholeIncomingQty { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WholeLength { get; set; }
        public int? WholeOnOrderQty { get; set; }
        public int? WholePackageSize { get; set; }
        public int? WholeQty { get; set; }
        public int? WholeQtyOnHand { get; set; }
        public int? WholeReservedQty { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WholeSpaceArea { get; set; }
        [StringLength(50)]
        public string? WholeUomCode { get; set; }
        [Column(TypeName = "decimal(15, 6)")]
        public decimal? WholeVolume { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WholeWeight { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WholeWidth { get; set; }
        [StringLength(3)]
        public string StatusCode { get; set; } = null!;
        [StringLength(50)]
        public string CreateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CreateDateTime { get; set; }
        [StringLength(50)]
        public string UpdateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime UpdateDateTime { get; set; }
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
    }
}
