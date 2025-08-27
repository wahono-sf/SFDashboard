using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSlvx11
    {
        [Column("Invoice No")]
        [StringLength(20)]
        public string? InvoiceNo { get; set; }
        [Column("Invoice Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? InvoiceDate { get; set; }
        [Column("Post Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? PostDate { get; set; }
        [Column("Post Mth")]
        [StringLength(6)]
        public string? PostMth { get; set; }
        [Column("Customer Name")]
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [Column("Customer Code")]
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [Column("Total Zero Amt", TypeName = "decimal(38, 2)")]
        public decimal? TotalZeroAmt { get; set; }
        [Column("Total Std Amt", TypeName = "decimal(38, 2)")]
        public decimal? TotalStdAmt { get; set; }
        [Column("Total Out Amt", TypeName = "decimal(38, 2)")]
        public decimal? TotalOutAmt { get; set; }
        [Column("Total Exm Amt", TypeName = "decimal(38, 2)")]
        public decimal? TotalExmAmt { get; set; }
        [Column("Ref No")]
        [StringLength(10)]
        public string? RefNo { get; set; }
        [Column("Invoice And Vat Amt", TypeName = "decimal(32, 12)")]
        public decimal? InvoiceAndVatAmt { get; set; }
        [Column("Total Vat Amt", TypeName = "decimal(31, 12)")]
        public decimal? TotalVatAmt { get; set; }
        [StringLength(3)]
        public string Status { get; set; } = null!;
    }
}
