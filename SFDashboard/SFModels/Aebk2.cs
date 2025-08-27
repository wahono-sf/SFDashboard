using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("aebk2")]
    public partial class Aebk2
    {
        [Key]
        [StringLength(20)]
        public string BookingNo { get; set; } = null!;
        [Key]
        public int LineItemNo { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Dimension { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? GrossWeight { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Height { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Length { get; set; }
        [Column(TypeName = "decimal(10, 0)")]
        public decimal? LooseQty { get; set; }
        [StringLength(50)]
        public string? LooseUomCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Pcs { get; set; }
        [StringLength(50)]
        public string? UomCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Width { get; set; }
    }
}
