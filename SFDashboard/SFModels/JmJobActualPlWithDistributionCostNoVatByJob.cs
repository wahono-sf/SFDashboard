using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class JmJobActualPlWithDistributionCostNoVatByJob
    {
        [Column("Job No")]
        [StringLength(20)]
        public string? JobNo { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? Sales { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? Cost { get; set; }
        [Column("Local Amt", TypeName = "decimal(38, 6)")]
        public decimal? LocalAmt { get; set; }
    }
}
