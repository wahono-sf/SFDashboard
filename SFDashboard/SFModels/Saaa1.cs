using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("saaa1")]
    public partial class Saaa1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(1000)]
        public string? Condition { get; set; }
        [StringLength(400)]
        public string? Email { get; set; }
        [StringLength(2000)]
        public string? Message { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReminderTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ScheduleDate { get; set; }
        [StringLength(100)]
        public string? Subject { get; set; }
        [Column("ToUserID")]
        [StringLength(200)]
        public string? ToUserId { get; set; }
        [StringLength(50)]
        public string? ViewName { get; set; }
        [StringLength(3)]
        public string StatusCode { get; set; } = null!;
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
