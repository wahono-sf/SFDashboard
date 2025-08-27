using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("asjd3")]
    public partial class Asjd3
    {
        [Key]
        [StringLength(30)]
        public string JobNo { get; set; } = null!;
        [Key]
        public short LineItemNo { get; set; }
        [StringLength(30)]
        public string? CostItemCode { get; set; }
        [StringLength(50)]
        public string? CostItemDescription { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? InvoiceCostAmt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InvoiceDate { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? InvoiceForeignAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? InvoiceLocalAmt { get; set; }
        [StringLength(20)]
        public string? InvoiceNo { get; set; }
        [StringLength(5)]
        public string? SourceCode { get; set; }
        [StringLength(10)]
        public string? TrxNo { get; set; }
        [StringLength(1)]
        public string? TrxType { get; set; }
        [StringLength(10)]
        public string? VendorCode { get; set; }
        [StringLength(80)]
        public string? VendorName { get; set; }
        [StringLength(10)]
        public string? VoucherNo { get; set; }

        [ForeignKey("CurrCode")]
        [InverseProperty("Asjd3s")]
        public virtual Glex1? CurrCodeNavigation { get; set; }
    }
}
