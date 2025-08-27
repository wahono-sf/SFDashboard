using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwIaOhInv
    {
        [StringLength(12)]
        public string? MawbNo { get; set; }
        [StringLength(12)]
        public string? SubMawb { get; set; }
        [StringLength(50)]
        public string? DeliveryNo { get; set; }
        [StringLength(8)]
        public string? OnhnadNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DatetimeOnhand { get; set; }
        [Column(TypeName = "decimal(12, 4)")]
        public decimal? ChgWt { get; set; }
        [StringLength(50)]
        public string? ShipperCode { get; set; }
        [StringLength(8)]
        public string? TrkCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? FrtAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TrkChgAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? IssChg { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? AfsChg { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? OsLocAmt { get; set; }
    }
}
