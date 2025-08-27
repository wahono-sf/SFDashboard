using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("tobk3")]
    public partial class Tobk3
    {
        [Key]
        [StringLength(10)]
        public string BookingNo { get; set; } = null!;
        [Key]
        public short BookingLineItemNo { get; set; }
        [Key]
        public short LineItemNo { get; set; }
        [StringLength(10)]
        public string? CollectFromCode { get; set; }
        [StringLength(100)]
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
        [StringLength(30)]
        public string? CollectFromContactTelephone { get; set; }
        [StringLength(3)]
        public string? CollectFromCityCode { get; set; }
        [StringLength(45)]
        public string? CollectFromCityName { get; set; }
        [StringLength(10)]
        public string? CollectFromPlaceCode { get; set; }
        [StringLength(10)]
        public string? CollectFromPostal { get; set; }
        [StringLength(10)]
        public string? CollectFromZone { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DeliverDateTime { get; set; }
        [StringLength(10)]
        public string? DeliverToCode { get; set; }
        [StringLength(100)]
        public string? DeliverToName { get; set; }
        [StringLength(50)]
        public string? DeliverToAddress1 { get; set; }
        [StringLength(50)]
        public string? DeliverToAddress2 { get; set; }
        [StringLength(50)]
        public string? DeliverToAddress3 { get; set; }
        [StringLength(50)]
        public string? DeliverToAddress4 { get; set; }
        [StringLength(50)]
        public string? DeliverToContactName { get; set; }
        [StringLength(30)]
        public string? DeliverToContactTelephone { get; set; }
        [StringLength(3)]
        public string? DeliverToCityCode { get; set; }
        [StringLength(45)]
        public string? DeliverToCityName { get; set; }
        [StringLength(10)]
        public string? DeliverToPlaceCode { get; set; }
        [StringLength(10)]
        public string? DeliverToPostal { get; set; }
        [StringLength(10)]
        public string? DeliverToZone { get; set; }
        [StringLength(100)]
        public string? Description { get; set; }
        [StringLength(15)]
        public string? DriverCode { get; set; }
        [StringLength(45)]
        public string? DriverName { get; set; }
        [StringLength(30)]
        public string? DriverContactNo { get; set; }
        [StringLength(100)]
        public string? Instructions { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OrderDate { get; set; }
        [StringLength(50)]
        public string? OrderNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ScheduleDate { get; set; }
        [StringLength(10)]
        public string? StatusCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? TrailerMaxLadenWeight { get; set; }
        [StringLength(12)]
        public string? TrailerNo { get; set; }
        [StringLength(100)]
        public string? TrailerParkAt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TripAddAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TripAmt { get; set; }
        [StringLength(25)]
        public string? TripType { get; set; }
        [Column(TypeName = "decimal(18, 1)")]
        public decimal? TripWeightage { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TruckInDateTime { get; set; }
        [StringLength(12)]
        public string? VehicleNo { get; set; }
        [StringLength(10)]
        public string? VehicleType { get; set; }

        [ForeignKey("BookingNo")]
        [InverseProperty("Tobk3s")]
        public virtual Tobk1 BookingNoNavigation { get; set; } = null!;
    }
}
