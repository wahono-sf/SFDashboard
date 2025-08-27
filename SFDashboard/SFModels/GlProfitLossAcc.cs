using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class GlProfitLossAcc
    {
        [Column("Acc Code")]
        [StringLength(15)]
        public string AccCode { get; set; } = null!;
        [Column("Acc Description")]
        [StringLength(50)]
        public string? AccDescription { get; set; }
        [Column("Analysis Code 1")]
        [StringLength(15)]
        public string AnalysisCode1 { get; set; } = null!;
        [Column("Analysis Code 2")]
        [StringLength(15)]
        public string AnalysisCode2 { get; set; } = null!;
        [Column("Analysis Code 3")]
        [StringLength(15)]
        public string AnalysisCode3 { get; set; } = null!;
        [Column("Analysis Code 4")]
        [StringLength(15)]
        public string AnalysisCode4 { get; set; } = null!;
        [Column("Analysis Code 5")]
        [StringLength(15)]
        public string AnalysisCode5 { get; set; } = null!;
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
        [Column("Control Acc Flag")]
        [StringLength(1)]
        public string? ControlAccFlag { get; set; }
        [Column("Current Balance", TypeName = "decimal(13, 2)")]
        public decimal? CurrentBalance { get; set; }
        [Column("Heading Flag")]
        [StringLength(1)]
        public string? HeadingFlag { get; set; }
        [Column("Keep Foreign Balance Flag")]
        [StringLength(1)]
        public string? KeepForeignBalanceFlag { get; set; }
        [Column("Keep Ytd Gl Flag")]
        [StringLength(1)]
        public string? KeepYtdGlFlag { get; set; }
        [Column("Post Detail Flag")]
        [StringLength(1)]
        public string? PostDetailFlag { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Analysis Name 1")]
        [StringLength(50)]
        public string? AnalysisName1 { get; set; }
        [Column("Analysis Name 2")]
        [StringLength(50)]
        public string? AnalysisName2 { get; set; }
        [Column("Analysis Name 3")]
        [StringLength(50)]
        public string? AnalysisName3 { get; set; }
        [Column("Analysis Name 4")]
        [StringLength(50)]
        public string? AnalysisName4 { get; set; }
        [Column("Analysis Name 5")]
        [StringLength(50)]
        public string? AnalysisName5 { get; set; }
        [Column("Created By")]
        [StringLength(50)]
        public string CreatedBy { get; set; } = null!;
        [Column("Created At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CreatedAt { get; set; }
        [Column("Updated By")]
        [StringLength(50)]
        public string UpdatedBy { get; set; } = null!;
        [Column("Updated At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? UpdatedAt { get; set; }
        [StringLength(3)]
        public string Status { get; set; } = null!;
    }
}
