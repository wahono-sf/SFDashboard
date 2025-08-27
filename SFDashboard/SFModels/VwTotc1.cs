using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwTotc1
    {
        [Column("Trip Code")]
        [StringLength(6)]
        public string TripCode { get; set; } = null!;
        [Column("Trip Description")]
        [StringLength(45)]
        public string? TripDescription { get; set; }
        [Column(TypeName = "decimal(13, 7)")]
        public decimal? Amt { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Driver Code")]
        [StringLength(15)]
        public string? DriverCode { get; set; }
        [Column("End Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? EndDateTime { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Start Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? StartDateTime { get; set; }
        [Column("Trailer No")]
        [StringLength(12)]
        public string? TrailerNo { get; set; }
        [Column("Vehicle No")]
        [StringLength(12)]
        public string? VehicleNo { get; set; }
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
