using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("saco1")]
    public partial class Saco1
    {
        /// <summary>
        /// Company Code of the Company
        /// </summary>
        [Key]
        [StringLength(5)]
        public string CompanyCode { get; set; } = null!;
        /// <summary>
        /// Just for AutoCountEDI
        /// </summary>
        [StringLength(1)]
        public string? AccPostProgram { get; set; }
        /// <summary>
        /// Company Addredss 1
        /// </summary>
        [StringLength(100)]
        public string? Address1 { get; set; }
        /// <summary>
        /// Company Addredss 2
        /// </summary>
        [StringLength(100)]
        public string? Address2 { get; set; }
        /// <summary>
        /// Company Addredss 3
        /// </summary>
        [StringLength(100)]
        public string? Address3 { get; set; }
        /// <summary>
        /// Company Addredss 4
        /// </summary>
        [StringLength(100)]
        public string? Address4 { get; set; }
        /// <summary>
        /// Company Air Office Address 1. To print on Air Freight related Document. If leave blank, system will take Company Address 1
        /// </summary>
        [StringLength(100)]
        public string? AirAddress1 { get; set; }
        /// <summary>
        /// Company Air Office Address 2. To print on Air Freight related Document. If leave blank, system will take Company Address 2
        /// </summary>
        [StringLength(100)]
        public string? AirAddress2 { get; set; }
        /// <summary>
        /// Company Air Office Address 3. To print on Air Freight related Document. If leave blank, system will take Company Address 3
        /// </summary>
        [StringLength(100)]
        public string? AirAddress3 { get; set; }
        /// <summary>
        /// Company Air Office Address 4. To print on Air Freight related Document. If leave blank, system will take Company Address 4
        /// </summary>
        [StringLength(100)]
        public string? AirAddress4 { get; set; }
        /// <summary>
        /// Company Air Office city code
        /// </summary>
        [StringLength(3)]
        public string? AirCityCode { get; set; }
        /// <summary>
        /// Company Air Office city name
        /// </summary>
        [StringLength(45)]
        public string? AirCityName { get; set; }
        /// <summary>
        /// Company Air Office country code
        /// </summary>
        [StringLength(2)]
        public string? AirCountryCode { get; set; }
        /// <summary>
        /// Company Air Office contact name
        /// </summary>
        [StringLength(50)]
        public string? AirContactName { get; set; }
        /// <summary>
        /// Company Air Office email
        /// </summary>
        [StringLength(50)]
        public string? AirEmail { get; set; }
        /// <summary>
        /// Company Air Office fax no
        /// </summary>
        [StringLength(30)]
        public string? AirFax { get; set; }
        /// <summary>
        /// Company Air Office postal code
        /// </summary>
        [StringLength(10)]
        public string? AirPostalCode { get; set; }
        /// <summary>
        /// Company Air Office telephone no
        /// </summary>
        [StringLength(30)]
        public string? AirTelephone { get; set; }
        /// <summary>
        /// If set as &apos;Y&apos;, then the system will the user to change the Tradenet password one week before the password expires when login to system.
        /// </summary>
        [StringLength(1)]
        public string? AlertFlag { get; set; }
        /// <summary>
        /// Define the Announcement tab in Memo
        /// </summary>
        [StringLength(2000)]
        public string? Announcement { get; set; }
        /// <summary>
        /// If set as &apos;Y&apos; then New, Edit, Delete all disabled for all forms. When login to the system, it will auto prompt the message ‘ This database was archived. You can view only!’
        /// </summary>
        [StringLength(1)]
        public string? ArchiveDatabaseFlag { get; set; }
        /// <summary>
        /// Define the limit of the attachment size
        /// </summary>
        public int? AttachmentLimit { get; set; }
        [StringLength(50)]
        public string? AuditLogDatabase { get; set; }
        /// <summary>
        /// Control if system should generate the Audit Log file
        /// </summary>
        [StringLength(1)]
        public string? AuditLogFlag { get; set; }
        /// <summary>
        /// If set as &apos;N&apos;, then the check box of Auto Generate will default as unticked on the Update Customer/Update Vendor button screen in rcbp1.
        /// </summary>
        [StringLength(1)]
        public string? AutoGenerateFlag { get; set; }
        /// <summary>
        /// Define which table auto search by Name instead of Code. if set as &apos;rcbp1, acit1&apos;, then for Business Party (rcbp) and Charge Item(acit1) auto search by name
        /// </summary>
        [StringLength(255)]
        public string? AutoSearchByName { get; set; }
        /// <summary>
        /// Alternate Backup Path
        /// </summary>
        [StringLength(50)]
        public string? BackupPath { get; set; }
        [StringLength(50)]
        public string? BlueName { get; set; }
        [StringLength(1)]
        public string? BranchCodeFlag { get; set; }
        /// <summary>
        /// Barch Office Name
        /// </summary>
        [StringLength(80)]
        public string? BranchName { get; set; }
        [StringLength(10)]
        public string? BusinessPartyCode { get; set; }
        /// <summary>
        /// if set as 3,2,2, System will take first 3 letters from first name, 2 letters from 2nd name and 2 letters from 3rd name
        /// SYSMAGIC SOFTWARE SOLUTION PTE LTD will become SYSSOSO  in business party code
        /// If there is already exist SYSSOSO in rcbp1 then it will SYSSOSO01,….. also add CT and CY. so that it can take the CityCode or CountryCode from rcbp1 to be part of the Business Party Code. e.g. 3,CT,CY,then it will update SYSMAGIC  as SYSSINSG. If this is setup, it will overwrite the Next Business Party No logic
        /// </summary>
        [StringLength(20)]
        public string? BusinessPartyFormat { get; set; }
        /// <summary>
        /// Sea Module Cargo Info Tab Commodity from Level1 or Level 2 , Y is Level2
        /// </summary>
        [StringLength(1)]
        public string? CargoCommodityFlag { get; set; }
        [StringLength(255)]
        public string? CfsSite { get; set; }
        [StringLength(1)]
        public string? CheckLicenceByUserFlag { get; set; }
        [StringLength(1)]
        public string? CheckPasswordHistoryFlag { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(200)]
        public string? CheckProjectWebSite { get; set; }
        /// <summary>
        /// City code of the Company
        /// </summary>
        [StringLength(3)]
        public string? CityCode { get; set; }
        /// <summary>
        /// City name of the Company
        /// </summary>
        [StringLength(45)]
        public string? CityName { get; set; }
        /// <summary>
        /// not in used
        /// </summary>
        [StringLength(50)]
        public string? ColorCode { get; set; }
        [StringLength(1)]
        public string? CombineDatabaseFlag { get; set; }
        /// <summary>
        /// Set as Y if there are common database for the reference table
        /// </summary>
        [StringLength(20)]
        public string? CommonDatabase { get; set; }
        /// <summary>
        /// Company Name need to match with the Licence Key
        /// </summary>
        [StringLength(100)]
        public string? CompanyName { get; set; }
        /// <summary>
        /// Contact Name of the Company
        /// </summary>
        [StringLength(50)]
        public string? ContactName { get; set; }
        /// <summary>
        /// if det as &apos;Y&apos;, then when create new sebk1/sebl1 should insert the record to &apos;Ctri1&apos; and &apos;Ctro1&apos;. The &apos;Release Order No&apos; should be the same as the Sebk1/Sebl1 Booking No.
        /// </summary>
        [StringLength(1)]
        public string? ContainerTrackingFlag { get; set; }
        /// <summary>
        /// When do the FHLMessage, the COSAC Agent Code pull from this field
        /// </summary>
        [StringLength(10)]
        public string? CosacAgentCode { get; set; }
        /// <summary>
        /// Country Code of the Company
        /// </summary>
        [StringLength(2)]
        public string? CountryCode { get; set; }
        /// <summary>
        /// Define the Cr No Name in slcu1, plvn1 and saco1
        /// </summary>
        [StringLength(50)]
        public string? CrNoName { get; set; }
        /// <summary>
        /// Local Currency Code using in report
        /// </summary>
        [StringLength(3)]
        public string? CurrencyCode { get; set; }
        [StringLength(3)]
        public string? DeliveryAgentPartyType { get; set; }
        [StringLength(1)]
        public string? DepartmentCodeFlag { get; set; }
        [StringLength(1)]
        public string? DocAttachmentFlag { get; set; }
        [StringLength(255)]
        public string? DocumentFooter1 { get; set; }
        [StringLength(255)]
        public string? DocumentFooter2 { get; set; }
        [StringLength(1)]
        public string? DocumentLocalPathFlag { get; set; }
        /// <summary>
        /// If the value is d:\sysfreight\doc then the system has to attach the document follow the path name. If the value is blank then use back old logic
        /// </summary>
        [StringLength(255)]
        public string? DocumentPath { get; set; }
        [StringLength(2000)]
        public string? DotNetUserLicenceKey { get; set; }
        /// <summary>
        /// for FWB Message
        /// </summary>
        [Column("EDINumber")]
        [StringLength(35)]
        public string? Edinumber { get; set; }
        /// <summary>
        /// for FWB Message
        /// </summary>
        [Column("EDIRecipientID")]
        [StringLength(35)]
        public string? EdirecipientId { get; set; }
        /// <summary>
        /// When click the button &apos;Insert eDoc&apos; on the Attachment screen, it will attach the docment to the eDocument path. The path of document for print on the Mobile App.
        /// </summary>
        [Column("eDocumentPath")]
        [StringLength(255)]
        public string? EDocumentPath { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? EffectiveDate { get; set; }
        [Column("EInvoiceKey")]
        [StringLength(50)]
        public string? EinvoiceKey { get; set; }
        /// <summary>
        /// Company email address
        /// </summary>
        [StringLength(50)]
        public string? Email { get; set; }
        /// <summary>
        /// the URL of eTrack. If blank, then hardcode as http://sysfreight.net:8081/eTrack
        /// </summary>
        [StringLength(80)]
        public string? EtrackAddress { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? ExpiryDate { get; set; }
        /// <summary>
        /// Company fax No.
        /// </summary>
        [StringLength(30)]
        public string? Fax { get; set; }
        /// <summary>
        /// If set as &apos;Y&apos;, then set the font as bold in system.
        /// </summary>
        [StringLength(1)]
        public string? FontBold { get; set; }
        /// <summary>
        /// Define the font size except the grid
        /// </summary>
        [Column(TypeName = "decimal(5, 1)")]
        public decimal? FontSize { get; set; }
        /// <summary>
        /// use for CTS
        /// </summary>
        [StringLength(20)]
        public string? FreightDatabase { get; set; }
        [StringLength(50)]
        public string? FwbEnvelopeLine1 { get; set; }
        [StringLength(50)]
        public string? FwbEnvelopeLine2 { get; set; }
        [StringLength(50)]
        public string? FwbMessageEnvelope { get; set; }
        /// <summary>
        /// Set Y if customer has the FWB interface
        /// </summary>
        [StringLength(1)]
        public string? FwbMessageFlag { get; set; }
        [StringLength(50)]
        public string? GreenName { get; set; }
        /// <summary>
        /// Define the font size in the grid
        /// </summary>
        [Column(TypeName = "decimal(5, 1)")]
        public decimal? GridFontSize { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(1)]
        public string? HideSubMasterFlag { get; set; }
        [Column("IAFPath")]
        [StringLength(255)]
        public string? Iafpath { get; set; }
        [Column("IAFVersionNo")]
        [StringLength(50)]
        public string? IafversionNo { get; set; }
        /// <summary>
        /// IATA Agent Code of the Company
        /// </summary>
        [StringLength(16)]
        public string? IataAgentCode { get; set; }
        /// <summary>
        /// Define the length of ItemCode when auto generate the Item Code
        /// </summary>
        public int? ItemCodeLength { get; set; }
        /// <summary>
        /// If set as &apos;Y&apos;, then it will lock the Account Code on the Update Customer / Update Vendor button screen in rcbp1. The Account Code will pull from slct1/plvt1.AccCode base on the CustomerType / VendorType
        /// </summary>
        [StringLength(1)]
        public string? LockAccCodeFlag { get; set; }
        /// <summary>
        /// Lock the customer to add/edit Business Party from other form entries
        /// </summary>
        [StringLength(1)]
        public string? LockBusinessPartyFlag { get; set; }
        /// <summary>
        /// Lock the Business Info tab in Business Party form when Customer or Vendor Code is entered.
        /// Set as U, if the access right =U, then it will be locked
        /// Set as S, if the access right = S or U, then it will be locked
        /// Set as A, then it will be locked for all users.
        /// </summary>
        [StringLength(1)]
        public string? LockBusinessPartyInfoFlag { get; set; }
        /// <summary>
        /// Lock the customer to add/edit Business Party from other forms
        /// </summary>
        [StringLength(1)]
        public string? LockReferenceFlag { get; set; }
        [StringLength(1)]
        public string? LockRecordOpenFormFlag { get; set; }
        /// <summary>
        /// Prompt user when login to the system
        /// </summary>
        [StringLength(255)]
        public string? LoginMessage { get; set; }
        [Column(TypeName = "image")]
        public byte[]? LogoImage { get; set; }
        /// <summary>
        /// Set the vessel code same as vessel name 50 characters
        /// </summary>
        [StringLength(1)]
        public string? LongVesselCodeFlag { get; set; }
        /// <summary>
        /// the URL of Mobile App. If blank, then hardcode as http://www.sysfreight.net:8081/mobileapp
        /// </summary>
        [StringLength(80)]
        public string? MobileAppAddress { get; set; }
        /// <summary>
        /// It will enter the database name with comma separator for multiple database e.g. abcfreight, netfreight. Then it will show a combo box to show the database name from MultipleDatabaseName so the Look for can search record across database
        /// </summary>
        [StringLength(255)]
        public string? MultipleDatabaseName { get; set; }
        /// <summary>
        /// When generate the EDI, for AR,AP and FM. It will use the NextBatchNo and then it will update the NextBatchNo+1. Remember only completed the file generation then +1
        /// </summary>
        [StringLength(10)]
        public string? NextBatchNo { get; set; }
        /// <summary>
        /// Next Auto Generate No. for Business Party
        /// </summary>
        [StringLength(10)]
        public string? NextBusinessPartyNo { get; set; }
        public int? NoOfFailLogin { get; set; }
        /// <summary>
        /// Limit the user open the no. of tab, except the User ID=S
        /// </summary>
        public int? NoOfTabOpen { get; set; }
        [StringLength(200)]
        public string? NotifyBccEmailAddress { get; set; }
        [StringLength(200)]
        public string? NotifyCcEmailAddress { get; set; }
        /// <summary>
        /// for FWB Message
        /// </summary>
        [StringLength(3)]
        public string? OfficeAirportCode { get; set; }
        /// <summary>
        /// for FWB Message
        /// </summary>
        [StringLength(2)]
        public string? OfficeDesignator { get; set; }
        /// <summary>
        /// for FWB Message
        /// </summary>
        [StringLength(2)]
        public string? OfficeFunctionDesignation { get; set; }
        [StringLength(50)]
        public string? OrangeName { get; set; }
        /// <summary>
        /// postal code of the Company
        /// </summary>
        [StringLength(10)]
        public string? PostalCode { get; set; }
        [StringLength(255)]
        public string? PostingLogPath { get; set; }
        [StringLength(1)]
        public string? PrintCrystalTrayFlag { get; set; }
        [StringLength(50)]
        public string? PurpleName { get; set; }
        [StringLength(1)]
        public string? QuotationCheckFlag { get; set; }
        [StringLength(1)]
        public string? ReadOnlyFlag { get; set; }
        [StringLength(50)]
        public string? RedName { get; set; }
        /// <summary>
        /// Company Registry No. of the Company
        /// </summary>
        [StringLength(20)]
        public string? RegistrationNo { get; set; }
        /// <summary>
        /// control whether for language = English, needs to read from the Multiple Language table. If language is English and the RenameEnglishLabelFlag = &quot;N&quot; or blank, do not need to read the Multiple Language table
        /// </summary>
        [StringLength(1)]
        public string? RenameEnglishLabelFlag { get; set; }
        [StringLength(1)]
        public string? ReportLocalPathFlag { get; set; }
        /// <summary>
        /// Alternate Report Path
        /// </summary>
        [StringLength(255)]
        public string? ReportPath { get; set; }
        [StringLength(255)]
        public string? ReportRemotePath { get; set; }
        /// <summary>
        /// if set A,S and U so in rcbp1 the SalesmanCode will be disabled (F4 also) by user right of the user. i.e. A will be A can enter only, S will be S and A, U all user can enter.
        /// </summary>
        [StringLength(1)]
        public string? SalesmanCodeAccessRight { get; set; }
        /// <summary>
        /// Company Sea Office Address 1. To print on Sea Freight related document. If leave blank, system will take Company Address 1
        /// </summary>
        [StringLength(100)]
        public string? SeaAddress1 { get; set; }
        /// <summary>
        /// Company Sea Office Address 2. To print on Sea Freight related document. If leave blank, system will take Company Address 2
        /// </summary>
        [StringLength(100)]
        public string? SeaAddress2 { get; set; }
        /// <summary>
        /// Company Sea Office Address 3. To print on Sea Freight related document. If leave blank, system will take Company Address 3
        /// </summary>
        [StringLength(100)]
        public string? SeaAddress3 { get; set; }
        /// <summary>
        /// Company Sea Office Address 4. To print on Sea Freight related document. If leave blank, system will take Company Address 4
        /// </summary>
        [StringLength(100)]
        public string? SeaAddress4 { get; set; }
        /// <summary>
        /// Company Sea Office city code
        /// </summary>
        [StringLength(3)]
        public string? SeaCityCode { get; set; }
        /// <summary>
        /// Company Sea Office city name
        /// </summary>
        [StringLength(45)]
        public string? SeaCityName { get; set; }
        /// <summary>
        /// Company Sea Office country code
        /// </summary>
        [StringLength(2)]
        public string? SeaCountryCode { get; set; }
        /// <summary>
        /// Company Sea Office contact name
        /// </summary>
        [StringLength(50)]
        public string? SeaContactName { get; set; }
        /// <summary>
        /// Company Sea Office email
        /// </summary>
        [StringLength(50)]
        public string? SeaEmail { get; set; }
        /// <summary>
        /// Company Sea Office fax no
        /// </summary>
        [StringLength(30)]
        public string? SeaFax { get; set; }
        /// <summary>
        /// Company Sea Office postal code
        /// </summary>
        [StringLength(10)]
        public string? SeaPostalCode { get; set; }
        /// <summary>
        /// Company Sea Office telephone no
        /// </summary>
        [StringLength(30)]
        public string? SeaTelephone { get; set; }
        /// <summary>
        /// for FWB Message
        /// </summary>
        [StringLength(3)]
        public string? SenderAirportCode { get; set; }
        /// <summary>
        /// for FWB Message
        /// </summary>
        [StringLength(15)]
        public string? SenderFileReference { get; set; }
        /// <summary>
        /// for FWB Message
        /// </summary>
        [StringLength(17)]
        public string? SenderParticipantCode { get; set; }
        /// <summary>
        /// for FWB Message
        /// </summary>
        [Column("SenderParticipantID")]
        [StringLength(3)]
        public string? SenderParticipantId { get; set; }
        [StringLength(50)]
        public string? ServerLoginId { get; set; }
        [StringLength(50)]
        public string? ServerPassword { get; set; }
        [StringLength(255)]
        public string? ServerPath { get; set; }
        /// <summary>
        /// Define the decimal for curr rate. e.g set 1, then the curr rate should be 1 decimal; if don’t set or blank or null, the system keep old logic.
        /// </summary>
        public int? SetCurrRateDecPlace { get; set; }
        /// <summary>
        /// Define the decimal for unit rate. e.g set 1, then the unit rate should be 1 decimal; if don’t set or blank or null, the system keep old logic.
        /// </summary>
        public int? SetUnitRateDecPlace { get; set; }
        [StringLength(1)]
        public string? Show45FtFlag { get; set; }
        [StringLength(1)]
        public string? ShowFwbAddress2 { get; set; }
        /// <summary>
        /// If set as &apos;Y&apos;, then the Telephone/Fax/Website/Email/RegistrationNo from saco1 will show on the report when header is ticked in sapp1
        /// </summary>
        [StringLength(1)]
        public string? ShowHeaderInfoFlag { get; set; }
        /// <summary>
        /// If set as &apos;Y&apos;, the MES button will appear in the Job entry
        /// </summary>
        [Column("ShowMESFlag")]
        [StringLength(1)]
        public string? ShowMesflag { get; set; }
        /// <summary>
        /// If Set as Y, then show Place in below forms (include the Place under delivery). If blank or N, don’t show.
        /// </summary>
        [StringLength(1)]
        public string? ShowPlaceFlag { get; set; }
        /// <summary>
        /// In the Cost Button screen in ivcr1 and plvi1 , if User Group is Y in saco1, the filter (click show all or multiple job or show house) need to show the same User Group as ivcr1.JobNo and plvi1.JobNo.
        /// </summary>
        [StringLength(1)]
        public string? ShowUserGroupFlag { get; set; }
        /// <summary>
        /// Site Code of the Company. Default as FREIGHT
        /// </summary>
        [StringLength(20)]
        public string? SiteCode { get; set; }
        [Column("SMTPAuthenticationFlag")]
        [StringLength(1)]
        public string? SmtpauthenticationFlag { get; set; }
        [Column("SMTPPassword")]
        [StringLength(50)]
        public string? Smtppassword { get; set; }
        [Column("SMTPPort")]
        [StringLength(4)]
        public string? Smtpport { get; set; }
        [Column("SMTPServer")]
        [StringLength(50)]
        public string? Smtpserver { get; set; }
        [Column("SMTPSSLFlag")]
        [StringLength(1)]
        public string? Smtpsslflag { get; set; }
        [Column("SMTPUserID")]
        [StringLength(50)]
        public string? SmtpuserId { get; set; }
        [Column("SQLPortNo")]
        [StringLength(10)]
        public string? SqlportNo { get; set; }
        /// <summary>
        /// Set SQL time Out. Default is 999
        /// </summary>
        public int? SqlTimeOut { get; set; }
        [StringLength(50)]
        public string? SysDrivePassword { get; set; }
        [StringLength(50)]
        public string? SysDriveUrl { get; set; }
        [StringLength(50)]
        public string? SysDriveUser { get; set; }
        /// <summary>
        /// the picture of the main menu background
        /// </summary>
        [StringLength(200)]
        public string? SysmagicPicName { get; set; }
        /// <summary>
        /// If set as &apos;Y&apos;, then if there is the new version, it will auto update to version.
        /// </summary>
        [StringLength(1)]
        public string? SystemUpgradeFlag { get; set; }
        /// <summary>
        /// control tab Width ,if TabWidth=0 or blank , use current width
        /// </summary>
        public int? TabWidth { get; set; }
        public int? TaskTimeInterval { get; set; }
        /// <summary>
        /// Telephone of the Company
        /// </summary>
        [StringLength(30)]
        public string? Telephone { get; set; }
        /// <summary>
        /// if set as &apos;Y&apos;, then the reminder in Message, Note and Reminder will check if there is the reminder and prompt user.
        /// </summary>
        [StringLength(1)]
        public string? TimerFlag { get; set; }
        /// <summary>
        /// Set the time interval for the Notification in Minute
        /// </summary>
        public short? TimerInterval { get; set; }
        [StringLength(20)]
        public string? Title { get; set; }
        /// <summary>
        /// If Y the Tradenet button will appear in the Job entry
        /// </summary>
        [StringLength(1)]
        public string? TradenetFlag { get; set; }
        [StringLength(10)]
        public string? TradenetFrontEnd { get; set; }
        /// <summary>
        /// Define the URL of the Tradenet
        /// </summary>
        [Column("TradenetURL")]
        [StringLength(200)]
        public string? TradenetUrl { get; set; }
        /// <summary>
        /// Default the Tradenet version
        /// </summary>
        [StringLength(3)]
        public string? TradenetVersion { get; set; }
        /// <summary>
        /// Company Transport Office Address 1. To print on Transport related document. If leave blank, system will take Company Address 1
        /// </summary>
        [StringLength(100)]
        public string? TransportAddress1 { get; set; }
        /// <summary>
        /// Company Transport Office Address 2. To print on Transport related document. If leave blank, system will take Company Address 2
        /// </summary>
        [StringLength(100)]
        public string? TransportAddress2 { get; set; }
        /// <summary>
        /// Company Transport Office Address 3. To print on Transport related document. If leave blank, system will take Company Address 3
        /// </summary>
        [StringLength(100)]
        public string? TransportAddress3 { get; set; }
        /// <summary>
        /// Company Transport Office Address 4. To print on Transport related document. If leave blank, system will take Company Address 4
        /// </summary>
        [StringLength(100)]
        public string? TransportAddress4 { get; set; }
        /// <summary>
        /// Company Transport Office city code
        /// </summary>
        [StringLength(3)]
        public string? TransportCityCode { get; set; }
        /// <summary>
        /// Company Transport Office city name
        /// </summary>
        [StringLength(45)]
        public string? TransportCityName { get; set; }
        /// <summary>
        /// Company Transport Office country code
        /// </summary>
        [StringLength(2)]
        public string? TransportCountryCode { get; set; }
        /// <summary>
        /// Company Transport Office contact name
        /// </summary>
        [StringLength(50)]
        public string? TransportContactName { get; set; }
        /// <summary>
        /// Company Transport Office email
        /// </summary>
        [StringLength(50)]
        public string? TransportEmail { get; set; }
        /// <summary>
        /// Company Transport Office fax no
        /// </summary>
        [StringLength(30)]
        public string? TransportFax { get; set; }
        [StringLength(250)]
        public string? TransportJobDatabase { get; set; }
        /// <summary>
        /// Company Transport Office postal code
        /// </summary>
        [StringLength(10)]
        public string? TransportPostalCode { get; set; }
        /// <summary>
        /// Company Transport Office telephone no
        /// </summary>
        [StringLength(30)]
        public string? TransportTelephone { get; set; }
        /// <summary>
        /// Set N to hide the Update Customer button in Business Party
        /// Set A only User Access is A can see Update Customer button in Business Party
        /// Set S only User Access is A &amp; S can see Update Customer button in Business Party
        /// Set U or leave blank, all user can see Update Customer button in Business Party
        /// </summary>
        [StringLength(1)]
        public string? UpdateCustomerFlag { get; set; }
        /// <summary>
        /// Just for AutoCountEDI
        /// </summary>
        [StringLength(1)]
        public string? UpdateCustomerProgram { get; set; }
        /// <summary>
        /// Set N to hide the Update Vendor button in Business Party
        /// Set A only User Access is A can see Update Vendor button in Business Party
        /// Set S only User Access is A &amp; S can see Update Vendor button in Business Party
        /// Set U or leave blank, all user can see Update Vendor button in Business Party
        /// </summary>
        [StringLength(1)]
        public string? UpdateVendorFlag { get; set; }
        /// <summary>
        /// Just for AutoCountEDI
        /// </summary>
        [StringLength(1)]
        public string? UpdateVendorProgram { get; set; }
        /// <summary>
        /// If set as ‘Y’ and leave blank, then keep current logic, if set as ‘N’, then when enter the value , the system should not auto change to upper case.
        /// The Sepa1.UpperCaseFlag is higher than saco1.UpperCaseFlag
        /// For parameter file include grid should not auto cap. It should always use normal letter
        /// </summary>
        [StringLength(1)]
        public string? UpperCaseFlag { get; set; }
        /// <summary>
        /// Enter the SysFreight Licence Key
        /// </summary>
        [StringLength(2000)]
        public string? UserLicenceKey { get; set; }
        [StringLength(1)]
        public string? UserLogFlag { get; set; }
        [StringLength(1)]
        public string? UserLoginMultipleSiteFlag { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(255)]
        public string? UserPath { get; set; }
        /// <summary>
        /// Alternate name of the Tax Code e.g GST for Singaport
        /// </summary>
        [StringLength(50)]
        public string? VatName { get; set; }
        /// <summary>
        /// Tax Registration No.of the Company
        /// </summary>
        [StringLength(20)]
        public string? VatRegistrationNo { get; set; }
        [StringLength(50)]
        public string? VersionNo { get; set; }
        /// <summary>
        /// Company Website
        /// </summary>
        [StringLength(50)]
        public string? WebSite { get; set; }
        /// <summary>
        /// Company Warehouse Office Address 1. To print on Warehouse related document. If leave blank, system will take Company Address 1
        /// </summary>
        [StringLength(100)]
        public string? WhAddress1 { get; set; }
        /// <summary>
        /// Company Warehouse Office Address 2. To print on Warehouse related document. If leave blank, system will take Company Address 2
        /// </summary>
        [StringLength(100)]
        public string? WhAddress2 { get; set; }
        /// <summary>
        /// Company Warehouse Office Address 3. To print on Warehouse related document. If leave blank, system will take Company Address 3
        /// </summary>
        [StringLength(100)]
        public string? WhAddress3 { get; set; }
        /// <summary>
        /// Company Warehouse Office Address 4. To print on Warehouse related document. If leave blank, system will take Company Address 4
        /// </summary>
        [StringLength(100)]
        public string? WhAddress4 { get; set; }
        /// <summary>
        /// Company Warehouse Office city code
        /// </summary>
        [StringLength(3)]
        public string? WhCityCode { get; set; }
        /// <summary>
        /// Company Warehouse Office city name
        /// </summary>
        [StringLength(45)]
        public string? WhCityName { get; set; }
        /// <summary>
        /// Company Warehouse Office country code
        /// </summary>
        [StringLength(2)]
        public string? WhCountryCode { get; set; }
        /// <summary>
        /// Company Warehouse Office contact name
        /// </summary>
        [StringLength(50)]
        public string? WhContactName { get; set; }
        /// <summary>
        /// Company Warehouse Office email
        /// </summary>
        [StringLength(50)]
        public string? WhEmail { get; set; }
        /// <summary>
        /// Company Warehouse Office fax no
        /// </summary>
        [StringLength(30)]
        public string? WhFax { get; set; }
        /// <summary>
        /// Company Warehouse Office postal code
        /// </summary>
        [StringLength(10)]
        public string? WhPostalCode { get; set; }
        /// <summary>
        /// Company Warehouse Office telephone no
        /// </summary>
        [StringLength(30)]
        public string? WhTelephone { get; set; }
        [StringLength(50)]
        public string? YellowName { get; set; }
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
    }
}
