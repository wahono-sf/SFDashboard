using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSarn1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("View Name")]
        [StringLength(50)]
        public string ViewName { get; set; } = null!;
        [StringLength(200)]
        public string? Caption { get; set; }
        [Column("Column Name")]
        [StringLength(100)]
        public string ColumnName { get; set; } = null!;
    }
}
