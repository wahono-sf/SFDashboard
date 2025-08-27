using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("sapp1")]
    [Index("GroupName", Name = "INDEX_Sapp1_GroupName")]
    public partial class Sapp1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(1)]
        public string? AccessRight { get; set; }
        [StringLength(1)]
        public string? AccountReportFlag { get; set; }
        [StringLength(50)]
        public string? AttachmentFileName { get; set; }
        [StringLength(1)]
        public string? AuditLogFlag { get; set; }
        [StringLength(1)]
        public string? AutoAttachmentFlag { get; set; }
        [StringLength(100)]
        public string? AutoAttachmentPath { get; set; }
        [StringLength(50)]
        public string? AutoEmail { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? BottomMargin { get; set; }
        [StringLength(1)]
        public string? BranchCodeFlag { get; set; }
        [StringLength(50)]
        public string? ButtonFunction { get; set; }
        [StringLength(1)]
        public string? CalendarDateFlag { get; set; }
        [StringLength(1)]
        public string? CalendarMthFlag { get; set; }
        [StringLength(50)]
        public string? CaptionName { get; set; }
        [StringLength(1)]
        public string? ConsolFlag { get; set; }
        [StringLength(1)]
        public string? ConsolIndividualFlag { get; set; }
        [StringLength(1)]
        public string? ConsolNotifyAttachFlag { get; set; }
        [StringLength(50)]
        public string? Criteria1 { get; set; }
        [StringLength(50)]
        public string? Criteria2 { get; set; }
        [StringLength(50)]
        public string? Criteria3 { get; set; }
        [StringLength(50)]
        public string? Criteria4 { get; set; }
        [StringLength(50)]
        public string? Criteria5 { get; set; }
        [StringLength(50)]
        public string? Criteria6 { get; set; }
        [StringLength(50)]
        public string? Criteria7 { get; set; }
        [StringLength(50)]
        public string? CrystalParameterName01 { get; set; }
        [StringLength(50)]
        public string? CrystalParameterName02 { get; set; }
        [StringLength(50)]
        public string? CrystalParameterName03 { get; set; }
        [StringLength(50)]
        public string? CrystalParameterName04 { get; set; }
        [StringLength(50)]
        public string? CrystalParameterName05 { get; set; }
        [StringLength(50)]
        public string? CrystalParameterName06 { get; set; }
        [StringLength(50)]
        public string? CrystalParameterName07 { get; set; }
        [StringLength(50)]
        public string? CrystalParameterName08 { get; set; }
        [StringLength(50)]
        public string? CrystalParameterName09 { get; set; }
        [StringLength(50)]
        public string? CrystalParameterName10 { get; set; }
        [StringLength(255)]
        public string? CrystalParameterScheduleDefault01 { get; set; }
        [StringLength(255)]
        public string? CrystalParameterScheduleDefault02 { get; set; }
        [StringLength(255)]
        public string? CrystalParameterScheduleDefault03 { get; set; }
        [StringLength(255)]
        public string? CrystalParameterScheduleDefault04 { get; set; }
        [StringLength(255)]
        public string? CrystalParameterScheduleDefault05 { get; set; }
        [StringLength(255)]
        public string? CrystalParameterScheduleDefault06 { get; set; }
        [StringLength(255)]
        public string? CrystalParameterScheduleDefault07 { get; set; }
        [StringLength(255)]
        public string? CrystalParameterScheduleDefault08 { get; set; }
        [StringLength(255)]
        public string? CrystalParameterScheduleDefault09 { get; set; }
        [StringLength(255)]
        public string? CrystalParameterScheduleDefault10 { get; set; }
        [StringLength(255)]
        public string? CrystalParameterValue01 { get; set; }
        [StringLength(255)]
        public string? CrystalParameterValue02 { get; set; }
        [StringLength(255)]
        public string? CrystalParameterValue03 { get; set; }
        [StringLength(255)]
        public string? CrystalParameterValue04 { get; set; }
        [StringLength(255)]
        public string? CrystalParameterValue05 { get; set; }
        [StringLength(255)]
        public string? CrystalParameterValue06 { get; set; }
        [StringLength(255)]
        public string? CrystalParameterValue07 { get; set; }
        [StringLength(255)]
        public string? CrystalParameterValue08 { get; set; }
        [StringLength(255)]
        public string? CrystalParameterValue09 { get; set; }
        [StringLength(255)]
        public string? CrystalParameterValue10 { get; set; }
        [StringLength(1)]
        public string? CurrentFlag { get; set; }
        [StringLength(1)]
        public string? DefaultByUserFlag { get; set; }
        [StringLength(20)]
        public string? DefaultPrintType { get; set; }
        [StringLength(1)]
        public string? DisplayFlag01 { get; set; }
        [StringLength(1)]
        public string? DisplayFlag02 { get; set; }
        [StringLength(1)]
        public string? DisplayFlag03 { get; set; }
        [StringLength(1)]
        public string? DisplayFlag04 { get; set; }
        [StringLength(1)]
        public string? DisplayFlag05 { get; set; }
        [StringLength(1)]
        public string? DisplayFlag06 { get; set; }
        [StringLength(1)]
        public string? DisplayFlag07 { get; set; }
        [StringLength(1)]
        public string? DisplayFlag08 { get; set; }
        [StringLength(1)]
        public string? DisplayFlag09 { get; set; }
        [StringLength(1)]
        public string? DisplayFlag10 { get; set; }
        [StringLength(1)]
        public string? DocNoFlag { get; set; }
        [StringLength(1)]
        public string? DocumentRemarkFlag { get; set; }
        [StringLength(3000)]
        public string? EmailBody { get; set; }
        [StringLength(50)]
        public string? EmailFileName { get; set; }
        [StringLength(50)]
        public string? EmailPartyField { get; set; }
        [StringLength(1)]
        public string? ExportReportFlag { get; set; }
        [StringLength(1)]
        public string? ExpressPrintFlag { get; set; }
        [StringLength(1)]
        public string? FilterSalesmanFlag { get; set; }
        [StringLength(1)]
        public string? FooterFlag { get; set; }
        [StringLength(4)]
        public string? GroupName { get; set; }
        [StringLength(1)]
        public string? HeaderFlag { get; set; }
        [StringLength(500)]
        public string? JobType { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LeftMargin { get; set; }
        [StringLength(1)]
        public string? LockCopyFlag { get; set; }
        [StringLength(1)]
        public string? LockFlag01 { get; set; }
        [StringLength(1)]
        public string? LockFlag02 { get; set; }
        [StringLength(1)]
        public string? LockFlag03 { get; set; }
        [StringLength(1)]
        public string? LockFlag04 { get; set; }
        [StringLength(1)]
        public string? LockFlag05 { get; set; }
        [StringLength(1)]
        public string? LockFlag06 { get; set; }
        [StringLength(1)]
        public string? LockFlag07 { get; set; }
        [StringLength(1)]
        public string? LockFlag08 { get; set; }
        [StringLength(1)]
        public string? LockFlag09 { get; set; }
        [StringLength(1)]
        public string? LockFlag10 { get; set; }
        [StringLength(1)]
        public string? MgmtReportFlag { get; set; }
        public byte? NoOfCopy { get; set; }
        public int? NoOfCriteria { get; set; }
        [StringLength(1)]
        public string? NotifyNoPrintFlag { get; set; }
        [StringLength(50)]
        public string? Orientation { get; set; }
        [StringLength(255)]
        public string? OtherReportPath { get; set; }
        [StringLength(50)]
        public string? PaperSize { get; set; }
        public int? PaperSizeValue { get; set; }
        [StringLength(50)]
        public string? PaperSource { get; set; }
        public int? PaperSourceValue { get; set; }
        [StringLength(255)]
        public string? ParameterDefault01 { get; set; }
        [StringLength(255)]
        public string? ParameterDefault02 { get; set; }
        [StringLength(255)]
        public string? ParameterDefault03 { get; set; }
        [StringLength(255)]
        public string? ParameterDefault04 { get; set; }
        [StringLength(255)]
        public string? ParameterDefault05 { get; set; }
        [StringLength(255)]
        public string? ParameterDefault06 { get; set; }
        [StringLength(255)]
        public string? ParameterDefault07 { get; set; }
        [StringLength(255)]
        public string? ParameterDefault08 { get; set; }
        [StringLength(255)]
        public string? ParameterDefault09 { get; set; }
        [StringLength(255)]
        public string? ParameterDefault10 { get; set; }
        [StringLength(50)]
        public string? ParameterName01 { get; set; }
        [StringLength(50)]
        public string? ParameterName02 { get; set; }
        [StringLength(50)]
        public string? ParameterName03 { get; set; }
        [StringLength(50)]
        public string? ParameterName04 { get; set; }
        [StringLength(50)]
        public string? ParameterName05 { get; set; }
        [StringLength(50)]
        public string? ParameterName06 { get; set; }
        [StringLength(50)]
        public string? ParameterName07 { get; set; }
        [StringLength(50)]
        public string? ParameterName08 { get; set; }
        [StringLength(50)]
        public string? ParameterName09 { get; set; }
        [StringLength(50)]
        public string? ParameterName10 { get; set; }
        [StringLength(5)]
        public string? ParameterTable01 { get; set; }
        [StringLength(5)]
        public string? ParameterTable02 { get; set; }
        [StringLength(5)]
        public string? ParameterTable03 { get; set; }
        [StringLength(5)]
        public string? ParameterTable04 { get; set; }
        [StringLength(5)]
        public string? ParameterTable05 { get; set; }
        [StringLength(5)]
        public string? ParameterTable06 { get; set; }
        [StringLength(5)]
        public string? ParameterTable07 { get; set; }
        [StringLength(5)]
        public string? ParameterTable08 { get; set; }
        [StringLength(5)]
        public string? ParameterTable09 { get; set; }
        [StringLength(5)]
        public string? ParameterTable10 { get; set; }
        [StringLength(255)]
        public string? ParameterValue01 { get; set; }
        [StringLength(255)]
        public string? ParameterValue02 { get; set; }
        [StringLength(255)]
        public string? ParameterValue03 { get; set; }
        [StringLength(255)]
        public string? ParameterValue04 { get; set; }
        [StringLength(255)]
        public string? ParameterValue05 { get; set; }
        [StringLength(255)]
        public string? ParameterValue06 { get; set; }
        [StringLength(255)]
        public string? ParameterValue07 { get; set; }
        [StringLength(255)]
        public string? ParameterValue08 { get; set; }
        [StringLength(255)]
        public string? ParameterValue09 { get; set; }
        [StringLength(255)]
        public string? ParameterValue10 { get; set; }
        [StringLength(1)]
        public string? PdfReportFlag { get; set; }
        public int? PrintCount { get; set; }
        [StringLength(1)]
        public string? PrintCountFlag { get; set; }
        [StringLength(1)]
        public string? PrintTypeFlag { get; set; }
        [StringLength(50)]
        public string? PrinterName { get; set; }
        [StringLength(1)]
        public string? PromptSelectionFlag { get; set; }
        [StringLength(1)]
        public string? QualityFlag { get; set; }
        [StringLength(50)]
        public string? ReportName { get; set; }
        [StringLength(50)]
        public string? ReportName1 { get; set; }
        [StringLength(50)]
        public string? ReportName2 { get; set; }
        [StringLength(1)]
        public string? ReportPrintCountFlag { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? RightMargin { get; set; }
        [StringLength(1)]
        public string? SelectionFlag { get; set; }
        public byte? SeqNo { get; set; }
        [StringLength(20)]
        public string? ShipmentType { get; set; }
        [StringLength(1)]
        public string? ShowEnquiryFlag { get; set; }
        [StringLength(50)]
        public string? SpecialFunction { get; set; }
        [StringLength(50)]
        public string? StrKey { get; set; }
        [StringLength(80)]
        public string? SubjectFormat { get; set; }
        [StringLength(1)]
        public string? SubreportFlag { get; set; }
        [StringLength(2)]
        public string? SubSeqNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TopMargin { get; set; }
        [StringLength(50)]
        public string? UpdateStatusCode { get; set; }
        [StringLength(1)]
        public string? UseFlag { get; set; }
        [Column("UserID")]
        [StringLength(1000)]
        public string? UserId { get; set; }
        [StringLength(500)]
        public string? UserRole { get; set; }
        [StringLength(20)]
        public string? ViewName { get; set; }
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
    }
}
