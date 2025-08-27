using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwImpo4
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Booking No")]
        [StringLength(14)]
        public string? BookingNo { get; set; }
        [Column("Dest Code")]
        [StringLength(5)]
        public string? DestCode { get; set; }
        [Column("Job No")]
        [StringLength(20)]
        public string? JobNo { get; set; }
        [StringLength(10)]
        public string? Mode { get; set; }
        [Column("Origin Code")]
        [StringLength(5)]
        public string? OriginCode { get; set; }
    }
}
