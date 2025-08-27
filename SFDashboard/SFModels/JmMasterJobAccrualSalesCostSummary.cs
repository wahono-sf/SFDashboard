using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class JmMasterJobAccrualSalesCostSummary
    {
        [Column("Job No")]
        [StringLength(20)]
        public string JobNo { get; set; } = null!;
        [Column("Accrual Sales", TypeName = "decimal(38, 2)")]
        public decimal? AccrualSales { get; set; }
        [Column("Accrual Cost", TypeName = "decimal(38, 2)")]
        public decimal? AccrualCost { get; set; }
    }
}
