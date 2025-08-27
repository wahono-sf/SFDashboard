using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwRcbp10
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Brand Flag")]
        [StringLength(1)]
        public string? BrandFlag { get; set; }
        [Column("Business Party Code")]
        [StringLength(10)]
        public string BusinessPartyCode { get; set; } = null!;
        [StringLength(50)]
        public string? Marking { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Rate { get; set; }
        [Column("Rate Group")]
        [StringLength(20)]
        public string? RateGroup { get; set; }
        [Column("Transport Mode")]
        [StringLength(1)]
        public string? TransportMode { get; set; }
    }
}
