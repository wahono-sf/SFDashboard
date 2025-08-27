using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwRcab1
    {
        [Column("Business Party Code")]
        [StringLength(10)]
        public string? BusinessPartyCode { get; set; }
        [Column("Line Item No")]
        public short? LineItemNo { get; set; }
        [Column("Address 1")]
        [StringLength(45)]
        public string? Address1 { get; set; }
        [Column("Address 2")]
        [StringLength(45)]
        public string? Address2 { get; set; }
        [Column("Address 3")]
        [StringLength(45)]
        public string? Address3 { get; set; }
        [Column("Address 4")]
        [StringLength(45)]
        public string? Address4 { get; set; }
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
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Business Party Name")]
        [StringLength(80)]
        public string? BusinessPartyName { get; set; }
        [Column("Business Type")]
        [StringLength(10)]
        public string? BusinessType { get; set; }
        [Column("City Code")]
        [StringLength(3)]
        public string? CityCode { get; set; }
        [Column("Company Profile")]
        [StringLength(1000)]
        public string? CompanyProfile { get; set; }
        [Column("Contact Name")]
        [StringLength(50)]
        public string? ContactName { get; set; }
        [Column("Country Code")]
        [StringLength(2)]
        public string? CountryCode { get; set; }
        [Column("Credit Status Code")]
        [StringLength(50)]
        public string? CreditStatusCode { get; set; }
        [Column("Cr No")]
        [StringLength(30)]
        public string? CrNo { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Customer Code")]
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [Column("Customer Short Code")]
        [StringLength(10)]
        public string? CustomerShortCode { get; set; }
        [Column("Delivery To Address 1")]
        [StringLength(45)]
        public string? DeliveryToAddress1 { get; set; }
        [Column("Delivery To Address 2")]
        [StringLength(45)]
        public string? DeliveryToAddress2 { get; set; }
        [Column("Delivery To Address 3")]
        [StringLength(45)]
        public string? DeliveryToAddress3 { get; set; }
        [Column("Delivery To Address 4")]
        [StringLength(45)]
        public string? DeliveryToAddress4 { get; set; }
        [Column("Delivery To Name")]
        [StringLength(45)]
        public string? DeliveryToName { get; set; }
        [Column("District Code")]
        [StringLength(5)]
        public string? DistrictCode { get; set; }
        [Column("Division Code")]
        [StringLength(10)]
        public string? DivisionCode { get; set; }
        [Column("Company Email")]
        [StringLength(50)]
        public string? CompanyEmail { get; set; }
        [StringLength(50)]
        public string? Email { get; set; }
        [StringLength(50)]
        public string? Facebook { get; set; }
        [Column("Company Fax")]
        [StringLength(30)]
        public string? CompanyFax { get; set; }
        [StringLength(30)]
        public string? Fax { get; set; }
        [Column("Fwb Acc Code")]
        [StringLength(10)]
        public string? FwbAccCode { get; set; }
        [Column("Fwb Address")]
        [StringLength(50)]
        public string? FwbAddress { get; set; }
        [Column("Fwb Name")]
        [StringLength(50)]
        public string? FwbName { get; set; }
        [Column("Fwb Place")]
        [StringLength(50)]
        public string? FwbPlace { get; set; }
        [Column("Fwb State")]
        [StringLength(50)]
        public string? FwbState { get; set; }
        [StringLength(30)]
        public string? Handphone { get; set; }
        [Column("Local Name")]
        [StringLength(255)]
        public string? LocalName { get; set; }
        [Column("Name Card", TypeName = "image")]
        public byte[]? NameCard { get; set; }
        [Column("Party Short Code")]
        [StringLength(10)]
        public string? PartyShortCode { get; set; }
        [Column("Party Type")]
        [StringLength(3)]
        public string? PartyType { get; set; }
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
        [Column("Pay Type")]
        [StringLength(50)]
        public string? PayType { get; set; }
        [Column("Postal Code")]
        [StringLength(10)]
        public string? PostalCode { get; set; }
        [Column("Psa Acc Code")]
        [StringLength(10)]
        public string? PsaAccCode { get; set; }
        [StringLength(1000)]
        public string? Remark { get; set; }
        [Column("Salesman Code")]
        [StringLength(10)]
        public string? SalesmanCode { get; set; }
        [Column("Site Code")]
        [StringLength(20)]
        public string? SiteCode { get; set; }
        [StringLength(50)]
        public string? Skype { get; set; }
        [Column("Special Instruction")]
        [StringLength(2000)]
        public string? SpecialInstruction { get; set; }
        [Column("Company Telephone")]
        [StringLength(30)]
        public string? CompanyTelephone { get; set; }
        [StringLength(30)]
        public string? Telephone { get; set; }
        [StringLength(10)]
        public string? Telex { get; set; }
        [StringLength(20)]
        public string? Title { get; set; }
        [Column("Term Code")]
        [StringLength(3)]
        public string? TermCode { get; set; }
        [Column("Vendor Code")]
        [StringLength(10)]
        public string? VendorCode { get; set; }
        [Column("Web Site")]
        [StringLength(50)]
        public string? WebSite { get; set; }
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
