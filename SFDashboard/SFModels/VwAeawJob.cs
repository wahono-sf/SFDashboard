using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwAeawJob
    {
        [Column("No Of Job")]
        public int? NoOfJob { get; set; }
        [Column("Master Job No")]
        [StringLength(20)]
        public string? MasterJobNo { get; set; }
        [Column("Total Pcs")]
        public int? TotalPcs { get; set; }
        [Column("Total Gross Weight", TypeName = "decimal(38, 4)")]
        public decimal? TotalGrossWeight { get; set; }
        [Column("Total Charge Weight", TypeName = "decimal(38, 4)")]
        public decimal? TotalChargeWeight { get; set; }
    }
}
