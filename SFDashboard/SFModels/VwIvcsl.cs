using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwIvcsl
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Invoice No")]
        [StringLength(20)]
        public string? InvoiceNo { get; set; }
        [Column("Apply To Invoice")]
        [StringLength(20)]
        public string? ApplyToInvoice { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Job No")]
        [StringLength(30)]
        public string? JobNo { get; set; }
        [Column("Invoice And Vat Amt", TypeName = "decimal(17, 2)")]
        public decimal? InvoiceAndVatAmt { get; set; }
        [Column("Invoice Amt", TypeName = "decimal(17, 2)")]
        public decimal? InvoiceAmt { get; set; }
        [Column("Invoice Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? InvoiceDate { get; set; }
        [Column("Invoice Local Amt", TypeName = "decimal(17, 2)")]
        public decimal? InvoiceLocalAmt { get; set; }
        [Column("Module Code")]
        [StringLength(2)]
        public string? ModuleCode { get; set; }
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
