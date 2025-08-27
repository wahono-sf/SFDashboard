using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwTobk1
    {
        [Column("Booking No")]
        [StringLength(10)]
        public string BookingNo { get; set; } = null!;
        [Column("Airline Code")]
        [StringLength(3)]
        public string? AirlineCode { get; set; }
        [Column("Airline ID")]
        [StringLength(2)]
        public string? AirlineId { get; set; }
        [Column("Airport Code")]
        [StringLength(3)]
        public string? AirportCode { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Available Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? AvailableDateTime { get; set; }
        [Column("Awb No Or Hblno")]
        [StringLength(30)]
        public string? AwbNoOrHblno { get; set; }
        [Column("Balance Of 20ft Container", TypeName = "decimal(5, 0)")]
        public decimal? BalanceOf20ftContainer { get; set; }
        [Column("Balance Of 40ft Container", TypeName = "decimal(5, 0)")]
        public decimal? BalanceOf40ftContainer { get; set; }
        [Column("Balance Of 45ft Container", TypeName = "decimal(5, 0)")]
        public decimal? BalanceOf45ftContainer { get; set; }
        [Column("Billable Truck Size Code")]
        [StringLength(10)]
        public string? BillableTruckSizeCode { get; set; }
        [Column("Booking By")]
        [StringLength(10)]
        public string? BookingBy { get; set; }
        [Column("Booking Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? BookingDateTime { get; set; }
        [Column("Cargo Type")]
        [StringLength(5)]
        public string? CargoType { get; set; }
        [Column("Carrier Agent")]
        [StringLength(10)]
        public string? CarrierAgent { get; set; }
        [Column("Close Date Time")]
        [StringLength(10)]
        [Unicode(false)]
        public string? CloseDateTime { get; set; }
        [Column("Collected Flag")]
        [StringLength(1)]
        public string? CollectedFlag { get; set; }
        [Column("Collect From Code")]
        [StringLength(10)]
        public string? CollectFromCode { get; set; }
        [Column("Collect From Warehouse Flag")]
        [StringLength(1)]
        public string? CollectFromWarehouseFlag { get; set; }
        [Column("Collection No")]
        [StringLength(6)]
        public string? CollectionNo { get; set; }
        [Column("Completed Flag")]
        [StringLength(1)]
        public string? CompletedFlag { get; set; }
        [Column("Consignee Code")]
        [StringLength(10)]
        public string? ConsigneeCode { get; set; }
        [Column("Consignee Name")]
        [StringLength(80)]
        public string? ConsigneeName { get; set; }
        [Column("Consignee Address 1")]
        [StringLength(50)]
        public string? ConsigneeAddress1 { get; set; }
        [Column("Consignee Address 2")]
        [StringLength(50)]
        public string? ConsigneeAddress2 { get; set; }
        [Column("Consignee Address 3")]
        [StringLength(50)]
        public string? ConsigneeAddress3 { get; set; }
        [Column("Consignee Address 4")]
        [StringLength(50)]
        public string? ConsigneeAddress4 { get; set; }
        [Column("Consignee Contact Name")]
        [StringLength(50)]
        public string? ConsigneeContactName { get; set; }
        [Column("Consignee Postal Code")]
        [StringLength(10)]
        public string? ConsigneePostalCode { get; set; }
        [Column("Consignee Telephone")]
        [StringLength(30)]
        public string? ConsigneeTelephone { get; set; }
        [Column("Consignee Zone")]
        [StringLength(5)]
        public string? ConsigneeZone { get; set; }
        [Column("Container No")]
        [StringLength(500)]
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
        [Column("Container Type 4")]
        [StringLength(5)]
        public string? ContainerType4 { get; set; }
        [Column("Copy Template Name")]
        [StringLength(50)]
        public string? CopyTemplateName { get; set; }
        [Column("Copy Template Remark")]
        [StringLength(255)]
        public string? CopyTemplateRemark { get; set; }
        [Column("Customer Code")]
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [Column("Customer Name")]
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [Column("Customer Contact Name")]
        [StringLength(50)]
        public string? CustomerContactName { get; set; }
        [Column("Customer Ref No")]
        [StringLength(50)]
        public string? CustomerRefNo { get; set; }
        [Column("Delivery Agent Code")]
        [StringLength(10)]
        public string? DeliveryAgentCode { get; set; }
        [Column("Delivery Agent Name")]
        [StringLength(80)]
        public string? DeliveryAgentName { get; set; }
        [Column("Delivery End Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? DeliveryEndDate { get; set; }
        [Column("Delivery End Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? DeliveryEndDateTime { get; set; }
        [Column("Delivery Type")]
        [StringLength(5)]
        public string? DeliveryType { get; set; }
        [Column("Department Code")]
        [StringLength(3)]
        public string? DepartmentCode { get; set; }
        [StringLength(2000)]
        public string? Description { get; set; }
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
        [Column("Dest Delivery Date Time")]
        [StringLength(10)]
        [Unicode(false)]
        public string? DestDeliveryDateTime { get; set; }
        [Column("Dest Name")]
        [StringLength(45)]
        public string? DestName { get; set; }
        [Column("Dest Address 1")]
        [StringLength(50)]
        public string? DestAddress1 { get; set; }
        [Column("Dest Address 2")]
        [StringLength(50)]
        public string? DestAddress2 { get; set; }
        [Column("Dest Address 3")]
        [StringLength(50)]
        public string? DestAddress3 { get; set; }
        [Column("Dest Address 4")]
        [StringLength(50)]
        public string? DestAddress4 { get; set; }
        [Column("Dest Company Code")]
        [StringLength(10)]
        public string? DestCompanyCode { get; set; }
        [Column("Dest Received By")]
        [StringLength(80)]
        public string? DestReceivedBy { get; set; }
        [Column("DG Flag")]
        [StringLength(5)]
        public string? DgFlag { get; set; }
        [StringLength(1000)]
        public string? Dimension { get; set; }
        [Column("Driver Code")]
        [StringLength(15)]
        public string? DriverCode { get; set; }
        [Column("Driver Name")]
        [StringLength(45)]
        public string? DriverName { get; set; }
        [Column("Driver Contact No 1")]
        [StringLength(30)]
        public string? DriverContactNo1 { get; set; }
        [Column("Driver Remark")]
        [StringLength(255)]
        public string? DriverRemark { get; set; }
        [Column("EDI Count")]
        public byte? EdiCount { get; set; }
        [Column("Email Count")]
        public byte? EmailCount { get; set; }
        [Column("Estimate Delivery Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? EstimateDeliveryDateTime { get; set; }
        [Column("Estimate Pickup Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? EstimatePickupDateTime { get; set; }
        [Column("Eta Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? EtaDate { get; set; }
        [Column("Eta Date 2")]
        [StringLength(10)]
        [Unicode(false)]
        public string? EtaDate2 { get; set; }
        [Column("Etd Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? EtdDate { get; set; }
        [Column("Etd Date 2")]
        [StringLength(10)]
        [Unicode(false)]
        public string? EtdDate2 { get; set; }
        [Column("Export Count")]
        public byte? ExportCount { get; set; }
        [Column("Fax Count")]
        public byte? FaxCount { get; set; }
        [Column("Feeder Vessel")]
        [StringLength(50)]
        public string? FeederVessel { get; set; }
        [Column("Feeder Voyage")]
        [StringLength(20)]
        public string? FeederVoyage { get; set; }
        [Column("Fiata Total", TypeName = "decimal(13, 4)")]
        public decimal? FiataTotal { get; set; }
        [Column("Fifth Via Port Code")]
        [StringLength(5)]
        public string? FifthViaPortCode { get; set; }
        [Column("First Via Port Code")]
        [StringLength(5)]
        public string? FirstViaPortCode { get; set; }
        [Column("Flag Status")]
        [StringLength(10)]
        public string? FlagStatus { get; set; }
        [Column("Flight No")]
        [StringLength(6)]
        public string? FlightNo { get; set; }
        [Column("Forwarding Agent Code")]
        [StringLength(10)]
        public string? ForwardingAgentCode { get; set; }
        [Column("Fourth Via Port Code")]
        [StringLength(5)]
        public string? FourthViaPortCode { get; set; }
        [Column("Freight Attachment Ref No")]
        [StringLength(100)]
        public string? FreightAttachmentRefNo { get; set; }
        [Column("Freight Job No")]
        [StringLength(30)]
        public string? FreightJobNo { get; set; }
        [Column("From Code")]
        [StringLength(10)]
        public string? FromCode { get; set; }
        [Column("From Name")]
        [StringLength(100)]
        public string? FromName { get; set; }
        [Column("From Address 1")]
        [StringLength(50)]
        public string? FromAddress1 { get; set; }
        [Column("From Address 2")]
        [StringLength(50)]
        public string? FromAddress2 { get; set; }
        [Column("From Address 3")]
        [StringLength(50)]
        public string? FromAddress3 { get; set; }
        [Column("From Address 4")]
        [StringLength(50)]
        public string? FromAddress4 { get; set; }
        [Column("From City Code")]
        [StringLength(3)]
        public string? FromCityCode { get; set; }
        [Column("From City Name")]
        [StringLength(45)]
        public string? FromCityName { get; set; }
        [Column("From Contact Name")]
        [StringLength(50)]
        public string? FromContactName { get; set; }
        [Column("From Place Code")]
        [StringLength(10)]
        public string? FromPlaceCode { get; set; }
        [Column("From Postal Code")]
        [StringLength(10)]
        public string? FromPostalCode { get; set; }
        [Column("From Telephone")]
        [StringLength(30)]
        public string? FromTelephone { get; set; }
        [Column("From Zone")]
        [StringLength(10)]
        public string? FromZone { get; set; }
        [Column("Goods Description")]
        [StringLength(2000)]
        public string? GoodsDescription { get; set; }
        [Column("Hold Flag")]
        [StringLength(1)]
        public string? HoldFlag { get; set; }
        [Column("Hold Reason")]
        [StringLength(50)]
        public string? HoldReason { get; set; }
        [StringLength(20)]
        public string? Imco { get; set; }
        [Column("Instruction 1")]
        [StringLength(100)]
        public string? Instruction1 { get; set; }
        [Column("Instruction 2")]
        [StringLength(100)]
        public string? Instruction2 { get; set; }
        [Column("Instruction 3")]
        [StringLength(100)]
        public string? Instruction3 { get; set; }
        [Column("Instruction 4")]
        [StringLength(100)]
        public string? Instruction4 { get; set; }
        [Column("Instruction 5")]
        [StringLength(100)]
        public string? Instruction5 { get; set; }
        [Column("Instruction 6")]
        [StringLength(100)]
        public string? Instruction6 { get; set; }
        [Column("Instruction 7")]
        [StringLength(100)]
        public string? Instruction7 { get; set; }
        [Column("Instruction 8")]
        [StringLength(100)]
        public string? Instruction8 { get; set; }
        [Column("Invoiced Flag")]
        [StringLength(1)]
        public string? InvoicedFlag { get; set; }
        [Column("Job Costing Flag")]
        [StringLength(1)]
        [Unicode(false)]
        public string JobCostingFlag { get; set; } = null!;
        [Column("Job Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? JobDate { get; set; }
        [Column("Item Name 1")]
        [StringLength(25)]
        public string? ItemName1 { get; set; }
        [Column("Item Name 2")]
        [StringLength(25)]
        public string? ItemName2 { get; set; }
        [Column("Job Mth")]
        [StringLength(6)]
        public string? JobMth { get; set; }
        [Column("Job No")]
        [StringLength(30)]
        public string? JobNo { get; set; }
        [Column("Job Type")]
        [StringLength(10)]
        public string? JobType { get; set; }
        [StringLength(16)]
        public string? JtcAccCode { get; set; }
        [Column("Letter Of Credit No")]
        [StringLength(15)]
        public string? LetterOfCreditNo { get; set; }
        [Column("Logger Flag")]
        [StringLength(1)]
        public string? LoggerFlag { get; set; }
        [Column("Master Job No")]
        [StringLength(30)]
        public string? MasterJobNo { get; set; }
        [Column("Mawb Or Obl")]
        [StringLength(30)]
        public string? MawbOrObl { get; set; }
        [Column("No Of Container 1")]
        public int? NoOfContainer1 { get; set; }
        [Column("No Of Container 2")]
        public int? NoOfContainer2 { get; set; }
        [Column("No Of Container 3")]
        public int? NoOfContainer3 { get; set; }
        [Column("No Of Container 4")]
        public int? NoOfContainer4 { get; set; }
        [Column("Node Name")]
        [StringLength(50)]
        public string? NodeName { get; set; }
        [Column("No Of 20ft Container", TypeName = "decimal(5, 0)")]
        public decimal? NoOf20ftContainer { get; set; }
        [Column("No Of 20ft Unstuff", TypeName = "decimal(5, 0)")]
        public decimal? NoOf20ftUnstuff { get; set; }
        [Column("No Of 20ft Stuff", TypeName = "decimal(5, 0)")]
        public decimal? NoOf20ftStuff { get; set; }
        [Column("No Of 40ft Container", TypeName = "decimal(5, 0)")]
        public decimal? NoOf40ftContainer { get; set; }
        [Column("No Of 40ft Stuff", TypeName = "decimal(5, 0)")]
        public decimal? NoOf40ftStuff { get; set; }
        [Column("No Of 40ft Unstuff", TypeName = "decimal(5, 0)")]
        public decimal? NoOf40ftUnstuff { get; set; }
        [Column("No Of 45ft Container", TypeName = "decimal(5, 0)")]
        public decimal? NoOf45ftContainer { get; set; }
        [Column("No Of 45ft Unstuff", TypeName = "decimal(5, 0)")]
        public decimal? NoOf45ftUnstuff { get; set; }
        [Column("No Of 45ft Stuff", TypeName = "decimal(5, 0)")]
        public decimal? NoOf45ftStuff { get; set; }
        [Column("No Of Pallet")]
        public int? NoOfPallet { get; set; }
        [StringLength(255)]
        public string? Note { get; set; }
        [Column("Notify Code")]
        [StringLength(10)]
        public string? NotifyCode { get; set; }
        [Column("Notify Name")]
        [StringLength(80)]
        public string? NotifyName { get; set; }
        [Column("Notify Address 1")]
        [StringLength(50)]
        public string? NotifyAddress1 { get; set; }
        [Column("Notify Address 2")]
        [StringLength(50)]
        public string? NotifyAddress2 { get; set; }
        [Column("Notify Address 3")]
        [StringLength(50)]
        public string? NotifyAddress3 { get; set; }
        [Column("Notify Address 4")]
        [StringLength(50)]
        public string? NotifyAddress4 { get; set; }
        [Column("O B L No")]
        [StringLength(30)]
        public string? OBLNo { get; set; }
        [Column("On Behalf Name")]
        [StringLength(50)]
        public string? OnBehalfName { get; set; }
        [Column("On Behalf Of")]
        [StringLength(10)]
        public string? OnBehalfOf { get; set; }
        [Column("Origin Code")]
        [StringLength(3)]
        public string? OriginCode { get; set; }
        [Column("Origin Name")]
        [StringLength(45)]
        public string? OriginName { get; set; }
        [Column("Other Balance Container")]
        [StringLength(50)]
        public string? OtherBalanceContainer { get; set; }
        [Column("Other Container")]
        [StringLength(50)]
        public string? OtherContainer { get; set; }
        [Column("Our Ref No")]
        [StringLength(24)]
        public string? OurRefNo { get; set; }
        [Column("Permit No")]
        [StringLength(260)]
        public string? PermitNo { get; set; }
        [Column("Pickup End Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? PickupEndDateTime { get; set; }
        [Column("Place Of Delivery")]
        [StringLength(20)]
        public string? PlaceOfDelivery { get; set; }
        [Column("Place Of Receipt")]
        [StringLength(20)]
        public string? PlaceOfReceipt { get; set; }
        [Column("Port Of Discharge Code")]
        [StringLength(5)]
        public string? PortOfDischargeCode { get; set; }
        [Column("Port Of Loading Code")]
        [StringLength(5)]
        public string? PortOfLoadingCode { get; set; }
        [Column("Portnet Ref No")]
        [StringLength(50)]
        public string? PortnetRefNo { get; set; }
        [Column("Prepared By")]
        [StringLength(25)]
        public string? PreparedBy { get; set; }
        [Column("Print Count")]
        public byte? PrintCount { get; set; }
        [Column("Printed Flag")]
        [StringLength(1)]
        public string? PrintedFlag { get; set; }
        [Column("Project Name")]
        [StringLength(50)]
        public string? ProjectName { get; set; }
        [Column("Psa Acc Code")]
        [StringLength(16)]
        public string? PsaAccCode { get; set; }
        [Column("Psa Info")]
        [StringLength(20)]
        public string? PsaInfo { get; set; }
        [StringLength(1000)]
        public string? Remark { get; set; }
        [Column("Remark Only")]
        [StringLength(4000)]
        public string? RemarkOnly { get; set; }
        [Column("Required Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? RequiredDateTime { get; set; }
        [Column("Salesman Code")]
        [StringLength(10)]
        public string? SalesmanCode { get; set; }
        [Column("Schedule Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ScheduleDate { get; set; }
        [Column("Schedule ID")]
        [StringLength(10)]
        public string? ScheduleId { get; set; }
        [Column("Schedule Time")]
        [StringLength(50)]
        public string? ScheduleTime { get; set; }
        [Column("Seal No")]
        [StringLength(1000)]
        public string? SealNo { get; set; }
        [Column("Second Via Port Code")]
        [StringLength(5)]
        public string? SecondViaPortCode { get; set; }
        [Column("Send To Warehouse Flag")]
        [StringLength(1)]
        public string? SendToWarehouseFlag { get; set; }
        [Column("Serial No 1")]
        [StringLength(25)]
        public string? SerialNo1 { get; set; }
        [Column("Serial No 2")]
        [StringLength(25)]
        public string? SerialNo2 { get; set; }
        [Column("Service Level")]
        [StringLength(10)]
        public string? ServiceLevel { get; set; }
        [Column("Shipment Type")]
        [StringLength(3)]
        public string? ShipmentType { get; set; }
        [Column("Shipper Code")]
        [StringLength(10)]
        public string? ShipperCode { get; set; }
        [Column("Shipper Name")]
        [StringLength(80)]
        public string? ShipperName { get; set; }
        [Column("Shipper Address 1")]
        [StringLength(50)]
        public string? ShipperAddress1 { get; set; }
        [Column("Shipper Address 2")]
        [StringLength(50)]
        public string? ShipperAddress2 { get; set; }
        [Column("Shipper Address 3")]
        [StringLength(50)]
        public string? ShipperAddress3 { get; set; }
        [Column("Shipper Address 4")]
        [StringLength(50)]
        public string? ShipperAddress4 { get; set; }
        [Column("Shipper Contact Name")]
        [StringLength(50)]
        public string? ShipperContactName { get; set; }
        [Column("Shipper Postal Code")]
        [StringLength(10)]
        public string? ShipperPostalCode { get; set; }
        [Column("Shipper Telephone")]
        [StringLength(30)]
        public string? ShipperTelephone { get; set; }
        [Column("Shipper Zone")]
        [StringLength(5)]
        public string? ShipperZone { get; set; }
        [Column("Shipping Line Code")]
        [StringLength(12)]
        public string? ShippingLineCode { get; set; }
        [Column("Shipping Line Name")]
        [StringLength(80)]
        public string? ShippingLineName { get; set; }
        [Column("Stuffing At Code")]
        [StringLength(10)]
        public string? StuffingAtCode { get; set; }
        [Column("Stuffing At Name")]
        [StringLength(80)]
        public string? StuffingAtName { get; set; }
        [Column("Stuffing Require")]
        [StringLength(30)]
        public string? StuffingRequire { get; set; }
        [Column("Stuff Or Unstuff On", TypeName = "decimal(13, 4)")]
        public decimal? StuffOrUnstuffOn { get; set; }
        [StringLength(20)]
        public string? Temperature { get; set; }
        [Column("Template Name")]
        [StringLength(50)]
        public string? TemplateName { get; set; }
        [Column("Terminal Code")]
        [StringLength(10)]
        public string? TerminalCode { get; set; }
        [Column("Third Via Port Code")]
        [StringLength(5)]
        public string? ThirdViaPortCode { get; set; }
        [Column("To Code")]
        [StringLength(10)]
        public string? ToCode { get; set; }
        [Column("To Name")]
        [StringLength(100)]
        public string? ToName { get; set; }
        [Column("To Address 1")]
        [StringLength(80)]
        public string? ToAddress1 { get; set; }
        [Column("To Address 2")]
        [StringLength(50)]
        public string? ToAddress2 { get; set; }
        [Column("To Address 3")]
        [StringLength(50)]
        public string? ToAddress3 { get; set; }
        [Column("To Address 4")]
        [StringLength(50)]
        public string? ToAddress4 { get; set; }
        [Column("To City Code")]
        [StringLength(3)]
        public string? ToCityCode { get; set; }
        [Column("To City Name")]
        [StringLength(45)]
        public string? ToCityName { get; set; }
        [Column("To Contact Name")]
        [StringLength(50)]
        public string? ToContactName { get; set; }
        [Column("To Email")]
        [StringLength(50)]
        public string? ToEmail { get; set; }
        [Column("To Fax")]
        [StringLength(30)]
        public string? ToFax { get; set; }
        [Column("To Place Code")]
        [StringLength(10)]
        public string? ToPlaceCode { get; set; }
        [Column("To Postal Code")]
        [StringLength(10)]
        public string? ToPostalCode { get; set; }
        [Column("To Telephone")]
        [StringLength(30)]
        public string? ToTelephone { get; set; }
        [Column("To Zone")]
        [StringLength(10)]
        public string? ToZone { get; set; }
        [Column("Total Charge Weight", TypeName = "decimal(13, 4)")]
        public decimal? TotalChargeWeight { get; set; }
        [Column("Total Container")]
        public string? TotalContainer { get; set; }
        [Column("Total Container Type")]
        [StringLength(1000)]
        public string? TotalContainerType { get; set; }
        [Column("Total Gross Weight", TypeName = "decimal(13, 4)")]
        public decimal? TotalGrossWeight { get; set; }
        [Column("Total Item", TypeName = "decimal(13, 4)")]
        public decimal? TotalItem { get; set; }
        [Column("Total Pcs")]
        public int? TotalPcs { get; set; }
        [Column("Total Volume", TypeName = "decimal(13, 4)")]
        public decimal? TotalVolume { get; set; }
        [Column("Trailer No")]
        [StringLength(255)]
        public string? TrailerNo { get; set; }
        [Column("Transport Agent")]
        [StringLength(10)]
        public string? TransportAgent { get; set; }
        [Column("Transport Company Code")]
        [StringLength(10)]
        public string? TransportCompanyCode { get; set; }
        [Column("Transport Company Name")]
        [StringLength(80)]
        public string? TransportCompanyName { get; set; }
        [Column("Transport Company Address 1")]
        [StringLength(50)]
        public string? TransportCompanyAddress1 { get; set; }
        [Column("Transport Company Address 2")]
        [StringLength(50)]
        public string? TransportCompanyAddress2 { get; set; }
        [Column("Transport Company Address 3")]
        [StringLength(50)]
        public string? TransportCompanyAddress3 { get; set; }
        [Column("Transport Company Address 4")]
        [StringLength(50)]
        public string? TransportCompanyAddress4 { get; set; }
        [Column("Transport Company Place Code")]
        [StringLength(10)]
        public string? TransportCompanyPlaceCode { get; set; }
        [Column("Transport Type")]
        [StringLength(1)]
        public string? TransportType { get; set; }
        [Column("Trip Weightage", TypeName = "decimal(18, 1)")]
        public decimal? TripWeightage { get; set; }
        [Column("Uci No")]
        [StringLength(15)]
        public string? UciNo { get; set; }
        [Column("Ucr No")]
        [StringLength(50)]
        public string? UcrNo { get; set; }
        [Column("Unstuffing At Code")]
        [StringLength(10)]
        public string? UnstuffingAtCode { get; set; }
        [Column("Unstuffing Name")]
        [StringLength(80)]
        public string? UnstuffingName { get; set; }
        [Column("Uom Code")]
        [StringLength(50)]
        public string? UomCode { get; set; }
        [Column("Update Charge Flag")]
        [StringLength(1)]
        public string? UpdateChargeFlag { get; set; }
        [Column("User Define 01")]
        [StringLength(255)]
        public string? UserDefine01 { get; set; }
        [Column("User Define 02")]
        [StringLength(255)]
        public string? UserDefine02 { get; set; }
        [Column("User Define 03")]
        [StringLength(255)]
        public string? UserDefine03 { get; set; }
        [Column("User Define 04")]
        [StringLength(255)]
        public string? UserDefine04 { get; set; }
        [Column("User Define 05")]
        [StringLength(255)]
        public string? UserDefine05 { get; set; }
        [Column("User Define 06")]
        [StringLength(255)]
        public string? UserDefine06 { get; set; }
        [Column("User Define 07")]
        [StringLength(255)]
        public string? UserDefine07 { get; set; }
        [Column("User Define 08")]
        [StringLength(255)]
        public string? UserDefine08 { get; set; }
        [Column("User Define 09")]
        [StringLength(255)]
        public string? UserDefine09 { get; set; }
        [Column("User Define 10")]
        [StringLength(255)]
        public string? UserDefine10 { get; set; }
        [Column("User Define 11")]
        [StringLength(255)]
        public string? UserDefine11 { get; set; }
        [Column("User Define 12")]
        [StringLength(255)]
        public string? UserDefine12 { get; set; }
        [Column("User Define 13")]
        [StringLength(255)]
        public string? UserDefine13 { get; set; }
        [Column("User Define 14")]
        [StringLength(255)]
        public string? UserDefine14 { get; set; }
        [Column("User Define 15")]
        [StringLength(255)]
        public string? UserDefine15 { get; set; }
        [Column("User Define 16")]
        [StringLength(255)]
        public string? UserDefine16 { get; set; }
        [Column("User Define 17")]
        [StringLength(255)]
        public string? UserDefine17 { get; set; }
        [Column("User Define 18")]
        [StringLength(255)]
        public string? UserDefine18 { get; set; }
        [Column("User Define 19")]
        [StringLength(255)]
        public string? UserDefine19 { get; set; }
        [Column("User Define 20")]
        [StringLength(255)]
        public string? UserDefine20 { get; set; }
        [Column("User Define 21")]
        [StringLength(255)]
        public string? UserDefine21 { get; set; }
        [Column("User Define 22")]
        [StringLength(255)]
        public string? UserDefine22 { get; set; }
        [Column("User Define 23")]
        [StringLength(255)]
        public string? UserDefine23 { get; set; }
        [Column("User Define 24")]
        [StringLength(255)]
        public string? UserDefine24 { get; set; }
        [Column("User Define 25")]
        [StringLength(255)]
        public string? UserDefine25 { get; set; }
        [Column("Vehicle No")]
        [StringLength(15)]
        public string? VehicleNo { get; set; }
        [Column("Vessel Code")]
        [StringLength(50)]
        public string? VesselCode { get; set; }
        [Column("Vessel Name")]
        [StringLength(50)]
        public string? VesselName { get; set; }
        [Column("Voyage No")]
        [StringLength(20)]
        public string? VoyageNo { get; set; }
        [Column("Yard Code")]
        [StringLength(10)]
        public string? YardCode { get; set; }
        [Column("Yard Name")]
        [StringLength(80)]
        public string? YardName { get; set; }
        [Column("Your Del No")]
        [StringLength(25)]
        public string? YourDelNo { get; set; }
        [Column("Your Ref No")]
        [StringLength(24)]
        public string? YourRefNo { get; set; }
        [Column("Work Station")]
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
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
