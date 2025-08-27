using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("aeaw5")]
    public partial class Aeaw5
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public short LineItemNo { get; set; }
        [StringLength(20)]
        public string? AwbNo { get; set; }
        [StringLength(3)]
        public string? DestCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? FreightAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? OtherAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ReforwardingAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TotalCollectAmt { get; set; }
    }
}
