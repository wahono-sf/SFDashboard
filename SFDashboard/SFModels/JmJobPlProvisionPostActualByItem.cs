using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class JmJobPlProvisionPostActualByItem
    {
        [Column("Job No")]
        [StringLength(20)]
        public string JobNo { get; set; } = null!;
        [Column("Item Code")]
        [StringLength(30)]
        public string ItemCode { get; set; } = null!;
        [Column("Provision Sales", TypeName = "decimal(38, 2)")]
        public decimal? ProvisionSales { get; set; }
        [Column("Provision Cost", TypeName = "decimal(38, 2)")]
        public decimal? ProvisionCost { get; set; }
        [Column("Actual Sales", TypeName = "decimal(38, 2)")]
        public decimal? ActualSales { get; set; }
        [Column("Actual Cost", TypeName = "decimal(38, 2)")]
        public decimal? ActualCost { get; set; }
    }
}
