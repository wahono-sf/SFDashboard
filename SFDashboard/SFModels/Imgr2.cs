using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("imgr2")]
    [Index("CustomerCode", Name = "INDEX_Imgr2_CustomerCode")]
    [Index("DimensionFlag", Name = "INDEX_Imgr2_DimensionFlag")]
    [Index("ExpiryDate", Name = "INDEX_Imgr2_ExpiryDate")]
    [Index("LineItemNo", Name = "INDEX_Imgr2_LineItemNo")]
    [Index("LotNo", Name = "INDEX_Imgr2_LotNo")]
    [Index("ManufactureDate", Name = "INDEX_Imgr2_ManufactureDate")]
    [Index("MovementTrxNo", Name = "INDEX_Imgr2_MovementTrxNo")]
    [Index("OrderTrxNo", Name = "INDEX_Imgr2_OrderTrxNo")]
    [Index("PackingNo", Name = "INDEX_Imgr2_PackingNo")]
    [Index("PartNoTrxNo", Name = "INDEX_Imgr2_PartNoTrxNo")]
    [Index("PermitNo", Name = "INDEX_Imgr2_PermitNo")]
    [Index("ProductCode", Name = "INDEX_Imgr2_ProductCode")]
    [Index("ProductTrxNo", Name = "INDEX_Imgr2_ProductTrxNo")]
    [Index("StoreNo", Name = "INDEX_Imgr2_StoreNo")]
    [Index("UserDefine1", Name = "INDEX_Imgr2_UserDefine1")]
    [Index("UserDefine2", Name = "INDEX_Imgr2_UserDefine2")]
    [Index("UserDefine3", Name = "INDEX_Imgr2_UserDefine3")]
    [Index("WarehouseCode", Name = "INDEX_Imgr2_WarehouseCode")]
    public partial class Imgr2
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public short LineItemNo { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? AlcoholPercent { get; set; }
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        public int? BarCodePrintQty { get; set; }
        [StringLength(50)]
        public string? BrandName { get; set; }
        [StringLength(10)]
        public string? CargoCondition { get; set; }
        [StringLength(2)]
        public string? CountryOfOrigin { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [StringLength(3)]
        public string? DeliveryTermCode { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [StringLength(1)]
        public string? DimensionFlag { get; set; }
        [StringLength(2000)]
        public string? DocRefNo { get; set; }
        [StringLength(1)]
        public string? EnterSerialNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ExpiryDate { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? FreightLocalAmt { get; set; }
        [StringLength(25)]
        public string? Grade { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Height { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? InsuranceLocalAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? InvAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? InvLocalAmt { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Length { get; set; }
        public int? LooseQty { get; set; }
        [StringLength(20)]
        public string? LotNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ManufactureDate { get; set; }
        public int? MovementTrxNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? NetWeight { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? NoOfStick { get; set; }
        public int? OrderLineItemNo { get; set; }
        public int? OrderTrxNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? OtherLocalAmt { get; set; }
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
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? UnitPrice { get; set; }
        [Column(TypeName = "decimal(15, 6)")]
        public decimal? UnitVol { get; set; }
        [StringLength(1)]
        public string? UnitVolFlag { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? UnitWt { get; set; }
        [StringLength(50)]
        public string? UomCode { get; set; }
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
        [Column(TypeName = "decimal(15, 6)")]
        public decimal? Volume { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? VolumePerBottle { get; set; }
        [StringLength(6)]
        public string? WarehouseCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Weight { get; set; }
        public int? WholeQty { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Width { get; set; }
        [StringLength(50)]
        public string? UpdateBy { get; set; }

        [ForeignKey("TrxNo")]
        [InverseProperty("Imgr2s")]
        public virtual Imgr1 TrxNoNavigation { get; set; } = null!;
    }
}
