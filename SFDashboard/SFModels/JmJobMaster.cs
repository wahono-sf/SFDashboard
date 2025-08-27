using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class JmJobMaster
    {
        [Column("Job No")]
        [StringLength(20)]
        public string JobNo { get; set; } = null!;
        [Column("Airline Code")]
        [StringLength(3)]
        public string? AirlineCode { get; set; }
        [Column("Airport Dept Code")]
        [StringLength(3)]
        public string? AirportDeptCode { get; set; }
        [Column("Airport Dept Name")]
        [StringLength(45)]
        public string? AirportDeptName { get; set; }
        [Column("Airport Dest Code")]
        [StringLength(3)]
        public string? AirportDestCode { get; set; }
        [Column("Airport Dest Name")]
        [StringLength(45)]
        public string? AirportDestName { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Awb Bl No")]
        [StringLength(20)]
        public string? AwbBlNo { get; set; }
        [Column("Awb Bl Status")]
        [StringLength(1)]
        public string? AwbBlStatus { get; set; }
        [Column("Awb Bl Type")]
        [StringLength(50)]
        public string? AwbBlType { get; set; }
        [Column("Billing Flag")]
        [StringLength(1)]
        public string? BillingFlag { get; set; }
        [Column("Billing instruction")]
        [StringLength(255)]
        public string? BillingInstruction { get; set; }
        [Column("Billing Remark")]
        [StringLength(255)]
        public string? BillingRemark { get; set; }
        [Column("Business Party Salesman Code")]
        [StringLength(10)]
        public string? BusinessPartySalesmanCode { get; set; }
        [Column("Cargo Desciption")]
        [StringLength(100)]
        public string? CargoDesciption { get; set; }
        [Column("Cargo Type")]
        [StringLength(5)]
        public string? CargoType { get; set; }
        [Column("Charge Rate", TypeName = "decimal(13, 2)")]
        public decimal? ChargeRate { get; set; }
        [Column("Charge Weight", TypeName = "decimal(13, 4)")]
        public decimal? ChargeWeight { get; set; }
        [Column("Close Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CloseDateTime { get; set; }
        [Column("Coloader Code")]
        [StringLength(10)]
        public string? ColoaderCode { get; set; }
        [Column("Commodity Code")]
        [StringLength(10)]
        public string? CommodityCode { get; set; }
        [Column("Commodity Description")]
        [StringLength(50)]
        public string? CommodityDescription { get; set; }
        [Column("Consignee Code")]
        [StringLength(10)]
        public string? ConsigneeCode { get; set; }
        [Column("Consignee Name")]
        [StringLength(80)]
        public string? ConsigneeName { get; set; }
        [Column("Container No")]
        [StringLength(500)]
        public string? ContainerNo { get; set; }
        [Column("Cost Amt", TypeName = "decimal(13, 2)")]
        public decimal? CostAmt { get; set; }
        [Column("Cost Charge Weight", TypeName = "decimal(18, 9)")]
        public decimal? CostChargeWeight { get; set; }
        [Column("Costing Approve Flag")]
        [StringLength(1)]
        public string? CostingApproveFlag { get; set; }
        [Column("Customer Code")]
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [Column("Customer Name")]
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [Column("Customer Ref No")]
        [StringLength(50)]
        public string? CustomerRefNo { get; set; }
        [Column("Delivery Agent Code")]
        [StringLength(10)]
        public string? DeliveryAgentCode { get; set; }
        [Column("Delivery Agent Name")]
        [StringLength(80)]
        public string? DeliveryAgentName { get; set; }
        [Column("Delivery Term")]
        [StringLength(20)]
        public string? DeliveryTerm { get; set; }
        [Column("Delivery Type")]
        [StringLength(5)]
        public string? DeliveryType { get; set; }
        [Column("Dest Code")]
        [StringLength(3)]
        public string? DestCode { get; set; }
        [Column("Dest Name")]
        [StringLength(45)]
        public string? DestName { get; set; }
        [Column("EDI Count")]
        public byte? EdiCount { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? Eta { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? Etd { get; set; }
        [Column("Feeder Vessel Name")]
        [StringLength(50)]
        public string? FeederVesselName { get; set; }
        [Column("Feeder Voyage")]
        [StringLength(20)]
        public string? FeederVoyage { get; set; }
        [Column("First Via Port Code")]
        [StringLength(5)]
        public string? FirstViaPortCode { get; set; }
        [Column("Flight Or Voyage No")]
        [StringLength(20)]
        public string? FlightOrVoyageNo { get; set; }
        [Column("Frt Pp Cc Flag")]
        [StringLength(1)]
        public string? FrtPpCcFlag { get; set; }
        [Column("General Remark")]
        [StringLength(255)]
        public string? GeneralRemark { get; set; }
        [Column("Gross Profit", TypeName = "decimal(13, 2)")]
        public decimal? GrossProfit { get; set; }
        [Column("Gross Weight", TypeName = "decimal(13, 4)")]
        public decimal? GrossWeight { get; set; }
        [Column("H Awb Hbl No")]
        [StringLength(20)]
        public string? HAwbHblNo { get; set; }
        [Column("House Seq No")]
        [StringLength(10)]
        public string? HouseSeqNo { get; set; }
        [Column("Invoice Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? InvoiceDate { get; set; }
        [Column("Invoice Local Amt", TypeName = "decimal(13, 2)")]
        public decimal? InvoiceLocalAmt { get; set; }
        [Column("Invoice No")]
        [StringLength(20)]
        public string? InvoiceNo { get; set; }
        [Column("Job Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? JobDate { get; set; }
        [Column("Job Mth")]
        [StringLength(6)]
        public string? JobMth { get; set; }
        [Column("Job Seq No")]
        [StringLength(20)]
        public string? JobSeqNo { get; set; }
        [Column("Job Type")]
        [StringLength(2)]
        public string? JobType { get; set; }
        [Column("Linking To Auto Job")]
        [StringLength(1)]
        public string? LinkingToAutoJob { get; set; }
        [Column("Master Job No")]
        [StringLength(20)]
        public string? MasterJobNo { get; set; }
        [Column("M Awb Obl No")]
        [StringLength(20)]
        public string? MAwbOblNo { get; set; }
        [Column("Misc Flag")]
        [StringLength(1)]
        public string? MiscFlag { get; set; }
        [Column("Module Code")]
        [StringLength(2)]
        public string? ModuleCode { get; set; }
        [Column("Mother Vessel Name")]
        [StringLength(50)]
        public string? MotherVesselName { get; set; }
        [Column("Mother Voyage")]
        [StringLength(20)]
        public string? MotherVoyage { get; set; }
        [Column("Multi Modal Job No")]
        [StringLength(20)]
        public string? MultiModalJobNo { get; set; }
        [Column("No Of 20ft Container")]
        public int? NoOf20ftContainer { get; set; }
        [Column("No Of 40ft Container")]
        public int? NoOf40ftContainer { get; set; }
        [Column("No Of 45ft Container")]
        public int? NoOf45ftContainer { get; set; }
        [Column("Origin Code")]
        [StringLength(3)]
        public string? OriginCode { get; set; }
        [Column("Origin Name")]
        [StringLength(45)]
        public string? OriginName { get; set; }
        [Column("Other Pp Cc Flag")]
        [StringLength(1)]
        public string? OtherPpCcFlag { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Payment { get; set; }
        [Column("Payment Remark")]
        [StringLength(255)]
        public string? PaymentRemark { get; set; }
        [Column("Payment Instruction")]
        [StringLength(255)]
        public string? PaymentInstruction { get; set; }
        public int? Pcs { get; set; }
        [Column("Permit No")]
        [StringLength(260)]
        public string? PermitNo { get; set; }
        [Column("Plexis On Hand No")]
        [StringLength(30)]
        public string? PlexisOnHandNo { get; set; }
        [Column("Port Of Discharge Code")]
        [StringLength(5)]
        public string? PortOfDischargeCode { get; set; }
        [Column("Port Of Discharge Name")]
        [StringLength(45)]
        public string? PortOfDischargeName { get; set; }
        [Column("Port Of Loading")]
        [StringLength(5)]
        public string? PortOfLoading { get; set; }
        [Column("Port Of Loading Name")]
        [StringLength(45)]
        public string? PortOfLoadingName { get; set; }
        [Column("Post Flag")]
        [StringLength(1)]
        public string? PostFlag { get; set; }
        [Column("Pp Cc Flag")]
        [StringLength(1)]
        public string? PpCcFlag { get; set; }
        [Column("Provision Cost Amt", TypeName = "decimal(13, 2)")]
        public decimal? ProvisionCostAmt { get; set; }
        [Column("Purchase Amt", TypeName = "decimal(13, 2)")]
        public decimal? PurchaseAmt { get; set; }
        [Column("Receipt Amt", TypeName = "decimal(13, 2)")]
        public decimal? ReceiptAmt { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Sales Amt", TypeName = "decimal(13, 2)")]
        public decimal? SalesAmt { get; set; }
        [Column("Salesman Code")]
        [StringLength(10)]
        public string? SalesmanCode { get; set; }
        [Column("Shipment Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ShipmentDate { get; set; }
        [Column("Shipment Type")]
        [StringLength(2)]
        public string? ShipmentType { get; set; }
        [Column("Shipper Code")]
        [StringLength(10)]
        public string? ShipperCode { get; set; }
        [Column("Shipper Name")]
        [StringLength(80)]
        public string? ShipperName { get; set; }
        [Column("Shippingline Code")]
        [StringLength(12)]
        public string? ShippinglineCode { get; set; }
        [Column("Sub Master Flag")]
        [StringLength(1)]
        public string? SubMasterFlag { get; set; }
        [Column("Template Name")]
        [StringLength(50)]
        public string? TemplateName { get; set; }
        [Column("Uom Code")]
        [StringLength(3)]
        public string? UomCode { get; set; }
        [Column("Vessel Code")]
        [StringLength(50)]
        public string? VesselCode { get; set; }
        [Column("Vessel Name")]
        [StringLength(50)]
        public string? VesselName { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Volume { get; set; }
        [Column("Voyage No")]
        [StringLength(20)]
        public string? VoyageNo { get; set; }
        [Column("Work Station")]
        [StringLength(50)]
        public string? WorkStation { get; set; }
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
