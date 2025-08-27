using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwOmtx11
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Ref No")]
        [StringLength(8000)]
        [Unicode(false)]
        public string? RefNo { get; set; }
        [Column("Airline Id")]
        [StringLength(2)]
        public string? AirlineId { get; set; }
        [Column("Airport Dept Code")]
        [StringLength(3)]
        public string? AirportDeptCode { get; set; }
        [Column("Airport Dest Code")]
        [StringLength(3)]
        public string? AirportDestCode { get; set; }
        [Column("ASN No")]
        [StringLength(20)]
        public string? AsnNo { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Awb Bl No")]
        [StringLength(30)]
        public string? AwbBlNo { get; set; }
        [Column("Awb No")]
        [StringLength(20)]
        public string? AwbNo { get; set; }
        [Column("Balance Gross Weight", TypeName = "decimal(13, 4)")]
        public decimal? BalanceGrossWeight { get; set; }
        [Column("Balance Pcs")]
        public int? BalancePcs { get; set; }
        [Column("Bl No")]
        [StringLength(30)]
        public string? BlNo { get; set; }
        [Column("Cargo Ready Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? CargoReadyDate { get; set; }
        [Column("Cargo Type")]
        [StringLength(5)]
        public string? CargoType { get; set; }
        [Column("Cargo Status Code")]
        [StringLength(5)]
        public string? CargoStatusCode { get; set; }
        [Column("Collect From Address 1")]
        [StringLength(45)]
        public string? CollectFromAddress1 { get; set; }
        [Column("Collect From Address 2")]
        [StringLength(45)]
        public string? CollectFromAddress2 { get; set; }
        [Column("Collect From Address 3")]
        [StringLength(45)]
        public string? CollectFromAddress3 { get; set; }
        [Column("Collect From Address 4")]
        [StringLength(45)]
        public string? CollectFromAddress4 { get; set; }
        [Column("Collect From Name")]
        [StringLength(80)]
        public string? CollectFromName { get; set; }
        [Column("Commodity Code")]
        [StringLength(10)]
        public string? CommodityCode { get; set; }
        [Column("Commodity Description")]
        [StringLength(50)]
        public string? CommodityDescription { get; set; }
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
        [Column("Consignee Code")]
        [StringLength(10)]
        public string? ConsigneeCode { get; set; }
        [Column("Consignee Name")]
        [StringLength(80)]
        public string? ConsigneeName { get; set; }
        [Column("Contact Name")]
        [StringLength(50)]
        public string? ContactName { get; set; }
        [Column("Container No")]
        [StringLength(255)]
        public string? ContainerNo { get; set; }
        [Column("Container Type 1")]
        [StringLength(5)]
        public string? ContainerType1 { get; set; }
        [Column("Container Type 2")]
        [StringLength(5)]
        public string? ContainerType2 { get; set; }
        [Column("Container Type 3")]
        [StringLength(5)]
        public string? ContainerType3 { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [Column("Customer Code")]
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [Column("Customer Name")]
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [Column("Deliver To Address 1")]
        [StringLength(45)]
        public string? DeliverToAddress1 { get; set; }
        [Column("Deliver To Address 2")]
        [StringLength(45)]
        public string? DeliverToAddress2 { get; set; }
        [Column("Deliver To Address 3")]
        [StringLength(45)]
        public string? DeliverToAddress3 { get; set; }
        [Column("Deliver To Address 4")]
        [StringLength(45)]
        public string? DeliverToAddress4 { get; set; }
        [Column("Deliver To Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? DeliverToDateTime { get; set; }
        [Column("Deliver To Name")]
        [StringLength(80)]
        public string? DeliverToName { get; set; }
        [Column("Delivery Type")]
        [StringLength(5)]
        public string? DeliveryType { get; set; }
        [Column("Description Of Goods 1")]
        [StringLength(50)]
        public string? DescriptionOfGoods1 { get; set; }
        [Column("Description Of Goods 2")]
        [StringLength(50)]
        public string? DescriptionOfGoods2 { get; set; }
        [Column("Description Of Goods 3")]
        [StringLength(50)]
        public string? DescriptionOfGoods3 { get; set; }
        [Column("Description Of Goods 4")]
        [StringLength(50)]
        public string? DescriptionOfGoods4 { get; set; }
        [Column("Dest Code")]
        [StringLength(3)]
        public string? DestCode { get; set; }
        [Column("Dg Flag")]
        [StringLength(1)]
        public string? DgFlag { get; set; }
        [Column("Doc Charge Weight", TypeName = "decimal(13, 4)")]
        public decimal? DocChargeWeight { get; set; }
        [Column("Eta Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? EtaDate { get; set; }
        [Column("Etd Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? EtdDate { get; set; }
        [Column("Export Awb No")]
        [StringLength(20)]
        public string? ExportAwbNo { get; set; }
        [Column("Export Flight Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ExportFlightDate { get; set; }
        [Column("Export Flight No")]
        [StringLength(6)]
        public string? ExportFlightNo { get; set; }
        [Column("Flight No")]
        [StringLength(10)]
        public string? FlightNo { get; set; }
        [Column("Flight Voy No")]
        [StringLength(22)]
        public string? FlightVoyNo { get; set; }
        [Column("Gross Weight", TypeName = "decimal(13, 4)")]
        public decimal? GrossWeight { get; set; }
        [Column("Invoice No")]
        [StringLength(20)]
        public string? InvoiceNo { get; set; }
        [Column("Job Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? JobDate { get; set; }
        [Column("Job No")]
        [StringLength(20)]
        public string? JobNo { get; set; }
        [Column("Job Type")]
        [StringLength(10)]
        public string? JobType { get; set; }
        [Column("Line Item No")]
        public int LineItemNo { get; set; }
        [Column("Mark No")]
        [StringLength(25)]
        public string? MarkNo { get; set; }
        [Column("M Awb Obl No")]
        [StringLength(30)]
        public string? MAwbOblNo { get; set; }
        [Column("Measurement Type")]
        [StringLength(2)]
        public string? MeasurementType { get; set; }
        [Column("Module Code")]
        [StringLength(2)]
        public string? ModuleCode { get; set; }
        [Column("Nomination Flag")]
        [StringLength(1)]
        public string? NominationFlag { get; set; }
        [Column("Nomination Remark")]
        [StringLength(50)]
        public string? NominationRemark { get; set; }
        [Column("No Of container 1")]
        public int? NoOfContainer1 { get; set; }
        [Column("No Of container 2")]
        public int? NoOfContainer2 { get; set; }
        [Column("No Of container 3")]
        public int? NoOfContainer3 { get; set; }
        [StringLength(2000)]
        public string? Note { get; set; }
        [Column("Order Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? OrderDate { get; set; }
        [Column("Order No")]
        [StringLength(50)]
        public string OrderNo { get; set; } = null!;
        [Column("Order No Bar Code")]
        [StringLength(255)]
        public string? OrderNoBarCode { get; set; }
        [Column("Order Status")]
        [StringLength(20)]
        public string? OrderStatus { get; set; }
        [Column("Order Type")]
        [StringLength(5)]
        public string? OrderType { get; set; }
        [Column("Origin Code")]
        [StringLength(3)]
        public string? OriginCode { get; set; }
        [Column("Packing Qty")]
        public int? PackingQty { get; set; }
        [Column("Packing Qty 1")]
        public int? PackingQty1 { get; set; }
        [Column("Packing Qty 2")]
        public int? PackingQty2 { get; set; }
        [Column("Packing Qty 3")]
        public int? PackingQty3 { get; set; }
        [Column("Packing Qty 4")]
        public int? PackingQty4 { get; set; }
        [Column("Packing Qty 5")]
        public int? PackingQty5 { get; set; }
        public int? Pcs { get; set; }
        [Column("Pickup Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? PickupDateTime { get; set; }
        [Column("POD Agent Code")]
        [StringLength(10)]
        public string? PodAgentCode { get; set; }
        [Column("POD Agent Name")]
        [StringLength(80)]
        public string? PodAgentName { get; set; }
        [Column("POD Coloader Code")]
        [StringLength(10)]
        public string? PodColoaderCode { get; set; }
        [Column("POD Coloader Name")]
        [StringLength(80)]
        public string? PodColoaderName { get; set; }
        [Column("POL Agent Code")]
        [StringLength(10)]
        public string? PolAgentCode { get; set; }
        [Column("POL Agent Name")]
        [StringLength(80)]
        public string? PolAgentName { get; set; }
        [Column("POL Coloader Code")]
        [StringLength(10)]
        public string? PolColoaderCode { get; set; }
        [Column("POL Coloader Name")]
        [StringLength(80)]
        public string? PolColoaderName { get; set; }
        [Column("Port Of Discharge Code")]
        [StringLength(5)]
        public string? PortOfDischargeCode { get; set; }
        [Column("Port Of Loading Code")]
        [StringLength(5)]
        public string? PortOfLoadingCode { get; set; }
        [Column("Purchase Order No")]
        [StringLength(50)]
        public string? PurchaseOrderNo { get; set; }
        public int? Qty { get; set; }
        [Column("Quote No")]
        [StringLength(15)]
        public string? QuoteNo { get; set; }
        [StringLength(20)]
        public string? Reference { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Salesman Code")]
        [StringLength(10)]
        public string? SalesmanCode { get; set; }
        [Column("Seal No")]
        [StringLength(255)]
        public string? SealNo { get; set; }
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
        [Column("Shipper Code")]
        [StringLength(10)]
        public string? ShipperCode { get; set; }
        [Column("Shipper Name")]
        [StringLength(80)]
        public string? ShipperName { get; set; }
        [Column("Shippingline Code")]
        [StringLength(12)]
        public string? ShippinglineCode { get; set; }
        [Column("Special Instruction")]
        [StringLength(3000)]
        public string? SpecialInstruction { get; set; }
        [StringLength(30)]
        public string? Telephone { get; set; }
        [Column("Trx Type")]
        [StringLength(5)]
        public string? TrxType { get; set; }
        [Column("Uom Code")]
        [StringLength(3)]
        public string? UomCode { get; set; }
        [Column("User Define 01")]
        [StringLength(50)]
        public string? UserDefine01 { get; set; }
        [Column("User Define 02")]
        [StringLength(50)]
        public string? UserDefine02 { get; set; }
        [Column("User Define 03")]
        [StringLength(50)]
        public string? UserDefine03 { get; set; }
        [Column("User Define 04")]
        [StringLength(50)]
        public string? UserDefine04 { get; set; }
        [Column("User Define 05")]
        [StringLength(50)]
        public string? UserDefine05 { get; set; }
        [Column("User Define 06")]
        [StringLength(50)]
        public string? UserDefine06 { get; set; }
        [Column("User Define 07")]
        [StringLength(50)]
        public string? UserDefine07 { get; set; }
        [Column("User Define 08")]
        [StringLength(50)]
        public string? UserDefine08 { get; set; }
        [Column("User Define 09")]
        [StringLength(50)]
        public string? UserDefine09 { get; set; }
        [Column("User Define 10")]
        [StringLength(50)]
        public string? UserDefine10 { get; set; }
        [Column("Vessel Code")]
        [StringLength(50)]
        public string? VesselCode { get; set; }
        [Column("Vessel Name")]
        [StringLength(50)]
        public string? VesselName { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Volume { get; set; }
        [Column("Volumetric Weight", TypeName = "decimal(13, 4)")]
        public decimal? VolumetricWeight { get; set; }
        [Column("Voyage No")]
        [StringLength(20)]
        public string? VoyageNo { get; set; }
        [Column("Warehouse Name")]
        [StringLength(45)]
        public string? WarehouseName { get; set; }
        [Column("Work Station")]
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Wt { get; set; }
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
