using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("jmdt4")]
    public partial class Jmdt4
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        [StringLength(30)]
        public string JobNo { get; set; } = null!;
        [Key]
        public short LineItemNo { get; set; }
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? InvoiceCostAmt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InvoiceDate { get; set; }
        [StringLength(10)]
        public string? InvoiceNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ProvisionCostAmt { get; set; }
        [StringLength(30)]
        public string? SalesOrCostItemCode { get; set; }
        [StringLength(50)]
        public string? Source { get; set; }

        [ForeignKey("JobNo")]
        [InverseProperty("Jmdt4s")]
        public virtual Jmdt1 JobNoNavigation { get; set; } = null!;
    }
}
