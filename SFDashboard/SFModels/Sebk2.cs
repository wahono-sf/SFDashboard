using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("sebk2")]
    [Index("ContainerLineItemNo", Name = "INDEX_Sebk2_ContainerLineItemNo")]
    public partial class Sebk2
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public short LineItemNo { get; set; }
        [StringLength(30)]
        public string BookingNo { get; set; } = null!;
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? ChargeWeight { get; set; }
        [StringLength(50)]
        public string? CommodityCode { get; set; }
        [StringLength(50)]
        public string? CommodityDescription { get; set; }
        public short? ContainerLineItemNo { get; set; }
        [StringLength(13)]
        public string? ContainerNo { get; set; }
        [StringLength(5)]
        public string? ContainerType { get; set; }
        [StringLength(10)]
        public string? DepotCode { get; set; }
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
        [StringLength(2)]
        public string? MeasurementType { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? NetWeight { get; set; }
        public int? Pcs { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(50)]
        public string? RemarkTemplateName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RequiredDateTime { get; set; }
        [StringLength(30)]
        public string? SealNo { get; set; }
        [StringLength(50)]
        public string? UomCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Volume { get; set; }
        public short? VolumetricWeightRatio { get; set; }

        [ForeignKey("TrxNo")]
        [InverseProperty("Sebk2s")]
        public virtual Sebk1 TrxNoNavigation { get; set; } = null!;
        [ForeignKey("UomCode")]
        [InverseProperty("Sebk2s")]
        public virtual Rcum1? UomCodeNavigation { get; set; }
    }
}
