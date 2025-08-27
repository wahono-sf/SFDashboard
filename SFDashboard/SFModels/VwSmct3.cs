using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSmct3
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Line Item No")]
        public short? LineItemNo { get; set; }
        [Column("Break Rate Type")]
        [StringLength(1)]
        public string? BreakRateType { get; set; }
        [Column("Weight Break", TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak { get; set; }
        [Column("Quote Rate")]
        [StringLength(25)]
        public string? QuoteRate { get; set; }
        [Column("Zone Code")]
        [StringLength(5)]
        public string? ZoneCode { get; set; }
    }
}
