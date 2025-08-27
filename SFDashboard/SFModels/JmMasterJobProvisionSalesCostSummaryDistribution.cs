using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class JmMasterJobProvisionSalesCostSummaryDistribution
    {
        [Column(TypeName = "decimal(38, 25)")]
        public decimal? Ratio { get; set; }
        [Column("Master Job No")]
        [StringLength(20)]
        public string MasterJobNo { get; set; } = null!;
        [Column("Sales Amt", TypeName = "decimal(38, 6)")]
        public decimal? SalesAmt { get; set; }
        [Column("Cost Amt", TypeName = "decimal(38, 6)")]
        public decimal? CostAmt { get; set; }
        [Column("Job No")]
        [StringLength(20)]
        public string JobNo { get; set; } = null!;
    }
}
