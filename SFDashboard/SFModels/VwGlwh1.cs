using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwGlwh1
    {
        [Column("Invoice Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? InvoiceDate { get; set; }
        [Column("Post Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? PostDate { get; set; }
        [Column("Ref No")]
        [StringLength(10)]
        public string? RefNo { get; set; }
        [Column("Post Mth")]
        [StringLength(6)]
        public string? PostMth { get; set; }
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Vendor Code")]
        [StringLength(10)]
        public string? VendorCode { get; set; }
        [Column("With Holding Base Amt", TypeName = "decimal(13, 2)")]
        public decimal? WithHoldingBaseAmt { get; set; }
        [Column("With Holding Tax Amt", TypeName = "decimal(13, 2)")]
        public decimal? WithHoldingTaxAmt { get; set; }
        [Column("With Holding Tax Code")]
        [StringLength(15)]
        public string? WithHoldingTaxCode { get; set; }
        [Column("With Holding Tax No")]
        [StringLength(20)]
        public string? WithHoldingTaxNo { get; set; }
        [Column("With Holding Tax Rate", TypeName = "decimal(9, 3)")]
        public decimal? WithHoldingTaxRate { get; set; }
        [StringLength(3)]
        public string Status { get; set; } = null!;
    }
}
