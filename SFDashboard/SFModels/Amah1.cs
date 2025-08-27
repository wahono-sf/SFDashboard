using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("amah1")]
    public partial class Amah1
    {
        [Key]
        [StringLength(20)]
        public string AwbNo { get; set; } = null!;
        [StringLength(50)]
        public string? Address01 { get; set; }
        [StringLength(50)]
        public string? Address02 { get; set; }
        [StringLength(50)]
        public string? Address03 { get; set; }
        [StringLength(50)]
        public string? Address04 { get; set; }
        [StringLength(1)]
        public string? AdhocFlag { get; set; }
        [StringLength(3)]
        public string? AirlineCode { get; set; }
        [Column("AirlineID")]
        [StringLength(2)]
        public string? AirlineId { get; set; }
        [StringLength(1)]
        public string? AmendFlag { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? AverageCostAmt { get; set; }
        [StringLength(10)]
        public string? BuyAgentCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? BuyChargeWeight { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? BuyRate { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? BuyTotalAmt { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? ChargeWeight { get; set; }
        [StringLength(50)]
        public string? CommodityCode { get; set; }
        [StringLength(50)]
        public string? CommodityDescription { get; set; }
        [StringLength(3)]
        public string? DestCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FlightDate { get; set; }
        [StringLength(6)]
        public string? FlightNo { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? GrossWeight { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? IataRate { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? IataTotalAmt { get; set; }
        [StringLength(50)]
        public string? IssuedBy { get; set; }
        [StringLength(1)]
        public string? KgLbFlag { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastPrintDate { get; set; }
        [StringLength(20)]
        public string? LoginName { get; set; }
        [StringLength(50)]
        public string? NegotiateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NegotiateDate { get; set; }
        [StringLength(1)]
        public string? NegotiateType { get; set; }
        [StringLength(50)]
        public string? NegotiateWith { get; set; }
        public short? NoOfNegotiateTime { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? OverRate { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? OverWeight { get; set; }
        public int? Pcs { get; set; }
        [StringLength(1)]
        public string? PrintFlag { get; set; }
        [StringLength(1)]
        public string? RateClassCode { get; set; }
        [StringLength(1)]
        public string? RateType { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(10)]
        public string? SalesmanCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? SellChargeWeight { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? SellRate { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? SellTotalAmt { get; set; }
        [StringLength(10)]
        public string? ShipperCode { get; set; }
        [StringLength(80)]
        public string? ShipperName { get; set; }
        [StringLength(64)]
        public string? Speciallnstr01 { get; set; }
        [StringLength(64)]
        public string? Speciallnstr02 { get; set; }
        [StringLength(64)]
        public string? Speciallnstr03 { get; set; }
        [StringLength(64)]
        public string? Speciallnstr04 { get; set; }
        [StringLength(64)]
        public string? Speciallnstr05 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? SpillRate { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? SpillWeight { get; set; }
        [StringLength(3)]
        public string? TerminalNo { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? TotalVolume { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? TotalWeight { get; set; }
        [StringLength(1)]
        public string? UpdateStatusCode { get; set; }
        [StringLength(3)]
        public string StatusCode { get; set; } = null!;
        [StringLength(50)]
        public string CreateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CreateDateTime { get; set; }
        [StringLength(50)]
        public string UpdateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime UpdateDateTime { get; set; }
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
    }
}
