using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSapp1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Access Right")]
        [StringLength(1)]
        public string? AccessRight { get; set; }
        [Column("Account Report Flag")]
        [StringLength(1)]
        public string? AccountReportFlag { get; set; }
        [Column("Attachment File Name")]
        [StringLength(50)]
        public string? AttachmentFileName { get; set; }
        [Column("Audit Log Flag")]
        [StringLength(1)]
        public string? AuditLogFlag { get; set; }
        [Column("Auto Attachment Flag")]
        [StringLength(1)]
        public string? AutoAttachmentFlag { get; set; }
        [Column("Auto Attachment Path")]
        [StringLength(100)]
        public string? AutoAttachmentPath { get; set; }
        [Column("Auto Email")]
        [StringLength(50)]
        public string? AutoEmail { get; set; }
        [Column("Bottom Margin", TypeName = "decimal(13, 2)")]
        public decimal? BottomMargin { get; set; }
        [Column("Branch Code Flag")]
        [StringLength(1)]
        public string? BranchCodeFlag { get; set; }
        [Column("Button Function")]
        [StringLength(50)]
        public string? ButtonFunction { get; set; }
        [Column("Calendar Date Flag")]
        [StringLength(1)]
        public string? CalendarDateFlag { get; set; }
        [Column("Calendar Mth Flag")]
        [StringLength(1)]
        public string? CalendarMthFlag { get; set; }
        [Column("Caption Name")]
        [StringLength(50)]
        public string? CaptionName { get; set; }
        [Column("Consol Flag")]
        [StringLength(1)]
        public string? ConsolFlag { get; set; }
        [Column("Consol Individual Flag")]
        [StringLength(1)]
        public string? ConsolIndividualFlag { get; set; }
        [Column("Consol Notify Attach Flag")]
        [StringLength(1)]
        public string? ConsolNotifyAttachFlag { get; set; }
        [Column("Criteria 1")]
        [StringLength(50)]
        public string? Criteria1 { get; set; }
        [Column("Criteria 2")]
        [StringLength(50)]
        public string? Criteria2 { get; set; }
        [Column("Criteria 3")]
        [StringLength(50)]
        public string? Criteria3 { get; set; }
        [Column("Criteria 4")]
        [StringLength(50)]
        public string? Criteria4 { get; set; }
        [Column("Criteria 5")]
        [StringLength(50)]
        public string? Criteria5 { get; set; }
        [Column("Criteria 6")]
        [StringLength(50)]
        public string? Criteria6 { get; set; }
        [Column("Criteria 7")]
        [StringLength(50)]
        public string? Criteria7 { get; set; }
        [Column("Crystal Parameter Name 01")]
        [StringLength(50)]
        public string? CrystalParameterName01 { get; set; }
        [Column("Crystal Parameter Name 02")]
        [StringLength(50)]
        public string? CrystalParameterName02 { get; set; }
        [Column("Crystal Parameter Name 03")]
        [StringLength(50)]
        public string? CrystalParameterName03 { get; set; }
        [Column("Crystal Parameter Name 04")]
        [StringLength(50)]
        public string? CrystalParameterName04 { get; set; }
        [Column("Crystal Parameter Name 05")]
        [StringLength(50)]
        public string? CrystalParameterName05 { get; set; }
        [Column("Crystal Parameter Name 06")]
        [StringLength(50)]
        public string? CrystalParameterName06 { get; set; }
        [Column("Crystal Parameter Name 07")]
        [StringLength(50)]
        public string? CrystalParameterName07 { get; set; }
        [Column("Crystal Parameter Name 08")]
        [StringLength(50)]
        public string? CrystalParameterName08 { get; set; }
        [Column("Crystal Parameter Name 09")]
        [StringLength(50)]
        public string? CrystalParameterName09 { get; set; }
        [Column("Crystal Parameter Name 10")]
        [StringLength(50)]
        public string? CrystalParameterName10 { get; set; }
        [Column("Crystal Parameter Schedule Default 01")]
        [StringLength(255)]
        public string? CrystalParameterScheduleDefault01 { get; set; }
        [Column("Crystal Parameter Schedule Default 02")]
        [StringLength(255)]
        public string? CrystalParameterScheduleDefault02 { get; set; }
        [Column("Crystal Parameter Schedule Default 03")]
        [StringLength(255)]
        public string? CrystalParameterScheduleDefault03 { get; set; }
        [Column("Crystal Parameter Schedule Default 04")]
        [StringLength(255)]
        public string? CrystalParameterScheduleDefault04 { get; set; }
        [Column("Crystal Parameter Schedule Default 05")]
        [StringLength(255)]
        public string? CrystalParameterScheduleDefault05 { get; set; }
        [Column("Crystal Parameter Schedule Default 06")]
        [StringLength(255)]
        public string? CrystalParameterScheduleDefault06 { get; set; }
        [Column("Crystal Parameter Schedule Default 07")]
        [StringLength(255)]
        public string? CrystalParameterScheduleDefault07 { get; set; }
        [Column("Crystal Parameter Schedule Default 08")]
        [StringLength(255)]
        public string? CrystalParameterScheduleDefault08 { get; set; }
        [Column("Crystal Parameter Schedule Default 09")]
        [StringLength(255)]
        public string? CrystalParameterScheduleDefault09 { get; set; }
        [Column("Crystal Parameter Schedule Default 10")]
        [StringLength(255)]
        public string? CrystalParameterScheduleDefault10 { get; set; }
        [Column("Crystal Parameter Value 01")]
        [StringLength(255)]
        public string? CrystalParameterValue01 { get; set; }
        [Column("Crystal Parameter Value 02")]
        [StringLength(255)]
        public string? CrystalParameterValue02 { get; set; }
        [Column("Crystal Parameter Value 03")]
        [StringLength(255)]
        public string? CrystalParameterValue03 { get; set; }
        [Column("Crystal Parameter Value 04")]
        [StringLength(255)]
        public string? CrystalParameterValue04 { get; set; }
        [Column("Crystal Parameter Value 05")]
        [StringLength(255)]
        public string? CrystalParameterValue05 { get; set; }
        [Column("Crystal Parameter Value 06")]
        [StringLength(255)]
        public string? CrystalParameterValue06 { get; set; }
        [Column("Crystal Parameter Value 07")]
        [StringLength(255)]
        public string? CrystalParameterValue07 { get; set; }
        [Column("Crystal Parameter Value 08")]
        [StringLength(255)]
        public string? CrystalParameterValue08 { get; set; }
        [Column("Crystal Parameter Value 09")]
        [StringLength(255)]
        public string? CrystalParameterValue09 { get; set; }
        [Column("Crystal Parameter Value 10")]
        [StringLength(255)]
        public string? CrystalParameterValue10 { get; set; }
        [Column("Current Flag")]
        [StringLength(1)]
        public string? CurrentFlag { get; set; }
        [Column("Default By User Flag")]
        [StringLength(1)]
        public string? DefaultByUserFlag { get; set; }
        [Column("Default Print Type")]
        [StringLength(20)]
        public string? DefaultPrintType { get; set; }
        [Column("Display Flag 01")]
        [StringLength(1)]
        public string? DisplayFlag01 { get; set; }
        [Column("Display Flag 02")]
        [StringLength(1)]
        public string? DisplayFlag02 { get; set; }
        [Column("Display Flag 03")]
        [StringLength(1)]
        public string? DisplayFlag03 { get; set; }
        [Column("Display Flag 04")]
        [StringLength(1)]
        public string? DisplayFlag04 { get; set; }
        [Column("Display Flag 05")]
        [StringLength(1)]
        public string? DisplayFlag05 { get; set; }
        [Column("Display Flag 06")]
        [StringLength(1)]
        public string? DisplayFlag06 { get; set; }
        [Column("Display Flag 07")]
        [StringLength(1)]
        public string? DisplayFlag07 { get; set; }
        [Column("Display Flag 08")]
        [StringLength(1)]
        public string? DisplayFlag08 { get; set; }
        [Column("Display Flag 09")]
        [StringLength(1)]
        public string? DisplayFlag09 { get; set; }
        [Column("Display Flag 10")]
        [StringLength(1)]
        public string? DisplayFlag10 { get; set; }
        [Column("Doc No Flag")]
        [StringLength(1)]
        public string? DocNoFlag { get; set; }
        [Column("Document Remark Flag")]
        [StringLength(1)]
        public string? DocumentRemarkFlag { get; set; }
        [Column("Email Body")]
        [StringLength(3000)]
        public string? EmailBody { get; set; }
        [Column("Email File Name")]
        [StringLength(50)]
        public string? EmailFileName { get; set; }
        [Column("Email Party Field")]
        [StringLength(50)]
        public string? EmailPartyField { get; set; }
        [Column("Export Report Flag")]
        [StringLength(1)]
        public string? ExportReportFlag { get; set; }
        [Column("Express Print Flag")]
        [StringLength(1)]
        public string? ExpressPrintFlag { get; set; }
        [Column("Filter Salesman Flag")]
        [StringLength(1)]
        public string? FilterSalesmanFlag { get; set; }
        [Column("Footer Flag")]
        [StringLength(1)]
        public string? FooterFlag { get; set; }
        [Column("Group Name")]
        [StringLength(4)]
        public string? GroupName { get; set; }
        [Column("Header Flag")]
        [StringLength(1)]
        public string? HeaderFlag { get; set; }
        [Column("Job Type")]
        [StringLength(500)]
        public string? JobType { get; set; }
        [Column("Left Margin", TypeName = "decimal(13, 2)")]
        public decimal? LeftMargin { get; set; }
        [Column("Lock Copy Flag")]
        [StringLength(1)]
        public string? LockCopyFlag { get; set; }
        [Column("Lock Flag 01")]
        [StringLength(1)]
        public string? LockFlag01 { get; set; }
        [Column("Lock Flag 02")]
        [StringLength(1)]
        public string? LockFlag02 { get; set; }
        [Column("Lock Flag 03")]
        [StringLength(1)]
        public string? LockFlag03 { get; set; }
        [Column("Lock Flag 04")]
        [StringLength(1)]
        public string? LockFlag04 { get; set; }
        [Column("Lock Flag 05")]
        [StringLength(1)]
        public string? LockFlag05 { get; set; }
        [Column("Lock Flag 06")]
        [StringLength(1)]
        public string? LockFlag06 { get; set; }
        [Column("Lock Flag 07")]
        [StringLength(1)]
        public string? LockFlag07 { get; set; }
        [Column("Lock Flag 08")]
        [StringLength(1)]
        public string? LockFlag08 { get; set; }
        [Column("Lock Flag 09")]
        [StringLength(1)]
        public string? LockFlag09 { get; set; }
        [Column("Lock Flag 10")]
        [StringLength(1)]
        public string? LockFlag10 { get; set; }
        [Column("Mgmt Report Flag")]
        [StringLength(1)]
        public string? MgmtReportFlag { get; set; }
        [Column("No Of Copy")]
        public byte? NoOfCopy { get; set; }
        [Column("No Of Criteria")]
        public int? NoOfCriteria { get; set; }
        [Column("Notify NoPrint Flag")]
        [StringLength(1)]
        public string? NotifyNoPrintFlag { get; set; }
        [StringLength(50)]
        public string? Orientation { get; set; }
        [Column("Other Report Path")]
        [StringLength(255)]
        public string? OtherReportPath { get; set; }
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
        [Column("Parameter Default 01")]
        [StringLength(255)]
        public string? ParameterDefault01 { get; set; }
        [Column("Parameter Default 02")]
        [StringLength(255)]
        public string? ParameterDefault02 { get; set; }
        [Column("Parameter Default 03")]
        [StringLength(255)]
        public string? ParameterDefault03 { get; set; }
        [Column("Parameter Default 04")]
        [StringLength(255)]
        public string? ParameterDefault04 { get; set; }
        [Column("Parameter Default 05")]
        [StringLength(255)]
        public string? ParameterDefault05 { get; set; }
        [Column("Parameter Default 06")]
        [StringLength(255)]
        public string? ParameterDefault06 { get; set; }
        [Column("Parameter Default 07")]
        [StringLength(255)]
        public string? ParameterDefault07 { get; set; }
        [Column("Parameter Default 08")]
        [StringLength(255)]
        public string? ParameterDefault08 { get; set; }
        [Column("Parameter Default 09")]
        [StringLength(255)]
        public string? ParameterDefault09 { get; set; }
        [Column("Parameter Default 10")]
        [StringLength(255)]
        public string? ParameterDefault10 { get; set; }
        [Column("Parameter Name 01")]
        [StringLength(50)]
        public string? ParameterName01 { get; set; }
        [Column("Parameter Name 02")]
        [StringLength(50)]
        public string? ParameterName02 { get; set; }
        [Column("Parameter Name 03")]
        [StringLength(50)]
        public string? ParameterName03 { get; set; }
        [Column("Parameter Name 04")]
        [StringLength(50)]
        public string? ParameterName04 { get; set; }
        [Column("Parameter Name 05")]
        [StringLength(50)]
        public string? ParameterName05 { get; set; }
        [Column("Parameter Name 06")]
        [StringLength(50)]
        public string? ParameterName06 { get; set; }
        [Column("Parameter Name 07")]
        [StringLength(50)]
        public string? ParameterName07 { get; set; }
        [Column("Parameter Name 08")]
        [StringLength(50)]
        public string? ParameterName08 { get; set; }
        [Column("Parameter Name 09")]
        [StringLength(50)]
        public string? ParameterName09 { get; set; }
        [Column("Parameter Name 10")]
        [StringLength(50)]
        public string? ParameterName10 { get; set; }
        [Column("Parameter Table 01")]
        [StringLength(5)]
        public string? ParameterTable01 { get; set; }
        [Column("Parameter Table 02")]
        [StringLength(5)]
        public string? ParameterTable02 { get; set; }
        [Column("Parameter Table 03")]
        [StringLength(5)]
        public string? ParameterTable03 { get; set; }
        [Column("Parameter Table 04")]
        [StringLength(5)]
        public string? ParameterTable04 { get; set; }
        [Column("Parameter Table 05")]
        [StringLength(5)]
        public string? ParameterTable05 { get; set; }
        [Column("Parameter Table 06")]
        [StringLength(5)]
        public string? ParameterTable06 { get; set; }
        [Column("Parameter Table 07")]
        [StringLength(5)]
        public string? ParameterTable07 { get; set; }
        [Column("Parameter Table 08")]
        [StringLength(5)]
        public string? ParameterTable08 { get; set; }
        [Column("Parameter Table 09")]
        [StringLength(5)]
        public string? ParameterTable09 { get; set; }
        [Column("Parameter Table 10")]
        [StringLength(5)]
        public string? ParameterTable10 { get; set; }
        [Column("Parameter Value 01")]
        [StringLength(255)]
        public string? ParameterValue01 { get; set; }
        [Column("Parameter Value 02")]
        [StringLength(255)]
        public string? ParameterValue02 { get; set; }
        [Column("Parameter Value 03")]
        [StringLength(255)]
        public string? ParameterValue03 { get; set; }
        [Column("Parameter Value 04")]
        [StringLength(255)]
        public string? ParameterValue04 { get; set; }
        [Column("Parameter Value 05")]
        [StringLength(255)]
        public string? ParameterValue05 { get; set; }
        [Column("Parameter Value 06")]
        [StringLength(255)]
        public string? ParameterValue06 { get; set; }
        [Column("Parameter Value 07")]
        [StringLength(255)]
        public string? ParameterValue07 { get; set; }
        [Column("Parameter Value 08")]
        [StringLength(255)]
        public string? ParameterValue08 { get; set; }
        [Column("Parameter Value 09")]
        [StringLength(255)]
        public string? ParameterValue09 { get; set; }
        [Column("Parameter Value 10")]
        [StringLength(255)]
        public string? ParameterValue10 { get; set; }
        [Column("PDF Report Flag")]
        [StringLength(1)]
        public string? PdfReportFlag { get; set; }
        [Column("Print Count")]
        public int? PrintCount { get; set; }
        [Column("Print Count Flag")]
        [StringLength(1)]
        public string? PrintCountFlag { get; set; }
        [Column("Print Type Flag")]
        [StringLength(1)]
        public string? PrintTypeFlag { get; set; }
        [Column("Printer Name")]
        [StringLength(50)]
        public string? PrinterName { get; set; }
        [Column("Prompt Selection Flag")]
        [StringLength(1)]
        public string? PromptSelectionFlag { get; set; }
        [Column("Quality Flag")]
        [StringLength(1)]
        public string? QualityFlag { get; set; }
        [Column("Report Name")]
        [StringLength(50)]
        public string? ReportName { get; set; }
        [Column("Report Name 1")]
        [StringLength(50)]
        public string? ReportName1 { get; set; }
        [Column("Report Name 2")]
        [StringLength(50)]
        public string? ReportName2 { get; set; }
        [Column("Report Print Count Flag")]
        [StringLength(1)]
        public string? ReportPrintCountFlag { get; set; }
        [Column("Right Margin", TypeName = "decimal(13, 2)")]
        public decimal? RightMargin { get; set; }
        [Column("Selection Flag")]
        [StringLength(1)]
        public string? SelectionFlag { get; set; }
        [Column("Seq No")]
        public byte? SeqNo { get; set; }
        [Column("Shipment Type")]
        [StringLength(20)]
        public string? ShipmentType { get; set; }
        [Column("Show Enquiry Flag")]
        [StringLength(1)]
        public string? ShowEnquiryFlag { get; set; }
        [Column("Special Function")]
        [StringLength(50)]
        public string? SpecialFunction { get; set; }
        [Column("Str Key")]
        [StringLength(50)]
        public string? StrKey { get; set; }
        [Column("Subject Format")]
        [StringLength(80)]
        public string? SubjectFormat { get; set; }
        [Column("Subreport Flag")]
        [StringLength(1)]
        public string? SubreportFlag { get; set; }
        [Column("Sub Seq No")]
        [StringLength(2)]
        public string? SubSeqNo { get; set; }
        [Column("Top Margin", TypeName = "decimal(13, 2)")]
        public decimal? TopMargin { get; set; }
        [Column("Update Status Code")]
        [StringLength(50)]
        public string? UpdateStatusCode { get; set; }
        [Column("Use Flag")]
        [StringLength(1)]
        public string? UseFlag { get; set; }
        [Column("User ID")]
        [StringLength(1000)]
        public string? UserId { get; set; }
        [Column("User Role")]
        [StringLength(500)]
        public string? UserRole { get; set; }
        [Column("View Name")]
        [StringLength(20)]
        public string? ViewName { get; set; }
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
