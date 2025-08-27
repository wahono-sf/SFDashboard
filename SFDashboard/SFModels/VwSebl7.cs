using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSebl7
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Line Item No")]
        public int LineItemNo { get; set; }
        [Column("OBL No")]
        [StringLength(30)]
        public string? OblNo { get; set; }
        [Column("Consignee Code")]
        [StringLength(10)]
        public string? ConsigneeCode { get; set; }
        [Column("Consignee Name")]
        [StringLength(80)]
        public string? ConsigneeName { get; set; }
        [Column("Consignee Address 1")]
        [StringLength(45)]
        public string? ConsigneeAddress1 { get; set; }
        [Column("Consignee Address 2")]
        [StringLength(45)]
        public string? ConsigneeAddress2 { get; set; }
        [Column("Consignee Address 3")]
        [StringLength(45)]
        public string? ConsigneeAddress3 { get; set; }
        [Column("Consignee Address 4")]
        [StringLength(45)]
        public string? ConsigneeAddress4 { get; set; }
        [Column("Delivery Agent Code")]
        [StringLength(10)]
        public string? DeliveryAgentCode { get; set; }
        [Column("Delivery Agent Name")]
        [StringLength(80)]
        public string? DeliveryAgentName { get; set; }
        [Column("Delivery Agent Address 1")]
        [StringLength(45)]
        public string? DeliveryAgentAddress1 { get; set; }
        [Column("Delivery Agent Address 2")]
        [StringLength(45)]
        public string? DeliveryAgentAddress2 { get; set; }
        [Column("Delivery Agent Address 3")]
        [StringLength(45)]
        public string? DeliveryAgentAddress3 { get; set; }
        [Column("Delivery Agent Address 4")]
        [StringLength(45)]
        public string? DeliveryAgentAddress4 { get; set; }
        [Column("Shipper Code")]
        [StringLength(10)]
        public string? ShipperCode { get; set; }
        [Column("Shipper Name")]
        [StringLength(80)]
        public string? ShipperName { get; set; }
        [Column("Shipper Address 1")]
        [StringLength(45)]
        public string? ShipperAddress1 { get; set; }
        [Column("Shipper Address 2")]
        [StringLength(45)]
        public string? ShipperAddress2 { get; set; }
        [Column("Shipper Address 3")]
        [StringLength(45)]
        public string? ShipperAddress3 { get; set; }
        [Column("Shipper Address 4")]
        [StringLength(45)]
        public string? ShipperAddress4 { get; set; }
    }
}
