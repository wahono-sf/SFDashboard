using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class SiChargeWeight
    {
        [Column("Curr Rate", TypeName = "decimal(13, 6)")]
        public decimal? CurrRate { get; set; }
        [Column("Import Rate", TypeName = "decimal(13, 2)")]
        public decimal? ImportRate { get; set; }
        [Column("Job No")]
        [StringLength(20)]
        public string? JobNo { get; set; }
        [Column("Master Job No")]
        [StringLength(20)]
        public string? MasterJobNo { get; set; }
        [Column("Shipment Type")]
        [StringLength(1)]
        public string? ShipmentType { get; set; }
        [Column("Transhipment Flag")]
        [StringLength(1)]
        public string? TranshipmentFlag { get; set; }
        [Column("Transhipment Rate", TypeName = "decimal(13, 2)")]
        public decimal? TranshipmentRate { get; set; }
        [Column("Transhipment Amt", TypeName = "decimal(13, 2)")]
        public decimal? TranshipmentAmt { get; set; }
        [Column("Charge Weight", TypeName = "decimal(13, 4)")]
        public decimal? ChargeWeight { get; set; }
    }
}
