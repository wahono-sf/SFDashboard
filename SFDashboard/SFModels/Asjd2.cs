using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("asjd2")]
    public partial class Asjd2
    {
        [Key]
        [StringLength(30)]
        public string JobNo { get; set; } = null!;
        [Key]
        public short LineItemNo { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [StringLength(50)]
        public string? CustomerAddress { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ForeignAmt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InvoiceDate { get; set; }
        [StringLength(10)]
        public string? InvoiceNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LocalAmt { get; set; }
        [StringLength(30)]
        public string? SalesItemCode { get; set; }
        [StringLength(5)]
        public string? SourceCode { get; set; }
        [StringLength(10)]
        public string? TrxNo { get; set; }
        [StringLength(1)]
        public string? TrxType { get; set; }

        [ForeignKey("CurrCode")]
        [InverseProperty("Asjd2s")]
        public virtual Glex1? CurrCodeNavigation { get; set; }
    }
}
