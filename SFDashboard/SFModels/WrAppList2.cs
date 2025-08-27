using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("wrAppList2")]
    public partial class WrAppList2
    {
        [Key]
        [StringLength(30)]
        public string NodeName { get; set; } = null!;
        [Key]
        public int LineItemNo { get; set; }
        [StringLength(1)]
        public string? Alert { get; set; }
        [Column("ALertType")]
        [StringLength(1)]
        public string? AlertType { get; set; }
        [StringLength(255)]
        public string? AlertUserId { get; set; }
        [StringLength(50)]
        public string? ConditionName { get; set; }
        [StringLength(255)]
        public string? Message { get; set; }
        [StringLength(255)]
        public string? OrderBy { get; set; }
        [StringLength(2000)]
        public string? ViewCondition { get; set; }
    }
}
