using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("impm1")]
    [Index("BrandName", Name = "INDEX_Impm1_BrandName")]
    [Index("CustomerCode", Name = "INDEX_Impm1_CustomerCode")]
    [Index("CustomerName", Name = "INDEX_Impm1_CustomerName")]
    [Index("ExpiryDate", Name = "INDEX_Impm1_ExpiryDate")]
    [Index("FromToStoreNo", Name = "INDEX_Impm1_FromToStoreNo")]
    [Index("FromToWarehouseCode", Name = "INDEX_Impm1_FromToWarehouseCode")]
    [Index("GoodsReceiveorIssueNo", Name = "INDEX_Impm1_GoodsReceiveorIssueNo")]
    [Index("LotNo", Name = "INDEX_Impm1_LotNo")]
    [Index("ManufactureDate", Name = "INDEX_Impm1_ManufactureDate")]
    [Index("MovementDate", Name = "INDEX_Impm1_MovementDate")]
    [Index("NoteLineItemNo", Name = "INDEX_Impm1_NoteLineItemNo")]
    [Index("PackingNo", Name = "INDEX_Impm1_PackingNo")]
    [Index("PartNoTrxNo", Name = "INDEX_Impm1_PartNoTrxNo")]
    [Index("PermitNo", Name = "INDEX_Impm1_PermitNo")]
    [Index("ProductCode", Name = "INDEX_Impm1_ProductCode")]
    [Index("ProductName", Name = "INDEX_Impm1_ProductName")]
    [Index("ProductTrxNo", Name = "INDEX_Impm1_ProductTrxNo")]
    [Index("ReceiptDate", Name = "INDEX_Impm1_ReceiptDate")]
    [Index("RefNo", Name = "INDEX_Impm1_RefNo")]
    [Index("StoreNo", Name = "INDEX_Impm1_StoreNo")]
    [Index("TrxNo", Name = "INDEX_Impm1_TrxNo")]
    [Index("UserDefine1", Name = "INDEX_Impm1_UserDefine1")]
    [Index("UserDefine2", Name = "INDEX_Impm1_UserDefine2")]
    [Index("UserDefine3", Name = "INDEX_Impm1_UserDefine3")]
    [Index("WarehouseCode", Name = "INDEX_Impm1_WarehouseCode")]
    [Index("BalanceLooseQty", Name = "IX_impm1_BalanceLooseQty")]
    [Index("BalancePackingQty", Name = "IX_impm1_BalancePackingQty")]
    [Index("BalanceWholeQty", Name = "IX_impm1_BalanceWholeQty")]
    [Index("BatchLineItemNo", Name = "IX_impm1_BatchLineItemNo")]
    [Index("BatchNo", Name = "IX_impm1_BatchNo")]
    [Index("DimensionFlag", Name = "IX_impm1_DimensionFlag")]
    [Index("StatusCode", Name = "IX_impm1_StatusCode")]
    [Index("TrxType", Name = "IX_impm1_TrxType")]
    public partial class Impm1
    {
        [Key]
        public int TrxNo { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? AlcoholPercent { get; set; }
        public int? BalanceLooseQty { get; set; }
        public int? BalancePackingQty { get; set; }
        public int? BalanceWholeQty { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? BalanceSpaceArea { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? BalanceVolume { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? BalanceWeight { get; set; }
        [StringLength(12)]
        public string? BatchNo { get; set; }
        public int? BatchLineItemNo { get; set; }
        [StringLength(1)]
        public string? BillableFlag { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BillingStartDate { get; set; }
        [StringLength(50)]
        public string? BrandName { get; set; }
        [Column("CIFValue", TypeName = "decimal(13, 2)")]
        public decimal? Cifvalue { get; set; }
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [StringLength(2000)]
        public string? Description { get; set; }
        [StringLength(1)]
        public string? DimensionFlag { get; set; }
        [StringLength(2000)]
        public string? DocRefNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ExpiryDate { get; set; }
        [StringLength(50)]
        public string? FromToLocation { get; set; }
        [StringLength(14)]
        public string? FromToStoreNo { get; set; }
        [StringLength(6)]
        public string? FromToWarehouseCode { get; set; }
        [StringLength(2000)]
        public string? GoodsDescription { get; set; }
        [StringLength(20)]
        public string? GoodsReceiveorIssueNo { get; set; }
        [StringLength(25)]
        public string? Grade { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastBillDate { get; set; }
        [StringLength(50)]
        public string? Location { get; set; }
        public int? LooseQty { get; set; }
        [StringLength(20)]
        public string? LotNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ManufactureDate { get; set; }
        [StringLength(2000)]
        public string? MarkNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? MovementDate { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? NoOfStick { get; set; }
        public short? NoteLineItemNo { get; set; }
        [StringLength(50)]
        public string? PackingNo { get; set; }
        public int? PackingQty { get; set; }
        public int? PartNoTrxNo { get; set; }
        [StringLength(20)]
        public string? PermitNo { get; set; }
        [StringLength(255)]
        public string? ProductCode { get; set; }
        [StringLength(255)]
        public string? ProductName { get; set; }
        public int? ProductTrxNo { get; set; }
        [StringLength(1)]
        public string? RateClassCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReceiptDate { get; set; }
        [StringLength(50)]
        public string? RefNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? SpaceArea { get; set; }
        [StringLength(14)]
        public string? StoreNo { get; set; }
        [StringLength(1)]
        public string? TrxType { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? UnitPrice { get; set; }
        [Column(TypeName = "decimal(15, 6)")]
        public decimal? UnitVol { get; set; }
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
        [Column(TypeName = "decimal(15, 6)")]
        public decimal? Volume { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? VolumePerBottle { get; set; }
        [StringLength(6)]
        public string? WarehouseCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Weight { get; set; }
        public int? WholeQty { get; set; }
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
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
