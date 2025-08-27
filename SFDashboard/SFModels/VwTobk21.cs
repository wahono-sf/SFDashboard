using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwTobk21
    {
        [Column("Booking No")]
        [StringLength(10)]
        public string BookingNo { get; set; } = null!;
        [Column("Line Item No")]
        public short LineItemNo { get; set; }
        [Column("ASN No")]
        [StringLength(50)]
        public string? AsnNo { get; set; }
        [Column("Assistant Code")]
        [StringLength(15)]
        public string? AssistantCode { get; set; }
        [Column("Attendent Flag")]
        [StringLength(1)]
        public string? AttendentFlag { get; set; }
        [Column("Available Pcs")]
        public int? AvailablePcs { get; set; }
        [Column("Billable Truck Size Code")]
        [StringLength(10)]
        public string? BillableTruckSizeCode { get; set; }
        [Column("Book Ref No")]
        [StringLength(24)]
        public string? BookRefNo { get; set; }
        [Column("Buy Amt", TypeName = "decimal(13, 4)")]
        public decimal? BuyAmt { get; set; }
        [Column("Buy Rate", TypeName = "decimal(13, 4)")]
        public decimal? BuyRate { get; set; }
        [Column("Cargo Type")]
        [StringLength(5)]
        public string? CargoType { get; set; }
        [Column("Charge Weight", TypeName = "decimal(13, 4)")]
        public decimal? ChargeWeight { get; set; }
        [Column("Chassis Type")]
        [StringLength(20)]
        public string? ChassisType { get; set; }
        [Column("Collect Driver")]
        [StringLength(15)]
        public string? CollectDriver { get; set; }
        [Column("Collect Trailer No")]
        [StringLength(12)]
        public string? CollectTrailerNo { get; set; }
        [Column("Collect Vehicle No")]
        [StringLength(12)]
        public string? CollectVehicleNo { get; set; }
        [Column("Commodity Code")]
        [StringLength(50)]
        public string? CommodityCode { get; set; }
        [Column("Commodity Name")]
        [StringLength(50)]
        public string? CommodityName { get; set; }
        [Column("Complete Flag")]
        [StringLength(1)]
        public string? CompleteFlag { get; set; }
        [Column("Contact Name")]
        [StringLength(50)]
        public string? ContactName { get; set; }
        [Column("Contact Telephone")]
        [StringLength(30)]
        public string? ContactTelephone { get; set; }
        [Column("Container No")]
        [StringLength(13)]
        public string? ContainerNo { get; set; }
        [Column("Container Park At")]
        [StringLength(100)]
        public string? ContainerParkAt { get; set; }
        [Column("Container Ref No")]
        [StringLength(9)]
        public string? ContainerRefNo { get; set; }
        [Column("Container Type")]
        [StringLength(5)]
        public string? ContainerType { get; set; }
        [Column("Delivery Date")]
        [StringLength(16)]
        [Unicode(false)]
        public string? DeliveryDate { get; set; }
        [Column("Delivery Gross Weight", TypeName = "decimal(13, 4)")]
        public decimal? DeliveryGrossWeight { get; set; }
        [Column("Delivery Order No")]
        [StringLength(20)]
        public string? DeliveryOrderNo { get; set; }
        [Column("Delivery Pcs")]
        public int? DeliveryPcs { get; set; }
        [Column("Delivery Volume", TypeName = "decimal(13, 4)")]
        public decimal? DeliveryVolume { get; set; }
        [Column("DG Flag")]
        [StringLength(1)]
        public string? DgFlag { get; set; }
        [Column("Direct Flag")]
        [StringLength(1)]
        public string? DirectFlag { get; set; }
        [Column("Do Flag")]
        [StringLength(1)]
        public string? DoFlag { get; set; }
        [Column("Driver Code")]
        [StringLength(15)]
        public string? DriverCode { get; set; }
        [Column("Escort Flag")]
        [StringLength(1)]
        public string? EscortFlag { get; set; }
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
        [Column("Export Time")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ExportTime { get; set; }
        [Column("Fiata Amt", TypeName = "decimal(13, 4)")]
        public decimal? FiataAmt { get; set; }
        [Column("Fiata Rate", TypeName = "decimal(13, 4)")]
        public decimal? FiataRate { get; set; }
        [Column("Flag Status")]
        [StringLength(10)]
        public string? FlagStatus { get; set; }
        [Column("From Location Code")]
        [StringLength(10)]
        public string? FromLocationCode { get; set; }
        [Column("From Location Name")]
        [StringLength(100)]
        public string? FromLocationName { get; set; }
        [Column("From Location Address 1")]
        [StringLength(50)]
        public string? FromLocationAddress1 { get; set; }
        [Column("From Location Address 2")]
        [StringLength(50)]
        public string? FromLocationAddress2 { get; set; }
        [Column("From Location Address 3")]
        [StringLength(50)]
        public string? FromLocationAddress3 { get; set; }
        [Column("From Location Address 4")]
        [StringLength(50)]
        public string? FromLocationAddress4 { get; set; }
        [Column("From City Code")]
        [StringLength(3)]
        public string? FromCityCode { get; set; }
        [Column("From City Name")]
        [StringLength(45)]
        public string? FromCityName { get; set; }
        [Column("From Contact")]
        [StringLength(50)]
        public string? FromContact { get; set; }
        [Column("From Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? FromDateTime { get; set; }
        [Column("From Place Code")]
        [StringLength(10)]
        public string? FromPlaceCode { get; set; }
        [Column("From Postal Code")]
        [StringLength(10)]
        public string? FromPostalCode { get; set; }
        [Column("From  Telephone")]
        [StringLength(30)]
        public string? FromTelephone { get; set; }
        [Column("From Zone")]
        [StringLength(10)]
        public string? FromZone { get; set; }
        [Column("Gate In Date Time")]
        [StringLength(10)]
        [Unicode(false)]
        public string? GateInDateTime { get; set; }
        [Column("Goods Description 01")]
        [StringLength(50)]
        public string? GoodsDescription01 { get; set; }
        [Column("Goods Description 02")]
        [StringLength(50)]
        public string? GoodsDescription02 { get; set; }
        [Column("Goods Description 03")]
        [StringLength(50)]
        public string? GoodsDescription03 { get; set; }
        [Column("Goods Description 04")]
        [StringLength(50)]
        public string? GoodsDescription04 { get; set; }
        [Column("Goods Description 05")]
        [StringLength(50)]
        public string? GoodsDescription05 { get; set; }
        [Column("Goods Description 06")]
        [StringLength(50)]
        public string? GoodsDescription06 { get; set; }
        [Column("Goods Description 07")]
        [StringLength(50)]
        public string? GoodsDescription07 { get; set; }
        [Column("Goods Description 08")]
        [StringLength(50)]
        public string? GoodsDescription08 { get; set; }
        [Column("Goods Description 09")]
        [StringLength(50)]
        public string? GoodsDescription09 { get; set; }
        [Column("Goods Description 10")]
        [StringLength(50)]
        public string? GoodsDescription10 { get; set; }
        [Column("Goods Description 11")]
        [StringLength(50)]
        public string? GoodsDescription11 { get; set; }
        [Column("Goods Description 12")]
        [StringLength(50)]
        public string? GoodsDescription12 { get; set; }
        [Column("Goods Description 13")]
        [StringLength(50)]
        public string? GoodsDescription13 { get; set; }
        [Column("Goods Description 14")]
        [StringLength(50)]
        public string? GoodsDescription14 { get; set; }
        [Column("Goods Description 15")]
        [StringLength(50)]
        public string? GoodsDescription15 { get; set; }
        [Column("Gross Weight", TypeName = "decimal(13, 4)")]
        public decimal? GrossWeight { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Height { get; set; }
        [Column("Inner Packing")]
        [StringLength(25)]
        public string? InnerPacking { get; set; }
        [StringLength(255)]
        public string? Instructions { get; set; }
        [Column("Job No")]
        [StringLength(30)]
        public string? JobNo { get; set; }
        [Column("Last Day Psa Date Time")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastDayPsaDateTime { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Length { get; set; }
        [StringLength(50)]
        public string? Location { get; set; }
        [StringLength(255)]
        public string? Marking { get; set; }
        [Column("Mark No 01")]
        [StringLength(25)]
        public string? MarkNo01 { get; set; }
        [Column("Mark No 02")]
        [StringLength(25)]
        public string? MarkNo02 { get; set; }
        [Column("Mark No 03")]
        [StringLength(25)]
        public string? MarkNo03 { get; set; }
        [Column("Mark No 04")]
        [StringLength(25)]
        public string? MarkNo04 { get; set; }
        [Column("Mark No 05")]
        [StringLength(25)]
        public string? MarkNo05 { get; set; }
        [Column("Mark No 06")]
        [StringLength(25)]
        public string? MarkNo06 { get; set; }
        [Column("Mark No 07")]
        [StringLength(25)]
        public string? MarkNo07 { get; set; }
        [Column("Mark No 08")]
        [StringLength(25)]
        public string? MarkNo08 { get; set; }
        [Column("Mark No 09")]
        [StringLength(25)]
        public string? MarkNo09 { get; set; }
        [Column("Mark No 10")]
        [StringLength(25)]
        public string? MarkNo10 { get; set; }
        [Column("Mark No 11")]
        [StringLength(25)]
        public string? MarkNo11 { get; set; }
        [Column("Mark No 12")]
        [StringLength(25)]
        public string? MarkNo12 { get; set; }
        [Column("Mark No 13")]
        [StringLength(25)]
        public string? MarkNo13 { get; set; }
        [Column("Mark No 14")]
        [StringLength(25)]
        public string? MarkNo14 { get; set; }
        [Column("Mark No 15")]
        [StringLength(25)]
        public string? MarkNo15 { get; set; }
        [Column("No Of Pallet")]
        public int? NoOfPallet { get; set; }
        [Column("No Of Trip")]
        [StringLength(20)]
        public string? NoOfTrip { get; set; }
        [StringLength(255)]
        public string? Note { get; set; }
        [Column("OOG Flag")]
        [StringLength(1)]
        public string? OogFlag { get; set; }
        public int? Pcs { get; set; }
        [Column("Permit Flag")]
        [StringLength(1)]
        public string? PermitFlag { get; set; }
        [Column("Permit No")]
        [StringLength(50)]
        public string? PermitNo { get; set; }
        [Column("Pickup Ref")]
        [StringLength(24)]
        public string? PickupRef { get; set; }
        [Column("Process Flag")]
        [StringLength(1)]
        public string? ProcessFlag { get; set; }
        [Column("Product No")]
        [StringLength(25)]
        public string? ProductNo { get; set; }
        [Column("Ref No")]
        [StringLength(255)]
        public string? RefNo { get; set; }
        [Column("Release Flag")]
        [StringLength(10)]
        public string? ReleaseFlag { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Return Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? ReturnDateTime { get; set; }
        [Column("Return Driver")]
        [StringLength(15)]
        public string? ReturnDriver { get; set; }
        [Column("Return Flag")]
        [StringLength(1)]
        public string? ReturnFlag { get; set; }
        [Column("Return Trailer No")]
        [StringLength(12)]
        public string? ReturnTrailerNo { get; set; }
        [Column("Return Vehicle No")]
        [StringLength(12)]
        public string? ReturnVehicleNo { get; set; }
        [Column("Return Yard Name")]
        [StringLength(100)]
        public string? ReturnYardName { get; set; }
        [Column("Schedule Date")]
        [StringLength(16)]
        [Unicode(false)]
        public string? ScheduleDate { get; set; }
        [Column("Schedule ID")]
        [StringLength(10)]
        public string? ScheduleId { get; set; }
        [Column("Seal No")]
        [StringLength(15)]
        public string? SealNo { get; set; }
        [Column("Sell Amt", TypeName = "decimal(13, 4)")]
        public decimal? SellAmt { get; set; }
        [Column("Sell Rate", TypeName = "decimal(13, 4)")]
        public decimal? SellRate { get; set; }
        [Column("Shifting Flag")]
        [StringLength(1)]
        public string? ShiftingFlag { get; set; }
        [Column("Short Landed")]
        public int? ShortLanded { get; set; }
        [Column("Source Job No")]
        [StringLength(30)]
        public string? SourceJobNo { get; set; }
        [StringLength(10)]
        public string? Status { get; set; }
        [Column("Stuff Or Unstaff Flag")]
        [StringLength(1)]
        public string? StuffOrUnstaffFlag { get; set; }
        [Column("Surveyed Amt")]
        public int? SurveyedAmt { get; set; }
        [Column("Text Flag")]
        [StringLength(1)]
        public string? TextFlag { get; set; }
        [Column("To Location Code")]
        [StringLength(10)]
        public string? ToLocationCode { get; set; }
        [Column("To Location Name")]
        [StringLength(100)]
        public string? ToLocationName { get; set; }
        [Column("To Location Address 1")]
        [StringLength(50)]
        public string? ToLocationAddress1 { get; set; }
        [Column("To Location Address 2")]
        [StringLength(50)]
        public string? ToLocationAddress2 { get; set; }
        [Column("To Location Address 3")]
        [StringLength(50)]
        public string? ToLocationAddress3 { get; set; }
        [Column("To Location Address 4")]
        [StringLength(50)]
        public string? ToLocationAddress4 { get; set; }
        [Column("To City Code")]
        [StringLength(3)]
        public string? ToCityCode { get; set; }
        [Column("To City Name")]
        [StringLength(45)]
        public string? ToCityName { get; set; }
        [Column("To Contact Name")]
        [StringLength(50)]
        public string? ToContactName { get; set; }
        [Column("To Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? ToDateTime { get; set; }
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
        [StringLength(15)]
        public string? ToZone { get; set; }
        [Column("Trailer No")]
        [StringLength(12)]
        public string? TrailerNo { get; set; }
        [Column("Trailer Park At")]
        [StringLength(100)]
        public string? TrailerParkAt { get; set; }
        [Column("Trip Code")]
        [StringLength(5)]
        public string? TripCode { get; set; }
        [Column("Trip Colour")]
        [StringLength(20)]
        [Unicode(false)]
        public string? TripColour { get; set; }
        [Column("Trip Description")]
        [StringLength(50)]
        public string? TripDescription { get; set; }
        [Column("Trip Link Key No")]
        public int? TripLinkKeyNo { get; set; }
        [Column("Trip Rate", TypeName = "decimal(16, 2)")]
        public decimal? TripRate { get; set; }
        [Column("Trip Type")]
        [StringLength(25)]
        public string? TripType { get; set; }
        [Column("Trip Weightage", TypeName = "decimal(18, 1)")]
        public decimal? TripWeightage { get; set; }
        [Column("Trx Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? TrxDate { get; set; }
        [Column("Trx Type")]
        [StringLength(1)]
        public string? TrxType { get; set; }
        [Column("Ucr No")]
        [StringLength(17)]
        public string? UcrNo { get; set; }
        [Column("Uom Code")]
        [StringLength(50)]
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
        [Column("User Define 11")]
        [StringLength(50)]
        public string? UserDefine11 { get; set; }
        [Column("User Define 12")]
        [StringLength(50)]
        public string? UserDefine12 { get; set; }
        [Column("User Define 13")]
        [StringLength(50)]
        public string? UserDefine13 { get; set; }
        [Column("User Define 14")]
        [StringLength(50)]
        public string? UserDefine14 { get; set; }
        [Column("User Define 15")]
        [StringLength(50)]
        public string? UserDefine15 { get; set; }
        [Column("User Define 16")]
        [StringLength(50)]
        public string? UserDefine16 { get; set; }
        [Column("User Define 17")]
        [StringLength(50)]
        public string? UserDefine17 { get; set; }
        [Column("User Define 18")]
        [StringLength(50)]
        public string? UserDefine18 { get; set; }
        [Column("User Define 19")]
        [StringLength(50)]
        public string? UserDefine19 { get; set; }
        [Column("User Define 20")]
        [StringLength(50)]
        public string? UserDefine20 { get; set; }
        [Column("User Define 21")]
        [StringLength(50)]
        public string? UserDefine21 { get; set; }
        [Column("User Define 22")]
        [StringLength(50)]
        public string? UserDefine22 { get; set; }
        [Column("User Define 23")]
        [StringLength(50)]
        public string? UserDefine23 { get; set; }
        [Column("User Define 24")]
        [StringLength(50)]
        public string? UserDefine24 { get; set; }
        [Column("User Define 25")]
        [StringLength(50)]
        public string? UserDefine25 { get; set; }
        [Column("Vehicle No")]
        [StringLength(12)]
        public string? VehicleNo { get; set; }
        [Column("Vehicle Type")]
        [StringLength(10)]
        public string? VehicleType { get; set; }
        [Column("Vessel Name")]
        [StringLength(50)]
        public string? VesselName { get; set; }
        [Column("Vessel Name 2")]
        [StringLength(50)]
        public string? VesselName2 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Volume { get; set; }
        [Column("Voyage No")]
        [StringLength(20)]
        public string? VoyageNo { get; set; }
        [Column("Voyage No 2")]
        [StringLength(20)]
        public string? VoyageNo2 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Width { get; set; }
    }
}
