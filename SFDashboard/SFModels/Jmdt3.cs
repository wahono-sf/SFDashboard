using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("jmdt3")]
    public partial class Jmdt3
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        [StringLength(30)]
        public string JobNo { get; set; } = null!;
        [Key]
        public short LineItemNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? CostAmt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InvoiceDate { get; set; }
        [StringLength(10)]
        public string? InvoiceNo { get; set; }
        [StringLength(30)]
        public string? SalesOrCostItemCode { get; set; }
        [StringLength(10)]
        public string? Source { get; set; }
        [StringLength(10)]
        public string? VendorCode { get; set; }

        [ForeignKey("JobNo")]
        [InverseProperty("Jmdt3s")]
        public virtual Jmdt1 JobNoNavigation { get; set; } = null!;
    }
}
