using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class JmVolumeRatio
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
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Volume { get; set; }
        [Column("Total Volume", TypeName = "decimal(38, 4)")]
        public decimal? TotalVolume { get; set; }
        [Column(TypeName = "decimal(38, 25)")]
        public decimal? Ratio { get; set; }
    }
}
