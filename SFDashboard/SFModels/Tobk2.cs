using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("tobk2")]
    public partial class Tobk2
    {
        [Key]
        [StringLength(10)]
        public string BookingNo { get; set; } = null!;
        [Key]
        public short LineItemNo { get; set; }
        [Column("ASNNo")]
        [StringLength(50)]
        public string? Asnno { get; set; }
        [StringLength(15)]
        public string? AssistantCode { get; set; }
        [StringLength(1)]
        public string? AttendentFlag { get; set; }
        public int? AvailablePcs { get; set; }
        [StringLength(10)]
        public string? BillableTruckSizeCode { get; set; }
        [StringLength(24)]
        public string? BookRefNo { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? BuyAmt { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? BuyRate { get; set; }
        [StringLength(5)]
        public string? CargoType { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? ChargeWeight { get; set; }
        [StringLength(20)]
        public string? ChassisType { get; set; }
        [StringLength(15)]
        public string? CollectDriver { get; set; }
        [StringLength(12)]
        public string? CollectTrailerNo { get; set; }
        [StringLength(12)]
        public string? CollectVehicleNo { get; set; }
        [StringLength(50)]
        public string? CommodityCode { get; set; }
        [StringLength(50)]
        public string? CommodityName { get; set; }
        [StringLength(1)]
        public string? CompleteFlag { get; set; }
        [StringLength(50)]
        public string? ContactName { get; set; }
        [StringLength(30)]
        public string? ContactTelephone { get; set; }
        [StringLength(13)]
        public string? ContainerNo { get; set; }
        [StringLength(100)]
        public string? ContainerParkAt { get; set; }
        [StringLength(9)]
        public string? ContainerRefNo { get; set; }
        [StringLength(5)]
        public string? ContainerType { get; set; }
        [Column("DGFlag")]
        [StringLength(1)]
        public string? Dgflag { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DeliveryDate { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? DeliveryGrossWeight { get; set; }
        [StringLength(20)]
        public string? DeliveryOrderNo { get; set; }
        public int? DeliveryPcs { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? DeliveryVolume { get; set; }
        [StringLength(1)]
        public string? DirectFlag { get; set; }
        [StringLength(1)]
        public string? DoFlag { get; set; }
        [StringLength(15)]
        public string? DriverCode { get; set; }
        [StringLength(255)]
        public string? DriverRemark { get; set; }
        [StringLength(1)]
        public string? EscortFlag { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EtaDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EtaDate2 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EtdDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EtdDate2 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ExportTime { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? FiataAmt { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? FiataRate { get; set; }
        [StringLength(10)]
        public string? FlagStatus { get; set; }
        [StringLength(10)]
        public string? FromLocationCode { get; set; }
        [StringLength(100)]
        public string? FromLocationName { get; set; }
        [StringLength(50)]
        public string? FromLocationAddress1 { get; set; }
        [StringLength(50)]
        public string? FromLocationAddress2 { get; set; }
        [StringLength(50)]
        public string? FromLocationAddress3 { get; set; }
        [StringLength(50)]
        public string? FromLocationAddress4 { get; set; }
        [StringLength(3)]
        public string? FromCityCode { get; set; }
        [StringLength(45)]
        public string? FromCityName { get; set; }
        [StringLength(50)]
        public string? FromContact { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromDateTime { get; set; }
        [StringLength(10)]
        public string? FromPlaceCode { get; set; }
        [StringLength(10)]
        public string? FromPostalCode { get; set; }
        [StringLength(30)]
        public string? FromTelephone { get; set; }
        [StringLength(10)]
        public string? FromZone { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? GateInDateTime { get; set; }
        [StringLength(50)]
        public string? GoodsDescription01 { get; set; }
        [StringLength(50)]
        public string? GoodsDescription02 { get; set; }
        [StringLength(50)]
        public string? GoodsDescription03 { get; set; }
        [StringLength(50)]
        public string? GoodsDescription04 { get; set; }
        [StringLength(50)]
        public string? GoodsDescription05 { get; set; }
        [StringLength(50)]
        public string? GoodsDescription06 { get; set; }
        [StringLength(50)]
        public string? GoodsDescription07 { get; set; }
        [StringLength(50)]
        public string? GoodsDescription08 { get; set; }
        [StringLength(50)]
        public string? GoodsDescription09 { get; set; }
        [StringLength(50)]
        public string? GoodsDescription10 { get; set; }
        [StringLength(50)]
        public string? GoodsDescription11 { get; set; }
        [StringLength(50)]
        public string? GoodsDescription12 { get; set; }
        [StringLength(50)]
        public string? GoodsDescription13 { get; set; }
        [StringLength(50)]
        public string? GoodsDescription14 { get; set; }
        [StringLength(50)]
        public string? GoodsDescription15 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? GrossWeight { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Height { get; set; }
        [StringLength(25)]
        public string? InnerPacking { get; set; }
        [StringLength(255)]
        public string? Instructions { get; set; }
        [StringLength(30)]
        public string? JobNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastDayPsaDateTime { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Length { get; set; }
        [StringLength(50)]
        public string? Location { get; set; }
        [StringLength(255)]
        public string? Marking { get; set; }
        [StringLength(25)]
        public string? MarkNo01 { get; set; }
        [StringLength(25)]
        public string? MarkNo02 { get; set; }
        [StringLength(25)]
        public string? MarkNo03 { get; set; }
        [StringLength(25)]
        public string? MarkNo04 { get; set; }
        [StringLength(25)]
        public string? MarkNo05 { get; set; }
        [StringLength(25)]
        public string? MarkNo06 { get; set; }
        [StringLength(25)]
        public string? MarkNo07 { get; set; }
        [StringLength(25)]
        public string? MarkNo08 { get; set; }
        [StringLength(25)]
        public string? MarkNo09 { get; set; }
        [StringLength(25)]
        public string? MarkNo10 { get; set; }
        [StringLength(25)]
        public string? MarkNo11 { get; set; }
        [StringLength(25)]
        public string? MarkNo12 { get; set; }
        [StringLength(25)]
        public string? MarkNo13 { get; set; }
        [StringLength(25)]
        public string? MarkNo14 { get; set; }
        [StringLength(25)]
        public string? MarkNo15 { get; set; }
        public int? NoOfPallet { get; set; }
        [StringLength(20)]
        public string? NoOfTrip { get; set; }
        [StringLength(255)]
        public string? Note { get; set; }
        [Column("OOGFlag")]
        [StringLength(1)]
        public string? Oogflag { get; set; }
        public int? Pcs { get; set; }
        [StringLength(1)]
        public string? PermitFlag { get; set; }
        [StringLength(50)]
        public string? PermitNo { get; set; }
        [StringLength(24)]
        public string? PickupRef { get; set; }
        [StringLength(1)]
        public string? ProcessFlag { get; set; }
        [StringLength(25)]
        public string? ProductNo { get; set; }
        [StringLength(255)]
        public string? RefNo { get; set; }
        [StringLength(10)]
        public string? ReleaseFlag { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReturnDateTime { get; set; }
        [StringLength(1)]
        public string? ReturnFlag { get; set; }
        [StringLength(15)]
        public string? ReturnDriver { get; set; }
        [StringLength(12)]
        public string? ReturnTrailerNo { get; set; }
        [StringLength(12)]
        public string? ReturnVehicleNo { get; set; }
        [StringLength(100)]
        public string? ReturnyardName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ScheduleDate { get; set; }
        [Column("ScheduleID")]
        [StringLength(10)]
        public string? ScheduleId { get; set; }
        [StringLength(15)]
        public string? SealNo { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? SellAmt { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? SellRate { get; set; }
        [StringLength(1)]
        public string? ShiftingFlag { get; set; }
        public int? ShortLanded { get; set; }
        [StringLength(30)]
        public string? SourceJobNo { get; set; }
        [StringLength(10)]
        public string? StatusCode { get; set; }
        [StringLength(1)]
        public string? StuffOrUnstaffFlag { get; set; }
        public int? SurveyedAmt { get; set; }
        [StringLength(1)]
        public string? TextFlag { get; set; }
        [StringLength(10)]
        public string? ToLocationCode { get; set; }
        [StringLength(100)]
        public string? ToLocationName { get; set; }
        [StringLength(50)]
        public string? ToLocationAddress1 { get; set; }
        [StringLength(50)]
        public string? ToLocationAddress2 { get; set; }
        [StringLength(50)]
        public string? ToLocationAddress3 { get; set; }
        [StringLength(50)]
        public string? ToLocationAddress4 { get; set; }
        [StringLength(3)]
        public string? ToCityCode { get; set; }
        [StringLength(45)]
        public string? ToCityName { get; set; }
        [StringLength(50)]
        public string? ToContactName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ToDateTime { get; set; }
        [StringLength(10)]
        public string? ToPlaceCode { get; set; }
        [StringLength(10)]
        public string? ToPostalCode { get; set; }
        [StringLength(30)]
        public string? ToTelephone { get; set; }
        [StringLength(15)]
        public string? ToZone { get; set; }
        [StringLength(12)]
        public string? TrailerNo { get; set; }
        [StringLength(100)]
        public string? TrailerParkAt { get; set; }
        [StringLength(50)]
        public string? TripCode { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? TripColour { get; set; }
        [StringLength(50)]
        public string? TripDescription { get; set; }
        public int? TripLinkKeyNo { get; set; }
        [StringLength(25)]
        public string? TripType { get; set; }
        [Column(TypeName = "decimal(18, 1)")]
        public decimal? TripWeightage { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TrxDate { get; set; }
        [Column(TypeName = "decimal(16, 2)")]
        public decimal? TripRate { get; set; }
        [StringLength(1)]
        public string? TrxType { get; set; }
        [StringLength(17)]
        public string? UcrNo { get; set; }
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
        public string? UserDefine11 { get; set; }
        [StringLength(50)]
        public string? UserDefine12 { get; set; }
        [StringLength(50)]
        public string? UserDefine13 { get; set; }
        [StringLength(50)]
        public string? UserDefine14 { get; set; }
        [StringLength(50)]
        public string? UserDefine15 { get; set; }
        [StringLength(50)]
        public string? UserDefine16 { get; set; }
        [StringLength(50)]
        public string? UserDefine17 { get; set; }
        [StringLength(50)]
        public string? UserDefine18 { get; set; }
        [StringLength(50)]
        public string? UserDefine19 { get; set; }
        [StringLength(50)]
        public string? UserDefine20 { get; set; }
        [StringLength(50)]
        public string? UserDefine21 { get; set; }
        [StringLength(50)]
        public string? UserDefine22 { get; set; }
        [StringLength(50)]
        public string? UserDefine23 { get; set; }
        [StringLength(50)]
        public string? UserDefine24 { get; set; }
        [StringLength(50)]
        public string? UserDefine25 { get; set; }
        [StringLength(12)]
        public string? VehicleNo { get; set; }
        [StringLength(10)]
        public string? VehicleType { get; set; }
        [StringLength(50)]
        public string? VesselName { get; set; }
        [StringLength(50)]
        public string? VesselName2 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Volume { get; set; }
        [StringLength(20)]
        public string? VoyageNo { get; set; }
        [StringLength(20)]
        public string? VoyageNo2 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Width { get; set; }

        [ForeignKey("BookingNo")]
        [InverseProperty("Tobk2s")]
        public virtual Tobk1 BookingNoNavigation { get; set; } = null!;
    }
}
