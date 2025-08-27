using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwWrApplist2
    {
        [Column("Node Name")]
        [StringLength(30)]
        public string NodeName { get; set; } = null!;
        [Column("Line Item No")]
        public int LineItemNo { get; set; }
        [StringLength(1)]
        public string? Alert { get; set; }
        [Column("ALert Type")]
        [StringLength(1)]
        public string? AlertType { get; set; }
        [Column("Alert User ID")]
        [StringLength(255)]
        public string? AlertUserId { get; set; }
        [Column("Condition Name")]
        [StringLength(50)]
        public string? ConditionName { get; set; }
        [StringLength(255)]
        public string? Message { get; set; }
        [Column("Order By")]
        [StringLength(255)]
        public string? OrderBy { get; set; }
        [Column("View Condition")]
        [StringLength(2000)]
        public string? ViewCondition { get; set; }
    }
}
