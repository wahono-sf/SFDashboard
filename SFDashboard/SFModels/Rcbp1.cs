using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("rcbp1")]
    [Index("BusinessPartyName", Name = "INDEX_Rcbp1_BusinessPartyName")]
    [Index("CityCode", Name = "INDEX_Rcbp1_CityCode")]
    [Index("CountryCode", Name = "INDEX_Rcbp1_CountryCode")]
    [Index("CurrCode", Name = "INDEX_Rcbp1_CurrCode")]
    [Index("CustomerCode", Name = "INDEX_Rcbp1_CustomerCode")]
    [Index("Email", Name = "INDEX_Rcbp1_Email")]
    [Index("Fax", Name = "INDEX_Rcbp1_Fax")]
    [Index("PartyType", Name = "INDEX_Rcbp1_PartyType")]
    [Index("StatusCode", Name = "INDEX_Rcbp1_StatusCode")]
    [Index("Telephone", Name = "INDEX_Rcbp1_Telephone")]
    [Index("UpdateDateTime", Name = "INDEX_Rcbp1_UpdateDateTime")]
    [Index("VendorCode", Name = "INDEX_Rcbp1_VendorCode")]
    [Index("BusinessPartyCode", Name = "IX_rcbp1_BusinessPartyCode")]
    public partial class Rcbp1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(10)]
        public string? BusinessPartyCode { get; set; }
        [StringLength(80)]
        public string? BusinessPartyName { get; set; }
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [StringLength(10)]
        public string? VendorCode { get; set; }
        [StringLength(10)]
        public string? AcctNo { get; set; }
        [StringLength(50)]
        public string? Address1 { get; set; }
        [StringLength(50)]
        public string? Address2 { get; set; }
        [StringLength(50)]
        public string? Address3 { get; set; }
        [StringLength(50)]
        public string? Address4 { get; set; }
        [StringLength(80)]
        public string? AgentName { get; set; }
        [StringLength(16)]
        public string? AgentAccCode { get; set; }
        [StringLength(3)]
        public string? AgentCityName { get; set; }
        [StringLength(16)]
        public string? AgentIataCode { get; set; }
        [StringLength(10)]
        public string? AirAgentCode { get; set; }
        [StringLength(10)]
        public string? AnalysisCode1 { get; set; }
        [StringLength(10)]
        public string? AnalysisCode2 { get; set; }
        [StringLength(10)]
        public string? AnalysisCode3 { get; set; }
        [StringLength(10)]
        public string? AppointAgentCode { get; set; }
        [Column("APCode")]
        [StringLength(10)]
        public string? Apcode { get; set; }
        [Column("APSalesCode")]
        [StringLength(10)]
        public string? ApsalesCode { get; set; }
        [Column("ARAcctCode")]
        [StringLength(10)]
        public string? AracctCode { get; set; }
        [Column("ARCode")]
        [StringLength(10)]
        public string? Arcode { get; set; }
        [Column("ARSalesCode")]
        [StringLength(10)]
        public string? ArsalesCode { get; set; }
        [StringLength(10)]
        public string? AwbPrefix { get; set; }
        [Column("BBFeeAmount", TypeName = "decimal(13, 2)")]
        public decimal? BbfeeAmount { get; set; }
        [Column("BBFeeCalculationMethod")]
        [StringLength(1)]
        public string? BbfeeCalculationMethod { get; set; }
        [Column("BBFeeCurrCode")]
        [StringLength(3)]
        public string? BbfeeCurrCode { get; set; }
        [StringLength(1000)]
        public string? BillingInstruction { get; set; }
        [StringLength(8)]
        public string? BillToCode { get; set; }
        [StringLength(20)]
        public string? BranchId { get; set; }
        [StringLength(10)]
        public string? BusinessType { get; set; }
        [StringLength(255)]
        public string? CfsChargeInstruction { get; set; }
        [StringLength(3)]
        public string? CityCode { get; set; }
        [StringLength(45)]
        public string? CityName { get; set; }
        [StringLength(1)]
        public string? ColdCallFlag { get; set; }
        [StringLength(50)]
        public string? ColdCallRemark { get; set; }
        [StringLength(1000)]
        public string? CompanyProfile { get; set; }
        [StringLength(50)]
        public string? CompanyRegisitrationNo { get; set; }
        [StringLength(50)]
        public string? ContactName1 { get; set; }
        [StringLength(50)]
        public string? ContactName2 { get; set; }
        [StringLength(50)]
        public string? ContactName3 { get; set; }
        [StringLength(6)]
        public string? CostCentreCode { get; set; }
        [StringLength(2)]
        public string? CountryCode { get; set; }
        [StringLength(50)]
        public string? CreditStatusCode { get; set; }
        [StringLength(30)]
        public string? CrNo { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [StringLength(50)]
        public string? CustomerRequestBy { get; set; }
        [StringLength(50)]
        public string? DatabaseName { get; set; }
        [StringLength(1000)]
        public string? DeliveryInstruction { get; set; }
        [StringLength(80)]
        public string? DeliveryToName { get; set; }
        [StringLength(50)]
        public string? DeliveryToAddress1 { get; set; }
        [StringLength(50)]
        public string? DeliveryToAddress2 { get; set; }
        [StringLength(50)]
        public string? DeliveryToAddress3 { get; set; }
        [StringLength(50)]
        public string? DeliveryToAddress4 { get; set; }
        [StringLength(5)]
        public string? DistrictCode { get; set; }
        [StringLength(10)]
        public string? DivisionCode { get; set; }
        public byte? EdiCount { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EdiDateTime { get; set; }
        [StringLength(200)]
        public string? Email { get; set; }
        [StringLength(100)]
        public string? Email1 { get; set; }
        [StringLength(100)]
        public string? Email2 { get; set; }
        [StringLength(100)]
        public string? Email3 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ExpiryDate { get; set; }
        [StringLength(80)]
        public string? ExportNotifyContactName { get; set; }
        [StringLength(250)]
        public string? ExportNotifyEmail { get; set; }
        [StringLength(3)]
        public string? ExportTermCode { get; set; }
        [StringLength(30)]
        public string? Fax { get; set; }
        [StringLength(30)]
        public string? Fax1 { get; set; }
        [StringLength(30)]
        public string? Fax2 { get; set; }
        [StringLength(30)]
        public string? Fax3 { get; set; }
        [StringLength(50)]
        public string? FwbName { get; set; }
        [StringLength(10)]
        public string? FwbAccCode { get; set; }
        [StringLength(50)]
        public string? FwbAddress { get; set; }
        [StringLength(50)]
        public string? FwbAddress2 { get; set; }
        [StringLength(35)]
        public string? FwbContactPerson { get; set; }
        [StringLength(2)]
        public string? FwbCountryCode { get; set; }
        [StringLength(22)]
        public string? FwbOciRefNo { get; set; }
        [StringLength(50)]
        public string? FwbPlace { get; set; }
        [StringLength(50)]
        public string? FwbState { get; set; }
        [StringLength(50)]
        public string? Handphone1 { get; set; }
        [StringLength(50)]
        public string? Handphone2 { get; set; }
        [StringLength(50)]
        public string? Handphone3 { get; set; }
        [StringLength(80)]
        public string? ImportNotifyContactName { get; set; }
        [StringLength(250)]
        public string? ImportNotifyEmail { get; set; }
        [StringLength(3)]
        public string? ImportTermCode { get; set; }
        [StringLength(1)]
        public string? InsuranceBill { get; set; }
        [StringLength(1)]
        public string? InsuranceFlag { get; set; }
        [StringLength(10)]
        public string? JtcAccCode { get; set; }
        [StringLength(20)]
        public string? KnownShipperFlag { get; set; }
        [StringLength(50)]
        public string? LocalAddress1 { get; set; }
        [StringLength(50)]
        public string? LocalAddress2 { get; set; }
        [StringLength(50)]
        public string? LocalAddress3 { get; set; }
        [StringLength(50)]
        public string? LocalAddress4 { get; set; }
        [StringLength(255)]
        public string? LocalName { get; set; }
        [StringLength(20)]
        public string? Marking { get; set; }
        [StringLength(1)]
        public string? MinDef { get; set; }
        [StringLength(2)]
        public string? ModuleCode { get; set; }
        [StringLength(50)]
        public string? Network { get; set; }
        [StringLength(20)]
        public string? NextCustGinNo { get; set; }
        [StringLength(10)]
        public string? NextCustGinPrefix { get; set; }
        [StringLength(20)]
        public string? NextCustGrnNo { get; set; }
        [StringLength(10)]
        public string? NextCustGrnPrefix { get; set; }
        [StringLength(1)]
        public string? NominationFlag { get; set; }
        [StringLength(50)]
        public string? NominationRemark { get; set; }
        [StringLength(50)]
        public string? NominationRemark2 { get; set; }
        [StringLength(50)]
        public string? NominationRemark3 { get; set; }
        [StringLength(1500)]
        public string? NominationTariffNote { get; set; }
        [StringLength(80)]
        public string? NotifyContactName { get; set; }
        [StringLength(250)]
        public string? NotifyEmail { get; set; }
        [StringLength(255)]
        public string? Note { get; set; }
        [StringLength(50)]
        public string? Pager1 { get; set; }
        [StringLength(50)]
        public string? Pager2 { get; set; }
        [StringLength(50)]
        public string? Pager3 { get; set; }
        [StringLength(10)]
        public string? PartyShortCode { get; set; }
        [StringLength(3)]
        public string? PartyType { get; set; }
        [StringLength(50)]
        public string? PartyTypeRemark { get; set; }
        [StringLength(10)]
        public string? Password { get; set; }
        [StringLength(50)]
        public string? PayType { get; set; }
        [Column("PeppolID")]
        [StringLength(50)]
        public string? PeppolId { get; set; }
        [StringLength(50)]
        public string? PeppolScheme { get; set; }
        [StringLength(50)]
        public string? Place { get; set; }
        [StringLength(5)]
        public string? PortCode { get; set; }
        [StringLength(10)]
        public string? PostalCode { get; set; }
        [StringLength(10)]
        public string? PsaAccCode { get; set; }
        [Column("RACode")]
        [StringLength(16)]
        public string? Racode { get; set; }
        [StringLength(1)]
        public string? RebateFlag { get; set; }
        [StringLength(1000)]
        public string? Remark { get; set; }
        [StringLength(1)]
        public string? SalesLeadFlag { get; set; }
        [StringLength(50)]
        public string? SalesLeadRemark { get; set; }
        [StringLength(10)]
        public string? SalesmanCode { get; set; }
        [StringLength(10)]
        public string? SalesmanCode2 { get; set; }
        [StringLength(10)]
        public string? SalesmanCode3 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SatLunchFromTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SatLunchToTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SatWorkFromTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SatWorkToTime { get; set; }
        [Column("SBUCode")]
        [StringLength(10)]
        public string? Sbucode { get; set; }
        [StringLength(2)]
        public string? SectorCode { get; set; }
        [StringLength(50)]
        public string? ServerName { get; set; }
        [StringLength(50)]
        public string? ShipperTelephoneNo { get; set; }
        [StringLength(20)]
        public string? SiteCode { get; set; }
        [StringLength(2000)]
        public string? SpecialInstruction { get; set; }
        [StringLength(50)]
        public string? StateOrProvince { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SunLunchFromTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SunLunchToTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SunWorkFromTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SunWorkToTime { get; set; }
        [StringLength(20)]
        public string? TaxId { get; set; }
        [StringLength(30)]
        public string? Telephone { get; set; }
        [StringLength(30)]
        public string? Telephone1 { get; set; }
        [StringLength(30)]
        public string? Telephone2 { get; set; }
        [StringLength(30)]
        public string? Telephone3 { get; set; }
        [StringLength(10)]
        public string? Telex { get; set; }
        [StringLength(3)]
        public string? TermCode { get; set; }
        [StringLength(50)]
        public string? Title1 { get; set; }
        [StringLength(50)]
        public string? Title2 { get; set; }
        [StringLength(50)]
        public string? Title3 { get; set; }
        [StringLength(30)]
        public string? TradenetAddress1 { get; set; }
        [StringLength(30)]
        public string? TradenetAddress2 { get; set; }
        [StringLength(30)]
        public string? TradenetName1 { get; set; }
        [StringLength(30)]
        public string? TradenetName2 { get; set; }
        [StringLength(10)]
        public string? VatCode { get; set; }
        [StringLength(50)]
        public string? VendorRequestBy { get; set; }
        [StringLength(6)]
        public string? WarehouseCode { get; set; }
        [StringLength(50)]
        public string? WebSite { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WeekLunchFromTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WeekLunchToTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WeekWorkFromTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WeekWorkToTime { get; set; }
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
        [StringLength(50)]
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
