using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwAebk3
    {
        [Column("Booking No")]
        [StringLength(15)]
        public string BookingNo { get; set; } = null!;
        [Column("Pickup No")]
        public int PickupNo { get; set; }
        [Column("Delivery Agent Code")]
        [StringLength(10)]
        public string? DeliveryAgentCode { get; set; }
        [Column("Delivery Agent Name")]
        [StringLength(80)]
        public string? DeliveryAgentName { get; set; }
        [Column("Delivery Party Code")]
        [StringLength(10)]
        public string? DeliveryPartyCode { get; set; }
        [Column("Delivery Party Name")]
        [StringLength(80)]
        public string? DeliveryPartyName { get; set; }
        [Column("Delivery Address 1")]
        [StringLength(45)]
        public string? DeliveryAddress1 { get; set; }
        [Column("Delivery Address 2")]
        [StringLength(45)]
        public string? DeliveryAddress2 { get; set; }
        [Column("Delivery Address 3")]
        [StringLength(45)]
        public string? DeliveryAddress3 { get; set; }
        [Column("Delivery Address 4")]
        [StringLength(45)]
        public string? DeliveryAddress4 { get; set; }
        [Column("Gross Weight", TypeName = "decimal(18, 0)")]
        public decimal? GrossWeight { get; set; }
        [Column("Handling Instruction 1")]
        [StringLength(50)]
        public string? HandlingInstruction1 { get; set; }
        [Column("Handling Instruction 2")]
        [StringLength(50)]
        public string? HandlingInstruction2 { get; set; }
        [Column("Handling Instruction 3")]
        [StringLength(50)]
        public string? HandlingInstruction3 { get; set; }
        [Column("Handling Instruction 4")]
        [StringLength(50)]
        public string? HandlingInstruction4 { get; set; }
        public int? Pcs { get; set; }
        [Column("Pcs Unit")]
        [StringLength(3)]
        public string? PcsUnit { get; set; }
        [StringLength(16)]
        [Unicode(false)]
        public string? PickupDateTime { get; set; }
        [Column("Pickup Party Code")]
        [StringLength(10)]
        public string? PickupPartyCode { get; set; }
        [Column("Pickup Party Name")]
        [StringLength(80)]
        public string? PickupPartyName { get; set; }
        [Column("Pickup Address 1")]
        [StringLength(45)]
        public string? PickupAddress1 { get; set; }
        [Column("Pickup Address 2")]
        [StringLength(45)]
        public string? PickupAddress2 { get; set; }
        [Column("Pickup Address 3")]
        [StringLength(45)]
        public string? PickupAddress3 { get; set; }
        [Column("Pickup Address 4")]
        [StringLength(45)]
        public string? PickupAddress4 { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(3)]
        public string? Status { get; set; }
    }
}
