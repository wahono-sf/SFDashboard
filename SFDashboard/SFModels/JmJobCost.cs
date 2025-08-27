using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class JmJobCost
    {
        [Column("Vendor Code")]
        [StringLength(10)]
        public string? VendorCode { get; set; }
        [Column("Vendor Name")]
        [StringLength(80)]
        public string? VendorName { get; set; }
        [Column("Job No")]
        [StringLength(20)]
        public string? JobNo { get; set; }
        [Column("Invoice No")]
        [StringLength(20)]
        public string? InvoiceNo { get; set; }
        [Column("Voucher No")]
        [StringLength(20)]
        public string? VoucherNo { get; set; }
        [Column("Item Code")]
        [StringLength(30)]
        public string? ItemCode { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [Column("Local Amt", TypeName = "decimal(13, 2)")]
        public decimal? LocalAmt { get; set; }
        [StringLength(3)]
        public string Status { get; set; } = null!;
    }
}
