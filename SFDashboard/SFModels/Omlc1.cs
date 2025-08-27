using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("omlc1")]
    public partial class Omlc1
    {
        [Key]
        [StringLength(8)]
        public string LicenseNo { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime? ExpiryDate { get; set; }
        [StringLength(36)]
        public string? LicenseInfo1 { get; set; }
        [StringLength(36)]
        public string? LicenseInfo2 { get; set; }
        [StringLength(36)]
        public string? LicenseInfo3 { get; set; }
        [StringLength(36)]
        public string? LicenseInfo4 { get; set; }
        [StringLength(36)]
        public string? LicenseInfo5 { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
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
