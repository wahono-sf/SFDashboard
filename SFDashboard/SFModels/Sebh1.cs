using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("sebh1")]
    public partial class Sebh1
    {
        public Sebh1()
        {
            Sebh2s = new HashSet<Sebh2>();
        }

        [Key]
        public int TrxNo { get; set; }
        [StringLength(30)]
        public string? BookingNo { get; set; }
        [StringLength(30)]
        public string? JobNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ActualPickupDateTime { get; set; }
        [StringLength(50)]
        public string? Address1 { get; set; }
        [StringLength(50)]
        public string? Address2 { get; set; }
        [StringLength(50)]
        public string? Address3 { get; set; }
        [StringLength(50)]
        public string? Address4 { get; set; }
        [StringLength(10)]
        public string? AlsoNotifyCode { get; set; }
        [StringLength(80)]
        public string? AlsoNotifyName { get; set; }
        [StringLength(50)]
        public string? AlsoNotifyAddress1 { get; set; }
        [StringLength(50)]
        public string? AlsoNotifyAddress2 { get; set; }
        [StringLength(50)]
        public string? AlsoNotifyAddress3 { get; set; }
        [StringLength(50)]
        public string? AlsoNotifyAddress4 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AtaDate { get; set; }
        [StringLength(50)]
        public string? BarCode { get; set; }
        [StringLength(1)]
        public string? BlType { get; set; }
        [StringLength(10)]
        public string? BookingCustomerCode { get; set; }
        [StringLength(80)]
        public string? BookingCustomerName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BookingDateTime { get; set; }
        [StringLength(4)]
        public string? BookingSeqNo { get; set; }
        [StringLength(10)]
        public string? CargoClass { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CargoReceiptDate { get; set; }
        [StringLength(1)]
        public string? CargoReceiptFlag { get; set; }
        [StringLength(5)]
        public string? CargoType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CloseDateTime { get; set; }
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
        public string? CollectFromTemplateName { get; set; }
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
        [StringLength(200)]
        public string? ContactEmail { get; set; }
        [StringLength(30)]
        public string? ContactFax { get; set; }
        [StringLength(50)]
        public string? ContactName { get; set; }
        [StringLength(30)]
        public string? ContactTelephone { get; set; }
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
        [StringLength(2)]
        public string? CountryOfOrigin { get; set; }
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
        public DateTime? DeliveryDateTime { get; set; }
        [StringLength(80)]
        public string? DeliveryInstruction1 { get; set; }
        [StringLength(80)]
        public string? DeliveryInstruction2 { get; set; }
        [StringLength(80)]
        public string? DeliveryInstruction3 { get; set; }
        [StringLength(80)]
        public string? DeliveryInstruction4 { get; set; }
        [StringLength(80)]
        public string? DeliveryInstruction5 { get; set; }
        [StringLength(80)]
        public string? DeliveryInstruction6 { get; set; }
        [StringLength(80)]
        public string? DeliveryInstruction7 { get; set; }
        [StringLength(80)]
        public string? DeliveryInstruction8 { get; set; }
        [StringLength(50)]
        public string? DeliveryInstructionTemplateName { get; set; }
        [StringLength(3)]
        public string? DeliveryStatusCode { get; set; }
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
        [StringLength(5)]
        public string? DestCargoType { get; set; }
        [StringLength(3)]
        public string? DestCode { get; set; }
        [StringLength(45)]
        public string? DestName { get; set; }
        [StringLength(2)]
        public string? DestCountryCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DestEta { get; set; }
        [StringLength(1)]
        public string? DgFlag { get; set; }
        [StringLength(10)]
        public string? DivisionCode { get; set; }
        [StringLength(15)]
        public string? DriverCode { get; set; }
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
        public DateTime? EtaDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EtdDate { get; set; }
        [StringLength(50)]
        public string? EventTemplateName { get; set; }
        public byte? ExportCount { get; set; }
        public byte? FaxCount { get; set; }
        [StringLength(50)]
        public string? FeederVesselName { get; set; }
        [StringLength(20)]
        public string? FeederVoyage { get; set; }
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
        [StringLength(80)]
        public string? Footer6 { get; set; }
        [StringLength(80)]
        public string? Footer7 { get; set; }
        [StringLength(80)]
        public string? Footer8 { get; set; }
        [StringLength(80)]
        public string? Footer9 { get; set; }
        [StringLength(80)]
        public string? Footer10 { get; set; }
        [StringLength(1)]
        public string? Footer1Bold { get; set; }
        [StringLength(1)]
        public string? Footer2Bold { get; set; }
        [StringLength(1)]
        public string? Footer3Bold { get; set; }
        [StringLength(1)]
        public string? Footer4Bold { get; set; }
        [StringLength(1)]
        public string? Footer5Bold { get; set; }
        [StringLength(1)]
        public string? Footer6Bold { get; set; }
        [StringLength(1)]
        public string? Footer7Bold { get; set; }
        [StringLength(1)]
        public string? Footer8Bold { get; set; }
        [StringLength(1)]
        public string? Footer9Bold { get; set; }
        [StringLength(1)]
        public string? Footer10Bold { get; set; }
        [StringLength(50)]
        public string? FooterTemplateName { get; set; }
        [StringLength(10)]
        public string? ForwardAgentCode { get; set; }
        [StringLength(80)]
        public string? ForwardAgentName { get; set; }
        [StringLength(5)]
        public string? FourthViaPortCode { get; set; }
        [StringLength(1)]
        public string? FrtPpCcFlag { get; set; }
        [StringLength(1)]
        public string? FumigationFlag { get; set; }
        [StringLength(50)]
        public string? FumigationRemark { get; set; }
        [StringLength(1)]
        public string? HistoryFlag { get; set; }
        [StringLength(30)]
        public string? HouseJobNo { get; set; }
        [Column(TypeName = "image")]
        public byte[]? Image01 { get; set; }
        [StringLength(20)]
        public string? Imco { get; set; }
        [StringLength(30)]
        public string? ImportJobNo { get; set; }
        [StringLength(1)]
        public string? InsuranceFlag { get; set; }
        [StringLength(50)]
        public string? InsuranceRemark { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? JobDate { get; set; }
        [StringLength(6)]
        public string? JobMth { get; set; }
        [StringLength(10)]
        public string? JobType { get; set; }
        [StringLength(15)]
        public string? LetterOfCreditNo { get; set; }
        public int? LooseQty { get; set; }
        [StringLength(50)]
        public string? LooseUomCode { get; set; }
        [StringLength(30)]
        public string? MasterJobNo { get; set; }
        [StringLength(50)]
        public string? MotherVesselName { get; set; }
        [StringLength(20)]
        public string? MotherVoyage { get; set; }
        [StringLength(1)]
        public string? NominationFlag { get; set; }
        [StringLength(50)]
        public string? NominationRemark { get; set; }
        public int? NoOf20ftContainer { get; set; }
        public int? NoOf40ftContainer { get; set; }
        public int? NoOf45ftContainer { get; set; }
        public int? NoOfContainer1 { get; set; }
        public int? NoOfContainer2 { get; set; }
        public int? NoOfContainer3 { get; set; }
        public int? NoOfContainer4 { get; set; }
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
        [StringLength(45)]
        public string? OriginName { get; set; }
        [StringLength(1)]
        public string? OtherPpCcFlag { get; set; }
        [StringLength(1)]
        public string? PermitFlag { get; set; }
        [StringLength(255)]
        public string? PermitNo { get; set; }
        [StringLength(50)]
        public string? PermitRemark { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PickupDateTime { get; set; }
        [StringLength(50)]
        public string? PickupDateTimeRemark { get; set; }
        [StringLength(20)]
        public string? PickupNo { get; set; }
        [StringLength(10)]
        public string? Place { get; set; }
        [StringLength(45)]
        public string? PlaceOfDelivery { get; set; }
        [StringLength(45)]
        public string? PlaceOfReceipt { get; set; }
        [StringLength(5)]
        public string? PortOfDischargeCode { get; set; }
        [StringLength(5)]
        public string? PortOfLoadingCode { get; set; }
        [StringLength(12)]
        public string? PrincipleAgentCode { get; set; }
        public byte? PrintCount { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ProfitSharePercent { get; set; }
        [StringLength(80)]
        public string? Psn { get; set; }
        [StringLength(15)]
        public string? QuotationNo { get; set; }
        [StringLength(1)]
        public string? RailingFlag { get; set; }
        [StringLength(1)]
        public string? RailingInstructionFlag { get; set; }
        [StringLength(50)]
        public string? RailingInstructionRemark { get; set; }
        [StringLength(100)]
        public string? RailingRemark { get; set; }
        [StringLength(1)]
        public string? ReeferContainerFlag { get; set; }
        [StringLength(1)]
        public string? ReeferSetting1 { get; set; }
        [StringLength(1)]
        public string? ReeferSetting2 { get; set; }
        [StringLength(1)]
        public string? ReeferSetting3 { get; set; }
        [StringLength(1)]
        public string? ReeferSetting4 { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(20)]
        public string? RequestTransportNo { get; set; }
        [StringLength(10)]
        public string? SalesmanCode { get; set; }
        [StringLength(10)]
        public string? ScnCode { get; set; }
        [StringLength(12)]
        public string? SecondVesselCode { get; set; }
        [StringLength(5)]
        public string? SecondViaPortCode { get; set; }
        [StringLength(20)]
        public string? SecondVoyageNo { get; set; }
        [StringLength(1)]
        public string? SendDirectBold { get; set; }
        [StringLength(1)]
        public string? SendDirectFlag { get; set; }
        [StringLength(10)]
        public string? ServiceLevel { get; set; }
        [StringLength(3)]
        public string? ShipmentType { get; set; }
        [StringLength(50)]
        public string? ShipMode { get; set; }
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
        [StringLength(20)]
        public string? SiteCode { get; set; }
        [StringLength(12)]
        public string? SmkShipAgentCode { get; set; }
        [StringLength(5)]
        public string? SourceCompanyCode { get; set; }
        [StringLength(30)]
        public string? SourceJobNo { get; set; }
        [StringLength(10)]
        public string? SourceSiteCode { get; set; }
        [StringLength(1)]
        public string? StackBold { get; set; }
        [StringLength(1)]
        public string? StackFlag { get; set; }
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
        [StringLength(10)]
        public string? TableName { get; set; }
        [StringLength(1)]
        public string? TakePhotoBold { get; set; }
        [StringLength(1)]
        public string? TakePhotoFlag { get; set; }
        [StringLength(20)]
        public string? Temperature1 { get; set; }
        [StringLength(20)]
        public string? Temperature2 { get; set; }
        [StringLength(20)]
        public string? Temperature3 { get; set; }
        [StringLength(20)]
        public string? Temperature4 { get; set; }
        [StringLength(20)]
        public string? Terminal { get; set; }
        [StringLength(5)]
        public string? ThirdViaPortCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? TotalChargeWeight { get; set; }
        [StringLength(50)]
        public string? TotalContainer { get; set; }
        [Column("TotalFIataAmt", TypeName = "decimal(13, 2)")]
        public decimal? TotalFiataAmt { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? TotalGrossWeight { get; set; }
        public int? TotalPcs { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? TotalVolume { get; set; }
        [StringLength(10)]
        public string? TransportCompanyCode { get; set; }
        [StringLength(80)]
        public string? TransportCompanyName { get; set; }
        [StringLength(50)]
        public string? TransportAddress1 { get; set; }
        [StringLength(50)]
        public string? TransportAddress2 { get; set; }
        [StringLength(50)]
        public string? TransportAddress3 { get; set; }
        [StringLength(50)]
        public string? TransportAddress4 { get; set; }
        [StringLength(250)]
        public string? UcrNo { get; set; }
        [StringLength(20)]
        public string? UnNo { get; set; }
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
        [StringLength(10)]
        public string? VehicleNo { get; set; }
        [StringLength(50)]
        public string? VesselCode { get; set; }
        [StringLength(50)]
        public string? VesselName { get; set; }
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
        public virtual ICollection<Sebh2> Sebh2s { get; set; }
    }
}
