using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwTntWmstrackingBalance
    {
        [StringLength(255)]
        public string? ProductCode { get; set; }
        [StringLength(255)]
        public string? ProductName { get; set; }
        [StringLength(50)]
        public string? UserDefine1 { get; set; }
        [Column("dimensionflag")]
        [StringLength(1)]
        public string? Dimensionflag { get; set; }
        public int? PackingQty { get; set; }
        public int? BalancePackingQty { get; set; }
        public int? WholeQty { get; set; }
        public int? BalanceWholeQty { get; set; }
        public int? LooseQty { get; set; }
        public int? BalanceLooseQty { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? Volume { get; set; }
        [Column(TypeName = "decimal(38, 4)")]
        public decimal? BalanceVolume { get; set; }
        [Column(TypeName = "decimal(38, 4)")]
        public decimal? Weight { get; set; }
        [Column(TypeName = "decimal(38, 4)")]
        public decimal? BalanceWeight { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? MovementDate { get; set; }
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [StringLength(50)]
        public string? RefNo { get; set; }
    }
}
