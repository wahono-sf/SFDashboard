using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("sard1")]
    public partial class Sard1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(255)]
        public string? CompleteTime { get; set; }
        [StringLength(255)]
        public string? CompleteValue { get; set; }
        [StringLength(255)]
        public string? Email { get; set; }
        [StringLength(20)]
        public string? FlagCode { get; set; }
        [StringLength(30)]
        public string? FormName { get; set; }
        [StringLength(255)]
        public string? Message { get; set; }
        [StringLength(50)]
        public string? ReminderName { get; set; }
        [StringLength(255)]
        public string? ReminderTime { get; set; }
        [Column("SMSNo")]
        [StringLength(255)]
        public string? Smsno { get; set; }
        [StringLength(50)]
        public string? Subject { get; set; }
        [Column("UserID")]
        [StringLength(50)]
        public string? UserId { get; set; }
        [StringLength(50)]
        public string CreateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CreateDateTime { get; set; }
        [StringLength(50)]
        public string UpdateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime UpdateDateTime { get; set; }
    }
}
