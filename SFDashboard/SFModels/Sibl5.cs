using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("sibl5")]
    public partial class Sibl5
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public short LineItemNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Amt { get; set; }
        public short? CargoLineItemNo { get; set; }
        [StringLength(1)]
        public string? CashReceiptFlag { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [StringLength(30)]
        public string? ItemCode { get; set; }
        [StringLength(1)]
        public string? PrintFlag { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Qty { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? RebateRate { get; set; }
        [Column(TypeName = "decimal(15, 5)")]
        public decimal? UnitRate { get; set; }
        [StringLength(50)]
        public string? UomCode { get; set; }

        [ForeignKey("TrxNo")]
        [InverseProperty("Sibl5s")]
        public virtual Sibl1 TrxNoNavigation { get; set; } = null!;
    }
}
