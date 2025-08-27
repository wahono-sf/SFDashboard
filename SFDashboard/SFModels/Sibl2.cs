using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("sibl2")]
    [Index("CargoStatusCode", Name = "INDEX_Sibl2_CargoStatusCode")]
    [Index("ContainerNo", Name = "INDEX_Sibl2_ContainerNo")]
    public partial class Sibl2
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public short LineItemNo { get; set; }
        [StringLength(50)]
        public string? AllotmentNo { get; set; }
        public int? AvailablePcs { get; set; }
        [StringLength(50)]
        public string? BarCode { get; set; }
        [StringLength(1)]
        public string? BillFlag { get; set; }
        [StringLength(255)]
        public string? CargoLocation { get; set; }
        [StringLength(3)]
        public string? CargoStatusCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? ChargeWeight { get; set; }
        [StringLength(500)]
        public string? CntrRemark { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CntrReturnDate { get; set; }
        [StringLength(1)]
        public string? CntrReturnType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CntrTransferDate { get; set; }
        [StringLength(50)]
        public string? CommodityCode { get; set; }
        [StringLength(50)]
        public string? CommodityDescription { get; set; }
        public short? ContainerLineItemNo { get; set; }
        [StringLength(13)]
        public string? ContainerNo { get; set; }
        [StringLength(5)]
        public string? ContainerType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DeliveryDate { get; set; }
        public int? DeliveryLineItemNo { get; set; }
        public int? DeliveryPcs { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DischargeDate { get; set; }
        [Column("DOReleaseDate", TypeName = "datetime")]
        public DateTime? DoreleaseDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EmptyDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FinalDestDate { get; set; }
        [StringLength(50)]
        public string? GoodsDescription01 { get; set; }
        [StringLength(50)]
        public string? GoodsDescription02 { get; set; }
        [StringLength(50)]
        public string? GoodsDescription03 { get; set; }
        [StringLength(50)]
        public string? GoodsDescription04 { get; set; }
        [StringLength(50)]
        public string? GoodsDescription05 { get; set; }
        [StringLength(50)]
        public string? GoodsDescription06 { get; set; }
        [StringLength(50)]
        public string? GoodsDescription07 { get; set; }
        [StringLength(50)]
        public string? GoodsDescription08 { get; set; }
        [StringLength(50)]
        public string? GoodsDescription09 { get; set; }
        [StringLength(50)]
        public string? GoodsDescription10 { get; set; }
        [StringLength(50)]
        public string? GoodsDescription11 { get; set; }
        [StringLength(50)]
        public string? GoodsDescription12 { get; set; }
        [StringLength(50)]
        public string? GoodsDescription13 { get; set; }
        [StringLength(50)]
        public string? GoodsDescription14 { get; set; }
        [StringLength(50)]
        public string? GoodsDescription15 { get; set; }
        [StringLength(50)]
        public string? GoodsDescription16 { get; set; }
        [StringLength(50)]
        public string? GoodsDescription17 { get; set; }
        [StringLength(50)]
        public string? GoodsDescription18 { get; set; }
        [StringLength(50)]
        public string? GoodsDescription19 { get; set; }
        [StringLength(50)]
        public string? GoodsDescription20 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? GrossWeight { get; set; }
        [Column("HODate", TypeName = "datetime")]
        public DateTime? Hodate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastDayStorageDateTime { get; set; }
        [StringLength(25)]
        public string? MarkNo01 { get; set; }
        [StringLength(25)]
        public string? MarkNo02 { get; set; }
        [StringLength(25)]
        public string? MarkNo03 { get; set; }
        [StringLength(25)]
        public string? MarkNo04 { get; set; }
        [StringLength(25)]
        public string? MarkNo05 { get; set; }
        [StringLength(25)]
        public string? MarkNo06 { get; set; }
        [StringLength(25)]
        public string? MarkNo07 { get; set; }
        [StringLength(25)]
        public string? MarkNo08 { get; set; }
        [StringLength(25)]
        public string? MarkNo09 { get; set; }
        [StringLength(25)]
        public string? MarkNo10 { get; set; }
        [StringLength(25)]
        public string? MarkNo11 { get; set; }
        [StringLength(25)]
        public string? MarkNo12 { get; set; }
        [StringLength(25)]
        public string? MarkNo13 { get; set; }
        [StringLength(25)]
        public string? MarkNo14 { get; set; }
        [StringLength(25)]
        public string? MarkNo15 { get; set; }
        [StringLength(25)]
        public string? MarkNo16 { get; set; }
        [StringLength(25)]
        public string? MarkNo17 { get; set; }
        [StringLength(25)]
        public string? MarkNo18 { get; set; }
        [StringLength(25)]
        public string? MarkNo19 { get; set; }
        [StringLength(25)]
        public string? MarkNo20 { get; set; }
        [Column(TypeName = "image")]
        public byte[]? MarkNoImage { get; set; }
        [StringLength(2)]
        public string? MeasurementType { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? NetWeight { get; set; }
        [StringLength(80)]
        public string? Owner { get; set; }
        public int? Pcs { get; set; }
        public int? Pcs01 { get; set; }
        public int? Pcs02 { get; set; }
        public int? Pcs03 { get; set; }
        public int? Pcs04 { get; set; }
        public int? Pcs05 { get; set; }
        public int? Pcs06 { get; set; }
        public int? Pcs07 { get; set; }
        public int? Pcs08 { get; set; }
        public int? Pcs09 { get; set; }
        public int? Pcs10 { get; set; }
        public int? Pcs11 { get; set; }
        public int? Pcs12 { get; set; }
        public int? Pcs13 { get; set; }
        public int? Pcs14 { get; set; }
        public int? Pcs15 { get; set; }
        public int? Pcs16 { get; set; }
        public int? Pcs17 { get; set; }
        public int? Pcs18 { get; set; }
        public int? Pcs19 { get; set; }
        public int? Pcs20 { get; set; }
        public int? Pcs21 { get; set; }
        public int? Pcs22 { get; set; }
        public int? Pcs23 { get; set; }
        public int? Pcs24 { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(50)]
        public string? RemarkTemplateName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RequestDate { get; set; }
        [StringLength(30)]
        public string? SealNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TruckingDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TruckOutDate { get; set; }
        [StringLength(50)]
        public string? UcrNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UnstuffingDate { get; set; }
        [StringLength(50)]
        public string? UomCode { get; set; }
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
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Volume { get; set; }
        [StringLength(50)]
        public string? WeightRemark { get; set; }
        [StringLength(50)]
        public string? YardName { get; set; }

        [ForeignKey("TrxNo")]
        [InverseProperty("Sibl2s")]
        public virtual Sibl1 TrxNoNavigation { get; set; } = null!;
    }
}
