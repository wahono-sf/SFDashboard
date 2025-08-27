using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwTntWmstrackingMovement
    {
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
        [StringLength(3)]
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
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Height { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Length { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Width { get; set; }
    }
}
