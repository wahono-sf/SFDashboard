using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwJmje2
    {
        [Column("Event Code")]
        [StringLength(10)]
        public string EventCode { get; set; } = null!;
        [Column("Line Item No")]
        public int LineItemNo { get; set; }
        [Column("Container No Flag")]
        [StringLength(1)]
        public string? ContainerNoFlag { get; set; }
        [Column("Days To Continue")]
        public int? DaysToContinue { get; set; }
        [Column("Days To Send Alert")]
        public int? DaysToSendAlert { get; set; }
        [Column("Default Date To Remark")]
        [StringLength(1)]
        public string? DefaultDateToRemark { get; set; }
        [Column("Done Flag")]
        [StringLength(1)]
        public string? DoneFlag { get; set; }
        [Column("Email Address Flag")]
        [StringLength(1)]
        public string? EmailAddressFlag { get; set; }
        [Column("Insert Next Event Code")]
        [StringLength(255)]
        public string? InsertNextEventCode { get; set; }
        [Column("Insert Next Event Group")]
        [StringLength(255)]
        public string? InsertNextEventGroup { get; set; }
        [Column("Item Name")]
        [StringLength(50)]
        public string? ItemName { get; set; }
        [Column("Item Type")]
        [StringLength(30)]
        public string? ItemType { get; set; }
        [Column("Mobile User")]
        [StringLength(10)]
        public string? MobileUser { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Send Alert Email Flag")]
        [StringLength(1)]
        public string? SendAlertEmailFlag { get; set; }
    }
}
