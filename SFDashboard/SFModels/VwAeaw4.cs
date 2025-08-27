using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwAeaw4
    {
        [Column("Awb No")]
        [StringLength(20)]
        public string AwbNo { get; set; } = null!;
        [Column("Line Item No")]
        public short LineItemNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Amt { get; set; }
        [Column("Chg Rate", TypeName = "decimal(13, 3)")]
        public decimal? ChgRate { get; set; }
        [Column("Chg Wt", TypeName = "decimal(13, 4)")]
        public decimal? ChgWt { get; set; }
        [Column("Commodity Code")]
        [StringLength(10)]
        public string? CommodityCode { get; set; }
        [Column("Gross Wt", TypeName = "decimal(13, 4)")]
        public decimal? GrossWt { get; set; }
        [Column("Kg Lb Flag")]
        [StringLength(1)]
        public string? KgLbFlag { get; set; }
        public int? Pcs { get; set; }
        [Column("Rate Class Code")]
        [StringLength(1)]
        public string? RateClassCode { get; set; }
        [StringLength(50)]
        public string? Sector { get; set; }
        [Column("SLAC Qty", TypeName = "decimal(10, 0)")]
        public decimal? SlacQty { get; set; }
        [Column("Uom Code")]
        [StringLength(3)]
        public string? UomCode { get; set; }
    }
}
