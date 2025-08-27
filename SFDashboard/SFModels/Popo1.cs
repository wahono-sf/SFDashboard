using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("popo1")]
    public partial class Popo1
    {
        [Key]
        public int TrxNo { get; set; }
        [Column("PONo")]
        [StringLength(50)]
        public string? Pono { get; set; }
        [StringLength(100)]
        public string? Address1 { get; set; }
        [StringLength(100)]
        public string? Address2 { get; set; }
        [StringLength(100)]
        public string? Address3 { get; set; }
        [StringLength(100)]
        public string? Address4 { get; set; }
        [StringLength(3)]
        public string? City { get; set; }
        [StringLength(50)]
        public string? CompanyName { get; set; }
        [StringLength(50)]
        public string? ContactFirstName { get; set; }
        [StringLength(50)]
        public string? ContactLastName { get; set; }
        [StringLength(50)]
        public string? ContactPerson { get; set; }
        [StringLength(2)]
        public string? Country { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DeliveryDate { get; set; }
        [StringLength(50)]
        public string? Email { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Etd { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Eta { get; set; }
        [StringLength(50)]
        public string? Fax { get; set; }
        [StringLength(5)]
        public string? IncoTerm { get; set; }
        [StringLength(3)]
        public string? IncoTermCity { get; set; }
        [StringLength(50)]
        public string? InvoiceNo { get; set; }
        [StringLength(10)]
        public string? ModeOfTransport { get; set; }
        [Column("PartialPOFlag")]
        [StringLength(1)]
        public string? PartialPoflag { get; set; }
        [StringLength(50)]
        public string? Phone { get; set; }
        [Column("POAmt", TypeName = "decimal(13, 2)")]
        public decimal? Poamt { get; set; }
        [Column("POCurrCode")]
        [StringLength(3)]
        public string? PocurrCode { get; set; }
        [Column("PODescription")]
        [StringLength(80)]
        public string? Podescription { get; set; }
        [Column("POIssueDate", TypeName = "datetime")]
        public DateTime? PoissueDate { get; set; }
        [Column("POLine")]
        public int? Poline { get; set; }
        [StringLength(5)]
        public string? PortOfLoadingCode { get; set; }
        [StringLength(5)]
        public string? PortOfDischargeCode { get; set; }
        [Column("POStatus")]
        [StringLength(20)]
        public string? Postatus { get; set; }
        [StringLength(50)]
        public string? PostalCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RequiredDate { get; set; }
        [StringLength(100)]
        public string? ShipToName { get; set; }
        [StringLength(100)]
        public string? ShipToAddress1 { get; set; }
        [StringLength(100)]
        public string? ShipToAddress2 { get; set; }
        [StringLength(100)]
        public string? ShipToAddress3 { get; set; }
        [StringLength(100)]
        public string? ShipToAddress4 { get; set; }
        [StringLength(50)]
        public string? ShipToEmail { get; set; }
        [StringLength(30)]
        public string? ShipToFax { get; set; }
        [StringLength(30)]
        public string? ShipToPhone { get; set; }
        [StringLength(50)]
        public string? State { get; set; }
        [StringLength(50)]
        public string? SupplierName { get; set; }
        [StringLength(50)]
        public string? SupplierFirstName { get; set; }
        [StringLength(50)]
        public string? SupplierLastName { get; set; }
        [StringLength(50)]
        public string? SupplierAddr1 { get; set; }
        [StringLength(50)]
        public string? SupplierAddr2 { get; set; }
        [StringLength(50)]
        public string? SupplierAddr3 { get; set; }
        [StringLength(50)]
        public string? SupplierAddr4 { get; set; }
        [StringLength(3)]
        public string? SupplierCity { get; set; }
        [StringLength(2)]
        public string? SupplierCountry { get; set; }
        [StringLength(50)]
        public string? SupplierEmail { get; set; }
        [StringLength(50)]
        public string? SupplierFax { get; set; }
        [StringLength(50)]
        public string? SupplierPhone { get; set; }
    }
}
