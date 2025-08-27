using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwRcsm2
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Actual Profit", TypeName = "decimal(13, 2)")]
        public decimal? ActualProfit { get; set; }
        [Column("Commission Rate", TypeName = "decimal(13, 2)")]
        public decimal? CommissionRate { get; set; }
        [Column("Gross Profit Rate", TypeName = "decimal(13, 2)")]
        public decimal? GrossProfitRate { get; set; }
        [StringLength(6)]
        public string? Period { get; set; }
        [Column("Quota Rate", TypeName = "decimal(13, 2)")]
        public decimal? QuotaRate { get; set; }
        [Column("Salesman Code")]
        [StringLength(10)]
        public string? SalesmanCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Target { get; set; }
    }
}
