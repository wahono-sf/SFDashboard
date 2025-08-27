using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwGlbh2
    {
        [Column("Line Item No")]
        public int LineItemNo { get; set; }
        [Column("Branch Code")]
        [StringLength(10)]
        public string BranchCode { get; set; } = null!;
        [Column("Department Code")]
        [StringLength(10)]
        public string? DepartmentCode { get; set; }
    }
}
