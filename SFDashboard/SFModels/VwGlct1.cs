using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwGlct1
    {
        [Column("Contract Code")]
        [StringLength(20)]
        public string ContractCode { get; set; } = null!;
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Contract Description")]
        [StringLength(100)]
        public string? ContractDescription { get; set; }
        [Column("Customer Code")]
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [Column("User Define 01")]
        [StringLength(100)]
        public string? UserDefine01 { get; set; }
        [Column("User Define 02")]
        [StringLength(100)]
        public string? UserDefine02 { get; set; }
        [Column("User Define 03")]
        [StringLength(100)]
        public string? UserDefine03 { get; set; }
        [Column("User Define 04")]
        [StringLength(100)]
        public string? UserDefine04 { get; set; }
        [Column("User Define 05")]
        [StringLength(100)]
        public string? UserDefine05 { get; set; }
        [Column("User Define 06")]
        [StringLength(100)]
        public string? UserDefine06 { get; set; }
        [Column("User Define 07")]
        [StringLength(100)]
        public string? UserDefine07 { get; set; }
        [Column("User Define 08")]
        [StringLength(100)]
        public string? UserDefine08 { get; set; }
        [Column("User Define 09")]
        [StringLength(100)]
        public string? UserDefine09 { get; set; }
        [Column("User Define 10")]
        [StringLength(100)]
        public string? UserDefine10 { get; set; }
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
