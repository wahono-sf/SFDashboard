using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("totc1")]
    public partial class Totc1
    {
        [Key]
        [StringLength(6)]
        public string TripCode { get; set; } = null!;
        [StringLength(45)]
        public string? TripDescription { get; set; }
        [Column(TypeName = "decimal(13, 7)")]
        public decimal? Amt { get; set; }
        [StringLength(15)]
        public string? DriverCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndDateTime { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartDateTime { get; set; }
        [StringLength(12)]
        public string? TrailerNo { get; set; }
        [StringLength(12)]
        public string? VehicleNo { get; set; }
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
