using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("sarn1")]
    [Index("ViewName", Name = "IX_Sarn1_1")]
    public partial class Sarn1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(50)]
        public string ViewName { get; set; } = null!;
        [StringLength(200)]
        public string? Caption { get; set; }
        [StringLength(100)]
        public string ColumnName { get; set; } = null!;
    }
}
