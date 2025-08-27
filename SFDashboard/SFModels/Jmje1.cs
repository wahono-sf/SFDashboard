using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("jmje1")]
    public partial class Jmje1
    {
        [Key]
        [StringLength(10)]
        public string EventCode { get; set; } = null!;
        [StringLength(1)]
        public string? AllowSkipFlag { get; set; }
        [StringLength(25)]
        public string? DefaultEmail { get; set; }
        [StringLength(255)]
        public string? Description { get; set; }
        [StringLength(2000)]
        public string? Email { get; set; }
        [StringLength(1)]
        public string? EmailUponCompletionFlag { get; set; }
        [StringLength(1)]
        public string? EtrackFlag { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EventDate { get; set; }
        public int? EventDays { get; set; }
        public int? EventOrder { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EventTime { get; set; }
        [StringLength(255)]
        public string? NotificationEmailAddress { get; set; }
        [StringLength(50)]
        public string? NotificationEmailName { get; set; }
        [StringLength(50)]
        public string? RefNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(1)]
        public string? SendNotificationEmailFlag { get; set; }
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
