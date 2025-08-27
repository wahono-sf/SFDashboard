using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("smct3")]
    public partial class Smct3
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public short LineItemNo { get; set; }
        [StringLength(1)]
        public string? BreakRateType { get; set; }
        [StringLength(25)]
        public string? QuoteRate { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak { get; set; }
        [Key]
        [StringLength(5)]
        public string ZoneCode { get; set; } = null!;
    }
}
