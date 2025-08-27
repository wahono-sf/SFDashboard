using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class JmSeaJobActualPlWithDistributionCost
    {
        [Column("Job No")]
        [StringLength(20)]
        public string? JobNo { get; set; }
        [Column("Item Code")]
        [StringLength(30)]
        public string? ItemCode { get; set; }
        [Column("Local Amt", TypeName = "numeric(38, 6)")]
        public decimal? LocalAmt { get; set; }
        [StringLength(2)]
        [Unicode(false)]
        public string Type { get; set; } = null!;
    }
}
