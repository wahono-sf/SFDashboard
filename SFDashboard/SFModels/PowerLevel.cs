using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("PowerLevel")]
    [Index("LRoleId", "SFunNo", "LSubId", Name = "IX_PowerLevel", IsUnique = true)]
    public partial class PowerLevel
    {
        [Key]
        [Column("lRoleId")]
        public int LRoleId { get; set; }
        [Key]
        [Column("sFunNo")]
        [StringLength(10)]
        public string SFunNo { get; set; } = null!;
        [Key]
        [Column("lSubId")]
        public int LSubId { get; set; }
        [StringLength(255)]
        public string? ViewCondition { get; set; }
    }
}
