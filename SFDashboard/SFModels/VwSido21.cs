using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSido21
    {
        [Column("Line Item No")]
        public short LineItemNo { get; set; }
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Di Trx No")]
        public int? DiTrxNo { get; set; }
        [Column("Di Line Item No")]
        public int? DiLineItemNo { get; set; }
        [Column("Available Pcs")]
        public int? AvailablePcs { get; set; }
        [Column("Container No")]
        [StringLength(13)]
        public string? ContainerNo { get; set; }
        [Column("Container Type")]
        [StringLength(5)]
        public string? ContainerType { get; set; }
        [Column("Delivery Pcs")]
        public int? DeliveryPcs { get; set; }
        [Column("Goods Description 01")]
        [StringLength(50)]
        public string? GoodsDescription01 { get; set; }
        [Column("Goods Description 02")]
        [StringLength(50)]
        public string? GoodsDescription02 { get; set; }
        [Column("Goods Description 03")]
        [StringLength(50)]
        public string? GoodsDescription03 { get; set; }
        [Column("Goods Description 04")]
        [StringLength(50)]
        public string? GoodsDescription04 { get; set; }
        [Column("Goods Description 05")]
        [StringLength(50)]
        public string? GoodsDescription05 { get; set; }
        [Column("Goods Description 06")]
        [StringLength(50)]
        public string? GoodsDescription06 { get; set; }
        [Column("Goods Description 07")]
        [StringLength(50)]
        public string? GoodsDescription07 { get; set; }
        [Column("Goods Description 08")]
        [StringLength(50)]
        public string? GoodsDescription08 { get; set; }
        [Column("Goods Description 09")]
        [StringLength(50)]
        public string? GoodsDescription09 { get; set; }
        [Column("Goods Description 10")]
        [StringLength(50)]
        public string? GoodsDescription10 { get; set; }
        [Column("Goods Description 11")]
        [StringLength(50)]
        public string? GoodsDescription11 { get; set; }
        [Column("Goods Description 12")]
        [StringLength(50)]
        public string? GoodsDescription12 { get; set; }
        [Column("Goods Description 13")]
        [StringLength(50)]
        public string? GoodsDescription13 { get; set; }
        [Column("Goods Description 14")]
        [StringLength(50)]
        public string? GoodsDescription14 { get; set; }
        [Column("Goods Description 15")]
        [StringLength(50)]
        public string? GoodsDescription15 { get; set; }
        [Column("Goods Description 16")]
        [StringLength(50)]
        public string? GoodsDescription16 { get; set; }
        [Column("Goods Description 17")]
        [StringLength(50)]
        public string? GoodsDescription17 { get; set; }
        [Column("Goods Description 18")]
        [StringLength(50)]
        public string? GoodsDescription18 { get; set; }
        [Column("Goods Description 19")]
        [StringLength(50)]
        public string? GoodsDescription19 { get; set; }
        [Column("Goods Description 20")]
        [StringLength(50)]
        public string? GoodsDescription20 { get; set; }
        [Column("Gross Weight", TypeName = "decimal(13, 4)")]
        public decimal? GrossWeight { get; set; }
        [Column("Mark No 01")]
        [StringLength(25)]
        public string? MarkNo01 { get; set; }
        [Column("Mark No 02")]
        [StringLength(25)]
        public string? MarkNo02 { get; set; }
        [Column("Mark No 03")]
        [StringLength(25)]
        public string? MarkNo03 { get; set; }
        [Column("Mark No 04")]
        [StringLength(25)]
        public string? MarkNo04 { get; set; }
        [Column("Mark No 05")]
        [StringLength(25)]
        public string? MarkNo05 { get; set; }
        [Column("Mark No 06")]
        [StringLength(25)]
        public string? MarkNo06 { get; set; }
        [Column("Mark No 07")]
        [StringLength(25)]
        public string? MarkNo07 { get; set; }
        [Column("Mark No 08")]
        [StringLength(25)]
        public string? MarkNo08 { get; set; }
        [Column("Mark No 09")]
        [StringLength(25)]
        public string? MarkNo09 { get; set; }
        [Column("Mark No 10")]
        [StringLength(25)]
        public string? MarkNo10 { get; set; }
        [Column("Mark No 11")]
        [StringLength(25)]
        public string? MarkNo11 { get; set; }
        [Column("Mark No 12")]
        [StringLength(25)]
        public string? MarkNo12 { get; set; }
        [Column("Mark No 13")]
        [StringLength(25)]
        public string? MarkNo13 { get; set; }
        [Column("Mark No 14")]
        [StringLength(25)]
        public string? MarkNo14 { get; set; }
        [Column("Mark No 15")]
        [StringLength(25)]
        public string? MarkNo15 { get; set; }
        [Column("Mark No 16")]
        [StringLength(25)]
        public string? MarkNo16 { get; set; }
        [Column("Mark No 17")]
        [StringLength(25)]
        public string? MarkNo17 { get; set; }
        [Column("Mark No 18")]
        [StringLength(25)]
        public string? MarkNo18 { get; set; }
        [Column("Mark No 19")]
        [StringLength(25)]
        public string? MarkNo19 { get; set; }
        [Column("Mark No 20")]
        [StringLength(25)]
        public string? MarkNo20 { get; set; }
        [Column("Original Pcs")]
        public int? OriginalPcs { get; set; }
        [Column("Seal No")]
        [StringLength(30)]
        public string? SealNo { get; set; }
        [Column("Uom Code")]
        [StringLength(3)]
        public string? UomCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Volume { get; set; }
    }
}
