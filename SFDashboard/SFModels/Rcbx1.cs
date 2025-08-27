using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("rcbx1")]
    public partial class Rcbx1
    {
        [Key]
        [StringLength(5)]
        public string BoxCode { get; set; } = null!;
        [StringLength(50)]
        public string? Description { get; set; }
        [StringLength(50)]
        public string? DestCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Price { get; set; }
        [Column(TypeName = "decimal(9, 4)")]
        public decimal? Weight { get; set; }
        [Column(TypeName = "decimal(9, 4)")]
        public decimal? Volume { get; set; }
        [StringLength(50)]
        public string CreateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CreateDateTime { get; set; }
        [StringLength(50)]
        public string UpdateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime UpdateDateTime { get; set; }
        [StringLength(3)]
        public string StatusCode { get; set; } = null!;
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
    }
}
