using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwJmjs1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Back Color")]
        [StringLength(20)]
        public string? BackColor { get; set; }
        [Column("Back Color_A")]
        public int? BackColorA { get; set; }
        [Column("Back Color_B")]
        public int? BackColorB { get; set; }
        [Column("Back Color_G")]
        public int? BackColorG { get; set; }
        [Column("Back Color_R")]
        public int? BackColorR { get; set; }
        [Column("Module Code")]
        [StringLength(2)]
        public string? ModuleCode { get; set; }
        [Column("Job Description")]
        [StringLength(50)]
        public string? JobDescription { get; set; }
        [Column("Job Status Code")]
        [StringLength(10)]
        public string JobStatusCode { get; set; } = null!;
        [Column("Job Track Order")]
        public int? JobTrackOrder { get; set; }
        [Column("Job Type")]
        [StringLength(2)]
        public string? JobType { get; set; }
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
