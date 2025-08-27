using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("ssjd1")]
    public partial class Ssjd1
    {
        [Key]
        [StringLength(30)]
        public string JobNo { get; set; } = null!;
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ForeignAmt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InvoiceDate { get; set; }
        [StringLength(10)]
        public string? InvoiceNo { get; set; }
        [StringLength(30)]
        public string? ItemCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LocalAmt { get; set; }
        [StringLength(80)]
        public string? Name { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ProvisionCostAmt { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(1)]
        public string? TrxType { get; set; }
        [StringLength(10)]
        public string? VendorCode { get; set; }
        [StringLength(50)]
        public string? VoucherNo { get; set; }
        [StringLength(3)]
        public string StatusCode { get; set; } = null!;
        [StringLength(50)]
        public string CreateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CreateDateTime { get; set; }
        [StringLength(50)]
        public string UpdateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime UpdateDateTime { get; set; }
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }

        [ForeignKey("CurrCode")]
        [InverseProperty("Ssjd1s")]
        public virtual Glex1? CurrCodeNavigation { get; set; }
        [ForeignKey("ItemCode")]
        [InverseProperty("Ssjd1s")]
        public virtual Acit1? ItemCodeNavigation { get; set; }
    }
}
