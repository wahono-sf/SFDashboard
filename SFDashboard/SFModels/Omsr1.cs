using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    [Table("omsr1")]
    public partial class Omsr1
    {
        [StringLength(6)]
        public string? ArrivalGatewayCode { get; set; }
        [StringLength(75)]
        public string? CancellationRmk { get; set; }
        [StringLength(75)]
        public string? CollectionPoint { get; set; }
        [StringLength(10)]
        public string? ConsigneeCode { get; set; }
        [StringLength(80)]
        public string? ConsigneeName { get; set; }
        [StringLength(8)]
        public string? ConsigneeCodePlexis { get; set; }
        [StringLength(20)]
        public string? ContractNumber { get; set; }
        [StringLength(10)]
        public string? ContractRepairVote { get; set; }
        [StringLength(8)]
        public string? ContrClientCode { get; set; }
        [StringLength(20)]
        public string? CpContactNo { get; set; }
        [StringLength(30)]
        public string? CpContactPerson { get; set; }
        [StringLength(20)]
        public string? CpFaxNo { get; set; }
        [StringLength(20)]
        public string? CustomerReference { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DatetimeAdded { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DatetimeChanged { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DatetimePickUpByFf { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DatetimePickupByFfGmt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DatetimeReadyForPickup { get; set; }
        [StringLength(6)]
        public string? DepartureGatewayCode { get; set; }
        [StringLength(1)]
        public string? DgIndicator { get; set; }
        [StringLength(10)]
        public string? EsRequestNo { get; set; }
        [StringLength(1)]
        public string? ExplosiveIndicator { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FfReceivedDatetime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FfReceivedDatetimeGmt { get; set; }
        [StringLength(30)]
        public string? HawbHblNo { get; set; }
        [StringLength(8)]
        public string? IssuerCode { get; set; }
        [StringLength(8)]
        public string? IssuerChanged { get; set; }
        [StringLength(5)]
        public string? ImcoClass { get; set; }
        [StringLength(30)]
        public string? JobNo { get; set; }
        [StringLength(75)]
        public string? LicenseInfo { get; set; }
        [StringLength(20)]
        public string? LicenseNo { get; set; }
        [StringLength(30)]
        public string? MasterJobNo { get; set; }
        [StringLength(30)]
        public string? MawbOblNo { get; set; }
        [StringLength(35)]
        public string? MethodOfDespatch { get; set; }
        [StringLength(50)]
        public string? ModeOfPayment { get; set; }
        [Column(TypeName = "decimal(11, 6)")]
        public decimal? Neq { get; set; }
        [StringLength(80)]
        public string? NotifyName { get; set; }
        [StringLength(50)]
        public string? NotifyAddr1 { get; set; }
        [StringLength(50)]
        public string? NotifyAddr2 { get; set; }
        [StringLength(50)]
        public string? NotifyAddr3 { get; set; }
        [StringLength(50)]
        public string? NotifyAddr4 { get; set; }
        [StringLength(30)]
        public string? OblJobNo { get; set; }
        [StringLength(40)]
        public string? ReasonsForDespatch { get; set; }
        [StringLength(2)]
        public string? RecStatus { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(250)]
        public string? Remarks { get; set; }
        [StringLength(4)]
        public string? ReqClientCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RequestDatetime { get; set; }
        [StringLength(12)]
        public string RequestNumber { get; set; } = null!;
        [StringLength(8)]
        public string? Requestor { get; set; }
        [StringLength(30)]
        public string? RequestorAppointment { get; set; }
        [StringLength(30)]
        public string? RequestorEmailId { get; set; }
        [StringLength(20)]
        public string? RequestorFaxNumber { get; set; }
        [StringLength(10)]
        public string? RequestorIcNumber { get; set; }
        [StringLength(30)]
        public string? RequestorName { get; set; }
        [StringLength(20)]
        public string? RequestorPhone { get; set; }
        [StringLength(30)]
        public string? RequestorUnit { get; set; }
        [StringLength(2)]
        public string? ShipmentFlag { get; set; }
        [StringLength(10)]
        public string? ShipperCode { get; set; }
        [StringLength(80)]
        public string? ShipperName { get; set; }
        [StringLength(8)]
        public string? ShipperCodePlexis { get; set; }
        [StringLength(250)]
        public string? SpecialShipperInstruction { get; set; }
        [Column(TypeName = "decimal(11, 2)")]
        public decimal? TotalGrossWt { get; set; }
        [Column(TypeName = "decimal(11, 2)")]
        public decimal? TotalItemValue { get; set; }
        [Column(TypeName = "decimal(11, 2)")]
        public decimal? TotalNoOfPackages { get; set; }
        [Column(TypeName = "decimal(12, 3)")]
        public decimal? TotalVol { get; set; }
        [StringLength(20)]
        public string? TypeOfSystem { get; set; }
        [StringLength(4)]
        public string? UnNo { get; set; }
        [StringLength(10)]
        public string? VoteIn { get; set; }
        [StringLength(10)]
        public string? VoteOut { get; set; }
    }
}
