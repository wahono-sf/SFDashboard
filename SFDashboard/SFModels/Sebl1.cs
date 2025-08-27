using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("sebl1")]
    [Index("AtaDate", Name = "INDEX_Sebl1_AtaDate")]
    [Index("BlNo", Name = "INDEX_Sebl1_BlNo")]
    [Index("BookingNo", Name = "INDEX_Sebl1_BookingNo")]
    [Index("ContainerNo", Name = "INDEX_Sebl1_ContainerNo")]
    [Index("CustomerName", Name = "INDEX_Sebl1_CustomerName")]
    [Index("DeliveryAgentName", Name = "INDEX_Sebl1_DeliveryAgentName")]
    [Index("EtdDate", Name = "INDEX_Sebl1_EtdDate")]
    [Index("HouseJobNo", Name = "INDEX_Sebl1_HouseJobNo")]
    [Index("ImportJobNo", Name = "INDEX_Sebl1_ImportJobNo")]
    [Index("JobNo", Name = "INDEX_Sebl1_JobNo")]
    [Index("JobType", Name = "INDEX_Sebl1_JobType")]
    [Index("MasterJobNo", Name = "INDEX_Sebl1_MasterJobNo")]
    [Index("PortOfDischargeCode", Name = "INDEX_Sebl1_PortOfDischargeCode")]
    [Index("PortOfDischargeName", Name = "INDEX_Sebl1_PortOfDischargeName")]
    [Index("SalesmanCode", Name = "INDEX_Sebl1_SalesmanCode")]
    [Index("ShipperName", Name = "INDEX_Sebl1_ShipperName")]
    [Index("StatusCode", Name = "INDEX_Sebl1_StatusCode")]
    [Index("UpdateDateTime", Name = "INDEX_Sebl1_UpdateDateTime")]
    [Index("VesselCode", Name = "INDEX_Sebl1_VesselCode")]
    [Index("WorkStation", Name = "INDEX_Sebl1_WorkStation")]
    [Index("UserGroup", Name = "IX_Sebl1_UserGroup_1")]
    [Index("BlNo", Name = "sebl1_blx")]
    [Index("TrxNo", Name = "sebl1_x", IsUnique = true)]
    public partial class Sebl1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(10)]
        public string? AgentCode { get; set; }
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
        public int? ApproveComFreeDay { get; set; }
        public int? ApproveDemFreeDay { get; set; }
        public int? ApproveDetFreeDay { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AtaDate { get; set; }
        [StringLength(50)]
        public string? BarCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BillingDate { get; set; }
        [StringLength(255)]
        public string? BillingInstruction { get; set; }
        [StringLength(50)]
        public string? BillMode { get; set; }
        [StringLength(8)]
        public string? BillToCode { get; set; }
        [StringLength(1)]
        public string? BlAttachFlag { get; set; }
        [StringLength(1)]
        public string? BlChargeApproveFlag { get; set; }
        [StringLength(5)]
        public string? BlCountryCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BlIssueDate { get; set; }
        [StringLength(45)]
        public string? BlIssuePlace { get; set; }
        [StringLength(30)]
        public string? BlNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BlReadyDate { get; set; }
        [StringLength(1)]
        public string? BlSurrenderFlag { get; set; }
        [StringLength(10)]
        public string? BlType { get; set; }
        [StringLength(50)]
        public string? BookingContainer { get; set; }
        [StringLength(30)]
        public string? BookingNo { get; set; }
        [StringLength(50)]
        public string? ByWhom { get; set; }
        [StringLength(10)]
        public string? CargoClass { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CargoCollectionDate { get; set; }
        [StringLength(255)]
        public string? CargoLocation { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CargoReceiptDate { get; set; }
        [StringLength(5)]
        public string? CargoType { get; set; }
        [StringLength(50)]
        public string? CfsUpdateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CfsUpdateDateTime { get; set; }
        [StringLength(255)]
        public string? ClearingRemark { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CloseDateTime { get; set; }
        [StringLength(1)]
        public string? CloseConsol { get; set; }
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
        public string? ColoaderCode { get; set; }
        [StringLength(80)]
        public string? ColoaderName { get; set; }
        [StringLength(20)]
        public string? ColoaderRefNo { get; set; }
        public int? CombineFreeDay { get; set; }
        [StringLength(50)]
        public string? CommodityCode { get; set; }
        [StringLength(50)]
        public string? CommodityDescription { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ConfirmArrivalDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ConfirmDepartureDate { get; set; }
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
        public string? ConsigneeAddress5 { get; set; }
        [StringLength(1000)]
        public string? ContainerNo { get; set; }
        [StringLength(2000)]
        public string? ContainerNoType { get; set; }
        [StringLength(2000)]
        public string? ContainerSealNo { get; set; }
        [StringLength(2000)]
        public string? ContainerSealNoType { get; set; }
        [StringLength(5)]
        public string? ContainerType1 { get; set; }
        [StringLength(5)]
        public string? ContainerType2 { get; set; }
        [StringLength(5)]
        public string? ContainerType3 { get; set; }
        [StringLength(5)]
        public string? ContainerType4 { get; set; }
        [StringLength(4)]
        public string? ContrFlag { get; set; }
        [StringLength(50)]
        public string? CopyTemplateName { get; set; }
        [StringLength(255)]
        public string? CopyTemplateRemark { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [StringLength(50)]
        public string? CustomerContactName { get; set; }
        [StringLength(200)]
        public string? CustomerEmail { get; set; }
        [StringLength(30)]
        public string? CustomerFax { get; set; }
        [StringLength(30)]
        public string? CustomerTelephone { get; set; }
        [StringLength(50)]
        public string? CustomerRefNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? CustomValue { get; set; }
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
        [StringLength(50)]
        public string? DeliveryAgentAddress5 { get; set; }
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
        [Column(TypeName = "datetime")]
        public DateTime? DeliveryOrderReleaseDate { get; set; }
        [StringLength(80)]
        public string? DeliveryOrderReleaseTo { get; set; }
        public int? DeliveryPcs { get; set; }
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
        [StringLength(5)]
        public string? DestCargoType { get; set; }
        [StringLength(3)]
        public string? DestCode { get; set; }
        [StringLength(45)]
        public string? DestName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DestEta { get; set; }
        public int? DetentionFreeDay { get; set; }
        [StringLength(10)]
        public string? DivisionCode { get; set; }
        [StringLength(20)]
        public string? DocRefNo { get; set; }
        [StringLength(255)]
        public string? DocRemark { get; set; }
        public byte? EdiCount { get; set; }
        public byte? EmailCount { get; set; }
        public short? EstTransitTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EtaDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EtdDate { get; set; }
        public byte? ExportCount { get; set; }
        [StringLength(50)]
        public string? ExportReference1 { get; set; }
        [StringLength(50)]
        public string? ExportReference2 { get; set; }
        [StringLength(50)]
        public string? ExportReference3 { get; set; }
        public byte? FaxCount { get; set; }
        [StringLength(50)]
        public string? FeederVesselName { get; set; }
        [StringLength(20)]
        public string? FeederVoyage { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FfReceiptDate { get; set; }
        [StringLength(5)]
        public string? FifthViaPortCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FirstViaAtaDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FirstViaEtaDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FirstViaEtdDate { get; set; }
        [StringLength(5)]
        public string? FirstViaPortCode { get; set; }
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
        [StringLength(5)]
        public string? FourthViaPortCode { get; set; }
        [StringLength(50)]
        public string? FreeHouseFlag { get; set; }
        [StringLength(1)]
        public string? FreightPrepaidType { get; set; }
        [StringLength(80)]
        public string? FreightTerm { get; set; }
        [StringLength(10)]
        public string? FrtBillPartyCode { get; set; }
        [StringLength(1)]
        public string? FrtPpCcFlag { get; set; }
        [StringLength(255)]
        public string? HaulierRemark { get; set; }
        [StringLength(1)]
        public string? HideOblFlag { get; set; }
        [StringLength(30)]
        public string? HouseJobNo { get; set; }
        [StringLength(30)]
        public string? ImportJobNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ImportRate { get; set; }
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
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? LocalProfitPercent { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LodgeDate { get; set; }
        [StringLength(50)]
        public string? LotNo { get; set; }
        [StringLength(30)]
        public string? MasterJobNo { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? MaxGrossWeight { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? MaxVolume { get; set; }
        [StringLength(50)]
        public string? MotherVesselName { get; set; }
        [StringLength(20)]
        public string? MotherVoyage { get; set; }
        public int? NoOf20ftContainer { get; set; }
        public int? NoOf40ftContainer { get; set; }
        public int? NoOf45ftContainer { get; set; }
        public int? NoOfContainer1 { get; set; }
        public int? NoOfContainer2 { get; set; }
        public int? NoOfContainer3 { get; set; }
        public int? NoOfContainer4 { get; set; }
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
        [StringLength(50)]
        public string? NotifyAddress5 { get; set; }
        [StringLength(1)]
        public string? OblFrtPpCcFlag { get; set; }
        [Column("OBLNo")]
        [StringLength(30)]
        public string? Oblno { get; set; }
        [StringLength(255)]
        public string? OblRemark { get; set; }
        [StringLength(1)]
        public string? OblSurrenderFlag { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? OnCarriageCharges { get; set; }
        [StringLength(30)]
        public string? OriginalBlNo { get; set; }
        [StringLength(30)]
        public string? OriginalBookingNo { get; set; }
        [StringLength(30)]
        public string? OriginalMasterJobNo { get; set; }
        [StringLength(1)]
        public string? OriginalPrintedFlag { get; set; }
        [StringLength(3)]
        public string? OriginCode { get; set; }
        [StringLength(45)]
        public string? OriginName { get; set; }
        [StringLength(10)]
        public string? OtherBillPartyCode { get; set; }
        [StringLength(1)]
        public string? OtherPpCcFlag { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? OverseasProfitPercent { get; set; }
        [StringLength(255)]
        public string? PackageStc { get; set; }
        [StringLength(45)]
        public string? PayableAt { get; set; }
        [StringLength(260)]
        public string? PermitNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PickUpDate { get; set; }
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
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? PpAmt { get; set; }
        [StringLength(45)]
        public string? PpAt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PreAlertDestDate { get; set; }
        [StringLength(80)]
        public string? PreCarriage { get; set; }
        [StringLength(12)]
        public string? PrincipleAgentCode { get; set; }
        [StringLength(1)]
        public string? PrintBlFlag { get; set; }
        public byte? PrintCount { get; set; }
        [StringLength(1)]
        public string? PrintFlag { get; set; }
        [StringLength(15)]
        public string? QuotationNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Rebate { get; set; }
        [StringLength(1)]
        public string? RebateFlag { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? RebatePerShp { get; set; }
        [StringLength(5)]
        public string? RecStatus { get; set; }
        [StringLength(1000)]
        public string? Remark { get; set; }
        public int? RequestCombineFreeDay { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RequestDate { get; set; }
        public int? RequestDemurrageFreeDay { get; set; }
        public int? RequestDetentionFreeDay { get; set; }
        [StringLength(255)]
        public string? SaidToContain { get; set; }
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
        [StringLength(10)]
        public string? ScnCode { get; set; }
        [StringLength(5)]
        public string? SecondViaPortCode { get; set; }
        [StringLength(50)]
        public string? Sector { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SendOn { get; set; }
        [StringLength(50)]
        public string? ServiceIndicator { get; set; }
        [StringLength(10)]
        public string? ServiceLevel { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ShipDate { get; set; }
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
        [StringLength(50)]
        public string? ShipperAddress5 { get; set; }
        [StringLength(1)]
        public string? ShipperCountFlag { get; set; }
        [StringLength(2000)]
        public string? ShippingDescription { get; set; }
        [StringLength(12)]
        public string? ShippinglineCode { get; set; }
        [StringLength(1000)]
        public string? ShippingMarkNo { get; set; }
        [StringLength(255)]
        public string? ShippingPkg { get; set; }
        [StringLength(50)]
        public string? SignBy { get; set; }
        [StringLength(20)]
        public string? SiteCode { get; set; }
        [StringLength(12)]
        public string? SmkShipAgentCode { get; set; }
        [StringLength(5)]
        public string? SourceCompanyCode { get; set; }
        [StringLength(50)]
        public string? SourceCreateBy { get; set; }
        [StringLength(30)]
        public string? SourceJobNo { get; set; }
        [StringLength(50)]
        public string? SourceJobCreateBy { get; set; }
        public int? SourceJobTrxNo { get; set; }
        [StringLength(20)]
        public string? SourceSiteCode { get; set; }
        [StringLength(10)]
        public string? StuffAgentCode { get; set; }
        [StringLength(80)]
        public string? StuffAgentName { get; set; }
        [StringLength(50)]
        public string? StuffAgentAddress1 { get; set; }
        [StringLength(50)]
        public string? StuffAgentAddress2 { get; set; }
        [StringLength(50)]
        public string? StuffAgentAddress3 { get; set; }
        [StringLength(50)]
        public string? StuffAgentAddress4 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StuffDate { get; set; }
        [StringLength(1)]
        public string? SubMasterFlag { get; set; }
        [StringLength(1)]
        public string? SubmitFlag { get; set; }
        [Column(TypeName = "decimal(12, 2)")]
        public decimal? SupplierAmt { get; set; }
        [StringLength(50)]
        public string? SupplierCurrCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? SupplierLocalAmt { get; set; }
        [StringLength(1)]
        public string? SurrenderPrintedFlag { get; set; }
        [StringLength(30)]
        public string? SwitchBlNo { get; set; }
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
        [StringLength(10)]
        public string? TaxRefundCompanyCode { get; set; }
        [StringLength(80)]
        public string? TaxRefundCompanyName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TaxRefundIssueDate { get; set; }
        [StringLength(20)]
        public string? TaxRefundNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TaxRefundReturnDate { get; set; }
        [StringLength(1)]
        public string? TelexReleaseFlag { get; set; }
        [StringLength(50)]
        public string? TemplateName { get; set; }
        [StringLength(20)]
        public string? Terminal { get; set; }
        [StringLength(5)]
        public string? ThirdViaPortCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? TotalBookingGrossWeight { get; set; }
        public int? TotalBookingPcs { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? TotalBookingVolume { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? TotalChargeWeight { get; set; }
        [StringLength(50)]
        public string? TotalContainer { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? TotalGrossWeight { get; set; }
        public int? TotalPcs { get; set; }
        [StringLength(254)]
        public string? TotalPcsInWord { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? TotalVolume { get; set; }
        [StringLength(10)]
        public string? TransportCompanyCode { get; set; }
        [StringLength(80)]
        public string? TransportCompanyName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TruckingDate { get; set; }
        [StringLength(50)]
        public string? TruckingDateRemark { get; set; }
        [StringLength(250)]
        public string? UcrNo { get; set; }
        [StringLength(50)]
        public string? UomCode { get; set; }
        [StringLength(50)]
        public string? UomDescription { get; set; }
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
        [StringLength(50)]
        public string? VesselCode { get; set; }
        [StringLength(50)]
        public string? VesselName { get; set; }
        [StringLength(50)]
        public string? VesselRemark { get; set; }
        [StringLength(10)]
        public string? VoyageId { get; set; }
        [StringLength(20)]
        public string? VoyageNo { get; set; }
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
    }
}
