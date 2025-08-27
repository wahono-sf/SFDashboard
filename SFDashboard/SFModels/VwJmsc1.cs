using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwJmsc1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Subcert No")]
        [StringLength(45)]
        public string? SubcertNo { get; set; }
        [Column("Commodity Code")]
        [StringLength(50)]
        public string? CommodityCode { get; set; }
        [Column("Commodity Description")]
        [StringLength(50)]
        public string? CommodityDescription { get; set; }
        [Column("Consignee Address 1")]
        [StringLength(50)]
        public string? ConsigneeAddress1 { get; set; }
        [Column("Consignee Address 2")]
        [StringLength(50)]
        public string? ConsigneeAddress2 { get; set; }
        [Column("Consignee Address 3")]
        [StringLength(50)]
        public string? ConsigneeAddress3 { get; set; }
        [Column("Consignee Address 4")]
        [StringLength(50)]
        public string? ConsigneeAddress4 { get; set; }
        [Column("Consignee Code")]
        [StringLength(10)]
        public string? ConsigneeCode { get; set; }
        [Column("Consignee Name")]
        [StringLength(80)]
        public string? ConsigneeName { get; set; }
        [Column("Country Of Origin")]
        [StringLength(2)]
        public string? CountryOfOrigin { get; set; }
        [Column("Handling Agent Code")]
        [StringLength(10)]
        public string? HandlingAgentCode { get; set; }
        [Column("Handling Agent Cr No")]
        [StringLength(30)]
        public string? HandlingAgentCrNo { get; set; }
        [Column("Handling Agent Name")]
        [StringLength(80)]
        public string? HandlingAgentName { get; set; }
        [Column("Handling Agent Tax No")]
        [StringLength(20)]
        public string? HandlingAgentTaxNo { get; set; }
        [Column("Incoterms Code")]
        [StringLength(3)]
        public string? IncotermsCode { get; set; }
        [Column("Job No")]
        [StringLength(20)]
        public string? JobNo { get; set; }
        [Column("Job Type")]
        [StringLength(10)]
        public string? JobType { get; set; }
        [Column("Mode Of Transport")]
        [StringLength(1)]
        public string? ModeOfTransport { get; set; }
        [Column("Permit No")]
        [StringLength(50)]
        public string? PermitNo { get; set; }
        [StringLength(50)]
        public string? Reference { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Shipper Address 1")]
        [StringLength(50)]
        public string? ShipperAddress1 { get; set; }
        [Column("Shipper Address 2")]
        [StringLength(50)]
        public string? ShipperAddress2 { get; set; }
        [Column("Shipper Address 3")]
        [StringLength(50)]
        public string? ShipperAddress3 { get; set; }
        [Column("Shipper Address 4")]
        [StringLength(50)]
        public string? ShipperAddress4 { get; set; }
        [Column("Shipper Cr No")]
        [StringLength(30)]
        public string? ShipperCrNo { get; set; }
        [Column("Shipper Code")]
        [StringLength(10)]
        public string? ShipperCode { get; set; }
        [Column("Shipper Name")]
        [StringLength(80)]
        public string? ShipperName { get; set; }
        [Column("Supplier Address 1")]
        [StringLength(50)]
        public string? SupplierAddress1 { get; set; }
        [Column("Supplier Address 2")]
        [StringLength(50)]
        public string? SupplierAddress2 { get; set; }
        [Column("Supplier Address 3")]
        [StringLength(50)]
        public string? SupplierAddress3 { get; set; }
        [Column("Supplier Address 4")]
        [StringLength(50)]
        public string? SupplierAddress4 { get; set; }
        [Column("Supplier Cr No")]
        [StringLength(30)]
        public string? SupplierCrNo { get; set; }
        [Column("Supplier Code")]
        [StringLength(10)]
        public string? SupplierCode { get; set; }
        [Column("Supplier Name")]
        [StringLength(80)]
        public string? SupplierName { get; set; }
        [Column("Total Pcs")]
        public int? TotalPcs { get; set; }
        [Column("Uom Code")]
        [StringLength(50)]
        public string? UomCode { get; set; }
        [Column("Uom Description")]
        [StringLength(50)]
        public string? UomDescription { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Created By")]
        [StringLength(50)]
        public string? CreatedBy { get; set; }
        [Column("Created At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CreatedAt { get; set; }
        [Column("Updated By")]
        [StringLength(50)]
        public string? UpdatedBy { get; set; }
        [Column("Updated At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? UpdatedAt { get; set; }
        [StringLength(3)]
        public string? Status { get; set; }
    }
}
