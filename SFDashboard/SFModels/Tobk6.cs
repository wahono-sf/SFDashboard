using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("tobk6")]
    public partial class Tobk6
    {
        [Key]
        [StringLength(10)]
        public string BookingNo { get; set; } = null!;
        [Key]
        public short LineItemNo { get; set; }
        public short? BookingLineItemNo { get; set; }
        public short? ScheduleLineItemNo { get; set; }
        [StringLength(25)]
        public string? ActivityCode { get; set; }
        [StringLength(3)]
        public string? ActivityStatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CompletionDateTime { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EstCompletionDateTime { get; set; }
        [StringLength(255)]
        public string? Instructions { get; set; }
        [StringLength(50)]
        public string? PersoninCharge { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ScheduleDateTime { get; set; }
        [StringLength(1)]
        public string? ScheduleFlag { get; set; }
    }
}
