using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("Glbh2")]
    public partial class Glbh2
    {
        [Key]
        public int LineItemNo { get; set; }
        [Key]
        [StringLength(10)]
        public string BranchCode { get; set; } = null!;
        [StringLength(10)]
        public string? DepartmentCode { get; set; }
    }
}
