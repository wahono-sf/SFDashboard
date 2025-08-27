using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwTovm1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Job Type")]
        [StringLength(10)]
        public string? JobType { get; set; }
        [Column("Vehicle No")]
        [StringLength(12)]
        public string VehicleNo { get; set; } = null!;
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Attendent Flag")]
        [StringLength(1)]
        public string? AttendentFlag { get; set; }
        [StringLength(50)]
        public string? Capacity { get; set; }
        [Column("Chassis No")]
        [StringLength(50)]
        public string? ChassisNo { get; set; }
        [Column("Chassis Type")]
        [StringLength(50)]
        public string? ChassisType { get; set; }
        [Column(TypeName = "decimal(13, 6)")]
        public decimal? Coe { get; set; }
        [Column("Depreciation Amt", TypeName = "decimal(13, 6)")]
        public decimal? DepreciationAmt { get; set; }
        [Column("Depreciation Total", TypeName = "decimal(13, 8)")]
        public decimal? DepreciationTotal { get; set; }
        [Column("Driver Code")]
        [StringLength(15)]
        public string? DriverCode { get; set; }
        [Column("Effect Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? EffectDate { get; set; }
        [Column("Empty Weight", TypeName = "decimal(13, 4)")]
        public decimal? EmptyWeight { get; set; }
        [StringLength(50)]
        public string? Engine { get; set; }
        [Column("Equipment No")]
        [StringLength(25)]
        public string? EquipmentNo { get; set; }
        [Column("Equipment Type")]
        [StringLength(6)]
        public string? EquipmentType { get; set; }
        [Column("Equipment Vehicle Type")]
        [StringLength(1)]
        public string? EquipmentVehicleType { get; set; }
        [Column("Excess Amt", TypeName = "decimal(13, 2)")]
        public decimal? ExcessAmt { get; set; }
        [Column("Expiry Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ExpiryDate { get; set; }
        [Column("Insurance Company Name")]
        [StringLength(50)]
        public string? InsuranceCompanyName { get; set; }
        [Column("Insurance Eff Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? InsuranceEffDate { get; set; }
        [Column("Insurance Expiry")]
        [StringLength(10)]
        [Unicode(false)]
        public string? InsuranceExpiry { get; set; }
        [Column("Insurance Fee", TypeName = "decimal(13, 6)")]
        public decimal? InsuranceFee { get; set; }
        [Column("IU No")]
        [StringLength(50)]
        public string? IuNo { get; set; }
        [Column("Last Year Billed", TypeName = "decimal(13, 8)")]
        public decimal? LastYearBilled { get; set; }
        [Column("Last Year Fuel", TypeName = "decimal(13, 8)")]
        public decimal? LastYearFuel { get; set; }
        [Column("Last Year Hrs", TypeName = "decimal(13, 5)")]
        public decimal? LastYearHrs { get; set; }
        [Column("Last Year Km", TypeName = "decimal(13, 5)")]
        public decimal? LastYearKm { get; set; }
        [Column("Last Year Maintenance", TypeName = "decimal(13, 8)")]
        public decimal? LastYearMaintenance { get; set; }
        [Column("Last Year Repair", TypeName = "decimal(13, 8)")]
        public decimal? LastYearRepair { get; set; }
        [Column("Licence Expiry Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LicenceExpiryDate { get; set; }
        [Column("Licence Fee", TypeName = "decimal(13, 6)")]
        public decimal? LicenceFee { get; set; }
        [Column("Loc Or Lot")]
        [StringLength(45)]
        public string? LocOrLot { get; set; }
        [StringLength(25)]
        public string? Maker { get; set; }
        [Column("Max Height", TypeName = "decimal(13, 4)")]
        public decimal? MaxHeight { get; set; }
        [Column("Max Length", TypeName = "decimal(13, 4)")]
        public decimal? MaxLength { get; set; }
        [Column("Max Load Weight", TypeName = "decimal(13, 4)")]
        public decimal? MaxLoadWeight { get; set; }
        [Column("Max Width", TypeName = "decimal(13, 4)")]
        public decimal? MaxWidth { get; set; }
        [Column("Meter Reading", TypeName = "decimal(18, 0)")]
        public decimal? MeterReading { get; set; }
        [StringLength(25)]
        public string? Model { get; set; }
        [Column("Month To Date Billed 01")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateBilled01 { get; set; }
        [Column("Month To Date Billed 02")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateBilled02 { get; set; }
        [Column("Month To Date Billed 03")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateBilled03 { get; set; }
        [Column("Month To Date Billed 04")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateBilled04 { get; set; }
        [Column("Month To Date Billed 05")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateBilled05 { get; set; }
        [Column("Month To Date Billed 06")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateBilled06 { get; set; }
        [Column("Month To Date Billed 07")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateBilled07 { get; set; }
        [Column("Month To Date Billed 08")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateBilled08 { get; set; }
        [Column("Month To Date Billed 09")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateBilled09 { get; set; }
        [Column("Month To Date Billed 10")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateBilled10 { get; set; }
        [Column("Month To Date Billed 11")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateBilled11 { get; set; }
        [Column("Month To Date Billed 12")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateBilled12 { get; set; }
        [Column("Month To Date Fuel Cost 01")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateFuelCost01 { get; set; }
        [Column("Month To Date Fuel Cost 02")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateFuelCost02 { get; set; }
        [Column("Month To Date Fuel Cost 03")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateFuelCost03 { get; set; }
        [Column("Month To Date Fuel Cost 04")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateFuelCost04 { get; set; }
        [Column("Month To Date Fuel Cost 05")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateFuelCost05 { get; set; }
        [Column("Month To Date Fuel Cost 06")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateFuelCost06 { get; set; }
        [Column("Month To Date Fuel Cost 07")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateFuelCost07 { get; set; }
        [Column("Month To Date Fuel Cost 08")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateFuelCost08 { get; set; }
        [Column("Month To Date Fuel Cost 09")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateFuelCost09 { get; set; }
        [Column("Month To Date Fuel Cost 10")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateFuelCost10 { get; set; }
        [Column("Month To Date Fuel Cost 11")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateFuelCost11 { get; set; }
        [Column("Month To Date Fuel Cost 12")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateFuelCost12 { get; set; }
        [Column("Month To Date Hrs 01")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateHrs01 { get; set; }
        [Column("Month To Date Hrs 02")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateHrs02 { get; set; }
        [Column("Month To Date Hrs 03")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateHrs03 { get; set; }
        [Column("Month To Date Hrs 04")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateHrs04 { get; set; }
        [Column("Month To Date Hrs 05")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateHrs05 { get; set; }
        [Column("Month To Date Hrs 06")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateHrs06 { get; set; }
        [Column("Month To Date Hrs 07")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateHrs07 { get; set; }
        [Column("Month To Date Hrs 08")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateHrs08 { get; set; }
        [Column("Month To Date Hrs 09")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateHrs09 { get; set; }
        [Column("Month To Date Hrs 10")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateHrs10 { get; set; }
        [Column("Month To Date Hrs 11")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateHrs11 { get; set; }
        [Column("Month To Date Hrs 12")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateHrs12 { get; set; }
        [Column("Month To Date Km 01")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateKm01 { get; set; }
        [Column("Month To Date Km 02")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateKm02 { get; set; }
        [Column("Month To Date Km 03")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateKm03 { get; set; }
        [Column("Month To Date Km 04")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateKm04 { get; set; }
        [Column("Month To Date Km 05")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateKm05 { get; set; }
        [Column("Month To Date Km 06")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateKm06 { get; set; }
        [Column("Month To Date Km 07")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateKm07 { get; set; }
        [Column("Month To Date Km 08")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateKm08 { get; set; }
        [Column("Month To Date Km 09")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateKm09 { get; set; }
        [Column("Month To Date Km 10")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateKm10 { get; set; }
        [Column("Month To Date Km 11")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateKm11 { get; set; }
        [Column("Month To Date Km 12")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateKm12 { get; set; }
        [Column("Month To Date Maintenance 01")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateMaintenance01 { get; set; }
        [Column("Month To Date Maintenance 02")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateMaintenance02 { get; set; }
        [Column("Month To Date Maintenance 03")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateMaintenance03 { get; set; }
        [Column("Month To Date Maintenance 04")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateMaintenance04 { get; set; }
        [Column("Month To Date Maintenance 05")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateMaintenance05 { get; set; }
        [Column("Month To Date Maintenance 06")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateMaintenance06 { get; set; }
        [Column("Month To Date Maintenance 07")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateMaintenance07 { get; set; }
        [Column("Month To Date Maintenance 08")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateMaintenance08 { get; set; }
        [Column("Month To Date Maintenance 09")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateMaintenance09 { get; set; }
        [Column("Month To Date Maintenance 10")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateMaintenance10 { get; set; }
        [Column("Month To Date Maintenance 11")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateMaintenance11 { get; set; }
        [Column("Month To Date Maintenance 12")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateMaintenance12 { get; set; }
        [Column("Month To Date Repair 01")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateRepair01 { get; set; }
        [Column("Month To Date Repair 02")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateRepair02 { get; set; }
        [Column("Month To Date Repair 03")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateRepair03 { get; set; }
        [Column("Month To Date Repair 04")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateRepair04 { get; set; }
        [Column("Month To Date Repair 05")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateRepair05 { get; set; }
        [Column("Month To Date Repair 06")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateRepair06 { get; set; }
        [Column("Month To Date Repair 07")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateRepair07 { get; set; }
        [Column("Month To Date Repair 08")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateRepair08 { get; set; }
        [Column("Month To Date Repair 09")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateRepair09 { get; set; }
        [Column("Month To Date Repair 10")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateRepair10 { get; set; }
        [Column("Month To Date Repair 11")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateRepair11 { get; set; }
        [Column("Month To Date Repair 12")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MonthToDateRepair12 { get; set; }
        [StringLength(50)]
        public string? Name { get; set; }
        [StringLength(255)]
        public string? Note { get; set; }
        [Column("Owner Code")]
        [StringLength(10)]
        public string? OwnerCode { get; set; }
        [Column("Owner Name")]
        [StringLength(80)]
        public string? OwnerName { get; set; }
        [Column("Owner Address 1")]
        [StringLength(50)]
        public string? OwnerAddress1 { get; set; }
        [Column("Owner Address 2")]
        [StringLength(50)]
        public string? OwnerAddress2 { get; set; }
        [Column("Owner Address 3")]
        [StringLength(50)]
        public string? OwnerAddress3 { get; set; }
        [Column("Owner Address 4")]
        [StringLength(50)]
        public string? OwnerAddress4 { get; set; }
        [Column("Policy No")]
        [StringLength(30)]
        public string? PolicyNo { get; set; }
        [Column("Purchase Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? PurchaseDate { get; set; }
        [Column("Purchase Insurance", TypeName = "decimal(13, 6)")]
        public decimal? PurchaseInsurance { get; set; }
        [Column("Purchase Price", TypeName = "decimal(13, 7)")]
        public decimal? PurchasePrice { get; set; }
        [Column("Purchase Registration")]
        [StringLength(50)]
        public string? PurchaseRegistration { get; set; }
        [Column("Registration Effective Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? RegistrationEffectiveDate { get; set; }
        [Column("Registration Expiry Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? RegistrationExpiryDate { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Road Tax Eff Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? RoadTaxEffDate { get; set; }
        [Column("Road Tax Exp Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? RoadTaxExpDate { get; set; }
        [Column("Road Tax No")]
        [StringLength(50)]
        public string? RoadTaxNo { get; set; }
        [Column("Scope Of Cover")]
        [StringLength(50)]
        public string? ScopeOfCover { get; set; }
        [Column("Serial No")]
        [StringLength(50)]
        public string? SerialNo { get; set; }
        [Column("Vehicle Type")]
        [StringLength(6)]
        public string? VehicleType { get; set; }
        [Column("VP Certificate Company Name")]
        [StringLength(50)]
        public string? VpCertificateCompanyName { get; set; }
        [Column("VP Certificate No")]
        [StringLength(20)]
        public string? VpCertificateNo { get; set; }
        [StringLength(4)]
        public string? Year { get; set; }
        [Column("Year To Date Billed")]
        [StringLength(10)]
        [Unicode(false)]
        public string? YearToDateBilled { get; set; }
        [Column("Year To Date Fuel")]
        [StringLength(10)]
        [Unicode(false)]
        public string? YearToDateFuel { get; set; }
        [Column("Year To Date Hrs")]
        [StringLength(10)]
        [Unicode(false)]
        public string? YearToDateHrs { get; set; }
        [Column("Year To Date Km")]
        [StringLength(10)]
        [Unicode(false)]
        public string? YearToDateKm { get; set; }
        [Column("Year To Date Maintenance")]
        [StringLength(10)]
        [Unicode(false)]
        public string? YearToDateMaintenance { get; set; }
        [Column("Year To Date Repair")]
        [StringLength(10)]
        [Unicode(false)]
        public string? YearToDateRepair { get; set; }
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
