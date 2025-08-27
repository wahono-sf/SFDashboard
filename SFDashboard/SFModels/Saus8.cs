using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("saus8")]
    public partial class Saus8
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        [Column("UserID")]
        [StringLength(50)]
        public string UserId { get; set; } = null!;
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? BottomMargin { get; set; }
        [StringLength(50)]
        public string? Criteria1 { get; set; }
        [StringLength(50)]
        public string? Criteria2 { get; set; }
        [StringLength(50)]
        public string? Criteria3 { get; set; }
        [StringLength(1)]
        public string? CurrentFlag { get; set; }
        [StringLength(20)]
        public string? DefaultPrintType { get; set; }
        [StringLength(3000)]
        public string? EmailBody { get; set; }
        [StringLength(50)]
        public string? EmailFileName { get; set; }
        [StringLength(255)]
        public string? EmailSubject { get; set; }
        [StringLength(1)]
        public string? FooterFlag { get; set; }
        [StringLength(1)]
        public string? HeaderFlag { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LeftMargin { get; set; }
        public byte? NoOfCopy { get; set; }
        [StringLength(50)]
        public string? Orientation { get; set; }
        [StringLength(50)]
        public string? PaperSize { get; set; }
        public int? PaperSizeValue { get; set; }
        [StringLength(50)]
        public string? PaperSource { get; set; }
        public int? PaperSourceValue { get; set; }
        [StringLength(50)]
        public string? PrinterName { get; set; }
        [StringLength(1)]
        public string? QualityFlag { get; set; }
        [StringLength(50)]
        public string? ReportName { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? RightMargin { get; set; }
        [StringLength(1)]
        public string? SelectionFlag { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TopMargin { get; set; }
    }
}
