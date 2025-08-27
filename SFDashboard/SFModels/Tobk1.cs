using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("tobk1")]
    public partial class Tobk1
    {
        public Tobk1()
        {
            Tobk2s = new HashSet<Tobk2>();
            Tobk3s = new HashSet<Tobk3>();
            Tobk4s = new HashSet<Tobk4>();
        }

        [Key]
        [StringLength(10)]
        public string BookingNo { get; set; } = null!;
        [StringLength(30)]
        public string? JobNo { get; set; }
        [StringLength(3)]
        public string? AirlineCode { get; set; }
        [StringLength(2)]
        public string? AirlineId { get; set; }
        [StringLength(3)]
        public string? AirportCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AvailableDateTime { get; set; }
        [StringLength(30)]
        public string? AwbNoOrHblNo { get; set; }
        [Column(TypeName = "decimal(5, 0)")]
        public decimal? BalanceOf20ftContainer { get; set; }
        [Column(TypeName = "decimal(5, 0)")]
        public decimal? BalanceOf40ftContainer { get; set; }
        [Column(TypeName = "decimal(5, 0)")]
        public decimal? BalanceOf45ftContainer { get; set; }
        [StringLength(10)]
        public string? BillableTruckSizeCode { get; set; }
        [StringLength(10)]
        public string? BookingBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BookingDateTime { get; set; }
        [StringLength(5)]
        public string? CargoType { get; set; }
        [StringLength(10)]
        public string? CarrierAgent { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CloseDateTime { get; set; }
        [StringLength(1)]
        public string? CollectedFlag { get; set; }
        [StringLength(10)]
        public string? CollectFromCode { get; set; }
        [StringLength(1)]
        public string? CollectFromWarehouseFlag { get; set; }
        [StringLength(6)]
        public string? CollectionNo { get; set; }
        [StringLength(1)]
        public string? CompletedFlag { get; set; }
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
        public string? ConsigneeContactName { get; set; }
        [StringLength(10)]
        public string? ConsigneePostalCode { get; set; }
        [StringLength(30)]
        public string? ConsigneeTelephone { get; set; }
        [StringLength(5)]
        public string? ConsigneeZone { get; set; }
        [StringLength(500)]
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
        [Column(TypeName = "datetime")]
        public DateTime? DeliveryEndDateTime { get; set; }
        [StringLength(5)]
        public string? DeliveryType { get; set; }
        [StringLength(3)]
        public string? DepartmentCode { get; set; }
        [StringLength(2000)]
        public string? Description { get; set; }
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
        [StringLength(50)]
        public string? DestAddress1 { get; set; }
        [StringLength(50)]
        public string? DestAddress2 { get; set; }
        [StringLength(50)]
        public string? DestAddress3 { get; set; }
        [StringLength(50)]
        public string? DestAddress4 { get; set; }
        [StringLength(10)]
        public string? DestCompanyCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DestDeliveryDateTime { get; set; }
        [StringLength(80)]
        public string? DestReceivedBy { get; set; }
        [StringLength(5)]
        public string? DgFlag { get; set; }
        [StringLength(1000)]
        public string? Dimension { get; set; }
        [StringLength(15)]
        public string? DriverCode { get; set; }
        [StringLength(45)]
        public string? DriverName { get; set; }
        [StringLength(30)]
        public string? DriverContactNo1 { get; set; }
        [StringLength(255)]
        public string? DriverRemark { get; set; }
        public byte? EdiCount { get; set; }
        public byte? EmailCount { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EstimateDeliveryDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EstimatePickupDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EtaDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EtaDate2 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EtdDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EtdDate2 { get; set; }
        public byte? ExportCount { get; set; }
        public byte? FaxCount { get; set; }
        [StringLength(50)]
        public string? FeederVessel { get; set; }
        [StringLength(20)]
        public string? FeederVoyage { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? FiataTotal { get; set; }
        [StringLength(5)]
        public string? FifthViaPortCode { get; set; }
        [StringLength(5)]
        public string? FirstViaPortCode { get; set; }
        [StringLength(10)]
        public string? FlagStatus { get; set; }
        [StringLength(6)]
        public string? FlightNo { get; set; }
        [StringLength(10)]
        public string? ForwardingAgentCode { get; set; }
        [StringLength(5)]
        public string? FourthViaPortCode { get; set; }
        [StringLength(100)]
        public string? FreightAttachmentRefNo { get; set; }
        [StringLength(30)]
        public string? FreightJobNo { get; set; }
        [StringLength(10)]
        public string? FromCode { get; set; }
        [StringLength(100)]
        public string? FromName { get; set; }
        [StringLength(50)]
        public string? FromAddress1 { get; set; }
        [StringLength(50)]
        public string? FromAddress2 { get; set; }
        [StringLength(50)]
        public string? FromAddress3 { get; set; }
        [StringLength(50)]
        public string? FromAddress4 { get; set; }
        [StringLength(3)]
        public string? FromCityCode { get; set; }
        [StringLength(45)]
        public string? FromCityName { get; set; }
        [StringLength(50)]
        public string? FromContactName { get; set; }
        [StringLength(10)]
        public string? FromPlaceCode { get; set; }
        [StringLength(10)]
        public string? FromPostalCode { get; set; }
        [StringLength(30)]
        public string? FromTelephone { get; set; }
        [StringLength(10)]
        public string? FromZone { get; set; }
        [StringLength(2000)]
        public string? GoodsDescription { get; set; }
        [StringLength(1)]
        public string? HoldFlag { get; set; }
        [StringLength(50)]
        public string? HoldReason { get; set; }
        [StringLength(20)]
        public string? Imco { get; set; }
        [StringLength(100)]
        public string? Instruction1 { get; set; }
        [StringLength(100)]
        public string? Instruction2 { get; set; }
        [StringLength(100)]
        public string? Instruction3 { get; set; }
        [StringLength(100)]
        public string? Instruction4 { get; set; }
        [StringLength(100)]
        public string? Instruction5 { get; set; }
        [StringLength(100)]
        public string? Instruction6 { get; set; }
        [StringLength(100)]
        public string? Instruction7 { get; set; }
        [StringLength(100)]
        public string? Instruction8 { get; set; }
        [StringLength(1)]
        public string? InvoicedFlag { get; set; }
        [StringLength(25)]
        public string? ItemName1 { get; set; }
        [StringLength(25)]
        public string? ItemName2 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? JobDate { get; set; }
        [StringLength(6)]
        public string? JobMth { get; set; }
        [StringLength(10)]
        public string? JobType { get; set; }
        [StringLength(16)]
        public string? JtcAccCode { get; set; }
        [StringLength(15)]
        public string? LetterOfCreditNo { get; set; }
        [StringLength(1)]
        public string? LoggerFlag { get; set; }
        [StringLength(30)]
        public string? MasterJobNo { get; set; }
        [StringLength(30)]
        public string? MawbOrObl { get; set; }
        [StringLength(50)]
        public string? NodeName { get; set; }
        public int? NoOfContainer1 { get; set; }
        public int? NoOfContainer2 { get; set; }
        public int? NoOfContainer3 { get; set; }
        public int? NoOfContainer4 { get; set; }
        [Column(TypeName = "decimal(5, 0)")]
        public decimal? NoOf20ftContainer { get; set; }
        [Column(TypeName = "decimal(5, 0)")]
        public decimal? NoOf20ftUnstuff { get; set; }
        [Column(TypeName = "decimal(5, 0)")]
        public decimal? NoOf20ftStuff { get; set; }
        [Column(TypeName = "decimal(5, 0)")]
        public decimal? NoOf40ftContainer { get; set; }
        [Column(TypeName = "decimal(5, 0)")]
        public decimal? NoOf40ftStuff { get; set; }
        [Column(TypeName = "decimal(5, 0)")]
        public decimal? NoOf40ftUnstuff { get; set; }
        [Column(TypeName = "decimal(5, 0)")]
        public decimal? NoOf45ftContainer { get; set; }
        [Column(TypeName = "decimal(5, 0)")]
        public decimal? NoOf45ftUnstuff { get; set; }
        [Column(TypeName = "decimal(5, 0)")]
        public decimal? NoOf45ftStuff { get; set; }
        public int? NoOfPallet { get; set; }
        [StringLength(255)]
        public string? Note { get; set; }
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
        [Column("OBLNo")]
        [StringLength(30)]
        public string? Oblno { get; set; }
        [StringLength(50)]
        public string? OnBehalfName { get; set; }
        [StringLength(10)]
        public string? OnBehalfOf { get; set; }
        [StringLength(3)]
        public string? OriginCode { get; set; }
        [StringLength(45)]
        public string? OriginName { get; set; }
        [StringLength(50)]
        public string? OtherBalanceContainer { get; set; }
        [StringLength(50)]
        public string? OtherContainer { get; set; }
        [StringLength(24)]
        public string? OurRefNo { get; set; }
        [StringLength(260)]
        public string? PermitNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PickupEndDateTime { get; set; }
        [StringLength(20)]
        public string? PlaceOfDelivery { get; set; }
        [StringLength(20)]
        public string? PlaceOfReceipt { get; set; }
        [StringLength(50)]
        public string? PortnetRefNo { get; set; }
        [StringLength(5)]
        public string? PortOfDischargeCode { get; set; }
        [StringLength(5)]
        public string? PortOfLoadingCode { get; set; }
        [StringLength(25)]
        public string? PreparedBy { get; set; }
        public byte? PrintCount { get; set; }
        [StringLength(1)]
        public string? PrintedFlag { get; set; }
        [StringLength(50)]
        public string? ProjectName { get; set; }
        [StringLength(16)]
        public string? PsaAccCode { get; set; }
        [StringLength(20)]
        public string? PsaInfo { get; set; }
        [StringLength(1000)]
        public string? Remark { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RequiredDateTime { get; set; }
        [StringLength(10)]
        public string? SalesmanCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ScheduleDate { get; set; }
        [Column("ScheduleID")]
        [StringLength(10)]
        public string? ScheduleId { get; set; }
        [StringLength(50)]
        public string? ScheduleTime { get; set; }
        [StringLength(1000)]
        public string? SealNo { get; set; }
        [StringLength(5)]
        public string? SecondViaPortCode { get; set; }
        [StringLength(1)]
        public string? SendToWarehouseFlag { get; set; }
        [StringLength(25)]
        public string? SerialNo1 { get; set; }
        [StringLength(25)]
        public string? SerialNo2 { get; set; }
        [StringLength(10)]
        public string? ServiceLevel { get; set; }
        [StringLength(3)]
        public string? ShipmentType { get; set; }
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
        [StringLength(50)]
        public string? ShipperContactName { get; set; }
        [StringLength(10)]
        public string? ShipperPostalCode { get; set; }
        [StringLength(30)]
        public string? ShipperTelephone { get; set; }
        [StringLength(5)]
        public string? ShipperZone { get; set; }
        [StringLength(12)]
        public string? ShippingLineCode { get; set; }
        [StringLength(80)]
        public string? ShippingLineName { get; set; }
        [StringLength(10)]
        public string? StuffingAtCode { get; set; }
        [StringLength(80)]
        public string? StuffingAtName { get; set; }
        [StringLength(30)]
        public string? StuffingRequire { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? StuffOrUnstuffOn { get; set; }
        [StringLength(20)]
        public string? Temperature { get; set; }
        [StringLength(50)]
        public string? TemplateName { get; set; }
        [StringLength(10)]
        public string? TerminalCode { get; set; }
        [StringLength(5)]
        public string? ThirdViaPortCode { get; set; }
        [StringLength(10)]
        public string? ToCode { get; set; }
        [StringLength(100)]
        public string? ToName { get; set; }
        [StringLength(80)]
        public string? ToAddress1 { get; set; }
        [StringLength(50)]
        public string? ToAddress2 { get; set; }
        [StringLength(50)]
        public string? ToAddress3 { get; set; }
        [StringLength(50)]
        public string? ToAddress4 { get; set; }
        [StringLength(3)]
        public string? ToCityCode { get; set; }
        [StringLength(45)]
        public string? ToCityName { get; set; }
        [StringLength(50)]
        public string? ToContactName { get; set; }
        [StringLength(50)]
        public string? ToEmail { get; set; }
        [StringLength(30)]
        public string? ToFax { get; set; }
        [StringLength(10)]
        public string? ToPlaceCode { get; set; }
        [StringLength(10)]
        public string? ToPostalCode { get; set; }
        [StringLength(30)]
        public string? ToTelephone { get; set; }
        [StringLength(10)]
        public string? ToZone { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? TotalChargeWeight { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? TotalGrossWeight { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? TotalItem { get; set; }
        public int? TotalPcs { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? TotalVolume { get; set; }
        [StringLength(255)]
        public string? TrailerNo { get; set; }
        [StringLength(10)]
        public string? TransportAgent { get; set; }
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
        [StringLength(10)]
        public string? TransportCompanyPlaceCode { get; set; }
        [StringLength(1)]
        public string? TransportType { get; set; }
        [Column(TypeName = "decimal(18, 1)")]
        public decimal? TripWeightage { get; set; }
        [StringLength(15)]
        public string? UciNo { get; set; }
        [StringLength(50)]
        public string? UcrNo { get; set; }
        [StringLength(10)]
        public string? UnstuffingAtCode { get; set; }
        [StringLength(80)]
        public string? UnstuffingName { get; set; }
        [StringLength(50)]
        public string? UomCode { get; set; }
        [StringLength(1)]
        public string? UpdateChargeFlag { get; set; }
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
        [StringLength(15)]
        public string? VehicleNo { get; set; }
        [StringLength(50)]
        public string? VesselCode { get; set; }
        [StringLength(50)]
        public string? VesselName { get; set; }
        [StringLength(20)]
        public string? VoyageNo { get; set; }
        [StringLength(10)]
        public string? YardCode { get; set; }
        [StringLength(80)]
        public string? YardName { get; set; }
        [StringLength(25)]
        public string? YourDelNo { get; set; }
        [StringLength(24)]
        public string? YourRefNo { get; set; }
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

        [InverseProperty("BookingNoNavigation")]
        public virtual ICollection<Tobk2> Tobk2s { get; set; }
        [InverseProperty("BookingNoNavigation")]
        public virtual ICollection<Tobk3> Tobk3s { get; set; }
        [InverseProperty("BookingNoNavigation")]
        public virtual ICollection<Tobk4> Tobk4s { get; set; }
    }
}
