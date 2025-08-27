using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwPlti1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Invoice Or Payment Ref No")]
        [StringLength(10)]
        public string? InvoiceOrPaymentRefNo { get; set; }
        [Column("Address 1")]
        [StringLength(45)]
        public string? Address1 { get; set; }
        [Column("Address 2")]
        [StringLength(45)]
        public string? Address2 { get; set; }
        [Column("Address 3")]
        [StringLength(45)]
        public string? Address3 { get; set; }
        [Column("Address 4")]
        [StringLength(45)]
        public string? Address4 { get; set; }
        [Column("Internal Tax Ref No")]
        [StringLength(10)]
        public string? InternalTaxRefNo { get; set; }
        [Column("Post Mth")]
        [StringLength(6)]
        public string? PostMth { get; set; }
        [Column("Tax Invoice Amt", TypeName = "decimal(13, 2)")]
        public decimal? TaxInvoiceAmt { get; set; }
        [Column("Tax Invoice Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? TaxInvoiceDate { get; set; }
        [Column("Tax Invoice No")]
        [StringLength(30)]
        public string? TaxInvoiceNo { get; set; }
        [Column("Tax Invoice Receipt Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? TaxInvoiceReceiptDate { get; set; }
        [Column("Tax Invoice S T D Amt", TypeName = "decimal(13, 2)")]
        public decimal? TaxInvoiceSTDAmt { get; set; }
        [Column("Tax Invoice Vat Amt", TypeName = "decimal(13, 2)")]
        public decimal? TaxInvoiceVatAmt { get; set; }
        [Column("Tax Invoice Wht Amt", TypeName = "decimal(13, 2)")]
        public decimal? TaxInvoiceWhtAmt { get; set; }
        [Column("Total Tax Invoice Amt", TypeName = "decimal(13, 2)")]
        public decimal? TotalTaxInvoiceAmt { get; set; }
        [Column("Vat Branch Code")]
        [StringLength(10)]
        public string? VatBranchCode { get; set; }
        [Column("Vat Registration No")]
        [StringLength(20)]
        public string? VatRegistrationNo { get; set; }
        [Column("Vendor Code")]
        [StringLength(10)]
        public string? VendorCode { get; set; }
        [Column("Vendor Name")]
        [StringLength(80)]
        public string? VendorName { get; set; }
        [Column("Work Station")]
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
        [Column("Branch Code")]
        [StringLength(10)]
        public string? BranchCode { get; set; }
        [Column("Department Code")]
        [StringLength(10)]
        public string? DepartmentCode { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Created By")]
        [StringLength(50)]
        public string CreatedBy { get; set; } = null!;
        [Column("Created At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CreatedAt { get; set; }
        [Column("Updated By")]
        [StringLength(50)]
        public string UpdatedBy { get; set; } = null!;
        [Column("Updated At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? UpdatedAt { get; set; }
        [StringLength(3)]
        public string Status { get; set; } = null!;
    }
}
