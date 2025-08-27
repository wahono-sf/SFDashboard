using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwRcco1
    {
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Capacity { get; set; }
        [Column("Container Type")]
        [StringLength(5)]
        public string ContainerType { get; set; } = null!;
        [Column("Container Description")]
        [StringLength(50)]
        public string? ContainerDescription { get; set; }
        [Column("Container Size")]
        [StringLength(2)]
        public string? ContainerSize { get; set; }
        [Column("Ext Coat")]
        [StringLength(50)]
        public string? ExtCoat { get; set; }
        [Column("External Breadth", TypeName = "decimal(13, 4)")]
        public decimal? ExternalBreadth { get; set; }
        [Column("External Height", TypeName = "decimal(13, 4)")]
        public decimal? ExternalHeight { get; set; }
        [Column("External Length", TypeName = "decimal(13, 4)")]
        public decimal? ExternalLength { get; set; }
        [Column("Internal Breadth", TypeName = "decimal(13, 4)")]
        public decimal? InternalBreadth { get; set; }
        [Column("Internal Height", TypeName = "decimal(13, 4)")]
        public decimal? InternalHeight { get; set; }
        [Column("Internal Length", TypeName = "decimal(13, 4)")]
        public decimal? InternalLength { get; set; }
        [Column("Iso Size")]
        [StringLength(2)]
        public string? IsoSize { get; set; }
        [StringLength(70)]
        public string? Material { get; set; }
        [Column("Max Cubic Ft", TypeName = "decimal(13, 4)")]
        public decimal? MaxCubicFt { get; set; }
        [Column("Max Payload", TypeName = "decimal(13, 4)")]
        public decimal? MaxPayload { get; set; }
        [Column("Max Volume", TypeName = "decimal(13, 4)")]
        public decimal? MaxVolume { get; set; }
        [Column("Max Weight", TypeName = "decimal(13, 4)")]
        public decimal? MaxWeight { get; set; }
        [Column("Max G Weight", TypeName = "decimal(13, 4)")]
        public decimal? MaxGWeight { get; set; }
        [Column("No Of Teu", TypeName = "decimal(13, 2)")]
        public decimal? NoOfTeu { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Tare Weight", TypeName = "decimal(13, 4)")]
        public decimal? TareWeight { get; set; }
        [Column("Temperature Degree")]
        [StringLength(20)]
        public string? TemperatureDegree { get; set; }
        [Column("Temperature Flag")]
        [StringLength(1)]
        public string? TemperatureFlag { get; set; }
        [Column("Test Press", TypeName = "decimal(5, 2)")]
        public decimal? TestPress { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? Thickness { get; set; }
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
