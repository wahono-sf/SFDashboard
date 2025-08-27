using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class JmJobInternalProvisionSummaryByMasterJob
    {
        [Column("Master Job No")]
        [StringLength(20)]
        public string? MasterJobNo { get; set; }
        [Column("Sales Amt", TypeName = "decimal(38, 2)")]
        public decimal? SalesAmt { get; set; }
        [Column("Cost Amt", TypeName = "decimal(38, 2)")]
        public decimal? CostAmt { get; set; }
    }
}
