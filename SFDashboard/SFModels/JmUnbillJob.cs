using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class JmUnbillJob
    {
        [StringLength(20)]
        public string JobNo { get; set; } = null!;
        [StringLength(3)]
        public string? AirlineCode { get; set; }
        [StringLength(3)]
        public string? AirportDeptCode { get; set; }
        [StringLength(45)]
        public string? AirportDeptName { get; set; }
        [StringLength(3)]
        public string? AirportDestCode { get; set; }
        [StringLength(45)]
        public string? AirportDestName { get; set; }
        [StringLength(20)]
        public string? AwbBlNo { get; set; }
        [StringLength(1)]
        public string? AwbBlStatus { get; set; }
        [StringLength(50)]
        public string? AwbBlType { get; set; }
        [StringLength(1)]
        public string? BillingFlag { get; set; }
        [StringLength(255)]
        public string? BillingInstruction { get; set; }
        [StringLength(255)]
        public string? BillingRemark { get; set; }
        [StringLength(100)]
        public string? CargoDesc { get; set; }
        [StringLength(5)]
        public string? CargoType { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ChargeRate { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? ChargeWeight { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CloseDateTime { get; set; }
        [StringLength(10)]
        public string? ColoaderCode { get; set; }
        [StringLength(10)]
        public string? CommodityCode { get; set; }
        [StringLength(50)]
        public string? CommodityDescription { get; set; }
        [StringLength(10)]
        public string? ConsigneeCode { get; set; }
        [StringLength(80)]
        public string? ConsigneeName { get; set; }
        [StringLength(500)]
        public string? ContainerNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? CostAmt { get; set; }
        [StringLength(1)]
        public string? CostingApproveFlag { get; set; }
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [StringLength(50)]
        public string? CustomerRefNo { get; set; }
        [StringLength(10)]
        public string? DeliveryAgentCode { get; set; }
        [StringLength(80)]
        public string? DeliveryAgentName { get; set; }
        [StringLength(20)]
        public string? DeliveryTerm { get; set; }
        [StringLength(5)]
        public string? DeliveryType { get; set; }
        [StringLength(3)]
        public string? DestCode { get; set; }
        [StringLength(45)]
        public string? DestName { get; set; }
        public byte? EdiCount { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Eta { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Etd { get; set; }
        [StringLength(50)]
        public string? FeederVesselName { get; set; }
        [StringLength(20)]
        public string? FeederVoyage { get; set; }
        [StringLength(5)]
        public string? FirstViaPortCode { get; set; }
        [StringLength(1)]
        public string? FrtPpCcFlag { get; set; }
        [StringLength(255)]
        public string? GeneralRemark { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? GrossProfit { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? GrossWeight { get; set; }
        [Column("HAwbHblNo")]
        [StringLength(20)]
        public string? HawbHblNo { get; set; }
        [StringLength(10)]
        public string? HouseSeqNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? InvoiceLocalAmt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? JobDate { get; set; }
        [StringLength(6)]
        public string? JobMth { get; set; }
        [StringLength(2)]
        public string? JobType { get; set; }
        [StringLength(1)]
        public string? LinkingToAutoJob { get; set; }
        [StringLength(20)]
        public string? MasterJobNo { get; set; }
        [Column("MAwbOblNo")]
        [StringLength(20)]
        public string? MawbOblNo { get; set; }
        [StringLength(1)]
        public string? MiscFlag { get; set; }
        [StringLength(2)]
        public string? ModuleCode { get; set; }
        [StringLength(50)]
        public string? MotherVesselName { get; set; }
        [StringLength(20)]
        public string? MotherVoyage { get; set; }
        [StringLength(20)]
        public string? MultiModalJobNo { get; set; }
        public int? NoOf20ftContainer { get; set; }
        public int? NoOf40ftContainer { get; set; }
        public int? NoOf45ftContainer { get; set; }
        [StringLength(3)]
        public string? OriginCode { get; set; }
        [StringLength(45)]
        public string? OriginName { get; set; }
        [StringLength(1)]
        public string? OtherPpCcFlag { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Payment { get; set; }
        [StringLength(255)]
        public string? PaymentRemark { get; set; }
        [StringLength(255)]
        public string? PaymentInstruction { get; set; }
        public int? Pcs { get; set; }
        [StringLength(260)]
        public string? PermitNo { get; set; }
        [StringLength(30)]
        public string? PlexisOnHandNo { get; set; }
        [StringLength(5)]
        public string? PortOfDischargeCode { get; set; }
        [StringLength(45)]
        public string? PortOfDischargeName { get; set; }
        [StringLength(5)]
        public string? PortOfLoading { get; set; }
        [StringLength(45)]
        public string? PortOfLoadingName { get; set; }
        [StringLength(1)]
        public string? PostFlag { get; set; }
        [StringLength(1)]
        public string? PpCcFlag { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ProvisionCostAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? PurchaseAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ReceiptAmt { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? SalesAmt { get; set; }
        [StringLength(10)]
        public string? SalesmanCode { get; set; }
        [StringLength(2)]
        public string? ShipmentType { get; set; }
        [StringLength(10)]
        public string? ShipperCode { get; set; }
        [StringLength(80)]
        public string? ShipperName { get; set; }
        [StringLength(12)]
        public string? ShippinglineCode { get; set; }
        [StringLength(1)]
        public string? SubMasterFlag { get; set; }
        [StringLength(50)]
        public string? TemplateName { get; set; }
        [StringLength(3)]
        public string? UomCode { get; set; }
        [StringLength(50)]
        public string? VesselCode { get; set; }
        [StringLength(50)]
        public string? VesselName { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Volume { get; set; }
        [StringLength(20)]
        public string? VoyageNo { get; set; }
        [StringLength(50)]
        public string? WorkStation { get; set; }
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
