using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class JmMasterJobAccSalesDistributionByJob
    {
        [Column("Job No")]
        [StringLength(20)]
        public string? JobNo { get; set; }
        [Column("Master Job No")]
        [StringLength(20)]
        public string? MasterJobNo { get; set; }
        [Column("Local Amt", TypeName = "decimal(38, 6)")]
        public decimal? LocalAmt { get; set; }
    }
}
