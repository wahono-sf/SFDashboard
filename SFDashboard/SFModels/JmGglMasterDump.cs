using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class JmGglMasterDump
    {
        [Column("Product Name")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ProductName { get; set; }
        [Column("Shipment Type")]
        [StringLength(5)]
        public string? ShipmentType { get; set; }
        [Column("Job No")]
        [StringLength(20)]
        public string JobNo { get; set; } = null!;
        [Column("Job Close")]
        [StringLength(1)]
        [Unicode(false)]
        public string JobClose { get; set; } = null!;
        [Column("Awb Bl No")]
        [StringLength(20)]
        public string? AwbBlNo { get; set; }
        [Column("Created Date")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CreatedDate { get; set; }
        [Column("Job Date", TypeName = "datetime")]
        public DateTime? JobDate { get; set; }
        [Column("Job Mth")]
        [StringLength(6)]
        public string? JobMth { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Etd { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Eta { get; set; }
        [Column("M Awb Obl No")]
        [StringLength(20)]
        public string? MAwbOblNo { get; set; }
        [Column("Origin Agent Name")]
        [StringLength(80)]
        public string? OriginAgentName { get; set; }
        [Column("Agent Name")]
        [StringLength(80)]
        public string? AgentName { get; set; }
        [Column("Shippingline Code")]
        [StringLength(12)]
        public string? ShippinglineCode { get; set; }
        [Column("Vessel Name")]
        [StringLength(50)]
        public string? VesselName { get; set; }
        [Column("Flight No")]
        [StringLength(20)]
        public string? FlightNo { get; set; }
        [Column("Flight Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? FlightDate { get; set; }
        [Column("Coloader Name")]
        [StringLength(80)]
        public string? ColoaderName { get; set; }
        [Column("Trader Code")]
        [StringLength(1)]
        [Unicode(false)]
        public string? TraderCode { get; set; }
        [Column("Service Code")]
        [StringLength(1)]
        [Unicode(false)]
        public string? ServiceCode { get; set; }
        [Column("Origin Country Name")]
        [StringLength(45)]
        public string? OriginCountryName { get; set; }
        [Column("Origin Port Name")]
        [StringLength(45)]
        public string? OriginPortName { get; set; }
        [Column("POL Country Name")]
        [StringLength(45)]
        public string? PolCountryName { get; set; }
        [Column("Port Of Loading Name")]
        [StringLength(45)]
        public string? PortOfLoadingName { get; set; }
        [Column("POD Country Name")]
        [StringLength(45)]
        public string? PodCountryName { get; set; }
        [Column("Port Of Discharge Name")]
        [StringLength(45)]
        public string? PortOfDischargeName { get; set; }
        [Column("FDC Country Name")]
        [StringLength(45)]
        public string? FdcCountryName { get; set; }
        [Column("FDC Port Name")]
        [StringLength(45)]
        public string? FdcPortName { get; set; }
        [Column("House PPCC")]
        [StringLength(1)]
        public string? HousePpcc { get; set; }
        [Column("Who Routed")]
        [StringLength(10)]
        public string? WhoRouted { get; set; }
        [Column("Is Coload")]
        [StringLength(1)]
        [Unicode(false)]
        public string IsCoload { get; set; } = null!;
        [Column("Consignee Name")]
        [StringLength(80)]
        public string? ConsigneeName { get; set; }
        [Column("Customer Name")]
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [Column("Shipper Name")]
        [StringLength(80)]
        public string? ShipperName { get; set; }
        [Column("Notify Name")]
        [StringLength(80)]
        public string? NotifyName { get; set; }
        [Column("Charge Weight", TypeName = "decimal(13, 4)")]
        public decimal? ChargeWeight { get; set; }
        [Column("CBM", TypeName = "decimal(13, 4)")]
        public decimal? Cbm { get; set; }
        [Column("TEU")]
        public int? Teu { get; set; }
        [Column("Salesman Code")]
        [StringLength(10)]
        public string? SalesmanCode { get; set; }
        [Column("Origin Booking No")]
        [StringLength(20)]
        public string? OriginBookingNo { get; set; }
        [Column("Booking Person")]
        [StringLength(50)]
        public string? BookingPerson { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? Revenue { get; set; }
        [Column("T/S Revenue", TypeName = "decimal(38, 6)")]
        public decimal? TSRevenue { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? Cost { get; set; }
        [Column("T/S Cost", TypeName = "decimal(38, 6)")]
        public decimal? TSCost { get; set; }
    }
}
