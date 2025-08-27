using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    [Table("omor2")]
    public partial class Omor2
    {
        [StringLength(16)]
        public string? ContrNo { get; set; }
        [StringLength(14)]
        public string? AmendNo { get; set; }
        [StringLength(1)]
        public string? AmendTermCode { get; set; }
        [StringLength(8)]
        public string? ClientCode { get; set; }
        [StringLength(15)]
        public string? ContactFaxNo { get; set; }
        [StringLength(15)]
        public string? ContactPhoneNo { get; set; }
        [StringLength(1)]
        public string? ContrType { get; set; }
        [StringLength(14)]
        public string? ContrVarNo { get; set; }
        [Column(TypeName = "decimal(16, 4)")]
        public decimal? ConverRate { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DatetimeAdded { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DatetimeChanged { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DatetimeContrEnd { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DatetimeContrStart { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DatetimeDelivery { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DatetimeLastRecv { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DatetimeTfer { get; set; }
        [StringLength(3)]
        public string? DeliveryTerm { get; set; }
        [StringLength(30)]
        public string? Email { get; set; }
        [StringLength(1)]
        public string? ExplosiveFlag { get; set; }
        [StringLength(1)]
        public string? FmsAssistType { get; set; }
        [StringLength(14)]
        public string? FmsContrNo { get; set; }
        [StringLength(4)]
        public string? FmsItemNo { get; set; }
        [StringLength(3)]
        public string? FmsMosFrom { get; set; }
        [StringLength(3)]
        public string? FmsMosTo { get; set; }
        [StringLength(1)]
        public string? FmsOfferRelCode { get; set; }
        [StringLength(1)]
        public string? FmsSrcCode { get; set; }
        [StringLength(2)]
        public string? FmsTrainingNote { get; set; }
        [StringLength(150)]
        public string? FrtForw { get; set; }
        [StringLength(3)]
        public string? Hd { get; set; }
        [StringLength(150)]
        public string? GateWayCode { get; set; }
        [StringLength(40)]
        public string? ItemDesc { get; set; }
        [StringLength(4)]
        public string? ItemNo { get; set; }
        [StringLength(14)]
        public string? MaterialGrp { get; set; }
        [StringLength(4)]
        public string? MinShelfLife { get; set; }
        [StringLength(32)]
        public string? Mpn { get; set; }
        [Column(TypeName = "decimal(10, 6)")]
        public decimal? Neq { get; set; }
        [Column(TypeName = "decimal(16, 4)")]
        public decimal? NetTotalAmt { get; set; }
        [StringLength(10)]
        public string? Niin { get; set; }
        [Column(TypeName = "decimal(16, 4)")]
        public decimal? NoOfPcs { get; set; }
        [StringLength(4)]
        public string? Nsc { get; set; }
        [StringLength(1)]
        public string? OptionFlag { get; set; }
        [StringLength(40)]
        public string? PeDept { get; set; }
        [StringLength(30)]
        public string? PeFax { get; set; }
        [StringLength(4)]
        public string? PeInit { get; set; }
        [StringLength(30)]
        public string? PePhoneNo { get; set; }
        [StringLength(80)]
        public string? PeRankName { get; set; }
        [StringLength(200)]
        public string? PlaceDelivery { get; set; }
        [StringLength(4)]
        public string? PrItemNo { get; set; }
        [StringLength(14)]
        public string? PrNo { get; set; }
        [StringLength(4)]
        public string? PrincContrItemNo { get; set; }
        [StringLength(14)]
        public string? PrincContrNo { get; set; }
        [StringLength(2)]
        public string? PriorityInd { get; set; }
        [Column(TypeName = "decimal(16, 4)")]
        public decimal? QtyRecv { get; set; }
        [StringLength(2)]
        public string? RecStatus { get; set; }
        [StringLength(1)]
        public string? Scg { get; set; }
        [StringLength(1)]
        public string? SecurityClass { get; set; }
        [StringLength(5)]
        public string? ServiceCode { get; set; }
        [StringLength(3)]
        public string? SubVoteNo { get; set; }
        [StringLength(12)]
        public string? SupplierCode { get; set; }
        [StringLength(30)]
        public string? SupplierContact { get; set; }
        [StringLength(2)]
        public string? TferStatus { get; set; }
        [Column(TypeName = "decimal(16, 4)")]
        public decimal? TotalAmtL { get; set; }
        [StringLength(3)]
        public string? UnitMeas { get; set; }
        [Column(TypeName = "decimal(16, 4)")]
        public decimal? UnitPrice { get; set; }
        [StringLength(4)]
        public string? UnNo { get; set; }
        [StringLength(10)]
        public string? VoteNo { get; set; }
    }
}
