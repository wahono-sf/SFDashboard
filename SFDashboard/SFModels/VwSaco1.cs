using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSaco1
    {
        [Column("Company Code")]
        [StringLength(5)]
        public string CompanyCode { get; set; } = null!;
        [Column("Acc Post Program")]
        [StringLength(1)]
        public string? AccPostProgram { get; set; }
        [Column("Address 1")]
        [StringLength(100)]
        public string? Address1 { get; set; }
        [Column("Address 2")]
        [StringLength(100)]
        public string? Address2 { get; set; }
        [Column("Address 3")]
        [StringLength(100)]
        public string? Address3 { get; set; }
        [Column("Address 4")]
        [StringLength(100)]
        public string? Address4 { get; set; }
        [Column("Air Address 1")]
        [StringLength(100)]
        public string? AirAddress1 { get; set; }
        [Column("Air Address 2")]
        [StringLength(100)]
        public string? AirAddress2 { get; set; }
        [Column("Air Address 3")]
        [StringLength(100)]
        public string? AirAddress3 { get; set; }
        [Column("Air Address 4")]
        [StringLength(100)]
        public string? AirAddress4 { get; set; }
        [Column("Air City Code")]
        [StringLength(3)]
        public string? AirCityCode { get; set; }
        [Column("Air City Name")]
        [StringLength(45)]
        public string? AirCityName { get; set; }
        [Column("Air Country Code")]
        [StringLength(2)]
        public string? AirCountryCode { get; set; }
        [Column("Air Contact Name")]
        [StringLength(50)]
        public string? AirContactName { get; set; }
        [Column("Air Email")]
        [StringLength(50)]
        public string? AirEmail { get; set; }
        [Column("Air Fax")]
        [StringLength(30)]
        public string? AirFax { get; set; }
        [Column("Air Postal Code")]
        [StringLength(10)]
        public string? AirPostalCode { get; set; }
        [Column("Air Telephone")]
        [StringLength(30)]
        public string? AirTelephone { get; set; }
        [Column("Alert Flag")]
        [StringLength(1)]
        public string? AlertFlag { get; set; }
        [StringLength(2000)]
        public string? Announcement { get; set; }
        [Column("Archive Database Flag")]
        [StringLength(1)]
        public string? ArchiveDatabaseFlag { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Attachment Limit")]
        public int? AttachmentLimit { get; set; }
        [Column("Audit Log Database")]
        [StringLength(50)]
        public string? AuditLogDatabase { get; set; }
        [Column("Audit Log Flag")]
        [StringLength(1)]
        public string? AuditLogFlag { get; set; }
        [Column("Auto Generate Flag")]
        [StringLength(1)]
        public string? AutoGenerateFlag { get; set; }
        [Column("Auto Search By Name")]
        [StringLength(255)]
        public string? AutoSearchByName { get; set; }
        [Column("Backup Path")]
        [StringLength(50)]
        public string? BackupPath { get; set; }
        [Column("Blue Name")]
        [StringLength(50)]
        public string? BlueName { get; set; }
        [Column("Branch Code Flag")]
        [StringLength(1)]
        public string? BranchCodeFlag { get; set; }
        [Column("Branch Name")]
        [StringLength(80)]
        public string? BranchName { get; set; }
        [Column("Business Party Code")]
        [StringLength(10)]
        public string? BusinessPartyCode { get; set; }
        [Column("Business Party Format")]
        [StringLength(20)]
        public string? BusinessPartyFormat { get; set; }
        [Column("Cargo Commodity Flag")]
        [StringLength(1)]
        public string? CargoCommodityFlag { get; set; }
        [Column("CFS Site")]
        [StringLength(255)]
        public string? CfsSite { get; set; }
        [Column("Check Licence By User Flag")]
        [StringLength(1)]
        public string? CheckLicenceByUserFlag { get; set; }
        [Column("Check Password History Flag")]
        [StringLength(1)]
        public string? CheckPasswordHistoryFlag { get; set; }
        [Column("Check Project Web Site")]
        [StringLength(200)]
        public string? CheckProjectWebSite { get; set; }
        [Column("City Code")]
        [StringLength(3)]
        public string? CityCode { get; set; }
        [Column("City Name")]
        [StringLength(45)]
        public string? CityName { get; set; }
        [Column("Color Code")]
        [StringLength(50)]
        public string? ColorCode { get; set; }
        [Column("Combine Database Flag")]
        [StringLength(1)]
        public string? CombineDatabaseFlag { get; set; }
        [Column("Common Database")]
        [StringLength(20)]
        public string? CommonDatabase { get; set; }
        [Column("Company Name")]
        [StringLength(100)]
        public string? CompanyName { get; set; }
        [Column("Contact Name")]
        [StringLength(50)]
        public string? ContactName { get; set; }
        [Column("Container Tracking Flag")]
        [StringLength(1)]
        public string? ContainerTrackingFlag { get; set; }
        [Column("Cosac Agent Code")]
        [StringLength(10)]
        public string? CosacAgentCode { get; set; }
        [Column("Country Code")]
        [StringLength(2)]
        public string? CountryCode { get; set; }
        [Column("Cr No Name")]
        [StringLength(50)]
        public string? CrNoName { get; set; }
        [Column("Currency Code")]
        [StringLength(3)]
        public string? CurrencyCode { get; set; }
        [Column("Delivery Agent Party Type")]
        [StringLength(3)]
        public string? DeliveryAgentPartyType { get; set; }
        [Column("Department Code Flag")]
        [StringLength(1)]
        public string? DepartmentCodeFlag { get; set; }
        [Column("Doc Attachment Flag")]
        [StringLength(1)]
        public string? DocAttachmentFlag { get; set; }
        [Column("Document Footer 1")]
        [StringLength(255)]
        public string? DocumentFooter1 { get; set; }
        [Column("Document Footer 2")]
        [StringLength(255)]
        public string? DocumentFooter2 { get; set; }
        [Column("Document Local Path Flag")]
        [StringLength(1)]
        public string? DocumentLocalPathFlag { get; set; }
        [Column("Document Path")]
        [StringLength(255)]
        public string? DocumentPath { get; set; }
        [Column("Dot Net User Licence Key")]
        [StringLength(10)]
        [Unicode(false)]
        public string DotNetUserLicenceKey { get; set; } = null!;
        [Column("EDI Number")]
        [StringLength(35)]
        public string? EdiNumber { get; set; }
        [Column("EDI Recipient ID")]
        [StringLength(35)]
        public string? EdiRecipientId { get; set; }
        [Column("e Document Path")]
        [StringLength(255)]
        public string? EDocumentPath { get; set; }
        [Column("Effective Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? EffectiveDate { get; set; }
        [Column("EInvoice Key")]
        [StringLength(50)]
        public string? EinvoiceKey { get; set; }
        [StringLength(50)]
        public string? Email { get; set; }
        [Column("eTrack Address")]
        [StringLength(80)]
        public string? ETrackAddress { get; set; }
        [Column("Expiry Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ExpiryDate { get; set; }
        [StringLength(30)]
        public string? Fax { get; set; }
        [Column("Font Bold")]
        [StringLength(1)]
        public string? FontBold { get; set; }
        [Column("Font Size", TypeName = "decimal(5, 1)")]
        public decimal? FontSize { get; set; }
        [Column("Freight Database")]
        [StringLength(20)]
        public string? FreightDatabase { get; set; }
        [Column("FWB Envelope Line 1")]
        [StringLength(50)]
        public string? FwbEnvelopeLine1 { get; set; }
        [Column("FWB Envelope Line 2")]
        [StringLength(50)]
        public string? FwbEnvelopeLine2 { get; set; }
        [Column("FWB Message Envelope")]
        [StringLength(50)]
        public string? FwbMessageEnvelope { get; set; }
        [Column("FWB Message Flag")]
        [StringLength(1)]
        public string? FwbMessageFlag { get; set; }
        [Column("Green Name")]
        [StringLength(50)]
        public string? GreenName { get; set; }
        [Column("Grid Font Size", TypeName = "decimal(5, 1)")]
        public decimal? GridFontSize { get; set; }
        [Column("Hide Sub Master Flag")]
        [StringLength(1)]
        public string? HideSubMasterFlag { get; set; }
        [Column("IAF Path")]
        [StringLength(255)]
        public string? IafPath { get; set; }
        [Column("IAF Version No")]
        [StringLength(50)]
        public string? IafVersionNo { get; set; }
        [Column("Iata Agent Code")]
        [StringLength(16)]
        public string? IataAgentCode { get; set; }
        [Column("Item Code Length")]
        public int? ItemCodeLength { get; set; }
        [Column("Lock Acc Code Flag")]
        [StringLength(1)]
        public string? LockAccCodeFlag { get; set; }
        [Column("Lock Business Party Flag")]
        [StringLength(1)]
        public string? LockBusinessPartyFlag { get; set; }
        [Column("Lock Business Party Info Flag")]
        [StringLength(1)]
        public string? LockBusinessPartyInfoFlag { get; set; }
        [Column("Lock Record Open Form Flag")]
        [StringLength(1)]
        public string? LockRecordOpenFormFlag { get; set; }
        [Column("Lock Reference Flag")]
        [StringLength(1)]
        public string? LockReferenceFlag { get; set; }
        [Column("Login Message")]
        [StringLength(255)]
        public string? LoginMessage { get; set; }
        [Column("Logo Image", TypeName = "image")]
        public byte[]? LogoImage { get; set; }
        [Column("Long Vessel Code Flag")]
        [StringLength(1)]
        public string? LongVesselCodeFlag { get; set; }
        [Column("Mobile App Address")]
        [StringLength(80)]
        public string? MobileAppAddress { get; set; }
        [Column("Multiple Database Name")]
        [StringLength(255)]
        public string? MultipleDatabaseName { get; set; }
        [Column("Next Batch No")]
        [StringLength(10)]
        public string? NextBatchNo { get; set; }
        [Column("Next Business Party No")]
        [StringLength(10)]
        public string? NextBusinessPartyNo { get; set; }
        [Column("No Of Fail Login")]
        public int? NoOfFailLogin { get; set; }
        [Column("No Of Tab Open")]
        public int? NoOfTabOpen { get; set; }
        [Column("Notify Bcc Email Address")]
        [StringLength(200)]
        public string? NotifyBccEmailAddress { get; set; }
        [Column("Notify Cc Email Address")]
        [StringLength(200)]
        public string? NotifyCcEmailAddress { get; set; }
        [Column("Office Airport Code")]
        [StringLength(3)]
        public string? OfficeAirportCode { get; set; }
        [Column("Office Function Designation")]
        [StringLength(2)]
        public string? OfficeFunctionDesignation { get; set; }
        [Column("Office Designator")]
        [StringLength(2)]
        public string? OfficeDesignator { get; set; }
        [Column("Orange Name")]
        [StringLength(50)]
        public string? OrangeName { get; set; }
        [Column("Postal Code")]
        [StringLength(10)]
        public string? PostalCode { get; set; }
        [Column("Posting Log Path")]
        [StringLength(255)]
        public string? PostingLogPath { get; set; }
        [Column("Print Crystal Tray Flag")]
        [StringLength(1)]
        public string? PrintCrystalTrayFlag { get; set; }
        [Column("Purple Name")]
        [StringLength(50)]
        public string? PurpleName { get; set; }
        [Column("Quotation Check Flag")]
        [StringLength(1)]
        public string? QuotationCheckFlag { get; set; }
        [Column("Read Only Flag")]
        [StringLength(1)]
        public string? ReadOnlyFlag { get; set; }
        [Column("Red Name")]
        [StringLength(50)]
        public string? RedName { get; set; }
        [Column("Registration No")]
        [StringLength(20)]
        public string? RegistrationNo { get; set; }
        [Column("Rename English Label Flag")]
        [StringLength(1)]
        public string? RenameEnglishLabelFlag { get; set; }
        [Column("Report Local Path Flag")]
        [StringLength(1)]
        public string? ReportLocalPathFlag { get; set; }
        [Column("Report Path")]
        [StringLength(255)]
        public string? ReportPath { get; set; }
        [Column("Report Remote Path")]
        [StringLength(255)]
        public string? ReportRemotePath { get; set; }
        [Column("Salesman Code Access Right")]
        [StringLength(1)]
        public string? SalesmanCodeAccessRight { get; set; }
        [Column("Sea Address 1")]
        [StringLength(100)]
        public string? SeaAddress1 { get; set; }
        [Column("Sea Address 2")]
        [StringLength(100)]
        public string? SeaAddress2 { get; set; }
        [Column("Sea Address 3")]
        [StringLength(100)]
        public string? SeaAddress3 { get; set; }
        [Column("Sea Address 4")]
        [StringLength(100)]
        public string? SeaAddress4 { get; set; }
        [Column("Sea City Code")]
        [StringLength(3)]
        public string? SeaCityCode { get; set; }
        [Column("Sea City Name")]
        [StringLength(45)]
        public string? SeaCityName { get; set; }
        [Column("Sea Country Code")]
        [StringLength(2)]
        public string? SeaCountryCode { get; set; }
        [Column("Sea Contact Name")]
        [StringLength(50)]
        public string? SeaContactName { get; set; }
        [Column("Sea Email")]
        [StringLength(50)]
        public string? SeaEmail { get; set; }
        [Column("Sea Fax")]
        [StringLength(30)]
        public string? SeaFax { get; set; }
        [Column("Sea Postal Code")]
        [StringLength(10)]
        public string? SeaPostalCode { get; set; }
        [Column("Sea Telephone")]
        [StringLength(30)]
        public string? SeaTelephone { get; set; }
        [Column("Sender Airport Code")]
        [StringLength(3)]
        public string? SenderAirportCode { get; set; }
        [Column("Sender File Reference")]
        [StringLength(15)]
        public string? SenderFileReference { get; set; }
        [Column("Sender Participant Code")]
        [StringLength(17)]
        public string? SenderParticipantCode { get; set; }
        [Column("Sender Participant ID")]
        [StringLength(3)]
        public string? SenderParticipantId { get; set; }
        [Column("Server Login ID")]
        [StringLength(50)]
        public string? ServerLoginId { get; set; }
        [Column("Server Password")]
        [StringLength(50)]
        public string? ServerPassword { get; set; }
        [Column("Server Path")]
        [StringLength(255)]
        public string? ServerPath { get; set; }
        [Column("Set Curr Rate Decimal Place")]
        public int? SetCurrRateDecimalPlace { get; set; }
        [Column("Set Unit Rate Decimal Place")]
        public int? SetUnitRateDecimalPlace { get; set; }
        [Column("Show 45ft Flag")]
        [StringLength(1)]
        public string? Show45ftFlag { get; set; }
        [Column("Show Fwb Address 2")]
        [StringLength(1)]
        public string? ShowFwbAddress2 { get; set; }
        [Column("Show Header Info Flag")]
        [StringLength(1)]
        public string? ShowHeaderInfoFlag { get; set; }
        [Column("Show MES Flag")]
        [StringLength(1)]
        public string? ShowMesFlag { get; set; }
        [Column("Show Place Flag")]
        [StringLength(1)]
        public string? ShowPlaceFlag { get; set; }
        [Column("Show User Group Flag")]
        [StringLength(1)]
        public string? ShowUserGroupFlag { get; set; }
        [Column("Site Code")]
        [StringLength(20)]
        public string? SiteCode { get; set; }
        [Column("SMTP Authentication Flag")]
        [StringLength(1)]
        public string? SmtpAuthenticationFlag { get; set; }
        [Column("SMTP Password")]
        [StringLength(50)]
        public string? SmtpPassword { get; set; }
        [Column("SMTP Port")]
        [StringLength(4)]
        public string? SmtpPort { get; set; }
        [Column("SMTP Server")]
        [StringLength(50)]
        public string? SmtpServer { get; set; }
        [Column("SMTP SSL Flag")]
        [StringLength(1)]
        public string? SmtpSslFlag { get; set; }
        [Column("SMTP User ID")]
        [StringLength(50)]
        public string? SmtpUserId { get; set; }
        [Column("SQL Port No")]
        [StringLength(10)]
        public string? SqlPortNo { get; set; }
        [Column("SQL Time Out")]
        public int? SqlTimeOut { get; set; }
        [Column("Sys Drive Password")]
        [StringLength(50)]
        public string? SysDrivePassword { get; set; }
        [Column("Sys Drive Url")]
        [StringLength(50)]
        public string? SysDriveUrl { get; set; }
        [Column("Sys Drive User")]
        [StringLength(50)]
        public string? SysDriveUser { get; set; }
        [Column("Sysmagic Pic Name")]
        [StringLength(200)]
        public string? SysmagicPicName { get; set; }
        [Column("System Upgrade Flag")]
        [StringLength(1)]
        public string? SystemUpgradeFlag { get; set; }
        [Column("Tab Width")]
        public int? TabWidth { get; set; }
        [Column("Task Time Interval")]
        public int? TaskTimeInterval { get; set; }
        [StringLength(30)]
        public string? Telephone { get; set; }
        [Column("Timer Flag")]
        [StringLength(1)]
        public string? TimerFlag { get; set; }
        [Column("Timer Interval")]
        public short? TimerInterval { get; set; }
        [StringLength(20)]
        public string? Title { get; set; }
        [Column("Tradenet Flag")]
        [StringLength(1)]
        public string? TradenetFlag { get; set; }
        [Column("Tradenet Front End")]
        [StringLength(10)]
        public string? TradenetFrontEnd { get; set; }
        [Column("Tradenet URL")]
        [StringLength(200)]
        public string? TradenetUrl { get; set; }
        [Column("Tradenet Version")]
        [StringLength(3)]
        public string? TradenetVersion { get; set; }
        [Column("Transport Address 1")]
        [StringLength(100)]
        public string? TransportAddress1 { get; set; }
        [Column("Transport Address 2")]
        [StringLength(100)]
        public string? TransportAddress2 { get; set; }
        [Column("Transport Address 3")]
        [StringLength(100)]
        public string? TransportAddress3 { get; set; }
        [Column("Transport Address 4")]
        [StringLength(100)]
        public string? TransportAddress4 { get; set; }
        [Column("Transport City Code")]
        [StringLength(3)]
        public string? TransportCityCode { get; set; }
        [Column("Transport City Name")]
        [StringLength(45)]
        public string? TransportCityName { get; set; }
        [Column("Transport Country Code")]
        [StringLength(2)]
        public string? TransportCountryCode { get; set; }
        [Column("Transport Contact Name")]
        [StringLength(50)]
        public string? TransportContactName { get; set; }
        [Column("Transport Email")]
        [StringLength(50)]
        public string? TransportEmail { get; set; }
        [Column("Transport Fax")]
        [StringLength(30)]
        public string? TransportFax { get; set; }
        [Column("Transport Job Database")]
        [StringLength(250)]
        public string? TransportJobDatabase { get; set; }
        [Column("Transport Postal Code")]
        [StringLength(10)]
        public string? TransportPostalCode { get; set; }
        [Column("Transport Telephone")]
        [StringLength(30)]
        public string? TransportTelephone { get; set; }
        [Column("Update Customer Flag")]
        [StringLength(1)]
        public string? UpdateCustomerFlag { get; set; }
        [Column("Update Customer Program")]
        [StringLength(1)]
        public string? UpdateCustomerProgram { get; set; }
        [Column("Update Vendor Flag")]
        [StringLength(1)]
        public string? UpdateVendorFlag { get; set; }
        [Column("Update Vendor Program")]
        [StringLength(1)]
        public string? UpdateVendorProgram { get; set; }
        [Column("Upper Case Flag")]
        [StringLength(1)]
        public string? UpperCaseFlag { get; set; }
        [Column("User Licence Key")]
        [StringLength(10)]
        [Unicode(false)]
        public string UserLicenceKey { get; set; } = null!;
        [Column("User Log Flag")]
        [StringLength(1)]
        public string? UserLogFlag { get; set; }
        [Column("User Login Multiple Site Flag")]
        [StringLength(1)]
        public string? UserLoginMultipleSiteFlag { get; set; }
        [Column("User Path")]
        [StringLength(255)]
        public string? UserPath { get; set; }
        [Column("Vat Name")]
        [StringLength(50)]
        public string? VatName { get; set; }
        [Column("Vat Registration No")]
        [StringLength(20)]
        public string? VatRegistrationNo { get; set; }
        [Column("Version No")]
        [StringLength(50)]
        public string? VersionNo { get; set; }
        [Column("Web Site")]
        [StringLength(50)]
        public string? WebSite { get; set; }
        [Column("Wh Address 1")]
        [StringLength(100)]
        public string? WhAddress1 { get; set; }
        [Column("Wh Address 2")]
        [StringLength(100)]
        public string? WhAddress2 { get; set; }
        [Column("Wh Address 3")]
        [StringLength(100)]
        public string? WhAddress3 { get; set; }
        [Column("Wh Address 4")]
        [StringLength(100)]
        public string? WhAddress4 { get; set; }
        [Column("Wh City Code")]
        [StringLength(3)]
        public string? WhCityCode { get; set; }
        [Column("Wh City Name")]
        [StringLength(45)]
        public string? WhCityName { get; set; }
        [Column("Wh Country Code")]
        [StringLength(2)]
        public string? WhCountryCode { get; set; }
        [Column("Wh Contact Name")]
        [StringLength(50)]
        public string? WhContactName { get; set; }
        [Column("Wh Email")]
        [StringLength(50)]
        public string? WhEmail { get; set; }
        [Column("Wh Fax")]
        [StringLength(30)]
        public string? WhFax { get; set; }
        [Column("Wh Postal Code")]
        [StringLength(10)]
        public string? WhPostalCode { get; set; }
        [Column("Wh Telephone")]
        [StringLength(30)]
        public string? WhTelephone { get; set; }
        [Column("Yellow Name")]
        [StringLength(50)]
        public string? YellowName { get; set; }
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
