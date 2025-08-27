using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("tosh1")]
    public partial class Tosh1
    {
        [Key]
        [Column("ScheduleID")]
        [StringLength(10)]
        public string ScheduleId { get; set; } = null!;
        [StringLength(50)]
        public string? Area { get; set; }
        [StringLength(3)]
        public string? CargoType { get; set; }
        [StringLength(3)]
        public string? CityCode { get; set; }
        [StringLength(45)]
        public string? CityName { get; set; }
        [StringLength(1000)]
        public string? CompanySealNo { get; set; }
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
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [StringLength(30)]
        public string? CustomerSealNo { get; set; }
        [StringLength(50)]
        public string? Description1 { get; set; }
        [StringLength(50)]
        public string? Description2 { get; set; }
        [StringLength(15)]
        public string? DriverCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EtaDate { get; set; }
        [StringLength(500)]
        public string? JobType { get; set; }
        [StringLength(10)]
        public string? LocationCode { get; set; }
        public int? NoOf20ftContainer { get; set; }
        public int? NoOf40ftContainer { get; set; }
        public int? NoOf45ftContainer { get; set; }
        public int? NoOfContainer1 { get; set; }
        public int? NoOfContainer2 { get; set; }
        public int? NoOfContainer3 { get; set; }
        public int? NoOfContainer4 { get; set; }
        [StringLength(255)]
        public string? Note { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ScheduleDate { get; set; }
        [StringLength(10)]
        public string? ScheduleType { get; set; }
        [StringLength(255)]
        public string? TrailerNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TruckDepartureDate { get; set; }
        [StringLength(50)]
        public string? TruckNo { get; set; }
        [StringLength(50)]
        public string? UcrNo { get; set; }
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
