using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwToso2
    {
        [Column("SO No")]
        [StringLength(20)]
        public string SoNo { get; set; } = null!;
        [Column("Buy Amt", TypeName = "decimal(13, 4)")]
        public decimal? BuyAmt { get; set; }
        [Column("Buy Rate", TypeName = "decimal(13, 4)")]
        public decimal? BuyRate { get; set; }
        [Column("Charge Weight", TypeName = "decimal(13, 4)")]
        public decimal? ChargeWeight { get; set; }
        [Column("Container No")]
        [StringLength(13)]
        public string? ContainerNo { get; set; }
        [Column("Container Ref No")]
        [StringLength(9)]
        public string? ContainerRefNo { get; set; }
        [Column("Container Type")]
        [StringLength(5)]
        public string? ContainerType { get; set; }
        [Column("Fiata Amt", TypeName = "decimal(13, 4)")]
        public decimal? FiataAmt { get; set; }
        [Column("Fiata Rate", TypeName = "decimal(13, 4)")]
        public decimal? FiataRate { get; set; }
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
        [Column("Gross Weight", TypeName = "decimal(13, 4)")]
        public decimal? GrossWeight { get; set; }
        [Column("Job No")]
        [StringLength(20)]
        public string JobNo { get; set; } = null!;
        [Column("Line Item No")]
        public int LineItemNo { get; set; }
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
        public int? Pcs { get; set; }
        [Column("Seal No")]
        [StringLength(15)]
        public string? SealNo { get; set; }
        [Column("Sell Amt", TypeName = "decimal(13, 4)")]
        public decimal? SellAmt { get; set; }
        [Column("Sell Rate", TypeName = "decimal(13, 4)")]
        public decimal? SellRate { get; set; }
        [Column("Text Flag")]
        [StringLength(1)]
        public string? TextFlag { get; set; }
        [Column("Ucr No")]
        [StringLength(17)]
        public string? UcrNo { get; set; }
        [Column("Uom Code")]
        [StringLength(3)]
        public string? UomCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Volume { get; set; }
        [StringLength(3)]
        [Unicode(false)]
        public string Status { get; set; } = null!;
    }
}
