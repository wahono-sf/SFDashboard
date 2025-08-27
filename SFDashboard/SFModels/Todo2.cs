using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("todo2")]
    public partial class Todo2
    {
        [Key]
        [StringLength(20)]
        public string DeliveryOrderNo { get; set; } = null!;
        [Key]
        public short LineItemNo { get; set; }
        public int? AvailablePcs { get; set; }
        [Column("BLNo")]
        [StringLength(30)]
        public string? Blno { get; set; }
        [StringLength(10)]
        public string? BookingNo { get; set; }
        public short? BookingLineItemNo { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? ChargeWeight { get; set; }
        [StringLength(13)]
        public string? ContainerNo { get; set; }
        [StringLength(9)]
        public string? ContainerRefNo { get; set; }
        [StringLength(5)]
        public string? ContainerType { get; set; }
        public int? DeliveryPcs { get; set; }
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
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? GrossWeight { get; set; }
        [StringLength(30)]
        public string? JobNo { get; set; }
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
        public int? OriginPcs { get; set; }
        [StringLength(1)]
        public string? PrintFlag { get; set; }
        [StringLength(15)]
        public string? SealNo { get; set; }
        [StringLength(50)]
        public string? UomCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Volume { get; set; }

        [ForeignKey("ContainerType")]
        [InverseProperty("Todo2s")]
        public virtual Rcco1? ContainerTypeNavigation { get; set; }
        [ForeignKey("DeliveryOrderNo")]
        [InverseProperty("Todo2s")]
        public virtual Todo1 DeliveryOrderNoNavigation { get; set; } = null!;
        [ForeignKey("UomCode")]
        [InverseProperty("Todo2s")]
        public virtual Rcum1? UomCodeNavigation { get; set; }
    }
}
