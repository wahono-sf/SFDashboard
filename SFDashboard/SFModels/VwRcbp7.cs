using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwRcbp7
    {
        [Column("Business Party Code")]
        [StringLength(10)]
        public string BusinessPartyCode { get; set; } = null!;
        [Column("Line Item No")]
        public int LineItemNo { get; set; }
        [Column("Delivery Code")]
        [StringLength(10)]
        public string? DeliveryCode { get; set; }
        [Column("Delivery Name")]
        [StringLength(80)]
        public string? DeliveryName { get; set; }
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
    }
}
