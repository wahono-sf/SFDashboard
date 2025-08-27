using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class JmNoOfHouseJob
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
        [Column("Total Job")]
        public int? TotalJob { get; set; }
    }
}
