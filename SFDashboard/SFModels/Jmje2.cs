using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("jmje2")]
    public partial class Jmje2
    {
        [Key]
        [StringLength(10)]
        public string EventCode { get; set; } = null!;
        [Key]
        public int LineItemNo { get; set; }
        [StringLength(1)]
        public string? ContainerNoFlag { get; set; }
        public int? DaysToContinue { get; set; }
        public int? DaysToSendAlert { get; set; }
        [StringLength(1)]
        public string? DefaultDateToRemark { get; set; }
        [StringLength(1)]
        public string? DoneFlag { get; set; }
        [StringLength(1)]
        public string? EmailAddressFlag { get; set; }
        [StringLength(255)]
        public string? InsertNextEventCode { get; set; }
        [StringLength(255)]
        public string? InsertNextEventGroup { get; set; }
        [StringLength(50)]
        public string? ItemName { get; set; }
        [StringLength(30)]
        public string? ItemType { get; set; }
        [StringLength(10)]
        public string? MobileUser { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(1)]
        public string? SendAlertEmailFlag { get; set; }
    }
}
