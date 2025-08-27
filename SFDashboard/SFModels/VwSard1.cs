using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSard1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Complete Time")]
        [StringLength(255)]
        public string? CompleteTime { get; set; }
        [Column("Complete Value")]
        [StringLength(255)]
        public string? CompleteValue { get; set; }
        [StringLength(255)]
        public string? Email { get; set; }
        [Column("Flag Code")]
        [StringLength(20)]
        public string? FlagCode { get; set; }
        [Column("Form Name")]
        [StringLength(30)]
        public string? FormName { get; set; }
        [StringLength(255)]
        public string? Message { get; set; }
        [Column("Reminder Name")]
        [StringLength(50)]
        public string? ReminderName { get; set; }
        [Column("Reminder Time")]
        [StringLength(255)]
        public string? ReminderTime { get; set; }
        [Column("SMS No")]
        [StringLength(255)]
        public string? SmsNo { get; set; }
        [StringLength(50)]
        public string? Subject { get; set; }
        [Column("User ID")]
        [StringLength(50)]
        public string? UserId { get; set; }
        [Column("Create By")]
        [StringLength(50)]
        public string CreateBy { get; set; } = null!;
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
    }
}
