using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("tovm1")]
    [Index("StatusCode", Name = "INDEX_Tovm1_StatusCode")]
    public partial class Tovm1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(12)]
        public string VehicleNo { get; set; } = null!;
        [StringLength(6)]
        public string? VehicleType { get; set; }
        [StringLength(1)]
        public string? AttendentFlag { get; set; }
        [StringLength(50)]
        public string? Capacity { get; set; }
        [StringLength(50)]
        public string? ChassisNo { get; set; }
        [StringLength(50)]
        public string? ChassisType { get; set; }
        [Column(TypeName = "decimal(13, 6)")]
        public decimal? Coe { get; set; }
        [Column(TypeName = "decimal(13, 6)")]
        public decimal? DepreciationAmt { get; set; }
        [Column(TypeName = "decimal(13, 8)")]
        public decimal? DepreciationTotal { get; set; }
        [StringLength(15)]
        public string? DriverCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EffectDate { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? EmptyWeight { get; set; }
        [StringLength(50)]
        public string? Engine { get; set; }
        [StringLength(25)]
        public string? EquipmentNo { get; set; }
        [StringLength(6)]
        public string? EquipmentType { get; set; }
        [StringLength(1)]
        public string? EquipmentVehicleType { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ExcessAmt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ExpiryDate { get; set; }
        [StringLength(50)]
        public string? InsuranceCompanyName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InsuranceEffDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InsuranceExpiry { get; set; }
        [Column(TypeName = "decimal(13, 6)")]
        public decimal? InsuranceFee { get; set; }
        [Column("IUNo")]
        [StringLength(50)]
        public string? Iuno { get; set; }
        [StringLength(10)]
        public string? JobType { get; set; }
        [Column(TypeName = "decimal(13, 8)")]
        public decimal? LastYearBilled { get; set; }
        [Column(TypeName = "decimal(13, 8)")]
        public decimal? LastYearFuel { get; set; }
        [Column(TypeName = "decimal(13, 5)")]
        public decimal? LastYearHrs { get; set; }
        [Column(TypeName = "decimal(13, 5)")]
        public decimal? LastYearKm { get; set; }
        [Column(TypeName = "decimal(13, 8)")]
        public decimal? LastYearMaintenance { get; set; }
        [Column(TypeName = "decimal(13, 8)")]
        public decimal? LastYearRepair { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LicenceExpiryDate { get; set; }
        [Column(TypeName = "decimal(13, 6)")]
        public decimal? LicenceFee { get; set; }
        [StringLength(45)]
        public string? LocOrLot { get; set; }
        [StringLength(25)]
        public string? Maker { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? MaxHeight { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? MaxLength { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? MaxLoadWeight { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? MaxWidth { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? MeterReading { get; set; }
        [StringLength(25)]
        public string? Model { get; set; }
        [Column(TypeName = "decimal(13, 7)")]
        public decimal? MonthToDateBilled01 { get; set; }
        [Column(TypeName = "decimal(13, 7)")]
        public decimal? MonthToDateBilled02 { get; set; }
        [Column(TypeName = "decimal(13, 7)")]
        public decimal? MonthToDateBilled03 { get; set; }
        [Column(TypeName = "decimal(13, 7)")]
        public decimal? MonthToDateBilled04 { get; set; }
        [Column(TypeName = "decimal(13, 7)")]
        public decimal? MonthToDateBilled05 { get; set; }
        [Column(TypeName = "decimal(13, 7)")]
        public decimal? MonthToDateBilled06 { get; set; }
        [Column(TypeName = "decimal(13, 7)")]
        public decimal? MonthToDateBilled07 { get; set; }
        [Column(TypeName = "decimal(13, 7)")]
        public decimal? MonthToDateBilled08 { get; set; }
        [Column(TypeName = "decimal(13, 7)")]
        public decimal? MonthToDateBilled09 { get; set; }
        [Column(TypeName = "decimal(13, 7)")]
        public decimal? MonthToDateBilled10 { get; set; }
        [Column(TypeName = "decimal(13, 7)")]
        public decimal? MonthToDateBilled11 { get; set; }
        [Column(TypeName = "decimal(13, 7)")]
        public decimal? MonthToDateBilled12 { get; set; }
        [Column(TypeName = "decimal(13, 7)")]
        public decimal? MonthToDateFuelCost01 { get; set; }
        [Column(TypeName = "decimal(13, 7)")]
        public decimal? MonthToDateFuelCost02 { get; set; }
        [Column(TypeName = "decimal(13, 7)")]
        public decimal? MonthToDateFuelCost03 { get; set; }
        [Column(TypeName = "decimal(13, 7)")]
        public decimal? MonthToDateFuelCost04 { get; set; }
        [Column(TypeName = "decimal(13, 7)")]
        public decimal? MonthToDateFuelCost05 { get; set; }
        [Column(TypeName = "decimal(13, 7)")]
        public decimal? MonthToDateFuelCost06 { get; set; }
        [Column(TypeName = "decimal(13, 7)")]
        public decimal? MonthToDateFuelCost07 { get; set; }
        [Column(TypeName = "decimal(13, 7)")]
        public decimal? MonthToDateFuelCost08 { get; set; }
        [Column(TypeName = "decimal(13, 7)")]
        public decimal? MonthToDateFuelCost09 { get; set; }
        [Column(TypeName = "decimal(13, 7)")]
        public decimal? MonthToDateFuelCost10 { get; set; }
        [Column(TypeName = "decimal(13, 7)")]
        public decimal? MonthToDateFuelCost11 { get; set; }
        [Column(TypeName = "decimal(13, 7)")]
        public decimal? MonthToDateFuelCost12 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? MonthToDateHrs01 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? MonthToDateHrs02 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? MonthToDateHrs03 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? MonthToDateHrs04 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? MonthToDateHrs05 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? MonthToDateHrs06 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? MonthToDateHrs07 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? MonthToDateHrs08 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? MonthToDateHrs09 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? MonthToDateHrs10 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? MonthToDateHrs11 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? MonthToDateHrs12 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? MonthToDateKm01 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? MonthToDateKm02 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? MonthToDateKm03 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? MonthToDateKm04 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? MonthToDateKm05 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? MonthToDateKm06 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? MonthToDateKm07 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? MonthToDateKm08 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? MonthToDateKm09 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? MonthToDateKm10 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? MonthToDateKm11 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? MonthToDateKm12 { get; set; }
        [Column(TypeName = "decimal(13, 7)")]
        public decimal? MonthToDateMaintenance01 { get; set; }
        [Column(TypeName = "decimal(13, 7)")]
        public decimal? MonthToDateMaintenance02 { get; set; }
        [Column(TypeName = "decimal(13, 7)")]
        public decimal? MonthToDateMaintenance03 { get; set; }
        [Column(TypeName = "decimal(13, 7)")]
        public decimal? MonthToDateMaintenance04 { get; set; }
        [Column(TypeName = "decimal(13, 7)")]
        public decimal? MonthToDateMaintenance05 { get; set; }
        [Column(TypeName = "decimal(13, 7)")]
        public decimal? MonthToDateMaintenance06 { get; set; }
        [Column(TypeName = "decimal(13, 7)")]
        public decimal? MonthToDateMaintenance07 { get; set; }
        [Column(TypeName = "decimal(13, 7)")]
        public decimal? MonthToDateMaintenance08 { get; set; }
        [Column(TypeName = "decimal(13, 7)")]
        public decimal? MonthToDateMaintenance09 { get; set; }
        [Column(TypeName = "decimal(13, 7)")]
        public decimal? MonthToDateMaintenance10 { get; set; }
        [Column(TypeName = "decimal(13, 7)")]
        public decimal? MonthToDateMaintenance11 { get; set; }
        [Column(TypeName = "decimal(13, 7)")]
        public decimal? MonthToDateMaintenance12 { get; set; }
        [Column(TypeName = "decimal(13, 7)")]
        public decimal? MonthToDateRepair01 { get; set; }
        [Column(TypeName = "decimal(13, 7)")]
        public decimal? MonthToDateRepair02 { get; set; }
        [Column(TypeName = "decimal(13, 7)")]
        public decimal? MonthToDateRepair03 { get; set; }
        [Column(TypeName = "decimal(13, 7)")]
        public decimal? MonthToDateRepair04 { get; set; }
        [Column(TypeName = "decimal(13, 7)")]
        public decimal? MonthToDateRepair05 { get; set; }
        [Column(TypeName = "decimal(13, 7)")]
        public decimal? MonthToDateRepair06 { get; set; }
        [Column(TypeName = "decimal(13, 7)")]
        public decimal? MonthToDateRepair07 { get; set; }
        [Column(TypeName = "decimal(13, 7)")]
        public decimal? MonthToDateRepair08 { get; set; }
        [Column(TypeName = "decimal(13, 7)")]
        public decimal? MonthToDateRepair09 { get; set; }
        [Column(TypeName = "decimal(13, 7)")]
        public decimal? MonthToDateRepair10 { get; set; }
        [Column(TypeName = "decimal(13, 7)")]
        public decimal? MonthToDateRepair11 { get; set; }
        [Column(TypeName = "decimal(13, 7)")]
        public decimal? MonthToDateRepair12 { get; set; }
        [StringLength(50)]
        public string? Name { get; set; }
        [StringLength(255)]
        public string? Note { get; set; }
        [StringLength(10)]
        public string? OwnerCode { get; set; }
        [StringLength(80)]
        public string? OwnerName { get; set; }
        [StringLength(50)]
        public string? OwnerAddress1 { get; set; }
        [StringLength(50)]
        public string? OwnerAddress2 { get; set; }
        [StringLength(50)]
        public string? OwnerAddress3 { get; set; }
        [StringLength(50)]
        public string? OwnerAddress4 { get; set; }
        [StringLength(30)]
        public string? PolicyNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PurchaseDate { get; set; }
        [Column(TypeName = "decimal(13, 6)")]
        public decimal? PurchaseInsurance { get; set; }
        [Column(TypeName = "decimal(13, 7)")]
        public decimal? PurchasePrice { get; set; }
        [StringLength(50)]
        public string? PurchaseRegistration { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RegistrationEffectiveDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RegistrationExpiryDate { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RoadTaxEffDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RoadTaxExpDate { get; set; }
        [StringLength(50)]
        public string? RoadTaxNo { get; set; }
        [StringLength(50)]
        public string? ScopeOfCover { get; set; }
        [StringLength(50)]
        public string? SerialNo { get; set; }
        [Column("VPCertificateCompanyName")]
        [StringLength(50)]
        public string? VpcertificateCompanyName { get; set; }
        [Column("VPCertificateNo")]
        [StringLength(20)]
        public string? VpcertificateNo { get; set; }
        [StringLength(4)]
        public string? Year { get; set; }
        [Column(TypeName = "decimal(13, 8)")]
        public decimal? YearToDateBilled { get; set; }
        [Column(TypeName = "decimal(13, 8)")]
        public decimal? YearToDateFuel { get; set; }
        [Column(TypeName = "decimal(13, 5)")]
        public decimal? YearToDateHrs { get; set; }
        [Column(TypeName = "decimal(13, 5)")]
        public decimal? YearToDateKm { get; set; }
        [Column(TypeName = "decimal(13, 8)")]
        public decimal? YearToDateMaintenance { get; set; }
        [Column(TypeName = "decimal(13, 8)")]
        public decimal? YearToDateRepair { get; set; }
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
