using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("imgi2")]
    [Index("BatchNo", Name = "INDEX_Imgi2_BatchNo")]
    [Index("CustomerCode", Name = "INDEX_Imgi2_CustomerCode")]
    [Index("ExpiryDate", Name = "INDEX_Imgi2_ExpiryDate")]
    [Index("LotNo", Name = "INDEX_Imgi2_LotNo")]
    [Index("ManufactureDate", Name = "INDEX_Imgi2_ManufactureDate")]
    [Index("PartNoTrxNo", Name = "INDEX_Imgi2_PartNoTrxNo")]
    [Index("PermitNo", Name = "INDEX_Imgi2_PermitNo")]
    [Index("ProductCode", Name = "INDEX_Imgi2_ProductCode")]
    [Index("ProductTrxNo", Name = "INDEX_Imgi2_ProductTrxNo")]
    [Index("ReceiptMovementTrxNo", Name = "INDEX_Imgi2_ReceiptMovementTrxNo")]
    [Index("UserDefine1", Name = "INDEX_Imgi2_UserDefine1")]
    [Index("UserDefine2", Name = "INDEX_Imgi2_UserDefine2")]
    [Index("UserDefine3", Name = "INDEX_Imgi2_UserDefine3")]
    [Index("WarehouseCode", Name = "INDEX_Imgi2_WarehouseCode")]
    [Index("StoreNo", Name = "Index_Imgi2_StoreNo")]
    public partial class Imgi2
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public short LineItemNo { get; set; }
        public short? KitProductLineItemNo { get; set; }
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BarCodeDateTime { get; set; }
        [StringLength(12)]
        public string? BatchNo { get; set; }
        public int? ConfirmQty { get; set; }
        public int? ConfirmQty1 { get; set; }
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [StringLength(1)]
        public string? DimensionFlag { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? DutyAmt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ExpiryDate { get; set; }
        [StringLength(20)]
        public string? GoodsReceiveNoteNo { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Height { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Length { get; set; }
        [StringLength(50)]
        public string? Location { get; set; }
        public int? LooseQty { get; set; }
        [StringLength(20)]
        public string? LotNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ManufactureDate { get; set; }
        public int? PackingQty { get; set; }
        public int? PartNoTrxNo { get; set; }
        [StringLength(20)]
        public string? PermitNo { get; set; }
        [StringLength(255)]
        public string? ProductCode { get; set; }
        [StringLength(255)]
        public string? ProductDescription { get; set; }
        public int? ProductTrxNo { get; set; }
        public int? QtyOnHand { get; set; }
        public int? ReceiptMovementTrxNo { get; set; }
        public int? SoLineItemNo { get; set; }
        [StringLength(50)]
        public string? SoNo { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? SpaceArea { get; set; }
        [StringLength(14)]
        public string? StoreNo { get; set; }
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
