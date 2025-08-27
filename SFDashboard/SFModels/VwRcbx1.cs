using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwRcbx1
    {
        [Column("Box Code")]
        [StringLength(5)]
        public string BoxCode { get; set; } = null!;
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [Column("Dest Code")]
        [StringLength(50)]
        public string? DestCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Price { get; set; }
        [Column(TypeName = "decimal(9, 4)")]
        public decimal? Weight { get; set; }
        [Column(TypeName = "decimal(9, 4)")]
        public decimal? Volume { get; set; }
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
