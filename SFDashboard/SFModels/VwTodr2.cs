using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwTodr2
    {
        [Column("Line Item No")]
        public int LineItemNo { get; set; }
        [Column("Driver Code")]
        [StringLength(15)]
        public string DriverCode { get; set; } = null!;
        [StringLength(50)]
        public string? Description { get; set; }
        [Column("Leave Date From", TypeName = "datetime")]
        public DateTime? LeaveDateFrom { get; set; }
        [Column("Leave Date To", TypeName = "datetime")]
        public DateTime? LeaveDateTo { get; set; }
        [Column("Leave Type")]
        [StringLength(2)]
        public string? LeaveType { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
    }
}
