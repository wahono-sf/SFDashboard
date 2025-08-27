using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwTobk3
    {
        [Column("Booking No")]
        [StringLength(10)]
        public string BookingNo { get; set; } = null!;
        [Column("Booking Line Item No")]
        public short BookingLineItemNo { get; set; }
        [Column("Line Item No")]
        public short LineItemNo { get; set; }
        [Column("Collect From Code")]
        [StringLength(10)]
        public string? CollectFromCode { get; set; }
        [Column("Collect From Name")]
        [StringLength(100)]
        public string? CollectFromName { get; set; }
        [Column("Collect From Address 1")]
        [StringLength(50)]
        public string? CollectFromAddress1 { get; set; }
        [Column("Collect From Address 2")]
        [StringLength(50)]
        public string? CollectFromAddress2 { get; set; }
        [Column("Collect From Address 3")]
        [StringLength(50)]
        public string? CollectFromAddress3 { get; set; }
        [Column("Collect From Address 4")]
        [StringLength(50)]
        public string? CollectFromAddress4 { get; set; }
        [Column("Collect From Contact Name")]
        [StringLength(50)]
        public string? CollectFromContactName { get; set; }
        [Column("Collect From Contact Telephone")]
        [StringLength(30)]
        public string? CollectFromContactTelephone { get; set; }
        [Column("Collect From City Code")]
        [StringLength(3)]
        public string? CollectFromCityCode { get; set; }
        [Column("Collect From City Name")]
        [StringLength(45)]
        public string? CollectFromCityName { get; set; }
        [Column("Collect From Place Code")]
        [StringLength(10)]
        public string? CollectFromPlaceCode { get; set; }
        [Column("Collect From Postal")]
        [StringLength(10)]
        public string? CollectFromPostal { get; set; }
        [Column("Collect From Zone")]
        [StringLength(10)]
        public string? CollectFromZone { get; set; }
        [Column("Deliver Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? DeliverDateTime { get; set; }
        [Column("Deliver To Code")]
        [StringLength(10)]
        public string? DeliverToCode { get; set; }
        [Column("Deliver To Name")]
        [StringLength(100)]
        public string? DeliverToName { get; set; }
        [Column("Deliver To Address 1")]
        [StringLength(50)]
        public string? DeliverToAddress1 { get; set; }
        [Column("Deliver To Address 2")]
        [StringLength(50)]
        public string? DeliverToAddress2 { get; set; }
        [Column("Deliver To Address 3")]
        [StringLength(50)]
        public string? DeliverToAddress3 { get; set; }
        [Column("Deliver To Address 4")]
        [StringLength(50)]
        public string? DeliverToAddress4 { get; set; }
        [Column("Deliver To Contact Name")]
        [StringLength(50)]
        public string? DeliverToContactName { get; set; }
        [Column("Deliver To Contact Telephone")]
        [StringLength(30)]
        public string? DeliverToContactTelephone { get; set; }
        [Column("Deliver To City Code")]
        [StringLength(3)]
        public string? DeliverToCityCode { get; set; }
        [Column("Deliver To City Name")]
        [StringLength(45)]
        public string? DeliverToCityName { get; set; }
        [Column("Deliver To Place Code")]
        [StringLength(10)]
        public string? DeliverToPlaceCode { get; set; }
        [Column("Deliver To Postal")]
        [StringLength(10)]
        public string? DeliverToPostal { get; set; }
        [Column("Deliver To Zone")]
        [StringLength(10)]
        public string? DeliverToZone { get; set; }
        [StringLength(100)]
        public string? Description { get; set; }
        [Column("Driver Code")]
        [StringLength(15)]
        public string? DriverCode { get; set; }
        [Column("Driver Name")]
        [StringLength(45)]
        public string? DriverName { get; set; }
        [Column("Driver Contact No")]
        [StringLength(30)]
        public string? DriverContactNo { get; set; }
        [StringLength(100)]
        public string? Instructions { get; set; }
        [Column("Order Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? OrderDate { get; set; }
        [Column("Order No")]
        [StringLength(50)]
        public string? OrderNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Schedule Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ScheduleDate { get; set; }
        [StringLength(10)]
        public string? Status { get; set; }
        [Column("Trailer Max Laden Weight", TypeName = "decimal(13, 4)")]
        public decimal? TrailerMaxLadenWeight { get; set; }
        [Column("Trailer No")]
        [StringLength(12)]
        public string? TrailerNo { get; set; }
        [Column("Trailer Park At")]
        [StringLength(100)]
        public string? TrailerParkAt { get; set; }
        [Column("Trip Add Amt", TypeName = "decimal(13, 2)")]
        public decimal? TripAddAmt { get; set; }
        [Column("Trip Amt", TypeName = "decimal(13, 2)")]
        public decimal? TripAmt { get; set; }
        [Column("Trip Type")]
        [StringLength(25)]
        public string? TripType { get; set; }
        [Column("Trip Weightage", TypeName = "decimal(18, 1)")]
        public decimal? TripWeightage { get; set; }
        [Column("Truck In Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? TruckInDateTime { get; set; }
        [Column("Vehicle No")]
        [StringLength(12)]
        public string? VehicleNo { get; set; }
        [Column("Vehicle Type")]
        [StringLength(10)]
        public string? VehicleType { get; set; }
    }
}
