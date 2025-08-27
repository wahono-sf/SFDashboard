using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwJmeg1
    {
        [Column("Group Code")]
        [StringLength(20)]
        public string GroupCode { get; set; } = null!;
        [Column("Group Description")]
        [StringLength(80)]
        public string? GroupDescription { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Default Flag")]
        [StringLength(1)]
        public string? DefaultFlag { get; set; }
        [Column("Job Type")]
        [StringLength(10)]
        public string? JobType { get; set; }
        [Column("Module Code")]
        [StringLength(2)]
        public string? ModuleCode { get; set; }
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
