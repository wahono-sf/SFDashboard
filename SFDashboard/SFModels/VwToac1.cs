using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwToac1
    {
        [Column("Activity Code")]
        [StringLength(25)]
        public string ActivityCode { get; set; } = null!;
        [Column("Activity Description")]
        [StringLength(50)]
        public string? ActivityDescription { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Req Doc Flag")]
        [StringLength(1)]
        public string? ReqDocFlag { get; set; }
        [Column("Schedule Flag")]
        [StringLength(1)]
        public string? ScheduleFlag { get; set; }
        [Column("Sort Order")]
        public int? SortOrder { get; set; }
        [Column("Total Drop Point")]
        public int? TotalDropPoint { get; set; }
        [Column("Transport Flag")]
        [StringLength(1)]
        public string? TransportFlag { get; set; }
        [Column("Trip Colour 1")]
        [StringLength(20)]
        [Unicode(false)]
        public string? TripColour1 { get; set; }
        [Column("Trip Colour 2")]
        [StringLength(20)]
        [Unicode(false)]
        public string? TripColour2 { get; set; }
        [Column("Trip Colour 3")]
        [StringLength(20)]
        [Unicode(false)]
        public string? TripColour3 { get; set; }
        [Column("Trip Colour 4")]
        [StringLength(20)]
        [Unicode(false)]
        public string? TripColour4 { get; set; }
        [Column("Trip Colour 5")]
        [StringLength(20)]
        [Unicode(false)]
        public string? TripColour5 { get; set; }
        [Column("Trip Type 1")]
        [StringLength(25)]
        public string? TripType1 { get; set; }
        [Column("Trip Type 2")]
        [StringLength(25)]
        public string? TripType2 { get; set; }
        [Column("Trip Type 3")]
        [StringLength(25)]
        public string? TripType3 { get; set; }
        [Column("Trip Type 4")]
        [StringLength(25)]
        public string? TripType4 { get; set; }
        [Column("Trip Type 5")]
        [StringLength(25)]
        public string? TripType5 { get; set; }
        [Column("Trip Weightage", TypeName = "decimal(18, 1)")]
        public decimal? TripWeightage { get; set; }
        [StringLength(3)]
        public string Status { get; set; } = null!;
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
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
    }
}
