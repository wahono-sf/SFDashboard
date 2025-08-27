using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class GlAccountBalance
    {
        [Column("Acc Code")]
        [StringLength(15)]
        public string? AccCode { get; set; }
        [Column("Acc Description")]
        [StringLength(50)]
        public string? AccDescription { get; set; }
        [Column("Financial Year")]
        [StringLength(4)]
        public string? FinancialYear { get; set; }
        [Column("Budget Mth 01", TypeName = "decimal(13, 2)")]
        public decimal? BudgetMth01 { get; set; }
        [Column("Budget Mth 02", TypeName = "decimal(13, 2)")]
        public decimal? BudgetMth02 { get; set; }
        [Column("Budget Mth 03", TypeName = "decimal(13, 2)")]
        public decimal? BudgetMth03 { get; set; }
        [Column("Budget Mth 04", TypeName = "decimal(13, 2)")]
        public decimal? BudgetMth04 { get; set; }
        [Column("Budget Mth 05", TypeName = "decimal(13, 2)")]
        public decimal? BudgetMth05 { get; set; }
        [Column("Budget Mth 06", TypeName = "decimal(13, 2)")]
        public decimal? BudgetMth06 { get; set; }
        [Column("Budget Mth 07", TypeName = "decimal(13, 2)")]
        public decimal? BudgetMth07 { get; set; }
        [Column("Budget Mth 08", TypeName = "decimal(13, 2)")]
        public decimal? BudgetMth08 { get; set; }
        [Column("Budget Mth 09", TypeName = "decimal(13, 2)")]
        public decimal? BudgetMth09 { get; set; }
        [Column("Budget Mth 10", TypeName = "decimal(13, 2)")]
        public decimal? BudgetMth10 { get; set; }
        [Column("Budget Mth 11", TypeName = "decimal(13, 2)")]
        public decimal? BudgetMth11 { get; set; }
        [Column("Budget Mth 12", TypeName = "decimal(13, 2)")]
        public decimal? BudgetMth12 { get; set; }
        [Column("Mth 00 Balance", TypeName = "decimal(20, 2)")]
        public decimal? Mth00Balance { get; set; }
        [Column("Mth 01 Balance", TypeName = "decimal(20, 2)")]
        public decimal? Mth01Balance { get; set; }
        [Column("Mth 02 Balance", TypeName = "decimal(20, 2)")]
        public decimal? Mth02Balance { get; set; }
        [Column("Mth 03 Balance", TypeName = "decimal(20, 2)")]
        public decimal? Mth03Balance { get; set; }
        [Column("Mth 04 Balance", TypeName = "decimal(20, 2)")]
        public decimal? Mth04Balance { get; set; }
        [Column("Mth 05 Balance", TypeName = "decimal(20, 2)")]
        public decimal? Mth05Balance { get; set; }
        [Column("Mth 06 Balance", TypeName = "decimal(20, 2)")]
        public decimal? Mth06Balance { get; set; }
        [Column("Mth 07 Balance", TypeName = "decimal(20, 2)")]
        public decimal? Mth07Balance { get; set; }
        [Column("Mth 08 Balance", TypeName = "decimal(20, 2)")]
        public decimal? Mth08Balance { get; set; }
        [Column("Mth 09 Balance", TypeName = "decimal(20, 2)")]
        public decimal? Mth09Balance { get; set; }
        [Column("Mth 10 Balance", TypeName = "decimal(20, 2)")]
        public decimal? Mth10Balance { get; set; }
        [Column("Mth 11 Balance", TypeName = "decimal(20, 2)")]
        public decimal? Mth11Balance { get; set; }
        [Column("Mth 12 Balance", TypeName = "decimal(20, 2)")]
        public decimal? Mth12Balance { get; set; }
        [Column("Mth 13 Balance", TypeName = "decimal(20, 2)")]
        public decimal? Mth13Balance { get; set; }
        [Column("Mth 14 Balance", TypeName = "decimal(20, 2)")]
        public decimal? Mth14Balance { get; set; }
        [Column("Mth 15 Balance", TypeName = "decimal(20, 2)")]
        public decimal? Mth15Balance { get; set; }
        [Column("Mth 16 Balance", TypeName = "decimal(20, 2)")]
        public decimal? Mth16Balance { get; set; }
        [Column("Mth 17 Balance", TypeName = "decimal(20, 2)")]
        public decimal? Mth17Balance { get; set; }
        [Column("Mth 18 Balance", TypeName = "decimal(20, 2)")]
        public decimal? Mth18Balance { get; set; }
        [StringLength(3)]
        public string Status { get; set; } = null!;
    }
}
