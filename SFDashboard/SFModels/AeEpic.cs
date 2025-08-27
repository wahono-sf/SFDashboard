using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class AeEpic
    {
        [Column("First Flight Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? FirstFlightDate { get; set; }
        [Column("Gross Weight", TypeName = "decimal(13, 4)")]
        public decimal? GrossWeight { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? SellChargeWeight { get; set; }
        [Column("Buy Rate", TypeName = "decimal(13, 3)")]
        public decimal? BuyRate { get; set; }
        [Column("Weight Charge Pp Amt", TypeName = "decimal(13, 4)")]
        public decimal? WeightChargePpAmt { get; set; }
        [Column("Value Charge Pp Amt", TypeName = "decimal(13, 2)")]
        public decimal? ValueChargePpAmt { get; set; }
        [Column("Carrier Pp Amt", TypeName = "decimal(13, 2)")]
        public decimal? CarrierPpAmt { get; set; }
        [Column("Weight Charge Cc Amt", TypeName = "decimal(13, 4)")]
        public decimal? WeightChargeCcAmt { get; set; }
        [Column("Value Charge Cc Amt", TypeName = "decimal(13, 2)")]
        public decimal? ValueChargeCcAmt { get; set; }
        [Column("Agent Cc Amt", TypeName = "decimal(13, 2)")]
        public decimal? AgentCcAmt { get; set; }
        [Column("Total Cc Amt", TypeName = "decimal(13, 2)")]
        public decimal? TotalCcAmt { get; set; }
        [Column("Total Pp Amt", TypeName = "decimal(13, 2)")]
        public decimal? TotalPpAmt { get; set; }
        [StringLength(3)]
        public string? Status { get; set; }
        [Column("Awb No")]
        [StringLength(20)]
        public string AwbNo { get; set; } = null!;
        [Column("Shipment Type")]
        [StringLength(1)]
        public string? ShipmentType { get; set; }
    }
}
