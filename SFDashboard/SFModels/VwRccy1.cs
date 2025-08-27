using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwRccy1
    {
        [Column("Country Code")]
        [StringLength(2)]
        public string CountryCode { get; set; } = null!;
        [Column("Country Name")]
        [StringLength(45)]
        public string? CountryName { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Handling Instruction")]
        [StringLength(3000)]
        public string? HandlingInstruction { get; set; }
        [Column("IDD")]
        [StringLength(4)]
        public string? Idd { get; set; }
        [Column("Flag Image", TypeName = "image")]
        public byte[]? FlagImage { get; set; }
        [Column("Region Code")]
        [StringLength(5)]
        public string? RegionCode { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Special Instruction")]
        [StringLength(3000)]
        public string? SpecialInstruction { get; set; }
        [Column("Zone Code")]
        [StringLength(5)]
        public string? ZoneCode { get; set; }
        [Column("Created By")]
        [StringLength(50)]
        public string CreatedBy { get; set; } = null!;
        [Column("Created At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CreatedAt { get; set; }
        [Column("Updated By")]
        [StringLength(50)]
        public string? UpdatedBy { get; set; }
        [Column("Updated At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? UpdatedAt { get; set; }
        [StringLength(3)]
        public string Status { get; set; } = null!;
    }
}
