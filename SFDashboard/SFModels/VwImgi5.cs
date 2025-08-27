using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwImgi5
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Line Item No")]
        public short LineItemNo { get; set; }
        [Column("Gross Weight", TypeName = "decimal(13, 4)")]
        public decimal? GrossWeight { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Height { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Length { get; set; }
        [Column("Packing No")]
        [StringLength(25)]
        public string? PackingNo { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Volume { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Width { get; set; }
    }
}
