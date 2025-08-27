using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("jmjm1")]
    [Index("CustomerRefNo", Name = "INDEX_Jmjm1_CustomerRefNo")]
    [Index("JobMth", Name = "INDEX_Jmjm1_JobMth")]
    [Index("JobNo", Name = "INDEX_Jmjm1_JobNo", IsUnique = true)]
    [Index("JobType", Name = "INDEX_Jmjm1_JobType")]
    [Index("MasterJobNo", Name = "INDEX_Jmjm1_MasterJobNo")]
    [Index("ModuleCode", Name = "INDEX_Jmjm1_ModuleCode")]
    [Index("SalesmanCode", Name = "INDEX_Jmjm1_SalesmanCode")]
    [Index("StatusCode", Name = "INDEX_Jmjm1_StatusCode")]
    [Index("UpdateDateTime", Name = "INDEX_Jmjm1_UpdateDateTime")]
    [Index("UpdateDateTime", "JobNo", Name = "INDEX_Jmjm1_UpdateDateTime_JobNo")]
    [Index("UserGroup", Name = "INDEX_Jmjm1_UserGroup")]
    public partial class Jmjm1
    {
        [Key]
        [StringLength(30)]
        public string JobNo { get; set; } = null!;
        [Column(TypeName = "decimal(20, 2)")]
        public decimal? AgentSellAmt { get; set; }
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
        [Column("AJU")]
        [StringLength(50)]
        public string? Aju { get; set; }
        [StringLength(10)]
        public string? AlsoNotifyPartyCode { get; set; }
        [StringLength(80)]
        public string? AlsoNotifyPartyName { get; set; }
        [StringLength(30)]
        public string? AwbBlNo { get; set; }
        [StringLength(1)]
        public string? AwbBlStatus { get; set; }
        [StringLength(50)]
        public string? AwbBlType { get; set; }
        [Column("BC11")]
        [StringLength(50)]
        public string? Bc11 { get; set; }
        [Column("BC2023")]
        [StringLength(50)]
        public string? Bc2023 { get; set; }
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
        [StringLength(50)]
        public string? CloseJobBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CloseJobDateTime { get; set; }
        [StringLength(10)]
        public string? CollectFromCode { get; set; }
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
        [Column(TypeName = "datetime")]
        public DateTime? CollectionDateTime { get; set; }
        [StringLength(10)]
        public string? CollectionFromPlace { get; set; }
        [StringLength(10)]
        public string? ColoaderCode { get; set; }
        [StringLength(50)]
        public string? CommodityCode { get; set; }
        [StringLength(50)]
        public string? CommodityDescription { get; set; }
        [StringLength(10)]
        public string? ConsigneeCode { get; set; }
        [StringLength(80)]
        public string? ConsigneeName { get; set; }
        [StringLength(1000)]
        public string? ContainerNo { get; set; }
        [StringLength(5)]
        public string? ContainerType1 { get; set; }
        [StringLength(5)]
        public string? ContainerType2 { get; set; }
        [StringLength(5)]
        public string? ContainerType3 { get; set; }
        [StringLength(5)]
        public string? ContainerType4 { get; set; }
        [StringLength(50)]
        public string? CopyTemplateName { get; set; }
        [StringLength(255)]
        public string? CopyTemplateRemark { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? CostAmt { get; set; }
        [StringLength(1)]
        public string? CostingApproveFlag { get; set; }
        [StringLength(1)]
        public string? CustomApproveFlag { get; set; }
        [StringLength(1)]
        public string? CustomBrokerageFlag { get; set; }
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
        [Column(TypeName = "datetime")]
        public DateTime? DeliveryDateTime { get; set; }
        [StringLength(60)]
        public string? DeliveryInstruction1 { get; set; }
        [StringLength(60)]
        public string? DeliveryInstruction2 { get; set; }
        [StringLength(60)]
        public string? DeliveryInstruction3 { get; set; }
        [StringLength(60)]
        public string? DeliveryInstruction4 { get; set; }
        [StringLength(60)]
        public string? DeliveryInstruction5 { get; set; }
        [StringLength(20)]
        public string? DeliveryTerm { get; set; }
        [StringLength(10)]
        public string? DeliveryToCode { get; set; }
        [StringLength(80)]
        public string? DeliveryToName { get; set; }
        [StringLength(50)]
        public string? DeliveryToAddress1 { get; set; }
        [StringLength(50)]
        public string? DeliveryToAddress2 { get; set; }
        [StringLength(50)]
        public string? DeliveryToAddress3 { get; set; }
        [StringLength(50)]
        public string? DeliveryToAddress4 { get; set; }
        [StringLength(5)]
        public string? DeliveryType { get; set; }
        [StringLength(3)]
        public string? DestCode { get; set; }
        [StringLength(45)]
        public string? DestName { get; set; }
        [StringLength(15)]
        public string? DriverCode { get; set; }
        [StringLength(50)]
        public string? DriverName { get; set; }
        [StringLength(30)]
        public string? DriverContactNo1 { get; set; }
        [StringLength(30)]
        public string? DriverContactNo2 { get; set; }
        [StringLength(15)]
        public string? Driver2Code { get; set; }
        [StringLength(50)]
        public string? Driver2Name { get; set; }
        [StringLength(30)]
        public string? Driver2ContactNo1 { get; set; }
        [StringLength(30)]
        public string? Driver2ContactNo2 { get; set; }
        public byte? EdiCount { get; set; }
        [StringLength(50)]
        public string? EdiRemark { get; set; }
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
        [StringLength(50)]
        public string? Freetime { get; set; }
        [StringLength(1)]
        public string? FrtPpCcFlag { get; set; }
        [StringLength(255)]
        public string? GeneralRemark { get; set; }
        [Column("GeneratingBBFeeFlag")]
        [StringLength(1)]
        public string? GeneratingBbfeeFlag { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? GrossProfit { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? GrossWeight { get; set; }
        [Column("HAwbHblNo")]
        [StringLength(30)]
        public string? HawbHblNo { get; set; }
        [StringLength(10)]
        public string? HouseSeqNo { get; set; }
        [StringLength(1)]
        public string? InvoiceCompleteFlag { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? InvoiceLocalAmt { get; set; }
        [StringLength(255)]
        public string? JobCostingRemark { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? JobDate { get; set; }
        [StringLength(240)]
        public string? JobDescription { get; set; }
        [StringLength(6)]
        public string? JobMth { get; set; }
        [StringLength(10)]
        public string? JobType { get; set; }
        [StringLength(1)]
        public string? LinkingToAutoJob { get; set; }
        [StringLength(1)]
        public string? LocalJobFlag { get; set; }
        [StringLength(1)]
        public string? LockDocumentFlag { get; set; }
        [StringLength(30)]
        public string? MasterJobNo { get; set; }
        [Column("MAwbOblNo")]
        [StringLength(30)]
        public string? MawbOblNo { get; set; }
        [StringLength(1)]
        public string? MiscFlag { get; set; }
        [StringLength(2)]
        public string? ModuleCode { get; set; }
        [StringLength(50)]
        public string? MotherVesselName { get; set; }
        [StringLength(20)]
        public string? MotherVoyage { get; set; }
        [StringLength(1)]
        public string? MultiModalFlag { get; set; }
        [StringLength(30)]
        public string? MultiModalJobNo { get; set; }
        public int? NoOf20ftContainer { get; set; }
        public int? NoOf40ftContainer { get; set; }
        public int? NoOf45ftContainer { get; set; }
        public int? NoOfContainer1 { get; set; }
        public int? NoOfContainer2 { get; set; }
        public int? NoOfContainer3 { get; set; }
        public int? NoOfContainer4 { get; set; }
        [StringLength(255)]
        public string? Note { get; set; }
        [StringLength(10)]
        public string? NotifyPartyCode { get; set; }
        [StringLength(80)]
        public string? NotifyPartyName { get; set; }
        [StringLength(3)]
        public string? OriginCode { get; set; }
        [StringLength(45)]
        public string? OriginName { get; set; }
        [StringLength(30)]
        public string? OriginalJobNo { get; set; }
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
        [StringLength(10)]
        public string? Place { get; set; }
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
        [StringLength(10)]
        public string? ProductCode { get; set; }
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
        [StringLength(30)]
        public string? SourceJobNo { get; set; }
        [StringLength(20)]
        public string? SourceSiteCode { get; set; }
        [StringLength(1)]
        public string? SubMasterFlag { get; set; }
        [StringLength(1)]
        public string? SuspenseInvoiceAgentFlag { get; set; }
        [StringLength(1)]
        public string? SuspenseInvoiceAirlineFlag { get; set; }
        [StringLength(50)]
        public string? TemplateName { get; set; }
        [StringLength(3)]
        public string? Termcode { get; set; }
        [StringLength(50)]
        public string? TotalPackages { get; set; }
        [StringLength(10)]
        public string? TransportCompanyCode { get; set; }
        [StringLength(80)]
        public string? TransportCompanyName { get; set; }
        [StringLength(50)]
        public string? TransportCompanyAddress1 { get; set; }
        [StringLength(50)]
        public string? TransportCompanyAddress2 { get; set; }
        [StringLength(50)]
        public string? TransportCompanyAddress3 { get; set; }
        [StringLength(50)]
        public string? TransportCompanyAddress4 { get; set; }
        [StringLength(30)]
        public string? TransportJobNo { get; set; }
        [StringLength(50)]
        public string? UomCode { get; set; }
        [StringLength(255)]
        public string? UserDefine01 { get; set; }
        [StringLength(255)]
        public string? UserDefine02 { get; set; }
        [StringLength(255)]
        public string? UserDefine03 { get; set; }
        [StringLength(255)]
        public string? UserDefine04 { get; set; }
        [StringLength(255)]
        public string? UserDefine05 { get; set; }
        [StringLength(255)]
        public string? UserDefine06 { get; set; }
        [StringLength(255)]
        public string? UserDefine07 { get; set; }
        [StringLength(255)]
        public string? UserDefine08 { get; set; }
        [StringLength(255)]
        public string? UserDefine09 { get; set; }
        [StringLength(255)]
        public string? UserDefine10 { get; set; }
        [StringLength(255)]
        public string? UserDefine11 { get; set; }
        [StringLength(255)]
        public string? UserDefine12 { get; set; }
        [StringLength(255)]
        public string? UserDefine13 { get; set; }
        [StringLength(255)]
        public string? UserDefine14 { get; set; }
        [StringLength(255)]
        public string? UserDefine15 { get; set; }
        [StringLength(255)]
        public string? UserDefine16 { get; set; }
        [StringLength(255)]
        public string? UserDefine17 { get; set; }
        [StringLength(255)]
        public string? UserDefine18 { get; set; }
        [StringLength(255)]
        public string? UserDefine19 { get; set; }
        [StringLength(255)]
        public string? UserDefine20 { get; set; }
        [StringLength(255)]
        public string? UserDefine21 { get; set; }
        [StringLength(255)]
        public string? UserDefine22 { get; set; }
        [StringLength(255)]
        public string? UserDefine23 { get; set; }
        [StringLength(255)]
        public string? UserDefine24 { get; set; }
        [StringLength(255)]
        public string? UserDefine25 { get; set; }
        [StringLength(255)]
        public string? UserDefine26 { get; set; }
        [StringLength(255)]
        public string? UserDefine27 { get; set; }
        [StringLength(255)]
        public string? UserDefine28 { get; set; }
        [StringLength(255)]
        public string? UserDefine29 { get; set; }
        [StringLength(255)]
        public string? UserDefine30 { get; set; }
        [StringLength(255)]
        public string? UserDefine31 { get; set; }
        [StringLength(255)]
        public string? UserDefine32 { get; set; }
        [StringLength(255)]
        public string? UserDefine33 { get; set; }
        [StringLength(255)]
        public string? UserDefine34 { get; set; }
        [StringLength(255)]
        public string? UserDefine35 { get; set; }
        [StringLength(255)]
        public string? UserDefine36 { get; set; }
        [StringLength(255)]
        public string? UserDefine37 { get; set; }
        [StringLength(255)]
        public string? UserDefine38 { get; set; }
        [StringLength(255)]
        public string? UserDefine39 { get; set; }
        [StringLength(255)]
        public string? UserDefine40 { get; set; }
        [StringLength(255)]
        public string? UserDefine41 { get; set; }
        [StringLength(255)]
        public string? UserDefine42 { get; set; }
        [StringLength(255)]
        public string? UserDefine43 { get; set; }
        [StringLength(255)]
        public string? UserDefine44 { get; set; }
        [StringLength(255)]
        public string? UserDefine45 { get; set; }
        [StringLength(255)]
        public string? UserDefine46 { get; set; }
        [StringLength(255)]
        public string? UserDefine47 { get; set; }
        [StringLength(255)]
        public string? UserDefine48 { get; set; }
        [StringLength(255)]
        public string? UserDefine49 { get; set; }
        [StringLength(255)]
        public string? UserDefine50 { get; set; }
        [StringLength(10)]
        public string? UserGroup { get; set; }
        [StringLength(12)]
        public string? VehicleNo { get; set; }
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
        [StringLength(10)]
        public string? OriginalBranchCode { get; set; }
        [StringLength(10)]
        public string? OriginalDepartmentCode { get; set; }
        [StringLength(10)]
        public string? BranchCode { get; set; }
        [StringLength(10)]
        public string? DepartmentCode { get; set; }
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
