using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("jmsc1")]
    public partial class Jmsc1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(45)]
        public string? SubcertNo { get; set; }
        [StringLength(50)]
        public string? CommodityCode { get; set; }
        [StringLength(50)]
        public string? CommodityDescription { get; set; }
        [StringLength(50)]
        public string? ConsigneeAddress1 { get; set; }
        [StringLength(50)]
        public string? ConsigneeAddress2 { get; set; }
        [StringLength(50)]
        public string? ConsigneeAddress3 { get; set; }
        [StringLength(50)]
        public string? ConsigneeAddress4 { get; set; }
        [StringLength(10)]
        public string? ConsigneeCode { get; set; }
        [StringLength(80)]
        public string? ConsigneeName { get; set; }
        [StringLength(2)]
        public string? CountryOfOrigin { get; set; }
        [StringLength(10)]
        public string? HandlingAgentCode { get; set; }
        [StringLength(30)]
        public string? HandlingAgentCrNo { get; set; }
        [StringLength(80)]
        public string? HandlingAgentName { get; set; }
        [StringLength(20)]
        public string? HandlingAgentTaxNo { get; set; }
        [StringLength(3)]
        public string? IncotermsCode { get; set; }
        [StringLength(20)]
        public string? JobNo { get; set; }
        [StringLength(1)]
        public string? ModeOfTransport { get; set; }
        [StringLength(50)]
        public string? PermitNo { get; set; }
        [StringLength(50)]
        public string? Reference { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(50)]
        public string? ShipperAddress1 { get; set; }
        [StringLength(50)]
        public string? ShipperAddress2 { get; set; }
        [StringLength(50)]
        public string? ShipperAddress3 { get; set; }
        [StringLength(50)]
        public string? ShipperAddress4 { get; set; }
        [StringLength(30)]
        public string? ShipperCrNo { get; set; }
        [StringLength(10)]
        public string? ShipperCode { get; set; }
        [StringLength(80)]
        public string? ShipperName { get; set; }
        [StringLength(50)]
        public string? SupplierAddress1 { get; set; }
        [StringLength(50)]
        public string? SupplierAddress2 { get; set; }
        [StringLength(50)]
        public string? SupplierAddress3 { get; set; }
        [StringLength(50)]
        public string? SupplierAddress4 { get; set; }
        [StringLength(30)]
        public string? SupplierCrNo { get; set; }
        [StringLength(10)]
        public string? SupplierCode { get; set; }
        [StringLength(80)]
        public string? SupplierName { get; set; }
        public int? TotalPcs { get; set; }
        [StringLength(50)]
        public string? UomCode { get; set; }
        [StringLength(50)]
        public string? UomDescription { get; set; }
        [StringLength(3)]
        public string? StatusCode { get; set; }
        [StringLength(50)]
        public string? CreateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateDateTime { get; set; }
        [StringLength(50)]
        public string? UpdateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdateDateTime { get; set; }
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
    }
}
