using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwCsbk2
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Line Item No")]
        public int LineItemNo { get; set; }
        [Column("Box Code")]
        [StringLength(5)]
        public string? BoxCode { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Dimension { get; set; }
        [Column("Gross Weight", TypeName = "decimal(13, 2)")]
        public decimal? GrossWeight { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Height { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Length { get; set; }
        public int? Pcs { get; set; }
        [StringLength(50)]
        public string? Status { get; set; }
        [Column("Unit Rate", TypeName = "decimal(13, 2)")]
        public decimal? UnitRate { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? Volume { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Width { get; set; }
    }
}
