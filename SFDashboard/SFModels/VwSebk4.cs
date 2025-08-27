using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSebk4
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Cargo Line Item No")]
        public int CargoLineItemNo { get; set; }
        [Column("Line Item No")]
        public short LineItemNo { get; set; }
        [Column("Gross Weight", TypeName = "decimal(13, 4)")]
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
        public int? Pcs { get; set; }
        [Column("Uom Code")]
        [StringLength(3)]
        public string? UomCode { get; set; }
        [Column(TypeName = "decimal(20, 4)")]
        public decimal? Volume { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Width { get; set; }
    }
}
