using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("impo4")]
    public partial class Impo4
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(30)]
        public string? BookingNo { get; set; }
        [StringLength(5)]
        public string? DestCode { get; set; }
        [StringLength(30)]
        public string? JobNo { get; set; }
        [StringLength(10)]
        public string? Mode { get; set; }
        [StringLength(5)]
        public string? OriginCode { get; set; }
    }
}
