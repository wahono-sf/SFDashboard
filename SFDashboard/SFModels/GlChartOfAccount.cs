using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class GlChartOfAccount
    {
        [Column("Acc Code")]
        [StringLength(15)]
        public string AccCode { get; set; } = null!;
        [Column("Acc Description")]
        [StringLength(50)]
        public string? AccDescription { get; set; }
        [Column("Acc Type")]
        [StringLength(1)]
        public string? AccType { get; set; }
        [Column("Analysis Code 1")]
        [StringLength(15)]
        public string? AnalysisCode1 { get; set; }
        [Column("Analysis Code 2")]
        [StringLength(15)]
        public string? AnalysisCode2 { get; set; }
        [Column("Analysis Code 3")]
        [StringLength(15)]
        public string? AnalysisCode3 { get; set; }
        [Column("Analysis Code 4")]
        [StringLength(15)]
        public string? AnalysisCode4 { get; set; }
        [Column("Analysis Code 5")]
        [StringLength(15)]
        public string? AnalysisCode5 { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
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
        [Column("Cash Flow Flag")]
        [StringLength(1)]
        public string? CashFlowFlag { get; set; }
        [Column("Control Acc Flag")]
        [StringLength(1)]
        public string? ControlAccFlag { get; set; }
        [Column("Cost Center Code")]
        [StringLength(10)]
        public string? CostCenterCode { get; set; }
        [Column("Current Balance", TypeName = "decimal(38, 2)")]
        public decimal? CurrentBalance { get; set; }
        [Column("Department Code")]
        [StringLength(10)]
        public string? DepartmentCode { get; set; }
        [Column("Heading Flag")]
        [StringLength(1)]
        public string? HeadingFlag { get; set; }
        [Column("Keep Foreign Balance Flag")]
        [StringLength(1)]
        public string? KeepForeignBalanceFlag { get; set; }
        [Column("Keep Ytd Gl Flag")]
        [StringLength(1)]
        public string? KeepYtdGlFlag { get; set; }
        [Column("Last Yr End Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrEndBalanceAmt { get; set; }
        [Column("Last Yr Mth 01 Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth01BalanceAmt { get; set; }
        [Column("Last Yr Mth 02 Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth02BalanceAmt { get; set; }
        [Column("Last Yr Mth 03 Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth03BalanceAmt { get; set; }
        [Column("Last Yr Mth 04 Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth04BalanceAmt { get; set; }
        [Column("Last Yr Mth 05 Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth05BalanceAmt { get; set; }
        [Column("Last Yr Mth 06 Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth06BalanceAmt { get; set; }
        [Column("Last Yr Mth 07 Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth07BalanceAmt { get; set; }
        [Column("Last Yr Mth 08 Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth08BalanceAmt { get; set; }
        [Column("Last Yr Mth 09 Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth09BalanceAmt { get; set; }
        [Column("Last Yr Mth 10 Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth10BalanceAmt { get; set; }
        [Column("Last Yr Mth 11 Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth11BalanceAmt { get; set; }
        [Column("Last Yr Mth 12 Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth12BalanceAmt { get; set; }
        [Column("Last Yr Open Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrOpenBalanceAmt { get; set; }
        [Column("Local Name")]
        [StringLength(255)]
        public string? LocalName { get; set; }
        [Column("Post Detail Flag")]
        [StringLength(1)]
        public string? PostDetailFlag { get; set; }
        [Column("Recoverable Flag")]
        [StringLength(1)]
        public string? RecoverableFlag { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("This Mth 01 End Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisMth01EndBalanceAmt { get; set; }
        [Column("This Mth 02 End Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisMth02EndBalanceAmt { get; set; }
        [Column("This Mth 03 End Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisMth03EndBalanceAmt { get; set; }
        [Column("This Mth 04 End Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisMth04EndBalanceAmt { get; set; }
        [Column("This Mth 05 End Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisMth05EndBalanceAmt { get; set; }
        [Column("This Mth 06 End Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisMth06EndBalanceAmt { get; set; }
        [Column("This Mth 07 End Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisMth07EndBalanceAmt { get; set; }
        [Column("This Mth 08 End Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisMth08EndBalanceAmt { get; set; }
        [Column("This Mth 09 End Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisMth09EndBalanceAmt { get; set; }
        [Column("This Mth 10 End Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisMth10EndBalanceAmt { get; set; }
        [Column("This Mth 11 End Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisMth11EndBalanceAmt { get; set; }
        [Column("This Mth 12 End Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisMth12EndBalanceAmt { get; set; }
        [Column("This Yr Open Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrOpenBalanceAmt { get; set; }
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
