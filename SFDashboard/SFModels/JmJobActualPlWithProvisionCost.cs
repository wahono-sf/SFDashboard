using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class JmJobActualPlWithProvisionCost
    {
        [StringLength(10)]
        public string? Code { get; set; }
        [StringLength(80)]
        public string? Name { get; set; }
        [Column("Job No")]
        [StringLength(20)]
        public string? JobNo { get; set; }
        [Column("Item Code")]
        [StringLength(30)]
        public string? ItemCode { get; set; }
        [Column("Invoice No")]
        [StringLength(20)]
        public string? InvoiceNo { get; set; }
        [Column("Voucher or Apply To No")]
        [StringLength(20)]
        public string? VoucherOrApplyToNo { get; set; }
        [Column("Local Amt", TypeName = "decimal(15, 2)")]
        public decimal? LocalAmt { get; set; }
        [StringLength(3)]
        public string Status { get; set; } = null!;
        [StringLength(2)]
        [Unicode(false)]
        public string Type { get; set; } = null!;
    }
}
