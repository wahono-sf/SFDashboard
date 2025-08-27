using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwRcum1
    {
        [Column("Uom Code")]
        [StringLength(3)]
        public string UomCode { get; set; } = null!;
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Conversion Factor", TypeName = "decimal(13, 6)")]
        public decimal? ConversionFactor { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Uom Description")]
        [StringLength(50)]
        public string? UomDescription { get; set; }
        [Column("Uom Type")]
        [StringLength(1)]
        public string? UomType { get; set; }
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
