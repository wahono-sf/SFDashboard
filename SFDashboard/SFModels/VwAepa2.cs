using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwAepa2
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Copy No")]
        [StringLength(50)]
        public string? CopyNo { get; set; }
        [Column("Document Name")]
        [StringLength(50)]
        public string? DocumentName { get; set; }
        [Column("Job Type")]
        [StringLength(500)]
        public string? JobType { get; set; }
        [Column("Shipment Type")]
        [StringLength(1)]
        public string? ShipmentType { get; set; }
    }
}
