using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwWrGridFlag
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Ageing Date")]
        [StringLength(100)]
        public string? AgeingDate { get; set; }
        [Column("Customer Flag")]
        [StringLength(1)]
        public string? CustomerFlag { get; set; }
        [Column("Daily Cycle")]
        public int? DailyCycle { get; set; }
        [StringLength(255)]
        public string? Email { get; set; }
        [Column("Email Flag")]
        [StringLength(1)]
        public string? EmailFlag { get; set; }
        [Column("Filter Condition")]
        [StringLength(100)]
        public string? FilterCondition { get; set; }
        [Column("Flag Code")]
        [StringLength(20)]
        public string FlagCode { get; set; } = null!;
        [Column("Form Name")]
        [StringLength(30)]
        public string? FormName { get; set; }
        [Column("Key Value")]
        [StringLength(50)]
        public string KeyValue { get; set; } = null!;
        [Column("Line Item No")]
        public int LineItemNo { get; set; }
        [StringLength(255)]
        public string? Message { get; set; }
        [Column("Monthly Days List")]
        [StringLength(100)]
        public string? MonthlyDaysList { get; set; }
        [Column("Monthly Days Or On")]
        [StringLength(10)]
        public string? MonthlyDaysOrOn { get; set; }
        [Column("Monthly List")]
        [StringLength(100)]
        public string? MonthlyList { get; set; }
        [Column("Monthly On Week Days List")]
        [StringLength(60)]
        public string? MonthlyOnWeekDaysList { get; set; }
        [Column("Monthly On Week Index")]
        [StringLength(50)]
        public string? MonthlyOnWeekIndex { get; set; }
        [Column("Node Name")]
        [StringLength(30)]
        public string? NodeName { get; set; }
        [Column("Reminder Flag")]
        [StringLength(1)]
        public string? ReminderFlag { get; set; }
        [Column("Reminder Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? ReminderTime { get; set; }
        [Column("Schedule Cycle")]
        [StringLength(1)]
        public string? ScheduleCycle { get; set; }
        [Column("Schedule Date")]
        [StringLength(16)]
        [Unicode(false)]
        public string? ScheduleDate { get; set; }
        [Column("SMS Flag")]
        [StringLength(1)]
        public string? SmsFlag { get; set; }
        [Column("SMS No")]
        [StringLength(255)]
        public string? SmsNo { get; set; }
        [StringLength(50)]
        public string? Subject { get; set; }
        [Column("Type Flag")]
        [StringLength(1)]
        public string? TypeFlag { get; set; }
        [Column("User ID")]
        [StringLength(255)]
        public string? UserId { get; set; }
        [Column("View Name")]
        [StringLength(30)]
        public string ViewName { get; set; } = null!;
        [Column("Weekly Cycle")]
        public int? WeeklyCycle { get; set; }
        [Column("Weekly Days")]
        [StringLength(100)]
        public string? WeeklyDays { get; set; }
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
    }
}
