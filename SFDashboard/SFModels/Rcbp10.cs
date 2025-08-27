using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("Rcbp10")]
    public partial class Rcbp10
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(1)]
        public string? BrandFlag { get; set; }
        [StringLength(10)]
        public string BusinessPartyCode { get; set; } = null!;
        [StringLength(50)]
        public string? Marking { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Rate { get; set; }
        [StringLength(20)]
        public string? RateGroup { get; set; }
        [StringLength(1)]
        public string? TransportMode { get; set; }
    }
}
