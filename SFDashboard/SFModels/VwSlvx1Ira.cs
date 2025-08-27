using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSlvx1Ira
    {
        [Column("Invoice No")]
        [StringLength(20)]
        public string? InvoiceNo { get; set; }
        [Column("Ref No")]
        [StringLength(10)]
        public string? RefNo { get; set; }
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
        [Column("Total Std Amt", TypeName = "decimal(38, 2)")]
        public decimal? TotalStdAmt { get; set; }
        [Column("Total Zero Amt", TypeName = "decimal(38, 2)")]
        public decimal? TotalZeroAmt { get; set; }
        [Column("Total Exm Amt", TypeName = "decimal(38, 2)")]
        public decimal? TotalExmAmt { get; set; }
        [Column("Total Out Amt", TypeName = "decimal(38, 2)")]
        public decimal? TotalOutAmt { get; set; }
        [Column("Total Purchases and Imports", TypeName = "decimal(38, 2)")]
        public decimal? TotalPurchasesAndImports { get; set; }
        [Column("Total Out Purchase Amt")]
        public int TotalOutPurchaseAmt { get; set; }
        [Column("Total MES Amt", TypeName = "decimal(38, 2)")]
        public decimal? TotalMesAmt { get; set; }
        [Column("Invoice And Vat Amt", TypeName = "decimal(38, 6)")]
        public decimal? InvoiceAndVatAmt { get; set; }
        [Column("Total Output Vat Amt", TypeName = "decimal(38, 6)")]
        public decimal? TotalOutputVatAmt { get; set; }
        [Column("Total Input Vat Amt", TypeName = "decimal(38, 6)")]
        public decimal? TotalInputVatAmt { get; set; }
        [Column("Total Revenue", TypeName = "decimal(38, 2)")]
        public decimal? TotalRevenue { get; set; }
        [Column("Total Igds Amt", TypeName = "decimal(38, 2)")]
        public decimal? TotalIgdsAmt { get; set; }
        [Column("Total Igds Vat Amt", TypeName = "decimal(38, 2)")]
        public decimal? TotalIgdsVatAmt { get; set; }
        [StringLength(6)]
        [Unicode(false)]
        public string Type { get; set; } = null!;
        [StringLength(3)]
        public string Status { get; set; } = null!;
    }
}
