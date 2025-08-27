using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class JmJobDocNo
    {
        [StringLength(20)]
        public string JobNo { get; set; } = null!;
        [Column("Job Contract Code")]
        public string? JobContractCode { get; set; }
        [Column("Job Invoice No")]
        public string? JobInvoiceNo { get; set; }
        [Column("Job Invoice Date")]
        public string? JobInvoiceDate { get; set; }
        [Column("Job Invoice Curr Rate", TypeName = "decimal(13, 6)")]
        public decimal? JobInvoiceCurrRate { get; set; }
        [Column("Job Vendor Invoice No")]
        public string? JobVendorInvoiceNo { get; set; }
        [Column("Job Vendor Invoice Date")]
        public string? JobVendorInvoiceDate { get; set; }
        [Column("Job Voucher No")]
        public string? JobVoucherNo { get; set; }
        [Column("Job Voucher Date")]
        public string? JobVoucherDate { get; set; }
    }
}
