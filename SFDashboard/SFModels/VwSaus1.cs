using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSaus1
    {
        [Column("User ID")]
        [StringLength(20)]
        public string UserId { get; set; } = null!;
        [Column("Access All User Doc Flag")]
        [StringLength(1)]
        public string? AccessAllUserDocFlag { get; set; }
        [Column("Access Right")]
        [StringLength(1)]
        public string? AccessRight { get; set; }
        [Column("Active Form Color")]
        [StringLength(20)]
        public string? ActiveFormColor { get; set; }
        [Column("Active Form Color ARGB")]
        [StringLength(200)]
        public string? ActiveFormColorArgb { get; set; }
        [Column("Address Book")]
        [StringLength(1)]
        public string? AddressBook { get; set; }
        [Column("Alert Form Type")]
        [StringLength(1)]
        public string? AlertFormType { get; set; }
        [Column("Announcement Flag")]
        [StringLength(1)]
        public string? AnnouncementFlag { get; set; }
        [Column("Approve Adhoc Rate")]
        [StringLength(1)]
        public string? ApproveAdhocRate { get; set; }
        [Column("Approve Invoice")]
        [StringLength(1)]
        public string? ApproveInvoice { get; set; }
        [Column("Approve Job")]
        [StringLength(1)]
        public string? ApproveJob { get; set; }
        [Column("Approve Job Costing")]
        [StringLength(1)]
        public string? ApproveJobCosting { get; set; }
        [Column("Approve Journal Voucher")]
        [StringLength(1)]
        public string? ApproveJournalVoucher { get; set; }
        [Column("Approve Payment Voucher")]
        [StringLength(1)]
        public string? ApprovePaymentVoucher { get; set; }
        [Column("Approve Quotation")]
        [StringLength(1)]
        public string? ApproveQuotation { get; set; }
        [Column("Approve Vendor Payment")]
        [StringLength(1)]
        public string? ApproveVendorPayment { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Auto Wild Card Search Flag")]
        [StringLength(1)]
        public string? AutoWildCardSearchFlag { get; set; }
        [Column("BCC Email")]
        [StringLength(50)]
        public string? BccEmail { get; set; }
        [Column("Block User Flag")]
        [StringLength(1)]
        public string? BlockUserFlag { get; set; }
        [Column("Business Party Filter")]
        [StringLength(1000)]
        public string? BusinessPartyFilter { get; set; }
        [Column("Business Party Filter Salesman Flag")]
        [StringLength(1)]
        public string? BusinessPartyFilterSalesmanFlag { get; set; }
        [Column("Clear Invoice No Flag")]
        [StringLength(1)]
        public string? ClearInvoiceNoFlag { get; set; }
        [Column("Client Set")]
        [StringLength(1)]
        public string? ClientSet { get; set; }
        [Column("Close Consol")]
        [StringLength(1)]
        public string? CloseConsol { get; set; }
        [Column("Close Job")]
        [StringLength(1)]
        public string? CloseJob { get; set; }
        [Column("Crystal Report Export Flag")]
        [StringLength(1)]
        public string? CrystalReportExportFlag { get; set; }
        [Column("Customise Menu Flag")]
        [StringLength(1)]
        public string? CustomiseMenuFlag { get; set; }
        [Column("Date Format")]
        [StringLength(10)]
        public string? DateFormat { get; set; }
        [Column("Default Menu List Width")]
        public int? DefaultMenuListWidth { get; set; }
        [Column("Default Select Top Record")]
        public int? DefaultSelectTopRecord { get; set; }
        [Column("Delete Attachment Flag")]
        [StringLength(1)]
        public string? DeleteAttachmentFlag { get; set; }
        [Column("Division Code")]
        [StringLength(10)]
        public string? DivisionCode { get; set; }
        [Column("Edit Invoice No Flag")]
        [StringLength(1)]
        public string? EditInvoiceNoFlag { get; set; }
        [Column("Email Password")]
        [StringLength(20)]
        public string? EmailPassword { get; set; }
        [Column("Export Config")]
        [StringLength(20)]
        public string? ExportConfig { get; set; }
        [Column("Export To Work Sheet Flag")]
        [StringLength(1)]
        public string? ExportToWorkSheetFlag { get; set; }
        [Column("Explorer Ini")]
        [StringLength(50)]
        public string? ExplorerIni { get; set; }
        [Column("Filter Salesman Flag")]
        [StringLength(1)]
        public string? FilterSalesmanFlag { get; set; }
        [Column("Gljv1 Post Flag")]
        [StringLength(1)]
        public string? Gljv1PostFlag { get; set; }
        [Column("Gljv1 UnPost Flag")]
        [StringLength(1)]
        public string? Gljv1UnPostFlag { get; set; }
        [StringLength(30)]
        public string? Handphone { get; set; }
        [Column("Hide Change Password Flag")]
        [StringLength(1)]
        public string? HideChangePasswordFlag { get; set; }
        [Column("Hide Cost Flag")]
        [StringLength(1)]
        public string? HideCostFlag { get; set; }
        [Column("Hide Mid Grid Flag")]
        [StringLength(1)]
        public string? HideMidGridFlag { get; set; }
        [Column("Hide Printer Setup")]
        [StringLength(1)]
        public string? HidePrinterSetup { get; set; }
        [Column("Hide Sales Flag")]
        [StringLength(1)]
        public string? HideSalesFlag { get; set; }
        [Column("Home Left Height")]
        public int? HomeLeftHeight { get; set; }
        [Column("Home Left Width")]
        public int? HomeLeftWidth { get; set; }
        [Column("Home Page Memo Minimum Flag")]
        [StringLength(1)]
        public string? HomePageMemoMinimumFlag { get; set; }
        [Column("Home Page Reminder Minimum Flag")]
        [StringLength(1)]
        public string? HomePageReminderMinimumFlag { get; set; }
        [Column("Home Page Statistics Minimum Flag")]
        [StringLength(1)]
        public string? HomePageStatisticsMinimumFlag { get; set; }
        [Column("Home Page Verification Minimum Flag")]
        [StringLength(1)]
        public string? HomePageVerificationMinimumFlag { get; set; }
        [Column("Home Right Height")]
        public int? HomeRightHeight { get; set; }
        [Column("Import Config")]
        [StringLength(20)]
        public string? ImportConfig { get; set; }
        [Column("Is Account Locked")]
        public bool? IsAccountLocked { get; set; }
        [Column("Is Administrator")]
        public bool? IsAdministrator { get; set; }
        [Column("Ivcr1 Post Flag")]
        [StringLength(1)]
        public string? Ivcr1PostFlag { get; set; }
        [Column("Ivcr1 Unpost Flag")]
        [StringLength(1)]
        public string? Ivcr1UnpostFlag { get; set; }
        [Column("Job Title")]
        [StringLength(50)]
        public string? JobTitle { get; set; }
        [Column("Join Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? JoinDate { get; set; }
        [Column("Last Login Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastLoginDate { get; set; }
        [Column("Look For Search Text")]
        [StringLength(50)]
        public string? LookForSearchText { get; set; }
        [Column("Mac Address 1")]
        [StringLength(50)]
        public string? MacAddress1 { get; set; }
        [Column("Mac Address 2")]
        [StringLength(50)]
        public string? MacAddress2 { get; set; }
        [StringLength(4000)]
        public string? Memo { get; set; }
        [Column("Menu Customise Flag")]
        [StringLength(1)]
        public string? MenuCustomiseFlag { get; set; }
        [Column("Menu Expand Flag")]
        [StringLength(1)]
        public string? MenuExpandFlag { get; set; }
        [Column("Message Flag")]
        [StringLength(1)]
        public string? MessageFlag { get; set; }
        [Column("Message Reminder Time")]
        public int? MessageReminderTime { get; set; }
        [Column("Multiple Data Base")]
        [StringLength(1)]
        public string? MultipleDataBase { get; set; }
        [Column("Multiple Login Flag")]
        [StringLength(1)]
        public string? MultipleLoginFlag { get; set; }
        [Column("Multiple Web Site")]
        [StringLength(1)]
        public string? MultipleWebSite { get; set; }
        [Column("My Favorite Flag")]
        [StringLength(1)]
        public string? MyFavoriteFlag { get; set; }
        [Column("Next Password Reset Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? NextPasswordResetDate { get; set; }
        [Column("No Of Filter")]
        [StringLength(1)]
        public string? NoOfFilter { get; set; }
        [Column("No Of Tab Open")]
        public int? NoOfTabOpen { get; set; }
        [StringLength(255)]
        public string? Note { get; set; }
        [Column("Open Consol")]
        [StringLength(1)]
        public string? OpenConsol { get; set; }
        [Column("Open Job")]
        [StringLength(1)]
        public string? OpenJob { get; set; }
        [Column("Outlook Flag")]
        [StringLength(1)]
        public string? OutlookFlag { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string Password { get; set; } = null!;
        [Column("Plpm1 Post Flag")]
        [StringLength(1)]
        public string? Plpm1PostFlag { get; set; }
        [Column("Plpm1 Unpost Flag")]
        [StringLength(1)]
        public string? Plpm1UnpostFlag { get; set; }
        [Column("Plvi1 Post Flag")]
        [StringLength(1)]
        public string? Plvi1PostFlag { get; set; }
        [Column("Plvi1 Unpost Flag")]
        [StringLength(1)]
        public string? Plvi1UnpostFlag { get; set; }
        [Column("Print Preview Tab")]
        [StringLength(1)]
        public string? PrintPreviewTab { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Reminder Time")]
        [StringLength(1)]
        public string? ReminderTime { get; set; }
        [Column("Remote Access Flag")]
        [StringLength(1)]
        public string? RemoteAccessFlag { get; set; }
        [Column("Reset Password Day")]
        public short? ResetPasswordDay { get; set; }
        [Column("Resign Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ResignDate { get; set; }
        [Column("Role ID")]
        public int RoleId { get; set; }
        [Column("Role Name")]
        [StringLength(30)]
        public string? RoleName { get; set; }
        [Column("Salesman Code")]
        [StringLength(100)]
        public string? SalesmanCode { get; set; }
        [Column("Set As Default Right Flag")]
        [StringLength(1)]
        public string? SetAsDefaultRightFlag { get; set; }
        [Column("Show Grid Line Flag")]
        [StringLength(1)]
        public string? ShowGridLineFlag { get; set; }
        [Column("Show Home Screen Flag")]
        [StringLength(1)]
        public string? ShowHomeScreenFlag { get; set; }
        [Column("Signature Image", TypeName = "image")]
        public byte[]? SignatureImage { get; set; }
        [Column("Site Code")]
        [StringLength(20)]
        public string? SiteCode { get; set; }
        [Column("Slcr1 Post Flag")]
        [StringLength(1)]
        public string? Slcr1PostFlag { get; set; }
        [Column("Slcr1 Unpost Flag")]
        [StringLength(1)]
        public string? Slcr1UnpostFlag { get; set; }
        [StringLength(1)]
        public string? Style { get; set; }
        [Column("Sys Acct Flag")]
        [StringLength(1)]
        public string? SysAcctFlag { get; set; }
        [Column("Sys Air Flag")]
        [StringLength(1)]
        public string? SysAirFlag { get; set; }
        [Column("Sys Sea Flag")]
        [StringLength(1)]
        public string? SysSeaFlag { get; set; }
        [Column("Sys Track Flag")]
        [StringLength(1)]
        public string? SysTrackFlag { get; set; }
        [Column("Sys Tran Flag")]
        [StringLength(1)]
        public string? SysTranFlag { get; set; }
        [Column("Sys Wh Flag")]
        [StringLength(1)]
        public string? SysWhFlag { get; set; }
        [StringLength(50)]
        public string? Telephone { get; set; }
        [StringLength(50)]
        public string? Title { get; set; }
        [Column("Tradenet ID")]
        [StringLength(20)]
        public string? TradenetId { get; set; }
        [Column("Tradenet Password")]
        [StringLength(50)]
        public string? TradenetPassword { get; set; }
        [Column("Unapprove Invoice")]
        [StringLength(1)]
        public string? UnapproveInvoice { get; set; }
        [Column("Unapprove Job")]
        [StringLength(1)]
        public string? UnapproveJob { get; set; }
        [Column("Unapprove Job Costing")]
        [StringLength(1)]
        public string? UnapproveJobCosting { get; set; }
        [Column("Unpost Flag")]
        [StringLength(1)]
        public string? UnpostFlag { get; set; }
        [Column("Update Dll Flag")]
        [StringLength(1)]
        public string? UpdateDllFlag { get; set; }
        [Column("Update Other Office Flag")]
        [StringLength(1)]
        public string? UpdateOtherOfficeFlag { get; set; }
        [Column("Use Language")]
        [StringLength(60)]
        public string? UseLanguage { get; set; }
        [Column("User Email")]
        [StringLength(50)]
        public string? UserEmail { get; set; }
        [Column("User Full Name")]
        [StringLength(50)]
        public string? UserFullName { get; set; }
        [Column("User Group")]
        [StringLength(10)]
        public string? UserGroup { get; set; }
        [Column("User Image", TypeName = "image")]
        public byte[]? UserImage { get; set; }
        [Column("User Name")]
        [StringLength(50)]
        public string? UserName { get; set; }
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
