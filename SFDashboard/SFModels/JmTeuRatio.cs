using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class JmTeuRatio
    {
        [Column("Shipment Type")]
        [StringLength(2)]
        public string? ShipmentType { get; set; }
        [Column("Job No")]
        [StringLength(20)]
        public string JobNo { get; set; } = null!;
        [Column("Master Job No")]
        [StringLength(20)]
        public string? MasterJobNo { get; set; }
        [Column("No Of Teu")]
        public int? NoOfTeu { get; set; }
        [Column("Total Teu")]
        public int? TotalTeu { get; set; }
        [Column(TypeName = "numeric(26, 12)")]
        public decimal? Ratio { get; set; }
    }
}
