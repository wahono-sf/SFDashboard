using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class JmJobActualSalesCostProvisionCost
    {
        [StringLength(10)]
        public string? Code { get; set; }
        [StringLength(80)]
        public string? Name { get; set; }
        [Column("Job No")]
        [StringLength(20)]
        public string? JobNo { get; set; }
        [Column("Invoice No")]
        [StringLength(255)]
        public string? InvoiceNo { get; set; }
        [Column("Voucher or Apply To No")]
        [StringLength(20)]
        public string? VoucherOrApplyToNo { get; set; }
        [Column("Trx Type")]
        [StringLength(1)]
        public string? TrxType { get; set; }
        [Column("Invoice Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? InvoiceDate { get; set; }
        [Column("Item Code")]
        [StringLength(30)]
        public string? ItemCode { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "decimal(36, 9)")]
        public decimal? Amt { get; set; }
        [Column("Local Amt", TypeName = "decimal(15, 2)")]
        public decimal? LocalAmt { get; set; }
        [Column("Post Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? PostDate { get; set; }
        [Column("Post Mth")]
        [StringLength(6)]
        public string? PostMth { get; set; }
        [StringLength(3)]
        public string Status { get; set; } = null!;
        [Column("Ref No")]
        [StringLength(20)]
        public string? RefNo { get; set; }
        [StringLength(2)]
        [Unicode(false)]
        public string Type { get; set; } = null!;
    }
}
