using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("aebk3")]
    public partial class Aebk3
    {
        [Key]
        [StringLength(15)]
        public string BookingNo { get; set; } = null!;
        [Key]
        public int PickupNo { get; set; }
        [StringLength(10)]
        public string? DeliveryAgentCode { get; set; }
        [StringLength(80)]
        public string? DeliveryAgentName { get; set; }
        [StringLength(10)]
        public string? DeliveryPartyCode { get; set; }
        [StringLength(80)]
        public string? DeliveryPartyName { get; set; }
        [StringLength(50)]
        public string? DeliveryAddress1 { get; set; }
        [StringLength(50)]
        public string? DeliveryAddress2 { get; set; }
        [StringLength(50)]
        public string? DeliveryAddress3 { get; set; }
        [StringLength(50)]
        public string? DeliveryAddress4 { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? GrossWeight { get; set; }
        [StringLength(50)]
        public string? HandlingInstruction1 { get; set; }
        [StringLength(50)]
        public string? HandlingInstruction2 { get; set; }
        [StringLength(50)]
        public string? HandlingInstruction3 { get; set; }
        [StringLength(50)]
        public string? HandlingInstruction4 { get; set; }
        public int? Pcs { get; set; }
        [StringLength(3)]
        public string? PcsUnit { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PickupDateTime { get; set; }
        [StringLength(10)]
        public string? PickupPartyCode { get; set; }
        [StringLength(80)]
        public string? PickupPartyName { get; set; }
        [StringLength(50)]
        public string? PickupAddress1 { get; set; }
        [StringLength(50)]
        public string? PickupAddress2 { get; set; }
        [StringLength(50)]
        public string? PickupAddress3 { get; set; }
        [StringLength(50)]
        public string? PickupAddress4 { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(3)]
        public string? StatusCode { get; set; }
    }
}
