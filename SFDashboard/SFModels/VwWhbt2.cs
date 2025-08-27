using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwWhbt2
    {
        [Column("Table No")]
        [StringLength(5)]
        public string TableNo { get; set; } = null!;
        [Column("Line Item No")]
        public short LineItemNo { get; set; }
        [Column("Sales Item Code")]
        [StringLength(30)]
        public string? SalesItemCode { get; set; }
        [Column("Billing Cycle Code")]
        [StringLength(1)]
        public string? BillingCycleCode { get; set; }
        [Column("Billing Rate", TypeName = "decimal(13, 2)")]
        public decimal? BillingRate { get; set; }
        [Column("Bonded Amt", TypeName = "decimal(13, 2)")]
        public decimal? BondedAmt { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [Column("Min Amt", TypeName = "decimal(13, 2)")]
        public decimal? MinAmt { get; set; }
        [Column("Rate Duration")]
        [StringLength(3)]
        public string? RateDuration { get; set; }
        [Column("Rate Type")]
        [StringLength(50)]
        public string? RateType { get; set; }
        [Column("Std Amt", TypeName = "decimal(13, 2)")]
        public decimal? StdAmt { get; set; }
        [Column("Unit Or Weight", TypeName = "decimal(13, 2)")]
        public decimal? UnitOrWeight { get; set; }
    }
}
