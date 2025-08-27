using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSearchCriteriaExport
    {
        [StringLength(10)]
        [Unicode(false)]
        public string FreightingMode { get; set; } = null!;
        [StringLength(5)]
        public string? Origin { get; set; }
        [StringLength(5)]
        public string? Dest { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BkgJobDate { get; set; }
        [StringLength(20)]
        public string? JobNo { get; set; }
        [StringLength(1)]
        [Unicode(false)]
        public string PoNo { get; set; } = null!;
        public int? CargoReadyDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PickupDateTime { get; set; }
        [Column("ETD", TypeName = "datetime")]
        public DateTime? Etd { get; set; }
        [Column("ETA", TypeName = "datetime")]
        public DateTime? Eta { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DeliveryDate { get; set; }
        [StringLength(10)]
        public string? CargoClass { get; set; }
        [StringLength(30)]
        public string? Hawb { get; set; }
        [StringLength(50)]
        public string? RefNo { get; set; }
        [StringLength(80)]
        public string? ShipperName { get; set; }
        [StringLength(80)]
        public string? ConsigneeName { get; set; }
        [StringLength(1)]
        [Unicode(false)]
        public string CaseMarkingNo { get; set; } = null!;
        [StringLength(1)]
        [Unicode(false)]
        public string RepairPoNo { get; set; } = null!;
        [StringLength(1)]
        [Unicode(false)]
        public string WorkServiceNo { get; set; } = null!;
        [StringLength(1)]
        [Unicode(false)]
        public string SerialNo { get; set; } = null!;
        [StringLength(1)]
        [Unicode(false)]
        public string Mpn { get; set; } = null!;
        [StringLength(1)]
        [Unicode(false)]
        public string Niin { get; set; } = null!;
        [StringLength(1)]
        [Unicode(false)]
        public string ItemNo { get; set; } = null!;
        [Column("serviceIndicator")]
        [StringLength(1)]
        [Unicode(false)]
        public string ServiceIndicator { get; set; } = null!;
        [Column("FMSCase")]
        [StringLength(1)]
        [Unicode(false)]
        public string Fmscase { get; set; } = null!;
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
    }
}
