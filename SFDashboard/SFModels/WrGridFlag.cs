using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("wrGridFlag")]
    public partial class WrGridFlag
    {
        [Key]
        public int TrxNo { get; set; }
        public int LineItemNo { get; set; }
        [StringLength(100)]
        public string? AgeingDate { get; set; }
        [StringLength(1)]
        public string? CustomerFlag { get; set; }
        public int? DailyCycle { get; set; }
        [StringLength(1000)]
        public string? Email { get; set; }
        [StringLength(1)]
        public string? EmailFlag { get; set; }
        [StringLength(100)]
        public string? FilterCondition { get; set; }
        [StringLength(20)]
        public string FlagCode { get; set; } = null!;
        [StringLength(30)]
        public string? FormName { get; set; }
        [StringLength(50)]
        public string KeyValue { get; set; } = null!;
        [StringLength(255)]
        public string? Message { get; set; }
        [StringLength(100)]
        public string? MonthlyDaysList { get; set; }
        [StringLength(10)]
        public string? MonthlyDaysOrOn { get; set; }
        [StringLength(100)]
        public string? MonthlyList { get; set; }
        [StringLength(60)]
        public string? MonthlyOnWeekDaysList { get; set; }
        [StringLength(50)]
        public string? MonthlyOnWeekIndex { get; set; }
        [StringLength(30)]
        public string? NodeName { get; set; }
        [StringLength(1)]
        public string? ReminderFlag { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReminderTime { get; set; }
        [StringLength(1)]
        public string? ScheduleCycle { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ScheduleDate { get; set; }
        [Column("SMSFlag")]
        [StringLength(1)]
        public string? Smsflag { get; set; }
        [Column("SMSNo")]
        [StringLength(255)]
        public string? Smsno { get; set; }
        [StringLength(50)]
        public string? Subject { get; set; }
        [StringLength(1)]
        public string? TypeFlag { get; set; }
        [Column("UserID")]
        [StringLength(255)]
        public string? UserId { get; set; }
        [StringLength(30)]
        public string ViewName { get; set; } = null!;
        public int? WeeklyCycle { get; set; }
        [StringLength(100)]
        public string? WeeklyDays { get; set; }
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
