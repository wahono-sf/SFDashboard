using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwTosh1
    {
        [StringLength(50)]
        public string? Area { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Cargo Type")]
        [StringLength(3)]
        public string? CargoType { get; set; }
        [Column("City Code")]
        [StringLength(3)]
        public string? CityCode { get; set; }
        [Column("City Name")]
        [StringLength(45)]
        public string? CityName { get; set; }
        [Column("Company Seal No")]
        [StringLength(1000)]
        public string? CompanySealNo { get; set; }
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
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Customer Seal No")]
        [StringLength(30)]
        public string? CustomerSealNo { get; set; }
        [Column("Description 1")]
        [StringLength(50)]
        public string? Description1 { get; set; }
        [Column("Description 2")]
        [StringLength(50)]
        public string? Description2 { get; set; }
        [Column("Driver Code")]
        [StringLength(15)]
        public string? DriverCode { get; set; }
        [Column("Eta Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? EtaDate { get; set; }
        [Column("Job Type")]
        [StringLength(500)]
        public string? JobType { get; set; }
        [Column("Location Code")]
        [StringLength(10)]
        public string? LocationCode { get; set; }
        [Column("No Of 20ft Container")]
        public int? NoOf20ftContainer { get; set; }
        [Column("No Of 40ft Container")]
        public int? NoOf40ftContainer { get; set; }
        [Column("No Of 45ft Container")]
        public int? NoOf45ftContainer { get; set; }
        [Column("No Of Container 1")]
        public int? NoOfContainer1 { get; set; }
        [Column("No Of Container 2")]
        public int? NoOfContainer2 { get; set; }
        [Column("No Of Container 3")]
        public int? NoOfContainer3 { get; set; }
        [Column("No Of Container 4")]
        public int? NoOfContainer4 { get; set; }
        [StringLength(255)]
        public string? Note { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Schedule Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ScheduleDate { get; set; }
        [Column("Schedule ID")]
        [StringLength(10)]
        public string ScheduleId { get; set; } = null!;
        [Column("Schedule Type")]
        [StringLength(10)]
        public string? ScheduleType { get; set; }
        [Column("Trailer No")]
        [StringLength(255)]
        public string? TrailerNo { get; set; }
        [Column("Truck Departure Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? TruckDepartureDate { get; set; }
        [Column("Truck No")]
        [StringLength(50)]
        public string? TruckNo { get; set; }
        [Column("Ucr No")]
        [StringLength(50)]
        public string? UcrNo { get; set; }
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
