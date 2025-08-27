using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("saus1")]
    [Index("UserName", Name = "INDEX_Saus1_UserName")]
    [Index("UserId", Name = "saus1_x", IsUnique = true)]
    public partial class Saus1
    {
        public Saus1()
        {
            WrAppointments = new HashSet<WrAppointment>();
        }

        [Key]
        [Column("UserID")]
        [StringLength(20)]
        public string UserId { get; set; } = null!;
        [StringLength(1)]
        public string? AccessAllUserDocFlag { get; set; }
        [StringLength(1)]
        public string? AccessRight { get; set; }
        [StringLength(20)]
        public string? ActiveFormColor { get; set; }
        [Column("ActiveFormColorARGB")]
        [StringLength(200)]
        public string? ActiveFormColorArgb { get; set; }
        [StringLength(1)]
        public string? AddressBook { get; set; }
        [StringLength(1)]
        public string? AlertFormType { get; set; }
        [StringLength(1)]
        public string? AnnouncementFlag { get; set; }
        [StringLength(1)]
        public string? ApproveAdhocRate { get; set; }
        [StringLength(1)]
        public string? ApproveInvoice { get; set; }
        [StringLength(1)]
        public string? ApproveJob { get; set; }
        [StringLength(1)]
        public string? ApproveJobCosting { get; set; }
        [StringLength(1)]
        public string? ApproveJournalVoucher { get; set; }
        [StringLength(1)]
        public string? ApprovePaymentVoucher { get; set; }
        [StringLength(1)]
        public string? ApproveQuotation { get; set; }
        [StringLength(1)]
        public string? ApproveVendorPayment { get; set; }
        [StringLength(1)]
        public string? AutoWildCardSearchFlag { get; set; }
        [StringLength(50)]
        public string? BccEmail { get; set; }
        [StringLength(1)]
        public string? BlockUserFlag { get; set; }
        [StringLength(1000)]
        public string? BusinessPartyFilter { get; set; }
        [StringLength(1)]
        public string? BusinessPartyFilterSalesmanFlag { get; set; }
        [StringLength(1)]
        public string? ClearInvoiceNoFlag { get; set; }
        [StringLength(1)]
        public string? ClientSet { get; set; }
        [StringLength(1)]
        public string? CloseConsol { get; set; }
        [StringLength(1)]
        public string? CloseJob { get; set; }
        [StringLength(1)]
        public string? CrystalReportExportFlag { get; set; }
        [StringLength(1)]
        public string? CustomiseMenuFlag { get; set; }
        [StringLength(10)]
        public string? DateFormat { get; set; }
        public int? DefaultMenuListWidth { get; set; }
        public int? DefaultSelectTopRecord { get; set; }
        [StringLength(1)]
        public string? DeleteAttachmentFlag { get; set; }
        [StringLength(10)]
        public string? DivisionCode { get; set; }
        [StringLength(1)]
        public string? EditInvoiceNoFlag { get; set; }
        [StringLength(20)]
        public string? EmailPassword { get; set; }
        [StringLength(20)]
        public string? ExportConfig { get; set; }
        [StringLength(1)]
        public string? ExportToWorkSheetFlag { get; set; }
        [StringLength(50)]
        public string? ExplorerIni { get; set; }
        [StringLength(1)]
        public string? FilterSalesmanFlag { get; set; }
        [StringLength(1)]
        public string? Gljv1PostFlag { get; set; }
        [StringLength(1)]
        public string? Gljv1UnpostFlag { get; set; }
        [StringLength(30)]
        public string? Handphone { get; set; }
        [StringLength(1)]
        public string? HideChangePasswordFlag { get; set; }
        [StringLength(1)]
        public string? HideCostFlag { get; set; }
        [StringLength(1)]
        public string? HideMidGridFlag { get; set; }
        [StringLength(1)]
        public string? HidePrinterSetup { get; set; }
        [StringLength(1)]
        public string? HideSalesFlag { get; set; }
        public int? HomeLeftHeight { get; set; }
        public int? HomeLeftWidth { get; set; }
        [StringLength(1)]
        public string? HomePageMemoMinimumFlag { get; set; }
        [StringLength(1)]
        public string? HomePageReminderMinimumFlag { get; set; }
        [StringLength(1)]
        public string? HomePageStatisticsMinimumFlag { get; set; }
        [StringLength(1)]
        public string? HomePageVerificationMinimumFlag { get; set; }
        public int? HomeRightHeight { get; set; }
        [StringLength(20)]
        public string? ImportConfig { get; set; }
        public bool? IsAccountLocked { get; set; }
        public bool? IsAdministrator { get; set; }
        [StringLength(1)]
        public string? Ivcr1PostFlag { get; set; }
        [StringLength(1)]
        public string? Ivcr1UnpostFlag { get; set; }
        [StringLength(50)]
        public string? JobTitle { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? JoinDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastLoginDate { get; set; }
        [StringLength(50)]
        public string? LookForSearchText { get; set; }
        [StringLength(50)]
        public string? MacAddress1 { get; set; }
        [StringLength(50)]
        public string? MacAddress2 { get; set; }
        [StringLength(4000)]
        public string? Memo { get; set; }
        [StringLength(1)]
        public string? MenuCustomiseFlag { get; set; }
        [StringLength(1)]
        public string? MenuExpandFlag { get; set; }
        [StringLength(1)]
        public string? MessageFlag { get; set; }
        public int? MsgReminderTime { get; set; }
        [StringLength(1)]
        public string? MultiDatabase { get; set; }
        [StringLength(1)]
        public string? MultipleLoginFlag { get; set; }
        [StringLength(1)]
        public string? MultiWebSite { get; set; }
        [StringLength(1)]
        public string? MyFavoriteFlag { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NextPasswordResetDate { get; set; }
        [StringLength(1)]
        public string? NoOfFilter { get; set; }
        public int? NoOfTabOpen { get; set; }
        [StringLength(255)]
        public string? Note { get; set; }
        [StringLength(1)]
        public string? OpenConsol { get; set; }
        [StringLength(1)]
        public string? OpenJob { get; set; }
        [StringLength(1)]
        public string? OutlookFlag { get; set; }
        [StringLength(50)]
        public string? Password { get; set; }
        [StringLength(1)]
        public string? Plpm1PostFlag { get; set; }
        [StringLength(1)]
        public string? Plpm1UnpostFlag { get; set; }
        [StringLength(1)]
        public string? Plvi1PostFlag { get; set; }
        [StringLength(1)]
        public string? Plvi1UnpostFlag { get; set; }
        [StringLength(1)]
        public string? PrintPreviewTab { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(1)]
        public string? ReminderTime { get; set; }
        [StringLength(1)]
        public string? RemoteAccessFlag { get; set; }
        public short? ResetPasswordDay { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ResignDate { get; set; }
        public int RoleId { get; set; }
        [StringLength(100)]
        public string? SalesmanCode { get; set; }
        [StringLength(1)]
        public string? SetAsDefaultRightFlag { get; set; }
        [StringLength(1)]
        public string? ShowGridLineFlag { get; set; }
        [StringLength(1)]
        public string? ShowHomeScreenFlag { get; set; }
        [Column(TypeName = "image")]
        public byte[]? SignatureImage { get; set; }
        [StringLength(20)]
        public string? SiteCode { get; set; }
        [StringLength(1)]
        public string? Slcr1PostFlag { get; set; }
        [StringLength(1)]
        public string? Slcr1UnpostFlag { get; set; }
        [StringLength(1)]
        public string? Style { get; set; }
        [StringLength(1)]
        public string? SysAcctFlag { get; set; }
        [StringLength(1)]
        public string? SysAirFlag { get; set; }
        [StringLength(1)]
        public string? SysSeaFlag { get; set; }
        [StringLength(1)]
        public string? SysTrackFlag { get; set; }
        [StringLength(1)]
        public string? SysTranFlag { get; set; }
        [StringLength(1)]
        public string? SysWhFlag { get; set; }
        [StringLength(50)]
        public string? Telephone { get; set; }
        [StringLength(50)]
        public string? Title { get; set; }
        [Column("TradenetID")]
        [StringLength(20)]
        public string? TradenetId { get; set; }
        [StringLength(50)]
        public string? TradenetPassword { get; set; }
        [StringLength(1)]
        public string? UnapproveInvoice { get; set; }
        [StringLength(1)]
        public string? UnapproveJob { get; set; }
        [StringLength(1)]
        public string? UnapproveJobCosting { get; set; }
        [StringLength(1)]
        public string? UnpostFlag { get; set; }
        [StringLength(1)]
        public string? UpdateDllFlag { get; set; }
        [StringLength(1)]
        public string? UpdateOtherOfficeFlag { get; set; }
        [StringLength(60)]
        public string? UseLanguage { get; set; }
        [StringLength(50)]
        public string? UserEmail { get; set; }
        [StringLength(50)]
        public string? UserFullName { get; set; }
        [StringLength(10)]
        public string? UserGroup { get; set; }
        [Column(TypeName = "image")]
        public byte[]? UserImage { get; set; }
        [StringLength(50)]
        public string? UserName { get; set; }
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

        [InverseProperty("User")]
        public virtual ICollection<WrAppointment> WrAppointments { get; set; }
    }
}
