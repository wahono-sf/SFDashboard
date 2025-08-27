using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwImgi3
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Line Item No")]
        public short LineItemNo { get; set; }
        [StringLength(80)]
        public string? Dimension { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Height { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Length { get; set; }
        [Column("Loose Qty")]
        public int? LooseQty { get; set; }
        [Column("Loose UOM Code")]
        [StringLength(3)]
        public string? LooseUomCode { get; set; }
        [Column("Packing No")]
        [StringLength(25)]
        public string? PackingNo { get; set; }
        [Column("Packing Qty")]
        public int? PackingQty { get; set; }
        [Column("Packing UOM Code")]
        [StringLength(3)]
        public string? PackingUomCode { get; set; }
        [Column("Product Description")]
        [StringLength(255)]
        public string? ProductDescription { get; set; }
        [Column("Product Trx No")]
        public int? ProductTrxNo { get; set; }
        [Column("User Define 1")]
        [StringLength(255)]
        public string? UserDefine1 { get; set; }
        [Column("User Define 2")]
        [StringLength(255)]
        public string? UserDefine2 { get; set; }
        [Column("User Define 3")]
        [StringLength(255)]
        public string? UserDefine3 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Volume { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Weight { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Width { get; set; }
        [Column("Whole Package Size")]
        public int? WholePackageSize { get; set; }
        [Column("Whole Qty")]
        public int? WholeQty { get; set; }
        [Column("Whole UOM Code")]
        [StringLength(3)]
        public string? WholeUomCode { get; set; }
    }
}
