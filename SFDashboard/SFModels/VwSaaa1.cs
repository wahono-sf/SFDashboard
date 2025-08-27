using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSaaa1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [StringLength(1000)]
        public string? Condition { get; set; }
        [StringLength(400)]
        public string? Email { get; set; }
        [StringLength(2000)]
        public string? Message { get; set; }
        [Column("Reminder Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? ReminderTime { get; set; }
        [Column("Schedule Date")]
        [StringLength(16)]
        [Unicode(false)]
        public string? ScheduleDate { get; set; }
        [StringLength(100)]
        public string? Subject { get; set; }
        [Column("To User ID")]
        [StringLength(200)]
        public string? ToUserId { get; set; }
        [Column("View Name")]
        [StringLength(50)]
        public string? ViewName { get; set; }
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
