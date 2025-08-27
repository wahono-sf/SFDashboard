using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("toso1")]
    public partial class Toso1
    {
        [Key]
        [Column("SONo")]
        [StringLength(20)]
        public string Sono { get; set; } = null!;
        [StringLength(30)]
        public string? JobNo { get; set; }
        [StringLength(10)]
        public string? BookingNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? BuyTotal { get; set; }
        [StringLength(8)]
        public string? CargoTransferNo { get; set; }
        [StringLength(5)]
        public string? CargoType { get; set; }
        [StringLength(1)]
        public string? ConfirmFlag { get; set; }
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
        [StringLength(3)]
        public string? DestCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EtaDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EtdDate { get; set; }
        [StringLength(30)]
        public string? FeederVessel { get; set; }
        [StringLength(6)]
        public string? FeederVoyage { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? FiataTotal { get; set; }
        [StringLength(5)]
        public string? FifthViaPortCode { get; set; }
        [StringLength(5)]
        public string? FirstViaPortCode { get; set; }
        [StringLength(6)]
        public string? FlightNo { get; set; }
        [StringLength(5)]
        public string? FourthViaPortCode { get; set; }
        [Column("LCNo")]
        [StringLength(12)]
        public string? Lcno { get; set; }
        [Column(TypeName = "decimal(10, 0)")]
        public decimal? NoOf20thContainer { get; set; }
        [Column(TypeName = "decimal(10, 0)")]
        public decimal? NoOf40thContainer { get; set; }
        [Column(TypeName = "decimal(10, 0)")]
        public decimal? NoOf45thContainer { get; set; }
        [StringLength(10)]
        public string? NotifyCode { get; set; }
        [StringLength(80)]
        public string? NotifyName { get; set; }
        [StringLength(50)]
        public string? NotifyAddress1 { get; set; }
        [StringLength(50)]
        public string? NotifyAddress2 { get; set; }
        [StringLength(50)]
        public string? NotifyAddress3 { get; set; }
        [StringLength(50)]
        public string? NotifyAddress4 { get; set; }
        [StringLength(3)]
        public string? OriginCode { get; set; }
        [StringLength(20)]
        public string? PlaceOfDelivery { get; set; }
        [StringLength(20)]
        public string? PlaceOfReceipt { get; set; }
        [StringLength(5)]
        public string? PortOfDischargeCode { get; set; }
        [StringLength(5)]
        public string? PortOfLoadingCode { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(5)]
        public string? SecondViaPortCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? SellTotal { get; set; }
        [StringLength(3)]
        public string? ShipmentType { get; set; }
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
        [StringLength(12)]
        public string? ShippingLineCode { get; set; }
        [StringLength(5)]
        public string? ThirdViaPortCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TotalChargeWeight { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TotalGrossWeight { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TotalPcs { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TotalVolume { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TransferDate { get; set; }
        [StringLength(10)]
        public string? TransferFromCode { get; set; }
        [StringLength(80)]
        public string? TransferFromName { get; set; }
        [StringLength(50)]
        public string? TransferFromAddress1 { get; set; }
        [StringLength(50)]
        public string? TransferFromAddress2 { get; set; }
        [StringLength(50)]
        public string? TransferFromAddress3 { get; set; }
        [StringLength(50)]
        public string? TransferFromAddress4 { get; set; }
        [StringLength(10)]
        public string? TransferToCode { get; set; }
        [StringLength(80)]
        public string? TransferToName { get; set; }
        [StringLength(50)]
        public string? TransferToAddress1 { get; set; }
        [StringLength(50)]
        public string? TransferToAddress2 { get; set; }
        [StringLength(50)]
        public string? TransferToAddress3 { get; set; }
        [StringLength(50)]
        public string? TransferToAddress4 { get; set; }
        [StringLength(10)]
        public string? TransportCode { get; set; }
        [StringLength(80)]
        public string? TransportName { get; set; }
        [StringLength(50)]
        public string? TransportAddress1 { get; set; }
        [StringLength(50)]
        public string? TransportAddress2 { get; set; }
        [StringLength(50)]
        public string? TransportAddress3 { get; set; }
        [StringLength(50)]
        public string? TransportAddress4 { get; set; }
        [StringLength(17)]
        public string? UcrNo { get; set; }
        [StringLength(12)]
        public string? VesselCode { get; set; }
        [StringLength(30)]
        public string? VesselName { get; set; }
        [StringLength(12)]
        public string? VoyageNo { get; set; }
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
