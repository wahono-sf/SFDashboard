using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwJmjt1
    {
        [Column("Job Type")]
        [StringLength(10)]
        public string JobType { get; set; } = null!;
        [Column("Job Description")]
        [StringLength(50)]
        public string? JobDescription { get; set; }
        [Column("AR Acc Code")]
        [StringLength(15)]
        public string? ArAccCode { get; set; }
        [Column("AR Adv Acc Code")]
        [StringLength(15)]
        public string? ArAdvAccCode { get; set; }
        [Column("AR Sup Acc Code")]
        [StringLength(15)]
        public string? ArSupAccCode { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Branch Code")]
        [StringLength(10)]
        public string? BranchCode { get; set; }
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
