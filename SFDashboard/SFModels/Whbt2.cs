using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("whbt2")]
    public partial class Whbt2
    {
        [Key]
        [StringLength(5)]
        public string TableNo { get; set; } = null!;
        [Key]
        public short LineItemNo { get; set; }
        [StringLength(30)]
        public string? SalesItemCode { get; set; }
        [StringLength(1)]
        public string? BillingCycleCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? BillingRate { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? BondedAmt { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? MinAmt { get; set; }
        [StringLength(3)]
        public string? RateDuration { get; set; }
        [StringLength(50)]
        public string? RateType { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? StdAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? UnitOrWeight { get; set; }

        [ForeignKey("SalesItemCode")]
        [InverseProperty("Whbt2s")]
        public virtual Acit1? SalesItemCodeNavigation { get; set; }
        [ForeignKey("TableNo")]
        [InverseProperty("Whbt2s")]
        public virtual Whbt1 TableNoNavigation { get; set; } = null!;
    }
}
