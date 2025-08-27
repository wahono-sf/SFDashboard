using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwPlvi4
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Line Item No")]
        public short? LineItemNo { get; set; }
        [Column("Customer Code")]
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [Column("Job No")]
        [StringLength(30)]
        public string? JobNo { get; set; }
        [Column("Source Ref No")]
        [StringLength(10)]
        public string? SourceRefNo { get; set; }
        [Column("Tax Flag")]
        [StringLength(1)]
        public string? TaxFlag { get; set; }
        [Column("Vendor Code")]
        [StringLength(10)]
        public string? VendorCode { get; set; }
        [Column("WHT Acc Code")]
        [StringLength(15)]
        public string? WhtAccCode { get; set; }
        [Column("With Holding Base Amt", TypeName = "decimal(13, 2)")]
        public decimal? WithHoldingBaseAmt { get; set; }
        [Column("With Holding Tax Amt", TypeName = "decimal(13, 2)")]
        public decimal? WithHoldingTaxAmt { get; set; }
        [Column("With Holding Tax Code")]
        [StringLength(15)]
        public string? WithHoldingTaxCode { get; set; }
        [Column("With Holding Tax Desc")]
        [StringLength(255)]
        public string? WithHoldingTaxDesc { get; set; }
        [Column("With Holding Tax No")]
        [StringLength(20)]
        public string? WithHoldingTaxNo { get; set; }
        [Column("With Holding Tax Rate", TypeName = "decimal(9, 3)")]
        public decimal? WithHoldingTaxRate { get; set; }
        [Column("Created By")]
        [StringLength(50)]
        public string? CreatedBy { get; set; }
        [Column("Created At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CreatedAt { get; set; }
        [Column("Deleted By")]
        [StringLength(50)]
        public string? DeletedBy { get; set; }
        [Column("Deleted At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? DeletedAt { get; set; }
        [StringLength(3)]
        public string? Status { get; set; }
    }
}
