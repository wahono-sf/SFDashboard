using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class JmJobProvisionSummaryWithDistributionByJob
    {
        [Column("Job No")]
        [StringLength(20)]
        public string JobNo { get; set; } = null!;
        [Column("Sales Amt", TypeName = "decimal(38, 2)")]
        public decimal? SalesAmt { get; set; }
        [Column("Cost Amt", TypeName = "decimal(38, 2)")]
        public decimal? CostAmt { get; set; }
    }
}
