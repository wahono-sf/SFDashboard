using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwCntrIdlingPort
    {
        [Column("Container No")]
        [StringLength(13)]
        public string ContainerNo { get; set; } = null!;
        [Column("Event Code")]
        [StringLength(10)]
        public string? EventCode { get; set; }
        [Column("Event Port Code")]
        [StringLength(5)]
        public string? EventPortCode { get; set; }
        [StringLength(16)]
        [Unicode(false)]
        public string? Eta { get; set; }
        [Column("Event Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? EventDate { get; set; }
        [Column("Idle Days")]
        public int? IdleDays { get; set; }
        [StringLength(3)]
        [Unicode(false)]
        public string Status { get; set; } = null!;
    }
}
