using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("omtx1")]
    public partial class Omtx1
    {
        public Omtx1()
        {
            Omtx2s = new HashSet<Omtx2>();
            Omtx6s = new HashSet<Omtx6>();
        }

        [Key]
        public int TrxNo { get; set; }
        [StringLength(50)]
        public string OrderNo { get; set; } = null!;
        public int LineItemNo { get; set; }
        [StringLength(2)]
        public string? AirlineId { get; set; }
        [StringLength(3)]
        public string? AirportDeptCode { get; set; }
        [StringLength(3)]
        public string? AirportDestCode { get; set; }
        [StringLength(20)]
        public string? AsnNo { get; set; }
        [StringLength(30)]
        public string? AwbBlNo { get; set; }
        [StringLength(20)]
        public string? AwbNo { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? BalanceGrossWeight { get; set; }
        public int? BalancePcs { get; set; }
        [StringLength(30)]
        public string? BlNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CargoReadyDate { get; set; }
        [StringLength(5)]
        public string? CargoStatusCode { get; set; }
        [StringLength(5)]
        public string? CargoType { get; set; }
        [StringLength(80)]
        public string? CollectFromName { get; set; }
        [StringLength(50)]
        public string? CollectFromAddress1 { get; set; }
        [StringLength(50)]
        public string? CollectFromAddress2 { get; set; }
        [StringLength(50)]
        public string? CollectFromAddress3 { get; set; }
        [StringLength(50)]
        public string? CollectFromAddress4 { get; set; }
        [StringLength(50)]
        public string? CommodityCode { get; set; }
        [StringLength(50)]
        public string? CommodityDescription { get; set; }
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
        [StringLength(50)]
        public string? ContactName { get; set; }
        [StringLength(255)]
        public string? ContainerNo { get; set; }
        [StringLength(5)]
        public string? ContainerType1 { get; set; }
        [StringLength(5)]
        public string? ContainerType2 { get; set; }
        [StringLength(5)]
        public string? ContainerType3 { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [StringLength(80)]
        public string? DeliverToName { get; set; }
        [StringLength(50)]
        public string? DeliverToAddress1 { get; set; }
        [StringLength(50)]
        public string? DeliverToAddress2 { get; set; }
        [StringLength(50)]
        public string? DeliverToAddress3 { get; set; }
        [StringLength(50)]
        public string? DeliverToAddress4 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DeliverToDateTime { get; set; }
        [StringLength(5)]
        public string? DeliveryType { get; set; }
        [StringLength(50)]
        public string? DescriptionOfGoods1 { get; set; }
        [StringLength(50)]
        public string? DescriptionOfGoods2 { get; set; }
        [StringLength(50)]
        public string? DescriptionOfGoods3 { get; set; }
        [StringLength(50)]
        public string? DescriptionOfGoods4 { get; set; }
        [StringLength(3)]
        public string? DestCode { get; set; }
        [StringLength(45)]
        public string? DestName { get; set; }
        [StringLength(1)]
        public string? DgFlag { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? DocChargeWeight { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EtaDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EtdDate { get; set; }
        [StringLength(10)]
        public string? FlightNo { get; set; }
        [StringLength(22)]
        public string? FlightVoyNo { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? GrossWeight { get; set; }
        [StringLength(20)]
        public string? InvoiceNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? JobDate { get; set; }
        [StringLength(30)]
        public string? JobNo { get; set; }
        [StringLength(10)]
        public string? JobType { get; set; }
        [StringLength(25)]
        public string? MarkNo { get; set; }
        [StringLength(30)]
        public string? MawbOblNo { get; set; }
        [StringLength(2)]
        public string? MeasurementType { get; set; }
        [StringLength(2)]
        public string? ModuleCode { get; set; }
        [StringLength(1)]
        public string? NominationFlag { get; set; }
        [StringLength(50)]
        public string? NominationRemark { get; set; }
        public int? NoOfContainer1 { get; set; }
        public int? NoOfContainer2 { get; set; }
        public int? NoOfContainer3 { get; set; }
        [StringLength(2000)]
        public string? Note { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OrderDate { get; set; }
        [StringLength(255)]
        public string? OrderNoBarCode { get; set; }
        [StringLength(20)]
        public string? OrderStatus { get; set; }
        [StringLength(5)]
        public string? OrderType { get; set; }
        [StringLength(3)]
        public string? OriginCode { get; set; }
        [StringLength(45)]
        public string? OriginName { get; set; }
        public int? PackingQty { get; set; }
        public int? PackingQty1 { get; set; }
        public int? PackingQty2 { get; set; }
        public int? PackingQty3 { get; set; }
        public int? PackingQty4 { get; set; }
        public int? PackingQty5 { get; set; }
        public int? Pcs { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PickupDateTime { get; set; }
        [Column("PODAgentCode")]
        [StringLength(10)]
        public string? PodagentCode { get; set; }
        [Column("PODAgentName")]
        [StringLength(80)]
        public string? PodagentName { get; set; }
        [Column("PODColoaderCode")]
        [StringLength(10)]
        public string? PodcoloaderCode { get; set; }
        [Column("PODColoaderName")]
        [StringLength(80)]
        public string? PodcoloaderName { get; set; }
        [Column("POLAgentCode")]
        [StringLength(10)]
        public string? PolagentCode { get; set; }
        [Column("POLAgentName")]
        [StringLength(80)]
        public string? PolagentName { get; set; }
        [Column("POLColoaderCode")]
        [StringLength(10)]
        public string? PolcoloaderCode { get; set; }
        [Column("POLColoaderName")]
        [StringLength(80)]
        public string? PolcoloaderName { get; set; }
        [StringLength(5)]
        public string? PortOfDischargeCode { get; set; }
        [StringLength(5)]
        public string? PortOfLoadingCode { get; set; }
        [StringLength(50)]
        public string? PurchaseOrderNo { get; set; }
        public int? Qty { get; set; }
        [StringLength(15)]
        public string? QuoteNo { get; set; }
        [StringLength(20)]
        public string? Reference { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(10)]
        public string? SalesmanCode { get; set; }
        [StringLength(255)]
        public string? SealNo { get; set; }
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
        public string? ShippinglineCode { get; set; }
        [StringLength(3000)]
        public string? SpecialInstruction { get; set; }
        [StringLength(30)]
        public string? Telephone { get; set; }
        [StringLength(5)]
        public string? TrxType { get; set; }
        [StringLength(50)]
        public string? UomCode { get; set; }
        [StringLength(50)]
        public string? UserDefine01 { get; set; }
        [StringLength(50)]
        public string? UserDefine02 { get; set; }
        [StringLength(50)]
        public string? UserDefine03 { get; set; }
        [StringLength(50)]
        public string? UserDefine04 { get; set; }
        [StringLength(50)]
        public string? UserDefine05 { get; set; }
        [StringLength(50)]
        public string? UserDefine06 { get; set; }
        [StringLength(50)]
        public string? UserDefine07 { get; set; }
        [StringLength(50)]
        public string? UserDefine08 { get; set; }
        [StringLength(50)]
        public string? UserDefine09 { get; set; }
        [StringLength(50)]
        public string? UserDefine10 { get; set; }
        [StringLength(50)]
        public string? VesselCode { get; set; }
        [StringLength(50)]
        public string? VesselName { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Volume { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? VolumetricWeight { get; set; }
        [StringLength(20)]
        public string? VoyageNo { get; set; }
        [StringLength(45)]
        public string? WarehouseName { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Wt { get; set; }
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
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

        [InverseProperty("TrxNoNavigation")]
        public virtual ICollection<Omtx2> Omtx2s { get; set; }
        [InverseProperty("TrxNoNavigation")]
        public virtual ICollection<Omtx6> Omtx6s { get; set; }
    }
}
