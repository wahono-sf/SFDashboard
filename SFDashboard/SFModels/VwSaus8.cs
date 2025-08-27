using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSaus8
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Bottom Margin", TypeName = "decimal(13, 2)")]
        public decimal? BottomMargin { get; set; }
        [Column("Criteria 1")]
        [StringLength(50)]
        public string? Criteria1 { get; set; }
        [Column("Criteria 2")]
        [StringLength(50)]
        public string? Criteria2 { get; set; }
        [Column("Criteria 3")]
        [StringLength(50)]
        public string? Criteria3 { get; set; }
        [Column("Current Flag")]
        [StringLength(1)]
        public string? CurrentFlag { get; set; }
        [Column("Default Print Type")]
        [StringLength(20)]
        public string? DefaultPrintType { get; set; }
        [Column("Email Body")]
        [StringLength(3000)]
        public string? EmailBody { get; set; }
        [Column("Email File Name")]
        [StringLength(50)]
        public string? EmailFileName { get; set; }
        [Column("Email Subject")]
        [StringLength(255)]
        public string? EmailSubject { get; set; }
        [Column("Footer Flag")]
        [StringLength(1)]
        public string? FooterFlag { get; set; }
        [Column("Header Flag")]
        [StringLength(1)]
        public string? HeaderFlag { get; set; }
        [Column("Left Margin", TypeName = "decimal(13, 2)")]
        public decimal? LeftMargin { get; set; }
        [Column("No Of Copy")]
        public byte? NoOfCopy { get; set; }
        [StringLength(50)]
        public string? Orientation { get; set; }
        [Column("Paper Size")]
        [StringLength(50)]
        public string? PaperSize { get; set; }
        [Column("Paper Size Value")]
        public int? PaperSizeValue { get; set; }
        [Column("Paper Source")]
        [StringLength(50)]
        public string? PaperSource { get; set; }
        [Column("Paper Source Value")]
        public int? PaperSourceValue { get; set; }
        [Column("Printer Name")]
        [StringLength(50)]
        public string? PrinterName { get; set; }
        [Column("Quality Flag")]
        [StringLength(1)]
        public string? QualityFlag { get; set; }
        [Column("Report Name")]
        [StringLength(50)]
        public string? ReportName { get; set; }
        [Column("Right Margin", TypeName = "decimal(13, 2)")]
        public decimal? RightMargin { get; set; }
        [Column("Selection Flag")]
        [StringLength(1)]
        public string? SelectionFlag { get; set; }
        [Column("Top Margin", TypeName = "decimal(13, 2)")]
        public decimal? TopMargin { get; set; }
        [Column("User ID")]
        [StringLength(50)]
        public string UserId { get; set; } = null!;
    }
}
