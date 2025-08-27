using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("toac1")]
    public partial class Toac1
    {
        [Key]
        [StringLength(25)]
        public string ActivityCode { get; set; } = null!;
        [StringLength(50)]
        public string? ActivityDescription { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(1)]
        public string? ReqDocFlag { get; set; }
        [StringLength(1)]
        public string? ScheduleFlag { get; set; }
        public int? SortOrder { get; set; }
        public int? TotalDropPoint { get; set; }
        [StringLength(1)]
        public string? TransportFlag { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? TripColour1 { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? TripColour2 { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? TripColour3 { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? TripColour4 { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? TripColour5 { get; set; }
        [StringLength(25)]
        public string? TripType1 { get; set; }
        [StringLength(25)]
        public string? TripType2 { get; set; }
        [StringLength(25)]
        public string? TripType3 { get; set; }
        [StringLength(25)]
        public string? TripType4 { get; set; }
        [StringLength(25)]
        public string? TripType5 { get; set; }
        [Column(TypeName = "decimal(18, 1)")]
        public decimal? TripWeightage { get; set; }
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
