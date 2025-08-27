using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("glch1")]
    [Index("AccDescription", Name = "INDEX_Glch1_AccDescription")]
    [Index("StatusCode", Name = "INDEX_Glch1_StatusCode")]
    public partial class Glch1
    {
        public Glch1()
        {
            Ivcr2s = new HashSet<Ivcr2>();
            Jmcs1s = new HashSet<Jmcs1>();
        }

        [Key]
        [StringLength(15)]
        public string AccCode { get; set; } = null!;
        [StringLength(50)]
        public string? AccDescription { get; set; }
        [StringLength(1)]
        public string? AccClass { get; set; }
        [StringLength(1)]
        public string? AccType { get; set; }
        [StringLength(15)]
        public string? AnalysisCode1 { get; set; }
        [StringLength(15)]
        public string? AnalysisCode2 { get; set; }
        [StringLength(15)]
        public string? AnalysisCode3 { get; set; }
        [StringLength(15)]
        public string? AnalysisCode4 { get; set; }
        [StringLength(15)]
        public string? AnalysisCode5 { get; set; }
        [StringLength(15)]
        public string? AnalysisCode11 { get; set; }
        [StringLength(15)]
        public string? AnalysisCode12 { get; set; }
        [StringLength(15)]
        public string? AnalysisCode13 { get; set; }
        [StringLength(15)]
        public string? AnalysisCode14 { get; set; }
        [StringLength(15)]
        public string? AnalysisCode15 { get; set; }
        [StringLength(10)]
        public string? BranchCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? BudgetMth01 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? BudgetMth02 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? BudgetMth03 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? BudgetMth04 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? BudgetMth05 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? BudgetMth06 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? BudgetMth07 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? BudgetMth08 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? BudgetMth09 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? BudgetMth10 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? BudgetMth11 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? BudgetMth12 { get; set; }
        [StringLength(1)]
        public string? CashEqAccCodeFlag { get; set; }
        [StringLength(15)]
        public string? CashFlowAnalysisCode1 { get; set; }
        [StringLength(15)]
        public string? CashFlowAnalysisCode2 { get; set; }
        [StringLength(15)]
        public string? CashFlowAnalysisCode3 { get; set; }
        [StringLength(15)]
        public string? CashFlowAnalysisCode4 { get; set; }
        [StringLength(15)]
        public string? CashFlowAnalysisCode5 { get; set; }
        [StringLength(1)]
        public string? CashFlowFlag { get; set; }
        [StringLength(1)]
        public string? ControlAccFlag { get; set; }
        [StringLength(10)]
        public string? CostCenterCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? CurrentBalance { get; set; }
        [StringLength(10)]
        public string? DepartmentCode { get; set; }
        [StringLength(1)]
        public string? HeadingFlag { get; set; }
        [StringLength(1)]
        public string? KeepForeignBalanceFlag { get; set; }
        [StringLength(1)]
        public string? KeepYtdGlFlag { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrEndBalanceAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth01BalanceAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth02BalanceAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth03BalanceAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth04BalanceAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth05BalanceAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth06BalanceAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth07BalanceAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth08BalanceAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth09BalanceAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth10BalanceAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth11BalanceAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth12BalanceAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrOpenBalanceAmt { get; set; }
        [StringLength(255)]
        public string? LocalName { get; set; }
        [StringLength(15)]
        public string? MainAccCode { get; set; }
        [StringLength(1)]
        public string? MainAccFlag { get; set; }
        [StringLength(1)]
        public string? PaymentAccFlag { get; set; }
        [StringLength(1)]
        public string? PostDetailFlag { get; set; }
        [StringLength(1)]
        public string? ReceiptAccFlag { get; set; }
        [StringLength(1)]
        public string? ReconcilFlag { get; set; }
        [StringLength(1)]
        public string? RecoverableFlag { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisMth01EndBalanceAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisMth02EndBalanceAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisMth03EndBalanceAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisMth04EndBalanceAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisMth05EndBalanceAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisMth06EndBalanceAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisMth07EndBalanceAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisMth08EndBalanceAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisMth09EndBalanceAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisMth10EndBalanceAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisMth11EndBalanceAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisMth12EndBalanceAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrOpenBalanceAmt { get; set; }
        [StringLength(3)]
        public string StatusCode { get; set; } = null!;
        [StringLength(50)]
        public string CreateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CreateDateTime { get; set; }
        [StringLength(50)]
        public string UpdateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime UpdateDateTime { get; set; }
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }

        [InverseProperty("AccCodeNavigation")]
        public virtual ICollection<Ivcr2> Ivcr2s { get; set; }
        [InverseProperty("AccCodeNavigation")]
        public virtual ICollection<Jmcs1> Jmcs1s { get; set; }
    }
}
