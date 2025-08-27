using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwGlpa1
    {
        [Column("Unique Key")]
        [StringLength(1)]
        public string UniqueKey { get; set; } = null!;
        [Column("Account Digit")]
        public byte? AccountDigit { get; set; }
        [Column("Account Position")]
        public int? AccountPosition { get; set; }
        [Column("Auto Post Flag")]
        [StringLength(1)]
        public string? AutoPostFlag { get; set; }
        [Column("Branch Digit")]
        public int? BranchDigit { get; set; }
        [Column("Branch Position")]
        public int? BranchPosition { get; set; }
        [Column("Branch Separator")]
        [StringLength(1)]
        public string? BranchSeparator { get; set; }
        [Column("Cost Center Digit")]
        public int? CostCenterDigit { get; set; }
        [Column("Cost Center Position")]
        public int? CostCenterPosition { get; set; }
        [Column("Cost Center Separator")]
        [StringLength(1)]
        public string? CostCenterSeparator { get; set; }
        [Column("Current Period Gl")]
        [StringLength(6)]
        public string? CurrentPeriodGl { get; set; }
        [Column("Current Period Iv")]
        [StringLength(6)]
        public string? CurrentPeriodIv { get; set; }
        [Column("Current Period Jm")]
        [StringLength(6)]
        public string? CurrentPeriodJm { get; set; }
        [Column("Current Period Op")]
        [StringLength(6)]
        public string? CurrentPeriodOp { get; set; }
        [Column("Current Period Pl")]
        [StringLength(6)]
        public string? CurrentPeriodPl { get; set; }
        [Column("Current Period Sl")]
        [StringLength(6)]
        public string? CurrentPeriodSl { get; set; }
        [Column("Current Period WHT")]
        [StringLength(6)]
        public string? CurrentPeriodWht { get; set; }
        [Column("Current Profit Loss Analysis Code")]
        [StringLength(15)]
        public string? CurrentProfitLossAnalysisCode { get; set; }
        [Column("Date Validate")]
        public byte? DateValidate { get; set; }
        [Column("Department Digit")]
        public int? DepartmentDigit { get; set; }
        [Column("Department Position")]
        public int? DepartmentPosition { get; set; }
        [Column("Department Separator")]
        [StringLength(1)]
        public string? DepartmentSeparator { get; set; }
        [Column("Division Digit")]
        public byte? DivisionDigit { get; set; }
        [Column("Ex Gain Loss Acc Code")]
        [StringLength(15)]
        public string? ExGainLossAccCode { get; set; }
        [Column("Financial Period")]
        public byte? FinancialPeriod { get; set; }
        [Column("Financial Year")]
        public short? FinancialYear { get; set; }
        [Column("First Cost Acc Code")]
        [StringLength(15)]
        public string? FirstCostAccCode { get; set; }
        [Column("First Sales Acc Code")]
        [StringLength(15)]
        public string? FirstSalesAccCode { get; set; }
        [Column("Hide Post Button Flag")]
        [StringLength(1)]
        public string? HidePostButtonFlag { get; set; }
        [Column("Journal Prefix")]
        [StringLength(5)]
        public string? JournalPrefix { get; set; }
        [Column("Last Yr 01 From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastYr01FromDate { get; set; }
        [Column("Last Yr 01 To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastYr01ToDate { get; set; }
        [Column("Last Yr 02 From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastYr02FromDate { get; set; }
        [Column("Last Yr 02 To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastYr02ToDate { get; set; }
        [Column("Last Yr 03 From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastYr03FromDate { get; set; }
        [Column("Last Yr 03 To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastYr03ToDate { get; set; }
        [Column("Last Yr 04 From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastYr04FromDate { get; set; }
        [Column("Last Yr 04 To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastYr04ToDate { get; set; }
        [Column("Last Yr 05 From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastYr05FromDate { get; set; }
        [Column("Last Yr 05 To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastYr05ToDate { get; set; }
        [Column("Last Yr 06 From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastYr06FromDate { get; set; }
        [Column("Last Yr 06 To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastYr06ToDate { get; set; }
        [Column("Last Yr 07 From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastYr07FromDate { get; set; }
        [Column("Last Yr 07 To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastYr07ToDate { get; set; }
        [Column("Last Yr 08 From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastYr08FromDate { get; set; }
        [Column("Last Yr 08 To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastYr08ToDate { get; set; }
        [Column("Last Yr 09 From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastYr09FromDate { get; set; }
        [Column("Last Yr 09 To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastYr09ToDate { get; set; }
        [Column("Last Yr 10 From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastYr10FromDate { get; set; }
        [Column("Last Yr 10 To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastYr10ToDate { get; set; }
        [Column("Last Yr 11 From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastYr11FromDate { get; set; }
        [Column("Last Yr 11 To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastYr11ToDate { get; set; }
        [Column("Last Yr 12 From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastYr12FromDate { get; set; }
        [Column("Last Yr 12 To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastYr12ToDate { get; set; }
        [Column("Last Yr 13 From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastYr13FromDate { get; set; }
        [Column("Last Yr 13 To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastYr13ToDate { get; set; }
        [Column("Last Yr 14 From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastYr14FromDate { get; set; }
        [Column("Last Yr 14 To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastYr14ToDate { get; set; }
        [Column("Last Yr 15 From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastYr15FromDate { get; set; }
        [Column("Last Yr 15 To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastYr15ToDate { get; set; }
        [Column("Last Yr 16 From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastYr16FromDate { get; set; }
        [Column("Last Yr 16 To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastYr16ToDate { get; set; }
        [Column("Last Yr 17 From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastYr17FromDate { get; set; }
        [Column("Last Yr 17 To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastYr17ToDate { get; set; }
        [Column("Last Yr 18 From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastYr18FromDate { get; set; }
        [Column("Last Yr 18 To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastYr18ToDate { get; set; }
        [Column("Local Curr Code")]
        [StringLength(3)]
        public string? LocalCurrCode { get; set; }
        [Column("Markup Rate", TypeName = "decimal(6, 3)")]
        public decimal? MarkupRate { get; set; }
        [Column("MAS Curr")]
        [StringLength(200)]
        public string? MasCurr { get; set; }
        [Column("Next Ref No")]
        [StringLength(50)]
        public string? NextRefNo { get; set; }
        [Column("No Of Yr History")]
        public byte? NoOfYrHistory { get; set; }
        [Column("Ocbctoken Value")]
        [StringLength(100)]
        public string? OcbctokenValue { get; set; }
        [Column("Post Online Or Batch")]
        [StringLength(1)]
        public string? PostOnlineOrBatch { get; set; }
        [Column("Retain Earn Acc Code")]
        [StringLength(15)]
        public string? RetainEarnAccCode { get; set; }
        [Column("Reverse Post Online Or Batch")]
        [StringLength(1)]
        public string? ReversePostOnlineOrBatch { get; set; }
        [Column("Sales Acc Code")]
        [StringLength(15)]
        public string? SalesAccCode { get; set; }
        [Column("Show Branch Code Flag")]
        [StringLength(1)]
        public string? ShowBranchCodeFlag { get; set; }
        [Column("Show Department Code Flag")]
        [StringLength(1)]
        public string? ShowDepartmentCodeFlag { get; set; }
        [Column("Show Vat Amt Flag")]
        [StringLength(1)]
        public string? ShowVatAmtFlag { get; set; }
        [Column("Site Digit")]
        public byte? SiteDigit { get; set; }
        [Column("Tax Acc Code")]
        [StringLength(15)]
        public string? TaxAccCode { get; set; }
        [Column("This Yr 01 From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ThisYr01FromDate { get; set; }
        [Column("This Yr 01 To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ThisYr01ToDate { get; set; }
        [Column("This Yr 02 From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ThisYr02FromDate { get; set; }
        [Column("This Yr 02 To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ThisYr02ToDate { get; set; }
        [Column("This Yr 03 From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ThisYr03FromDate { get; set; }
        [Column("This Yr 03 To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ThisYr03ToDate { get; set; }
        [Column("This Yr 04 From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ThisYr04FromDate { get; set; }
        [Column("This Yr 04 To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ThisYr04ToDate { get; set; }
        [Column("This Yr 05 From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ThisYr05FromDate { get; set; }
        [Column("This Yr 05 To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ThisYr05ToDate { get; set; }
        [Column("This Yr 06 From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ThisYr06FromDate { get; set; }
        [Column("This Yr 06 To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ThisYr06ToDate { get; set; }
        [Column("This Yr 07 From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ThisYr07FromDate { get; set; }
        [Column("This Yr 07 To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ThisYr07ToDate { get; set; }
        [Column("This Yr 08 From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ThisYr08FromDate { get; set; }
        [Column("This Yr 08 To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ThisYr08ToDate { get; set; }
        [Column("This Yr 09 From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ThisYr09FromDate { get; set; }
        [Column("This Yr 09 To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ThisYr09ToDate { get; set; }
        [Column("This Yr 10 From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ThisYr10FromDate { get; set; }
        [Column("This Yr 10 To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ThisYr10ToDate { get; set; }
        [Column("This Yr 11 From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ThisYr11FromDate { get; set; }
        [Column("This Yr 11 To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ThisYr11ToDate { get; set; }
        [Column("This Yr 12 From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ThisYr12FromDate { get; set; }
        [Column("This Yr 12 To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ThisYr12ToDate { get; set; }
        [Column("This Yr 13 From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ThisYr13FromDate { get; set; }
        [Column("This Yr 13 To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ThisYr13ToDate { get; set; }
        [Column("This Yr 14 From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ThisYr14FromDate { get; set; }
        [Column("This Yr 14 To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ThisYr14ToDate { get; set; }
        [Column("This Yr 15 From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ThisYr15FromDate { get; set; }
        [Column("This Yr 15 To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ThisYr15ToDate { get; set; }
        [Column("This Yr 16 From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ThisYr16FromDate { get; set; }
        [Column("This Yr 16 To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ThisYr16ToDate { get; set; }
        [Column("This Yr 17 From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ThisYr17FromDate { get; set; }
        [Column("This Yr 17 To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ThisYr17ToDate { get; set; }
        [Column("This Yr 18 From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ThisYr18FromDate { get; set; }
        [Column("This Yr 18 To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ThisYr18ToDate { get; set; }
        [Column("Unpost Remark Flag")]
        [StringLength(1)]
        public string? UnpostRemarkFlag { get; set; }
        [Column("Unrealise Acc Code")]
        [StringLength(15)]
        public string? UnrealiseAccCode { get; set; }
        [Column("WHT Report Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? WhtReportDate { get; set; }
        [Column("XE Curr")]
        [StringLength(100)]
        public string? XeCurr { get; set; }
        [Column("Yahoo Curr")]
        [StringLength(100)]
        public string? YahooCurr { get; set; }
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
