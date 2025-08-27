using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwOmlc1
    {
        [Column("License No")]
        [StringLength(8)]
        public string LicenseNo { get; set; } = null!;
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Expiry Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ExpiryDate { get; set; }
        [Column("License Info 1")]
        [StringLength(36)]
        public string? LicenseInfo1 { get; set; }
        [Column("License Info 2")]
        [StringLength(36)]
        public string? LicenseInfo2 { get; set; }
        [Column("License Info 3")]
        [StringLength(36)]
        public string? LicenseInfo3 { get; set; }
        [Column("License Info 4")]
        [StringLength(36)]
        public string? LicenseInfo4 { get; set; }
        [Column("License Info 5")]
        [StringLength(36)]
        public string? LicenseInfo5 { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
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
