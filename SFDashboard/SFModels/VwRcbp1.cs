using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwRcbp1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Business Party Code")]
        [StringLength(10)]
        public string? BusinessPartyCode { get; set; }
        [Column("Business Party Name")]
        [StringLength(80)]
        public string? BusinessPartyName { get; set; }
        [Column("Customer Code")]
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [Column("Vendor Code")]
        [StringLength(10)]
        public string? VendorCode { get; set; }
        [Column("Acct No")]
        [StringLength(10)]
        public string? AcctNo { get; set; }
        [Column("Address 1")]
        [StringLength(50)]
        public string? Address1 { get; set; }
        [Column("Address 2")]
        [StringLength(50)]
        public string? Address2 { get; set; }
        [Column("Address 3")]
        [StringLength(50)]
        public string? Address3 { get; set; }
        [Column("Address 4")]
        [StringLength(50)]
        public string? Address4 { get; set; }
        [Column("Agent Acc Code")]
        [StringLength(16)]
        public string? AgentAccCode { get; set; }
        [Column("Agent City Name")]
        [StringLength(3)]
        public string? AgentCityName { get; set; }
        [Column("Agent Iata Code")]
        [StringLength(16)]
        public string? AgentIataCode { get; set; }
        [Column("Agent Name")]
        [StringLength(80)]
        public string? AgentName { get; set; }
        [Column("Air Agent Code")]
        [StringLength(10)]
        public string? AirAgentCode { get; set; }
        [Column("Analysis Code 1")]
        [StringLength(10)]
        public string? AnalysisCode1 { get; set; }
        [Column("Analysis Code 2")]
        [StringLength(10)]
        public string? AnalysisCode2 { get; set; }
        [Column("Analysis Code 3")]
        [StringLength(10)]
        public string? AnalysisCode3 { get; set; }
        [Column("Appoint Agent Code")]
        [StringLength(10)]
        public string? AppointAgentCode { get; set; }
        [Column("AP Code")]
        [StringLength(10)]
        public string? ApCode { get; set; }
        [Column("AP Sales Code")]
        [StringLength(10)]
        public string? ApSalesCode { get; set; }
        [Column("Ar Acct Code")]
        [StringLength(10)]
        public string? ArAcctCode { get; set; }
        [Column("AR Code")]
        [StringLength(10)]
        public string? ArCode { get; set; }
        [Column("AR Sales Code")]
        [StringLength(10)]
        public string? ArSalesCode { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Awb Prefix")]
        [StringLength(10)]
        public string? AwbPrefix { get; set; }
        [Column("BB Fee Amount", TypeName = "decimal(13, 2)")]
        public decimal? BbFeeAmount { get; set; }
        [Column("BB Fee Calculation Method")]
        [StringLength(1)]
        public string? BbFeeCalculationMethod { get; set; }
        [Column("BB Fee Curr Code")]
        [StringLength(3)]
        public string? BbFeeCurrCode { get; set; }
        [Column("Billing Instruction")]
        [StringLength(1000)]
        public string? BillingInstruction { get; set; }
        [Column("Bill To Code")]
        [StringLength(8)]
        public string? BillToCode { get; set; }
        [Column("Branch ID")]
        [StringLength(20)]
        public string? BranchId { get; set; }
        [Column("Business Type")]
        [StringLength(10)]
        public string? BusinessType { get; set; }
        [Column("CFS Charge Instruction")]
        [StringLength(255)]
        public string? CfsChargeInstruction { get; set; }
        [Column("City Code")]
        [StringLength(3)]
        public string? CityCode { get; set; }
        [Column("City Name")]
        [StringLength(45)]
        public string? CityName { get; set; }
        [Column("Cold Call Flag")]
        [StringLength(1)]
        public string? ColdCallFlag { get; set; }
        [Column("Cold Call Remark")]
        [StringLength(50)]
        public string? ColdCallRemark { get; set; }
        [Column("Company Profile")]
        [StringLength(1000)]
        public string? CompanyProfile { get; set; }
        [Column("Company Registration No")]
        [StringLength(50)]
        public string? CompanyRegistrationNo { get; set; }
        [Column("Contact Name 1")]
        [StringLength(50)]
        public string? ContactName1 { get; set; }
        [Column("Contact Name 2")]
        [StringLength(50)]
        public string? ContactName2 { get; set; }
        [Column("Contact Name 3")]
        [StringLength(50)]
        public string? ContactName3 { get; set; }
        [Column("CostCentre Code")]
        [StringLength(6)]
        public string? CostCentreCode { get; set; }
        [Column("Country Code")]
        [StringLength(2)]
        public string? CountryCode { get; set; }
        [Column("Country Name")]
        [StringLength(45)]
        public string? CountryName { get; set; }
        [Column("Credit Limit", TypeName = "decimal(13, 2)")]
        public decimal? CreditLimit { get; set; }
        [Column("Credit Status Code")]
        [StringLength(50)]
        public string? CreditStatusCode { get; set; }
        [Column("Cr No")]
        [StringLength(30)]
        public string? CrNo { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Customer Request By")]
        [StringLength(50)]
        public string? CustomerRequestBy { get; set; }
        [Column("Database Name")]
        [StringLength(50)]
        public string? DatabaseName { get; set; }
        [Column("Delivery Instruction")]
        [StringLength(1000)]
        public string? DeliveryInstruction { get; set; }
        [Column("Delivery To Name")]
        [StringLength(80)]
        public string? DeliveryToName { get; set; }
        [Column("Delivery To Address 1")]
        [StringLength(50)]
        public string? DeliveryToAddress1 { get; set; }
        [Column("Delivery To Address 2")]
        [StringLength(50)]
        public string? DeliveryToAddress2 { get; set; }
        [Column("Delivery To Address 3")]
        [StringLength(50)]
        public string? DeliveryToAddress3 { get; set; }
        [Column("Delivery To Address 4")]
        [StringLength(50)]
        public string? DeliveryToAddress4 { get; set; }
        [Column("District Code")]
        [StringLength(5)]
        public string? DistrictCode { get; set; }
        [Column("Division Code")]
        [StringLength(10)]
        public string? DivisionCode { get; set; }
        [Column("EDI Count")]
        public byte? EdiCount { get; set; }
        [Column("EDI  Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? EdiDateTime { get; set; }
        [StringLength(200)]
        public string? Email { get; set; }
        [Column("Email 1")]
        [StringLength(100)]
        public string? Email1 { get; set; }
        [Column("Email 2")]
        [StringLength(100)]
        public string? Email2 { get; set; }
        [Column("Email 3")]
        [StringLength(100)]
        public string? Email3 { get; set; }
        [Column("Expiry Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ExpiryDate { get; set; }
        [Column("Export Notify Contact Name")]
        [StringLength(80)]
        public string? ExportNotifyContactName { get; set; }
        [Column("Export Notify Email")]
        [StringLength(250)]
        public string? ExportNotifyEmail { get; set; }
        [Column("Export Term Code")]
        [StringLength(3)]
        public string? ExportTermCode { get; set; }
        [StringLength(30)]
        public string? Fax { get; set; }
        [Column("Fax 1")]
        [StringLength(30)]
        public string? Fax1 { get; set; }
        [Column("Fax 2")]
        [StringLength(30)]
        public string? Fax2 { get; set; }
        [Column("Fax 3")]
        [StringLength(30)]
        public string? Fax3 { get; set; }
        [Column("FWB Name")]
        [StringLength(50)]
        public string? FwbName { get; set; }
        [Column("FWB Acc Code")]
        [StringLength(10)]
        public string? FwbAccCode { get; set; }
        [Column("FWB Address")]
        [StringLength(50)]
        public string? FwbAddress { get; set; }
        [Column("FWB Address 2")]
        [StringLength(50)]
        public string? FwbAddress2 { get; set; }
        [Column("FWB Contact Person")]
        [StringLength(35)]
        public string? FwbContactPerson { get; set; }
        [Column("FWB Country Code")]
        [StringLength(2)]
        public string? FwbCountryCode { get; set; }
        [Column("FWB OCI Ref No")]
        [StringLength(22)]
        public string? FwbOciRefNo { get; set; }
        [Column("FWB Place")]
        [StringLength(50)]
        public string? FwbPlace { get; set; }
        [Column("FWB State")]
        [StringLength(50)]
        public string? FwbState { get; set; }
        [Column("Handphone 1")]
        [StringLength(50)]
        public string? Handphone1 { get; set; }
        [Column("Handphone 2")]
        [StringLength(50)]
        public string? Handphone2 { get; set; }
        [Column("Handphone 3")]
        [StringLength(50)]
        public string? Handphone3 { get; set; }
        [Column("Import Notify Contact Name")]
        [StringLength(80)]
        public string? ImportNotifyContactName { get; set; }
        [Column("Import Notify Email")]
        [StringLength(250)]
        public string? ImportNotifyEmail { get; set; }
        [Column("Import Term Code")]
        [StringLength(3)]
        public string? ImportTermCode { get; set; }
        [Column("Insurance Bill")]
        [StringLength(1)]
        public string? InsuranceBill { get; set; }
        [Column("Insurance Flag")]
        [StringLength(1)]
        public string? InsuranceFlag { get; set; }
        [Column("Jtc Acc Code")]
        [StringLength(10)]
        public string? JtcAccCode { get; set; }
        [Column("Known Shipper Flag")]
        [StringLength(20)]
        public string? KnownShipperFlag { get; set; }
        [Column("Local Address 1")]
        [StringLength(50)]
        public string? LocalAddress1 { get; set; }
        [Column("Local Address 2")]
        [StringLength(50)]
        public string? LocalAddress2 { get; set; }
        [Column("Local Address 3")]
        [StringLength(50)]
        public string? LocalAddress3 { get; set; }
        [Column("Local Address 4")]
        [StringLength(50)]
        public string? LocalAddress4 { get; set; }
        [Column("Local Name")]
        [StringLength(255)]
        public string? LocalName { get; set; }
        [StringLength(20)]
        public string? Marking { get; set; }
        [Column("Min Def")]
        [StringLength(1)]
        public string? MinDef { get; set; }
        [Column("Module Code")]
        [StringLength(2)]
        public string? ModuleCode { get; set; }
        [StringLength(50)]
        public string? Network { get; set; }
        [Column("Next Customer Gin No")]
        [StringLength(20)]
        public string? NextCustomerGinNo { get; set; }
        [Column("Next Customer Gin Prefix")]
        [StringLength(10)]
        public string? NextCustomerGinPrefix { get; set; }
        [Column("Next Customer Grn No")]
        [StringLength(20)]
        public string? NextCustomerGrnNo { get; set; }
        [Column("Next Customer Grn Prefix")]
        [StringLength(10)]
        public string? NextCustomerGrnPrefix { get; set; }
        [Column("Nomination Flag")]
        [StringLength(1)]
        public string? NominationFlag { get; set; }
        [Column("Nomination Remark")]
        [StringLength(50)]
        public string? NominationRemark { get; set; }
        [Column("Nomination Remark 2")]
        [StringLength(50)]
        public string? NominationRemark2 { get; set; }
        [Column("Nomination Remark 3")]
        [StringLength(50)]
        public string? NominationRemark3 { get; set; }
        [Column("Nomination Tariff Note")]
        [StringLength(1500)]
        public string? NominationTariffNote { get; set; }
        [StringLength(255)]
        public string? Note { get; set; }
        [Column("Notify Contact Name")]
        [StringLength(80)]
        public string? NotifyContactName { get; set; }
        [Column("Notify Email")]
        [StringLength(250)]
        public string? NotifyEmail { get; set; }
        [Column("Pager 1")]
        [StringLength(50)]
        public string? Pager1 { get; set; }
        [Column("Pager 2")]
        [StringLength(50)]
        public string? Pager2 { get; set; }
        [Column("Pager 3")]
        [StringLength(50)]
        public string? Pager3 { get; set; }
        [Column("Party Short Code")]
        [StringLength(10)]
        public string? PartyShortCode { get; set; }
        [Column("Party Type")]
        [StringLength(3)]
        public string? PartyType { get; set; }
        [Column("Party Type Remark")]
        [StringLength(50)]
        public string? PartyTypeRemark { get; set; }
        [Column("Client Flag")]
        [StringLength(1)]
        [Unicode(false)]
        public string ClientFlag { get; set; } = null!;
        [Column("Overseas Agent Flag")]
        [StringLength(1)]
        [Unicode(false)]
        public string OverseasAgentFlag { get; set; } = null!;
        [Column("Shipper Flag")]
        [StringLength(1)]
        [Unicode(false)]
        public string ShipperFlag { get; set; } = null!;
        [Column("Consignee Flag")]
        [StringLength(1)]
        [Unicode(false)]
        public string ConsigneeFlag { get; set; } = null!;
        [Column("Coloader Flag")]
        [StringLength(1)]
        [Unicode(false)]
        public string ColoaderFlag { get; set; } = null!;
        [Column("Coloader Agent Flag")]
        [StringLength(1)]
        [Unicode(false)]
        public string ColoaderAgentFlag { get; set; } = null!;
        [Column("Warehouse Flag")]
        [StringLength(1)]
        [Unicode(false)]
        public string WarehouseFlag { get; set; } = null!;
        [Column("Transport Flag")]
        [StringLength(1)]
        [Unicode(false)]
        public string TransportFlag { get; set; } = null!;
        [Column("Others Flag")]
        [StringLength(1)]
        [Unicode(false)]
        public string OthersFlag { get; set; } = null!;
        [Column("Shipping Line Flag")]
        [StringLength(1)]
        [Unicode(false)]
        public string ShippingLineFlag { get; set; } = null!;
        [Column("Vendor Flag")]
        [StringLength(1)]
        [Unicode(false)]
        public string VendorFlag { get; set; } = null!;
        [StringLength(10)]
        [Unicode(false)]
        public string Password { get; set; } = null!;
        [Column("Pay Type")]
        [StringLength(50)]
        public string? PayType { get; set; }
        [Column("Peppol ID")]
        [StringLength(50)]
        public string? PeppolId { get; set; }
        [Column("Peppol Scheme")]
        [StringLength(50)]
        public string? PeppolScheme { get; set; }
        [StringLength(50)]
        public string? Place { get; set; }
        [Column("Port Code")]
        [StringLength(5)]
        public string? PortCode { get; set; }
        [Column("Port Name")]
        [StringLength(45)]
        public string? PortName { get; set; }
        [Column("Postal Code")]
        [StringLength(10)]
        public string? PostalCode { get; set; }
        [Column("Psa Acc Code")]
        [StringLength(10)]
        public string? PsaAccCode { get; set; }
        [Column("RA Code")]
        [StringLength(16)]
        public string? RaCode { get; set; }
        [Column("Rebate Flag")]
        [StringLength(1)]
        public string? RebateFlag { get; set; }
        [StringLength(1000)]
        public string? Remark { get; set; }
        [Column("Sales Lead Flag")]
        [StringLength(1)]
        public string? SalesLeadFlag { get; set; }
        [Column("Sales Lead Remark")]
        [StringLength(50)]
        public string? SalesLeadRemark { get; set; }
        [Column("Salesman Code")]
        [StringLength(10)]
        public string? SalesmanCode { get; set; }
        [Column("Salesman Code 2")]
        [StringLength(10)]
        public string? SalesmanCode2 { get; set; }
        [Column("Salesman Code 3")]
        [StringLength(10)]
        public string? SalesmanCode3 { get; set; }
        [Column("Sat Lunch From Time")]
        [StringLength(5)]
        [Unicode(false)]
        public string? SatLunchFromTime { get; set; }
        [Column("Sat Lunch To Time")]
        [StringLength(5)]
        [Unicode(false)]
        public string? SatLunchToTime { get; set; }
        [Column("Sat Work From Time")]
        [StringLength(5)]
        [Unicode(false)]
        public string? SatWorkFromTime { get; set; }
        [Column("Sat Work To Time")]
        [StringLength(5)]
        [Unicode(false)]
        public string? SatWorkToTime { get; set; }
        [Column("SBU Code")]
        [StringLength(10)]
        public string? SbuCode { get; set; }
        [Column("Sector Code")]
        [StringLength(2)]
        public string? SectorCode { get; set; }
        [Column("Server Name")]
        [StringLength(50)]
        public string? ServerName { get; set; }
        [Column("Shipper Telephone No")]
        [StringLength(50)]
        public string? ShipperTelephoneNo { get; set; }
        [Column("Site Code")]
        [StringLength(20)]
        public string? SiteCode { get; set; }
        [Column("Special Instruction")]
        [StringLength(2000)]
        public string? SpecialInstruction { get; set; }
        [Column("State Or Province")]
        [StringLength(50)]
        public string? StateOrProvince { get; set; }
        [Column("Sun Lunch From Time")]
        [StringLength(5)]
        [Unicode(false)]
        public string? SunLunchFromTime { get; set; }
        [Column("Sun Lunch To Time")]
        [StringLength(5)]
        [Unicode(false)]
        public string? SunLunchToTime { get; set; }
        [Column("Sun Work From Time")]
        [StringLength(5)]
        [Unicode(false)]
        public string? SunWorkFromTime { get; set; }
        [Column("Sun Work To Time")]
        [StringLength(5)]
        [Unicode(false)]
        public string? SunWorkToTime { get; set; }
        [Column("Tax ID")]
        [StringLength(20)]
        public string? TaxId { get; set; }
        [StringLength(30)]
        public string? Telephone { get; set; }
        [Column("Telephone 1")]
        [StringLength(30)]
        public string? Telephone1 { get; set; }
        [Column("Telephone 2")]
        [StringLength(30)]
        public string? Telephone2 { get; set; }
        [Column("Telephone 3")]
        [StringLength(30)]
        public string? Telephone3 { get; set; }
        [StringLength(10)]
        public string? Telex { get; set; }
        [Column("Term Code")]
        [StringLength(3)]
        public string? TermCode { get; set; }
        [Column("Title 1")]
        [StringLength(50)]
        public string? Title1 { get; set; }
        [Column("Title 2")]
        [StringLength(50)]
        public string? Title2 { get; set; }
        [Column("Title 3")]
        [StringLength(50)]
        public string? Title3 { get; set; }
        [Column("Tradenet Address 1")]
        [StringLength(30)]
        public string? TradenetAddress1 { get; set; }
        [Column("Tradenet Address 2")]
        [StringLength(30)]
        public string? TradenetAddress2 { get; set; }
        [Column("Tradenet Name 1")]
        [StringLength(30)]
        public string? TradenetName1 { get; set; }
        [Column("Tradenet Name 2")]
        [StringLength(30)]
        public string? TradenetName2 { get; set; }
        [Column("Vat Code")]
        [StringLength(10)]
        public string? VatCode { get; set; }
        [Column("Vendor Request By")]
        [StringLength(50)]
        public string? VendorRequestBy { get; set; }
        [Column("Warehouse Code")]
        [StringLength(6)]
        public string? WarehouseCode { get; set; }
        [Column("Web Site")]
        [StringLength(50)]
        public string? WebSite { get; set; }
        [Column("Week Lunch From Time")]
        [StringLength(5)]
        [Unicode(false)]
        public string? WeekLunchFromTime { get; set; }
        [Column("Week Lunch To Time")]
        [StringLength(5)]
        [Unicode(false)]
        public string? WeekLunchToTime { get; set; }
        [Column("Week Work From Time")]
        [StringLength(5)]
        [Unicode(false)]
        public string? WeekWorkFromTime { get; set; }
        [Column("Week Work To Time")]
        [StringLength(5)]
        [Unicode(false)]
        public string? WeekWorkToTime { get; set; }
        [Column("Work Station")]
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
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
        [StringLength(50)]
        public string Status { get; set; } = null!;
    }
}
