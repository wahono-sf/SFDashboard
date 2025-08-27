using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwTobk6
    {
        [Column("Booking No")]
        [StringLength(10)]
        public string BookingNo { get; set; } = null!;
        [Column("Line Item No")]
        public int LineItemNo { get; set; }
        [Column("Booking Line Item No")]
        public int? BookingLineItemNo { get; set; }
        [Column("Schedule Line Item No")]
        public int? ScheduleLineItemNo { get; set; }
        [Column("Activity Code")]
        [StringLength(25)]
        public string? ActivityCode { get; set; }
        [Column("Activity Status")]
        [StringLength(3)]
        public string? ActivityStatus { get; set; }
        [Column("Completion Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CompletionDateTime { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [Column("Est Completion Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? EstCompletionDateTime { get; set; }
        [StringLength(255)]
        public string? Instructions { get; set; }
        [Column("Personin Charge")]
        [StringLength(50)]
        public string? PersoninCharge { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Schedule Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? ScheduleDateTime { get; set; }
        [Column("Schedule Flag")]
        [StringLength(1)]
        public string? ScheduleFlag { get; set; }
    }
}
