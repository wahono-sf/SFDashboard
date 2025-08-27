using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("Plti1")]
    public partial class Plti1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(10)]
        public string? InvoiceOrPaymentRefNo { get; set; }
        [StringLength(45)]
        public string? Address1 { get; set; }
        [StringLength(45)]
        public string? Address2 { get; set; }
        [StringLength(45)]
        public string? Address3 { get; set; }
        [StringLength(45)]
        public string? Address4 { get; set; }
        [StringLength(10)]
        public string? InternalTaxRefNo { get; set; }
        [StringLength(6)]
        public string? PostMth { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TaxInvoiceAmt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TaxInvoiceDate { get; set; }
        [StringLength(30)]
        public string? TaxInvoiceNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TaxInvoiceReceiptDate { get; set; }
        [Column("TaxInvoiceSTDAmt", TypeName = "decimal(13, 2)")]
        public decimal? TaxInvoiceStdamt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TaxInvoiceVatAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TaxInvoiceWhtAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TotalTaxInvoiceAmt { get; set; }
        [StringLength(10)]
        public string? VatBranchCode { get; set; }
        [StringLength(20)]
        public string? VatRegistrationNo { get; set; }
        [StringLength(10)]
        public string? VendorCode { get; set; }
        [StringLength(80)]
        public string? VendorName { get; set; }
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
        [StringLength(10)]
        public string? BranchCode { get; set; }
        [StringLength(10)]
        public string? DepartmentCode { get; set; }
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
    }
}
