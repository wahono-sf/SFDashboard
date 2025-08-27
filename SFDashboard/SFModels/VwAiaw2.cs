using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwAiaw2
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Line Item No")]
        public int LineItemNo { get; set; }
        [Column("Actual Weight", TypeName = "decimal(13, 2)")]
        public decimal? ActualWeight { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Dimension { get; set; }
        [Column("Gross Weight", TypeName = "decimal(13, 2)")]
        public decimal? GrossWeight { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Height { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Length { get; set; }
        [Column("Loose Qty", TypeName = "decimal(10, 0)")]
        public decimal? LooseQty { get; set; }
        [Column("Loose Uom Code")]
        [StringLength(3)]
        public string? LooseUomCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Pcs { get; set; }
        [Column("Pcs Item No")]
        [StringLength(10)]
        public string? PcsItemNo { get; set; }
        [Column("Pcs Pack No")]
        [StringLength(10)]
        public string? PcsPackNo { get; set; }
        [Column("Uom Code")]
        [StringLength(3)]
        public string? UomCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Width { get; set; }
    }
}
