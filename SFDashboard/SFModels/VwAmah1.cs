using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwAmah1
    {
        [Column("Awb No")]
        [StringLength(20)]
        public string AwbNo { get; set; } = null!;
        [Column("Address 01")]
        [StringLength(45)]
        public string? Address01 { get; set; }
        [Column("Address 02")]
        [StringLength(45)]
        public string? Address02 { get; set; }
        [Column("Address 03")]
        [StringLength(45)]
        public string? Address03 { get; set; }
        [Column("Address 04")]
        [StringLength(45)]
        public string? Address04 { get; set; }
        [Column("Adhoc Flag")]
        [StringLength(1)]
        public string? AdhocFlag { get; set; }
        [Column("Airline Code")]
        [StringLength(3)]
        public string? AirlineCode { get; set; }
        [Column("Airline ID")]
        [StringLength(2)]
        public string? AirlineId { get; set; }
        [Column("Amend Flag")]
        [StringLength(1)]
        public string? AmendFlag { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Average Cost Amt", TypeName = "decimal(13, 2)")]
        public decimal? AverageCostAmt { get; set; }
        [Column("Buy Agent Code")]
        [StringLength(10)]
        public string? BuyAgentCode { get; set; }
        [Column("Buy Charge Weight", TypeName = "decimal(13, 4)")]
        public decimal? BuyChargeWeight { get; set; }
        [Column("Buy Rate", TypeName = "decimal(13, 3)")]
        public decimal? BuyRate { get; set; }
        [Column("Buy Total Amt", TypeName = "decimal(13, 2)")]
        public decimal? BuyTotalAmt { get; set; }
        [Column("Charge Weight", TypeName = "decimal(13, 4)")]
        public decimal? ChargeWeight { get; set; }
        [Column("Commodity Code")]
        [StringLength(10)]
        public string? CommodityCode { get; set; }
        [Column("Commodity Description")]
        [StringLength(50)]
        public string? CommodityDescription { get; set; }
        [Column("Dest Code")]
        [StringLength(3)]
        public string? DestCode { get; set; }
        [Column("Flight Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? FlightDate { get; set; }
        [Column("Flight No")]
        [StringLength(6)]
        public string? FlightNo { get; set; }
        [Column("Gross Weight", TypeName = "decimal(13, 4)")]
        public decimal? GrossWeight { get; set; }
        [Column("Iata Rate", TypeName = "decimal(13, 3)")]
        public decimal? IataRate { get; set; }
        [Column("Iata Total Amt", TypeName = "decimal(13, 2)")]
        public decimal? IataTotalAmt { get; set; }
        [Column("Issued By")]
        [StringLength(50)]
        public string? IssuedBy { get; set; }
        [Column("Kg Lb Flag")]
        [StringLength(1)]
        public string? KgLbFlag { get; set; }
        [Column("Last Print Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastPrintDate { get; set; }
        [Column("Login Name")]
        [StringLength(20)]
        public string? LoginName { get; set; }
        [Column("Negotiate By")]
        [StringLength(50)]
        public string? NegotiateBy { get; set; }
        [Column("Negotiate Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? NegotiateDate { get; set; }
        [Column("Negotiate Type")]
        [StringLength(1)]
        public string? NegotiateType { get; set; }
        [Column("Negotiate With")]
        [StringLength(50)]
        public string? NegotiateWith { get; set; }
        [Column("No Of Negotiate Time")]
        public short? NoOfNegotiateTime { get; set; }
        [Column("Over Rate", TypeName = "decimal(13, 3)")]
        public decimal? OverRate { get; set; }
        [Column("Over Weight", TypeName = "decimal(13, 4)")]
        public decimal? OverWeight { get; set; }
        public int? Pcs { get; set; }
        [Column("Print Flag")]
        [StringLength(1)]
        public string? PrintFlag { get; set; }
        [Column("Rate Class Code")]
        [StringLength(1)]
        public string? RateClassCode { get; set; }
        [Column("Rate Type")]
        [StringLength(1)]
        public string? RateType { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Salesman Code")]
        [StringLength(10)]
        public string? SalesmanCode { get; set; }
        [Column("Sell Charge Weight", TypeName = "decimal(13, 4)")]
        public decimal? SellChargeWeight { get; set; }
        [Column("Sell Rate", TypeName = "decimal(13, 3)")]
        public decimal? SellRate { get; set; }
        [Column("Sell Total Amt", TypeName = "decimal(13, 2)")]
        public decimal? SellTotalAmt { get; set; }
        [Column("Shipper Code")]
        [StringLength(10)]
        public string? ShipperCode { get; set; }
        [Column("Shipper Name")]
        [StringLength(80)]
        public string? ShipperName { get; set; }
        [Column("Speciallnstr 01")]
        [StringLength(64)]
        public string? Speciallnstr01 { get; set; }
        [Column("Speciallnstr 02")]
        [StringLength(64)]
        public string? Speciallnstr02 { get; set; }
        [Column("Speciallnstr 03")]
        [StringLength(64)]
        public string? Speciallnstr03 { get; set; }
        [Column("Speciallnstr 04")]
        [StringLength(64)]
        public string? Speciallnstr04 { get; set; }
        [Column("Speciallnstr 05")]
        [StringLength(64)]
        public string? Speciallnstr05 { get; set; }
        [Column("Spill Rate", TypeName = "decimal(13, 3)")]
        public decimal? SpillRate { get; set; }
        [Column("Spill Weight", TypeName = "decimal(13, 4)")]
        public decimal? SpillWeight { get; set; }
        [Column("Terminal No")]
        [StringLength(3)]
        public string? TerminalNo { get; set; }
        [Column("Total Volume", TypeName = "decimal(13, 4)")]
        public decimal? TotalVolume { get; set; }
        [Column("Total Weight", TypeName = "decimal(13, 4)")]
        public decimal? TotalWeight { get; set; }
        [Column("Update Status Code")]
        [StringLength(1)]
        public string? UpdateStatusCode { get; set; }
        [Column("Created By")]
        [StringLength(50)]
        public string CreatedBy { get; set; } = null!;
        [Column("Created At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CreatedAt { get; set; }
        [Column("Updated By")]
        [StringLength(50)]
        public string UpdatedBy { get; set; } = null!;
        [Column("Updated At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? UpdatedAt { get; set; }
        [StringLength(3)]
        public string Status { get; set; } = null!;
    }
}
