using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("jmeg1")]
    public partial class Jmeg1
    {
        [Key]
        [StringLength(20)]
        public string GroupCode { get; set; } = null!;
        [StringLength(80)]
        public string? GroupDescription { get; set; }
        [StringLength(1)]
        public string? DefaultFlag { get; set; }
        [StringLength(10)]
        public string? JobType { get; set; }
        [StringLength(2)]
        public string? ModuleCode { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(50)]
        public string CreateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CreateDateTime { get; set; }
        [StringLength(50)]
        public string UpdateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime UpdateDateTime { get; set; }
        [StringLength(3)]
        public string StatusCode { get; set; } = null!;
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
    }
}
