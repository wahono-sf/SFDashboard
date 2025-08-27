using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("sebl7")]
    public partial class Sebl7
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public int LineItemNo { get; set; }
        [StringLength(30)]
        public string? OblNo { get; set; }
        [StringLength(10)]
        public string? ConsigneeCode { get; set; }
        [StringLength(80)]
        public string? ConsigneeName { get; set; }
        [StringLength(50)]
        public string? ConsigneeAddress1 { get; set; }
        [StringLength(50)]
        public string? ConsigneeAddress2 { get; set; }
        [StringLength(50)]
        public string? ConsigneeAddress3 { get; set; }
        [StringLength(50)]
        public string? ConsigneeAddress4 { get; set; }
        [StringLength(10)]
        public string? DeliveryAgentCode { get; set; }
        [StringLength(80)]
        public string? DeliveryAgentName { get; set; }
        [StringLength(50)]
        public string? DeliveryAgentAddress1 { get; set; }
        [StringLength(50)]
        public string? DeliveryAgentAddress2 { get; set; }
        [StringLength(50)]
        public string? DeliveryAgentAddress3 { get; set; }
        [StringLength(50)]
        public string? DeliveryAgentAddress4 { get; set; }
        [StringLength(10)]
        public string? ShipperCode { get; set; }
        [StringLength(80)]
        public string? ShipperName { get; set; }
        [StringLength(50)]
        public string? ShipperAddress1 { get; set; }
        [StringLength(50)]
        public string? ShipperAddress2 { get; set; }
        [StringLength(50)]
        public string? ShipperAddress3 { get; set; }
        [StringLength(50)]
        public string? ShipperAddress4 { get; set; }
    }
}
