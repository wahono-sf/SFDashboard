using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwJmje1
    {
        [Column("Event Code")]
        [StringLength(10)]
        public string EventCode { get; set; } = null!;
        [Column("Allow Skip Flag")]
        [StringLength(1)]
        public string? AllowSkipFlag { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Default Email")]
        [StringLength(25)]
        public string? DefaultEmail { get; set; }
        [StringLength(255)]
        public string? Description { get; set; }
        [StringLength(2000)]
        public string? Email { get; set; }
        [Column("Email Upon Completion Flag")]
        [StringLength(1)]
        public string? EmailUponCompletionFlag { get; set; }
        [Column("Etrack Flag")]
        [StringLength(1)]
        public string? EtrackFlag { get; set; }
        [Column("Event Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? EventDate { get; set; }
        [Column("Event Days")]
        public int? EventDays { get; set; }
        [Column("Event Order")]
        public int? EventOrder { get; set; }
        [Column("Event Time")]
        [StringLength(5)]
        [Unicode(false)]
        public string? EventTime { get; set; }
        [Column("Notification Email Address")]
        [StringLength(255)]
        public string? NotificationEmailAddress { get; set; }
        [Column("Notification Email Name")]
        [StringLength(50)]
        public string? NotificationEmailName { get; set; }
        [Column("Ref No")]
        [StringLength(50)]
        public string? RefNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Send Notification Email Flag")]
        [StringLength(1)]
        public string? SendNotificationEmailFlag { get; set; }
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
