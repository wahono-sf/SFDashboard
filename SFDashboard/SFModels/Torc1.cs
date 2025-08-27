using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("torc1")]
    public partial class Torc1
    {
        [Key]
        public int TrxNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Amt { get; set; }
        [StringLength(10)]
        public string? BillingPartyCode { get; set; }
        [StringLength(20)]
        public string? ChequeNo { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InvoiceDate { get; set; }
        [StringLength(10)]
        public string? InvoiceNo { get; set; }
        [StringLength(30)]
        public string JobNo { get; set; } = null!;
        [StringLength(10)]
        public string? OnBehalfOf { get; set; }
        [StringLength(10)]
        public string? PaymentVoucherNo { get; set; }
        [StringLength(2)]
        public string? PaymentVoucherType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReceiptDate { get; set; }
        [StringLength(1)]
        public string? ReceivedFlag { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(30)]
        public string? SalesItemCode { get; set; }
        [StringLength(50)]
        public string? SalesItemDescription { get; set; }
        [StringLength(10)]
        public string? VendorCode { get; set; }
        [StringLength(80)]
        public string? VendorName { get; set; }
        [StringLength(10)]
        public string? VendorInvoiceNo { get; set; }
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

        [ForeignKey("SalesItemCode")]
        [InverseProperty("Torc1s")]
        public virtual Acit1? SalesItemCodeNavigation { get; set; }
    }
}
