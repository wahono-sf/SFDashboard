using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("Rcsm2")]
    public partial class Rcsm2
    {
        [Key]
        public int TrxNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ActualProfit { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? CommissionRate { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? GrossProfitRate { get; set; }
        [StringLength(6)]
        public string? Period { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? QuotaRate { get; set; }
        [StringLength(10)]
        public string? SalesmanCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Target { get; set; }
    }
}
