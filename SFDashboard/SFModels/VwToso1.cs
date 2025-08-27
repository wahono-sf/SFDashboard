using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwToso1
    {
        [Column("SO No")]
        [StringLength(20)]
        public string SoNo { get; set; } = null!;
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Booking No")]
        [StringLength(10)]
        public string? BookingNo { get; set; }
        [Column("Buy Total", TypeName = "decimal(13, 2)")]
        public decimal? BuyTotal { get; set; }
        [Column("Cargo Transfer No")]
        [StringLength(8)]
        public string? CargoTransferNo { get; set; }
        [Column("Cargo Type")]
        [StringLength(5)]
        public string? CargoType { get; set; }
        [Column("Confirm Flag")]
        [StringLength(1)]
        public string? ConfirmFlag { get; set; }
        [Column("Consignee Code")]
        [StringLength(10)]
        public string? ConsigneeCode { get; set; }
        [Column("Consignee Name")]
        [StringLength(80)]
        public string? ConsigneeName { get; set; }
        [Column("Consignee Address 1")]
        [StringLength(45)]
        public string? ConsigneeAddress1 { get; set; }
        [Column("Consignee Address 2")]
        [StringLength(45)]
        public string? ConsigneeAddress2 { get; set; }
        [Column("Consignee Address 3")]
        [StringLength(45)]
        public string? ConsigneeAddress3 { get; set; }
        [Column("Consignee Address 4")]
        [StringLength(45)]
        public string? ConsigneeAddress4 { get; set; }
        [Column("Dest Code")]
        [StringLength(3)]
        public string? DestCode { get; set; }
        [Column("Eta Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? EtaDate { get; set; }
        [Column("Etd Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? EtdDate { get; set; }
        [Column("Feeder Vessel")]
        [StringLength(30)]
        public string? FeederVessel { get; set; }
        [Column("Feeder Voyage")]
        [StringLength(6)]
        public string? FeederVoyage { get; set; }
        [Column("Fiata Total", TypeName = "decimal(13, 2)")]
        public decimal? FiataTotal { get; set; }
        [Column("Fifth Via Port Code")]
        [StringLength(5)]
        public string? FifthViaPortCode { get; set; }
        [Column("First Via Port Code")]
        [StringLength(5)]
        public string? FirstViaPortCode { get; set; }
        [Column("Flight No")]
        [StringLength(6)]
        public string? FlightNo { get; set; }
        [Column("Fourth Via Port Code")]
        [StringLength(5)]
        public string? FourthViaPortCode { get; set; }
        [Column("Job No")]
        [StringLength(20)]
        public string? JobNo { get; set; }
        [Column("L C No")]
        [StringLength(12)]
        public string? LCNo { get; set; }
        [Column("No Of 20th Container", TypeName = "decimal(10, 0)")]
        public decimal? NoOf20thContainer { get; set; }
        [Column("No Of 40th Container", TypeName = "decimal(10, 0)")]
        public decimal? NoOf40thContainer { get; set; }
        [Column("No Of 45th Container", TypeName = "decimal(10, 0)")]
        public decimal? NoOf45thContainer { get; set; }
        [Column("Notify Code")]
        [StringLength(10)]
        public string? NotifyCode { get; set; }
        [Column("Notify Name")]
        [StringLength(80)]
        public string? NotifyName { get; set; }
        [Column("Notify Address 1")]
        [StringLength(45)]
        public string? NotifyAddress1 { get; set; }
        [Column("Notify Address 2")]
        [StringLength(45)]
        public string? NotifyAddress2 { get; set; }
        [Column("Notify Address 3")]
        [StringLength(45)]
        public string? NotifyAddress3 { get; set; }
        [Column("Notify Address 4")]
        [StringLength(45)]
        public string? NotifyAddress4 { get; set; }
        [Column("Origin Code")]
        [StringLength(3)]
        public string? OriginCode { get; set; }
        [Column("Place Of Delivery")]
        [StringLength(20)]
        public string? PlaceOfDelivery { get; set; }
        [Column("Place Of Receipt")]
        [StringLength(20)]
        public string? PlaceOfReceipt { get; set; }
        [Column("Port Of Discharge Code")]
        [StringLength(5)]
        public string? PortOfDischargeCode { get; set; }
        [Column("Port Of Loading Code")]
        [StringLength(5)]
        public string? PortOfLoadingCode { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Second Via Port Code")]
        [StringLength(5)]
        public string? SecondViaPortCode { get; set; }
        [Column("Sell Total", TypeName = "decimal(13, 2)")]
        public decimal? SellTotal { get; set; }
        [Column("Shipment Type")]
        [StringLength(3)]
        public string? ShipmentType { get; set; }
        [Column("Shipper Code")]
        [StringLength(10)]
        public string? ShipperCode { get; set; }
        [Column("Shipper Name")]
        [StringLength(80)]
        public string? ShipperName { get; set; }
        [Column("Shipper Address 1")]
        [StringLength(45)]
        public string? ShipperAddress1 { get; set; }
        [Column("Shipper Address 2")]
        [StringLength(45)]
        public string? ShipperAddress2 { get; set; }
        [Column("Shipper Address 3")]
        [StringLength(45)]
        public string? ShipperAddress3 { get; set; }
        [Column("Shipper Address 4")]
        [StringLength(45)]
        public string? ShipperAddress4 { get; set; }
        [Column("Shipping Line Code")]
        [StringLength(12)]
        public string? ShippingLineCode { get; set; }
        [Column("Third Via Port Code")]
        [StringLength(5)]
        public string? ThirdViaPortCode { get; set; }
        [Column("Total Charge Weight", TypeName = "decimal(13, 2)")]
        public decimal? TotalChargeWeight { get; set; }
        [Column("Total Gross Weight", TypeName = "decimal(13, 2)")]
        public decimal? TotalGrossWeight { get; set; }
        [Column("Total Pcs", TypeName = "decimal(13, 2)")]
        public decimal? TotalPcs { get; set; }
        [Column("Total Volume", TypeName = "decimal(13, 2)")]
        public decimal? TotalVolume { get; set; }
        [Column("Transfer Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? TransferDate { get; set; }
        [Column("Transfer From Code")]
        [StringLength(10)]
        public string? TransferFromCode { get; set; }
        [Column("Transfer From Name")]
        [StringLength(80)]
        public string? TransferFromName { get; set; }
        [Column("Transfer From Address 1")]
        [StringLength(45)]
        public string? TransferFromAddress1 { get; set; }
        [Column("Transfer From Address 2")]
        [StringLength(45)]
        public string? TransferFromAddress2 { get; set; }
        [Column("Transfer From Address 3")]
        [StringLength(45)]
        public string? TransferFromAddress3 { get; set; }
        [Column("Transfer From Address 4")]
        [StringLength(45)]
        public string? TransferFromAddress4 { get; set; }
        [Column("Transfer To Code")]
        [StringLength(10)]
        public string? TransferToCode { get; set; }
        [Column("Transfer To Name")]
        [StringLength(80)]
        public string? TransferToName { get; set; }
        [Column("Transfer To Address 1")]
        [StringLength(45)]
        public string? TransferToAddress1 { get; set; }
        [Column("Transfer To Address 2")]
        [StringLength(45)]
        public string? TransferToAddress2 { get; set; }
        [Column("Transfer To Address 3")]
        [StringLength(45)]
        public string? TransferToAddress3 { get; set; }
        [Column("Transfer To Address 4")]
        [StringLength(45)]
        public string? TransferToAddress4 { get; set; }
        [Column("Transport Code")]
        [StringLength(10)]
        public string? TransportCode { get; set; }
        [Column("Transport Name")]
        [StringLength(80)]
        public string? TransportName { get; set; }
        [Column("Transport Address 1")]
        [StringLength(45)]
        public string? TransportAddress1 { get; set; }
        [Column("Transport Address 2")]
        [StringLength(45)]
        public string? TransportAddress2 { get; set; }
        [Column("Transport Address 3")]
        [StringLength(45)]
        public string? TransportAddress3 { get; set; }
        [Column("Transport Address 4")]
        [StringLength(45)]
        public string? TransportAddress4 { get; set; }
        [Column("Ucr No")]
        [StringLength(17)]
        public string? UcrNo { get; set; }
        [Column("Vessel Code")]
        [StringLength(12)]
        public string? VesselCode { get; set; }
        [Column("Vessel Name")]
        [StringLength(30)]
        public string? VesselName { get; set; }
        [Column("Voyage No")]
        [StringLength(12)]
        public string? VoyageNo { get; set; }
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
