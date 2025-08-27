using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class JmSeaJobActualPlWithDistributionCostByJob
    {
        [Column("Job No")]
        [StringLength(20)]
        public string? JobNo { get; set; }
        [Column("Local Amt", TypeName = "numeric(38, 6)")]
        public decimal? LocalAmt { get; set; }
    }
}
