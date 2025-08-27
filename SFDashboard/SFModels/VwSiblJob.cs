using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSiblJob
    {
        [Column("No Of Job")]
        public int? NoOfJob { get; set; }
        [Column("Master Job No")]
        [StringLength(20)]
        public string? MasterJobNo { get; set; }
        [Column("Local No Of Job")]
        public int? LocalNoOfJob { get; set; }
        [Column("Local Volume", TypeName = "decimal(38, 4)")]
        public decimal? LocalVolume { get; set; }
        [Column("Total Pcs")]
        public int? TotalPcs { get; set; }
        [Column("Total Volume", TypeName = "decimal(38, 4)")]
        public decimal? TotalVolume { get; set; }
        [Column("Total Gross Weight", TypeName = "decimal(38, 4)")]
        public decimal? TotalGrossWeight { get; set; }
        [Column("Total Charge Weight", TypeName = "decimal(38, 4)")]
        public decimal? TotalChargeWeight { get; set; }
        [Column("Transhipment No Of Job")]
        public int? TranshipmentNoOfJob { get; set; }
        [Column("Transhipment Volume", TypeName = "decimal(38, 4)")]
        public decimal? TranshipmentVolume { get; set; }
    }
}
