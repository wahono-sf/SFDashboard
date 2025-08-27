using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class SeShipmentSummary
    {
        [Column("Job No")]
        [StringLength(20)]
        public string? JobNo { get; set; }
        [Column("No Of Teu")]
        public int? NoOfTeu { get; set; }
        [Column("No Of Shipment")]
        public int NoOfShipment { get; set; }
        [Column("No of Bl")]
        public int NoOfBl { get; set; }
        [Column("No of LCL")]
        public int NoOfLcl { get; set; }
        [Column("No of FCL")]
        public int NoOfFcl { get; set; }
        [Column("Charge Weight", TypeName = "decimal(13, 4)")]
        public decimal? ChargeWeight { get; set; }
        [Column("Gross Weight", TypeName = "decimal(13, 4)")]
        public decimal? GrossWeight { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Volume { get; set; }
        [Column(TypeName = "decimal(38, 2)")]
        public decimal Sales { get; set; }
        [Column(TypeName = "decimal(38, 2)")]
        public decimal Cost { get; set; }
        [StringLength(3)]
        public string Status { get; set; } = null!;
    }
}
