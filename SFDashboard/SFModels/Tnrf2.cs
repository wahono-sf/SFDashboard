using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("tnrf2")]
    public partial class Tnrf2
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public short LineItemNo { get; set; }
        [Column(TypeName = "decimal(16, 2)")]
        public decimal? CustomsRefundAmt { get; set; }
        [Column(TypeName = "decimal(16, 2)")]
        public decimal? ExciseRefundAmt { get; set; }
        [Column(TypeName = "decimal(16, 2)")]
        public decimal? GstRefundAmt { get; set; }
        [Column("HSCode")]
        [StringLength(10)]
        public string? Hscode { get; set; }
        [Column(TypeName = "decimal(16, 2)")]
        public decimal? OtherRefundAmt { get; set; }
    }
}
