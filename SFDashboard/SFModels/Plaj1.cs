using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("plaj1")]
    public partial class Plaj1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(15)]
        public string? AccCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? AdjustAmt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AdjustDate { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? AdjustLocalAmt { get; set; }
        [StringLength(20)]
        public string? ApplyToInvoice { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [StringLength(20)]
        public string? InvoiceNo { get; set; }
        [StringLength(30)]
        public string? JobNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PostDate { get; set; }
        [StringLength(1)]
        public string? PostFlag { get; set; }
        [StringLength(1)]
        public string? PostLiabFlag { get; set; }
        [StringLength(6)]
        public string? PostMth { get; set; }
        [StringLength(20)]
        public string? PurchaseOrderNo { get; set; }
        [StringLength(10)]
        public string? RefNo { get; set; }
        [StringLength(50)]
        public string? Remark { get; set; }
        [StringLength(10)]
        public string? VendorCode { get; set; }
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
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
        [InverseProperty("Plaj1s")]
        public virtual Glex1? CurrCodeNavigation { get; set; }
    }
}
