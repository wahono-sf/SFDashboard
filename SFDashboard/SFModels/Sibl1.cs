using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("sibl1")]
    [Index("BlNo", Name = "INDEX_Sibl1_BlNo")]
    [Index("ConsigneeName", Name = "INDEX_Sibl1_ConsigneeName")]
    [Index("ContainerNo", Name = "INDEX_Sibl1_ContainerNo")]
    [Index("CustomerName", Name = "INDEX_Sibl1_CustomerName")]
    [Index("DeliveryAgentName", Name = "INDEX_Sibl1_DeliveryAgentName")]
    [Index("EtaDate", Name = "INDEX_Sibl1_EtaDate")]
    [Index("JobNo", Name = "INDEX_Sibl1_JobNo")]
    [Index("JobType", Name = "INDEX_Sibl1_JobType")]
    [Index("MasterJobNo", Name = "INDEX_Sibl1_MasterJobNo")]
    [Index("PortOfLoadingCode", Name = "INDEX_Sibl1_PortOfLoadingCode")]
    [Index("PortOfLoadingName", Name = "INDEX_Sibl1_PortOfLoadingName")]
    [Index("SalesmanCode", Name = "INDEX_Sibl1_SalesmanCode")]
    [Index("StatusCode", Name = "INDEX_Sibl1_StatusCode")]
    [Index("UpdateDateTime", Name = "INDEX_Sibl1_UpdateDateTime")]
    [Index("VesselCode", Name = "INDEX_Sibl1_VesselCode")]
    [Index("WorkStation", Name = "INDEX_Sibl1_WorkStation")]
    [Index("UserGroup", Name = "IX_Sibl1_UserGroup_1")]
    public partial class Sibl1
    {
        public Sibl1()
        {
            Sibl2s = new HashSet<Sibl2>();
            Sibl3s = new HashSet<Sibl3>();
            Sibl4s = new HashSet<Sibl4>();
            Sibl5s = new HashSet<Sibl5>();
        }

        [Key]
        public int TrxNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? AgentCcAmt { get; set; }
        [StringLength(10)]
        public string? AgentCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? AgentPpAmt { get; set; }
        [StringLength(1)]
        public string? AirExportFlag { get; set; }
        [StringLength(10)]
        public string? AlsoNotifyCode { get; set; }
        [StringLength(80)]
        public string? AlsoNotifyName { get; set; }
        [StringLength(15)]
        public string? AlsoNotifyAcctCode { get; set; }
        [StringLength(50)]
        public string? AlsoNotifyAddress1 { get; set; }
        [StringLength(50)]
        public string? AlsoNotifyAddress2 { get; set; }
        [StringLength(50)]
        public string? AlsoNotifyAddress3 { get; set; }
        [StringLength(50)]
        public string? AlsoNotifyAddress4 { get; set; }
        [StringLength(30)]
        public string? AlternateBlNo { get; set; }
        [StringLength(10)]
        public string? AppointAgentCode { get; set; }
        [StringLength(80)]
        public string? AppointAgentName { get; set; }
        [StringLength(50)]
        public string? AppointAgentAddress1 { get; set; }
        [StringLength(50)]
        public string? AppointAgentAddress2 { get; set; }
        [StringLength(50)]
        public string? AppointAgentAddress3 { get; set; }
        [StringLength(50)]
        public string? AppointAgentAddress4 { get; set; }
        [StringLength(50)]
        public string? AppointAgentContactName { get; set; }
        [StringLength(30)]
        public string? AppointAgentFax { get; set; }
        [StringLength(30)]
        public string? AppointAgentTelephone { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ArrivalDateTime { get; set; }
        [StringLength(50)]
        public string? ArrivalNoticeBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ArrivalNoticeDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AtaDate { get; set; }
        [StringLength(50)]
        public string? BarCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BillingDate { get; set; }
        [StringLength(255)]
        public string? BillingInstruction { get; set; }
        [StringLength(2)]
        public string? BillMode { get; set; }
        [StringLength(8)]
        public string? BillToCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BlIssueDate { get; set; }
        [StringLength(45)]
        public string? BlIssuePlace { get; set; }
        [StringLength(30)]
        public string BlNo { get; set; } = null!;
        [StringLength(10)]
        public string? BlType { get; set; }
        [StringLength(10)]
        public string? BreakBulkAgentCode { get; set; }
        [StringLength(80)]
        public string? BreakBulkAgentName { get; set; }
        [StringLength(50)]
        public string? BreakBulkAgentAddress1 { get; set; }
        [StringLength(50)]
        public string? BreakBulkAgentAddress2 { get; set; }
        [StringLength(50)]
        public string? BreakBulkAgentAddress3 { get; set; }
        [StringLength(50)]
        public string? BreakBulkAgentAddress4 { get; set; }
        [StringLength(50)]
        public string? BreakBulkAgentContactName { get; set; }
        [StringLength(50)]
        public string? ByWhom { get; set; }
        [StringLength(100)]
        public string? CarModel { get; set; }
        [StringLength(10)]
        public string? CargoClass { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CargoCollectionDate { get; set; }
        [StringLength(255)]
        public string? CargoLocation { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CargoRcvDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CargoReadyDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CargoReceiptDate { get; set; }
        [StringLength(1)]
        public string? CargoReceiptFlag { get; set; }
        [StringLength(5)]
        public string? CargoType { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? CarrierCcAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? CarrierPpAmt { get; set; }
        [StringLength(255)]
        public string? CfsChargeInstruction { get; set; }
        [StringLength(50)]
        public string? CfsUpdateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CfsUpdateDateTime { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ChargeCollectAmt { get; set; }
        [StringLength(80)]
        public string? ChargeCollectRemark { get; set; }
        [StringLength(200)]
        public string? ChassisNo { get; set; }
        [StringLength(50)]
        public string? ClearBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ClearDateTime { get; set; }
        [StringLength(255)]
        public string? ClearingRemark { get; set; }
        [StringLength(8)]
        public string? ClientCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? CollectCashAmt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CollectDateTime { get; set; }
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
        [StringLength(50)]
        public string? CollectFromContactName { get; set; }
        [StringLength(10)]
        public string? CollectionFromPlace { get; set; }
        [StringLength(10)]
        public string? ColoaderCode { get; set; }
        [StringLength(80)]
        public string? ColoaderName { get; set; }
        [StringLength(20)]
        public string? ColoaderRefNo { get; set; }
        [StringLength(50)]
        public string? CommodityCode { get; set; }
        [StringLength(50)]
        public string? CommodityDescription { get; set; }
        [StringLength(255)]
        public string? CommodityDescription01 { get; set; }
        [StringLength(10)]
        public string? ConsigneeCode { get; set; }
        [StringLength(80)]
        public string? ConsigneeName { get; set; }
        [StringLength(16)]
        public string? ConsigneeAccCode { get; set; }
        [StringLength(50)]
        public string? ConsigneeAddress1 { get; set; }
        [StringLength(50)]
        public string? ConsigneeAddress2 { get; set; }
        [StringLength(50)]
        public string? ConsigneeAddress3 { get; set; }
        [StringLength(50)]
        public string? ConsigneeAddress4 { get; set; }
        [StringLength(50)]
        public string? ConsigneeContact { get; set; }
        [StringLength(10)]
        public string? ConsigneePostalCode { get; set; }
        [StringLength(30)]
        public string? ConsigneeTelephone { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ContainerDepositAmt { get; set; }
        [StringLength(1000)]
        public string? ContainerNo { get; set; }
        [StringLength(2000)]
        public string? ContainerNoType { get; set; }
        [StringLength(2000)]
        public string? ContainerSealNo { get; set; }
        [StringLength(2000)]
        public string? ContainerSealNoType { get; set; }
        [StringLength(4)]
        public string? ContrFlag { get; set; }
        [StringLength(50)]
        public string? CopyTemplateName { get; set; }
        [StringLength(255)]
        public string? CopyTemplateRemark { get; set; }
        [StringLength(15)]
        public string? CrNo { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? CustomDeclareValue { get; set; }
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [StringLength(50)]
        public string? CustomerContactName { get; set; }
        [StringLength(50)]
        public string? CustomerRefNo { get; set; }
        [StringLength(10)]
        public string? DeliveryAgentCode { get; set; }
        [StringLength(80)]
        public string? DeliveryAgentName { get; set; }
        [StringLength(50)]
        public string? DeliveryAgentAddress1 { get; set; }
        [StringLength(50)]
        public string? DeliveryAgentAddress2 { get; set; }
        [StringLength(50)]
        public string? DeliveryAgentAddress3 { get; set; }
        [StringLength(50)]
        public string? DeliveryAgentAddress4 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DeliveryDate { get; set; }
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
        [StringLength(60)]
        public string? DeliveryInstruction6 { get; set; }
        [StringLength(60)]
        public string? DeliveryInstruction7 { get; set; }
        [StringLength(60)]
        public string? DeliveryInstruction8 { get; set; }
        [StringLength(50)]
        public string? DeliveryInstructionTemplateName { get; set; }
        [StringLength(10)]
        public string? DeliveryNo { get; set; }
        [StringLength(20)]
        public string? DeliveryOrderNo { get; set; }
        [StringLength(1)]
        public string? DeliveryOrderReadyFlag { get; set; }
        [StringLength(50)]
        public string? DeliveryOrderReadyRemark { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DeliveryOrderReleaseDate { get; set; }
        [StringLength(80)]
        public string? DeliveryOrderReleaseTo { get; set; }
        public int? DeliveryPcs { get; set; }
        [StringLength(80)]
        public string? DeliveryTemplateName { get; set; }
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
        [StringLength(50)]
        public string? DeliveryToContactName { get; set; }
        [StringLength(5)]
        public string? DeliveryType { get; set; }
        public int? DemurrageFreeDay { get; set; }
        [StringLength(10)]
        public string? DepotCode { get; set; }
        [StringLength(80)]
        public string? DepotName { get; set; }
        [StringLength(50)]
        public string? DepotAddress1 { get; set; }
        [StringLength(50)]
        public string? DepotAddress2 { get; set; }
        [StringLength(50)]
        public string? DepotAddress3 { get; set; }
        [StringLength(50)]
        public string? DepotAddress4 { get; set; }
        [StringLength(60)]
        public string? DepotInstruction1 { get; set; }
        [StringLength(60)]
        public string? DepotInstruction2 { get; set; }
        [StringLength(60)]
        public string? DepotInstruction3 { get; set; }
        [StringLength(60)]
        public string? DepotInstruction4 { get; set; }
        [StringLength(100)]
        public string? DescrepancyDesc { get; set; }
        [StringLength(5)]
        public string? DestCargoType { get; set; }
        [StringLength(3)]
        public string? DestCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DestEta { get; set; }
        [StringLength(45)]
        public string? DestName { get; set; }
        public int? DetentionFreeDay { get; set; }
        [StringLength(1)]
        public string? DgFlag { get; set; }
        [StringLength(10)]
        public string? DivisionCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocRcvDate { get; set; }
        [StringLength(20)]
        public string? DocRefNo { get; set; }
        [StringLength(255)]
        public string? DocRemark { get; set; }
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
        public byte? EmailCount { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EmptyContainerDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EtaDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EtdDate { get; set; }
        [StringLength(255)]
        public string? ExportBookingNo { get; set; }
        [StringLength(10)]
        public string? ExportColoaderCode { get; set; }
        [StringLength(80)]
        public string? ExportColoaderName { get; set; }
        [StringLength(20)]
        public string? ExportColoaderRefNo { get; set; }
        public byte? ExportCount { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ExportEta { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ExportEtd { get; set; }
        [StringLength(255)]
        public string? ExportJobNo { get; set; }
        [StringLength(255)]
        public string? ExportNote { get; set; }
        [StringLength(5)]
        public string? ExportPortOfDischargeCode { get; set; }
        [StringLength(50)]
        public string? ExportVesselCode { get; set; }
        [StringLength(80)]
        public string? ExportVesselName { get; set; }
        [StringLength(20)]
        public string? ExportVoyage { get; set; }
        public byte? FaxCount { get; set; }
        [StringLength(50)]
        public string? FeederVesselName { get; set; }
        [StringLength(20)]
        public string? FeederVoyage { get; set; }
        [StringLength(5)]
        public string? FifthViaPortCode { get; set; }
        [StringLength(5)]
        public string? FirstViaPortCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FirstViaEtaDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FirstViaEtdDate { get; set; }
        [StringLength(12)]
        public string? FirstViaShippingLineCode { get; set; }
        [StringLength(50)]
        public string? FirstViaVesselCode { get; set; }
        [StringLength(50)]
        public string? FirstViaVesselName { get; set; }
        [StringLength(20)]
        public string? FlashPoint { get; set; }
        [StringLength(80)]
        public string? Footer1 { get; set; }
        [StringLength(80)]
        public string? Footer2 { get; set; }
        [StringLength(80)]
        public string? Footer3 { get; set; }
        [StringLength(80)]
        public string? Footer4 { get; set; }
        [StringLength(80)]
        public string? Footer5 { get; set; }
        [StringLength(50)]
        public string? FooterTemplateName { get; set; }
        [StringLength(5)]
        public string? FourthViaPortCode { get; set; }
        [StringLength(10)]
        public string? FrtBillPartyCode { get; set; }
        [StringLength(1)]
        public string? FrtPpCcFlag { get; set; }
        [StringLength(255)]
        public string? HaulierRemark { get; set; }
        [Column("HBlNo")]
        [StringLength(30)]
        public string? HblNo { get; set; }
        [StringLength(30)]
        public string? HouseJobNo { get; set; }
        [StringLength(20)]
        public string? Imco { get; set; }
        [StringLength(3)]
        public string? ImportCurrCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ImportRate { get; set; }
        [StringLength(80)]
        public string? Instruction1 { get; set; }
        [StringLength(80)]
        public string? Instruction2 { get; set; }
        [StringLength(80)]
        public string? Instruction3 { get; set; }
        [StringLength(80)]
        public string? Instruction4 { get; set; }
        [StringLength(50)]
        public string? InstructionTemplateName { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? InsuranceAmt { get; set; }
        [StringLength(50)]
        public string? IssueBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? JobDate { get; set; }
        [StringLength(6)]
        public string? JobMth { get; set; }
        [StringLength(30)]
        public string? JobNo { get; set; }
        [StringLength(10)]
        public string? JobType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LadenDate { get; set; }
        [StringLength(50)]
        public string? LetterOfCreditNo { get; set; }
        [StringLength(50)]
        public string? Marking { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? MasterGrossWeight { get; set; }
        [StringLength(30)]
        public string? MasterJobNo { get; set; }
        public int? MasterPcs { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? MasterVolume { get; set; }
        [StringLength(50)]
        public string? MotherVesselName { get; set; }
        [StringLength(20)]
        public string? MotherVoyage { get; set; }
        [Column("NBlNo")]
        [StringLength(30)]
        public string? NblNo { get; set; }
        [StringLength(10)]
        public string? NominationCustomerCode { get; set; }
        [StringLength(1)]
        public string? NominationFlag { get; set; }
        [StringLength(50)]
        public string? NominationRemark { get; set; }
        public int? NoOf20ftContainer { get; set; }
        public int? NoOf40ftContainer { get; set; }
        public int? NoOf45ftContainer { get; set; }
        public byte? NoOfOriginBl { get; set; }
        [StringLength(2000)]
        public string? Note { get; set; }
        [StringLength(10)]
        public string? NotifyCode { get; set; }
        [StringLength(80)]
        public string? NotifyName { get; set; }
        [StringLength(15)]
        public string? NotifyAcctCode { get; set; }
        [StringLength(50)]
        public string? NotifyAddress1 { get; set; }
        [StringLength(50)]
        public string? NotifyAddress2 { get; set; }
        [StringLength(50)]
        public string? NotifyAddress3 { get; set; }
        [StringLength(50)]
        public string? NotifyAddress4 { get; set; }
        [StringLength(10)]
        public string? NvoccCode { get; set; }
        [Column("OBlNo")]
        [StringLength(30)]
        public string? OblNo { get; set; }
        [StringLength(30)]
        public string? OriginBlNo { get; set; }
        [StringLength(3)]
        public string? OriginCode { get; set; }
        [StringLength(45)]
        public string? OriginName { get; set; }
        [StringLength(10)]
        public string? OtherBillPartyCode { get; set; }
        [StringLength(1)]
        public string? OtherPpCcFlag { get; set; }
        [StringLength(45)]
        public string? PayableAmt { get; set; }
        [StringLength(1)]
        public string? PermitFlag { get; set; }
        [StringLength(260)]
        public string? PermitNo { get; set; }
        [StringLength(20)]
        public string? PhoneNo { get; set; }
        [StringLength(10)]
        public string? Place { get; set; }
        [StringLength(45)]
        public string? PlaceOfDelivery { get; set; }
        [StringLength(45)]
        public string? PlaceOfReceipt { get; set; }
        [StringLength(5)]
        public string? PortOfDischargeCode { get; set; }
        [StringLength(45)]
        public string? PortOfDischargeName { get; set; }
        [StringLength(5)]
        public string? PortOfLoadingCode { get; set; }
        [StringLength(45)]
        public string? PortOfLoadingName { get; set; }
        [StringLength(45)]
        public string? PpAt { get; set; }
        [StringLength(12)]
        public string? PrincipleAgentCode { get; set; }
        public byte? PrintCount { get; set; }
        [StringLength(80)]
        public string? Psn { get; set; }
        [StringLength(15)]
        public string? QuotationNo { get; set; }
        [StringLength(20)]
        public string? RateGroup { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Rebate { get; set; }
        [StringLength(1)]
        public string? RebateFlag { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? RebatePerShp { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? ReceiptGrossWeight { get; set; }
        public int? ReceiptPcs { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? ReceiptVolume { get; set; }
        [StringLength(5)]
        public string? RecStatus { get; set; }
        [StringLength(1000)]
        public string? Remark { get; set; }
        [StringLength(20)]
        public string? SalesCoordinator1 { get; set; }
        [StringLength(20)]
        public string? SalesCoordinator2 { get; set; }
        [StringLength(80)]
        public string? SalesDescription1 { get; set; }
        [StringLength(80)]
        public string? SalesDescription2 { get; set; }
        [StringLength(10)]
        public string? SalesmanCode { get; set; }
        [Column("SBlNo")]
        [StringLength(30)]
        public string? SblNo { get; set; }
        [StringLength(10)]
        public string? ScnCode { get; set; }
        [StringLength(1)]
        public string? SeaExportFlag { get; set; }
        [StringLength(5)]
        public string? SecondViaPortCode { get; set; }
        [StringLength(10)]
        public string? ServiceLevel { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ShipDate { get; set; }
        [StringLength(16)]
        public string? ShipmentId { get; set; }
        [StringLength(1)]
        public string? ShipmentType { get; set; }
        [StringLength(50)]
        public string? ShipMode { get; set; }
        [StringLength(10)]
        public string? ShipperCode { get; set; }
        [StringLength(80)]
        public string? ShipperName { get; set; }
        [StringLength(16)]
        public string? ShipperAccCode { get; set; }
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
        [StringLength(20)]
        public string? SiteCode { get; set; }
        [StringLength(12)]
        public string? SmkShipAgentCode { get; set; }
        [StringLength(5)]
        public string? SourceCompanyCode { get; set; }
        [StringLength(50)]
        public string? SourceCreateBy { get; set; }
        [StringLength(50)]
        public string? SourceJobCreateBy { get; set; }
        [StringLength(30)]
        public string? SourceJobNo { get; set; }
        public int? SourceJobTrxNo { get; set; }
        [StringLength(20)]
        public string? SourceSiteCode { get; set; }
        [StringLength(1)]
        public string? SubMasterFlag { get; set; }
        [StringLength(3)]
        public string? SupplierCurrCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SwitchBlIssueDate { get; set; }
        [StringLength(45)]
        public string? SwitchBlIssuePlace { get; set; }
        [StringLength(10)]
        public string? SwitchConsigneeCode { get; set; }
        [StringLength(80)]
        public string? SwitchConsigneeName { get; set; }
        [StringLength(50)]
        public string? SwitchConsigneeAddress1 { get; set; }
        [StringLength(50)]
        public string? SwitchConsigneeAddress2 { get; set; }
        [StringLength(50)]
        public string? SwitchConsigneeAddress3 { get; set; }
        [StringLength(50)]
        public string? SwitchConsigneeAddress4 { get; set; }
        [StringLength(10)]
        public string? SwitchDeliveryAgentCode { get; set; }
        [StringLength(80)]
        public string? SwitchDeliveryAgentName { get; set; }
        [StringLength(50)]
        public string? SwitchDeliveryAgentAddress1 { get; set; }
        [StringLength(50)]
        public string? SwitchDeliveryAgentAddress2 { get; set; }
        [StringLength(50)]
        public string? SwitchDeliveryAgentAddress3 { get; set; }
        [StringLength(50)]
        public string? SwitchDeliveryAgentAddress4 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SwitchLadenDate { get; set; }
        [StringLength(10)]
        public string? SwitchNotifyCode { get; set; }
        [StringLength(80)]
        public string? SwitchNotifyName { get; set; }
        [StringLength(50)]
        public string? SwitchNotifyAddress1 { get; set; }
        [StringLength(50)]
        public string? SwitchNotifyAddress2 { get; set; }
        [StringLength(50)]
        public string? SwitchNotifyAddress3 { get; set; }
        [StringLength(50)]
        public string? SwitchNotifyAddress4 { get; set; }
        [StringLength(10)]
        public string? SwitchShipperCode { get; set; }
        [StringLength(80)]
        public string? SwitchShipperName { get; set; }
        [StringLength(50)]
        public string? SwitchShipperAddress1 { get; set; }
        [StringLength(50)]
        public string? SwitchShipperAddress2 { get; set; }
        [StringLength(50)]
        public string? SwitchShipperAddress3 { get; set; }
        [StringLength(50)]
        public string? SwitchShipperAddress4 { get; set; }
        [StringLength(50)]
        public string? SwitchVesselName { get; set; }
        [StringLength(20)]
        public string? SwitchVoyageNo { get; set; }
        [StringLength(10)]
        public string? TableName { get; set; }
        [StringLength(50)]
        public string? TallyBy { get; set; }
        [StringLength(5)]
        public string? TargetCompanyCode { get; set; }
        [StringLength(30)]
        public string? TargetJobNo { get; set; }
        [StringLength(20)]
        public string? TargetSiteCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TaxCcAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TaxPpAmt { get; set; }
        [StringLength(1)]
        public string? TelexReleaseFlag { get; set; }
        [StringLength(50)]
        public string? TemplateName { get; set; }
        [StringLength(20)]
        public string? Terminal { get; set; }
        [StringLength(5)]
        public string? ThirdViaPortCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? TotalActualVolume { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? TotalChargeWeight { get; set; }
        [StringLength(50)]
        public string? TotalContainer { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? TotalGrossWeight { get; set; }
        public int? TotalPcs { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? TotalVolume { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TranshipmentAmt { get; set; }
        [StringLength(3)]
        public string? TranshipmentCurrCode { get; set; }
        [StringLength(2)]
        public string? TranshipmentFlag { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TranshipmentRate { get; set; }
        [StringLength(50)]
        public string? TranshipmentRateRemark { get; set; }
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
        [StringLength(50)]
        public string? TransportCompanyContactName { get; set; }
        [StringLength(30)]
        public string? TransportCompanyFax { get; set; }
        [StringLength(30)]
        public string? TransportCompanyTelephone { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TrkReceiptDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TrkRcvDate { get; set; }
        [StringLength(8)]
        public string? TruckerCode { get; set; }
        [StringLength(50)]
        public string? TruckerName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TruckingDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TruckInDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TruckOutDateTime { get; set; }
        [StringLength(50)]
        public string? UcrNo { get; set; }
        [StringLength(20)]
        public string? UnNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UnstuffDate { get; set; }
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
        [StringLength(10)]
        public string? UserGroup { get; set; }
        [StringLength(12)]
        public string? VehicleNo { get; set; }
        [StringLength(50)]
        public string? VesselCode { get; set; }
        [StringLength(50)]
        public string? VesselName { get; set; }
        [StringLength(20)]
        public string? VoyageNo { get; set; }
        [StringLength(50)]
        public string? WarehouseChargeTemplateName { get; set; }
        [StringLength(10)]
        public string? YardCode { get; set; }
        [StringLength(80)]
        public string? YardName { get; set; }
        [StringLength(50)]
        public string? YardAddress1 { get; set; }
        [StringLength(50)]
        public string? YardAddress2 { get; set; }
        [StringLength(50)]
        public string? YardAddress3 { get; set; }
        [StringLength(50)]
        public string? YardAddress4 { get; set; }
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
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

        [InverseProperty("TrxNoNavigation")]
        public virtual ICollection<Sibl2> Sibl2s { get; set; }
        [InverseProperty("TrxNoNavigation")]
        public virtual ICollection<Sibl3> Sibl3s { get; set; }
        [InverseProperty("TrxNoNavigation")]
        public virtual ICollection<Sibl4> Sibl4s { get; set; }
        [InverseProperty("TrxNoNavigation")]
        public virtual ICollection<Sibl5> Sibl5s { get; set; }
    }
}
