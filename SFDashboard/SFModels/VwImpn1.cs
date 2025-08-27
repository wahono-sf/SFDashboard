using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwImpn1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [Column("Part No")]
        [StringLength(50)]
        public string PartNo { get; set; } = null!;
        [Column("Product Code")]
        [StringLength(24)]
        public string ProductCode { get; set; } = null!;
        [StringLength(50)]
        public string? Reference { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("User Define 1")]
        [StringLength(50)]
        public string? UserDefine1 { get; set; }
        [Column("User Define 2")]
        [StringLength(50)]
        public string? UserDefine2 { get; set; }
        [Column("User Define 3")]
        [StringLength(50)]
        public string? UserDefine3 { get; set; }
        [Column("Work Station")]
        [StringLength(50)]
        public string? WorkStation { get; set; }
        [Column("Created By")]
        [StringLength(50)]
        public string? CreatedBy { get; set; }
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
        public string? Status { get; set; }
    }
}
