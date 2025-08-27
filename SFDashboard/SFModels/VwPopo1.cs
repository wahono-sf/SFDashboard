using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwPopo1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Po No")]
        [StringLength(50)]
        public string? PoNo { get; set; }
        [Column("Address 1")]
        [StringLength(100)]
        public string? Address1 { get; set; }
        [Column("Address 2")]
        [StringLength(100)]
        public string? Address2 { get; set; }
        [Column("Address 3")]
        [StringLength(45)]
        public string? Address3 { get; set; }
        [Column("Address 4")]
        [StringLength(45)]
        public string? Address4 { get; set; }
        [StringLength(3)]
        public string? City { get; set; }
        [Column("Company Name")]
        [StringLength(50)]
        public string? CompanyName { get; set; }
        [Column("Contact First Name")]
        [StringLength(50)]
        public string? ContactFirstName { get; set; }
        [Column("Contact Last Name")]
        [StringLength(50)]
        public string? ContactLastName { get; set; }
        [Column("Contact Person")]
        [StringLength(50)]
        public string? ContactPerson { get; set; }
        [StringLength(2)]
        public string? Country { get; set; }
        [Column("ETA")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Eta { get; set; }
        [Column("ETD")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Etd { get; set; }
        [StringLength(50)]
        public string? Email { get; set; }
        [StringLength(50)]
        public string? Fax { get; set; }
        [Column("Inco Term")]
        [StringLength(5)]
        public string? IncoTerm { get; set; }
        [Column("Inco Term City")]
        [StringLength(3)]
        public string? IncoTermCity { get; set; }
        [Column("Invoice No")]
        [StringLength(50)]
        public string? InvoiceNo { get; set; }
        [Column("Mode Of Transport")]
        [StringLength(10)]
        public string? ModeOfTransport { get; set; }
        [Column("Partial PO Flag")]
        [StringLength(1)]
        public string? PartialPoFlag { get; set; }
        [StringLength(50)]
        public string? Phone { get; set; }
        [Column("PO Amt", TypeName = "decimal(13, 2)")]
        public decimal? PoAmt { get; set; }
        [Column("PO Curr Code")]
        [StringLength(3)]
        public string? PoCurrCode { get; set; }
        [Column("PO Description")]
        [StringLength(80)]
        public string? PoDescription { get; set; }
        [Column("PO Issue Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? PoIssueDate { get; set; }
        [Column("PO Line")]
        public int? PoLine { get; set; }
        [Column("Port Of Loading Code")]
        [StringLength(5)]
        public string? PortOfLoadingCode { get; set; }
        [Column("Port Of Discharge Code")]
        [StringLength(5)]
        public string? PortOfDischargeCode { get; set; }
        [Column("PO Status")]
        [StringLength(20)]
        public string? PoStatus { get; set; }
        [Column("Postal Code")]
        [StringLength(50)]
        public string? PostalCode { get; set; }
        [Column("Required Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? RequiredDate { get; set; }
        [Column("Ship To Address 1")]
        [StringLength(100)]
        public string? ShipToAddress1 { get; set; }
        [Column("Ship To Address 2")]
        [StringLength(100)]
        public string? ShipToAddress2 { get; set; }
        [Column("Ship To Address 3")]
        [StringLength(100)]
        public string? ShipToAddress3 { get; set; }
        [Column("Ship To Address 4")]
        [StringLength(100)]
        public string? ShipToAddress4 { get; set; }
        [Column("Ship To Email")]
        [StringLength(50)]
        public string? ShipToEmail { get; set; }
        [Column("Ship To Fax")]
        [StringLength(30)]
        public string? ShipToFax { get; set; }
        [Column("Ship To Name")]
        [StringLength(100)]
        public string? ShipToName { get; set; }
        [StringLength(50)]
        public string? State { get; set; }
        [Column("Supplier Name")]
        [StringLength(50)]
        public string? SupplierName { get; set; }
        [Column("Supplier First Name")]
        [StringLength(50)]
        public string? SupplierFirstName { get; set; }
        [Column("Supplier Last Name")]
        [StringLength(50)]
        public string? SupplierLastName { get; set; }
        [Column("Supplier Address 1")]
        [StringLength(45)]
        public string? SupplierAddress1 { get; set; }
        [Column("Supplier Address 2")]
        [StringLength(45)]
        public string? SupplierAddress2 { get; set; }
        [Column("Supplier Address 3")]
        [StringLength(45)]
        public string? SupplierAddress3 { get; set; }
        [Column("Supplier Address 4")]
        [StringLength(45)]
        public string? SupplierAddress4 { get; set; }
        [Column("Supplier City")]
        [StringLength(3)]
        public string? SupplierCity { get; set; }
        [Column("Supplier Country")]
        [StringLength(2)]
        public string? SupplierCountry { get; set; }
        [Column("Supplier Email")]
        [StringLength(50)]
        public string? SupplierEmail { get; set; }
        [Column("Supplier Fax")]
        [StringLength(50)]
        public string? SupplierFax { get; set; }
        [Column("Supplier Phone")]
        [StringLength(50)]
        public string? SupplierPhone { get; set; }
    }
}
