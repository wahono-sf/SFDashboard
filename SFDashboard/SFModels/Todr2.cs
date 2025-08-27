using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("todr2")]
    public partial class Todr2
    {
        [Key]
        [StringLength(15)]
        public string DriverCode { get; set; } = null!;
        [Key]
        public int LineItemNo { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LeaveDateFrom { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LeaveDateTo { get; set; }
        [StringLength(2)]
        public string? LeaveType { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
    }
}
