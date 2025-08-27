using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class JmMasterJobProvisionCost
    {
        [Column("Vendor Code")]
        [StringLength(10)]
        public string? VendorCode { get; set; }
        [Column("Vendor Name")]
        [StringLength(80)]
        public string? VendorName { get; set; }
        [Column("Job No")]
        [StringLength(20)]
        public string JobNo { get; set; } = null!;
        [Column("Invoice No")]
        [StringLength(1)]
        [Unicode(false)]
        public string InvoiceNo { get; set; } = null!;
        [Column("Voucher No")]
        [StringLength(1)]
        [Unicode(false)]
        public string VoucherNo { get; set; } = null!;
        [Column("Item Code")]
        [StringLength(30)]
        public string? ItemCode { get; set; }
        [Column("Local Amt", TypeName = "decimal(13, 2)")]
        public decimal? LocalAmt { get; set; }
        [StringLength(3)]
        [Unicode(false)]
        public string Status { get; set; } = null!;
    }
}
