using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("glpa1")]
    public partial class Glpa1
    {
        [Key]
        [StringLength(1)]
        public string UniqueKey { get; set; } = null!;
        /// <summary>
        /// Maximal digit of Account Code
        /// </summary>
        public byte? AccountDigit { get; set; }
        public int? AccountPosition { get; set; }
        /// <summary>
        /// If set as &apos;Y&apos;, it will call the post store prcedure auotmatically as long as the record exit the form if the record is not posted and not deleted
        /// </summary>
        [StringLength(1)]
        public string? AutoPostFlag { get; set; }
        public int? BranchDigit { get; set; }
        public int? BranchPosition { get; set; }
        [StringLength(1)]
        public string? BranchSeparator { get; set; }
        public int? CostCenterDigit { get; set; }
        public int? CostCenterPosition { get; set; }
        [StringLength(1)]
        public string? CostCenterSeparator { get; set; }
        [StringLength(6)]
        public string? CurrentPeriodGl { get; set; }
        /// <summary>
        /// Control the current period of the Invoice in Accounts
        /// </summary>
        [StringLength(6)]
        public string? CurrentPeriodIv { get; set; }
        /// <summary>
        /// Control the current period of the Job Management
        /// </summary>
        [StringLength(6)]
        public string? CurrentPeriodJm { get; set; }
        /// <summary>
        /// Control the current period of the Operation include Invoice and Payment
        /// </summary>
        [StringLength(6)]
        public string? CurrentPeriodOp { get; set; }
        /// <summary>
        /// Control the current period of the Purchase Ledger
        /// </summary>
        [StringLength(6)]
        public string? CurrentPeriodPl { get; set; }
        /// <summary>
        /// Control the current period of the Sales Ledger
        /// </summary>
        [StringLength(6)]
        public string? CurrentPeriodSl { get; set; }
        [Column("CurrentPeriodWHT")]
        [StringLength(6)]
        public string? CurrentPeriodWht { get; set; }
        [StringLength(15)]
        public string? CurrentProfitLossAnalysisCode { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        public byte? DateValidate { get; set; }
        public int? DepartmentDigit { get; set; }
        public int? DepartmentPosition { get; set; }
        [StringLength(1)]
        public string? DepartmentSeparator { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        public byte? DivisionDigit { get; set; }
        /// <summary>
        /// Define the Ex Gain Loss Acc Code
        /// </summary>
        [StringLength(15)]
        public string? ExGainLossAccCode { get; set; }
        /// <summary>
        /// No of Financial Period in Financial Year
        /// </summary>
        public byte? FinancialPeriod { get; set; }
        /// <summary>
        /// Default Financial Year to Financial Year in Yearly Posting
        /// </summary>
        public short? FinancialYear { get; set; }
        /// <summary>
        /// Use in the older Balance Sheet or P&amp;L report
        /// </summary>
        [StringLength(15)]
        public string? FirstCostAccCode { get; set; }
        /// <summary>
        /// Use in the older Balance Sheet or P&amp;L report
        /// </summary>
        [StringLength(15)]
        public string? FirstSalesAccCode { get; set; }
        /// <summary>
        /// If set as Y, will hide the Post button for all user, if set as S, will hide the Post button for access right is U, if set as A, will hide the Post button for access right is U and S
        /// </summary>
        [StringLength(1)]
        public string? HidePostButtonFlag { get; set; }
        /// <summary>
        /// the Ref No. Prefix for Journal Voucher
        /// </summary>
        [StringLength(5)]
        public string? JournalPrefix { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastYr01FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastYr01ToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastYr02FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastYr02ToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastYr03FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastYr03ToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastYr04FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastYr04ToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastYr05FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastYr05ToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastYr06FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastYr06ToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastYr07FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastYr07ToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastYr08FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastYr08ToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastYr09FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastYr09ToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastYr10FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastYr10ToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastYr11FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastYr11ToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastYr12FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastYr12ToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastYr13FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastYr13ToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastYr14FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastYr14ToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastYr15FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastYr15ToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastYr16FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastYr16ToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastYr17FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastYr17ToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastYr18FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastYr18ToDate { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(3)]
        public string? LocalCurrCode { get; set; }
        /// <summary>
        /// If it has value, it will compute the CurrRate from CostCurrRate when Curr Rate is empty (or 0) in glex1 and glex1_1.
        /// </summary>
        [Column(TypeName = "decimal(6, 3)")]
        public decimal? MarkupRate { get; set; }
        [StringLength(200)]
        public string? MasCurr { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(50)]
        public string? NextRefNo { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        public byte? NoOfYrHistory { get; set; }
        [StringLength(100)]
        public string? OcbctokenValue { get; set; }
        /// <summary>
        /// O - When Posting will overwrite the exist record in General Ledger, B - when Posting will insert a new record to General Ledger
        /// </summary>
        [StringLength(1)]
        public string? PostOnlineOrBatch { get; set; }
        /// <summary>
        /// Default the Accounts for the Retain Earning during the Yearly Posting
        /// </summary>
        [StringLength(15)]
        public string? RetainEarnAccCode { get; set; }
        /// <summary>
        /// O - When Reverse Post will overwrite the exist record in General Ledger, B - When Reverse Posting will insert a new record to General Ledger
        /// </summary>
        [StringLength(1)]
        public string? ReversePostOnlineOrBatch { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(15)]
        public string? SalesAccCode { get; set; }
        [StringLength(1)]
        public string? ShowBranchCodeFlag { get; set; }
        [StringLength(1)]
        public string? ShowDepartmentCodeFlag { get; set; }
        [StringLength(1)]
        public string? ShowVatAmtFlag { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        public byte? SiteDigit { get; set; }
        [StringLength(15)]
        public string? TaxAccCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ThisYr01FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ThisYr01ToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ThisYr02FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ThisYr02ToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ThisYr03FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ThisYr03ToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ThisYr04FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ThisYr04ToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ThisYr05FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ThisYr05ToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ThisYr06FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ThisYr06ToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ThisYr07FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ThisYr07ToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ThisYr08FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ThisYr08ToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ThisYr09FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ThisYr09ToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ThisYr10FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ThisYr10ToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ThisYr11FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ThisYr11ToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ThisYr12FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ThisYr12ToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ThisYr13FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ThisYr13ToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ThisYr14FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ThisYr14ToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ThisYr15FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ThisYr15ToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ThisYr16FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ThisYr16ToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ThisYr17FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ThisYr17ToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ThisYr18FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ThisYr18ToDate { get; set; }
        [StringLength(1)]
        public string? UnpostRemarkFlag { get; set; }
        [StringLength(15)]
        public string? UnrealiseAccCode { get; set; }
        [Column("WHTReportDate", TypeName = "datetime")]
        public DateTime? WhtreportDate { get; set; }
        /// <summary>
        /// When parameter is not null or blank, the system should show the button on Glex1 and gleh1 screen.  Use this parameter to post and get the curr rate.
        /// </summary>
        [Column("XECurr")]
        [StringLength(100)]
        public string? Xecurr { get; set; }
        /// <summary>
        /// When parameter is not null or blank, the system should show the button on Glex1 and gleh1 screen.  Use this parameter to post and get the curr rate.
        /// </summary>
        [StringLength(100)]
        public string? YahooCurr { get; set; }
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

        [ForeignKey("LocalCurrCode")]
        [InverseProperty("Glpa1s")]
        public virtual Glex1? LocalCurrCodeNavigation { get; set; }
    }
}
